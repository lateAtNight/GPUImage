using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageHueFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageHueFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueFilter']/field[@name='HUE_FRAGMENT_SHADER']"
		[Register ("HUE_FRAGMENT_SHADER")]
		public const string HueFragmentShader = (string) "precision highp float;\u000avarying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000auniform mediump float hueAdjust;\u000aconst highp vec4 kRGBToYPrime = vec4 (0.299, 0.587, 0.114, 0.0);\u000aconst highp vec4 kRGBToI = vec4 (0.595716, -0.274453, -0.321263, 0.0);\u000aconst highp vec4 kRGBToQ = vec4 (0.211456, -0.522591, 0.31135, 0.0);\u000a\u000aconst highp vec4 kYIQToR = vec4 (1.0, 0.9563, 0.6210, 0.0);\u000aconst highp vec4 kYIQToG = vec4 (1.0, -0.2721, -0.6474, 0.0);\u000aconst highp vec4 kYIQToB = vec4 (1.0, -1.1070, 1.7046, 0.0);\u000a\u000avoid main ()\u000a{\u000a    // Sample the input pixel\u000a    highp vec4 color = texture2D(inputImageTexture, textureCoordinate);\u000a\u000a    // Convert to YIQ\u000a    highp float YPrime = dot (color, kRGBToYPrime);\u000a    highp float I = dot (color, kRGBToI);\u000a    highp float Q = dot (color, kRGBToQ);\u000a\u000a    // Calculate the hue and chroma\u000a    highp float hue = atan (Q, I);\u000a    highp float chroma = sqrt (I * I + Q * Q);\u000a\u000a    // Make the user's adjustments\u000a    hue += (-hueAdjust); //why negative rotation?\u000a\u000a    // Convert back to YIQ\u000a    Q = chroma * sin (hue);\u000a    I = chroma * cos (hue);\u000a\u000a    // Convert back to RGB\u000a    highp vec4 yIQ = vec4 (YPrime, I, Q, 0.0);\u000a    color.r = dot (yIQ, kYIQToR);\u000a    color.g = dot (yIQ, kYIQToG);\u000a    color.b = dot (yIQ, kYIQToB);\u000a\u000a    // Save the result\u000a    gl_FragColor = color;\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageHueFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageHueFilter); }
		}

		protected GPUImageHueFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueFilter']/constructor[@name='GPUImageHueFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageHueFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageHueFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueFilter']/constructor[@name='GPUImageHueFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageHueFilter (float hue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hue);
				if (((object) this).GetType () != typeof (GPUImageHueFilter)) {
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

		static Delegate cb_setHue_F;
#pragma warning disable 0169
		static Delegate GetSetHue_FHandler ()
		{
			if (cb_setHue_F == null)
				cb_setHue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHue_F);
			return cb_setHue_F;
		}

		static void n_SetHue_F (IntPtr jnienv, IntPtr native__this, float hue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHueFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHueFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHue (hue);
		}
#pragma warning restore 0169

		static IntPtr id_setHue_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHueFilter']/method[@name='setHue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHue", "(F)V", "GetSetHue_FHandler")]
		public virtual unsafe void SetHue (float hue)
		{
			if (id_setHue_F == IntPtr.Zero)
				id_setHue_F = JNIEnv.GetMethodID (class_ref, "setHue", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (hue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHue_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHue", "(F)V"), __args);
			} finally {
			}
		}

	}
}
