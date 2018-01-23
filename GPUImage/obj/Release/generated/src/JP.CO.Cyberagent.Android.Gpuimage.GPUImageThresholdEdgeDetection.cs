using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageThresholdEdgeDetection']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageThresholdEdgeDetection", DoNotGenerateAcw=true)]
	public partial class GPUImageThresholdEdgeDetection : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageThresholdEdgeDetection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageThresholdEdgeDetection); }
		}

		protected GPUImageThresholdEdgeDetection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageThresholdEdgeDetection']/constructor[@name='GPUImageThresholdEdgeDetection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageThresholdEdgeDetection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageThresholdEdgeDetection)) {
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

		static Delegate cb_setLineSize_F;
#pragma warning disable 0169
		static Delegate GetSetLineSize_FHandler ()
		{
			if (cb_setLineSize_F == null)
				cb_setLineSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineSize_F);
			return cb_setLineSize_F;
		}

		static void n_SetLineSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageThresholdEdgeDetection __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageThresholdEdgeDetection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLineSize (size);
		}
#pragma warning restore 0169

		static IntPtr id_setLineSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageThresholdEdgeDetection']/method[@name='setLineSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLineSize", "(F)V", "GetSetLineSize_FHandler")]
		public virtual unsafe void SetLineSize (float size)
		{
			if (id_setLineSize_F == IntPtr.Zero)
				id_setLineSize_F = JNIEnv.GetMethodID (class_ref, "setLineSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (size);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLineSize_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineSize", "(F)V"), __args);
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

		static void n_SetThreshold_F (IntPtr jnienv, IntPtr native__this, float threshold)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageThresholdEdgeDetection __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageThresholdEdgeDetection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThreshold (threshold);
		}
#pragma warning restore 0169

		static IntPtr id_setThreshold_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageThresholdEdgeDetection']/method[@name='setThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setThreshold", "(F)V", "GetSetThreshold_FHandler")]
		public virtual unsafe void SetThreshold (float threshold)
		{
			if (id_setThreshold_F == IntPtr.Zero)
				id_setThreshold_F = JNIEnv.GetMethodID (class_ref, "setThreshold", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threshold);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThreshold_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThreshold", "(F)V"), __args);
			} finally {
			}
		}

	}
}
