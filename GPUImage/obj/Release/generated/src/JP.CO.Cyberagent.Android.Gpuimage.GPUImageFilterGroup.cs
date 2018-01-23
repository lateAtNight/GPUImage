using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageFilterGroup", DoNotGenerateAcw=true)]
	public partial class GPUImageFilterGroup : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		static IntPtr mFilters_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/field[@name='mFilters']"
		[Register ("mFilters")]
		protected global::System.Collections.IList MFilters {
			get {
				if (mFilters_jfieldId == IntPtr.Zero)
					mFilters_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilters", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mFilters_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mFilters_jfieldId == IntPtr.Zero)
					mFilters_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilters", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFilters_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMergedFilters_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/field[@name='mMergedFilters']"
		[Register ("mMergedFilters")]
		protected global::System.Collections.IList MMergedFilters {
			get {
				if (mMergedFilters_jfieldId == IntPtr.Zero)
					mMergedFilters_jfieldId = JNIEnv.GetFieldID (class_ref, "mMergedFilters", "Ljava/util/List;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMergedFilters_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMergedFilters_jfieldId == IntPtr.Zero)
					mMergedFilters_jfieldId = JNIEnv.GetFieldID (class_ref, "mMergedFilters", "Ljava/util/List;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMergedFilters_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageFilterGroup", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageFilterGroup); }
		}

		protected GPUImageFilterGroup (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/constructor[@name='GPUImageFilterGroup' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageFilterGroup ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageFilterGroup)) {
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

		static IntPtr id_ctor_Ljava_util_List_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/constructor[@name='GPUImageFilterGroup' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;jp.co.cyberagent.android.gpuimage.GPUImageFilter&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe GPUImageFilterGroup (global::System.Collections.Generic.IList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> filters)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_filters = global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.ToLocalJniHandle (filters);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_filters);
				if (((object) this).GetType () != typeof (GPUImageFilterGroup)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/util/List;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/util/List;)V", __args);
					return;
				}

				if (id_ctor_Ljava_util_List_ == IntPtr.Zero)
					id_ctor_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/util/List;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_util_List_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_util_List_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filters);
			}
		}

		static Delegate cb_getFilters;
#pragma warning disable 0169
		static Delegate GetGetFiltersHandler ()
		{
			if (cb_getFilters == null)
				cb_getFilters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilters);
			return cb_getFilters;
		}

		static IntPtr n_GetFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.ToLocalJniHandle (__this.Filters);
		}
#pragma warning restore 0169

		static IntPtr id_getFilters;
		public virtual unsafe global::System.Collections.Generic.IList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> Filters {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/method[@name='getFilters' and count(parameter)=0]"
			[Register ("getFilters", "()Ljava/util/List;", "GetGetFiltersHandler")]
			get {
				if (id_getFilters == IntPtr.Zero)
					id_getFilters = JNIEnv.GetMethodID (class_ref, "getFilters", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilters", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMergedFilters;
#pragma warning disable 0169
		static Delegate GetGetMergedFiltersHandler ()
		{
			if (cb_getMergedFilters == null)
				cb_getMergedFilters = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMergedFilters);
			return cb_getMergedFilters;
		}

		static IntPtr n_GetMergedFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.ToLocalJniHandle (__this.MergedFilters);
		}
#pragma warning restore 0169

		static IntPtr id_getMergedFilters;
		public virtual unsafe global::System.Collections.Generic.IList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> MergedFilters {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/method[@name='getMergedFilters' and count(parameter)=0]"
			[Register ("getMergedFilters", "()Ljava/util/List;", "GetGetMergedFiltersHandler")]
			get {
				if (id_getMergedFilters == IntPtr.Zero)
					id_getMergedFilters = JNIEnv.GetMethodID (class_ref, "getMergedFilters", "()Ljava/util/List;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMergedFilters), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMergedFilters", "()Ljava/util/List;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
#pragma warning disable 0169
		static Delegate GetAddFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_Handler ()
		{
			if (cb_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ == null)
				cb_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_);
			return cb_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		}

		static void n_AddFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_aFilter)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter aFilter = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (native_aFilter, JniHandleOwnership.DoNotTransfer);
			__this.AddFilter (aFilter);
		}
#pragma warning restore 0169

		static IntPtr id_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/method[@name='addFilter' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImageFilter']]"
		[Register ("addFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V", "GetAddFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_Handler")]
		public virtual unsafe void AddFilter (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter aFilter)
		{
			if (id_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ == IntPtr.Zero)
				id_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ = JNIEnv.GetMethodID (class_ref, "addFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (aFilter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_updateMergedFilters;
#pragma warning disable 0169
		static Delegate GetUpdateMergedFiltersHandler ()
		{
			if (cb_updateMergedFilters == null)
				cb_updateMergedFilters = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_UpdateMergedFilters);
			return cb_updateMergedFilters;
		}

		static void n_UpdateMergedFilters (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateMergedFilters ();
		}
#pragma warning restore 0169

		static IntPtr id_updateMergedFilters;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilterGroup']/method[@name='updateMergedFilters' and count(parameter)=0]"
		[Register ("updateMergedFilters", "()V", "GetUpdateMergedFiltersHandler")]
		public virtual unsafe void UpdateMergedFilters ()
		{
			if (id_updateMergedFilters == IntPtr.Zero)
				id_updateMergedFilters = JNIEnv.GetMethodID (class_ref, "updateMergedFilters", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_updateMergedFilters);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "updateMergedFilters", "()V"));
			} finally {
			}
		}

	}
}
