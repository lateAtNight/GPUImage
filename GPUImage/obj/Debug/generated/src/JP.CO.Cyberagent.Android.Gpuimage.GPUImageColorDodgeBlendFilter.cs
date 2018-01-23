using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorDodgeBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageColorDodgeBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageColorDodgeBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorDodgeBlendFilter']/field[@name='COLOR_DODGE_BLEND_FRAGMENT_SHADER']"
		[Register ("COLOR_DODGE_BLEND_FRAGMENT_SHADER")]
		public const string ColorDodgeBlendFragmentShader = (string) "precision mediump float;\u000a \u000a varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a void main()\u000a {\u000a     vec4 base = texture2D(inputImageTexture, textureCoordinate);\u000a     vec4 overlay = texture2D(inputImageTexture2, textureCoordinate2);\u000a     \u000a     vec3 baseOverlayAlphaProduct = vec3(overlay.a * base.a);\u000a     vec3 rightHandProduct = overlay.rgb * (1.0 - base.a) + base.rgb * (1.0 - overlay.a);\u000a     \u000a     vec3 firstBlendColor = baseOverlayAlphaProduct + rightHandProduct;\u000a     vec3 overlayRGB = clamp((overlay.rgb / clamp(overlay.a, 0.01, 1.0)) * step(0.0, overlay.a), 0.0, 0.99);\u000a     \u000a     vec3 secondBlendColor = (base.rgb * overlay.a) / (1.0 - overlayRGB) + rightHandProduct;\u000a     \u000a     vec3 colorChoice = step((overlay.rgb * base.a + base.rgb * overlay.a), baseOverlayAlphaProduct);\u000a     \u000a     gl_FragColor = vec4(mix(firstBlendColor, secondBlendColor, colorChoice), 1.0);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageColorDodgeBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageColorDodgeBlendFilter); }
		}

		protected GPUImageColorDodgeBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorDodgeBlendFilter']/constructor[@name='GPUImageColorDodgeBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageColorDodgeBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageColorDodgeBlendFilter)) {
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
