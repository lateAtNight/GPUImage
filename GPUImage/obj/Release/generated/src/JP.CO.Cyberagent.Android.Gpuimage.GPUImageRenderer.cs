using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageRenderer", DoNotGenerateAcw=true)]
	public partial class GPUImageRenderer : global::Java.Lang.Object, global::Android.Hardware.Camera.IPreviewCallback, global::Android.Opengl.GLSurfaceView.IRenderer {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/field[@name='NO_IMAGE']"
		[Register ("NO_IMAGE")]
		public const int NoImage = (int) -1;

		static IntPtr mSurfaceChangedWaiter_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/field[@name='mSurfaceChangedWaiter']"
		[Register ("mSurfaceChangedWaiter")]
		public global::Java.Lang.Object MSurfaceChangedWaiter {
			get {
				if (mSurfaceChangedWaiter_jfieldId == IntPtr.Zero)
					mSurfaceChangedWaiter_jfieldId = JNIEnv.GetFieldID (class_ref, "mSurfaceChangedWaiter", "Ljava/lang/Object;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mSurfaceChangedWaiter_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mSurfaceChangedWaiter_jfieldId == IntPtr.Zero)
					mSurfaceChangedWaiter_jfieldId = JNIEnv.GetFieldID (class_ref, "mSurfaceChangedWaiter", "Ljava/lang/Object;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mSurfaceChangedWaiter_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageRenderer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageRenderer); }
		}

		protected GPUImageRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/constructor[@name='GPUImageRenderer' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImageFilter']]"
		[Register (".ctor", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V", "")]
		public unsafe GPUImageRenderer (global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter filter)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (filter);
				if (((object) this).GetType () != typeof (GPUImageRenderer)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V", __args);
					return;
				}

				if (id_ctor_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ == IntPtr.Zero)
					id_ctor_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljp/co/cyberagent/android/gpuimage/GPUImageFilter;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_, __args);
			} finally {
			}
		}

		static Delegate cb_getFrameHeight;
#pragma warning disable 0169
		static Delegate GetGetFrameHeightHandler ()
		{
			if (cb_getFrameHeight == null)
				cb_getFrameHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameHeight);
			return cb_getFrameHeight;
		}

		static int n_GetFrameHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameHeight;
		protected virtual unsafe int FrameHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='getFrameHeight' and count(parameter)=0]"
			[Register ("getFrameHeight", "()I", "GetGetFrameHeightHandler")]
			get {
				if (id_getFrameHeight == IntPtr.Zero)
					id_getFrameHeight = JNIEnv.GetMethodID (class_ref, "getFrameHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getFrameWidth;
#pragma warning disable 0169
		static Delegate GetGetFrameWidthHandler ()
		{
			if (cb_getFrameWidth == null)
				cb_getFrameWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameWidth);
			return cb_getFrameWidth;
		}

		static int n_GetFrameWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameWidth;
		protected virtual unsafe int FrameWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='getFrameWidth' and count(parameter)=0]"
			[Register ("getFrameWidth", "()I", "GetGetFrameWidthHandler")]
			get {
				if (id_getFrameWidth == IntPtr.Zero)
					id_getFrameWidth = JNIEnv.GetMethodID (class_ref, "getFrameWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFrameWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isFlippedHorizontally;
#pragma warning disable 0169
		static Delegate GetIsFlippedHorizontallyHandler ()
		{
			if (cb_isFlippedHorizontally == null)
				cb_isFlippedHorizontally = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFlippedHorizontally);
			return cb_isFlippedHorizontally;
		}

		static bool n_IsFlippedHorizontally (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFlippedHorizontally;
		}
#pragma warning restore 0169

		static IntPtr id_isFlippedHorizontally;
		public virtual unsafe bool IsFlippedHorizontally {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='isFlippedHorizontally' and count(parameter)=0]"
			[Register ("isFlippedHorizontally", "()Z", "GetIsFlippedHorizontallyHandler")]
			get {
				if (id_isFlippedHorizontally == IntPtr.Zero)
					id_isFlippedHorizontally = JNIEnv.GetMethodID (class_ref, "isFlippedHorizontally", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFlippedHorizontally);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFlippedHorizontally", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isFlippedVertically;
#pragma warning disable 0169
		static Delegate GetIsFlippedVerticallyHandler ()
		{
			if (cb_isFlippedVertically == null)
				cb_isFlippedVertically = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFlippedVertically);
			return cb_isFlippedVertically;
		}

		static bool n_IsFlippedVertically (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFlippedVertically;
		}
#pragma warning restore 0169

		static IntPtr id_isFlippedVertically;
		public virtual unsafe bool IsFlippedVertically {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='isFlippedVertically' and count(parameter)=0]"
			[Register ("isFlippedVertically", "()Z", "GetIsFlippedVerticallyHandler")]
			get {
				if (id_isFlippedVertically == IntPtr.Zero)
					id_isFlippedVertically = JNIEnv.GetMethodID (class_ref, "isFlippedVertically", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isFlippedVertically);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isFlippedVertically", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRotation;
#pragma warning disable 0169
		static Delegate GetGetRotationHandler ()
		{
			if (cb_getRotation == null)
				cb_getRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRotation);
			return cb_getRotation;
		}

		static IntPtr n_GetRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Rotation);
		}
#pragma warning restore 0169

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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.Rotation = rotation;
		}
