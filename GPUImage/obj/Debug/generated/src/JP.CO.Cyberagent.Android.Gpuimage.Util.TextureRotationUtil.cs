using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage.util']/class[@name='TextureRotationUtil']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/util/TextureRotationUtil", DoNotGenerateAcw=true)]
	public partial class TextureRotationUtil : global::Java.Lang.Object {


		static IntPtr TEXTURE_NO_ROTATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage.util']/class[@name='TextureRotationUtil']/field[@name='TEXTURE_NO_ROTATION']"
		[Register ("TEXTURE_NO_ROTATION")]
		public static IList<float> TextureNoRotation {
			get {
				if (TEXTURE_NO_ROTATION_jfieldId == IntPtr.Zero)
					TEXTURE_NO_ROTATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXTURE_NO_ROTATION", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, TEXTURE_NO_ROTATION_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXTURE_ROTATED_180_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage.util']/class[@name='TextureRotationUtil']/field[@name='TEXTURE_ROTATED_180']"
		[Register ("TEXTURE_ROTATED_180")]
		public static IList<float> TextureRotated180 {
			get {
				if (TEXTURE_ROTATED_180_jfieldId == IntPtr.Zero)
					TEXTURE_ROTATED_180_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXTURE_ROTATED_180", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, TEXTURE_ROTATED_180_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXTURE_ROTATED_270_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage.util']/class[@name='TextureRotationUtil']/field[@name='TEXTURE_ROTATED_270']"
		[Register ("TEXTURE_ROTATED_270")]
		public static IList<float> TextureRotated270 {
			get {
				if (TEXTURE_ROTATED_270_jfieldId == IntPtr.Zero)
					TEXTURE_ROTATED_270_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXTURE_ROTATED_270", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, TEXTURE_ROTATED_270_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr TEXTURE_ROTATED_90_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage.util']/class[@name='TextureRotationUtil']/field[@name='TEXTURE_ROTATED_90']"
		[Register ("TEXTURE_ROTATED_90")]
		public static IList<float> TextureRotated90 {
			get {
				if (TEXTURE_ROTATED_90_jfieldId == IntPtr.Zero)
					TEXTURE_ROTATED_90_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TEXTURE_ROTATED_90", "[F");
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (JNIEnv.GetStaticObjectField (class_ref, TEXTURE_ROTATED_90_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/util/TextureRotationUtil", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (TextureRotationUtil); }
		}

		protected TextureRotationUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage.util']/class[@name='TextureRotationUtil']/method[@name='getRotation' and count(parameter)=3 and parameter[1][@type='jp.co.cyberagent.android.gpuimage.Rotation'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("getRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)[F", "")]
		public static unsafe float[] GetRotation (global::JP.CO.Cyberagent.Android.Gpuimage.Rotation rotation, bool flipHorizontal, bool flipVertical)
		{
			if (id_getRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ == IntPtr.Zero)
				id_getRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ = JNIEnv.GetStaticMethodID (class_ref, "getRotation", "(Ljp/co/cyberagent/android/gpuimage/Rotation;ZZ)[F");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (rotation);
				__args [1] = new JValue (flipHorizontal);
				__args [2] = new JValue (flipVertical);
				float[] __ret = (float[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_getRotation_Ljp_co_cyberagent_android_gpuimage_Rotation_ZZ, __args), JniHandleOwnership.TransferLocalRef, typeof (float));
				return __ret;
			} finally {
			}
		}

	}
}
