using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageDivideBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageDivideBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageDivideBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageDivideBlendFilter']/field[@name='DIVIDE_BLEND_FRAGMENT_SHADER']"
		[Register ("DIVIDE_BLEND_FRAGMENT_SHADER")]
		public const string DivideBlendFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a\u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a void main()\u000a {\u000a   mediump vec4 base = texture2D(inputImageTexture, textureCoordinate);\u000a   mediump vec4 overlay = texture2D(inputImageTexture2, textureCoordinate2);\u000a   \u000a   mediump float ra;\u000a   if (overlay.a == 0.0 || ((base.r / overlay.r) > (base.a / overlay.a)))\u000a     ra = overlay.a * base.a + overlay.r * (1.0 - base.a) + base.r * (1.0 - overlay.a);\u000a   else\u000a     ra = (base.r * overlay.a * overlay.a) / overlay.r + overlay.r * (1.0 - base.a) + base.r * (1.0 - overlay.a);\u000a   \u000a\u000a   mediump float ga;\u000a   if (overlay.a == 0.0 || ((base.g / overlay.g) > (base.a / overlay.a)))\u000a     ga = overlay.a * base.a + overlay.g * (1.0 - base.a) + base.g * (1.0 - overlay.a);\u000a   else\u000a     ga = (base.g * overlay.a * overlay.a) / overlay.g + overlay.g * (1.0 - base.a) + base.g * (1.0 - overlay.a);\u000a\u000a   \u000a   mediump float ba;\u000a   if (overlay.a == 0.0 || ((base.b / overlay.b) > (base.a / overlay.a)))\u000a     ba = overlay.a * base.a + overlay.b * (1.0 - base.a) + base.b * (1.0 - overlay.a);\u000a   else\u000a     ba = (base.b * overlay.a * overlay.a) / overlay.b + overlay.b * (1.0 - base.a) + base.b * (1.0 - overlay.a);\u000a\u000a   mediump float a = overlay.a + base.a - overlay.a * base.a;\u000a   \u000a   gl_FragColor = vec4(ra, ga, ba, a);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageDivideBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageDivideBlendFilter); }
		}

		protected GPUImageDivideBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageDivideBlendFilter']/constructor[@name='GPUImageDivideBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageDivideBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageDivideBlendFilter)) {
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
