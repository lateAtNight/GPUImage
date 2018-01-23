using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSaturationFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageSaturationFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageSaturationFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSaturationFilter']/field[@name='SATURATION_FRAGMENT_SHADER']"
		[Register ("SATURATION_FRAGMENT_SHADER")]
		public const string SaturationFragmentShader = (string) " varying highp vec2 textureCoordinate;\u000a \u000a uniform sampler2D inputImageTexture;\u000a uniform lowp float saturation;\u000a \u000a // Values from \"Graphics Shaders: Theory and Practice\" by Bailey and Cunningham\u000a const mediump vec3 luminanceWeighting = vec3(0.2125, 0.7154, 0.0721);\u000a \u000a void main()\u000a {\u000a    lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a    lowp float luminance = dot(textureColor.rgb, luminanceWeighting);\u000a    lowp vec3 greyScaleColor = vec3(luminance);\u000a    \u000a    gl_FragColor = vec4(mix(greyScaleColor, textureColor.rgb, saturation), textureColor.w);\u000a     \u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageSaturationFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageSaturationFilter); }
		}

		protected GPUImageSaturationFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSaturationFilter']/constructor[@name='GPUImageSaturationFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageSaturationFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageSaturationFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSaturationFilter']/constructor[@name='GPUImageSaturationFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageSaturationFilter (float saturation)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (saturation);
				if (((object) this).GetType () != typeof (GPUImageSaturationFilter)) {
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

		static Delegate cb_setSaturation_F;
#pragma warning disable 0169
		static Delegate GetSetSaturation_FHandler ()
		{
			if (cb_setSaturation_F == null)
				cb_setSaturation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSaturation_F);
			return cb_setSaturation_F;
		}

		static void n_SetSaturation_F (IntPtr jnienv, IntPtr native__this, float saturation)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSaturationFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSaturationFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSaturation (saturation);
		}
#pragma warning restore 0169

		static IntPtr id_setSaturation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSaturationFilter']/method[@name='setSaturation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSaturation", "(F)V", "GetSetSaturation_FHandler")]
		public virtual unsafe void SetSaturation (float saturation)
		{
			if (id_setSaturation_F == IntPtr.Zero)
				id_setSaturation_F = JNIEnv.GetMethodID (class_ref, "setSaturation", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (saturation);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSaturation_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSaturation", "(F)V"), __args);
			} finally {
			}
		}

	}
}
