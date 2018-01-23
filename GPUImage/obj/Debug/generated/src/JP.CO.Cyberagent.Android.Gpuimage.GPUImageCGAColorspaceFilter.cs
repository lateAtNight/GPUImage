using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCGAColorspaceFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageCGAColorspaceFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageCGAColorspaceFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCGAColorspaceFilter']/field[@name='CGACOLORSPACE_FRAGMENT_SHADER']"
		[Register ("CGACOLORSPACE_FRAGMENT_SHADER")]
		public const string CgacolorspaceFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000ahighp vec2 sampleDivisor = vec2(1.0 / 200.0, 1.0 / 320.0);\u000a//highp vec4 colorDivisor = vec4(colorDepth);\u000a\u000ahighp vec2 samplePos = textureCoordinate - mod(textureCoordinate, sampleDivisor);\u000ahighp vec4 color = texture2D(inputImageTexture, samplePos );\u000a\u000a//gl_FragColor = texture2D(inputImageTexture, samplePos );\u000amediump vec4 colorCyan = vec4(85.0 / 255.0, 1.0, 1.0, 1.0);\u000amediump vec4 colorMagenta = vec4(1.0, 85.0 / 255.0, 1.0, 1.0);\u000amediump vec4 colorWhite = vec4(1.0, 1.0, 1.0, 1.0);\u000amediump vec4 colorBlack = vec4(0.0, 0.0, 0.0, 1.0);\u000a\u000amediump vec4 endColor;\u000ahighp float blackDistance = distance(color, colorBlack);\u000ahighp float whiteDistance = distance(color, colorWhite);\u000ahighp float magentaDistance = distance(color, colorMagenta);\u000ahighp float cyanDistance = distance(color, colorCyan);\u000a\u000amediump vec4 finalColor;\u000a\u000ahighp float colorDistance = min(magentaDistance, cyanDistance);\u000acolorDistance = min(colorDistance, whiteDistance);\u000acolorDistance = min(colorDistance, blackDistance); \u000a\u000aif (colorDistance == blackDistance) {\u000afinalColor = colorBlack;\u000a} else if (colorDistance == whiteDistance) {\u000afinalColor = colorWhite;\u000a} else if (colorDistance == cyanDistance) {\u000afinalColor = colorCyan;\u000a} else {\u000afinalColor = colorMagenta;\u000a}\u000a\u000agl_FragColor = finalColor;\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageCGAColorspaceFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageCGAColorspaceFilter); }
		}

		protected GPUImageCGAColorspaceFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCGAColorspaceFilter']/constructor[@name='GPUImageCGAColorspaceFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageCGAColorspaceFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageCGAColorspaceFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

	}
}
