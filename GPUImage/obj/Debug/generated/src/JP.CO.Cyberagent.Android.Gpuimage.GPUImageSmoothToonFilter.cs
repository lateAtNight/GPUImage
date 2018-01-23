using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageSmoothToonFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageSmoothToonFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageSmoothToonFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageSmoothToonFilter); }
		}

		protected GPUImageSmoothToonFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']/constructor[@name='GPUImageSmoothToonFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageSmoothToonFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageSmoothToonFilter)) {
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

		static Delegate cb_setBlurSize_F;
#pragma warning disable 0169
		static Delegate GetSetBlurSize_FHandler ()
		{
			if (cb_setBlurSize_F == null)
				cb_setBlurSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBlurSize_F);
			return cb_setBlurSize_F;
		}

		static void n_SetBlurSize_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlurSize (value);
		}
#pragma warning restore 0169

		static IntPtr id_setBlurSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']/method[@name='setBlurSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBlurSize", "(F)V", "GetSetBlurSize_FHandler")]
		public virtual unsafe void SetBlurSize (float value)
		{
			if (id_setBlurSize_F == IntPtr.Zero)
				id_setBlurSize_F = JNIEnv.GetMethodID (class_ref, "setBlurSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlurSize_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlurSize", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setQuantizationLevels_F;
#pragma warning disable 0169
		static Delegate GetSetQuantizationLevels_FHandler ()
		{
			if (cb_setQuantizationLevels_F == null)
				cb_setQuantizationLevels_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetQuantizationLevels_F);
			return cb_setQuantizationLevels_F;
		}

		static void n_SetQuantizationLevels_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuantizationLevels (value);
		}
#pragma warning restore 0169

		static IntPtr id_setQuantizationLevels_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']/method[@name='setQuantizationLevels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setQuantizationLevels", "(F)V", "GetSetQuantizationLevels_FHandler")]
		public virtual unsafe void SetQuantizationLevels (float value)
		{
			if (id_setQuantizationLevels_F == IntPtr.Zero)
				id_setQuantizationLevels_F = JNIEnv.GetMethodID (class_ref, "setQuantizationLevels", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuantizationLevels_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuantizationLevels", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTexelHeight_F;
#pragma warning disable 0169
		static Delegate GetSetTexelHeight_FHandler ()
		{
			if (cb_setTexelHeight_F == null)
				cb_setTexelHeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTexelHeight_F);
			return cb_setTexelHeight_F;
		}

		static void n_SetTexelHeight_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTexelHeight (value);
		}
#pragma warning restore 0169

		static IntPtr id_setTexelHeight_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']/method[@name='setTexelHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTexelHeight", "(F)V", "GetSetTexelHeight_FHandler")]
		public virtual unsafe void SetTexelHeight (float value)
		{
			if (id_setTexelHeight_F == IntPtr.Zero)
				id_setTexelHeight_F = JNIEnv.GetMethodID (class_ref, "setTexelHeight", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTexelHeight_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTexelHeight", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTexelWidth_F;
#pragma warning disable 0169
		static Delegate GetSetTexelWidth_FHandler ()
		{
			if (cb_setTexelWidth_F == null)
				cb_setTexelWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTexelWidth_F);
			return cb_setTexelWidth_F;
		}

		static void n_SetTexelWidth_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTexelWidth (value);
		}
#pragma warning restore 0169

		static IntPtr id_setTexelWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']/method[@name='setTexelWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTexelWidth", "(F)V", "GetSetTexelWidth_FHandler")]
		public virtual unsafe void SetTexelWidth (float value)
		{
			if (id_setTexelWidth_F == IntPtr.Zero)
				id_setTexelWidth_F = JNIEnv.GetMethodID (class_ref, "setTexelWidth", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTexelWidth_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTexelWidth", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetThreshold_FHandler ()
		{
			if (cb_setThreshold_F == null)
				cb_setThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetThreshold_F);
			return cb_setThreshold_F;
		}

		static void n_SetThreshold_F (IntPtr jnienv, IntPtr native__this, float value)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSmoothToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThreshold (value);
		}
#pragma warning restore 0169

		static IntPtr id_setThreshold_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSmoothToonFilter']/method[@name='setThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setThreshold", "(F)V", "GetSetThreshold_FHandler")]
		public virtual unsafe void SetThreshold (float value)
		{
			if (id_setThreshold_F == IntPtr.Zero)
				id_setThreshold_F = JNIEnv.GetMethodID (class_ref, "setThreshold", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThreshold_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThreshold", "(F)V"), __args);
			} finally {
			}
		}

	}
}
