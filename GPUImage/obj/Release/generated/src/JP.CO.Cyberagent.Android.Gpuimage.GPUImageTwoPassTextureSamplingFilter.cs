using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassTextureSamplingFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageTwoPassTextureSamplingFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageTwoPassTextureSamplingFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassFilter {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageTwoPassTextureSamplingFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageTwoPassTextureSamplingFilter); }
		}

		protected GPUImageTwoPassTextureSamplingFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassTextureSamplingFilter']/constructor[@name='GPUImageTwoPassTextureSamplingFilter' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GPUImageTwoPassTextureSamplingFilter (string firstVertexShader, string firstFragmentShader, string secondVertexShader, string secondFragmentShader)
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
				if (((object) this).GetType () != typeof (GPUImageTwoPassTextureSamplingFilter)) {
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

		static Delegate cb_getHorizontalTexelOffsetRatio;
#pragma warning disable 0169
		static Delegate GetGetHorizontalTexelOffsetRatioHandler ()
		{
			if (cb_getHorizontalTexelOffsetRatio == null)
				cb_getHorizontalTexelOffsetRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHorizontalTexelOffsetRatio);
			return cb_getHorizontalTexelOffsetRatio;
		}

		static float n_GetHorizontalTexelOffsetRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HorizontalTexelOffsetRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getHorizontalTexelOffsetRatio;
		public virtual unsafe float HorizontalTexelOffsetRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassTextureSamplingFilter']/method[@name='getHorizontalTexelOffsetRatio' and count(parameter)=0]"
			[Register ("getHorizontalTexelOffsetRatio", "()F", "GetGetHorizontalTexelOffsetRatioHandler")]
			get {
				if (id_getHorizontalTexelOffsetRatio == IntPtr.Zero)
					id_getHorizontalTexelOffsetRatio = JNIEnv.GetMethodID (class_ref, "getHorizontalTexelOffsetRatio", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getHorizontalTexelOffsetRatio);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHorizontalTexelOffsetRatio", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_getVerticalTexelOffsetRatio;
#pragma warning disable 0169
		static Delegate GetGetVerticalTexelOffsetRatioHandler ()
		{
			if (cb_getVerticalTexelOffsetRatio == null)
				cb_getVerticalTexelOffsetRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetVerticalTexelOffsetRatio);
			return cb_getVerticalTexelOffsetRatio;
		}

		static float n_GetVerticalTexelOffsetRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VerticalTexelOffsetRatio;
		}
#pragma warning restore 0169

		static IntPtr id_getVerticalTexelOffsetRatio;
		public virtual unsafe float VerticalTexelOffsetRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassTextureSamplingFilter']/method[@name='getVerticalTexelOffsetRatio' and count(parameter)=0]"
			[Register ("getVerticalTexelOffsetRatio", "()F", "GetGetVerticalTexelOffsetRatioHandler")]
			get {
				if (id_getVerticalTexelOffsetRatio == IntPtr.Zero)
					id_getVerticalTexelOffsetRatio = JNIEnv.GetMethodID (class_ref, "getVerticalTexelOffsetRatio", "()F");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getVerticalTexelOffsetRatio);
					else
						return JNIEnv.CallNonvirtualFloatMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVerticalTexelOffsetRatio", "()F"));
				} finally {
				}
			}
		}

		static Delegate cb_initTexelOffsets;
#pragma warning disable 0169
		static Delegate GetInitTexelOffsetsHandler ()
		{
			if (cb_initTexelOffsets == null)
				cb_initTexelOffsets = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitTexelOffsets);
			return cb_initTexelOffsets;
		}

		static void n_InitTexelOffsets (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitTexelOffsets ();
		}
#pragma warning restore 0169

		static IntPtr id_initTexelOffsets;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageTwoPassTextureSamplingFilter']/method[@name='initTexelOffsets' and count(parameter)=0]"
		[Register ("initTexelOffsets", "()V", "GetInitTexelOffsetsHandler")]
		protected virtual unsafe void InitTexelOffsets ()
		{
			if (id_initTexelOffsets == IntPtr.Zero)
				id_initTexelOffsets = JNIEnv.GetMethodID (class_ref, "initTexelOffsets", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initTexelOffsets);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "initTexelOffsets", "()V"));
			} finally {
			}
		}

	}
}
