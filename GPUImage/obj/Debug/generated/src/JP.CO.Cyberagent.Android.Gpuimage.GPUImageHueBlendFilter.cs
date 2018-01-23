using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageHueBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageHueBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueBlendFilter']/field[@name='HUE_BLEND_FRAGMENT_SHADER']"
		[Register ("HUE_BLEND_FRAGMENT_SHADER")]
		public const string HueBlendFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a highp float lum(lowp vec3 c) {\u000a     return dot(c, vec3(0.3, 0.59, 0.11));\u000a }\u000a \u000a lowp vec3 clipcolor(lowp vec3 c) {\u000a     highp float l = lum(c);\u000a     lowp float n = min(min(c.r, c.g), c.b);\u000a     lowp float x = max(max(c.r, c.g), c.b);\u000a     \u000a     if (n < 0.0) {\u000a         c.r = l + ((c.r - l) * l) / (l - n);\u000a         c.g = l + ((c.g - l) * l) / (l - n);\u000a         c.b = l + ((c.b - l) * l) / (l - n);\u000a     }\u000a     if (x > 1.0) {\u000a         c.r = l + ((c.r - l) * (1.0 - l)) / (x - l);\u000a         c.g = l + ((c.g - l) * (1.0 - l)) / (x - l);\u000a         c.b = l + ((c.b - l) * (1.0 - l)) / (x - l);\u000a     }\u000a     \u000a     return c;\u000a }\u000a \u000a lowp vec3 setlum(lowp vec3 c, highp float l) {\u000a     highp float d = l - lum(c);\u000a     c = c + vec3(d);\u000a     return clipcolor(c);\u000a }\u000a \u000a highp float sat(lowp vec3 c) {\u000a     lowp float n = min(min(c.r, c.g), c.b);\u000a     lowp float x = max(max(c.r, c.g), c.b);\u000a     return x - n;\u000a }\u000a \u000a lowp float mid(lowp float cmin, lowp float cmid, lowp float cmax, highp float s) {\u000a     return ((cmid - cmin) * s) / (cmax - cmin);\u000a }\u000a \u000a lowp vec3 setsat(lowp vec3 c, highp float s) {\u000a     if (c.r > c.g) {\u000a         if (c.r > c.b) {\u000a             if (c.g > c.b) {\u000a                 /* g is mid, b is min */\u000a                 c.g = mid(c.b, c.g, c.r, s);\u000a                 c.b = 0.0;\u000a             } else {\u000a                 /* b is mid, g is min */\u000a                 c.b = mid(c.g, c.b, c.r, s);\u000a                 c.g = 0.0;\u000a             }\u000a             c.r = s;\u000a         } else {\u000a             /* b is max, r is mid, g is min */\u000a             c.r = mid(c.g, c.r, c.b, s);\u000a             c.b = s;\u000a             c.r = 0.0;\u000a         }\u000a     } else if (c.r > c.b) {\u000a         /* g is max, r is mid, b is min */\u000a         c.r = mid(c.b, c.r, c.g, s);\u000a         c.g = s;\u000a         c.b = 0.0;\u000a     } else if (c.g > c.b) {\u000a         /* g is max, b is mid, r is min */\u000a         c.b = mid(c.r, c.b, c.g, s);\u000a         c.g = s;\u000a         c.r = 0.0;\u000a     } else if (c.b > c.g) {\u000a         /* b is max, g is mid, r is min */\u000a         c.g = mid(c.r, c.g, c.b, s);\u000a         c.b = s;\u000a         c.r = 0.0;\u000a     } else {\u000a         c = vec3(0.0);\u000a     }\u000a     return c;\u000a }\u000a \u000a void main()\u000a {\u000a   highp vec4 baseColor = texture2D(inputImageTexture, textureCoordinate);\u000a   highp vec4 overlayColor = texture2D(inputImageTexture2, textureCoordinate2);\u000a     \u000a     gl_FragColor = vec4(baseColor.rgb * (1.0 - overlayColor.a) + setlum(setsat(overlayColor.rgb, sat(baseColor.rgb)), lum(baseColor.rgb)) * overlayColor.a, baseColor.a);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageHueBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageHueBlendFilter); }
		}

		protected GPUImageHueBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueBlendFilter']/constructor[@name='GPUImageHueBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageHueBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageHueBlendFilter)) {
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
