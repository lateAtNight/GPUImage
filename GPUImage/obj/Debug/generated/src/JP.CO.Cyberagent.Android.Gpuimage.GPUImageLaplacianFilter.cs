using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLaplacianFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageLaplacianFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageLaplacianFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLaplacianFilter']/field[@name='LAPLACIAN_FRAGMENT_SHADER']"
		[Register ("LAPLACIAN_FRAGMENT_SHADER")]
		public const string LaplacianFragmentShader = (string) "precision highp float;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform mediump mat3 convolutionMatrix;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000avoid main()\u000a{\u000amediump vec3 bottomColor = texture2D(inputImageTexture, bottomTextureCoordinate).rgb;\u000amediump vec3 bottomLeftColor = texture2D(inputImageTexture, bottomLeftTextureCoordinate).rgb;\u000amediump vec3 bottomRightColor = texture2D(inputImageTexture, bottomRightTextureCoordinate).rgb;\u000amediump vec4 centerColor = texture2D(inputImageTexture, textureCoordinate);\u000amediump vec3 leftColor = texture2D(inputImageTexture, leftTextureCoordinate).rgb;\u000amediump vec3 rightColor = texture2D(inputImageTexture, rightTextureCoordinate).rgb;\u000amediump vec3 topColor = texture2D(inputImageTexture, topTextureCoordinate).rgb;\u000amediump vec3 topRightColor = texture2D(inputImageTexture, topRightTextureCoordinate).rgb;\u000amediump vec3 topLeftColor = texture2D(inputImageTexture, topLeftTextureCoordinate).rgb;\u000a\u000amediump vec3 resultColor = topLeftColor * convolutionMatrix[0][0] + topColor * convolutionMatrix[0][1] + topRightColor * convolutionMatrix[0][2];\u000aresultColor += leftColor * convolutionMatrix[1][0] + centerColor.rgb * convolutionMatrix[1][1] + rightColor * convolutionMatrix[1][2];\u000aresultColor += bottomLeftColor * convolutionMatrix[2][0] + bottomColor * convolutionMatrix[2][1] + bottomRightColor * convolutionMatrix[2][2];\u000a\u000a// Normalize the results to allow for negative gradients in the 0.0-1.0 colorspace\u000aresultColor = resultColor + 0.5;\u000a\u000agl_FragColor = vec4(resultColor, centerColor.a);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageLaplacianFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageLaplacianFilter); }
		}

		protected GPUImageLaplacianFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLaplacianFilter']/constructor[@name='GPUImageLaplacianFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageLaplacianFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageLaplacianFilter)) {
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