#pragma warning restore 0169

		static IntPtr id_getRotation;
		static IntPtr id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_;
		public virtual unsafe global::JP.CO.Cyberagent.Android.Gpuimage.Rotation Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()Ljp/co/cyberagent/android/gpuimage/Rotation;", "GetGetRotationHandler")]
			get {
				if (id_getRotation == IntPtr.Zero)
					id_getRotation = JNIEnv.GetMethodID (class_ref, "getRotation", "()Ljp/co/cyberagent/android/gpuimage/Rotation;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRotation), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRotation", "()Ljp/co/cyberagent/android/gpuimage/Rotation;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation']]"
			[Register ("setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;)V", "GetSetRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_Handler")]
			set {
				if (id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ == IntPtr.Zero)
					id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ = JNIEnv.GetMethodID (class_ref, "setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;)V");
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (value);

					if (((object) this).GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;)V"), __args);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeleteImage ();
		}
#pragma warning restore 0169

		static IntPtr id_deleteImage;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='deleteImage' and count(parameter)=0]"
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

		static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
		static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
		{
			if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
				cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
			return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		}

		static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gl)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (gl);
		}
#pragma warning restore 0169

		static IntPtr id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 gl)
		{
			if (id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == IntPtr.Zero)
				id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNIEnv.GetMethodID (class_ref, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gl);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler ()
		{
			if (cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ == null)
				cb_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnPreviewFrame_arrayBLandroid_hardware_Camera_);
			return cb_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		}

		static void n_OnPreviewFrame_arrayBLandroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, IntPtr native_camera)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Android.Hardware.Camera camera = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_camera, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviewFrame (data, camera);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		static IntPtr id_onPreviewFrame_arrayBLandroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='onPreviewFrame' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='android.hardware.Camera']]"
		[Register ("onPreviewFrame", "([BLandroid/hardware/Camera;)V", "GetOnPreviewFrame_arrayBLandroid_hardware_Camera_Handler")]
		public virtual unsafe void OnPreviewFrame (byte[] data, global::Android.Hardware.Camera camera)
		{
			if (id_onPreviewFrame_arrayBLandroid_hardware_Camera_ == IntPtr.Zero)
				id_onPreviewFrame_arrayBLandroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "onPreviewFrame", "([BLandroid/hardware/Camera;)V");
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_data);
				__args [1] = new JValue (camera);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPreviewFrame_arrayBLandroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPreviewFrame", "([BLandroid/hardware/Camera;)V"), __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
		{
			if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
				cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int>) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
			return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		}

		static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_gl, int width, int height)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (gl, width, height);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 gl, int width, int height)
		{
			if (id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == IntPtr.Zero)
				id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNIEnv.GetMethodID (class_ref, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (gl);
				__args [1] = new JValue (width);
				__args [2] = new JValue (height);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
		{
			if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
				cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
			return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		}

		static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unused, IntPtr native_config)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Opengles.IGL10 unused = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_unused, JniHandleOwnership.DoNotTransfer);
			global::Javax.Microedition.Khronos.Egl.EGLConfig config = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (unused, config);
		}
