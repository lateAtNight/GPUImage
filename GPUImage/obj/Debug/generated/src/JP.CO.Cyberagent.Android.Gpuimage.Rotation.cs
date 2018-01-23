using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/Rotation", DoNotGenerateAcw=true)]
	public sealed partial class Rotation : global::Java.Lang.Enum {


		static IntPtr NORMAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/field[@name='NORMAL']"
		[Register ("NORMAL")]
		public static global::JP.CO.Cyberagent.Android.Gpuimage.Rotation Normal {
			get {
				if (NORMAL_jfieldId == IntPtr.Zero)
					NORMAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NORMAL", "Ljp/co/cyberagent/android/gpuimage/Rotation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NORMAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ROTATION_180_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/field[@name='ROTATION_180']"
		[Register ("ROTATION_180")]
		public static global::JP.CO.Cyberagent.Android.Gpuimage.Rotation Rotation180 {
			get {
				if (ROTATION_180_jfieldId == IntPtr.Zero)
					ROTATION_180_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROTATION_180", "Ljp/co/cyberagent/android/gpuimage/Rotation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROTATION_180_jfieldId);
				return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ROTATION_270_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/field[@name='ROTATION_270']"
		[Register ("ROTATION_270")]
		public static global::JP.CO.Cyberagent.Android.Gpuimage.Rotation Rotation270 {
			get {
				if (ROTATION_270_jfieldId == IntPtr.Zero)
					ROTATION_270_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROTATION_270", "Ljp/co/cyberagent/android/gpuimage/Rotation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROTATION_270_jfieldId);
				return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ROTATION_90_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/field[@name='ROTATION_90']"
		[Register ("ROTATION_90")]
		public static global::JP.CO.Cyberagent.Android.Gpuimage.Rotation Rotation90 {
			get {
				if (ROTATION_90_jfieldId == IntPtr.Zero)
					ROTATION_90_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ROTATION_90", "Ljp/co/cyberagent/android/gpuimage/Rotation;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ROTATION_90_jfieldId);
				return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/Rotation", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Rotation); }
		}

		internal Rotation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_asInt;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/method[@name='asInt' and count(parameter)=0]"
		[Register ("asInt", "()I", "")]
		public unsafe int AsInt ()
		{
			if (id_asInt == IntPtr.Zero)
				id_asInt = JNIEnv.GetMethodID (class_ref, "asInt", "()I");
			try {
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_asInt);
			} finally {
			}
		}

		static IntPtr id_fromInt_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/method[@name='fromInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromInt", "(I)Ljp/co/cyberagent/android/gpuimage/Rotation;", "")]
		public static unsafe global::JP.CO.Cyberagent.Android.Gpuimage.Rotation FromInt (int rotation)
		{
			if (id_fromInt_I == IntPtr.Zero)
				id_fromInt_I = JNIEnv.GetStaticMethodID (class_ref, "fromInt", "(I)Ljp/co/cyberagent/android/gpuimage/Rotation;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (rotation);
				return global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_fromInt_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Ljp/co/cyberagent/android/gpuimage/Rotation;", "")]
		public static unsafe global::JP.CO.Cyberagent.Android.Gpuimage.Rotation ValueOf (string name)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Ljp/co/cyberagent/android/gpuimage/Rotation;");
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_name);
				global::JP.CO.Cyberagent.Android.Gpuimage.Rotation __ret = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.Rotation> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='Rotation']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Ljp/co/cyberagent/android/gpuimage/Rotation;", "")]
		public static unsafe global::JP.CO.Cyberagent.Android.Gpuimage.Rotation[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Ljp/co/cyberagent/android/gpuimage/Rotation;");
			try {
				return (global::JP.CO.Cyberagent.Android.Gpuimage.Rotation[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::JP.CO.Cyberagent.Android.Gpuimage.Rotation));
			} finally {
			}
		}

	}
}
