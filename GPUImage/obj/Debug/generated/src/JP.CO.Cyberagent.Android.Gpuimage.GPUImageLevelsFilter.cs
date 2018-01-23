using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageLevelsFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageLevelsFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/field[@name='LEVELS_FRAGMET_SHADER']"
		[Register ("LEVELS_FRAGMET_SHADER")]
		public const string LevelsFragmetShader = (string) " varying highp vec2 textureCoordinate;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform mediump vec3 levelMinimum;\u000a uniform mediump vec3 levelMiddle;\u000a uniform mediump vec3 levelMaximum;\u000a uniform mediump vec3 minOutput;\u000a uniform mediump vec3 maxOutput;\u000a \u000a void main()\u000a {\u000a     mediump vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     \u000a     gl_FragColor = vec4( mix(minOutput, maxOutput, pow(min(max(textureColor.rgb -levelMinimum, vec3(0.0)) / (levelMaximum - levelMinimum  ), vec3(1.0)), 1.0 /levelMiddle)) , textureColor.a);\u000a }\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageLevelsFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageLevelsFilter); }
		}

		protected GPUImageLevelsFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/constructor[@name='GPUImageLevelsFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageLevelsFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageLevelsFilter)) {
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

		static Delegate cb_setBlueMin_FFF;
#pragma warning disable 0169
		static Delegate GetSetBlueMin_FFFHandler ()
		{
			if (cb_setBlueMin_FFF == null)
				cb_setBlueMin_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetBlueMin_FFF);
			return cb_setBlueMin_FFF;
		}

		static void n_SetBlueMin_FFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlueMin (min, mid, max);
		}
#pragma warning restore 0169

		static IntPtr id_setBlueMin_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setBlueMin' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setBlueMin", "(FFF)V", "GetSetBlueMin_FFFHandler")]
		public virtual unsafe void SetBlueMin (float min, float mid, float max)
		{
			if (id_setBlueMin_FFF == IntPtr.Zero)
				id_setBlueMin_FFF = JNIEnv.GetMethodID (class_ref, "setBlueMin", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlueMin_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlueMin", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBlueMin_FFFFF;
#pragma warning disable 0169
		static Delegate GetSetBlueMin_FFFFFHandler ()
		{
			if (cb_setBlueMin_FFFFF == null)
				cb_setBlueMin_FFFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, float>) n_SetBlueMin_FFFFF);
			return cb_setBlueMin_FFFFF;
		}

		static void n_SetBlueMin_FFFFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max, float minOut, float maxOut)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlueMin (min, mid, max, minOut, maxOut);
		}
#pragma warning restore 0169

		static IntPtr id_setBlueMin_FFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setBlueMin' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("setBlueMin", "(FFFFF)V", "GetSetBlueMin_FFFFFHandler")]
		public virtual unsafe void SetBlueMin (float min, float mid, float max, float minOut, float maxOut)
		{
			if (id_setBlueMin_FFFFF == IntPtr.Zero)
				id_setBlueMin_FFFFF = JNIEnv.GetMethodID (class_ref, "setBlueMin", "(FFFFF)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);
				__args [3] = new JValue (minOut);
				__args [4] = new JValue (maxOut);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlueMin_FFFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlueMin", "(FFFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGreenMin_FFF;
#pragma warning disable 0169
		static Delegate GetSetGreenMin_FFFHandler ()
		{
			if (cb_setGreenMin_FFF == null)
				cb_setGreenMin_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetGreenMin_FFF);
			return cb_setGreenMin_FFF;
		}

		static void n_SetGreenMin_FFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGreenMin (min, mid, max);
		}
#pragma warning restore 0169

		static IntPtr id_setGreenMin_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setGreenMin' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setGreenMin", "(FFF)V", "GetSetGreenMin_FFFHandler")]
		public virtual unsafe void SetGreenMin (float min, float mid, float max)
		{
			if (id_setGreenMin_FFF == IntPtr.Zero)
				id_setGreenMin_FFF = JNIEnv.GetMethodID (class_ref, "setGreenMin", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGreenMin_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGreenMin", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGreenMin_FFFFF;
#pragma warning disable 0169
		static Delegate GetSetGreenMin_FFFFFHandler ()
		{
			if (cb_setGreenMin_FFFFF == null)
				cb_setGreenMin_FFFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, float>) n_SetGreenMin_FFFFF);
			return cb_setGreenMin_FFFFF;
		}

		static void n_SetGreenMin_FFFFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max, float minOut, float maxOut)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGreenMin (min, mid, max, minOut, maxOut);
		}
