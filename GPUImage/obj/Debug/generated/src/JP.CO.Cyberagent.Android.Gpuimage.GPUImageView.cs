using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageView", DoNotGenerateAcw=true)]
	public partial class GPUImageView : global::Android.Widget.FrameLayout {


		static IntPtr mForceSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/field[@name='mForceSize']"
		[Register ("mForceSize")]
		public global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.Size MForceSize {
			get {
				if (mForceSize_jfieldId == IntPtr.Zero)
					mForceSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mForceSize", "Ljp/co/cyberagent/android/gpuimage/GPUImageView$Size;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mForceSize_jfieldId);
				return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.Size> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mForceSize_jfieldId == IntPtr.Zero)
					mForceSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mForceSize", "Ljp/co/cyberagent/android/gpuimage/GPUImageView$Size;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mForceSize_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath interface reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/interface[@name='GPUImageView.OnPictureSavedListener']"
		[Register ("jp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener", "", "JP.CO.Cyberagent.Android.Gpuimage.GPUImageView/IOnPictureSavedListenerInvoker")]
		public partial interface IOnPictureSavedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/interface[@name='GPUImageView.OnPictureSavedListener']/method[@name='onPictureSaved' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("onPictureSaved", "(Landroid/net/Uri;)V", "GetOnPictureSaved_Landroid_net_Uri_Handler:JP.CO.Cyberagent.Android.Gpuimage.GPUImageView/IOnPictureSavedListenerInvoker, GPUImage")]
			void OnPictureSaved (global::Android.Net.Uri p0);

		}

		[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener", DoNotGenerateAcw=true)]
		internal class IOnPictureSavedListenerInvoker : global::Java.Lang.Object, IOnPictureSavedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IOnPictureSavedListenerInvoker); }
			}

			IntPtr class_ref;

			public static IOnPictureSavedListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IOnPictureSavedListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "jp.co.cyberagent.android.gpuimage.GPUImageView.OnPictureSavedListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IOnPictureSavedListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_onPictureSaved_Landroid_net_Uri_;
#pragma warning disable 0169
			static Delegate GetOnPictureSaved_Landroid_net_Uri_Handler ()
			{
				if (cb_onPictureSaved_Landroid_net_Uri_ == null)
					cb_onPictureSaved_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnPictureSaved_Landroid_net_Uri_);
				return cb_onPictureSaved_Landroid_net_Uri_;
			}

			static void n_OnPictureSaved_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.OnPictureSaved (p0);
			}
#pragma warning restore 0169

			IntPtr id_onPictureSaved_Landroid_net_Uri_;
			public unsafe void OnPictureSaved (global::Android.Net.Uri p0)
			{
				if (id_onPictureSaved_Landroid_net_Uri_ == IntPtr.Zero)
					id_onPictureSaved_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "onPictureSaved", "(Landroid/net/Uri;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPictureSaved_Landroid_net_Uri_, __args);
			}

		}

		public partial class PictureSavedEventArgs : global::System.EventArgs {

			public PictureSavedEventArgs (global::Android.Net.Uri p0)
			{
				this.p0 = p0;
			}

			global::Android.Net.Uri p0;
			public global::Android.Net.Uri P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/jp/co/cyberagent/android/gpuimage/GPUImageView_OnPictureSavedListenerImplementor")]
		internal sealed partial class IOnPictureSavedListenerImplementor : global::Java.Lang.Object, IOnPictureSavedListener {

			object sender;

			public IOnPictureSavedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/jp/co/cyberagent/android/gpuimage/GPUImageView_OnPictureSavedListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<PictureSavedEventArgs> Handler;
#pragma warning restore 0649

			public void OnPictureSaved (global::Android.Net.Uri p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new PictureSavedEventArgs (p0));
			}

			internal static bool __IsEmpty (IOnPictureSavedListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView.Size']"
		[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageView$Size", DoNotGenerateAcw=true)]
		public partial class Size : global::Java.Lang.Object {

			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageView$Size", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (Size); }
			}

			protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_II;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView.Size']/constructor[@name='GPUImageView.Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register (".ctor", "(II)V", "")]
			public unsafe Size (int width, int height)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (width);
					__args [1] = new JValue (height);
					if (((object) this).GetType () != typeof (Size)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(II)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(II)V", __args);
						return;
					}

					if (id_ctor_II == IntPtr.Zero)
						id_ctor_II = JNIEnv.GetMethodID (class_ref, "<init>", "(II)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_II, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_II, __args);
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageView); }
		}

		protected GPUImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/constructor[@name='GPUImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GPUImageView (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (GPUImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/constructor[@name='GPUImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe GPUImageView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (context);
				__args [1] = new JValue (attrs);
				if (((object) this).GetType () != typeof (GPUImageView)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, __args);
			} finally {
			}
		}

		static Delegate cb_getFilter;
