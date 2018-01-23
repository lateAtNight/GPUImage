using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLookupFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageLookupFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageLookupFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLookupFilter']/field[@name='LOOKUP_FRAGMENT_SHADER']"
		[Register ("LOOKUP_FRAGMENT_SHADER")]
		public const string LookupFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2; // TODO: This is not used\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2; // lookup texture\u000a \u000a void main()\u000a {\u000a     lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     \u000a     mediump float blueColor = textureColor.b * 63.0;\u000a     \u000a     mediump vec2 quad1;\u000a     quad1.y = floor(floor(blueColor) / 8.0);\u000a     quad1.x = floor(blueColor) - (quad1.y * 8.0);\u000a     \u000a     mediump vec2 quad2;\u000a     quad2.y = floor(ceil(blueColor) / 8.0);\u000a     quad2.x = ceil(blueColor) - (quad2.y * 8.0);\u000a     \u000a     highp vec2 texPos1;\u000a     texPos1.x = (quad1.x * 0.125) + 0.5/512.0 + ((0.125 - 1.0/512.0) * textureColor.r);\u000a     texPos1.y = (quad1.y * 0.125) + 0.5/512.0 + ((0.125 - 1.0/512.0) * textureColor.g);\u000a     \u000a     highp vec2 texPos2;\u000a     texPos2.x = (quad2.x * 0.125) + 0.5/512.0 + ((0.125 - 1.0/512.0) * textureColor.r);\u000a     texPos2.y = (quad2.y * 0.125) + 0.5/512.0 + ((0.125 - 1.0/512.0) * textureColor.g);\u000a     \u000a     lowp vec4 newColor1 = texture2D(inputImageTexture2, texPos1);\u000a     lowp vec4 newColor2 = texture2D(inputImageTexture2, texPos2);\u000a     \u000a     lowp vec4 newColor = mix(newColor1, newColor2, fract(blueColor));\u000a     gl_FragColor = vec4(newColor.rgb, textureColor.w);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageLookupFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageLookupFilter); }
		}

		protected GPUImageLookupFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLookupFilter']/constructor[@name='GPUImageLookupFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageLookupFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageLookupFilter)) {
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
