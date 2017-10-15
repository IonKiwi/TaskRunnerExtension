using EnvDTE;
using EnvDTE80;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TaskRunnerExplorer;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TaskRunnerExtension {

	[Export(typeof(ITaskRunnerOutputListener))]
	[Name("TaskRunnerExtension.ErrorListOutputListener")]
	[Order(Before = "Microsoft.VisualStudio.TaskRunnerExplorer.TaskRunnerConsoles")]
	public class TaskOutputListener : ITaskRunnerOutputListener, IVsSolutionEvents {

		private readonly Regex _colorRegex;
		private readonly IEnumerable<Regex> _errorMatchRegexes;
		private readonly DTE2 _dte;
		private readonly Events _events;
		private readonly BuildEvents _buildEvents;
		private readonly IVsSolution _vsSolution;
		private readonly OutputErrorsFactory _factory;
		private IErrorListProvider _errorProvider;
		private bool _isFirstLine;

		[ImportingConstructor]
		internal TaskOutputListener(IErrorListProvider errorProvider) {
			_dte = (DTE2)Package.GetGlobalService(typeof(DTE));
			_colorRegex = new Regex(@"\u001b\[\d+m");
			_errorMatchRegexes = new List<Regex> {
				new Regex(@"^(?<file>([a-z]:)[^:]+): line (?<line>[0-9]+), col (?<column>[0-9]+), (?<severity>[\w]+) - (?<message>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled),
				new Regex(@"^(?<file>.+)\((?<line>[0-9]+),(?<column>[0-9]+)\): (?<severity>\w[\w]*)[\s]+(?<category>\w[\w]*): (?<message>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled),
				new Regex(@"^(?<file>.+)\((?<line>[0-9]+),(?<column>[0-9]+)\): (?<severity>\w[\w\s]*): (?<message>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled),
			};

			_errorProvider = errorProvider;
			_factory = new OutputErrorsFactory(_errorProvider);

			uint solutionEventsCookie;
			_vsSolution = (IVsSolution)ServiceProvider.GlobalProvider.GetService(typeof(SVsSolution));
			_vsSolution.AdviseSolutionEvents(this, out solutionEventsCookie);

			_events = _dte.Events;
			_buildEvents = _events.BuildEvents;
			_buildEvents.OnBuildBegin += BuildBegin;
			_buildEvents.OnBuildDone += BuildDone;

			Initialize();
		}

		private void BuildDone(vsBuildScope Scope, vsBuildAction Action) {
			_isFirstLine = true;
		}

		private void BuildBegin(vsBuildScope Scope, vsBuildAction Action) {
			_isFirstLine = true;
			RemoveErrors();
		}

		internal void UpdateErrorsList() {
			// tell the provider to mark all the sinks dirty (so, as a side-effect, they will start an update pass that will get the new snapshot
			// from the factory).
			_errorProvider.UpdateAllSinks(_factory);
		}

		public void Initialize() {
			// ataches the Factory to the error provider
			_errorProvider.AddErrorListFactory(_factory);
		}

		public void RemoveErrors() {
			_factory.ClearErrors();
		}

		private void ShowMessage(string message) {
			IVsOutputWindow outWindow = (IVsOutputWindow)Package.GetGlobalService(typeof(SVsOutputWindow));
			Guid generalPaneGuid = VSConstants.GUID_OutWindowGeneralPane;
			IVsOutputWindowPane generalPane;
			outWindow.GetPane(ref generalPaneGuid, out generalPane);
			if (generalPane == null) {
				outWindow.CreatePane(ref generalPaneGuid, "TaskRunnerExtension", 1, 1);
				outWindow.GetPane(ref generalPaneGuid, out generalPane);
			}
			if (_isFirstLine) {
				generalPane.Clear();
				_isFirstLine = false;
			}
			generalPane.OutputString(message);
			generalPane.Activate();
		}

		public IEnumerable<string> HandleLines(ITaskRunnerNode task, string projectName, IEnumerable<string> lines) {
			var currentTaskName = task.Name;

			var errorList = new List<IErrorListItem>();
			foreach (var line in lines) {
				var cleanLine = _colorRegex.Replace(line, string.Empty);
				var singleLine = cleanLine.Replace("\r\n", string.Empty);
				if (string.Equals("cancel-build", singleLine, StringComparison.Ordinal)) {
					if (_dte.Solution.SolutionBuild.BuildState == vsBuildState.vsBuildStateInProgress) {
						_dte.ExecuteCommand("Build.Cancel");
					}
					ShowMessage("Build cancellation requested by task: " + currentTaskName);
					break;
				}

				foreach (var regex in _errorMatchRegexes) {
					Match match = regex.Match(singleLine);
					if (!match.Success) {
						continue;
					}

					var descriptor = GetTaskErrorFromMatch(match);
					descriptor.ProjectName = projectName;
					errorList.Add(descriptor);
					break;
				}
				// copy line to custom output pane
				ShowMessage(line);
			}

			OutputErrorSnapshot currentSnapshot = _factory.CurrentSnapshot as OutputErrorSnapshot;
			List<IErrorListItem> newErrors = RemoveErrorDuplicates(task, projectName, errorList, currentSnapshot);

			if (newErrors.Count > 0) {
				_factory.AddErrorItems(newErrors);
				UpdateErrorsList();
			}

			// return the lines for display in the Task Runner Explorer console
			return lines;
		}

		internal static TaskError GetTaskErrorFromMatch(Match match) {
			int line;
			int column;

			int.TryParse(match.Groups["line"].Value, out line);
			int.TryParse(match.Groups["column"].Value, out column);

			return new TaskError {
				Line = line,
				Column = column,
				ErrorCode = match.Groups["code"]?.Value.Trim(),
				Message = match.Groups["message"]?.Value.Trim(),
				Severity = ParseSeverity(match.Groups["severity"]?.Value.Trim()),
				Filename = match.Groups["file"]?.Value.Trim(),
				ErrorCategory = match.Groups["category"]?.Value.Trim(),
			};
		}

		private static MessageSeverity ParseSeverity(string severity) {
			if (!string.IsNullOrWhiteSpace(severity)) {
				if (severity.Equals("error", StringComparison.OrdinalIgnoreCase))
					return MessageSeverity.Error;

				if (severity.Equals("warning", StringComparison.OrdinalIgnoreCase))
					return MessageSeverity.Warning;

				if (severity.Equals("info", StringComparison.OrdinalIgnoreCase))
					return MessageSeverity.Info;
			}

			return MessageSeverity.NoProblems;
		}

		private static List<IErrorListItem> RemoveErrorDuplicates(ITaskRunnerNode task,
																																string projectName,
																																List<IErrorListItem> errorList,
																																OutputErrorSnapshot currentSnapshot) {
			List<IErrorListItem> newErrors = new List<IErrorListItem>();

			foreach (IErrorListItem error in errorList) {
				error.ProjectName = projectName;
				error.ErrorSource = task.Name;
				error.Filename = Path.Combine(task.Command.WorkingDirectory, error.Filename);
				error.Command = task.Command;

				if (!currentSnapshot.Errors.Contains(error)) {
					newErrors.Add(error);
				}
			}

			return newErrors;
		}

		public void Dispose() {
			if (_errorProvider != null) {
				// Detach the Factory from the error provider
				_errorProvider.RemoveErrorListFactory(_factory);
			}

			_factory.Dispose();
		}

		int IVsSolutionEvents.OnAfterOpenProject(IVsHierarchy pHierarchy, int fAdded) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnQueryCloseProject(IVsHierarchy pHierarchy, int fRemoving, ref int pfCancel) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnBeforeCloseProject(IVsHierarchy pHierarchy, int fRemoved) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnAfterLoadProject(IVsHierarchy pStubHierarchy, IVsHierarchy pRealHierarchy) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnQueryUnloadProject(IVsHierarchy pRealHierarchy, ref int pfCancel) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnBeforeUnloadProject(IVsHierarchy pRealHierarchy, IVsHierarchy pStubHierarchy) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnAfterOpenSolution(object pUnkReserved, int fNewSolution) {
			//Initialize();
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnQueryCloseSolution(object pUnkReserved, ref int pfCancel) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnBeforeCloseSolution(object pUnkReserved) {
			return VSConstants.S_OK;
		}

		int IVsSolutionEvents.OnAfterCloseSolution(object pUnkReserved) {
			RemoveErrors();
			return VSConstants.S_OK;
		}
	}
}
