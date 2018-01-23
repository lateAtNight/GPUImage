using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImage", DoNotGenerateAcw=true)]
	public partial class GPUImage : global::Java.Lang.Object {

		// Metadata.xml XPath interface reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/interface[@name='GPUImage.OnPictureSavedListener']"
		[Register ("jp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener", "", "JP.CO.Cyberagent.Android.Gpuimage.GPUImage/IOnPictureSavedListenerInvoker")]
		public partial interface IOnPictureSavedListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/interface[@name='GPUImage.OnPictureSavedListener']/method[@name='onPictureSaved' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
			[Register ("onPictureSaved", "(Landroid/net/Uri;)V", "GetOnPictureSaved_Landroid_net_Uri_Handler:JP.CO.Cyberagent.Android.Gpuimage.GPUImage/IOnPictureSavedListenerInvoker, GPUImage")]
			void OnPictureSaved (global::Android.Net.Uri p0);

		}

		[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener", DoNotGenerateAcw=true)]
		internal class IOnPictureSavedListenerInvoker : global::Java.Lang.Object, IOnPictureSavedListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener");

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
								JNIEnv.GetClassNameFromInstance (handle), "jp.co.cyberagent.android.gpuimage.GPUImage.OnPictureSavedListener"));
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
				global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		[global::Android.Runtime.Register ("mono/jp/co/cyberagent/android/gpuimage/GPUImage_OnPictureSavedListenerImplementor")]
		internal sealed partial class IOnPictureSavedListenerImplementor : global::Java.Lang.Object, IOnPictureSavedListener {

			object sender;

			public IOnPictureSavedListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/jp/co/cyberagent/android/gpuimage/GPUImage_OnPictureSavedListenerImplementor", "()V"),
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


		// Metadata.xml XPath interface reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/interface[@name='GPUImage.ResponseListener']"
		[Register ("jp/co/cyberagent/android/gpuimage/GPUImage$ResponseListener", "", "JP.CO.Cyberagent.Android.Gpuimage.GPUImage/IResponseListenerInvoker")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public partial interface IResponseListener : IJavaObject {

			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/interface[@name='GPUImage.ResponseListener']/method[@name='response' and count(parameter)=1 and parameter[1][@type='T']]"
			[Register ("response", "(Ljava/lang/Object;)V", "GetResponse_Ljava_lang_Object_Handler:JP.CO.Cyberagent.Android.Gpuimage.GPUImage/IResponseListenerInvoker, GPUImage")]
			void Response (global::Java.Lang.Object p0);

		}

		[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImage$ResponseListener", DoNotGenerateAcw=true)]
		internal class IResponseListenerInvoker : global::Java.Lang.Object, IResponseListener {

			static IntPtr java_class_ref = JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImage$ResponseListener");

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (IResponseListenerInvoker); }
			}

			IntPtr class_ref;

			public static IResponseListener GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<IResponseListener> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
								JNIEnv.GetClassNameFromInstance (handle), "jp.co.cyberagent.android.gpuimage.GPUImage.ResponseListener"));
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public IResponseListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_response_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetResponse_Ljava_lang_Object_Handler ()
			{
				if (cb_response_Ljava_lang_Object_ == null)
					cb_response_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Response_Ljava_lang_Object_);
				return cb_response_Ljava_lang_Object_;
			}

			static void n_Response_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
			{
				global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IResponseListener __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IResponseListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
				__this.Response (p0);
			}
