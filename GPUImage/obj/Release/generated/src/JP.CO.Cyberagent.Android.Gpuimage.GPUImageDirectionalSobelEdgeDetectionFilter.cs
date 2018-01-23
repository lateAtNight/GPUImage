using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageDirectionalSobelEdgeDetectionFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageDirectionalSobelEdgeDetectionFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageDirectionalSobelEdgeDetectionFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageDirectionalSobelEdgeDetectionFilter']/field[@name='DIRECTIONAL_SOBEL_EDGE_DETECTION_FRAGMENT_SHADER']"
		[Register ("DIRECTIONAL_SOBEL_EDGE_DETECTION_FRAGMENT_SHADER")]
		public const string DirectionalSobelEdgeDetectionFragmentShader = (string) "precision mediump float;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000a    float bottomLeftIntensity = texture2D(inputImageTexture, bottomLeftTextureCoordinate).r;\u000a    float topRightIntensity = texture2D(inputImageTexture, topRightTextureCoordinate).r;\u000a    float topLeftIntensity = texture2D(inputImageTexture, topLeftTextureCoordinate).r;\u000a    float bottomRightIntensity = texture2D(inputImageTexture, bottomRightTextureCoordinate).r;\u000a    float leftIntensity = texture2D(inputImageTexture, leftTextureCoordinate).r;\u000a    float rightIntensity = texture2D(inputImageTexture, rightTextureCoordinate).r;\u000a    float bottomIntensity = texture2D(inputImageTexture, bottomTextureCoordinate).r;\u000a    float topIntensity = texture2D(inputImageTexture, topTextureCoordinate).r;\u000a\u000a    vec2 gradientDirection;\u000a    gradientDirection.x = -bottomLeftIntensity - 2.0 * leftIntensity - topLeftIntensity + bottomRightIntensity + 2.0 * rightIntensity + topRightIntensity;\u000a    gradientDirection.y = -topLeftIntensity - 2.0 * topIntensity - topRightIntensity + bottomLeftIntensity + 2.0 * bottomIntensity + bottomRightIntensity;\u000a\u000a    float gradientMagnitude = length(gradientDirection);\u000a    vec2 normalizedDirection = normalize(gradientDirection);\u000a    normalizedDirection = sign(normalizedDirection) * floor(abs(normalizedDirection) + 0.617316); // Offset by 1-sin(pi/8) to set to 0 if near axis, 1 if away\u000a    normalizedDirection = (normalizedDirection + 1.0) * 0.5; // Place -1.0 - 1.0 within 0 - 1.0\u000a\u000a    gl_FragColor = vec4(gradientMagnitude, normalizedDirection.x, normalizedDirection.y, 1.0);\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageDirectionalSobelEdgeDetectionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageDirectionalSobelEdgeDetectionFilter); }
		}

		protected GPUImageDirectionalSobelEdgeDetectionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageDirectionalSobelEdgeDetectionFilter']/constructor[@name='GPUImageDirectionalSobelEdgeDetectionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageDirectionalSobelEdgeDetectionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageDirectionalSobelEdgeDetectionFilter)) {
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
