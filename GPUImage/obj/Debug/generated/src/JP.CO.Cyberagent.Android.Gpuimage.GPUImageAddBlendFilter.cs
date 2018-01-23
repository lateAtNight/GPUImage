using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageAddBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageAddBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageAddBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageAddBlendFilter']/field[@name='ADD_BLEND_FRAGMENT_SHADER']"
		[Register ("ADD_BLEND_FRAGMENT_SHADER")]
		public const string AddBlendFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a\u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a void main()\u000a {\u000a   lowp vec4 base = texture2D(inputImageTexture, textureCoordinate);\u000a   lowp vec4 overlay = texture2D(inputImageTexture2, textureCoordinate2);\u000a\u000a   mediump float r;\u000a   if (overlay.r * base.a + base.r * overlay.a >= overlay.a * base.a) {\u000a     r = overlay.a * base.a + overlay.r * (1.0 - base.a) + base.r * (1.0 - overlay.a);\u000a   } else {\u000a     r = overlay.r + base.r;\u000a   }\u000a\u000a   mediump float g;\u000a   if (overlay.g * base.a + base.g * overlay.a >= overlay.a * base.a) {\u000a     g = overlay.a * base.a + overlay.g * (1.0 - base.a) + base.g * (1.0 - overlay.a);\u000a   } else {\u000a     g = overlay.g + base.g;\u000a   }\u000a\u000a   mediump float b;\u000a   if (overlay.b * base.a + base.b * overlay.a >= overlay.a * base.a) {\u000a     b = overlay.a * base.a + overlay.b * (1.0 - base.a) + base.b * (1.0 - overlay.a);\u000a   } else {\u000a     b = overlay.b + base.b;\u000a   }\u000a\u000a   mediump float a = overlay.a + base.a - overlay.a * base.a;\u000a   \u000a   gl_FragColor = vec4(r, g, b, a);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageAddBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageAddBlendFilter); }
		}

		protected GPUImageAddBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageAddBlendFilter']/constructor[@name='GPUImageAddBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageAddBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageAddBlendFilter)) {
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