#pragma warning restore 0169

			IntPtr id_response_Ljava_lang_Object_;
			public unsafe void Response (global::Java.Lang.Object p0)
			{
				if (id_response_Ljava_lang_Object_ == IntPtr.Zero)
					id_response_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "response", "(Ljava/lang/Object;)V");
				IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_response_Ljava_lang_Object_, __args);
				JNIEnv.DeleteLocalRef (native_p0);
			}

		}

		public partial class ResponseEventArgs : global::System.EventArgs {

			public ResponseEventArgs (global::Java.Lang.Object p0)
			{
				this.p0 = p0;
			}

			global::Java.Lang.Object p0;
			public global::Java.Lang.Object P0 {
				get { return p0; }
			}
		}

		[global::Android.Runtime.Register ("mono/jp/co/cyberagent/android/gpuimage/GPUImage_ResponseListenerImplementor")]
		internal sealed partial class IResponseListenerImplementor : global::Java.Lang.Object, IResponseListener {

			object sender;

			public IResponseListenerImplementor (object sender)
				: base (
					global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/jp/co/cyberagent/android/gpuimage/GPUImage_ResponseListenerImplementor", "()V"),
					JniHandleOwnership.TransferLocalRef)
			{
				global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
				this.sender = sender;
			}

#pragma warning disable 0649
			public EventHandler<ResponseEventArgs> Handler;
#pragma warning restore 0649

			public void Response (global::Java.Lang.Object p0)
			{
				var __h = Handler;
				if (__h != null)
					__h (sender, new ResponseEventArgs (p0));
			}

			internal static bool __IsEmpty (IResponseListenerImplementor value)
			{
				return value.Handler == null;
			}
		}


		// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage.ScaleType']"
		[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImage$ScaleType", DoNotGenerateAcw=true)]
		public sealed partial class ScaleType : global::Java.Lang.Enum {


			static IntPtr CENTER_CROP_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage.ScaleType']/field[@name='CENTER_CROP']"
			[Register ("CENTER_CROP")]
			public static global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType CenterCrop {
				get {
					if (CENTER_CROP_jfieldId == IntPtr.Zero)
						CENTER_CROP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER_CROP", "Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CENTER_CROP_jfieldId);
					return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr CENTER_INSIDE_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage.ScaleType']/field[@name='CENTER_INSIDE']"
			[Register ("CENTER_INSIDE")]
			public static global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType CenterInside {
				get {
					if (CENTER_INSIDE_jfieldId == IntPtr.Zero)
						CENTER_INSIDE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CENTER_INSIDE", "Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CENTER_INSIDE_jfieldId);
					return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static new IntPtr java_class_handle;
			internal static new IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImage$ScaleType", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (ScaleType); }
			}

			internal ScaleType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage.ScaleType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;", "")]
			public static unsafe global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType ValueOf (string name)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;");
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_name);
					global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType __ret = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage.ScaleType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;", "")]
			public static unsafe global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Ljp/co/cyberagent/android/gpuimage/GPUImage$ScaleType;");
				try {
					return (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType));
				} finally {
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImage", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImage); }
		}

		protected GPUImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/constructor[@name='GPUImage' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe GPUImage (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (context);
				if (((object) this).GetType () != typeof (GPUImage)) {
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

		static Delegate cb_getBitmapWithFilterApplied;
#pragma warning disable 0169
		static Delegate GetGetBitmapWithFilterAppliedHandler ()
		{
			if (cb_getBitmapWithFilterApplied == null)
				cb_getBitmapWithFilterApplied = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmapWithFilterApplied);
			return cb_getBitmapWithFilterApplied;
		}

		static IntPtr n_GetBitmapWithFilterApplied (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BitmapWithFilterApplied);
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapWithFilterApplied;
		public virtual unsafe global::Android.Graphics.Bitmap BitmapWithFilterApplied {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='getBitmapWithFilterApplied' and count(parameter)=0]"
			[Register ("getBitmapWithFilterApplied", "()Landroid/graphics/Bitmap;", "GetGetBitmapWithFilterAppliedHandler")]
			get {
				if (id_getBitmapWithFilterApplied == IntPtr.Zero)
					id_getBitmapWithFilterApplied = JNIEnv.GetMethodID (class_ref, "getBitmapWithFilterApplied", "()Landroid/graphics/Bitmap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmapWithFilterApplied), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapWithFilterApplied", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_deleteImage;
#pragma warning disable 0169
		static Delegate GetDeleteImageHandler ()
		{
			if (cb_deleteImage == null)
				cb_deleteImage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DeleteImage);
			return cb_deleteImage;
		}

		static void n_DeleteImage (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteImage ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='deleteImage' and count(parameter)=0]"
		[Register ("deleteImage", "()V", "GetDeleteImageHandler")]
		public virtual unsafe void DeleteImage ()
		{
			if (id_deleteImage == IntPtr.Zero)
				id_deleteImage = JNIEnv.GetMethodID (class_ref, "deleteImage", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteImage);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteImage", "()V"));
			} finally {
			}
		}

		static IntPtr id_getBitmapForMultipleFilters_Landroid_graphics_Bitmap_Ljava_util_List_Ljp_co_cyberagent_android_gpuimage_GPUImage_ResponseListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='getBitmapForMultipleFilters' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.util.List&lt;jp.co.cyberagent.android.gpuimage.GPUImageFilter&gt;'] and parameter[3][@type='jp.co.cyberagent.android.gpuimage.GPUImage.ResponseListener&lt;android.graphics.Bitmap&gt;']]"
		[Register ("getBitmapForMultipleFilters", "(Landroid/graphics/Bitmap;Ljava/util/List;Ljp/co/cyberagent/android/gpuimage/GPUImage$ResponseListener;)V", "")]
		public static unsafe void GetBitmapForMultipleFilters (global::Android.Graphics.Bitmap bitmap, global::System.Collections.Generic.IList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> filters, global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IResponseListener listener)
		{
			if (id_getBitmapForMultipleFilters_Landroid_graphics_Bitmap_Ljava_util_List_Ljp_co_cyberagent_android_gpuimage_GPUImage_ResponseListener_ == IntPtr.Zero)
				id_getBitmapForMultipleFilters_Landroid_graphics_Bitmap_Ljava_util_List_Ljp_co_cyberagent_android_gpuimage_GPUImage_ResponseListener_ = JNIEnv.GetStaticMethodID (class_ref, "getBitmapForMultipleFilters", "(Landroid/graphics/Bitmap;Ljava/util/List;Ljp/co/cyberagent/android/gpuimage/GPUImage$ResponseListener;)V");
			IntPtr native_filters = global::Android.Runtime.JavaList<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter>.ToLocalJniHandle (filters);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (bitmap);
				__args [1] = new JValue (native_filters);
				__args [2] = new JValue (listener);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_getBitmapForMultipleFilters_Landroid_graphics_Bitmap_Ljava_util_List_Ljp_co_cyberagent_android_gpuimage_GPUImage_ResponseListener_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filters);
			}
		}

		static Delegate cb_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetGetBitmapWithFilterApplied_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_ == null)
				cb_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetBitmapWithFilterApplied_Landroid_graphics_Bitmap_);
			return cb_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_;
		}

		static IntPtr n_GetBitmapWithFilterApplied_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBitmapWithFilterApplied (bitmap));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='getBitmapWithFilterApplied' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("getBitmapWithFilterApplied", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;", "GetGetBitmapWithFilterApplied_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe global::Android.Graphics.Bitmap GetBitmapWithFilterApplied (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "getBitmapWithFilterApplied", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);

				global::Android.Graphics.Bitmap __ret;
				if (((object) this).GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmapWithFilterApplied_Landroid_graphics_Bitmap_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmapWithFilterApplied", "(Landroid/graphics/Bitmap;)Landroid/graphics/Bitmap;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RequestRender ();
		}
#pragma warning restore 0169

		static IntPtr id_requestRender;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='requestRender' and count(parameter)=0]"
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

		static Delegate cb_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_;
