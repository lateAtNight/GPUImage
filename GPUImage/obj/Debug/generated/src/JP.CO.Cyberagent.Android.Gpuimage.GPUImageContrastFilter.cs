using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageContrastFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageContrastFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageContrastFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageContrastFilter']/field[@name='CONTRAST_FRAGMENT_SHADER']"
		[Register ("CONTRAST_FRAGMENT_SHADER")]
		public const string ContrastFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform lowp float contrast;\u000a \u000a void main()\u000a {\u000a     lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     \u000a     gl_FragColor = vec4(((textureColor.rgb - vec3(0.5)) * contrast + vec3(0.5)), textureColor.w);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageContrastFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageContrastFilter); }
		}

		protected GPUImageContrastFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageContrastFilter']/constructor[@name='GPUImageContrastFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageContrastFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageContrastFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageContrastFilter']/constructor[@name='GPUImageContrastFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageContrastFilter (float contrast)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (contrast);
				if (((object) this).GetType () != typeof (GPUImageContrastFilter)) {
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

		static Delegate cb_setContrast_F;
#pragma warning disable 0169
		static Delegate GetSetContrast_FHandler ()
		{
			if (cb_setContrast_F == null)
				cb_setContrast_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetContrast_F);
			return cb_setContrast_F;
		}

		static void n_SetContrast_F (IntPtr jnienv, IntPtr native__this, float contrast)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageContrastFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageContrastFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetContrast (contrast);
		}
#pragma warning restore 0169

		static IntPtr id_setContrast_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageContrastFilter']/method[@name='setContrast' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setContrast", "(F)V", "GetSetContrast_FHandler")]
		public virtual unsafe void SetContrast (float contrast)
		{
			if (id_setContrast_F == IntPtr.Zero)
				id_setContrast_F = JNIEnv.GetMethodID (class_ref, "setContrast", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (contrast);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setContrast_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setContrast", "(F)V"), __args);
			} finally {
			}
		}

	}
}