#pragma warning restore 0169

		static IntPtr id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 unused, global::Javax.Microedition.Khronos.Egl.EGLConfig config)
		{
			if (id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == IntPtr.Zero)
				id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNIEnv.GetMethodID (class_ref, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (unused);
				__args [1] = new JValue (config);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_runOnDraw_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnDraw_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnDraw_Ljava_lang_Runnable_ == null)
				cb_runOnDraw_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunOnDraw_Ljava_lang_Runnable_);
			return cb_runOnDraw_Ljava_lang_Runnable_;
		}

		static void n_RunOnDraw_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.RunOnDraw (runnable);
		}
#pragma warning restore 0169

		static IntPtr id_runOnDraw_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='runOnDraw' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnDraw", "(Ljava/lang/Runnable;)V", "GetRunOnDraw_Ljava_lang_Runnable_Handler")]
		protected virtual unsafe void RunOnDraw (global::Java.Lang.IRunnable runnable)
		{
			if (id_runOnDraw_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnDraw_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnDraw", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (runnable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runOnDraw_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnDraw", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_runOnDrawEnd_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnDrawEnd_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnDrawEnd_Ljava_lang_Runnable_ == null)
				cb_runOnDrawEnd_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunOnDrawEnd_Ljava_lang_Runnable_);
			return cb_runOnDrawEnd_Ljava_lang_Runnable_;
		}

		static void n_RunOnDrawEnd_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.RunOnDrawEnd (runnable);
		}
#pragma warning restore 0169

		static IntPtr id_runOnDrawEnd_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='runOnDrawEnd' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnDrawEnd", "(Ljava/lang/Runnable;)V", "GetRunOnDrawEnd_Ljava_lang_Runnable_Handler")]
		protected virtual unsafe void RunOnDrawEnd (global::Java.Lang.IRunnable runnable)
		{
			if (id_runOnDrawEnd_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnDrawEnd_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnDrawEnd", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (runnable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runOnDrawEnd_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnDrawEnd", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter filter = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			__this.SetFilter (filter);
		}
#pragma warning restore 0169

		static IntPtr id_setFilter_Ljp_co_cyberagent_android_gpuimage_GPUImageFilter_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setFilter' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImageFilter']]"
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

		static Delegate cb_setImageBitmap_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		static Delegate GetSetImageBitmap_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setImageBitmap_Landroid_graphics_Bitmap_ == null)
				cb_setImageBitmap_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImageBitmap_Landroid_graphics_Bitmap_);
			return cb_setImageBitmap_Landroid_graphics_Bitmap_;
		}

		static void n_SetImageBitmap_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmap (bitmap);
		}
#pragma warning restore 0169

		static IntPtr id_setImageBitmap_Landroid_graphics_Bitmap_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setImageBitmap' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setImageBitmap", "(Landroid/graphics/Bitmap;)V", "GetSetImageBitmap_Landroid_graphics_Bitmap_Handler")]
		public virtual unsafe void SetImageBitmap (global::Android.Graphics.Bitmap bitmap)
		{
			if (id_setImageBitmap_Landroid_graphics_Bitmap_ == IntPtr.Zero)
				id_setImageBitmap_Landroid_graphics_Bitmap_ = JNIEnv.GetMethodID (class_ref, "setImageBitmap", "(Landroid/graphics/Bitmap;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (bitmap);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageBitmap_Landroid_graphics_Bitmap_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageBitmap", "(Landroid/graphics/Bitmap;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setImageBitmap_Landroid_graphics_Bitmap_Z;
#pragma warning disable 0169
		static Delegate GetSetImageBitmap_Landroid_graphics_Bitmap_ZHandler ()
		{
			if (cb_setImageBitmap_Landroid_graphics_Bitmap_Z == null)
				cb_setImageBitmap_Landroid_graphics_Bitmap_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_SetImageBitmap_Landroid_graphics_Bitmap_Z);
			return cb_setImageBitmap_Landroid_graphics_Bitmap_Z;
		}

		static void n_SetImageBitmap_Landroid_graphics_Bitmap_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, bool recycle)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetImageBitmap (bitmap, recycle);
		}