#pragma warning disable 0169
		static Delegate GetSaveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_Handler ()
		{
			if (cb_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ == null)
				cb_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_);
			return cb_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_;
		}

		static void n_SaveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native_folderName, IntPtr native_fileName, IntPtr native_listener)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			string folderName = JNIEnv.GetString (native_folderName, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener listener = (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener)global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SaveToPictures (bitmap, folderName, fileName, listener);
		}
#pragma warning restore 0169

		static IntPtr id_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='saveToPictures' and count(parameter)=4 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='jp.co.cyberagent.android.gpuimage.GPUImage.OnPictureSavedListener']]"
		[Obsolete (@"deprecated")]
		[Register ("saveToPictures", "(Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener;)V", "GetSaveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_Handler")]
		public virtual unsafe void SaveToPictures (global::Android.Graphics.Bitmap bitmap, string folderName, string fileName, global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener listener)
		{
			if (id_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ == IntPtr.Zero)
				id_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ = JNIEnv.GetMethodID (class_ref, "saveToPictures", "(Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener;)V");
			IntPtr native_folderName = JNIEnv.NewString (folderName);
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (bitmap);
				__args [1] = new JValue (native_folderName);
				__args [2] = new JValue (native_fileName);
				__args [3] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveToPictures_Landroid_graphics_Bitmap_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToPictures", "(Landroid/graphics/Bitmap;Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_folderName);
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_;
#pragma warning disable 0169
		static Delegate GetSaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_Handler ()
		{
			if (cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ == null)
				cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_);
			return cb_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_;
		}

		static void n_SaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_folderName, IntPtr native_fileName, IntPtr native_listener)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string folderName = JNIEnv.GetString (native_folderName, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener listener = (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener)global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SaveToPictures (folderName, fileName, listener);
		}
