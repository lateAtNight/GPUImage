using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBurnBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageColorBurnBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageColorBurnBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBurnBlendFilter']/field[@name='COLOR_BURN_BLEND_FRAGMENT_SHADER']"
		[Register ("COLOR_BURN_BLEND_FRAGMENT_SHADER")]
		public const string ColorBurnBlendFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a\u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a void main()\u000a {\u000a    mediump vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a    mediump vec4 textureColor2 = texture2D(inputImageTexture2, textureCoordinate2);\u000a    mediump vec4 whiteColor = vec4(1.0);\u000a    gl_FragColor = whiteColor - (whiteColor - textureColor) / textureColor2;\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageColorBurnBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageColorBurnBlendFilter); }
		}

		protected GPUImageColorBurnBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBurnBlendFilter']/constructor[@name='GPUImageColorBurnBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageColorBurnBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageColorBurnBlendFilter)) {
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
