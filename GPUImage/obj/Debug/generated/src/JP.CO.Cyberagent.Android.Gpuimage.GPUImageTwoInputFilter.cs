using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageTwoInputFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageTwoInputFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		static IntPtr mFilterInputTextureUniform2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/field[@name='mFilterInputTextureUniform2']"
		[Register ("mFilterInputTextureUniform2")]
		public int MFilterInputTextureUniform2 {
			get {
				if (mFilterInputTextureUniform2_jfieldId == IntPtr.Zero)
					mFilterInputTextureUniform2_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilterInputTextureUniform2", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFilterInputTextureUniform2_jfieldId);
			}
			set {
				if (mFilterInputTextureUniform2_jfieldId == IntPtr.Zero)
					mFilterInputTextureUniform2_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilterInputTextureUniform2", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFilterInputTextureUniform2_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFilterSecondTextureCoordinateAttribute_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/field[@name='mFilterSecondTextureCoordinateAttribute']"
		[Register ("mFilterSecondTextureCoordinateAttribute")]
		public int MFilterSecondTextureCoordinateAttribute {
			get {
				if (mFilterSecondTextureCoordinateAttribute_jfieldId == IntPtr.Zero)
					mFilterSecondTextureCoordinateAttribute_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilterSecondTextureCoordinateAttribute", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFilterSecondTextureCoordinateAttribute_jfieldId);
			}
			set {
				if (mFilterSecondTextureCoordinateAttribute_jfieldId == IntPtr.Zero)
					mFilterSecondTextureCoordinateAttribute_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilterSecondTextureCoordinateAttribute", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFilterSecondTextureCoordinateAttribute_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mFilterSourceTexture2_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/field[@name='mFilterSourceTexture2']"
		[Register ("mFilterSourceTexture2")]
		public int MFilterSourceTexture2 {
			get {
				if (mFilterSourceTexture2_jfieldId == IntPtr.Zero)
					mFilterSourceTexture2_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilterSourceTexture2", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mFilterSourceTexture2_jfieldId);
			}
			set {
				if (mFilterSourceTexture2_jfieldId == IntPtr.Zero)
					mFilterSourceTexture2_jfieldId = JNIEnv.GetFieldID (class_ref, "mFilterSourceTexture2", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mFilterSourceTexture2_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageTwoInputFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageTwoInputFilter); }
		}

		protected GPUImageTwoInputFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/constructor[@name='GPUImageTwoInputFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GPUImageTwoInputFilter (string fragmentShader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_fragmentShader);
				if (((object) this).GetType () != typeof (GPUImageTwoInputFilter)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/constructor[@name='GPUImageTwoInputFilter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GPUImageTwoInputFilter (string vertexShader, string fragmentShader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vertexShader = JNIEnv.NewString (vertexShader);
			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_vertexShader);
				__args [1] = new JValue (native_fragmentShader);
				if (((object) this).GetType () != typeof (GPUImageTwoInputFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_vertexShader);
				JNIEnv.DeleteLocalRef (native_fragmentShader);
			}
		}

		static Delegate cb_getBitmap;
#pragma warning disable 0169
		static Delegate GetGetBitmapHandler ()
		{
			if (cb_getBitmap == null)
				cb_getBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmap);
			return cb_getBitmap;
		}

		static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		static Delegate cb_setBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmap_Landroid_graphics_Bitmap_);
			return cb_setBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.Bitmap = bitmap;
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap;
		static IntPtr id_setBitmap_Landroid_graphics_Bitmap_;
		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/method[@name='getBitmap' and count(parameter)=0]"
			[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
			get {
				if (id_getBitmap == IntPtr.Zero)
					id_getBitmap = JNIEnv.GetMethodID (class_ref, "getBitmap", "()Landroid/graphics/Bitmap;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBitmap), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/method[@name='setBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
			[Register ("setBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetBitmap_Landroid_graphics_Bitmap_Handler")]
			set {
				if (id_setBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
					id_setBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setBitmap", "(Landroid/graphics/Bitmap;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBitmap_Landroid_graphics_Bitmap_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
				} finally {
				}
			}
		}

		static Delegate cb_recycleBitmap;
#pragma warning disable 0169
		static Delegate GetRecycleBitmapHandler ()
		{
			if (cb_recycleBitmap == null)
				cb_recycleBitmap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecycleBitmap);
			return cb_recycleBitmap;
		}

		static void n_RecycleBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecycleBitmap ();
		}
#pragma warning restore 0169

		static IntPtr id_recycleBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/method[@name='recycleBitmap' and count(parameter)=0]"
		[Register ("recycleBitmap", "()V", "GetRecycleBitmapHandler")]
		public virtual unsafe void RecycleBitmap ()
		{
			if (id_recycleBitmap == IntPtr.Zero)
				id_recycleBitmap = JNIEnv.GetMethodID (class_ref, "recycleBitmap", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_recycleBitmap);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "recycleBitmap", "()V"));
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (rotation, flipHorizontal, flipVertical);
		}
#pragma warning restore 0169

		static IntPtr id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoInputFilter']/method[@name='setRotation' and count(parameter)=3 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
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

	}
}