#pragma warning restore 0169

		static IntPtr id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='saveToPictures' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='jp.co.cyberagent.android.gpuimage.GPUImage.OnPictureSavedListener']]"
		[Obsolete (@"deprecated")]
		[Register ("saveToPictures", "(Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener;)V", "GetSaveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_Handler")]
		public virtual unsafe void SaveToPictures (string folderName, string fileName, global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.IOnPictureSavedListener listener)
		{
			if (id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ == IntPtr.Zero)
				id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_ = JNIEnv.GetMethodID (class_ref, "saveToPictures", "(Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener;)V");
			IntPtr native_folderName = JNIEnv.NewString (folderName);
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_folderName);
				__args [1] = new JValue (native_fileName);
				__args [2] = new JValue (listener);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_saveToPictures_Ljava_lang_String_Ljava_lang_String_Ljp_co_cyberagent_android_gpuimage_GPUImage_OnPictureSavedListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "saveToPictures", "(Ljava/lang/String;Ljava/lang/String;Ljp/co/cyberagent/android/gpuimage/GPUImage$OnPictureSavedListener;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_folderName);
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter filter = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.SetFilter (filter);
		}
#pragma warning restore 0169

		static IntPtr id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImageFilter']]"
		[Register ("setFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V", "GetSetFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_Handler")]
		public virtual unsafe void SetFilter (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter filter)
		{
			if (id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ == IntPtr.Zero)
				id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ = JNIEnv.GetMethodID (class_ref, "setFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFilter", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGLSurfaceView_Landroid_opengl_GLSurfaceView_;
#pragma warning disable 0169
		static Delegate GetSetGLSurfaceView_Landroid_opengl_GLSurfaceView_Handler ()
		{
			if (cb_setGLSurfaceView_Landroid_opengl_GLSurfaceView_ == null)
				cb_setGLSurfaceView_Landroid_opengl_GLSurfaceView_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGLSurfaceView_Landroid_opengl_GLSurfaceView_);
			return cb_setGLSurfaceView_Landroid_opengl_GLSurfaceView_;
		}

		static void n_SetGLSurfaceView_Landroid_opengl_GLSurfaceView_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Opengl.GLSurfaceView view = global::Java.Lang.Object.GetObject<global::Android.Opengl.GLSurfaceView> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.SetGLSurfaceView (view);
		}
#pragma warning restore 0169

		static IntPtr id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setGLSurfaceView' and count(parameter)=1 and parameter[1][@type='android.opengl.GLSurfaceView']]"
		[Register ("setGLSurfaceView", "(Landroid/opengl/GLSurfaceView;)V", "GetSetGLSurfaceView_Landroid_opengl_GLSurfaceView_Handler")]
		public virtual unsafe void SetGLSurfaceView (global::Android.Opengl.GLSurfaceView view)
		{
			if (id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_ == IntPtr.Zero)
				id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_ = JNIEnv.GetMethodID (class_ref, "setGLSurfaceView", "(Landroid/opengl/GLSurfaceView;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (view);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGLSurfaceView_Landroid_opengl_GLSurfaceView_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGLSurfaceView", "(Landroid/opengl/GLSurfaceView;)V"), __args);
			} finally {
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (bitmap);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (uri);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Landroid_net_Uri_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='android.net.Uri']]"
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.IO.File file = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_file, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (file);
		}
#pragma warning restore 0169

		static IntPtr id_setImage_Ljava_io_File_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='java.io.File']]"
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (rotation);
		}
#pragma warning restore 0169

		static IntPtr id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation']]"
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

		static Delegate cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
