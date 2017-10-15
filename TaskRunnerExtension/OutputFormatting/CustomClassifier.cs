using Microsoft.VisualStudio.Text.Classification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Text;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Utilities;
using System.Windows.Media;

namespace TaskRunnerExtension.OutputFormatting {
	public class CustomClassifier : IClassifier {

		private IClassificationTypeRegistryService _classificationTypeRegistry;
		private IClassificationFormatMapService _format;

		internal CustomClassifier(IClassificationTypeRegistryService registry, IClassificationFormatMapService format) {
			_classificationTypeRegistry = registry;
			_format = format;
		}

		public event EventHandler<ClassificationChangedEventArgs> ClassificationChanged;

		public IList<ClassificationSpan> GetClassificationSpans(SnapshotSpan span) {
			ITextSnapshot snapshot = span.Snapshot;

			List<ClassificationSpan> spans = new List<ClassificationSpan>();

			if (snapshot.Length == 0) {
				return spans;
			}

			var allText = span.GetText();

			int startno = span.Start.GetContainingLine().LineNumber;
			int endno = (span.End - 1).GetContainingLine().LineNumber;

			for (int i = startno; i <= endno; i++) {
				ITextSnapshotLine line = snapshot.GetLineFromLineNumber(i);
				if (line.Length == 0) { continue; }
				string text = line.Snapshot.GetText(new SnapshotSpan(line.Start, line.Length));

				int c1 = 0, c2, c3;
				IClassificationType fgType = _classificationTypeRegistry.GetClassificationType("output.term.color15");
				IClassificationType bgType = _classificationTypeRegistry.GetClassificationType("output.term.bgcolor00");

				c1 = text.IndexOf("\u001b["); // '\x001b'
				if (c1 >= 0) {
					handleMarker:
					c3 = text.IndexOf("m", c1);
					if (c3 < 0) {
						// invalid or unexpected escape sequence
						continue;
					}

					string[] escapeCodes = text.Substring(c1 + 2, c3 - c1 - 2).Split(';');
					int l = escapeCodes.Length;
					if (string.IsNullOrEmpty(escapeCodes[l - 1])) {
						l--;
					}

					for (int ii = 0; ii < l; ii++) {
						int v;
						if (int.TryParse(escapeCodes[ii], out v)) {
							// ansi colors
							if ((v >= 30 && v <= 37) || (v >= 40 && v <= 47)) {
								bool bright = false;
								if (ii + 1 < l) {
									int v2;
									if (int.TryParse(escapeCodes[ii + 1], out v2)) {
										if (v2 == 1) { bright = true; ii++; }
										else if (v2 != 0) { break; }
									}
									else {
										break;
									}
								}
								if (v >= 30 && v <= 37) {
									if (!bright) {
										fgType = _classificationTypeRegistry.GetClassificationType("output.term.color" + (v - 30).ToString("00"));
									}
									else {
										fgType = _classificationTypeRegistry.GetClassificationType("output.term.color" + (0x08 + (v - 30)).ToString("00"));
									}
								}
								if (v >= 40 && v <= 47) {
									if (!bright) {
										bgType = _classificationTypeRegistry.GetClassificationType("output.term.bgcolor" + (v - 40).ToString("00"));
									}
									else {
										bgType = _classificationTypeRegistry.GetClassificationType("output.term.bgcolor" + (0x08 + (v - 40)).ToString("00"));
									}
								}
							}
							else if (v >= 90 && v <= 97) {
								fgType = _classificationTypeRegistry.GetClassificationType("output.term.color" + (0x08 + (v - 90)).ToString("00"));
							}
							else if (v >= 100 && v <= 107) {
								bgType = _classificationTypeRegistry.GetClassificationType("output.term.bgcolor" + (0x08 + (v - 100)).ToString("00"));
							}
							else if (v == 38 || v == 48) {
								if (ii + 1 < l) {
									int v2;
									if (int.TryParse(escapeCodes[ii + 1], out v2)) {
										if (v2 == 2) {
											// rgb
											if (ii + 4 < l) {
												int r, g, b;
												if (!int.TryParse(escapeCodes[ii + 2], out r) || !int.TryParse(escapeCodes[ii + 3], out g) || !int.TryParse(escapeCodes[ii + 4], out b)) {
													break;
												}
												// TODO: handle rgb code
												ii += 4;
											}
											else {
												break;
											}
										}
										else if (v2 == 5) {
											// 256 color mode
											if (ii + 2 < l) {
												int code;
												if (!int.TryParse(escapeCodes[ii + 2], out code)) {
													break;
												}
												if (v == 38) {
													fgType = _classificationTypeRegistry.GetClassificationType("output.term.color" + code.ToString("00"));
												}
												if (v == 48) {
													bgType = _classificationTypeRegistry.GetClassificationType("output.term.bgcolor" + code.ToString("00"));
												}
												ii += 2;
											}
											else {
												break;
											}
										}
										else {
											break;
										}
									}
									else {
										break;
									}
								}
								else {
									break;
								}
							}
							else {
								break;
							}
						}
						else {
							break;
						}
					}

					c3++; // include 'm' character
					var tCode = _classificationTypeRegistry.GetClassificationType("output.term.colorcode");
					spans.Add(new ClassificationSpan(new SnapshotSpan(line.Extent.Start + c1, c3 - c1), tCode));

					c2 = text.IndexOf("\u001b[", c3);
					if (c2 >= 0) {
						if (c2 - c3 >= 0) {
							spans.Add(new ClassificationSpan(new SnapshotSpan(line.Extent.Start + c3, c2 - c3), fgType));
							spans.Add(new ClassificationSpan(new SnapshotSpan(line.Extent.Start + c3, c2 - c3), bgType));
						}
						c1 = c2;
						goto handleMarker;
					}
					else if (text.Length - c3 > 0) {
						spans.Add(new ClassificationSpan(new SnapshotSpan(line.Extent.Start + c3, text.Length - c3), fgType));
						spans.Add(new ClassificationSpan(new SnapshotSpan(line.Extent.Start + c3, text.Length - c3), bgType));
					}
					//spans.Add(new ClassificationSpan(line.Extent, t));
				}
			}

			return spans;
		}
	}
}
