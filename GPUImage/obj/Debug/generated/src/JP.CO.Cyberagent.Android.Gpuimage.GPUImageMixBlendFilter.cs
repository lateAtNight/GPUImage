using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMixBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageMixBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageMixBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageMixBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageMixBlendFilter); }
		}

		protected GPUImageMixBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMixBlendFilter']/constructor[@name='GPUImageMixBlendFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GPUImageMixBlendFilter (string fragmentShader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_fragmentShader);
				if (((object) this).GetType () != typeof (GPUImageMixBlendFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fragmentShader);
			}
		}

		static IntPtr id_ctor_Ljava_lang_String_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMixBlendFilter']/constructor[@name='GPUImageMixBlendFilter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='float']]"
		[Register (".ctor", "(Ljava/lang/String;F)V", "")]
		public unsafe GPUImageMixBlendFilter (string fragmentShader, float mix)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_fragmentShader);
				__args [1] = new JValue (mix);
				if (((object) this).GetType () != typeof (GPUImageMixBlendFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;F)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_F == IntPtr.Zero)
					id_ctor_Ljava_lang_String_F = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_F, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fragmentShader);
			}
		}

		static Delegate cb_setMix_F;
#pragma warning disable 0169
		static Delegate GetSetMix_FHandler ()
		{
			if (cb_setMix_F == null)
				cb_setMix_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMix_F);
			return cb_setMix_F;
		}

		static void n_SetMix_F (IntPtr jnienv, IntPtr native__this, float mix)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMixBlendFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMixBlendFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMix (mix);
		}
#pragma warning restore 0169

		static IntPtr id_setMix_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMixBlendFilter']/method[@name='setMix' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMix", "(F)V", "GetSetMix_FHandler")]
		public virtual unsafe void SetMix (float mix)
		{
			if (id_setMix_F == IntPtr.Zero)
				id_setMix_F = JNIEnv.GetMethodID (class_ref, "setMix", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (mix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMix_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMix", "(F)V"), __args);
			} finally {
			}
		}

	}
}