#pragma warning disable 0169
		static Delegate GetSetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZHandler ()
		{
			if (cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ == null)
				cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_SetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ);
			return cb_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		}

		static void n_SetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_rotation, bool flipHorizontal, bool flipVertical)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (rotation, flipHorizontal, flipVertical);
		}
#pragma warning restore 0169

		static IntPtr id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setRotation' and count(parameter)=3 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)V", "GetSetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZHandler")]
		public virtual unsafe void SetRotation (global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation, bool flipHorizontal, bool flipVertical)
		{
			if (id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ == IntPtr.Zero)
				id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ = JNIEnv.GetMethodID (class_ref, "setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (rotation);
				__args [1] = new JValue (flipHorizontal);
				__args [2] = new JValue (flipVertical);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)V"), __args);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType scaleType = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleType (scaleType);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImage.ScaleType']]"
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

		static Delegate cb_setUpCamera_Landroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetSetUpCamera_Landroid_hardware_Camera_Handler ()
		{
			if (cb_setUpCamera_Landroid_hardware_Camera_ == null)
				cb_setUpCamera_Landroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUpCamera_Landroid_hardware_Camera_);
			return cb_setUpCamera_Landroid_hardware_Camera_;
		}

		static void n_SetUpCamera_Landroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_camera)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera camera = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_camera, JniHandleOwnership.DoNotTransfer);
			__this.SetUpCamera (camera);
		}
#pragma warning restore 0169

		static IntPtr id_setUpCamera_Landroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setUpCamera' and count(parameter)=1 and parameter[1][@type='android.hardware.Camera']]"
		[Register ("setUpCamera", "(Landroid/hardware/Camera;)V", "GetSetUpCamera_Landroid_hardware_Camera_Handler")]
		public virtual unsafe void SetUpCamera (global::Android.Hardware.Camera camera)
		{
			if (id_setUpCamera_Landroid_hardware_Camera_ == IntPtr.Zero)
				id_setUpCamera_Landroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "setUpCamera", "(Landroid/hardware/Camera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (camera);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpCamera_Landroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpCamera", "(Landroid/hardware/Camera;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUpCamera_Landroid_hardware_Camera_IZZ;
#pragma warning disable 0169
		static Delegate GetSetUpCamera_Landroid_hardware_Camera_IZZHandler ()
		{
			if (cb_setUpCamera_Landroid_hardware_Camera_IZZ == null)
				cb_setUpCamera_Landroid_hardware_Camera_IZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, bool, bool>) n_SetUpCamera_Landroid_hardware_Camera_IZZ);
			return cb_setUpCamera_Landroid_hardware_Camera_IZZ;
		}

		static void n_SetUpCamera_Landroid_hardware_Camera_IZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_camera, int degrees, bool flipHorizontal, bool flipVertical)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera camera = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_camera, JniHandleOwnership.DoNotTransfer);
			__this.SetUpCamera (camera, degrees, flipHorizontal, flipVertical);
		}
#pragma warning restore 0169

		static IntPtr id_setUpCamera_Landroid_hardware_Camera_IZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage']/method[@name='setUpCamera' and count(parameter)=4 and parameter[1][@type='android.hardware.Camera'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean']]"
		[Register ("setUpCamera", "(Landroid/hardware/Camera;IZZ)V", "GetSetUpCamera_Landroid_hardware_Camera_IZZHandler")]
		public virtual unsafe void SetUpCamera (global::Android.Hardware.Camera camera, int degrees, bool flipHorizontal, bool flipVertical)
		{
			if (id_setUpCamera_Landroid_hardware_Camera_IZZ == IntPtr.Zero)
				id_setUpCamera_Landroid_hardware_Camera_IZZ = JNIEnv.GetMethodID (class_ref, "setUpCamera", "(Landroid/hardware/Camera;IZZ)V");
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (camera);
				__args [1] = new JValue (degrees);
				__args [2] = new JValue (flipHorizontal);
				__args [3] = new JValue (flipVertical);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpCamera_Landroid_hardware_Camera_IZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpCamera", "(Landroid/hardware/Camera;IZZ)V"), __args);
			} finally {
			}
		}

	}
}