#pragma warning restore 0169

		static IntPtr id_setImageBitmap_Landroid_graphics_Bitmap_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setImageBitmap' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='boolean']]"
		[Register ("setImageBitmap", "(Landroid/graphics/Bitmap;Z)V", "GetSetImageBitmap_Landroid_graphics_Bitmap_ZHandler")]
		public virtual unsafe void SetImageBitmap (global::Android.Graphics.Bitmap bitmap, bool recycle)
		{
			if (id_setImageBitmap_Landroid_graphics_Bitmap_Z == IntPtr.Zero)
				id_setImageBitmap_Landroid_graphics_Bitmap_Z = JNIEnv.GetMethodID (class_ref, "setImageBitmap", "(Landroid/graphics/Bitmap;Z)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (bitmap);
				__args [1] = new JValue (recycle);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setImageBitmap_Landroid_graphics_Bitmap_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setImageBitmap", "(Landroid/graphics/Bitmap;Z)V"), __args);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (rotation, flipHorizontal, flipVertical);
		}
#pragma warning restore 0169

		static IntPtr id_setRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setRotation' and count(parameter)=3 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
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

		static Delegate cb_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
#pragma warning disable 0169
		static Delegate GetSetRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZHandler ()
		{
			if (cb_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ == null)
				cb_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool, bool>) n_SetRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ);
			return cb_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		}

		static void n_SetRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ (IntPtr jnienv, IntPtr native__this, IntPtr native_rotation, bool flipHorizontal, bool flipVertical)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (native_rotation, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationCamera (rotation, flipHorizontal, flipVertical);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setRotationCamera' and count(parameter)=3 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("setRotationCamera", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)V", "GetSetRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZHandler")]
		public virtual unsafe void SetRotationCamera (global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation, bool flipHorizontal, bool flipVertical)
		{
			if (id_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ == IntPtr.Zero)
				id_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ = JNIEnv.GetMethodID (class_ref, "setRotationCamera", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (rotation);
				__args [1] = new JValue (flipHorizontal);
				__args [2] = new JValue (flipVertical);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotationCamera_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationCamera", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)V"), __args);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType scaleType = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage.ScaleType> (native_scaleType, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleType (scaleType);
		}
#pragma warning restore 0169

		static IntPtr id_setScaleType_Ljp_co_cyberagent_android_gpuimage_GPUImage_ScaleType_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setScaleType' and count(parameter)=1 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.GPUImage.ScaleType']]"
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

		static Delegate cb_setUpSurfaceTexture_Landroid_hardware_Camera_;
#pragma warning disable 0169
		static Delegate GetSetUpSurfaceTexture_Landroid_hardware_Camera_Handler ()
		{
			if (cb_setUpSurfaceTexture_Landroid_hardware_Camera_ == null)
				cb_setUpSurfaceTexture_Landroid_hardware_Camera_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetUpSurfaceTexture_Landroid_hardware_Camera_);
			return cb_setUpSurfaceTexture_Landroid_hardware_Camera_;
		}

		static void n_SetUpSurfaceTexture_Landroid_hardware_Camera_ (IntPtr jnienv, IntPtr native__this, IntPtr native_camera)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Hardware.Camera camera = global::Java.Lang.Object.GetObject<global::Android.Hardware.Camera> (native_camera, JniHandleOwnership.DoNotTransfer);
			__this.SetUpSurfaceTexture (camera);
		}
#pragma warning restore 0169

		static IntPtr id_setUpSurfaceTexture_Landroid_hardware_Camera_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRenderer']/method[@name='setUpSurfaceTexture' and count(parameter)=1 and parameter[1][@type='android.hardware.Camera']]"
		[Register ("setUpSurfaceTexture", "(Landroid/hardware/Camera;)V", "GetSetUpSurfaceTexture_Landroid_hardware_Camera_Handler")]
		public virtual unsafe void SetUpSurfaceTexture (global::Android.Hardware.Camera camera)
		{
			if (id_setUpSurfaceTexture_Landroid_hardware_Camera_ == IntPtr.Zero)
				id_setUpSurfaceTexture_Landroid_hardware_Camera_ = JNIEnv.GetMethodID (class_ref, "setUpSurfaceTexture", "(Landroid/hardware/Camera;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (camera);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUpSurfaceTexture_Landroid_hardware_Camera_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUpSurfaceTexture", "(Landroid/hardware/Camera;)V"), __args);
			} finally {
			}
		}

	}
}
