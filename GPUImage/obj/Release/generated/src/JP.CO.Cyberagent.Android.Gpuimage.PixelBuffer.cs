using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='PixelBuffer']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/PixelBuffer", DoNotGenerateAcw=true)]
	public partial class PixelBuffer : global::Java.Lang.Object {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/PixelBuffer", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PixelBuffer); }
		}

		protected PixelBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_II;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='PixelBuffer']/constructor[@name='PixelBuffer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe PixelBuffer (int width, int height)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (width);
				__args [1] = new JValue (height);
				if (((object) this).GetType () != typeof (PixelBuffer)) {
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
			global::JP.CO.Cyberagent.Android.Gpuimage.PixelBuffer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.PixelBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Bitmap);
		}
#pragma warning restore 0169

		static IntPtr id_getBitmap;
		public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='PixelBuffer']/method[@name='getBitmap' and count(parameter)=0]"
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
		}

		static Delegate cb_destroy;
#pragma warning disable 0169
		static Delegate GetDestroyHandler ()
		{
			if (cb_destroy == null)
				cb_destroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Destroy);
			return cb_destroy;
		}

		static void n_Destroy (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.PixelBuffer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.PixelBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Destroy ();
		}
#pragma warning restore 0169

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='PixelBuffer']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "GetDestroyHandler")]
		public virtual unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "destroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_;
#pragma warning disable 0169
		static Delegate GetSetRenderer_Landroid_opengl_GLSurfaceView_Renderer_Handler ()
		{
			if (cb_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_ == null)
				cb_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRenderer_Landroid_opengl_GLSurfaceView_Renderer_);
			return cb_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_;
		}

		static void n_SetRenderer_Landroid_opengl_GLSurfaceView_Renderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renderer)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.PixelBuffer __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.PixelBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Opengl.GLSurfaceView.IRenderer renderer = (global::Android.Opengl.GLSurfaceView.IRenderer)global::Java.Lang.Object.GetObject<global::Android.Opengl.GLSurfaceView.IRenderer> (native_renderer, JniHandleOwnership.DoNotTransfer);
			__this.SetRenderer (renderer);
		}
#pragma warning restore 0169

		static IntPtr id_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='PixelBuffer']/method[@name='setRenderer' and count(parameter)=1 and parameter[1][@type='android.opengl.GLSurfaceView.Renderer']]"
		[Register ("setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V", "GetSetRenderer_Landroid_opengl_GLSurfaceView_Renderer_Handler")]
		public virtual unsafe void SetRenderer (global::Android.Opengl.GLSurfaceView.IRenderer renderer)
		{
			if (id_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_ == IntPtr.Zero)
				id_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_ = JNIEnv.GetMethodID (class_ref, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (renderer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRenderer_Landroid_opengl_GLSurfaceView_Renderer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRenderer", "(Landroid/opengl/GLSurfaceView$Renderer;)V"), __args);
			} finally {
			}
		}

	}
}
