using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageExposureFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageExposureFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageExposureFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageExposureFilter']/field[@name='EXPOSURE_FRAGMENT_SHADER']"
		[Register ("EXPOSURE_FRAGMENT_SHADER")]
		public const string ExposureFragmentShader = (string) " varying highp vec2 textureCoordinate;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform highp float exposure;\u000a \u000a void main()\u000a {\u000a     highp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     \u000a     gl_FragColor = vec4(textureColor.rgb * pow(2.0, exposure), textureColor.w);\u000a } ";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageExposureFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageExposureFilter); }
		}

		protected GPUImageExposureFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageExposureFilter']/constructor[@name='GPUImageExposureFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageExposureFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageExposureFilter)) {
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

		static IntPtr id_ctor_F;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageExposureFilter']/constructor[@name='GPUImageExposureFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageExposureFilter (float exposure)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exposure);
				if (((object) this).GetType () != typeof (GPUImageExposureFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F)V", __args);
					return;
				}

				if (id_ctor_F == IntPtr.Zero)
					id_ctor_F = JNIEnv.GetMethodID (class_ref, "<init>", "(F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_F, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_F, __args);
			} finally {
			}
		}

		static Delegate cb_setExposure_F;
#pragma warning disable 0169
		static Delegate GetSetExposure_FHandler ()
		{
			if (cb_setExposure_F == null)
				cb_setExposure_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetExposure_F);
			return cb_setExposure_F;
		}

		static void n_SetExposure_F (IntPtr jnienv, IntPtr native__this, float exposure)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageExposureFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageExposureFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExposure (exposure);
		}
#pragma warning restore 0169

		static IntPtr id_setExposure_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageExposureFilter']/method[@name='setExposure' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setExposure", "(F)V", "GetSetExposure_FHandler")]
		public virtual unsafe void SetExposure (float exposure)
		{
			if (id_setExposure_F == IntPtr.Zero)
				id_setExposure_F = JNIEnv.GetMethodID (class_ref, "setExposure", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (exposure);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setExposure_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setExposure", "(F)V"), __args);
			} finally {
			}
		}

	}
}
