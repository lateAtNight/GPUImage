using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageChromaKeyBlendFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageChromaKeyBlendFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageChromaKeyBlendFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoInputFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageChromaKeyBlendFilter']/field[@name='CHROMA_KEY_BLEND_FRAGMENT_SHADER']"
		[Register ("CHROMA_KEY_BLEND_FRAGMENT_SHADER")]
		public const string ChromaKeyBlendFragmentShader = (string) " precision highp float;\u000a \u000a varying highp vec2 textureCoordinate;\u000a varying highp vec2 textureCoordinate2;\u000a\u000a uniform float thresholdSensitivity;\u000a uniform float smoothing;\u000a uniform vec3 colorToReplace;\u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D inputImageTexture2;\u000a \u000a void main()\u000a {\u000a     vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     vec4 textureColor2 = texture2D(inputImageTexture2, textureCoordinate2);\u000a     \u000a     float maskY = 0.2989 * colorToReplace.r + 0.5866 * colorToReplace.g + 0.1145 * colorToReplace.b;\u000a     float maskCr = 0.7132 * (colorToReplace.r - maskY);\u000a     float maskCb = 0.5647 * (colorToReplace.b - maskY);\u000a     \u000a     float Y = 0.2989 * textureColor.r + 0.5866 * textureColor.g + 0.1145 * textureColor.b;\u000a     float Cr = 0.7132 * (textureColor.r - Y);\u000a     float Cb = 0.5647 * (textureColor.b - Y);\u000a     \u000a     float blendValue = 1.0 - smoothstep(thresholdSensitivity, thresholdSensitivity + smoothing, distance(vec2(Cr, Cb), vec2(maskCr, maskCb)));\u000a     gl_FragColor = mix(textureColor, textureColor2, blendValue);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageChromaKeyBlendFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageChromaKeyBlendFilter); }
		}

		protected GPUImageChromaKeyBlendFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageChromaKeyBlendFilter']/constructor[@name='GPUImageChromaKeyBlendFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageChromaKeyBlendFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageChromaKeyBlendFilter)) {
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

		static Delegate cb_setColorToReplace_FFF;
#pragma warning disable 0169
		static Delegate GetSetColorToReplace_FFFHandler ()
		{
			if (cb_setColorToReplace_FFF == null)
				cb_setColorToReplace_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetColorToReplace_FFF);
			return cb_setColorToReplace_FFF;
		}

		static void n_SetColorToReplace_FFF (IntPtr jnienv, IntPtr native__this, float redComponent, float greenComponent, float blueComponent)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageChromaKeyBlendFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageChromaKeyBlendFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorToReplace (redComponent, greenComponent, blueComponent);
		}
#pragma warning restore 0169

		static IntPtr id_setColorToReplace_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageChromaKeyBlendFilter']/method[@name='setColorToReplace' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setColorToReplace", "(FFF)V", "GetSetColorToReplace_FFFHandler")]
		public virtual unsafe void SetColorToReplace (float redComponent, float greenComponent, float blueComponent)
		{
			if (id_setColorToReplace_FFF == IntPtr.Zero)
				id_setColorToReplace_FFF = JNIEnv.GetMethodID (class_ref, "setColorToReplace", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (redComponent);
				__args [1] = new JValue (greenComponent);
				__args [2] = new JValue (blueComponent);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorToReplace_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorToReplace", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSmoothing_F;
#pragma warning disable 0169
		static Delegate GetSetSmoothing_FHandler ()
		{
			if (cb_setSmoothing_F == null)
				cb_setSmoothing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSmoothing_F);
			return cb_setSmoothing_F;
		}

		static void n_SetSmoothing_F (IntPtr jnienv, IntPtr native__this, float smoothing)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageChromaKeyBlendFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageChromaKeyBlendFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSmoothing (smoothing);
		}
#pragma warning restore 0169

		static IntPtr id_setSmoothing_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageChromaKeyBlendFilter']/method[@name='setSmoothing' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSmoothing", "(F)V", "GetSetSmoothing_FHandler")]
		public virtual unsafe void SetSmoothing (float smoothing)
		{
			if (id_setSmoothing_F == IntPtr.Zero)
				id_setSmoothing_F = JNIEnv.GetMethodID (class_ref, "setSmoothing", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (smoothing);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSmoothing_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSmoothing", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setThresholdSensitivity_F;
#pragma warning disable 0169
		static Delegate GetSetThresholdSensitivity_FHandler ()
		{
			if (cb_setThresholdSensitivity_F == null)
				cb_setThresholdSensitivity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetThresholdSensitivity_F);
			return cb_setThresholdSensitivity_F;
		}

		static void n_SetThresholdSensitivity_F (IntPtr jnienv, IntPtr native__this, float thresholdSensitivity)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageChromaKeyBlendFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageChromaKeyBlendFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThresholdSensitivity (thresholdSensitivity);
		}
#pragma warning restore 0169

		static IntPtr id_setThresholdSensitivity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageChromaKeyBlendFilter']/method[@name='setThresholdSensitivity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setThresholdSensitivity", "(F)V", "GetSetThresholdSensitivity_FHandler")]
		public virtual unsafe void SetThresholdSensitivity (float thresholdSensitivity)
		{
			if (id_setThresholdSensitivity_F == IntPtr.Zero)
				id_setThresholdSensitivity_F = JNIEnv.GetMethodID (class_ref, "setThresholdSensitivity", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (thresholdSensitivity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThresholdSensitivity_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThresholdSensitivity", "(F)V"), __args);
			} finally {
			}
		}

	}
}
