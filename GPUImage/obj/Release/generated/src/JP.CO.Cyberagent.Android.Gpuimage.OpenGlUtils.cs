using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/OpenGlUtils", DoNotGenerateAcw=true)]
	public partial class OpenGlUtils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/field[@name='NO_TEXTURE']"
		[Register ("NO_TEXTURE")]
		public const int NoTexture = (int) -1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/OpenGlUtils", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (OpenGlUtils); }
		}

		protected OpenGlUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/constructor[@name='OpenGlUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OpenGlUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (OpenGlUtils)) {
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

		static IntPtr id_loadProgram_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='loadProgram' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("loadProgram", "(Ljava/lang/String;Ljava/lang/String;)I", "")]
		public static unsafe int LoadProgram (string strVSource, string strFSource)
		{
			if (id_loadProgram_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_loadProgram_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "loadProgram", "(Ljava/lang/String;Ljava/lang/String;)I");
			IntPtr native_strVSource = JNIEnv.NewString (strVSource);
			IntPtr native_strFSource = JNIEnv.NewString (strFSource);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_strVSource);
				__args [1] = new JValue (native_strFSource);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_loadProgram_Ljava_lang_String_Ljava_lang_String_, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_strVSource);
				JNIEnv.DeleteLocalRef (native_strFSource);
			}
		}

		static IntPtr id_loadShader_Ljava_lang_String_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='loadShader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("loadShader", "(Ljava/lang/String;I)I", "")]
		public static unsafe int LoadShader (string strSource, int iType)
		{
			if (id_loadShader_Ljava_lang_String_I == IntPtr.Zero)
				id_loadShader_Ljava_lang_String_I = JNIEnv.GetStaticMethodID (class_ref, "loadShader", "(Ljava/lang/String;I)I");
			IntPtr native_strSource = JNIEnv.NewString (strSource);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_strSource);
				__args [1] = new JValue (iType);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_loadShader_Ljava_lang_String_I, __args);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_strSource);
			}
		}

		static IntPtr id_loadTexture_Landroid_graphics_Bitmap_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='loadTexture' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int']]"
		[Register ("loadTexture", "(Landroid/graphics/Bitmap;I)I", "")]
		public static unsafe int LoadTexture (global::Android.Graphics.Bitmap img, int usedTexId)
		{
			if (id_loadTexture_Landroid_graphics_Bitmap_I == IntPtr.Zero)
				id_loadTexture_Landroid_graphics_Bitmap_I = JNIEnv.GetStaticMethodID (class_ref, "loadTexture", "(Landroid/graphics/Bitmap;I)I");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (img);
				__args [1] = new JValue (usedTexId);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_loadTexture_Landroid_graphics_Bitmap_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadTexture_Landroid_graphics_Bitmap_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='loadTexture' and count(parameter)=3 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("loadTexture", "(Landroid/graphics/Bitmap;IZ)I", "")]
		public static unsafe int LoadTexture (global::Android.Graphics.Bitmap img, int usedTexId, bool recycle)
		{
			if (id_loadTexture_Landroid_graphics_Bitmap_IZ == IntPtr.Zero)
				id_loadTexture_Landroid_graphics_Bitmap_IZ = JNIEnv.GetStaticMethodID (class_ref, "loadTexture", "(Landroid/graphics/Bitmap;IZ)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (img);
				__args [1] = new JValue (usedTexId);
				__args [2] = new JValue (recycle);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_loadTexture_Landroid_graphics_Bitmap_IZ, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadTexture_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='loadTexture' and count(parameter)=3 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='android.hardware.Camera.Size'] and parameter[3][@type='int']]"
		[Register ("loadTexture", "(Ljava/nio/IntBuffer;Landroid/hardware/Camera$Size;I)I", "")]
		public static unsafe int LoadTexture (global::Java.Nio.IntBuffer data, global::Android.Hardware.Camera.Size size, int usedTexId)
		{
			if (id_loadTexture_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I == IntPtr.Zero)
				id_loadTexture_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I = JNIEnv.GetStaticMethodID (class_ref, "loadTexture", "(Ljava/nio/IntBuffer;Landroid/hardware/Camera$Size;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (data);
				__args [1] = new JValue (size);
				__args [2] = new JValue (usedTexId);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_loadTexture_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_loadTextureAsBitmap_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='loadTextureAsBitmap' and count(parameter)=3 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='android.hardware.Camera.Size'] and parameter[3][@type='int']]"
		[Register ("loadTextureAsBitmap", "(Ljava/nio/IntBuffer;Landroid/hardware/Camera$Size;I)I", "")]
		public static unsafe int LoadTextureAsBitmap (global::Java.Nio.IntBuffer data, global::Android.Hardware.Camera.Size size, int usedTexId)
		{
			if (id_loadTextureAsBitmap_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I == IntPtr.Zero)
				id_loadTextureAsBitmap_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I = JNIEnv.GetStaticMethodID (class_ref, "loadTextureAsBitmap", "(Ljava/nio/IntBuffer;Landroid/hardware/Camera$Size;I)I");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (data);
				__args [1] = new JValue (size);
				__args [2] = new JValue (usedTexId);
				int __ret = JNIEnv.CallStaticIntMethod  (class_ref, id_loadTextureAsBitmap_Ljava_nio_IntBuffer_Landroid_hardware_Camera_Size_I, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_rnd_FF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='OpenGlUtils']/method[@name='rnd' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("rnd", "(FF)F", "")]
		public static unsafe float Rnd (float min, float max)
		{
			if (id_rnd_FF == IntPtr.Zero)
				id_rnd_FF = JNIEnv.GetStaticMethodID (class_ref, "rnd", "(FF)F");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (min);
				__args [1] = new JValue (max);
				return JNIEnv.CallStaticFloatMethod  (class_ref, id_rnd_FF, __args);
			} finally {
			}
		}

	}
}
