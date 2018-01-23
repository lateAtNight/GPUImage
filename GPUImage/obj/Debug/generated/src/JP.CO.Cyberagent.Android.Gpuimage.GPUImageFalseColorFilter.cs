using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageFalseColorFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageFalseColorFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']/field[@name='FALSECOLOR_FRAGMENT_SHADER']"
		[Register ("FALSECOLOR_FRAGMENT_SHADER")]
		public const string FalsecolorFragmentShader = (string) "precision lowp float;\u000a\u000avarying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000auniform float intensity;\u000auniform vec3 firstColor;\u000auniform vec3 secondColor;\u000a\u000aconst mediump vec3 luminanceWeighting = vec3(0.2125, 0.7154, 0.0721);\u000a\u000avoid main()\u000a{\u000alowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000afloat luminance = dot(textureColor.rgb, luminanceWeighting);\u000a\u000agl_FragColor = vec4( mix(firstColor.rgb, secondColor.rgb, luminance), textureColor.a);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageFalseColorFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageFalseColorFilter); }
		}

		protected GPUImageFalseColorFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']/constructor[@name='GPUImageFalseColorFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageFalseColorFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageFalseColorFilter)) {
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

		static IntPtr id_ctor_FFFFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']/constructor[@name='GPUImageFalseColorFilter' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float']]"
		[Register (".ctor", "(FFFFFF)V", "")]
		public unsafe GPUImageFalseColorFilter (float firstRed, float firstGreen, float firstBlue, float secondRed, float secondGreen, float secondBlue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [6];
				__args [0] = new JValue (firstRed);
				__args [1] = new JValue (firstGreen);
				__args [2] = new JValue (firstBlue);
				__args [3] = new JValue (secondRed);
				__args [4] = new JValue (secondGreen);
				__args [5] = new JValue (secondBlue);
				if (((object) this).GetType () != typeof (GPUImageFalseColorFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFFFFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFFFFF)V", __args);
					return;
				}

				if (id_ctor_FFFFFF == IntPtr.Zero)
					id_ctor_FFFFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFFFFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFFFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFFFFF, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_arrayFarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']/constructor[@name='GPUImageFalseColorFilter' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "([F[F)V", "")]
		public unsafe GPUImageFalseColorFilter (float[] firstColor, float[] secondColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_firstColor = JNIEnv.NewArray (firstColor);
			IntPtr native_secondColor = JNIEnv.NewArray (secondColor);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_firstColor);
				__args [1] = new JValue (native_secondColor);
				if (((object) this).GetType () != typeof (GPUImageFalseColorFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([F[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([F[F)V", __args);
					return;
				}

				if (id_ctor_arrayFarrayF == IntPtr.Zero)
					id_ctor_arrayFarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "([F[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayFarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayFarrayF, __args);
			} finally {
				if (firstColor != null) {
					JNIEnv.CopyArray (native_firstColor, firstColor);
					JNIEnv.DeleteLocalRef (native_firstColor);
				}
				if (secondColor != null) {
					JNIEnv.CopyArray (native_secondColor, secondColor);
					JNIEnv.DeleteLocalRef (native_secondColor);
				}
			}
		}

		static Delegate cb_setFirstColor_arrayF;
#pragma warning disable 0169
		static Delegate GetSetFirstColor_arrayFHandler ()
		{
			if (cb_setFirstColor_arrayF == null)
				cb_setFirstColor_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFirstColor_arrayF);
			return cb_setFirstColor_arrayF;
		}

		static void n_SetFirstColor_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_firstColor)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFalseColorFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFalseColorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] firstColor = (float[]) JNIEnv.GetArray (native_firstColor, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFirstColor (firstColor);
			if (firstColor != null)
				JNIEnv.CopyArray (firstColor, native_firstColor);
		}
#pragma warning restore 0169

		static IntPtr id_setFirstColor_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']/method[@name='setFirstColor' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setFirstColor", "([F)V", "GetSetFirstColor_arrayFHandler")]
		public virtual unsafe void SetFirstColor (float[] firstColor)
		{
			if (id_setFirstColor_arrayF == IntPtr.Zero)
				id_setFirstColor_arrayF = JNIEnv.GetMethodID (class_ref, "setFirstColor", "([F)V");
			IntPtr native_firstColor = JNIEnv.NewArray (firstColor);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_firstColor);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFirstColor_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFirstColor", "([F)V"), __args);
			} finally {
				if (firstColor != null) {
					JNIEnv.CopyArray (native_firstColor, firstColor);
					JNIEnv.DeleteLocalRef (native_firstColor);
				}
			}
		}

		static Delegate cb_setSecondColor_arrayF;
#pragma warning disable 0169
		static Delegate GetSetSecondColor_arrayFHandler ()
		{
			if (cb_setSecondColor_arrayF == null)
				cb_setSecondColor_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSecondColor_arrayF);
			return cb_setSecondColor_arrayF;
		}

		static void n_SetSecondColor_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_secondColor)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFalseColorFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFalseColorFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] secondColor = (float[]) JNIEnv.GetArray (native_secondColor, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetSecondColor (secondColor);
			if (secondColor != null)
				JNIEnv.CopyArray (secondColor, native_secondColor);
		}
#pragma warning restore 0169

		static IntPtr id_setSecondColor_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFalseColorFilter']/method[@name='setSecondColor' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setSecondColor", "([F)V", "GetSetSecondColor_arrayFHandler")]
		public virtual unsafe void SetSecondColor (float[] secondColor)
		{
			if (id_setSecondColor_arrayF == IntPtr.Zero)
				id_setSecondColor_arrayF = JNIEnv.GetMethodID (class_ref, "setSecondColor", "([F)V");
			IntPtr native_secondColor = JNIEnv.NewArray (secondColor);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_secondColor);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSecondColor_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSecondColor", "([F)V"), __args);
			} finally {
				if (secondColor != null) {
					JNIEnv.CopyArray (native_secondColor, secondColor);
					JNIEnv.DeleteLocalRef (native_secondColor);
				}
			}
		}

	}
}