#pragma warning disable 0169
		static Delegate GetGetFilterHandler ()
		{
			if (cb_getFilter == null)
				cb_getFilter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilter);
			return cb_getFilter;
		}

		static IntPtr n_GetFilter (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Filter);
		}
#pragma warning restore 0169

		static Delegate cb_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
#pragma warning disable 0169
		static Delegate GetSetFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_Handler ()
		{
			if (cb_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ == null)
				cb_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_);
			return cb_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		}

		static void n_SetFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filter)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter filter = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.Filter = filter;
		}
#pragma warning restore 0169

		static IntPtr id_getFilter;
		static IntPtr id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		public virtual unsafe global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter Filter {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='getFilter' and count(parameter)=0]"
			[Register ("getFilter", "()Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;", "GetGetFilterHandler")]
			get {
				if (id_getFilter == IntPtr.Zero)
					id_getFilter = JNIEnv.GetMethodID (class_ref, "getFilter", "()Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilter), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilter", "()Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImageFilter']]"
			[Register ("setFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V", "GetSetFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_Handler")]
			set {
				if (id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ == IntPtr.Zero)
					id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ = JNIEnv.GetMethodID (class_ref, "setFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGPUImage;
#pragma warning disable 0169
		static Delegate GetGetGPUImageHandler ()
		{
			if (cb_getGPUImage == null)
				cb_getGPUImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGPUImage);
			return cb_getGPUImage;
		}

		static IntPtr n_GetGPUImage (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GPUImage);
		}
#pragma warning restore 0169

		static IntPtr id_getGPUImage;
		public virtual unsafe global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage GPUImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='getGPUImage' and count(parameter)=0]"
			[Register ("getGPUImage", "()Ljp/co/cyberagent/android/gpuimage/GPUImage;", "GetGetGPUImageHandler")]
			get {
				if (id_getGPUImage == IntPtr.Zero)
					id_getGPUImage = JNIEnv.GetMethodID (class_ref, "getGPUImage", "()Ljp/co/cyberagent/android/gpuimage/GPUImage;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGPUImage), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGPUImage", "()Ljp/co/cyberagent/android/gpuimage/GPUImage;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_capture;
#pragma warning disable 0169
		static Delegate GetCaptureHandler ()
		{
			if (cb_capture == null)
				cb_capture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Capture);
			return cb_capture;
		}

		static IntPtr n_Capture (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Capture ());
		}
#pragma warning restore 0169

		static IntPtr id_capture;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='capture' and count(parameter)=0]"
		[Register ("capture", "()Landroid/graphics/Bitmap;", "GetCaptureHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap Capture ()
		{
			if (id_capture == IntPtr.Zero)
				id_capture = JNIEnv.GetMethodID (class_ref, "capture", "()Landroid/graphics/Bitmap;");
			try {

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_capture), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "capture", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_capture_II;
#pragma warning disable 0169
		static Delegate GetCapture_IIHandler ()
		{
			if (cb_capture_II == null)
				cb_capture_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Capture_II);
			return cb_capture_II;
		}

		static IntPtr n_Capture_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Capture (width, height));
		}
