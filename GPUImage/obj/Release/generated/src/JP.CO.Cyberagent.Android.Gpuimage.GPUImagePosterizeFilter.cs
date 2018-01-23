using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePosterizeFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImagePosterizeFilter", DoNotGenerateAcw=true)]
	public partial class GPUImagePosterizeFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePosterizeFilter']/field[@name='POSTERIZE_FRAGMENT_SHADER']"
		[Register ("POSTERIZE_FRAGMENT_SHADER")]
		public const string PosterizeFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000auniform highp float colorLevels;\u000a\u000avoid main()\u000a{\u000a   highp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a   \u000a   gl_FragColor = floor((textureColor * colorLevels) + vec4(0.5)) / colorLevels;\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImagePosterizeFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImagePosterizeFilter); }
		}

		protected GPUImagePosterizeFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePosterizeFilter']/constructor[@name='GPUImagePosterizeFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImagePosterizeFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImagePosterizeFilter)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePosterizeFilter']/constructor[@name='GPUImagePosterizeFilter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe GPUImagePosterizeFilter (int colorLevels)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (colorLevels);
				if (((object) this).GetType () != typeof (GPUImagePosterizeFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_setColorLevels_I;
#pragma warning disable 0169
		static Delegate GetSetColorLevels_IHandler ()
		{
			if (cb_setColorLevels_I == null)
				cb_setColorLevels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColorLevels_I);
			return cb_setColorLevels_I;
		}

		static void n_SetColorLevels_I (IntPtr jnienv, IntPtr native__this, int colorLevels)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImagePosterizeFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImagePosterizeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorLevels (colorLevels);
		}
#pragma warning restore 0169

		static IntPtr id_setColorLevels_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePosterizeFilter']/method[@name='setColorLevels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setColorLevels", "(I)V", "GetSetColorLevels_IHandler")]
		public virtual unsafe void SetColorLevels (int colorLevels)
		{
			if (id_setColorLevels_I == IntPtr.Zero)
				id_setColorLevels_I = JNIEnv.GetMethodID (class_ref, "setColorLevels", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (colorLevels);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorLevels_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorLevels", "(I)V"), __args);
			} finally {
			}
		}

	}
}
