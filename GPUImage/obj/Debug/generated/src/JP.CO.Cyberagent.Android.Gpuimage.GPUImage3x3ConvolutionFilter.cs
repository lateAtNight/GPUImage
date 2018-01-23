using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3ConvolutionFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImage3x3ConvolutionFilter", DoNotGenerateAcw=true)]
	public partial class GPUImage3x3ConvolutionFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3ConvolutionFilter']/field[@name='THREE_X_THREE_TEXTURE_SAMPLING_FRAGMENT_SHADER']"
		[Register ("THREE_X_THREE_TEXTURE_SAMPLING_FRAGMENT_SHADER")]
		public const string ThreeXThreeTextureSamplingFragmentShader = (string) "precision highp float;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform mediump mat3 convolutionMatrix;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000avoid main()\u000a{\u000a    mediump vec4 bottomColor = texture2D(inputImageTexture, bottomTextureCoordinate);\u000a    mediump vec4 bottomLeftColor = texture2D(inputImageTexture, bottomLeftTextureCoordinate);\u000a    mediump vec4 bottomRightColor = texture2D(inputImageTexture, bottomRightTextureCoordinate);\u000a    mediump vec4 centerColor = texture2D(inputImageTexture, textureCoordinate);\u000a    mediump vec4 leftColor = texture2D(inputImageTexture, leftTextureCoordinate);\u000a    mediump vec4 rightColor = texture2D(inputImageTexture, rightTextureCoordinate);\u000a    mediump vec4 topColor = texture2D(inputImageTexture, topTextureCoordinate);\u000a    mediump vec4 topRightColor = texture2D(inputImageTexture, topRightTextureCoordinate);\u000a    mediump vec4 topLeftColor = texture2D(inputImageTexture, topLeftTextureCoordinate);\u000a\u000a    mediump vec4 resultColor = topLeftColor * convolutionMatrix[0][0] + topColor * convolutionMatrix[0][1] + topRightColor * convolutionMatrix[0][2];\u000a    resultColor += leftColor * convolutionMatrix[1][0] + centerColor * convolutionMatrix[1][1] + rightColor * convolutionMatrix[1][2];\u000a    resultColor += bottomLeftColor * convolutionMatrix[2][0] + bottomColor * convolutionMatrix[2][1] + bottomRightColor * convolutionMatrix[2][2];\u000a\u000a    gl_FragColor = resultColor;\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImage3x3ConvolutionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImage3x3ConvolutionFilter); }
		}

		protected GPUImage3x3ConvolutionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3ConvolutionFilter']/constructor[@name='GPUImage3x3ConvolutionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImage3x3ConvolutionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImage3x3ConvolutionFilter)) {
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

		static IntPtr id_ctor_arrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3ConvolutionFilter']/constructor[@name='GPUImage3x3ConvolutionFilter' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register (".ctor", "([F)V", "")]
		public unsafe GPUImage3x3ConvolutionFilter (float[] convolutionKernel)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_convolutionKernel = JNIEnv.NewArray (convolutionKernel);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_convolutionKernel);
				if (((object) this).GetType () != typeof (GPUImage3x3ConvolutionFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([F)V", __args);
					return;
				}

				if (id_ctor_arrayF == IntPtr.Zero)
					id_ctor_arrayF = JNIEnv.GetMethodID (class_ref, "<init>", "([F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayF, __args);
			} finally {
				if (convolutionKernel != null) {
					JNIEnv.CopyArray (native_convolutionKernel, convolutionKernel);
					JNIEnv.DeleteLocalRef (native_convolutionKernel);
				}
			}
		}

		static Delegate cb_setConvolutionKernel_arrayF;
#pragma warning disable 0169
		static Delegate GetSetConvolutionKernel_arrayFHandler ()
		{
			if (cb_setConvolutionKernel_arrayF == null)
				cb_setConvolutionKernel_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConvolutionKernel_arrayF);
			return cb_setConvolutionKernel_arrayF;
		}

		static void n_SetConvolutionKernel_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_convolutionKernel)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3ConvolutionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3ConvolutionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] convolutionKernel = (float[]) JNIEnv.GetArray (native_convolutionKernel, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetConvolutionKernel (convolutionKernel);
			if (convolutionKernel != null)
				JNIEnv.CopyArray (convolutionKernel, native_convolutionKernel);
		}
#pragma warning restore 0169

		static IntPtr id_setConvolutionKernel_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3ConvolutionFilter']/method[@name='setConvolutionKernel' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setConvolutionKernel", "([F)V", "GetSetConvolutionKernel_arrayFHandler")]
		public virtual unsafe void SetConvolutionKernel (float[] convolutionKernel)
		{
			if (id_setConvolutionKernel_arrayF == IntPtr.Zero)
				id_setConvolutionKernel_arrayF = JNIEnv.GetMethodID (class_ref, "setConvolutionKernel", "([F)V");
			IntPtr native_convolutionKernel = JNIEnv.NewArray (convolutionKernel);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_convolutionKernel);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setConvolutionKernel_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setConvolutionKernel", "([F)V"), __args);
			} finally {
				if (convolutionKernel != null) {
					JNIEnv.CopyArray (native_convolutionKernel, convolutionKernel);
					JNIEnv.DeleteLocalRef (native_convolutionKernel);
				}
			}
		}

	}
}
