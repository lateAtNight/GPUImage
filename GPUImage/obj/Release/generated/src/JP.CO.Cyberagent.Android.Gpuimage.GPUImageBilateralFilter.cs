using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBilateralFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageBilateralFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageBilateralFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBilateralFilter']/field[@name='BILATERAL_FRAGMENT_SHADER']"
		[Register ("BILATERAL_FRAGMENT_SHADER")]
		public const string BilateralFragmentShader = (string) "uniform sampler2D inputImageTexture;\u000a const lowp int GAUSSIAN_SAMPLES = 9;\u000a varying highp vec2 textureCoordinate;\u000a varying highp vec2 blurCoordinates[GAUSSIAN_SAMPLES];\u000a uniform mediump float distanceNormalizationFactor;\u000a void main()\u000a {\u000a     lowp vec4 centralColor;\u000a     lowp float gaussianWeightTotal;\u000a     lowp vec4 sum;\u000a     lowp vec4 sampleColor;\u000a     lowp float distanceFromCentralColor;\u000a     lowp float gaussianWeight;\u000a     \u000a     centralColor = texture2D(inputImageTexture, blurCoordinates[4]);\u000a     gaussianWeightTotal = 0.18;\u000a     sum = centralColor * 0.18;\u000a     \u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[0]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.05 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[1]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.09 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[2]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.12 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[3]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.15 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[5]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.15 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[6]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.12 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[7]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.09 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     sampleColor = texture2D(inputImageTexture, blurCoordinates[8]);\u000a     distanceFromCentralColor = min(distance(centralColor, sampleColor) * distanceNormalizationFactor, 1.0);\u000a     gaussianWeight = 0.05 * (1.0 - distanceFromCentralColor);\u000a     gaussianWeightTotal += gaussianWeight;\u000a     sum += sampleColor * gaussianWeight;\u000a     gl_FragColor = sum / gaussianWeightTotal;\u000a }";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBilateralFilter']/field[@name='BILATERAL_VERTEX_SHADER']"
		[Register ("BILATERAL_VERTEX_SHADER")]
		public const string BilateralVertexShader = (string) "attribute vec4 position;\u000aattribute vec4 inputTextureCoordinate;\u000aconst int GAUSSIAN_SAMPLES = 9;\u000auniform vec2 singleStepOffset;\u000avarying vec2 textureCoordinate;\u000avarying vec2 blurCoordinates[GAUSSIAN_SAMPLES];\u000avoid main()\u000a{\u000a\u0009gl_Position = position;\u000a\u0009textureCoordinate = inputTextureCoordinate.xy;\u000a\u0009int multiplier = 0;\u000a\u0009vec2 blurStep;\u000a\u0009for (int i = 0; i < GAUSSIAN_SAMPLES; i++)\u000a\u0009{\u000a\u0009\u0009multiplier = (i - ((GAUSSIAN_SAMPLES - 1) / 2));\u000a\u0009\u0009blurStep = float(multiplier) * singleStepOffset;\u000a\u0009\u0009blurCoordinates[i] = inputTextureCoordinate.xy + blurStep;\u000a\u0009}\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageBilateralFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageBilateralFilter); }
		}

		protected GPUImageBilateralFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBilateralFilter']/constructor[@name='GPUImageBilateralFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageBilateralFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageBilateralFilter)) {
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

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBilateralFilter']/constructor[@name='GPUImageBilateralFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageBilateralFilter (float distanceNormalizationFactor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (distanceNormalizationFactor);
				if (((object) this).GetType () != typeof (GPUImageBilateralFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F)V", __args);
					return;
				}

				if (id_ctor_F == IntPtr.Zero)
					id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_F, __args);
			} finally {
			}
		}

		static Delegate cb_setDistanceNormalizationFactor_F;
#pragma warning disable 0169
		static Delegate GetSetDistanceNormalizationFactor_FHandler ()
		{
			if (cb_setDistanceNormalizationFactor_F == null)
				cb_setDistanceNormalizationFactor_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDistanceNormalizationFactor_F);
			return cb_setDistanceNormalizationFactor_F;
		}

		static void n_SetDistanceNormalizationFactor_F (IntPtr jnienv, IntPtr native__this, float newValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBilateralFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBilateralFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDistanceNormalizationFactor (newValue);
		}
#pragma warning restore 0169

		static IntPtr id_setDistanceNormalizationFactor_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBilateralFilter']/method[@name='setDistanceNormalizationFactor' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDistanceNormalizationFactor", "(F)V", "GetSetDistanceNormalizationFactor_FHandler")]
		public virtual unsafe void SetDistanceNormalizationFactor (float newValue)
		{
			if (id_setDistanceNormalizationFactor_F == IntPtr.Zero)
				id_setDistanceNormalizationFactor_F = JNIEnv.GetMethodID (class_ref, "setDistanceNormalizationFactor", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (newValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistanceNormalizationFactor_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistanceNormalizationFactor", "(F)V"), __args);
			} finally {
			}
		}

	}
}
