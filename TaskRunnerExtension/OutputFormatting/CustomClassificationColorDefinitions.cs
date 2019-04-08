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
	internal partial class CustomClassificationDefinitions {

		[Export]
		[Name("output.term.color00")]
		internal static ClassificationTypeDefinition outputTermColor00Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color00")]
		[Name("output.term.color00")]
		internal sealed class OutputTermColor00Format : ClassificationFormatDefinition {
			public OutputTermColor00Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor00")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor00Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor00")]
		[Name("output.term.bgcolor00")]
		internal sealed class OutputTermBackgroundColor00Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor00Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color01")]
		internal static ClassificationTypeDefinition outputTermColor01Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color01")]
		[Name("output.term.color01")]
		internal sealed class OutputTermColor01Format : ClassificationFormatDefinition {
			public OutputTermColor01Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor01")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor01Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor01")]
		[Name("output.term.bgcolor01")]
		internal sealed class OutputTermBackgroundColor01Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor01Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color02")]
		internal static ClassificationTypeDefinition outputTermColor02Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color02")]
		[Name("output.term.color02")]
		internal sealed class OutputTermColor02Format : ClassificationFormatDefinition {
			public OutputTermColor02Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x80, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor02")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor02Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor02")]
		[Name("output.term.bgcolor02")]
		internal sealed class OutputTermBackgroundColor02Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor02Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x80, 0x00);
			}
		}

		[Export]
		[Name("output.term.color03")]
		internal static ClassificationTypeDefinition outputTermColor03Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color03")]
		[Name("output.term.color03")]
		internal sealed class OutputTermColor03Format : ClassificationFormatDefinition {
			public OutputTermColor03Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x80, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor03")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor03Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor03")]
		[Name("output.term.bgcolor03")]
		internal sealed class OutputTermBackgroundColor03Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor03Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x80, 0x00);
			}
		}

		[Export]
		[Name("output.term.color04")]
		internal static ClassificationTypeDefinition outputTermColor04Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color04")]
		[Name("output.term.color04")]
		internal sealed class OutputTermColor04Format : ClassificationFormatDefinition {
			public OutputTermColor04Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x80);
			}
		}

		[Export]
		[Name("output.term.bgcolor04")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor04Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor04")]
		[Name("output.term.bgcolor04")]
		internal sealed class OutputTermBackgroundColor04Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor04Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x80);
			}
		}

		[Export]
		[Name("output.term.color05")]
		internal static ClassificationTypeDefinition outputTermColor05Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color05")]
		[Name("output.term.color05")]
		internal sealed class OutputTermColor05Format : ClassificationFormatDefinition {
			public OutputTermColor05Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x00, 0x80);
			}
		}

		[Export]
		[Name("output.term.bgcolor05")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor05Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor05")]
		[Name("output.term.bgcolor05")]
		internal sealed class OutputTermBackgroundColor05Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor05Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x00, 0x80);
			}
		}

		[Export]
		[Name("output.term.color06")]
		internal static ClassificationTypeDefinition outputTermColor06Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color06")]
		[Name("output.term.color06")]
		internal sealed class OutputTermColor06Format : ClassificationFormatDefinition {
			public OutputTermColor06Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x80, 0x80);
			}
		}

		[Export]
		[Name("output.term.bgcolor06")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor06Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor06")]
		[Name("output.term.bgcolor06")]
		internal sealed class OutputTermBackgroundColor06Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor06Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x80, 0x80);
			}
		}

		[Export]
		[Name("output.term.color07")]
		internal static ClassificationTypeDefinition outputTermColor07Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color07")]
		[Name("output.term.color07")]
		internal sealed class OutputTermColor07Format : ClassificationFormatDefinition {
			public OutputTermColor07Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0);
			}
		}

		[Export]
		[Name("output.term.bgcolor07")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor07Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor07")]
		[Name("output.term.bgcolor07")]
		internal sealed class OutputTermBackgroundColor07Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor07Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xc0, 0xc0, 0xc0);
			}
		}

		[Export]
		[Name("output.term.color08")]
		internal static ClassificationTypeDefinition outputTermColor08Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color08")]
		[Name("output.term.color08")]
		internal sealed class OutputTermColor08Format : ClassificationFormatDefinition {
			public OutputTermColor08Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x80, 0x80);
			}
		}

		[Export]
		[Name("output.term.bgcolor08")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor08Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor08")]
		[Name("output.term.bgcolor08")]
		internal sealed class OutputTermBackgroundColor08Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor08Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x80, 0x80);
			}
		}

		[Export]
		[Name("output.term.color09")]
		internal static ClassificationTypeDefinition outputTermColor09Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color09")]
		[Name("output.term.color09")]
		internal sealed class OutputTermColor09Format : ClassificationFormatDefinition {
			public OutputTermColor09Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor09")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor09Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor09")]
		[Name("output.term.bgcolor09")]
		internal sealed class OutputTermBackgroundColor09Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor09Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color10")]
		internal static ClassificationTypeDefinition outputTermColor10Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color10")]
		[Name("output.term.color10")]
		internal sealed class OutputTermColor10Format : ClassificationFormatDefinition {
			public OutputTermColor10Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor10")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor10Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor10")]
		[Name("output.term.bgcolor10")]
		internal sealed class OutputTermBackgroundColor10Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor10Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color11")]
		internal static ClassificationTypeDefinition outputTermColor11Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color11")]
		[Name("output.term.color11")]
		internal sealed class OutputTermColor11Format : ClassificationFormatDefinition {
			public OutputTermColor11Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor11")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor11Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor11")]
		[Name("output.term.bgcolor11")]
		internal sealed class OutputTermBackgroundColor11Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor11Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color12")]
		internal static ClassificationTypeDefinition outputTermColor12Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color12")]
		[Name("output.term.color12")]
		internal sealed class OutputTermColor12Format : ClassificationFormatDefinition {
			public OutputTermColor12Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor12")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor12Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor12")]
		[Name("output.term.bgcolor12")]
		internal sealed class OutputTermBackgroundColor12Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor12Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color13")]
		internal static ClassificationTypeDefinition outputTermColor13Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color13")]
		[Name("output.term.color13")]
		internal sealed class OutputTermColor13Format : ClassificationFormatDefinition {
			public OutputTermColor13Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor13")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor13Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor13")]
		[Name("output.term.bgcolor13")]
		internal sealed class OutputTermBackgroundColor13Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor13Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color14")]
		internal static ClassificationTypeDefinition outputTermColor14Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color14")]
		[Name("output.term.color14")]
		internal sealed class OutputTermColor14Format : ClassificationFormatDefinition {
			public OutputTermColor14Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor14")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor14Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor14")]
		[Name("output.term.bgcolor14")]
		internal sealed class OutputTermBackgroundColor14Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor14Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color15")]
		internal static ClassificationTypeDefinition outputTermColor15Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color15")]
		[Name("output.term.color15")]
		internal sealed class OutputTermColor15Format : ClassificationFormatDefinition {
			public OutputTermColor15Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor15")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor15Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor15")]
		[Name("output.term.bgcolor15")]
		internal sealed class OutputTermBackgroundColor15Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor15Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color16")]
		internal static ClassificationTypeDefinition outputTermColor16Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color16")]
		[Name("output.term.color16")]
		internal sealed class OutputTermColor16Format : ClassificationFormatDefinition {
			public OutputTermColor16Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor16")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor16Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor16")]
		[Name("output.term.bgcolor16")]
		internal sealed class OutputTermBackgroundColor16Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor16Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color17")]
		internal static ClassificationTypeDefinition outputTermColor17Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color17")]
		[Name("output.term.color17")]
		internal sealed class OutputTermColor17Format : ClassificationFormatDefinition {
			public OutputTermColor17Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor17")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor17Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor17")]
		[Name("output.term.bgcolor17")]
		internal sealed class OutputTermBackgroundColor17Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor17Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color18")]
		internal static ClassificationTypeDefinition outputTermColor18Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color18")]
		[Name("output.term.color18")]
		internal sealed class OutputTermColor18Format : ClassificationFormatDefinition {
			public OutputTermColor18Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor18")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor18Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor18")]
		[Name("output.term.bgcolor18")]
		internal sealed class OutputTermBackgroundColor18Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor18Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.color19")]
		internal static ClassificationTypeDefinition outputTermColor19Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color19")]
		[Name("output.term.color19")]
		internal sealed class OutputTermColor19Format : ClassificationFormatDefinition {
			public OutputTermColor19Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor19")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor19Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor19")]
		[Name("output.term.bgcolor19")]
		internal sealed class OutputTermBackgroundColor19Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor19Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color20")]
		internal static ClassificationTypeDefinition outputTermColor20Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color20")]
		[Name("output.term.color20")]
		internal sealed class OutputTermColor20Format : ClassificationFormatDefinition {
			public OutputTermColor20Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor20")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor20Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor20")]
		[Name("output.term.bgcolor20")]
		internal sealed class OutputTermBackgroundColor20Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor20Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color21")]
		internal static ClassificationTypeDefinition outputTermColor21Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color21")]
		[Name("output.term.color21")]
		internal sealed class OutputTermColor21Format : ClassificationFormatDefinition {
			public OutputTermColor21Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor21")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor21Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor21")]
		[Name("output.term.bgcolor21")]
		internal sealed class OutputTermBackgroundColor21Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor21Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color22")]
		internal static ClassificationTypeDefinition outputTermColor22Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color22")]
		[Name("output.term.color22")]
		internal sealed class OutputTermColor22Format : ClassificationFormatDefinition {
			public OutputTermColor22Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor22")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor22Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor22")]
		[Name("output.term.bgcolor22")]
		internal sealed class OutputTermBackgroundColor22Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor22Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.color23")]
		internal static ClassificationTypeDefinition outputTermColor23Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color23")]
		[Name("output.term.color23")]
		internal sealed class OutputTermColor23Format : ClassificationFormatDefinition {
			public OutputTermColor23Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor23")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor23Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor23")]
		[Name("output.term.bgcolor23")]
		internal sealed class OutputTermBackgroundColor23Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor23Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color24")]
		internal static ClassificationTypeDefinition outputTermColor24Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color24")]
		[Name("output.term.color24")]
		internal sealed class OutputTermColor24Format : ClassificationFormatDefinition {
			public OutputTermColor24Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor24")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor24Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor24")]
		[Name("output.term.bgcolor24")]
		internal sealed class OutputTermBackgroundColor24Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor24Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.color25")]
		internal static ClassificationTypeDefinition outputTermColor25Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color25")]
		[Name("output.term.color25")]
		internal sealed class OutputTermColor25Format : ClassificationFormatDefinition {
			public OutputTermColor25Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor25")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor25Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor25")]
		[Name("output.term.bgcolor25")]
		internal sealed class OutputTermBackgroundColor25Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor25Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color26")]
		internal static ClassificationTypeDefinition outputTermColor26Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color26")]
		[Name("output.term.color26")]
		internal sealed class OutputTermColor26Format : ClassificationFormatDefinition {
			public OutputTermColor26Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor26")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor26Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor26")]
		[Name("output.term.bgcolor26")]
		internal sealed class OutputTermBackgroundColor26Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor26Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color27")]
		internal static ClassificationTypeDefinition outputTermColor27Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color27")]
		[Name("output.term.color27")]
		internal sealed class OutputTermColor27Format : ClassificationFormatDefinition {
			public OutputTermColor27Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor27")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor27Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor27")]
		[Name("output.term.bgcolor27")]
		internal sealed class OutputTermBackgroundColor27Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor27Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.color28")]
		internal static ClassificationTypeDefinition outputTermColor28Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color28")]
		[Name("output.term.color28")]
		internal sealed class OutputTermColor28Format : ClassificationFormatDefinition {
			public OutputTermColor28Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor28")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor28Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor28")]
		[Name("output.term.bgcolor28")]
		internal sealed class OutputTermBackgroundColor28Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor28Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.color29")]
		internal static ClassificationTypeDefinition outputTermColor29Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color29")]
		[Name("output.term.color29")]
		internal sealed class OutputTermColor29Format : ClassificationFormatDefinition {
			public OutputTermColor29Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor29")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor29Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor29")]
		[Name("output.term.bgcolor29")]
		internal sealed class OutputTermBackgroundColor29Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor29Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color30")]
		internal static ClassificationTypeDefinition outputTermColor30Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color30")]
		[Name("output.term.color30")]
		internal sealed class OutputTermColor30Format : ClassificationFormatDefinition {
			public OutputTermColor30Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor30")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor30Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor30")]
		[Name("output.term.bgcolor30")]
		internal sealed class OutputTermBackgroundColor30Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor30Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.color31")]
		internal static ClassificationTypeDefinition outputTermColor31Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color31")]
		[Name("output.term.color31")]
		internal sealed class OutputTermColor31Format : ClassificationFormatDefinition {
			public OutputTermColor31Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor31")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor31Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor31")]
		[Name("output.term.bgcolor31")]
		internal sealed class OutputTermBackgroundColor31Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor31Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color32")]
		internal static ClassificationTypeDefinition outputTermColor32Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color32")]
		[Name("output.term.color32")]
		internal sealed class OutputTermColor32Format : ClassificationFormatDefinition {
			public OutputTermColor32Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor32")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor32Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor32")]
		[Name("output.term.bgcolor32")]
		internal sealed class OutputTermBackgroundColor32Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor32Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color33")]
		internal static ClassificationTypeDefinition outputTermColor33Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color33")]
		[Name("output.term.color33")]
		internal sealed class OutputTermColor33Format : ClassificationFormatDefinition {
			public OutputTermColor33Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor33")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor33Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor33")]
		[Name("output.term.bgcolor33")]
		internal sealed class OutputTermBackgroundColor33Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor33Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.color34")]
		internal static ClassificationTypeDefinition outputTermColor34Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color34")]
		[Name("output.term.color34")]
		internal sealed class OutputTermColor34Format : ClassificationFormatDefinition {
			public OutputTermColor34Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor34")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor34Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor34")]
		[Name("output.term.bgcolor34")]
		internal sealed class OutputTermBackgroundColor34Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor34Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.color35")]
		internal static ClassificationTypeDefinition outputTermColor35Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color35")]
		[Name("output.term.color35")]
		internal sealed class OutputTermColor35Format : ClassificationFormatDefinition {
			public OutputTermColor35Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor35")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor35Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor35")]
		[Name("output.term.bgcolor35")]
		internal sealed class OutputTermBackgroundColor35Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor35Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color36")]
		internal static ClassificationTypeDefinition outputTermColor36Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color36")]
		[Name("output.term.color36")]
		internal sealed class OutputTermColor36Format : ClassificationFormatDefinition {
			public OutputTermColor36Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor36")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor36Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor36")]
		[Name("output.term.bgcolor36")]
		internal sealed class OutputTermBackgroundColor36Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor36Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.color37")]
		internal static ClassificationTypeDefinition outputTermColor37Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color37")]
		[Name("output.term.color37")]
		internal sealed class OutputTermColor37Format : ClassificationFormatDefinition {
			public OutputTermColor37Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor37")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor37Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor37")]
		[Name("output.term.bgcolor37")]
		internal sealed class OutputTermBackgroundColor37Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor37Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color38")]
		internal static ClassificationTypeDefinition outputTermColor38Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color38")]
		[Name("output.term.color38")]
		internal sealed class OutputTermColor38Format : ClassificationFormatDefinition {
			public OutputTermColor38Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor38")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor38Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor38")]
		[Name("output.term.bgcolor38")]
		internal sealed class OutputTermBackgroundColor38Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor38Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color39")]
		internal static ClassificationTypeDefinition outputTermColor39Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color39")]
		[Name("output.term.color39")]
		internal sealed class OutputTermColor39Format : ClassificationFormatDefinition {
			public OutputTermColor39Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor39")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor39Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor39")]
		[Name("output.term.bgcolor39")]
		internal sealed class OutputTermBackgroundColor39Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor39Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.color40")]
		internal static ClassificationTypeDefinition outputTermColor40Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color40")]
		[Name("output.term.color40")]
		internal sealed class OutputTermColor40Format : ClassificationFormatDefinition {
			public OutputTermColor40Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor40")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor40Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor40")]
		[Name("output.term.bgcolor40")]
		internal sealed class OutputTermBackgroundColor40Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor40Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.color41")]
		internal static ClassificationTypeDefinition outputTermColor41Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color41")]
		[Name("output.term.color41")]
		internal sealed class OutputTermColor41Format : ClassificationFormatDefinition {
			public OutputTermColor41Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor41")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor41Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor41")]
		[Name("output.term.bgcolor41")]
		internal sealed class OutputTermBackgroundColor41Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor41Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color42")]
		internal static ClassificationTypeDefinition outputTermColor42Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color42")]
		[Name("output.term.color42")]
		internal sealed class OutputTermColor42Format : ClassificationFormatDefinition {
			public OutputTermColor42Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor42")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor42Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor42")]
		[Name("output.term.bgcolor42")]
		internal sealed class OutputTermBackgroundColor42Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor42Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.color43")]
		internal static ClassificationTypeDefinition outputTermColor43Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color43")]
		[Name("output.term.color43")]
		internal sealed class OutputTermColor43Format : ClassificationFormatDefinition {
			public OutputTermColor43Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor43")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor43Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor43")]
		[Name("output.term.bgcolor43")]
		internal sealed class OutputTermBackgroundColor43Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor43Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color44")]
		internal static ClassificationTypeDefinition outputTermColor44Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color44")]
		[Name("output.term.color44")]
		internal sealed class OutputTermColor44Format : ClassificationFormatDefinition {
			public OutputTermColor44Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor44")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor44Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor44")]
		[Name("output.term.bgcolor44")]
		internal sealed class OutputTermBackgroundColor44Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor44Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color45")]
		internal static ClassificationTypeDefinition outputTermColor45Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color45")]
		[Name("output.term.color45")]
		internal sealed class OutputTermColor45Format : ClassificationFormatDefinition {
			public OutputTermColor45Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor45")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor45Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor45")]
		[Name("output.term.bgcolor45")]
		internal sealed class OutputTermBackgroundColor45Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor45Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.color46")]
		internal static ClassificationTypeDefinition outputTermColor46Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color46")]
		[Name("output.term.color46")]
		internal sealed class OutputTermColor46Format : ClassificationFormatDefinition {
			public OutputTermColor46Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor46")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor46Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor46")]
		[Name("output.term.bgcolor46")]
		internal sealed class OutputTermBackgroundColor46Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor46Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color47")]
		internal static ClassificationTypeDefinition outputTermColor47Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color47")]
		[Name("output.term.color47")]
		internal sealed class OutputTermColor47Format : ClassificationFormatDefinition {
			public OutputTermColor47Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor47")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor47Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor47")]
		[Name("output.term.bgcolor47")]
		internal sealed class OutputTermBackgroundColor47Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor47Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color48")]
		internal static ClassificationTypeDefinition outputTermColor48Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color48")]
		[Name("output.term.color48")]
		internal sealed class OutputTermColor48Format : ClassificationFormatDefinition {
			public OutputTermColor48Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor48")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor48Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor48")]
		[Name("output.term.bgcolor48")]
		internal sealed class OutputTermBackgroundColor48Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor48Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.color49")]
		internal static ClassificationTypeDefinition outputTermColor49Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color49")]
		[Name("output.term.color49")]
		internal sealed class OutputTermColor49Format : ClassificationFormatDefinition {
			public OutputTermColor49Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor49")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor49Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor49")]
		[Name("output.term.bgcolor49")]
		internal sealed class OutputTermBackgroundColor49Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor49Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color50")]
		internal static ClassificationTypeDefinition outputTermColor50Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color50")]
		[Name("output.term.color50")]
		internal sealed class OutputTermColor50Format : ClassificationFormatDefinition {
			public OutputTermColor50Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor50")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor50Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor50")]
		[Name("output.term.bgcolor50")]
		internal sealed class OutputTermBackgroundColor50Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor50Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color51")]
		internal static ClassificationTypeDefinition outputTermColor51Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color51")]
		[Name("output.term.color51")]
		internal sealed class OutputTermColor51Format : ClassificationFormatDefinition {
			public OutputTermColor51Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor51")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor51Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor51")]
		[Name("output.term.bgcolor51")]
		internal sealed class OutputTermBackgroundColor51Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor51Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x00, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color52")]
		internal static ClassificationTypeDefinition outputTermColor52Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color52")]
		[Name("output.term.color52")]
		internal sealed class OutputTermColor52Format : ClassificationFormatDefinition {
			public OutputTermColor52Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor52")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor52Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor52")]
		[Name("output.term.bgcolor52")]
		internal sealed class OutputTermBackgroundColor52Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor52Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color53")]
		internal static ClassificationTypeDefinition outputTermColor53Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color53")]
		[Name("output.term.color53")]
		internal sealed class OutputTermColor53Format : ClassificationFormatDefinition {
			public OutputTermColor53Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor53")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor53Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor53")]
		[Name("output.term.bgcolor53")]
		internal sealed class OutputTermBackgroundColor53Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor53Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color54")]
		internal static ClassificationTypeDefinition outputTermColor54Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color54")]
		[Name("output.term.color54")]
		internal sealed class OutputTermColor54Format : ClassificationFormatDefinition {
			public OutputTermColor54Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor54")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor54Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor54")]
		[Name("output.term.bgcolor54")]
		internal sealed class OutputTermBackgroundColor54Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor54Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.color55")]
		internal static ClassificationTypeDefinition outputTermColor55Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color55")]
		[Name("output.term.color55")]
		internal sealed class OutputTermColor55Format : ClassificationFormatDefinition {
			public OutputTermColor55Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor55")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor55Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor55")]
		[Name("output.term.bgcolor55")]
		internal sealed class OutputTermBackgroundColor55Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor55Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color56")]
		internal static ClassificationTypeDefinition outputTermColor56Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color56")]
		[Name("output.term.color56")]
		internal sealed class OutputTermColor56Format : ClassificationFormatDefinition {
			public OutputTermColor56Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor56")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor56Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor56")]
		[Name("output.term.bgcolor56")]
		internal sealed class OutputTermBackgroundColor56Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor56Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color57")]
		internal static ClassificationTypeDefinition outputTermColor57Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color57")]
		[Name("output.term.color57")]
		internal sealed class OutputTermColor57Format : ClassificationFormatDefinition {
			public OutputTermColor57Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor57")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor57Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor57")]
		[Name("output.term.bgcolor57")]
		internal sealed class OutputTermBackgroundColor57Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor57Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color58")]
		internal static ClassificationTypeDefinition outputTermColor58Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color58")]
		[Name("output.term.color58")]
		internal sealed class OutputTermColor58Format : ClassificationFormatDefinition {
			public OutputTermColor58Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor58")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor58Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor58")]
		[Name("output.term.bgcolor58")]
		internal sealed class OutputTermBackgroundColor58Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor58Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.color59")]
		internal static ClassificationTypeDefinition outputTermColor59Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color59")]
		[Name("output.term.color59")]
		internal sealed class OutputTermColor59Format : ClassificationFormatDefinition {
			public OutputTermColor59Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor59")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor59Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor59")]
		[Name("output.term.bgcolor59")]
		internal sealed class OutputTermBackgroundColor59Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor59Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color60")]
		internal static ClassificationTypeDefinition outputTermColor60Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color60")]
		[Name("output.term.color60")]
		internal sealed class OutputTermColor60Format : ClassificationFormatDefinition {
			public OutputTermColor60Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor60")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor60Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor60")]
		[Name("output.term.bgcolor60")]
		internal sealed class OutputTermBackgroundColor60Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor60Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.color61")]
		internal static ClassificationTypeDefinition outputTermColor61Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color61")]
		[Name("output.term.color61")]
		internal sealed class OutputTermColor61Format : ClassificationFormatDefinition {
			public OutputTermColor61Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor61")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor61Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor61")]
		[Name("output.term.bgcolor61")]
		internal sealed class OutputTermBackgroundColor61Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor61Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color62")]
		internal static ClassificationTypeDefinition outputTermColor62Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color62")]
		[Name("output.term.color62")]
		internal sealed class OutputTermColor62Format : ClassificationFormatDefinition {
			public OutputTermColor62Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor62")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor62Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor62")]
		[Name("output.term.bgcolor62")]
		internal sealed class OutputTermBackgroundColor62Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor62Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color63")]
		internal static ClassificationTypeDefinition outputTermColor63Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color63")]
		[Name("output.term.color63")]
		internal sealed class OutputTermColor63Format : ClassificationFormatDefinition {
			public OutputTermColor63Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor63")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor63Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor63")]
		[Name("output.term.bgcolor63")]
		internal sealed class OutputTermBackgroundColor63Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor63Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.color64")]
		internal static ClassificationTypeDefinition outputTermColor64Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color64")]
		[Name("output.term.color64")]
		internal sealed class OutputTermColor64Format : ClassificationFormatDefinition {
			public OutputTermColor64Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor64")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor64Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor64")]
		[Name("output.term.bgcolor64")]
		internal sealed class OutputTermBackgroundColor64Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor64Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.color65")]
		internal static ClassificationTypeDefinition outputTermColor65Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color65")]
		[Name("output.term.color65")]
		internal sealed class OutputTermColor65Format : ClassificationFormatDefinition {
			public OutputTermColor65Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor65")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor65Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor65")]
		[Name("output.term.bgcolor65")]
		internal sealed class OutputTermBackgroundColor65Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor65Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color66")]
		internal static ClassificationTypeDefinition outputTermColor66Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color66")]
		[Name("output.term.color66")]
		internal sealed class OutputTermColor66Format : ClassificationFormatDefinition {
			public OutputTermColor66Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor66")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor66Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor66")]
		[Name("output.term.bgcolor66")]
		internal sealed class OutputTermBackgroundColor66Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor66Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.color67")]
		internal static ClassificationTypeDefinition outputTermColor67Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color67")]
		[Name("output.term.color67")]
		internal sealed class OutputTermColor67Format : ClassificationFormatDefinition {
			public OutputTermColor67Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor67")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor67Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor67")]
		[Name("output.term.bgcolor67")]
		internal sealed class OutputTermBackgroundColor67Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor67Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color68")]
		internal static ClassificationTypeDefinition outputTermColor68Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color68")]
		[Name("output.term.color68")]
		internal sealed class OutputTermColor68Format : ClassificationFormatDefinition {
			public OutputTermColor68Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor68")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor68Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor68")]
		[Name("output.term.bgcolor68")]
		internal sealed class OutputTermBackgroundColor68Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor68Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color69")]
		internal static ClassificationTypeDefinition outputTermColor69Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color69")]
		[Name("output.term.color69")]
		internal sealed class OutputTermColor69Format : ClassificationFormatDefinition {
			public OutputTermColor69Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor69")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor69Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor69")]
		[Name("output.term.bgcolor69")]
		internal sealed class OutputTermBackgroundColor69Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor69Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.color70")]
		internal static ClassificationTypeDefinition outputTermColor70Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color70")]
		[Name("output.term.color70")]
		internal sealed class OutputTermColor70Format : ClassificationFormatDefinition {
			public OutputTermColor70Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor70")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor70Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor70")]
		[Name("output.term.bgcolor70")]
		internal sealed class OutputTermBackgroundColor70Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor70Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.color71")]
		internal static ClassificationTypeDefinition outputTermColor71Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color71")]
		[Name("output.term.color71")]
		internal sealed class OutputTermColor71Format : ClassificationFormatDefinition {
			public OutputTermColor71Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor71")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor71Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor71")]
		[Name("output.term.bgcolor71")]
		internal sealed class OutputTermBackgroundColor71Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor71Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color72")]
		internal static ClassificationTypeDefinition outputTermColor72Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color72")]
		[Name("output.term.color72")]
		internal sealed class OutputTermColor72Format : ClassificationFormatDefinition {
			public OutputTermColor72Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor72")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor72Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor72")]
		[Name("output.term.bgcolor72")]
		internal sealed class OutputTermBackgroundColor72Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor72Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.color73")]
		internal static ClassificationTypeDefinition outputTermColor73Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color73")]
		[Name("output.term.color73")]
		internal sealed class OutputTermColor73Format : ClassificationFormatDefinition {
			public OutputTermColor73Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor73")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor73Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor73")]
		[Name("output.term.bgcolor73")]
		internal sealed class OutputTermBackgroundColor73Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor73Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color74")]
		internal static ClassificationTypeDefinition outputTermColor74Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color74")]
		[Name("output.term.color74")]
		internal sealed class OutputTermColor74Format : ClassificationFormatDefinition {
			public OutputTermColor74Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor74")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor74Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor74")]
		[Name("output.term.bgcolor74")]
		internal sealed class OutputTermBackgroundColor74Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor74Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color75")]
		internal static ClassificationTypeDefinition outputTermColor75Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color75")]
		[Name("output.term.color75")]
		internal sealed class OutputTermColor75Format : ClassificationFormatDefinition {
			public OutputTermColor75Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor75")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor75Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor75")]
		[Name("output.term.bgcolor75")]
		internal sealed class OutputTermBackgroundColor75Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor75Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.color76")]
		internal static ClassificationTypeDefinition outputTermColor76Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color76")]
		[Name("output.term.color76")]
		internal sealed class OutputTermColor76Format : ClassificationFormatDefinition {
			public OutputTermColor76Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor76")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor76Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor76")]
		[Name("output.term.bgcolor76")]
		internal sealed class OutputTermBackgroundColor76Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor76Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.color77")]
		internal static ClassificationTypeDefinition outputTermColor77Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color77")]
		[Name("output.term.color77")]
		internal sealed class OutputTermColor77Format : ClassificationFormatDefinition {
			public OutputTermColor77Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor77")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor77Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor77")]
		[Name("output.term.bgcolor77")]
		internal sealed class OutputTermBackgroundColor77Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor77Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color78")]
		internal static ClassificationTypeDefinition outputTermColor78Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color78")]
		[Name("output.term.color78")]
		internal sealed class OutputTermColor78Format : ClassificationFormatDefinition {
			public OutputTermColor78Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor78")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor78Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor78")]
		[Name("output.term.bgcolor78")]
		internal sealed class OutputTermBackgroundColor78Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor78Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.color79")]
		internal static ClassificationTypeDefinition outputTermColor79Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color79")]
		[Name("output.term.color79")]
		internal sealed class OutputTermColor79Format : ClassificationFormatDefinition {
			public OutputTermColor79Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor79")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor79Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor79")]
		[Name("output.term.bgcolor79")]
		internal sealed class OutputTermBackgroundColor79Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor79Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color80")]
		internal static ClassificationTypeDefinition outputTermColor80Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color80")]
		[Name("output.term.color80")]
		internal sealed class OutputTermColor80Format : ClassificationFormatDefinition {
			public OutputTermColor80Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor80")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor80Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor80")]
		[Name("output.term.bgcolor80")]
		internal sealed class OutputTermBackgroundColor80Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor80Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color81")]
		internal static ClassificationTypeDefinition outputTermColor81Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color81")]
		[Name("output.term.color81")]
		internal sealed class OutputTermColor81Format : ClassificationFormatDefinition {
			public OutputTermColor81Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor81")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor81Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor81")]
		[Name("output.term.bgcolor81")]
		internal sealed class OutputTermBackgroundColor81Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor81Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.color82")]
		internal static ClassificationTypeDefinition outputTermColor82Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color82")]
		[Name("output.term.color82")]
		internal sealed class OutputTermColor82Format : ClassificationFormatDefinition {
			public OutputTermColor82Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor82")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor82Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor82")]
		[Name("output.term.bgcolor82")]
		internal sealed class OutputTermBackgroundColor82Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor82Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color83")]
		internal static ClassificationTypeDefinition outputTermColor83Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color83")]
		[Name("output.term.color83")]
		internal sealed class OutputTermColor83Format : ClassificationFormatDefinition {
			public OutputTermColor83Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor83")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor83Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor83")]
		[Name("output.term.bgcolor83")]
		internal sealed class OutputTermBackgroundColor83Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor83Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color84")]
		internal static ClassificationTypeDefinition outputTermColor84Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color84")]
		[Name("output.term.color84")]
		internal sealed class OutputTermColor84Format : ClassificationFormatDefinition {
			public OutputTermColor84Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor84")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor84Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor84")]
		[Name("output.term.bgcolor84")]
		internal sealed class OutputTermBackgroundColor84Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor84Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.color85")]
		internal static ClassificationTypeDefinition outputTermColor85Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color85")]
		[Name("output.term.color85")]
		internal sealed class OutputTermColor85Format : ClassificationFormatDefinition {
			public OutputTermColor85Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor85")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor85Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor85")]
		[Name("output.term.bgcolor85")]
		internal sealed class OutputTermBackgroundColor85Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor85Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color86")]
		internal static ClassificationTypeDefinition outputTermColor86Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color86")]
		[Name("output.term.color86")]
		internal sealed class OutputTermColor86Format : ClassificationFormatDefinition {
			public OutputTermColor86Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor86")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor86Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor86")]
		[Name("output.term.bgcolor86")]
		internal sealed class OutputTermBackgroundColor86Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor86Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color87")]
		internal static ClassificationTypeDefinition outputTermColor87Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color87")]
		[Name("output.term.color87")]
		internal sealed class OutputTermColor87Format : ClassificationFormatDefinition {
			public OutputTermColor87Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor87")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor87Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor87")]
		[Name("output.term.bgcolor87")]
		internal sealed class OutputTermBackgroundColor87Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor87Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x5f, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color88")]
		internal static ClassificationTypeDefinition outputTermColor88Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color88")]
		[Name("output.term.color88")]
		internal sealed class OutputTermColor88Format : ClassificationFormatDefinition {
			public OutputTermColor88Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor88")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor88Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor88")]
		[Name("output.term.bgcolor88")]
		internal sealed class OutputTermBackgroundColor88Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor88Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color89")]
		internal static ClassificationTypeDefinition outputTermColor89Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color89")]
		[Name("output.term.color89")]
		internal sealed class OutputTermColor89Format : ClassificationFormatDefinition {
			public OutputTermColor89Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor89")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor89Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor89")]
		[Name("output.term.bgcolor89")]
		internal sealed class OutputTermBackgroundColor89Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor89Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color90")]
		internal static ClassificationTypeDefinition outputTermColor90Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color90")]
		[Name("output.term.color90")]
		internal sealed class OutputTermColor90Format : ClassificationFormatDefinition {
			public OutputTermColor90Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor90")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor90Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor90")]
		[Name("output.term.bgcolor90")]
		internal sealed class OutputTermBackgroundColor90Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor90Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.color91")]
		internal static ClassificationTypeDefinition outputTermColor91Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color91")]
		[Name("output.term.color91")]
		internal sealed class OutputTermColor91Format : ClassificationFormatDefinition {
			public OutputTermColor91Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor91")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor91Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor91")]
		[Name("output.term.bgcolor91")]
		internal sealed class OutputTermBackgroundColor91Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor91Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color92")]
		internal static ClassificationTypeDefinition outputTermColor92Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color92")]
		[Name("output.term.color92")]
		internal sealed class OutputTermColor92Format : ClassificationFormatDefinition {
			public OutputTermColor92Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor92")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor92Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor92")]
		[Name("output.term.bgcolor92")]
		internal sealed class OutputTermBackgroundColor92Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor92Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color93")]
		internal static ClassificationTypeDefinition outputTermColor93Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color93")]
		[Name("output.term.color93")]
		internal sealed class OutputTermColor93Format : ClassificationFormatDefinition {
			public OutputTermColor93Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor93")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor93Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor93")]
		[Name("output.term.bgcolor93")]
		internal sealed class OutputTermBackgroundColor93Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor93Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color94")]
		internal static ClassificationTypeDefinition outputTermColor94Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color94")]
		[Name("output.term.color94")]
		internal sealed class OutputTermColor94Format : ClassificationFormatDefinition {
			public OutputTermColor94Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor94")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor94Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor94")]
		[Name("output.term.bgcolor94")]
		internal sealed class OutputTermBackgroundColor94Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor94Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.color95")]
		internal static ClassificationTypeDefinition outputTermColor95Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color95")]
		[Name("output.term.color95")]
		internal sealed class OutputTermColor95Format : ClassificationFormatDefinition {
			public OutputTermColor95Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor95")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor95Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor95")]
		[Name("output.term.bgcolor95")]
		internal sealed class OutputTermBackgroundColor95Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor95Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color96")]
		internal static ClassificationTypeDefinition outputTermColor96Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color96")]
		[Name("output.term.color96")]
		internal sealed class OutputTermColor96Format : ClassificationFormatDefinition {
			public OutputTermColor96Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor96")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor96Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor96")]
		[Name("output.term.bgcolor96")]
		internal sealed class OutputTermBackgroundColor96Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor96Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.color97")]
		internal static ClassificationTypeDefinition outputTermColor97Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color97")]
		[Name("output.term.color97")]
		internal sealed class OutputTermColor97Format : ClassificationFormatDefinition {
			public OutputTermColor97Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor97")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor97Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor97")]
		[Name("output.term.bgcolor97")]
		internal sealed class OutputTermBackgroundColor97Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor97Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color98")]
		internal static ClassificationTypeDefinition outputTermColor98Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color98")]
		[Name("output.term.color98")]
		internal sealed class OutputTermColor98Format : ClassificationFormatDefinition {
			public OutputTermColor98Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor98")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor98Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor98")]
		[Name("output.term.bgcolor98")]
		internal sealed class OutputTermBackgroundColor98Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor98Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color99")]
		internal static ClassificationTypeDefinition outputTermColor99Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color99")]
		[Name("output.term.color99")]
		internal sealed class OutputTermColor99Format : ClassificationFormatDefinition {
			public OutputTermColor99Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor99")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor99Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor99")]
		[Name("output.term.bgcolor99")]
		internal sealed class OutputTermBackgroundColor99Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor99Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.color100")]
		internal static ClassificationTypeDefinition outputTermColor100Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color100")]
		[Name("output.term.color100")]
		internal sealed class OutputTermColor100Format : ClassificationFormatDefinition {
			public OutputTermColor100Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor100")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor100Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor100")]
		[Name("output.term.bgcolor100")]
		internal sealed class OutputTermBackgroundColor100Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor100Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.color101")]
		internal static ClassificationTypeDefinition outputTermColor101Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color101")]
		[Name("output.term.color101")]
		internal sealed class OutputTermColor101Format : ClassificationFormatDefinition {
			public OutputTermColor101Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor101")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor101Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor101")]
		[Name("output.term.bgcolor101")]
		internal sealed class OutputTermBackgroundColor101Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor101Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color102")]
		internal static ClassificationTypeDefinition outputTermColor102Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color102")]
		[Name("output.term.color102")]
		internal sealed class OutputTermColor102Format : ClassificationFormatDefinition {
			public OutputTermColor102Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor102")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor102Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor102")]
		[Name("output.term.bgcolor102")]
		internal sealed class OutputTermBackgroundColor102Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor102Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.color103")]
		internal static ClassificationTypeDefinition outputTermColor103Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color103")]
		[Name("output.term.color103")]
		internal sealed class OutputTermColor103Format : ClassificationFormatDefinition {
			public OutputTermColor103Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor103")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor103Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor103")]
		[Name("output.term.bgcolor103")]
		internal sealed class OutputTermBackgroundColor103Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor103Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color104")]
		internal static ClassificationTypeDefinition outputTermColor104Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color104")]
		[Name("output.term.color104")]
		internal sealed class OutputTermColor104Format : ClassificationFormatDefinition {
			public OutputTermColor104Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor104")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor104Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor104")]
		[Name("output.term.bgcolor104")]
		internal sealed class OutputTermBackgroundColor104Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor104Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color105")]
		internal static ClassificationTypeDefinition outputTermColor105Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color105")]
		[Name("output.term.color105")]
		internal sealed class OutputTermColor105Format : ClassificationFormatDefinition {
			public OutputTermColor105Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor105")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor105Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor105")]
		[Name("output.term.bgcolor105")]
		internal sealed class OutputTermBackgroundColor105Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor105Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.color106")]
		internal static ClassificationTypeDefinition outputTermColor106Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color106")]
		[Name("output.term.color106")]
		internal sealed class OutputTermColor106Format : ClassificationFormatDefinition {
			public OutputTermColor106Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor106")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor106Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor106")]
		[Name("output.term.bgcolor106")]
		internal sealed class OutputTermBackgroundColor106Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor106Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.color107")]
		internal static ClassificationTypeDefinition outputTermColor107Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color107")]
		[Name("output.term.color107")]
		internal sealed class OutputTermColor107Format : ClassificationFormatDefinition {
			public OutputTermColor107Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor107")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor107Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor107")]
		[Name("output.term.bgcolor107")]
		internal sealed class OutputTermBackgroundColor107Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor107Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color108")]
		internal static ClassificationTypeDefinition outputTermColor108Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color108")]
		[Name("output.term.color108")]
		internal sealed class OutputTermColor108Format : ClassificationFormatDefinition {
			public OutputTermColor108Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor108")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor108Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor108")]
		[Name("output.term.bgcolor108")]
		internal sealed class OutputTermBackgroundColor108Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor108Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.color109")]
		internal static ClassificationTypeDefinition outputTermColor109Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color109")]
		[Name("output.term.color109")]
		internal sealed class OutputTermColor109Format : ClassificationFormatDefinition {
			public OutputTermColor109Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor109")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor109Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor109")]
		[Name("output.term.bgcolor109")]
		internal sealed class OutputTermBackgroundColor109Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor109Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color110")]
		internal static ClassificationTypeDefinition outputTermColor110Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color110")]
		[Name("output.term.color110")]
		internal sealed class OutputTermColor110Format : ClassificationFormatDefinition {
			public OutputTermColor110Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor110")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor110Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor110")]
		[Name("output.term.bgcolor110")]
		internal sealed class OutputTermBackgroundColor110Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor110Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color111")]
		internal static ClassificationTypeDefinition outputTermColor111Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color111")]
		[Name("output.term.color111")]
		internal sealed class OutputTermColor111Format : ClassificationFormatDefinition {
			public OutputTermColor111Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor111")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor111Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor111")]
		[Name("output.term.bgcolor111")]
		internal sealed class OutputTermBackgroundColor111Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor111Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.color112")]
		internal static ClassificationTypeDefinition outputTermColor112Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color112")]
		[Name("output.term.color112")]
		internal sealed class OutputTermColor112Format : ClassificationFormatDefinition {
			public OutputTermColor112Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor112")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor112Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor112")]
		[Name("output.term.bgcolor112")]
		internal sealed class OutputTermBackgroundColor112Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor112Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.color113")]
		internal static ClassificationTypeDefinition outputTermColor113Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color113")]
		[Name("output.term.color113")]
		internal sealed class OutputTermColor113Format : ClassificationFormatDefinition {
			public OutputTermColor113Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor113")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor113Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor113")]
		[Name("output.term.bgcolor113")]
		internal sealed class OutputTermBackgroundColor113Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor113Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color114")]
		internal static ClassificationTypeDefinition outputTermColor114Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color114")]
		[Name("output.term.color114")]
		internal sealed class OutputTermColor114Format : ClassificationFormatDefinition {
			public OutputTermColor114Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor114")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor114Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor114")]
		[Name("output.term.bgcolor114")]
		internal sealed class OutputTermBackgroundColor114Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor114Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.color115")]
		internal static ClassificationTypeDefinition outputTermColor115Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color115")]
		[Name("output.term.color115")]
		internal sealed class OutputTermColor115Format : ClassificationFormatDefinition {
			public OutputTermColor115Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor115")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor115Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor115")]
		[Name("output.term.bgcolor115")]
		internal sealed class OutputTermBackgroundColor115Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor115Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color116")]
		internal static ClassificationTypeDefinition outputTermColor116Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color116")]
		[Name("output.term.color116")]
		internal sealed class OutputTermColor116Format : ClassificationFormatDefinition {
			public OutputTermColor116Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor116")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor116Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor116")]
		[Name("output.term.bgcolor116")]
		internal sealed class OutputTermBackgroundColor116Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor116Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color117")]
		internal static ClassificationTypeDefinition outputTermColor117Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color117")]
		[Name("output.term.color117")]
		internal sealed class OutputTermColor117Format : ClassificationFormatDefinition {
			public OutputTermColor117Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor117")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor117Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor117")]
		[Name("output.term.bgcolor117")]
		internal sealed class OutputTermBackgroundColor117Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor117Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.color118")]
		internal static ClassificationTypeDefinition outputTermColor118Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color118")]
		[Name("output.term.color118")]
		internal sealed class OutputTermColor118Format : ClassificationFormatDefinition {
			public OutputTermColor118Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor118")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor118Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor118")]
		[Name("output.term.bgcolor118")]
		internal sealed class OutputTermBackgroundColor118Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor118Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color119")]
		internal static ClassificationTypeDefinition outputTermColor119Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color119")]
		[Name("output.term.color119")]
		internal sealed class OutputTermColor119Format : ClassificationFormatDefinition {
			public OutputTermColor119Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor119")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor119Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor119")]
		[Name("output.term.bgcolor119")]
		internal sealed class OutputTermBackgroundColor119Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor119Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color120")]
		internal static ClassificationTypeDefinition outputTermColor120Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color120")]
		[Name("output.term.color120")]
		internal sealed class OutputTermColor120Format : ClassificationFormatDefinition {
			public OutputTermColor120Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor120")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor120Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor120")]
		[Name("output.term.bgcolor120")]
		internal sealed class OutputTermBackgroundColor120Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor120Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.color121")]
		internal static ClassificationTypeDefinition outputTermColor121Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color121")]
		[Name("output.term.color121")]
		internal sealed class OutputTermColor121Format : ClassificationFormatDefinition {
			public OutputTermColor121Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor121")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor121Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor121")]
		[Name("output.term.bgcolor121")]
		internal sealed class OutputTermBackgroundColor121Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor121Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color122")]
		internal static ClassificationTypeDefinition outputTermColor122Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color122")]
		[Name("output.term.color122")]
		internal sealed class OutputTermColor122Format : ClassificationFormatDefinition {
			public OutputTermColor122Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor122")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor122Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor122")]
		[Name("output.term.bgcolor122")]
		internal sealed class OutputTermBackgroundColor122Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor122Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color123")]
		internal static ClassificationTypeDefinition outputTermColor123Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color123")]
		[Name("output.term.color123")]
		internal sealed class OutputTermColor123Format : ClassificationFormatDefinition {
			public OutputTermColor123Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor123")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor123Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor123")]
		[Name("output.term.bgcolor123")]
		internal sealed class OutputTermBackgroundColor123Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor123Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x87, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color124")]
		internal static ClassificationTypeDefinition outputTermColor124Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color124")]
		[Name("output.term.color124")]
		internal sealed class OutputTermColor124Format : ClassificationFormatDefinition {
			public OutputTermColor124Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor124")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor124Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor124")]
		[Name("output.term.bgcolor124")]
		internal sealed class OutputTermBackgroundColor124Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor124Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color125")]
		internal static ClassificationTypeDefinition outputTermColor125Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color125")]
		[Name("output.term.color125")]
		internal sealed class OutputTermColor125Format : ClassificationFormatDefinition {
			public OutputTermColor125Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor125")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor125Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor125")]
		[Name("output.term.bgcolor125")]
		internal sealed class OutputTermBackgroundColor125Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor125Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color126")]
		internal static ClassificationTypeDefinition outputTermColor126Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color126")]
		[Name("output.term.color126")]
		internal sealed class OutputTermColor126Format : ClassificationFormatDefinition {
			public OutputTermColor126Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor126")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor126Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor126")]
		[Name("output.term.bgcolor126")]
		internal sealed class OutputTermBackgroundColor126Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor126Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.color127")]
		internal static ClassificationTypeDefinition outputTermColor127Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color127")]
		[Name("output.term.color127")]
		internal sealed class OutputTermColor127Format : ClassificationFormatDefinition {
			public OutputTermColor127Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor127")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor127Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor127")]
		[Name("output.term.bgcolor127")]
		internal sealed class OutputTermBackgroundColor127Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor127Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color128")]
		internal static ClassificationTypeDefinition outputTermColor128Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color128")]
		[Name("output.term.color128")]
		internal sealed class OutputTermColor128Format : ClassificationFormatDefinition {
			public OutputTermColor128Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor128")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor128Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor128")]
		[Name("output.term.bgcolor128")]
		internal sealed class OutputTermBackgroundColor128Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor128Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color129")]
		internal static ClassificationTypeDefinition outputTermColor129Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color129")]
		[Name("output.term.color129")]
		internal sealed class OutputTermColor129Format : ClassificationFormatDefinition {
			public OutputTermColor129Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor129")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor129Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor129")]
		[Name("output.term.bgcolor129")]
		internal sealed class OutputTermBackgroundColor129Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor129Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color130")]
		internal static ClassificationTypeDefinition outputTermColor130Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color130")]
		[Name("output.term.color130")]
		internal sealed class OutputTermColor130Format : ClassificationFormatDefinition {
			public OutputTermColor130Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor130")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor130Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor130")]
		[Name("output.term.bgcolor130")]
		internal sealed class OutputTermBackgroundColor130Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor130Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.color131")]
		internal static ClassificationTypeDefinition outputTermColor131Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color131")]
		[Name("output.term.color131")]
		internal sealed class OutputTermColor131Format : ClassificationFormatDefinition {
			public OutputTermColor131Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor131")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor131Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor131")]
		[Name("output.term.bgcolor131")]
		internal sealed class OutputTermBackgroundColor131Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor131Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color132")]
		internal static ClassificationTypeDefinition outputTermColor132Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color132")]
		[Name("output.term.color132")]
		internal sealed class OutputTermColor132Format : ClassificationFormatDefinition {
			public OutputTermColor132Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor132")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor132Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor132")]
		[Name("output.term.bgcolor132")]
		internal sealed class OutputTermBackgroundColor132Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor132Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.color133")]
		internal static ClassificationTypeDefinition outputTermColor133Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color133")]
		[Name("output.term.color133")]
		internal sealed class OutputTermColor133Format : ClassificationFormatDefinition {
			public OutputTermColor133Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor133")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor133Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor133")]
		[Name("output.term.bgcolor133")]
		internal sealed class OutputTermBackgroundColor133Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor133Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color134")]
		internal static ClassificationTypeDefinition outputTermColor134Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color134")]
		[Name("output.term.color134")]
		internal sealed class OutputTermColor134Format : ClassificationFormatDefinition {
			public OutputTermColor134Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor134")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor134Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor134")]
		[Name("output.term.bgcolor134")]
		internal sealed class OutputTermBackgroundColor134Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor134Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color135")]
		internal static ClassificationTypeDefinition outputTermColor135Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color135")]
		[Name("output.term.color135")]
		internal sealed class OutputTermColor135Format : ClassificationFormatDefinition {
			public OutputTermColor135Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor135")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor135Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor135")]
		[Name("output.term.bgcolor135")]
		internal sealed class OutputTermBackgroundColor135Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor135Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.color136")]
		internal static ClassificationTypeDefinition outputTermColor136Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color136")]
		[Name("output.term.color136")]
		internal sealed class OutputTermColor136Format : ClassificationFormatDefinition {
			public OutputTermColor136Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor136")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor136Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor136")]
		[Name("output.term.bgcolor136")]
		internal sealed class OutputTermBackgroundColor136Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor136Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.color137")]
		internal static ClassificationTypeDefinition outputTermColor137Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color137")]
		[Name("output.term.color137")]
		internal sealed class OutputTermColor137Format : ClassificationFormatDefinition {
			public OutputTermColor137Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor137")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor137Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor137")]
		[Name("output.term.bgcolor137")]
		internal sealed class OutputTermBackgroundColor137Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor137Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color138")]
		internal static ClassificationTypeDefinition outputTermColor138Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color138")]
		[Name("output.term.color138")]
		internal sealed class OutputTermColor138Format : ClassificationFormatDefinition {
			public OutputTermColor138Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor138")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor138Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor138")]
		[Name("output.term.bgcolor138")]
		internal sealed class OutputTermBackgroundColor138Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor138Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.color139")]
		internal static ClassificationTypeDefinition outputTermColor139Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color139")]
		[Name("output.term.color139")]
		internal sealed class OutputTermColor139Format : ClassificationFormatDefinition {
			public OutputTermColor139Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor139")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor139Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor139")]
		[Name("output.term.bgcolor139")]
		internal sealed class OutputTermBackgroundColor139Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor139Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color140")]
		internal static ClassificationTypeDefinition outputTermColor140Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color140")]
		[Name("output.term.color140")]
		internal sealed class OutputTermColor140Format : ClassificationFormatDefinition {
			public OutputTermColor140Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor140")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor140Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor140")]
		[Name("output.term.bgcolor140")]
		internal sealed class OutputTermBackgroundColor140Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor140Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color141")]
		internal static ClassificationTypeDefinition outputTermColor141Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color141")]
		[Name("output.term.color141")]
		internal sealed class OutputTermColor141Format : ClassificationFormatDefinition {
			public OutputTermColor141Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor141")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor141Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor141")]
		[Name("output.term.bgcolor141")]
		internal sealed class OutputTermBackgroundColor141Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor141Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.color142")]
		internal static ClassificationTypeDefinition outputTermColor142Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color142")]
		[Name("output.term.color142")]
		internal sealed class OutputTermColor142Format : ClassificationFormatDefinition {
			public OutputTermColor142Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor142")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor142Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor142")]
		[Name("output.term.bgcolor142")]
		internal sealed class OutputTermBackgroundColor142Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor142Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.color143")]
		internal static ClassificationTypeDefinition outputTermColor143Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color143")]
		[Name("output.term.color143")]
		internal sealed class OutputTermColor143Format : ClassificationFormatDefinition {
			public OutputTermColor143Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor143")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor143Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor143")]
		[Name("output.term.bgcolor143")]
		internal sealed class OutputTermBackgroundColor143Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor143Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color144")]
		internal static ClassificationTypeDefinition outputTermColor144Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color144")]
		[Name("output.term.color144")]
		internal sealed class OutputTermColor144Format : ClassificationFormatDefinition {
			public OutputTermColor144Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor144")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor144Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor144")]
		[Name("output.term.bgcolor144")]
		internal sealed class OutputTermBackgroundColor144Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor144Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.color145")]
		internal static ClassificationTypeDefinition outputTermColor145Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color145")]
		[Name("output.term.color145")]
		internal sealed class OutputTermColor145Format : ClassificationFormatDefinition {
			public OutputTermColor145Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor145")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor145Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor145")]
		[Name("output.term.bgcolor145")]
		internal sealed class OutputTermBackgroundColor145Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor145Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color146")]
		internal static ClassificationTypeDefinition outputTermColor146Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color146")]
		[Name("output.term.color146")]
		internal sealed class OutputTermColor146Format : ClassificationFormatDefinition {
			public OutputTermColor146Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor146")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor146Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor146")]
		[Name("output.term.bgcolor146")]
		internal sealed class OutputTermBackgroundColor146Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor146Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color147")]
		internal static ClassificationTypeDefinition outputTermColor147Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color147")]
		[Name("output.term.color147")]
		internal sealed class OutputTermColor147Format : ClassificationFormatDefinition {
			public OutputTermColor147Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor147")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor147Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor147")]
		[Name("output.term.bgcolor147")]
		internal sealed class OutputTermBackgroundColor147Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor147Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.color148")]
		internal static ClassificationTypeDefinition outputTermColor148Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color148")]
		[Name("output.term.color148")]
		internal sealed class OutputTermColor148Format : ClassificationFormatDefinition {
			public OutputTermColor148Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor148")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor148Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor148")]
		[Name("output.term.bgcolor148")]
		internal sealed class OutputTermBackgroundColor148Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor148Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.color149")]
		internal static ClassificationTypeDefinition outputTermColor149Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color149")]
		[Name("output.term.color149")]
		internal sealed class OutputTermColor149Format : ClassificationFormatDefinition {
			public OutputTermColor149Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor149")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor149Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor149")]
		[Name("output.term.bgcolor149")]
		internal sealed class OutputTermBackgroundColor149Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor149Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color150")]
		internal static ClassificationTypeDefinition outputTermColor150Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color150")]
		[Name("output.term.color150")]
		internal sealed class OutputTermColor150Format : ClassificationFormatDefinition {
			public OutputTermColor150Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor150")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor150Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor150")]
		[Name("output.term.bgcolor150")]
		internal sealed class OutputTermBackgroundColor150Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor150Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.color151")]
		internal static ClassificationTypeDefinition outputTermColor151Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color151")]
		[Name("output.term.color151")]
		internal sealed class OutputTermColor151Format : ClassificationFormatDefinition {
			public OutputTermColor151Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor151")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor151Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor151")]
		[Name("output.term.bgcolor151")]
		internal sealed class OutputTermBackgroundColor151Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor151Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color152")]
		internal static ClassificationTypeDefinition outputTermColor152Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color152")]
		[Name("output.term.color152")]
		internal sealed class OutputTermColor152Format : ClassificationFormatDefinition {
			public OutputTermColor152Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor152")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor152Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor152")]
		[Name("output.term.bgcolor152")]
		internal sealed class OutputTermBackgroundColor152Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor152Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color153")]
		internal static ClassificationTypeDefinition outputTermColor153Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color153")]
		[Name("output.term.color153")]
		internal sealed class OutputTermColor153Format : ClassificationFormatDefinition {
			public OutputTermColor153Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor153")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor153Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor153")]
		[Name("output.term.bgcolor153")]
		internal sealed class OutputTermBackgroundColor153Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor153Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.color154")]
		internal static ClassificationTypeDefinition outputTermColor154Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color154")]
		[Name("output.term.color154")]
		internal sealed class OutputTermColor154Format : ClassificationFormatDefinition {
			public OutputTermColor154Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor154")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor154Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor154")]
		[Name("output.term.bgcolor154")]
		internal sealed class OutputTermBackgroundColor154Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor154Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color155")]
		internal static ClassificationTypeDefinition outputTermColor155Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color155")]
		[Name("output.term.color155")]
		internal sealed class OutputTermColor155Format : ClassificationFormatDefinition {
			public OutputTermColor155Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor155")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor155Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor155")]
		[Name("output.term.bgcolor155")]
		internal sealed class OutputTermBackgroundColor155Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor155Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color156")]
		internal static ClassificationTypeDefinition outputTermColor156Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color156")]
		[Name("output.term.color156")]
		internal sealed class OutputTermColor156Format : ClassificationFormatDefinition {
			public OutputTermColor156Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor156")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor156Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor156")]
		[Name("output.term.bgcolor156")]
		internal sealed class OutputTermBackgroundColor156Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor156Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.color157")]
		internal static ClassificationTypeDefinition outputTermColor157Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color157")]
		[Name("output.term.color157")]
		internal sealed class OutputTermColor157Format : ClassificationFormatDefinition {
			public OutputTermColor157Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor157")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor157Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor157")]
		[Name("output.term.bgcolor157")]
		internal sealed class OutputTermBackgroundColor157Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor157Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color158")]
		internal static ClassificationTypeDefinition outputTermColor158Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color158")]
		[Name("output.term.color158")]
		internal sealed class OutputTermColor158Format : ClassificationFormatDefinition {
			public OutputTermColor158Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor158")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor158Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor158")]
		[Name("output.term.bgcolor158")]
		internal sealed class OutputTermBackgroundColor158Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor158Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color159")]
		internal static ClassificationTypeDefinition outputTermColor159Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color159")]
		[Name("output.term.color159")]
		internal sealed class OutputTermColor159Format : ClassificationFormatDefinition {
			public OutputTermColor159Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor159")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor159Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor159")]
		[Name("output.term.bgcolor159")]
		internal sealed class OutputTermBackgroundColor159Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor159Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xaf, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color160")]
		internal static ClassificationTypeDefinition outputTermColor160Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color160")]
		[Name("output.term.color160")]
		internal sealed class OutputTermColor160Format : ClassificationFormatDefinition {
			public OutputTermColor160Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor160")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor160Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor160")]
		[Name("output.term.bgcolor160")]
		internal sealed class OutputTermBackgroundColor160Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor160Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color161")]
		internal static ClassificationTypeDefinition outputTermColor161Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color161")]
		[Name("output.term.color161")]
		internal sealed class OutputTermColor161Format : ClassificationFormatDefinition {
			public OutputTermColor161Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor161")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor161Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor161")]
		[Name("output.term.bgcolor161")]
		internal sealed class OutputTermBackgroundColor161Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor161Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color162")]
		internal static ClassificationTypeDefinition outputTermColor162Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color162")]
		[Name("output.term.color162")]
		internal sealed class OutputTermColor162Format : ClassificationFormatDefinition {
			public OutputTermColor162Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor162")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor162Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor162")]
		[Name("output.term.bgcolor162")]
		internal sealed class OutputTermBackgroundColor162Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor162Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.color163")]
		internal static ClassificationTypeDefinition outputTermColor163Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color163")]
		[Name("output.term.color163")]
		internal sealed class OutputTermColor163Format : ClassificationFormatDefinition {
			public OutputTermColor163Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor163")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor163Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor163")]
		[Name("output.term.bgcolor163")]
		internal sealed class OutputTermBackgroundColor163Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor163Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color164")]
		internal static ClassificationTypeDefinition outputTermColor164Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color164")]
		[Name("output.term.color164")]
		internal sealed class OutputTermColor164Format : ClassificationFormatDefinition {
			public OutputTermColor164Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor164")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor164Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor164")]
		[Name("output.term.bgcolor164")]
		internal sealed class OutputTermBackgroundColor164Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor164Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color165")]
		internal static ClassificationTypeDefinition outputTermColor165Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color165")]
		[Name("output.term.color165")]
		internal sealed class OutputTermColor165Format : ClassificationFormatDefinition {
			public OutputTermColor165Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor165")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor165Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor165")]
		[Name("output.term.bgcolor165")]
		internal sealed class OutputTermBackgroundColor165Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor165Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color166")]
		internal static ClassificationTypeDefinition outputTermColor166Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color166")]
		[Name("output.term.color166")]
		internal sealed class OutputTermColor166Format : ClassificationFormatDefinition {
			public OutputTermColor166Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor166")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor166Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor166")]
		[Name("output.term.bgcolor166")]
		internal sealed class OutputTermBackgroundColor166Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor166Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.color167")]
		internal static ClassificationTypeDefinition outputTermColor167Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color167")]
		[Name("output.term.color167")]
		internal sealed class OutputTermColor167Format : ClassificationFormatDefinition {
			public OutputTermColor167Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor167")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor167Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor167")]
		[Name("output.term.bgcolor167")]
		internal sealed class OutputTermBackgroundColor167Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor167Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color168")]
		internal static ClassificationTypeDefinition outputTermColor168Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color168")]
		[Name("output.term.color168")]
		internal sealed class OutputTermColor168Format : ClassificationFormatDefinition {
			public OutputTermColor168Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor168")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor168Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor168")]
		[Name("output.term.bgcolor168")]
		internal sealed class OutputTermBackgroundColor168Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor168Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.color169")]
		internal static ClassificationTypeDefinition outputTermColor169Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color169")]
		[Name("output.term.color169")]
		internal sealed class OutputTermColor169Format : ClassificationFormatDefinition {
			public OutputTermColor169Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor169")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor169Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor169")]
		[Name("output.term.bgcolor169")]
		internal sealed class OutputTermBackgroundColor169Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor169Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color170")]
		internal static ClassificationTypeDefinition outputTermColor170Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color170")]
		[Name("output.term.color170")]
		internal sealed class OutputTermColor170Format : ClassificationFormatDefinition {
			public OutputTermColor170Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor170")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor170Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor170")]
		[Name("output.term.bgcolor170")]
		internal sealed class OutputTermBackgroundColor170Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor170Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color171")]
		internal static ClassificationTypeDefinition outputTermColor171Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color171")]
		[Name("output.term.color171")]
		internal sealed class OutputTermColor171Format : ClassificationFormatDefinition {
			public OutputTermColor171Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor171")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor171Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor171")]
		[Name("output.term.bgcolor171")]
		internal sealed class OutputTermBackgroundColor171Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor171Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.color172")]
		internal static ClassificationTypeDefinition outputTermColor172Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color172")]
		[Name("output.term.color172")]
		internal sealed class OutputTermColor172Format : ClassificationFormatDefinition {
			public OutputTermColor172Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor172")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor172Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor172")]
		[Name("output.term.bgcolor172")]
		internal sealed class OutputTermBackgroundColor172Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor172Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.color173")]
		internal static ClassificationTypeDefinition outputTermColor173Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color173")]
		[Name("output.term.color173")]
		internal sealed class OutputTermColor173Format : ClassificationFormatDefinition {
			public OutputTermColor173Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor173")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor173Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor173")]
		[Name("output.term.bgcolor173")]
		internal sealed class OutputTermBackgroundColor173Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor173Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color174")]
		internal static ClassificationTypeDefinition outputTermColor174Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color174")]
		[Name("output.term.color174")]
		internal sealed class OutputTermColor174Format : ClassificationFormatDefinition {
			public OutputTermColor174Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor174")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor174Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor174")]
		[Name("output.term.bgcolor174")]
		internal sealed class OutputTermBackgroundColor174Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor174Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.color175")]
		internal static ClassificationTypeDefinition outputTermColor175Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color175")]
		[Name("output.term.color175")]
		internal sealed class OutputTermColor175Format : ClassificationFormatDefinition {
			public OutputTermColor175Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor175")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor175Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor175")]
		[Name("output.term.bgcolor175")]
		internal sealed class OutputTermBackgroundColor175Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor175Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color176")]
		internal static ClassificationTypeDefinition outputTermColor176Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color176")]
		[Name("output.term.color176")]
		internal sealed class OutputTermColor176Format : ClassificationFormatDefinition {
			public OutputTermColor176Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor176")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor176Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor176")]
		[Name("output.term.bgcolor176")]
		internal sealed class OutputTermBackgroundColor176Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor176Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color177")]
		internal static ClassificationTypeDefinition outputTermColor177Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color177")]
		[Name("output.term.color177")]
		internal sealed class OutputTermColor177Format : ClassificationFormatDefinition {
			public OutputTermColor177Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor177")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor177Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor177")]
		[Name("output.term.bgcolor177")]
		internal sealed class OutputTermBackgroundColor177Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor177Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.color178")]
		internal static ClassificationTypeDefinition outputTermColor178Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color178")]
		[Name("output.term.color178")]
		internal sealed class OutputTermColor178Format : ClassificationFormatDefinition {
			public OutputTermColor178Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor178")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor178Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor178")]
		[Name("output.term.bgcolor178")]
		internal sealed class OutputTermBackgroundColor178Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor178Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.color179")]
		internal static ClassificationTypeDefinition outputTermColor179Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color179")]
		[Name("output.term.color179")]
		internal sealed class OutputTermColor179Format : ClassificationFormatDefinition {
			public OutputTermColor179Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor179")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor179Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor179")]
		[Name("output.term.bgcolor179")]
		internal sealed class OutputTermBackgroundColor179Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor179Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color180")]
		internal static ClassificationTypeDefinition outputTermColor180Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color180")]
		[Name("output.term.color180")]
		internal sealed class OutputTermColor180Format : ClassificationFormatDefinition {
			public OutputTermColor180Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor180")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor180Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor180")]
		[Name("output.term.bgcolor180")]
		internal sealed class OutputTermBackgroundColor180Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor180Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.color181")]
		internal static ClassificationTypeDefinition outputTermColor181Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color181")]
		[Name("output.term.color181")]
		internal sealed class OutputTermColor181Format : ClassificationFormatDefinition {
			public OutputTermColor181Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor181")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor181Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor181")]
		[Name("output.term.bgcolor181")]
		internal sealed class OutputTermBackgroundColor181Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor181Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color182")]
		internal static ClassificationTypeDefinition outputTermColor182Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color182")]
		[Name("output.term.color182")]
		internal sealed class OutputTermColor182Format : ClassificationFormatDefinition {
			public OutputTermColor182Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor182")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor182Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor182")]
		[Name("output.term.bgcolor182")]
		internal sealed class OutputTermBackgroundColor182Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor182Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color183")]
		internal static ClassificationTypeDefinition outputTermColor183Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color183")]
		[Name("output.term.color183")]
		internal sealed class OutputTermColor183Format : ClassificationFormatDefinition {
			public OutputTermColor183Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor183")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor183Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor183")]
		[Name("output.term.bgcolor183")]
		internal sealed class OutputTermBackgroundColor183Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor183Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.color184")]
		internal static ClassificationTypeDefinition outputTermColor184Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color184")]
		[Name("output.term.color184")]
		internal sealed class OutputTermColor184Format : ClassificationFormatDefinition {
			public OutputTermColor184Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor184")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor184Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor184")]
		[Name("output.term.bgcolor184")]
		internal sealed class OutputTermBackgroundColor184Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor184Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.color185")]
		internal static ClassificationTypeDefinition outputTermColor185Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color185")]
		[Name("output.term.color185")]
		internal sealed class OutputTermColor185Format : ClassificationFormatDefinition {
			public OutputTermColor185Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor185")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor185Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor185")]
		[Name("output.term.bgcolor185")]
		internal sealed class OutputTermBackgroundColor185Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor185Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color186")]
		internal static ClassificationTypeDefinition outputTermColor186Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color186")]
		[Name("output.term.color186")]
		internal sealed class OutputTermColor186Format : ClassificationFormatDefinition {
			public OutputTermColor186Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor186")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor186Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor186")]
		[Name("output.term.bgcolor186")]
		internal sealed class OutputTermBackgroundColor186Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor186Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.color187")]
		internal static ClassificationTypeDefinition outputTermColor187Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color187")]
		[Name("output.term.color187")]
		internal sealed class OutputTermColor187Format : ClassificationFormatDefinition {
			public OutputTermColor187Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor187")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor187Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor187")]
		[Name("output.term.bgcolor187")]
		internal sealed class OutputTermBackgroundColor187Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor187Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color188")]
		internal static ClassificationTypeDefinition outputTermColor188Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color188")]
		[Name("output.term.color188")]
		internal sealed class OutputTermColor188Format : ClassificationFormatDefinition {
			public OutputTermColor188Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor188")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor188Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor188")]
		[Name("output.term.bgcolor188")]
		internal sealed class OutputTermBackgroundColor188Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor188Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color189")]
		internal static ClassificationTypeDefinition outputTermColor189Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color189")]
		[Name("output.term.color189")]
		internal sealed class OutputTermColor189Format : ClassificationFormatDefinition {
			public OutputTermColor189Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor189")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor189Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor189")]
		[Name("output.term.bgcolor189")]
		internal sealed class OutputTermBackgroundColor189Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor189Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.color190")]
		internal static ClassificationTypeDefinition outputTermColor190Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color190")]
		[Name("output.term.color190")]
		internal sealed class OutputTermColor190Format : ClassificationFormatDefinition {
			public OutputTermColor190Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor190")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor190Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor190")]
		[Name("output.term.bgcolor190")]
		internal sealed class OutputTermBackgroundColor190Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor190Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color191")]
		internal static ClassificationTypeDefinition outputTermColor191Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color191")]
		[Name("output.term.color191")]
		internal sealed class OutputTermColor191Format : ClassificationFormatDefinition {
			public OutputTermColor191Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor191")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor191Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor191")]
		[Name("output.term.bgcolor191")]
		internal sealed class OutputTermBackgroundColor191Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor191Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color192")]
		internal static ClassificationTypeDefinition outputTermColor192Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color192")]
		[Name("output.term.color192")]
		internal sealed class OutputTermColor192Format : ClassificationFormatDefinition {
			public OutputTermColor192Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor192")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor192Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor192")]
		[Name("output.term.bgcolor192")]
		internal sealed class OutputTermBackgroundColor192Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor192Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.color193")]
		internal static ClassificationTypeDefinition outputTermColor193Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color193")]
		[Name("output.term.color193")]
		internal sealed class OutputTermColor193Format : ClassificationFormatDefinition {
			public OutputTermColor193Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor193")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor193Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor193")]
		[Name("output.term.bgcolor193")]
		internal sealed class OutputTermBackgroundColor193Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor193Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color194")]
		internal static ClassificationTypeDefinition outputTermColor194Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color194")]
		[Name("output.term.color194")]
		internal sealed class OutputTermColor194Format : ClassificationFormatDefinition {
			public OutputTermColor194Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor194")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor194Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor194")]
		[Name("output.term.bgcolor194")]
		internal sealed class OutputTermBackgroundColor194Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor194Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color195")]
		internal static ClassificationTypeDefinition outputTermColor195Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color195")]
		[Name("output.term.color195")]
		internal sealed class OutputTermColor195Format : ClassificationFormatDefinition {
			public OutputTermColor195Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor195")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor195Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor195")]
		[Name("output.term.bgcolor195")]
		internal sealed class OutputTermBackgroundColor195Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor195Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd7, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color196")]
		internal static ClassificationTypeDefinition outputTermColor196Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color196")]
		[Name("output.term.color196")]
		internal sealed class OutputTermColor196Format : ClassificationFormatDefinition {
			public OutputTermColor196Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor196")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor196Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor196")]
		[Name("output.term.bgcolor196")]
		internal sealed class OutputTermBackgroundColor196Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor196Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x00);
			}
		}

		[Export]
		[Name("output.term.color197")]
		internal static ClassificationTypeDefinition outputTermColor197Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color197")]
		[Name("output.term.color197")]
		internal sealed class OutputTermColor197Format : ClassificationFormatDefinition {
			public OutputTermColor197Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor197")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor197Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor197")]
		[Name("output.term.bgcolor197")]
		internal sealed class OutputTermBackgroundColor197Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor197Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color198")]
		internal static ClassificationTypeDefinition outputTermColor198Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color198")]
		[Name("output.term.color198")]
		internal sealed class OutputTermColor198Format : ClassificationFormatDefinition {
			public OutputTermColor198Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor198")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor198Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor198")]
		[Name("output.term.bgcolor198")]
		internal sealed class OutputTermBackgroundColor198Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor198Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0x87);
			}
		}

		[Export]
		[Name("output.term.color199")]
		internal static ClassificationTypeDefinition outputTermColor199Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color199")]
		[Name("output.term.color199")]
		internal sealed class OutputTermColor199Format : ClassificationFormatDefinition {
			public OutputTermColor199Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor199")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor199Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor199")]
		[Name("output.term.bgcolor199")]
		internal sealed class OutputTermBackgroundColor199Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor199Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color200")]
		internal static ClassificationTypeDefinition outputTermColor200Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color200")]
		[Name("output.term.color200")]
		internal sealed class OutputTermColor200Format : ClassificationFormatDefinition {
			public OutputTermColor200Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor200")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor200Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor200")]
		[Name("output.term.bgcolor200")]
		internal sealed class OutputTermBackgroundColor200Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor200Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color201")]
		internal static ClassificationTypeDefinition outputTermColor201Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color201")]
		[Name("output.term.color201")]
		internal sealed class OutputTermColor201Format : ClassificationFormatDefinition {
			public OutputTermColor201Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor201")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor201Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor201")]
		[Name("output.term.bgcolor201")]
		internal sealed class OutputTermBackgroundColor201Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor201Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x00, 0xff);
			}
		}

		[Export]
		[Name("output.term.color202")]
		internal static ClassificationTypeDefinition outputTermColor202Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color202")]
		[Name("output.term.color202")]
		internal sealed class OutputTermColor202Format : ClassificationFormatDefinition {
			public OutputTermColor202Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor202")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor202Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor202")]
		[Name("output.term.bgcolor202")]
		internal sealed class OutputTermBackgroundColor202Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor202Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0x00);
			}
		}

		[Export]
		[Name("output.term.color203")]
		internal static ClassificationTypeDefinition outputTermColor203Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color203")]
		[Name("output.term.color203")]
		internal sealed class OutputTermColor203Format : ClassificationFormatDefinition {
			public OutputTermColor203Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor203")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor203Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor203")]
		[Name("output.term.bgcolor203")]
		internal sealed class OutputTermBackgroundColor203Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor203Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color204")]
		internal static ClassificationTypeDefinition outputTermColor204Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color204")]
		[Name("output.term.color204")]
		internal sealed class OutputTermColor204Format : ClassificationFormatDefinition {
			public OutputTermColor204Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor204")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor204Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor204")]
		[Name("output.term.bgcolor204")]
		internal sealed class OutputTermBackgroundColor204Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor204Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0x87);
			}
		}

		[Export]
		[Name("output.term.color205")]
		internal static ClassificationTypeDefinition outputTermColor205Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color205")]
		[Name("output.term.color205")]
		internal sealed class OutputTermColor205Format : ClassificationFormatDefinition {
			public OutputTermColor205Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor205")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor205Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor205")]
		[Name("output.term.bgcolor205")]
		internal sealed class OutputTermBackgroundColor205Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor205Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color206")]
		internal static ClassificationTypeDefinition outputTermColor206Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color206")]
		[Name("output.term.color206")]
		internal sealed class OutputTermColor206Format : ClassificationFormatDefinition {
			public OutputTermColor206Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor206")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor206Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor206")]
		[Name("output.term.bgcolor206")]
		internal sealed class OutputTermBackgroundColor206Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor206Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color207")]
		internal static ClassificationTypeDefinition outputTermColor207Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color207")]
		[Name("output.term.color207")]
		internal sealed class OutputTermColor207Format : ClassificationFormatDefinition {
			public OutputTermColor207Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor207")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor207Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor207")]
		[Name("output.term.bgcolor207")]
		internal sealed class OutputTermBackgroundColor207Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor207Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x5f, 0xff);
			}
		}

		[Export]
		[Name("output.term.color208")]
		internal static ClassificationTypeDefinition outputTermColor208Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color208")]
		[Name("output.term.color208")]
		internal sealed class OutputTermColor208Format : ClassificationFormatDefinition {
			public OutputTermColor208Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor208")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor208Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor208")]
		[Name("output.term.bgcolor208")]
		internal sealed class OutputTermBackgroundColor208Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor208Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0x00);
			}
		}

		[Export]
		[Name("output.term.color209")]
		internal static ClassificationTypeDefinition outputTermColor209Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color209")]
		[Name("output.term.color209")]
		internal sealed class OutputTermColor209Format : ClassificationFormatDefinition {
			public OutputTermColor209Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor209")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor209Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor209")]
		[Name("output.term.bgcolor209")]
		internal sealed class OutputTermBackgroundColor209Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor209Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color210")]
		internal static ClassificationTypeDefinition outputTermColor210Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color210")]
		[Name("output.term.color210")]
		internal sealed class OutputTermColor210Format : ClassificationFormatDefinition {
			public OutputTermColor210Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor210")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor210Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor210")]
		[Name("output.term.bgcolor210")]
		internal sealed class OutputTermBackgroundColor210Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor210Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0x87);
			}
		}

		[Export]
		[Name("output.term.color211")]
		internal static ClassificationTypeDefinition outputTermColor211Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color211")]
		[Name("output.term.color211")]
		internal sealed class OutputTermColor211Format : ClassificationFormatDefinition {
			public OutputTermColor211Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor211")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor211Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor211")]
		[Name("output.term.bgcolor211")]
		internal sealed class OutputTermBackgroundColor211Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor211Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color212")]
		internal static ClassificationTypeDefinition outputTermColor212Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color212")]
		[Name("output.term.color212")]
		internal sealed class OutputTermColor212Format : ClassificationFormatDefinition {
			public OutputTermColor212Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor212")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor212Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor212")]
		[Name("output.term.bgcolor212")]
		internal sealed class OutputTermBackgroundColor212Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor212Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color213")]
		internal static ClassificationTypeDefinition outputTermColor213Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color213")]
		[Name("output.term.color213")]
		internal sealed class OutputTermColor213Format : ClassificationFormatDefinition {
			public OutputTermColor213Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor213")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor213Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor213")]
		[Name("output.term.bgcolor213")]
		internal sealed class OutputTermBackgroundColor213Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor213Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0x87, 0xff);
			}
		}

		[Export]
		[Name("output.term.color214")]
		internal static ClassificationTypeDefinition outputTermColor214Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color214")]
		[Name("output.term.color214")]
		internal sealed class OutputTermColor214Format : ClassificationFormatDefinition {
			public OutputTermColor214Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor214")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor214Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor214")]
		[Name("output.term.bgcolor214")]
		internal sealed class OutputTermBackgroundColor214Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor214Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0x00);
			}
		}

		[Export]
		[Name("output.term.color215")]
		internal static ClassificationTypeDefinition outputTermColor215Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color215")]
		[Name("output.term.color215")]
		internal sealed class OutputTermColor215Format : ClassificationFormatDefinition {
			public OutputTermColor215Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor215")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor215Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor215")]
		[Name("output.term.bgcolor215")]
		internal sealed class OutputTermBackgroundColor215Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor215Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color216")]
		internal static ClassificationTypeDefinition outputTermColor216Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color216")]
		[Name("output.term.color216")]
		internal sealed class OutputTermColor216Format : ClassificationFormatDefinition {
			public OutputTermColor216Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor216")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor216Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor216")]
		[Name("output.term.bgcolor216")]
		internal sealed class OutputTermBackgroundColor216Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor216Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0x87);
			}
		}

		[Export]
		[Name("output.term.color217")]
		internal static ClassificationTypeDefinition outputTermColor217Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color217")]
		[Name("output.term.color217")]
		internal sealed class OutputTermColor217Format : ClassificationFormatDefinition {
			public OutputTermColor217Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor217")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor217Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor217")]
		[Name("output.term.bgcolor217")]
		internal sealed class OutputTermBackgroundColor217Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor217Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color218")]
		internal static ClassificationTypeDefinition outputTermColor218Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color218")]
		[Name("output.term.color218")]
		internal sealed class OutputTermColor218Format : ClassificationFormatDefinition {
			public OutputTermColor218Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor218")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor218Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor218")]
		[Name("output.term.bgcolor218")]
		internal sealed class OutputTermBackgroundColor218Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor218Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color219")]
		internal static ClassificationTypeDefinition outputTermColor219Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color219")]
		[Name("output.term.color219")]
		internal sealed class OutputTermColor219Format : ClassificationFormatDefinition {
			public OutputTermColor219Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor219")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor219Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor219")]
		[Name("output.term.bgcolor219")]
		internal sealed class OutputTermBackgroundColor219Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor219Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xaf, 0xff);
			}
		}

		[Export]
		[Name("output.term.color220")]
		internal static ClassificationTypeDefinition outputTermColor220Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color220")]
		[Name("output.term.color220")]
		internal sealed class OutputTermColor220Format : ClassificationFormatDefinition {
			public OutputTermColor220Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor220")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor220Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor220")]
		[Name("output.term.bgcolor220")]
		internal sealed class OutputTermBackgroundColor220Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor220Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0x00);
			}
		}

		[Export]
		[Name("output.term.color221")]
		internal static ClassificationTypeDefinition outputTermColor221Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color221")]
		[Name("output.term.color221")]
		internal sealed class OutputTermColor221Format : ClassificationFormatDefinition {
			public OutputTermColor221Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor221")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor221Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor221")]
		[Name("output.term.bgcolor221")]
		internal sealed class OutputTermBackgroundColor221Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor221Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color222")]
		internal static ClassificationTypeDefinition outputTermColor222Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color222")]
		[Name("output.term.color222")]
		internal sealed class OutputTermColor222Format : ClassificationFormatDefinition {
			public OutputTermColor222Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor222")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor222Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor222")]
		[Name("output.term.bgcolor222")]
		internal sealed class OutputTermBackgroundColor222Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor222Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0x87);
			}
		}

		[Export]
		[Name("output.term.color223")]
		internal static ClassificationTypeDefinition outputTermColor223Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color223")]
		[Name("output.term.color223")]
		internal sealed class OutputTermColor223Format : ClassificationFormatDefinition {
			public OutputTermColor223Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor223")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor223Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor223")]
		[Name("output.term.bgcolor223")]
		internal sealed class OutputTermBackgroundColor223Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor223Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color224")]
		internal static ClassificationTypeDefinition outputTermColor224Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color224")]
		[Name("output.term.color224")]
		internal sealed class OutputTermColor224Format : ClassificationFormatDefinition {
			public OutputTermColor224Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor224")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor224Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor224")]
		[Name("output.term.bgcolor224")]
		internal sealed class OutputTermBackgroundColor224Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor224Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color225")]
		internal static ClassificationTypeDefinition outputTermColor225Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color225")]
		[Name("output.term.color225")]
		internal sealed class OutputTermColor225Format : ClassificationFormatDefinition {
			public OutputTermColor225Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor225")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor225Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor225")]
		[Name("output.term.bgcolor225")]
		internal sealed class OutputTermBackgroundColor225Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor225Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xd7, 0xff);
			}
		}

		[Export]
		[Name("output.term.color226")]
		internal static ClassificationTypeDefinition outputTermColor226Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color226")]
		[Name("output.term.color226")]
		internal sealed class OutputTermColor226Format : ClassificationFormatDefinition {
			public OutputTermColor226Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.bgcolor226")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor226Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor226")]
		[Name("output.term.bgcolor226")]
		internal sealed class OutputTermBackgroundColor226Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor226Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x00);
			}
		}

		[Export]
		[Name("output.term.color227")]
		internal static ClassificationTypeDefinition outputTermColor227Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color227")]
		[Name("output.term.color227")]
		internal sealed class OutputTermColor227Format : ClassificationFormatDefinition {
			public OutputTermColor227Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.bgcolor227")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor227Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor227")]
		[Name("output.term.bgcolor227")]
		internal sealed class OutputTermBackgroundColor227Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor227Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x5f);
			}
		}

		[Export]
		[Name("output.term.color228")]
		internal static ClassificationTypeDefinition outputTermColor228Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color228")]
		[Name("output.term.color228")]
		internal sealed class OutputTermColor228Format : ClassificationFormatDefinition {
			public OutputTermColor228Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.bgcolor228")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor228Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor228")]
		[Name("output.term.bgcolor228")]
		internal sealed class OutputTermBackgroundColor228Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor228Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0x87);
			}
		}

		[Export]
		[Name("output.term.color229")]
		internal static ClassificationTypeDefinition outputTermColor229Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color229")]
		[Name("output.term.color229")]
		internal sealed class OutputTermColor229Format : ClassificationFormatDefinition {
			public OutputTermColor229Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.bgcolor229")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor229Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor229")]
		[Name("output.term.bgcolor229")]
		internal sealed class OutputTermBackgroundColor229Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor229Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xaf);
			}
		}

		[Export]
		[Name("output.term.color230")]
		internal static ClassificationTypeDefinition outputTermColor230Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color230")]
		[Name("output.term.color230")]
		internal sealed class OutputTermColor230Format : ClassificationFormatDefinition {
			public OutputTermColor230Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.bgcolor230")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor230Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor230")]
		[Name("output.term.bgcolor230")]
		internal sealed class OutputTermBackgroundColor230Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor230Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xd7);
			}
		}

		[Export]
		[Name("output.term.color231")]
		internal static ClassificationTypeDefinition outputTermColor231Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color231")]
		[Name("output.term.color231")]
		internal sealed class OutputTermColor231Format : ClassificationFormatDefinition {
			public OutputTermColor231Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.bgcolor231")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor231Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor231")]
		[Name("output.term.bgcolor231")]
		internal sealed class OutputTermBackgroundColor231Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor231Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xff, 0xff, 0xff);
			}
		}

		[Export]
		[Name("output.term.color232")]
		internal static ClassificationTypeDefinition outputTermColor232Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color232")]
		[Name("output.term.color232")]
		internal sealed class OutputTermColor232Format : ClassificationFormatDefinition {
			public OutputTermColor232Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x08, 0x08, 0x08);
			}
		}

		[Export]
		[Name("output.term.bgcolor232")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor232Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor232")]
		[Name("output.term.bgcolor232")]
		internal sealed class OutputTermBackgroundColor232Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor232Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x08, 0x08, 0x08);
			}
		}

		[Export]
		[Name("output.term.color233")]
		internal static ClassificationTypeDefinition outputTermColor233Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color233")]
		[Name("output.term.color233")]
		internal sealed class OutputTermColor233Format : ClassificationFormatDefinition {
			public OutputTermColor233Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x12, 0x12, 0x12);
			}
		}

		[Export]
		[Name("output.term.bgcolor233")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor233Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor233")]
		[Name("output.term.bgcolor233")]
		internal sealed class OutputTermBackgroundColor233Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor233Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x12, 0x12, 0x12);
			}
		}

		[Export]
		[Name("output.term.color234")]
		internal static ClassificationTypeDefinition outputTermColor234Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color234")]
		[Name("output.term.color234")]
		internal sealed class OutputTermColor234Format : ClassificationFormatDefinition {
			public OutputTermColor234Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x1c, 0x1c, 0x1c);
			}
		}

		[Export]
		[Name("output.term.bgcolor234")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor234Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor234")]
		[Name("output.term.bgcolor234")]
		internal sealed class OutputTermBackgroundColor234Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor234Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x1c, 0x1c, 0x1c);
			}
		}

		[Export]
		[Name("output.term.color235")]
		internal static ClassificationTypeDefinition outputTermColor235Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color235")]
		[Name("output.term.color235")]
		internal sealed class OutputTermColor235Format : ClassificationFormatDefinition {
			public OutputTermColor235Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x26, 0x26, 0x26);
			}
		}

		[Export]
		[Name("output.term.bgcolor235")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor235Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor235")]
		[Name("output.term.bgcolor235")]
		internal sealed class OutputTermBackgroundColor235Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor235Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x26, 0x26, 0x26);
			}
		}

		[Export]
		[Name("output.term.color236")]
		internal static ClassificationTypeDefinition outputTermColor236Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color236")]
		[Name("output.term.color236")]
		internal sealed class OutputTermColor236Format : ClassificationFormatDefinition {
			public OutputTermColor236Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x30, 0x30, 0x30);
			}
		}

		[Export]
		[Name("output.term.bgcolor236")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor236Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor236")]
		[Name("output.term.bgcolor236")]
		internal sealed class OutputTermBackgroundColor236Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor236Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x30, 0x30, 0x30);
			}
		}

		[Export]
		[Name("output.term.color237")]
		internal static ClassificationTypeDefinition outputTermColor237Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color237")]
		[Name("output.term.color237")]
		internal sealed class OutputTermColor237Format : ClassificationFormatDefinition {
			public OutputTermColor237Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x3a, 0x3a, 0x3a);
			}
		}

		[Export]
		[Name("output.term.bgcolor237")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor237Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor237")]
		[Name("output.term.bgcolor237")]
		internal sealed class OutputTermBackgroundColor237Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor237Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x3a, 0x3a, 0x3a);
			}
		}

		[Export]
		[Name("output.term.color238")]
		internal static ClassificationTypeDefinition outputTermColor238Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color238")]
		[Name("output.term.color238")]
		internal sealed class OutputTermColor238Format : ClassificationFormatDefinition {
			public OutputTermColor238Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x44, 0x44, 0x44);
			}
		}

		[Export]
		[Name("output.term.bgcolor238")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor238Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor238")]
		[Name("output.term.bgcolor238")]
		internal sealed class OutputTermBackgroundColor238Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor238Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x44, 0x44, 0x44);
			}
		}

		[Export]
		[Name("output.term.color239")]
		internal static ClassificationTypeDefinition outputTermColor239Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color239")]
		[Name("output.term.color239")]
		internal sealed class OutputTermColor239Format : ClassificationFormatDefinition {
			public OutputTermColor239Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x4e, 0x4e, 0x4e);
			}
		}

		[Export]
		[Name("output.term.bgcolor239")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor239Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor239")]
		[Name("output.term.bgcolor239")]
		internal sealed class OutputTermBackgroundColor239Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor239Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x4e, 0x4e, 0x4e);
			}
		}

		[Export]
		[Name("output.term.color240")]
		internal static ClassificationTypeDefinition outputTermColor240Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color240")]
		[Name("output.term.color240")]
		internal sealed class OutputTermColor240Format : ClassificationFormatDefinition {
			public OutputTermColor240Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x58, 0x58, 0x58);
			}
		}

		[Export]
		[Name("output.term.bgcolor240")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor240Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor240")]
		[Name("output.term.bgcolor240")]
		internal sealed class OutputTermBackgroundColor240Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor240Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x58, 0x58, 0x58);
			}
		}

		[Export]
		[Name("output.term.color241")]
		internal static ClassificationTypeDefinition outputTermColor241Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color241")]
		[Name("output.term.color241")]
		internal sealed class OutputTermColor241Format : ClassificationFormatDefinition {
			public OutputTermColor241Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x62, 0x62, 0x62);
			}
		}

		[Export]
		[Name("output.term.bgcolor241")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor241Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor241")]
		[Name("output.term.bgcolor241")]
		internal sealed class OutputTermBackgroundColor241Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor241Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x62, 0x62, 0x62);
			}
		}

		[Export]
		[Name("output.term.color242")]
		internal static ClassificationTypeDefinition outputTermColor242Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color242")]
		[Name("output.term.color242")]
		internal sealed class OutputTermColor242Format : ClassificationFormatDefinition {
			public OutputTermColor242Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x6c, 0x6c, 0x6c);
			}
		}

		[Export]
		[Name("output.term.bgcolor242")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor242Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor242")]
		[Name("output.term.bgcolor242")]
		internal sealed class OutputTermBackgroundColor242Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor242Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x6c, 0x6c, 0x6c);
			}
		}

		[Export]
		[Name("output.term.color243")]
		internal static ClassificationTypeDefinition outputTermColor243Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color243")]
		[Name("output.term.color243")]
		internal sealed class OutputTermColor243Format : ClassificationFormatDefinition {
			public OutputTermColor243Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x76, 0x76, 0x76);
			}
		}

		[Export]
		[Name("output.term.bgcolor243")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor243Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor243")]
		[Name("output.term.bgcolor243")]
		internal sealed class OutputTermBackgroundColor243Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor243Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x76, 0x76, 0x76);
			}
		}

		[Export]
		[Name("output.term.color244")]
		internal static ClassificationTypeDefinition outputTermColor244Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color244")]
		[Name("output.term.color244")]
		internal sealed class OutputTermColor244Format : ClassificationFormatDefinition {
			public OutputTermColor244Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x80, 0x80);
			}
		}

		[Export]
		[Name("output.term.bgcolor244")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor244Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor244")]
		[Name("output.term.bgcolor244")]
		internal sealed class OutputTermBackgroundColor244Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor244Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x80, 0x80, 0x80);
			}
		}

		[Export]
		[Name("output.term.color245")]
		internal static ClassificationTypeDefinition outputTermColor245Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color245")]
		[Name("output.term.color245")]
		internal sealed class OutputTermColor245Format : ClassificationFormatDefinition {
			public OutputTermColor245Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x8a, 0x8a, 0x8a);
			}
		}

		[Export]
		[Name("output.term.bgcolor245")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor245Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor245")]
		[Name("output.term.bgcolor245")]
		internal sealed class OutputTermBackgroundColor245Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor245Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x8a, 0x8a, 0x8a);
			}
		}

		[Export]
		[Name("output.term.color246")]
		internal static ClassificationTypeDefinition outputTermColor246Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color246")]
		[Name("output.term.color246")]
		internal sealed class OutputTermColor246Format : ClassificationFormatDefinition {
			public OutputTermColor246Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x94, 0x94, 0x94);
			}
		}

		[Export]
		[Name("output.term.bgcolor246")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor246Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor246")]
		[Name("output.term.bgcolor246")]
		internal sealed class OutputTermBackgroundColor246Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor246Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x94, 0x94, 0x94);
			}
		}

		[Export]
		[Name("output.term.color247")]
		internal static ClassificationTypeDefinition outputTermColor247Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color247")]
		[Name("output.term.color247")]
		internal sealed class OutputTermColor247Format : ClassificationFormatDefinition {
			public OutputTermColor247Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x9e, 0x9e, 0x9e);
			}
		}

		[Export]
		[Name("output.term.bgcolor247")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor247Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor247")]
		[Name("output.term.bgcolor247")]
		internal sealed class OutputTermBackgroundColor247Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor247Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0x9e, 0x9e, 0x9e);
			}
		}

		[Export]
		[Name("output.term.color248")]
		internal static ClassificationTypeDefinition outputTermColor248Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color248")]
		[Name("output.term.color248")]
		internal sealed class OutputTermColor248Format : ClassificationFormatDefinition {
			public OutputTermColor248Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xa8, 0xa8, 0xa8);
			}
		}

		[Export]
		[Name("output.term.bgcolor248")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor248Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor248")]
		[Name("output.term.bgcolor248")]
		internal sealed class OutputTermBackgroundColor248Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor248Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xa8, 0xa8, 0xa8);
			}
		}

		[Export]
		[Name("output.term.color249")]
		internal static ClassificationTypeDefinition outputTermColor249Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color249")]
		[Name("output.term.color249")]
		internal sealed class OutputTermColor249Format : ClassificationFormatDefinition {
			public OutputTermColor249Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xb2, 0xb2, 0xb2);
			}
		}

		[Export]
		[Name("output.term.bgcolor249")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor249Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor249")]
		[Name("output.term.bgcolor249")]
		internal sealed class OutputTermBackgroundColor249Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor249Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xb2, 0xb2, 0xb2);
			}
		}

		[Export]
		[Name("output.term.color250")]
		internal static ClassificationTypeDefinition outputTermColor250Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color250")]
		[Name("output.term.color250")]
		internal sealed class OutputTermColor250Format : ClassificationFormatDefinition {
			public OutputTermColor250Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xbc, 0xbc, 0xbc);
			}
		}

		[Export]
		[Name("output.term.bgcolor250")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor250Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor250")]
		[Name("output.term.bgcolor250")]
		internal sealed class OutputTermBackgroundColor250Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor250Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xbc, 0xbc, 0xbc);
			}
		}

		[Export]
		[Name("output.term.color251")]
		internal static ClassificationTypeDefinition outputTermColor251Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color251")]
		[Name("output.term.color251")]
		internal sealed class OutputTermColor251Format : ClassificationFormatDefinition {
			public OutputTermColor251Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xc6, 0xc6, 0xc6);
			}
		}

		[Export]
		[Name("output.term.bgcolor251")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor251Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor251")]
		[Name("output.term.bgcolor251")]
		internal sealed class OutputTermBackgroundColor251Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor251Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xc6, 0xc6, 0xc6);
			}
		}

		[Export]
		[Name("output.term.color252")]
		internal static ClassificationTypeDefinition outputTermColor252Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color252")]
		[Name("output.term.color252")]
		internal sealed class OutputTermColor252Format : ClassificationFormatDefinition {
			public OutputTermColor252Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd0, 0xd0, 0xd0);
			}
		}

		[Export]
		[Name("output.term.bgcolor252")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor252Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor252")]
		[Name("output.term.bgcolor252")]
		internal sealed class OutputTermBackgroundColor252Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor252Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xd0, 0xd0, 0xd0);
			}
		}

		[Export]
		[Name("output.term.color253")]
		internal static ClassificationTypeDefinition outputTermColor253Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color253")]
		[Name("output.term.color253")]
		internal sealed class OutputTermColor253Format : ClassificationFormatDefinition {
			public OutputTermColor253Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xda, 0xda, 0xda);
			}
		}

		[Export]
		[Name("output.term.bgcolor253")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor253Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor253")]
		[Name("output.term.bgcolor253")]
		internal sealed class OutputTermBackgroundColor253Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor253Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xda, 0xda, 0xda);
			}
		}

		[Export]
		[Name("output.term.color254")]
		internal static ClassificationTypeDefinition outputTermColor254Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color254")]
		[Name("output.term.color254")]
		internal sealed class OutputTermColor254Format : ClassificationFormatDefinition {
			public OutputTermColor254Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xe4, 0xe4, 0xe4);
			}
		}

		[Export]
		[Name("output.term.bgcolor254")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor254Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor254")]
		[Name("output.term.bgcolor254")]
		internal sealed class OutputTermBackgroundColor254Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor254Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xe4, 0xe4, 0xe4);
			}
		}

		[Export]
		[Name("output.term.color255")]
		internal static ClassificationTypeDefinition outputTermColor255Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.color255")]
		[Name("output.term.color255")]
		internal sealed class OutputTermColor255Format : ClassificationFormatDefinition {
			public OutputTermColor255Format() {
				ForegroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xee, 0xee, 0xee);
			}
		}

		[Export]
		[Name("output.term.bgcolor255")]
		internal static ClassificationTypeDefinition outputTermBackgroundColor255Definition { get; set; }

		[Export(typeof(EditorFormatDefinition))]
		[ClassificationType(ClassificationTypeNames = "output.term.bgcolor255")]
		[Name("output.term.bgcolor255")]
		internal sealed class OutputTermBackgroundColor255Format : ClassificationFormatDefinition {
			public OutputTermBackgroundColor255Format() {
				BackgroundColor = System.Windows.Media.Color.FromArgb(0xff, 0xee, 0xee, 0xee);
			}
		}
	}
}