#pragma warning restore 0169

		static IntPtr id_capture_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='capture' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("capture", "(II)Landroid/graphics/Bitmap;", "GetCapture_IIHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap Capture (int width, int height)
		{
			if (id_capture_II == IntPtr.Zero)
				id_capture_II = JNIEnv.GetMethodID (class_ref, "capture", "(II)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (width);
				__args [1] = new JValue (height);

				if (((object) this).GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_capture_II, __args), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "capture", "(II)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		static IntPtr id_onPause;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			if (id_onPause == IntPtr.Zero)
				id_onPause = JNIEnv.GetMethodID (class_ref, "onPause", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPause);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPause", "()V"));
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_requestRender;
#pragma warning disable 0169
		static Delegate GetRequestRenderHandler ()
		{
			if (cb_requestRender == null)
				cb_requestRender = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RequestRender);
			return cb_requestRender;
		}

		static void n_RequestRender (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		static IntPtr id_requestRender;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='requestRender' and count(parameter)=0]"
		[Register ("requestRender", "()V", "GetRequestRenderHandler")]
		public virtual unsafe void RequestRender ()
		{
			if (id_requestRender == IntPtr.Zero)
				id_requestRender = JNIEnv.GetMethodID (class_ref, "requestRender", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_requestRender);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "requestRender", "()V"));
			} finally {
			}
		}

		static Delegate cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_;
#pragma warning disable 0169
		static Delegate GetSaveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_Handler ()
		{
			if (cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ == null)
				cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_SaveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_);
			return cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_;
		}

		static void n_SaveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folderName, IntPtr native_fileName, int width, int height, IntPtr native_listener)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string folderName = JNIEnv.GetString (native_folderName, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener listener = (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener)global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SaveToPictures (folderName, fileName, width, height, listener);
		}
#pragma warning restore 0169

		static IntPtr id_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='saveToPictures' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='jp.co.cyberagent.android.gpuimage.GPUImageView.OnPictureSavedListener']]"
		[Register ("saveToPictures", "(Ljava/lang/String;Ljava/lang/String;IILjp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener;)V", "GetSaveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_Handler")]
		public virtual unsafe void SaveToPictures (string folderName, string fileName, int width, int height, global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener listener)
		{
			if (id_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ == IntPtr.Zero)
				id_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ = JNIEnv.GetMethodID (class_ref, "saveToPictures", "(Ljava/lang/String;Ljava/lang/String;IILjp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener;)V");
			IntPtr native_folderName = JNIEnv.NewString (folderName);
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_folderName);
				__args [1] = new JValue (native_fileName);
				__args [2] = new JValue (width);
				__args [3] = new JValue (height);
				__args [4] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveToPictures_Ljava_lang_String_Ljava_lang_String_IILjp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToPictures", "(Ljava/lang/String;Ljava/lang/String;IILjp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_folderName);
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_;
#pragma warning disable 0169
		static Delegate GetSaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_Handler ()
		{
			if (cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ == null)
				cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_);
			return cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_;
		}

		static void n_SaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folderName, IntPtr native_fileName, IntPtr native_listener)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string folderName = JNIEnv.GetString (native_folderName, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener listener = (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener)global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SaveToPictures (folderName, fileName, listener);
		}
