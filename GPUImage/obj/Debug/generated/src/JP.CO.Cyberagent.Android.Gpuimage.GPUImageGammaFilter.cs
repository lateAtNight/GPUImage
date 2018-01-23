using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGammaFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageGammaFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageGammaFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGammaFilter']/field[@name='GAMMA_FRAGMENT_SHADER']"
		[Register ("GAMMA_FRAGMENT_SHADER")]
		public const string GammaFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform lowp float gamma;\u000a \u000a void main()\u000a {\u000a     lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     \u000a     gl_FragColor = vec4(pow(textureColor.rgb, vec3(gamma)), textureColor.w);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageGammaFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageGammaFilter); }
		}

		protected GPUImageGammaFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGammaFilter']/constructor[@name='GPUImageGammaFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageGammaFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageGammaFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGammaFilter']/constructor[@name='GPUImageGammaFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageGammaFilter (float gamma)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gamma);
				if (((object) this).GetType () != typeof (GPUImageGammaFilter)) {
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

		static Delegate cb_setGamma_F;
#pragma warning disable 0169
		static Delegate GetSetGamma_FHandler ()
		{
			if (cb_setGamma_F == null)
				cb_setGamma_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGamma_F);
			return cb_setGamma_F;
		}

		static void n_SetGamma_F (IntPtr jnienv, IntPtr native__this, float gamma)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageGammaFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageGammaFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGamma (gamma);
		}
#pragma warning restore 0169

		static IntPtr id_setGamma_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGammaFilter']/method[@name='setGamma' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setGamma", "(F)V", "GetSetGamma_FHandler")]
		public virtual unsafe void SetGamma (float gamma)
		{
			if (id_setGamma_F == IntPtr.Zero)
				id_setGamma_F = JNIEnv.GetMethodID (class_ref, "setGamma", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (gamma);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGamma_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGamma", "(F)V"), __args);
			} finally {
			}
		}

	}
}
