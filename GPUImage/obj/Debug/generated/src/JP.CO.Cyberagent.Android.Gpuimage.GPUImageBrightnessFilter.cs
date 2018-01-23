using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBrightnessFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageBrightnessFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageBrightnessFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBrightnessFilter']/field[@name='BRIGHTNESS_FRAGMENT_SHADER']"
		[Register ("BRIGHTNESS_FRAGMENT_SHADER")]
		public const string BrightnessFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform lowp float brightness;\u000a \u000a void main()\u000a {\u000a     lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     \u000a     gl_FragColor = vec4((textureColor.rgb + vec3(brightness)), textureColor.w);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageBrightnessFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageBrightnessFilter); }
		}

		protected GPUImageBrightnessFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBrightnessFilter']/constructor[@name='GPUImageBrightnessFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageBrightnessFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageBrightnessFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBrightnessFilter']/constructor[@name='GPUImageBrightnessFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageBrightnessFilter (float brightness)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (brightness);
				if (((object) this).GetType () != typeof (GPUImageBrightnessFilter)) {
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

		static Delegate cb_setBrightness_F;
#pragma warning disable 0169
		static Delegate GetSetBrightness_FHandler ()
		{
			if (cb_setBrightness_F == null)
				cb_setBrightness_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBrightness_F);
			return cb_setBrightness_F;
		}

		static void n_SetBrightness_F (IntPtr jnienv, IntPtr native__this, float brightness)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBrightnessFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBrightnessFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBrightness (brightness);
		}
#pragma warning restore 0169

		static IntPtr id_setBrightness_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBrightnessFilter']/method[@name='setBrightness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBrightness", "(F)V", "GetSetBrightness_FHandler")]
		public virtual unsafe void SetBrightness (float brightness)
		{
			if (id_setBrightness_F == IntPtr.Zero)
				id_setBrightness_F = JNIEnv.GetMethodID (class_ref, "setBrightness", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (brightness);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBrightness_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBrightness", "(F)V"), __args);
			} finally {
			}
		}

	}
}