#pragma warning restore 0169

		static IntPtr id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='saveToPictures' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='jp.co.cyberagent.android.gpuimage.GPUImageView.OnPictureSavedListener']]"
		[Register ("saveToPictures", "(Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener;)V", "GetSaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_Handler")]
		public virtual unsafe void SaveToPictures (string folderName, string fileName, global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView.IOnPictureSavedListener listener)
		{
			if (id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ == IntPtr.Zero)
				id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_ = JNIEnv.GetMethodID (class_ref, "saveToPictures", "(Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener;)V");
			IntPtr native_folderName = JNIEnv.NewString (folderName);
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_folderName);
				__args [1] = new JValue (native_fileName);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImageView_OnPictureSavedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToPictures", "(Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImageView$OnPictureSavedListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_folderName);
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_setImage_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImage_Landroid_graphics_Bitmap_ == null)
				cb_setImage_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_graphics_Bitmap_);
			return cb_setImage_Landroid_graphics_Bitmap_;
		}

		static void n_SetImage_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (bitmap);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImage", "(Landroid/graphics/Bitmap;)V", "GetSetImage_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImage (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_setImage_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImage_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Landroid_net_Uri_;
#pragma warning disable 0169
		static Delegate GetSetImage_Landroid_net_Uri_Handler ()
		{
			if (cb_setImage_Landroid_net_Uri_ == null)
				cb_setImage_Landroid_net_Uri_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Landroid_net_Uri_);
			return cb_setImage_Landroid_net_Uri_;
		}

		static void n_SetImage_Landroid_net_Uri_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (uri);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
		[Register ("setImage", "(Landroid/net/Uri;)V", "GetSetImage_Landroid_net_Uri_Handler")]
		public virtual unsafe void SetImage (global::Android.Net.Uri uri)
		{
			if (id_setImage_Landroid_net_Uri_ == IntPtr.Zero)
				id_setImage_Landroid_net_Uri_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Landroid/net/Uri;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (uri);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Landroid_net_Uri_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Landroid/net/Uri;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetSetImage_Ljava_io_File_Handler ()
		{
			if (cb_setImage_Ljava_io_File_ == null)
				cb_setImage_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Ljava_io_File_);
			return cb_setImage_Ljava_io_File_;
		}

		static void n_SetImage_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_file)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (file);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
		[Register ("setImage", "(Ljava/io/File;)V", "GetSetImage_Ljava_io_File_Handler")]
		public virtual unsafe void SetImage (global::Java.IO.File file)
		{
			if (id_setImage_Ljava_io_File_ == IntPtr.Zero)
				id_setImage_Ljava_io_File_ = JNIEnv.GetMethodID (class_ref, "setImage", "(Ljava/io/File;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (file);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImage_Ljava_io_File_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImage", "(Ljava/io/File;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRatio_F;
#pragma warning disable 0169
		static Delegate GetSetRatio_FHandler ()
		{
			if (cb_setRatio_F == null)
				cb_setRatio_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRatio_F);
			return cb_setRatio_F;
		}

		static void n_SetRatio_F (IntPtr jnienv, IntPtr native__this, float ratio)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRatio (ratio);
		}
#pragma warning restore 0169

		static IntPtr id_setRatio_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setRatio' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRatio", "(F)V", "GetSetRatio_FHandler")]
		public virtual unsafe void SetRatio (float ratio)
		{
			if (id_setRatio_F == IntPtr.Zero)
				id_setRatio_F = JNIEnv.GetMethodID (class_ref, "setRatio", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (ratio);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRatio_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRatio", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_;
#pragma warning disable 0169
		static Delegate GetSetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_Handler ()
		{
			if (cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ == null)
				cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_);
			return cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_;
		}

		static void n_SetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rotation)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (rotation);
		}
#pragma warning restore 0169

		static IntPtr id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation']]"
		[Register ("setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;)V", "GetSetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_Handler")]
		public virtual unsafe void SetRotation (global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation)
		{
			if (id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ == IntPtr.Zero)
				id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ = JNIEnv.GetMethodID (class_ref, "setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (rotation);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_;
#pragma warning disable 0169
		static Delegate GetSetScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_Handler ()
		{
			if (cb_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_ == null)
				cb_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_);
			return cb_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_;
		}

		static void n_SetScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scaleType)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType scaleType = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleType (scaleType);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageView']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImage.ScaleType']]"
		[Register ("setScaleType", "(Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;)V", "GetSetScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_Handler")]
		public virtual unsafe void SetScaleType (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType scaleType)
		{
			if (id_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_ == IntPtr.Zero)
				id_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_ = JNIEnv.GetMethodID (class_ref, "setScaleType", "(Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scaleType);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScaleType", "(Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;)V"), __args);
			} finally {
			}
		}

	}
}
