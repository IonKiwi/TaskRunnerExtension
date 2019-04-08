using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRunnerExtension.OutputFormatting {
	[Export(typeof(IClassifierProvider))]
	[ContentType("output")]
	internal class CustomClassifierProvider : IClassifierProvider {

		[Import]
		internal IClassificationTypeRegistryService ClassificationRegistry { get; set; }

		[Import]
		internal IClassificationFormatMapService ClassificationFormatMapService { get; set; }

		private static CustomClassifier _diffClassifier;

		public IClassifier GetClassifier(ITextBuffer buffer) {
			if (_diffClassifier == null) {
				_diffClassifier = new CustomClassifier(ClassificationRegistry, ClassificationFormatMapService);
			}

			return _diffClassifier;
		}
	}
}
