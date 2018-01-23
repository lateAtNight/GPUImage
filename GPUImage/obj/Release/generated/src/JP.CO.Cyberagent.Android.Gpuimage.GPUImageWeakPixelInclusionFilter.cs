using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWeakPixelInclusionFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageWeakPixelInclusionFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageWeakPixelInclusionFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWeakPixelInclusionFilter']/field[@name='WEAKPIXEL_FRAGMENT_SHADER']"
		[Register ("WEAKPIXEL_FRAGMENT_SHADER")]
		public const string WeakpixelFragmentShader = (string) "precision lowp float;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000afloat bottomLeftIntensity = texture2D(inputImageTexture, bottomLeftTextureCoordinate).r;\u000afloat topRightIntensity = texture2D(inputImageTexture, topRightTextureCoordinate).r;\u000afloat topLeftIntensity = texture2D(inputImageTexture, topLeftTextureCoordinate).r;\u000afloat bottomRightIntensity = texture2D(inputImageTexture, bottomRightTextureCoordinate).r;\u000afloat leftIntensity = texture2D(inputImageTexture, leftTextureCoordinate).r;\u000afloat rightIntensity = texture2D(inputImageTexture, rightTextureCoordinate).r;\u000afloat bottomIntensity = texture2D(inputImageTexture, bottomTextureCoordinate).r;\u000afloat topIntensity = texture2D(inputImageTexture, topTextureCoordinate).r;\u000afloat centerIntensity = texture2D(inputImageTexture, textureCoordinate).r;\u000a\u000afloat pixelIntensitySum = bottomLeftIntensity + topRightIntensity + topLeftIntensity + bottomRightIntensity + leftIntensity + rightIntensity + bottomIntensity + topIntensity + centerIntensity;\u000afloat sumTest = step(1.5, pixelIntensitySum);\u000afloat pixelTest = step(0.01, centerIntensity);\u000a\u000agl_FragColor = vec4(vec3(sumTest * pixelTest), 1.0);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageWeakPixelInclusionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageWeakPixelInclusionFilter); }
		}

		protected GPUImageWeakPixelInclusionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWeakPixelInclusionFilter']/constructor[@name='GPUImageWeakPixelInclusionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageWeakPixelInclusionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageWeakPixelInclusionFilter)) {
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
