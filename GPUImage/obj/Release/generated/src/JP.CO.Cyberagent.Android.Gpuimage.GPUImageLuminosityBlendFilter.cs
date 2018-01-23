using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLuminosityBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageLuminosityBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageLuminosityBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLuminosityBlendFilter']/field[@name='LUMINOSITY_BLEND_FRAGMENT_SHADER']"
		[Register ("LUMINOSITY_BLEND_FRAGMENT_SHADER")]
		public const string LuminosityBlendFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a highp float lum(lowp vec3 c) {\u000a     return dot(c, vec3(0.3, 0.59, 0.11));\u000a }\u000a \u000a lowp vec3 clipcolor(lowp vec3 c) {\u000a     highp float l = lum(c);\u000a     lowp float n = min(min(c.r, c.g), c.b);\u000a     lowp float x = max(max(c.r, c.g), c.b);\u000a     \u000a     if (n < 0.0) {\u000a         c.r = l + ((c.r - l) * l) / (l - n);\u000a         c.g = l + ((c.g - l) * l) / (l - n);\u000a         c.b = l + ((c.b - l) * l) / (l - n);\u000a     }\u000a     if (x > 1.0) {\u000a         c.r = l + ((c.r - l) * (1.0 - l)) / (x - l);\u000a         c.g = l + ((c.g - l) * (1.0 - l)) / (x - l);\u000a         c.b = l + ((c.b - l) * (1.0 - l)) / (x - l);\u000a     }\u000a     \u000a     return c;\u000a }\u000a \u000a lowp vec3 setlum(lowp vec3 c, highp float l) {\u000a     highp float d = l - lum(c);\u000a     c = c + vec3(d);\u000a     return clipcolor(c);\u000a }\u000a \u000a void main()\u000a {\u000a   highp vec4 baseColor = texture2D(inputImageTexture, textureCoordinate);\u000a   highp vec4 overlayColor = texture2D(inputImageTexture2, textureCoordinate2);\u000a     \u000a     gl_FragColor = vec4(baseColor.rgb * (1.0 - overlayColor.a) + setlum(baseColor.rgb, lum(overlayColor.rgb)) * overlayColor.a, baseColor.a);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageLuminosityBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageLuminosityBlendFilter); }
		}

		protected GPUImageLuminosityBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLuminosityBlendFilter']/constructor[@name='GPUImageLuminosityBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageLuminosityBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageLuminosityBlendFilter)) {
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
