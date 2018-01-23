using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageEmbossFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageEmbossFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageEmbossFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3ConvolutionFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageEmbossFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageEmbossFilter); }
		}

		protected GPUImageEmbossFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageEmbossFilter']/constructor[@name='GPUImageEmbossFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageEmbossFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageEmbossFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageEmbossFilter']/constructor[@name='GPUImageEmbossFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageEmbossFilter (float intensity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (intensity);
				if (((object) this).GetType () != typeof (GPUImageEmbossFilter)) {
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

		static Delegate cb_getIntensity;
#pragma warning disable 0169
		static Delegate GetGetIntensityHandler ()
		{
			if (cb_getIntensity == null)
				cb_getIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetIntensity);
			return cb_getIntensity;
		}

		static float n_GetIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageEmbossFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageEmbossFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Intensity;
		}
#pragma warning restore 0169

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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageEmbossFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageEmbossFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Intensity = intensity;
		}
#pragma warning restore 0169

		static IntPtr id_getIntensity;
		static IntPtr id_setIntensity_F;
		public virtual unsafe float Intensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageEmbossFilter']/method[@name='getIntensity' and count(parameter)=0]"
			[Register ("getIntensity", "()F", "GetGetIntensityHandler")]
			get {
				if (id_getIntensity == IntPtr.Zero)
					id_getIntensity = JNIEnv.GetMethodID (class_ref, "getIntensity", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getIntensity);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIntensity", "()F"));
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageEmbossFilter']/method[@name='setIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setIntensity", "(F)V", "GetSetIntensity_FHandler")]
			set {
				if (id_setIntensity_F == IntPtr.Zero)
					id_setIntensity_F = JNIEnv.GetMethodID (class_ref, "setIntensity", "(F)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntensity_F, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntensity", "(F)V"), __args);
				} finally {
				}
			}
		}

	}
}
