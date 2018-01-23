using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageNonMaximumSuppressionFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageNonMaximumSuppressionFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageNonMaximumSuppressionFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageNonMaximumSuppressionFilter']/field[@name='NMS_FRAGMENT_SHADER']"
		[Register ("NMS_FRAGMENT_SHADER")]
		public const string NmsFragmentShader = (string) "uniform sampler2D inputImageTexture;\u000a\u000avarying highp vec2 textureCoordinate;\u000avarying highp vec2 leftTextureCoordinate;\u000avarying highp vec2 rightTextureCoordinate;\u000a\u000avarying highp vec2 topTextureCoordinate;\u000avarying highp vec2 topLeftTextureCoordinate;\u000avarying highp vec2 topRightTextureCoordinate;\u000a\u000avarying highp vec2 bottomTextureCoordinate;\u000avarying highp vec2 bottomLeftTextureCoordinate;\u000avarying highp vec2 bottomRightTextureCoordinate;\u000a\u000avoid main()\u000a{\u000alowp float bottomColor = texture2D(inputImageTexture, bottomTextureCoordinate).r;\u000alowp float bottomLeftColor = texture2D(inputImageTexture, bottomLeftTextureCoordinate).r;\u000alowp float bottomRightColor = texture2D(inputImageTexture, bottomRightTextureCoordinate).r;\u000alowp vec4 centerColor = texture2D(inputImageTexture, textureCoordinate);\u000alowp float leftColor = texture2D(inputImageTexture, leftTextureCoordinate).r;\u000alowp float rightColor = texture2D(inputImageTexture, rightTextureCoordinate).r;\u000alowp float topColor = texture2D(inputImageTexture, topTextureCoordinate).r;\u000alowp float topRightColor = texture2D(inputImageTexture, topRightTextureCoordinate).r;\u000alowp float topLeftColor = texture2D(inputImageTexture, topLeftTextureCoordinate).r;\u000a\u000a// Use a tiebreaker for pixels to the left and immediately above this one\u000alowp float multiplier = 1.0 - step(centerColor.r, topColor);\u000amultiplier = multiplier * 1.0 - step(centerColor.r, topLeftColor);\u000amultiplier = multiplier * 1.0 - step(centerColor.r, leftColor);\u000amultiplier = multiplier * 1.0 - step(centerColor.r, bottomLeftColor);\u000a\u000alowp float maxValue = max(centerColor.r, bottomColor);\u000amaxValue = max(maxValue, bottomRightColor);\u000amaxValue = max(maxValue, rightColor);\u000amaxValue = max(maxValue, topRightColor);\u000a\u000agl_FragColor = vec4((centerColor.rgb * step(maxValue, centerColor.r) * multiplier), 1.0);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageNonMaximumSuppressionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageNonMaximumSuppressionFilter); }
		}

		protected GPUImageNonMaximumSuppressionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageNonMaximumSuppressionFilter']/constructor[@name='GPUImageNonMaximumSuppressionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageNonMaximumSuppressionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageNonMaximumSuppressionFilter)) {
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
