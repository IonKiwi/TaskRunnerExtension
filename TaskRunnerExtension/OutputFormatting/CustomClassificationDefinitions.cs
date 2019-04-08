using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TaskRunnerExtension.OutputFormatting {
	internal static partial class CustomClassificationDefinitions {

		[Export]
		[Name("output.term.colorcode")]
		internal static ClassificationTypeDefinition OutputTermColorCodeDefinition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.colorcode")]
		[Name("output.term.colorcode")]
		internal sealed class OutputTermColorCodeFormat : ClassificationFormatDefinition {
			public OutputTermColorCodeFormat() {
				ForegroundColor = Colors.Black;
				BackgroundColor = Colors.Black;
			}
		}
	}
}
