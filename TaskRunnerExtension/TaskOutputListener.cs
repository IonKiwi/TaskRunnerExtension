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
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace TaskRunnerExtension {

	[Export(typeof(ITaskRunnerOutputListener))]
	[Name("TaskRunnerExtension.TaskOutputListener")]
	[Order(After = "Microsoft.WebTools.TaskRunnerExplorer.TaskRunnerConsoles")]
	public class TaskOutputListener : ITaskRunnerOutputListener {

		private readonly Regex _colorRegex;
		private readonly IEnumerable<Regex> _errorMatchRegexes;
		private readonly DTE2 _dte;
		private Dictionary<string, (Guid paneId, IVsOutputWindowPane pane)> _taskPanes = new Dictionary<string, (Guid paneId, IVsOutputWindowPane pane)>(StringComparer.Ordinal);
		private readonly OutputErrorsFactory _factory;
		private readonly IErrorListProvider _errorProvider;
		private readonly EnvDTE.Events _events;
		private readonly EnvDTE.SolutionEvents _solutionEvents;

		[ImportingConstructor]
		internal TaskOutputListener(IErrorListProvider errorProvider) {

			ThreadHelper.ThrowIfNotOnUIThread();

			_dte = (DTE2)Package.GetGlobalService(typeof(EnvDTE.DTE));
			_colorRegex = new Regex(@"\u001b\[\d+m");
			_errorMatchRegexes = new List<Regex> {
				new Regex(@"^(?<file>([a-z]:)[^:]+): line (?<line>[0-9]+), col (?<column>[0-9]+), (?<severity>[\w]+) - (?<message>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled),
				new Regex(@"^(?<file>.+)\((?<line>[0-9]+),(?<column>[0-9]+)\): (?<severity>\w[\w]*)[\s]+(?<category>\w[\w]*): (?<message>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled),
				new Regex(@"^(?<file>.+)\((?<line>[0-9]+),(?<column>[0-9]+)\): (?<severity>\w[\w\s]*): (?<message>.+)", RegexOptions.IgnoreCase | RegexOptions.Compiled),
			};

			_events = _dte.Events;
			_solutionEvents = _events.SolutionEvents;
			_solutionEvents.BeforeClosing += _solutionEvents_BeforeClosing;

			_errorProvider = errorProvider;

			_factory = new OutputErrorsFactory(_errorProvider);

			// ataches the Factory to the error provider
			_errorProvider.AddErrorListFactory(_factory);

			var hostAssembly = typeof(ITaskRunnerOutputListener).Assembly.GetName(false);
			var taskRunnerAssembly = "Microsoft.WebTools.TaskRunnerExplorer, Version=" + hostAssembly.Version + ", Culture=neutral, PublicKeyToken=" + GetHexadecimalString(hostAssembly.GetPublicKeyToken(), false);
			Type t = Type.GetType("Microsoft.WebTools.TaskRunnerExplorer.TaskRunnerExplorerVsPackage, " + taskRunnerAssembly, true);
			var instanceProperty = t.GetProperty("Instance", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
			var taskRunnerManagerProperty = t.GetProperty("TaskRunnerManager", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			var instance = instanceProperty.GetValue(null);
			var taskRunnerManager = taskRunnerManagerProperty.GetValue(instance);
			var consolesProperty = taskRunnerManager.GetType().GetProperty("Consoles", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			var consoles = consolesProperty.GetValue(taskRunnerManager);
			var consolesType = Type.GetType("Microsoft.WebTools.TaskRunnerExplorer.ITaskRunnerConsoles, " + taskRunnerAssembly, true);
			var consoleAddedEvent = consolesType.GetEvent("ConsoleAdded");
			//var consoleRemovedEvent = consolesType.GetEvent("ConsoleRemoved");

			var taskRunnerConsoleAddedEventArgs = Type.GetType("Microsoft.WebTools.TaskRunnerExplorer.TaskRunnerConsoleAddedEventArgs, " + taskRunnerAssembly, true);
			//var taskRunnerConsoleRemovedEventArgs = Type.GetType("Microsoft.WebTools.TaskRunnerExplorer.TaskRunnerConsoleRemovedEventArgs, " + taskRunnerAssembly, true);

			var p1 = Expression.Parameter(typeof(EventArgs), "p1");
			var callMethod = Expression.Call(Expression.Convert(p1, taskRunnerConsoleAddedEventArgs), taskRunnerConsoleAddedEventArgs.GetProperty("Console", BindingFlags.Instance | BindingFlags.Public).GetMethod);
			_taskRunnerConsoleAddedEventArgsGetConsole = Expression.Lambda<Func<EventArgs, object>>(callMethod, p1).Compile();

			//p1 = Expression.Parameter(typeof(EventArgs), "p1");
			//callMethod = Expression.Call(Expression.Convert(p1, taskRunnerConsoleRemovedEventArgs), taskRunnerConsoleRemovedEventArgs.GetProperty("Console", BindingFlags.Instance | BindingFlags.Public).GetMethod);
			//_taskRunnerConsoleRemovedEventArgsGetConsole = Expression.Lambda<Func<EventArgs, object>>(callMethod, p1).Compile();

			var consoleType = Type.GetType("Microsoft.WebTools.TaskRunnerExplorer.ITaskRunnerConsole, " + taskRunnerAssembly, true);
			var consoleTask = consoleType.GetProperty("Task", BindingFlags.Instance | BindingFlags.Public);
			p1 = Expression.Parameter(typeof(object), "p1");
			callMethod = Expression.Call(Expression.Convert(p1, consoleType), consoleTask.GetMethod);
			_getTask = Expression.Lambda<Func<object, ITaskRunnerNode>>(callMethod, p1).Compile();

			//var stateChangedEventArgs = Type.GetType("Microsoft.WebTools.TaskRunnerExplorer.TaskRunnerConsoleStateChangedEventArgs, " + taskRunnerAssembly, true);
			//_stateChangedEvent = consoleType.GetEvent("StateChanged");

			//p1 = Expression.Parameter(typeof(EventArgs), "p1");
			//callMethod = Expression.Call(Expression.Convert(p1, stateChangedEventArgs), stateChangedEventArgs.GetProperty("Console", BindingFlags.Instance | BindingFlags.Public).GetMethod);
			//_taskRunnerConsoleStateChangedEventArgsGetConsole = Expression.Lambda<Func<EventArgs, object>>(callMethod, p1).Compile();

			//p1 = Expression.Parameter(typeof(EventArgs), "p1");
			//callMethod = Expression.Call(Expression.Convert(p1, stateChangedEventArgs), stateChangedEventArgs.GetProperty("State", BindingFlags.Instance | BindingFlags.Public).GetMethod);
			//_taskRunnerConsoleStateChangedEventArgsGetState = Expression.Lambda<Func<EventArgs, int>>(Expression.Convert(callMethod, typeof(int)), p1).Compile();

			consoleAddedEvent.AddEventHandler(consoles, Delegate.CreateDelegate(typeof(EventHandler<>).MakeGenericType(taskRunnerConsoleAddedEventArgs), this, typeof(TaskOutputListener).GetMethod("OnConsoleAdded", BindingFlags.Instance | BindingFlags.NonPublic)));
			//consoleRemovedEvent.AddEventHandler(consoles, Delegate.CreateDelegate(typeof(EventHandler<>).MakeGenericType(taskRunnerConsoleRemovedEventArgs), this, typeof(TaskOutputListener).GetMethod("OnConsoleRemoved", BindingFlags.Instance | BindingFlags.NonPublic)));
			//_onStateChanged = Delegate.CreateDelegate(typeof(EventHandler<>).MakeGenericType(stateChangedEventArgs), this, typeof(TaskOutputListener).GetMethod("OnStateChanged", BindingFlags.Instance | BindingFlags.NonPublic));
		}

		private void _solutionEvents_BeforeClosing() {
			ThreadHelper.ThrowIfNotOnUIThread();

			var paneIds = _taskPanes.Select(z => z.Value.paneId).ToList();
			_taskPanes.Clear();

			IVsOutputWindow outWindow = (IVsOutputWindow)Package.GetGlobalService(typeof(SVsOutputWindow));

			foreach (var paneId in paneIds) {
				Guid currentPaneId = paneId;
				outWindow.DeletePane(ref currentPaneId);
			}
		}

		private Func<EventArgs, object> _taskRunnerConsoleAddedEventArgsGetConsole;
		private Func<object, ITaskRunnerNode> _getTask;

		private void OnConsoleAdded(object sender, EventArgs e) {

			var console = _taskRunnerConsoleAddedEventArgsGetConsole(e);
			var task = _getTask(console);
			//_stateChangedEvent.AddEventHandler(console, _onStateChanged);

			EnsureTaskPane(task.Name, true);
			_factory.ClearErrors(task);

			return;
		}

		private static string GetHexadecimalString(IEnumerable<byte> data, bool upperCase) {
			string format = (upperCase ? "X2" : "x2");
			return data.Aggregate(new StringBuilder(),
				(sb, v) => sb.Append(v.ToString(format))).ToString();
		}

		internal void UpdateErrorsList() {
			// tell the provider to mark all the sinks dirty (so, as a side-effect, they will start an update pass that will get the new snapshot
			// from the factory).
			_errorProvider.UpdateAllSinks(_factory);
		}

		public void RemoveErrors(string taskName) {
			_factory.ClearErrors();
		}

		private IVsOutputWindowPane EnsureTaskPane(string taskName, bool clear) {
			if (!_taskPanes.TryGetValue(taskName, out var paneInfo)) {
				ThreadHelper.JoinableTaskFactory.Run(async () => {
					await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
					IVsOutputWindow outWindow = (IVsOutputWindow)Package.GetGlobalService(typeof(SVsOutputWindow));
					Guid paneGuid = Guid.NewGuid();
					IVsOutputWindowPane pane;
					outWindow.GetPane(ref paneGuid, out pane);
					if (pane == null) {
						outWindow.CreatePane(ref paneGuid, "TaskRunnerExtension - " + taskName, 1, 1);
						outWindow.GetPane(ref paneGuid, out pane);
					}
					_taskPanes.Add(taskName, (paneGuid, pane));
					pane.Activate();
				});
			}
			else if (clear) {
				ThreadHelper.JoinableTaskFactory.Run(async () => {
					await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
					paneInfo.pane.Clear();
					paneInfo.pane.Activate();
				});
			}
			return paneInfo.pane;
		}

		public IEnumerable<string> HandleLines(ITaskRunnerNode task, string projectName, IEnumerable<string> lines) {

			var currentTaskName = task.Name;
			var pane = EnsureTaskPane(currentTaskName, false);

			var errorList = new List<IErrorListItem>();
			foreach (var line in lines) {

				var cleanLine = _colorRegex.Replace(line, string.Empty);
				var singleLine = cleanLine.Replace("\r\n", string.Empty);
				if (string.Equals("cancel-build", singleLine, StringComparison.Ordinal)) {
					_dte.ExecuteCommand("Build.Cancel");
					ThreadHelper.JoinableTaskFactory.Run(async () => {
						await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
						pane.OutputString("Build cancellation requested");
					});
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
				ThreadHelper.JoinableTaskFactory.Run(async () => {
					await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();
					pane.OutputString(line);
				});
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
	}
}
