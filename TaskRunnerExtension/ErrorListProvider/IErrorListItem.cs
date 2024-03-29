﻿extern alias taskrunner;

using System;
using taskrunner::Microsoft.VisualStudio.TaskRunnerExplorer;

namespace TaskRunnerExtension {
	internal interface IErrorListItem {
		/// <summary>
		/// Line of code on the error item
		/// </summary>
		int Line { get; set; }

		/// <summary>
		/// Column of code on the error item
		/// </summary>
		int Column { get; set; }

		/// <summary>
		/// Error message
		/// </summary>
		string Message { get; set; }

		/// <summary>
		/// File name of the error item
		/// </summary>
		string Filename { get; set; }

		/// <summary>
		/// Project name of the error item
		/// </summary>
		string ProjectName { get; set; }

		/// <summary>
		/// Severity of the error item
		/// </summary>
		MessageSeverity Severity { get; set; }

		/// <summary>
		/// Error source
		/// </summary>
		string ErrorSource { get; set; }

		/// <summary>
		/// Error code for the error item
		/// </summary>
		string ErrorCode { get; set; }

		/// <summary>
		/// Command that generated the error
		/// </summary>
		ITaskRunnerCommand Command { get; set; }
	}
}
