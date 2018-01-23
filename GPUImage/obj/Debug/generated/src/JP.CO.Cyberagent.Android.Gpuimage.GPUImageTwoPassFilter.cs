using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageTwoPassFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageTwoPassFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageTwoPassFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageTwoPassFilter); }
		}

		protected GPUImageTwoPassFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassFilter']/constructor[@name='GPUImageTwoPassFilter' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GPUImageTwoPassFilter (string firstVertexShader, string firstFragmentShader, string secondVertexShader, string secondFragmentShader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_firstVertexShader = JNIEnv.NewString (firstVertexShader);
			IntPtr native_firstFragmentShader = JNIEnv.NewString (firstFragmentShader);
			IntPtr native_secondVertexShader = JNIEnv.NewString (secondVertexShader);
			IntPtr native_secondFragmentShader = JNIEnv.NewString (secondFragmentShader);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (native_firstVertexShader);
				__args [1] = new JValue (native_firstFragmentShader);
				__args [2] = new JValue (native_secondVertexShader);
				__args [3] = new JValue (native_secondFragmentShader);
				if (((object) this).GetType () != typeof (GPUImageTwoPassFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_firstVertexShader);
				JNIEnv.DeleteLocalRef (native_firstFragmentShader);
				JNIEnv.DeleteLocalRef (native_secondVertexShader);
				JNIEnv.DeleteLocalRef (native_secondFragmentShader);
			}
		}

	}
}
