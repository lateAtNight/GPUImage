using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorMatrixFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageColorMatrixFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageColorMatrixFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorMatrixFilter']/field[@name='COLOR_MATRIX_FRAGMENT_SHADER']"
		[Register ("COLOR_MATRIX_FRAGMENT_SHADER")]
		public const string ColorMatrixFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform lowp mat4 colorMatrix;\u000auniform lowp float intensity;\u000a\u000avoid main()\u000a{\u000a    lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a    lowp vec4 outputColor = textureColor * colorMatrix;\u000a    \u000a    gl_FragColor = (intensity * outputColor) + ((1.0 - intensity) * textureColor);\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageColorMatrixFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageColorMatrixFilter); }
		}

		protected GPUImageColorMatrixFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorMatrixFilter']/constructor[@name='GPUImageColorMatrixFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageColorMatrixFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageColorMatrixFilter)) {
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

		static IntPtr id_ctor_FarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorMatrixFilter']/constructor[@name='GPUImageColorMatrixFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "(F[F)V", "")]
		public unsafe GPUImageColorMatrixFilter (float intensity, float[] colorMatrix)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_colorMatrix = JNIEnv.NewArray (colorMatrix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (intensity);
				__args [1] = new JValue (native_colorMatrix);
				if (((object) this).GetType () != typeof (GPUImageColorMatrixFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F[F)V", __args);
					return;
				}

				if (id_ctor_FarrayF == IntPtr.Zero)
					id_ctor_FarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(F[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FarrayF, __args);
			} finally {
				if (colorMatrix != null) {
					JNIEnv.CopyArray (native_colorMatrix, colorMatrix);
					JNIEnv.DeleteLocalRef (native_colorMatrix);
				}
			}
		}

		static Delegate cb_setColorMatrix_arrayF;
#pragma warning disable 0169
		static Delegate GetSetColorMatrix_arrayFHandler ()
		{
			if (cb_setColorMatrix_arrayF == null)
				cb_setColorMatrix_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColorMatrix_arrayF);
			return cb_setColorMatrix_arrayF;
		}

		static void n_SetColorMatrix_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_colorMatrix)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorMatrixFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorMatrixFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] colorMatrix = (float[]) JNIEnv.GetArray (native_colorMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetColorMatrix (colorMatrix);
			if (colorMatrix != null)
				JNIEnv.CopyArray (colorMatrix, native_colorMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_setColorMatrix_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorMatrixFilter']/method[@name='setColorMatrix' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setColorMatrix", "([F)V", "GetSetColorMatrix_arrayFHandler")]
		public virtual unsafe void SetColorMatrix (float[] colorMatrix)
		{
			if (id_setColorMatrix_arrayF == IntPtr.Zero)
				id_setColorMatrix_arrayF = JNIEnv.GetMethodID (class_ref, "setColorMatrix", "([F)V");
			IntPtr native_colorMatrix = JNIEnv.NewArray (colorMatrix);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_colorMatrix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorMatrix_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorMatrix", "([F)V"), __args);
			} finally {
				if (colorMatrix != null) {
					JNIEnv.CopyArray (native_colorMatrix, colorMatrix);
					JNIEnv.DeleteLocalRef (native_colorMatrix);
				}
			}
		}

		static Delegate cb_setIntensity_F;
#pragma warning disable 0169
		static Delegate GetSetIntensity_FHandler ()
		{
			if (cb_setIntensity_F == null)
				cb_setIntensity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIntensity_F);
			return cb_setIntensity_F;
		}

		static void n_SetIntensity_F (IntPtr jnienv, IntPtr native__this, float intensity)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorMatrixFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorMatrixFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIntensity (intensity);
		}
#pragma warning restore 0169

		static IntPtr id_setIntensity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorMatrixFilter']/method[@name='setIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setIntensity", "(F)V", "GetSetIntensity_FHandler")]
		public virtual unsafe void SetIntensity (float intensity)
		{
			if (id_setIntensity_F == IntPtr.Zero)
				id_setIntensity_F = JNIEnv.GetMethodID (class_ref, "setIntensity", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (intensity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntensity_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntensity", "(F)V"), __args);
			} finally {
			}
		}

	}
}