#pragma warning restore 0169

		static IntPtr id_setGreenMin_FFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setGreenMin' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("setGreenMin", "(FFFFF)V", "GetSetGreenMin_FFFFFHandler")]
		public virtual unsafe void SetGreenMin (float min, float mid, float max, float minOut, float maxOut)
		{
			if (id_setGreenMin_FFFFF == IntPtr.Zero)
				id_setGreenMin_FFFFF = JNIEnv.GetMethodID (class_ref, "setGreenMin", "(FFFFF)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);
				__args [3] = new JValue (minOut);
				__args [4] = new JValue (maxOut);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGreenMin_FFFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGreenMin", "(FFFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMin_FFF;
#pragma warning disable 0169
		static Delegate GetSetMin_FFFHandler ()
		{
			if (cb_setMin_FFF == null)
				cb_setMin_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetMin_FFF);
			return cb_setMin_FFF;
		}

		static void n_SetMin_FFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMin (min, mid, max);
		}
#pragma warning restore 0169

		static IntPtr id_setMin_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setMin' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setMin", "(FFF)V", "GetSetMin_FFFHandler")]
		public virtual unsafe void SetMin (float min, float mid, float max)
		{
			if (id_setMin_FFF == IntPtr.Zero)
				id_setMin_FFF = JNIEnv.GetMethodID (class_ref, "setMin", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMin_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMin", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setMin_FFFFF;
#pragma warning disable 0169
		static Delegate GetSetMin_FFFFFHandler ()
		{
			if (cb_setMin_FFFFF == null)
				cb_setMin_FFFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, float>) n_SetMin_FFFFF);
			return cb_setMin_FFFFF;
		}

		static void n_SetMin_FFFFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max, float minOut, float maxOut)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMin (min, mid, max, minOut, maxOut);
		}
#pragma warning restore 0169

		static IntPtr id_setMin_FFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setMin' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("setMin", "(FFFFF)V", "GetSetMin_FFFFFHandler")]
		public virtual unsafe void SetMin (float min, float mid, float max, float minOut, float maxOut)
		{
			if (id_setMin_FFFFF == IntPtr.Zero)
				id_setMin_FFFFF = JNIEnv.GetMethodID (class_ref, "setMin", "(FFFFF)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);
				__args [3] = new JValue (minOut);
				__args [4] = new JValue (maxOut);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMin_FFFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMin", "(FFFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRedMin_FFF;
#pragma warning disable 0169
		static Delegate GetSetRedMin_FFFHandler ()
		{
			if (cb_setRedMin_FFF == null)
				cb_setRedMin_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetRedMin_FFF);
			return cb_setRedMin_FFF;
		}

		static void n_SetRedMin_FFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRedMin (min, mid, max);
		}
#pragma warning restore 0169

		static IntPtr id_setRedMin_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setRedMin' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setRedMin", "(FFF)V", "GetSetRedMin_FFFHandler")]
		public virtual unsafe void SetRedMin (float min, float mid, float max)
		{
			if (id_setRedMin_FFF == IntPtr.Zero)
				id_setRedMin_FFF = JNIEnv.GetMethodID (class_ref, "setRedMin", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRedMin_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedMin", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRedMin_FFFFF;
#pragma warning disable 0169
		static Delegate GetSetRedMin_FFFFFHandler ()
		{
			if (cb_setRedMin_FFFFF == null)
				cb_setRedMin_FFFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, float>) n_SetRedMin_FFFFF);
			return cb_setRedMin_FFFFF;
		}

		static void n_SetRedMin_FFFFF (IntPtr jnienv, IntPtr native__this, float min, float mid, float max, float minOut, float maxOut)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRedMin (min, mid, max, minOut, maxOut);
		}
#pragma warning restore 0169

		static IntPtr id_setRedMin_FFFFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='setRedMin' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register ("setRedMin", "(FFFFF)V", "GetSetRedMin_FFFFFHandler")]
		public virtual unsafe void SetRedMin (float min, float mid, float max, float minOut, float maxOut)
		{
			if (id_setRedMin_FFFFF == IntPtr.Zero)
				id_setRedMin_FFFFF = JNIEnv.GetMethodID (class_ref, "setRedMin", "(FFFFF)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (min);
				__args [1] = new JValue (mid);
				__args [2] = new JValue (max);
				__args [3] = new JValue (minOut);
				__args [4] = new JValue (maxOut);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRedMin_FFFFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedMin", "(FFFFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateUniforms;
#pragma warning disable 0169
		static Delegate GetUpdateUniformsHandler ()
		{
			if (cb_updateUniforms == null)
				cb_updateUniforms = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateUniforms);
			return cb_updateUniforms;
		}

		static void n_UpdateUniforms (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageLevelsFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateUniforms ();
		}
#pragma warning restore 0169

		static IntPtr id_updateUniforms;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageLevelsFilter']/method[@name='updateUniforms' and count(parameter)=0]"
		[Register ("updateUniforms", "()V", "GetUpdateUniformsHandler")]
		public virtual unsafe void UpdateUniforms ()
		{
			if (id_updateUniforms == IntPtr.Zero)
				id_updateUniforms = JNIEnv.GetMethodID (class_ref, "updateUniforms", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateUniforms);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateUniforms", "()V"));
			} finally {
			}
		}

	}
}
