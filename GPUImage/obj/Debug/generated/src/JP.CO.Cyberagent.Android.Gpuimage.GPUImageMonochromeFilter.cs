using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageMonochromeFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageMonochromeFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']/field[@name='MONOCHROME_FRAGMENT_SHADER']"
		[Register ("MONOCHROME_FRAGMENT_SHADER")]
		public const string MonochromeFragmentShader = (string) " precision lowp float;\u000a  \u000a  varying highp vec2 textureCoordinate;\u000a  \u000a  uniform sampler2D inputImageTexture;\u000a  uniform float intensity;\u000a  uniform vec3 filterColor;\u000a  \u000a  const mediump vec3 luminanceWeighting = vec3(0.2125, 0.7154, 0.0721);\u000a  \u000a  void main()\u000a  {\u000a \u0009//desat, then apply overlay blend\u000a \u0009lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a \u0009float luminance = dot(textureColor.rgb, luminanceWeighting);\u000a \u0009\u000a \u0009lowp vec4 desat = vec4(vec3(luminance), 1.0);\u000a \u0009\u000a \u0009//overlay\u000a \u0009lowp vec4 outputColor = vec4(\u000a                                  (desat.r < 0.5 ? (2.0 * desat.r * filterColor.r) : (1.0 - 2.0 * (1.0 - desat.r) * (1.0 - filterColor.r))),\u000a                                  (desat.g < 0.5 ? (2.0 * desat.g * filterColor.g) : (1.0 - 2.0 * (1.0 - desat.g) * (1.0 - filterColor.g))),\u000a                                  (desat.b < 0.5 ? (2.0 * desat.b * filterColor.b) : (1.0 - 2.0 * (1.0 - desat.b) * (1.0 - filterColor.b))),\u000a                                  1.0\u000a                                  );\u000a \u0009\u000a \u0009//which is better, or are they equal?\u000a \u0009gl_FragColor = vec4( mix(textureColor.rgb, outputColor.rgb, intensity), textureColor.a);\u000a  }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageMonochromeFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageMonochromeFilter); }
		}

		protected GPUImageMonochromeFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']/constructor[@name='GPUImageMonochromeFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageMonochromeFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageMonochromeFilter)) {
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

		static IntPtr id_ctor_FarrayF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']/constructor[@name='GPUImageMonochromeFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "(F[F)V", "")]
		public unsafe GPUImageMonochromeFilter (float intensity, float[] color)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_color = JNIEnv.NewArray (color);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (intensity);
				__args [1] = new JValue (native_color);
				if (((object) this).GetType () != typeof (GPUImageMonochromeFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(F[F)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(F[F)V", __args);
					return;
				}

				if (id_ctor_FarrayF == IntPtr.Zero)
					id_ctor_FarrayF = JNIEnv.GetMethodID (class_ref, "<init>", "(F[F)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FarrayF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FarrayF, __args);
			} finally {
				if (color != null) {
					JNIEnv.CopyArray (native_color, color);
					JNIEnv.DeleteLocalRef (native_color);
				}
			}
		}

		static Delegate cb_setColor_arrayF;
#pragma warning disable 0169
		static Delegate GetSetColor_arrayFHandler ()
		{
			if (cb_setColor_arrayF == null)
				cb_setColor_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColor_arrayF);
			return cb_setColor_arrayF;
		}

		static void n_SetColor_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_color)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMonochromeFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMonochromeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] color = (float[]) JNIEnv.GetArray (native_color, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetColor (color);
			if (color != null)
				JNIEnv.CopyArray (color, native_color);
		}
#pragma warning restore 0169

		static IntPtr id_setColor_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setColor", "([F)V", "GetSetColor_arrayFHandler")]
		public virtual unsafe void SetColor (float[] color)
		{
			if (id_setColor_arrayF == IntPtr.Zero)
				id_setColor_arrayF = JNIEnv.GetMethodID (class_ref, "setColor", "([F)V");
			IntPtr native_color = JNIEnv.NewArray (color);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_color);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColor_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColor", "([F)V"), __args);
			} finally {
				if (color != null) {
					JNIEnv.CopyArray (native_color, color);
					JNIEnv.DeleteLocalRef (native_color);
				}
			}
		}

		static Delegate cb_setColorRed_FFF;
#pragma warning disable 0169
		static Delegate GetSetColorRed_FFFHandler ()
		{
			if (cb_setColorRed_FFF == null)
				cb_setColorRed_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_SetColorRed_FFF);
			return cb_setColorRed_FFF;
		}

		static void n_SetColorRed_FFF (IntPtr jnienv, IntPtr native__this, float red, float green, float blue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMonochromeFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMonochromeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColorRed (red, green, blue);
		}
#pragma warning restore 0169

		static IntPtr id_setColorRed_FFF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']/method[@name='setColorRed' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("setColorRed", "(FFF)V", "GetSetColorRed_FFFHandler")]
		public virtual unsafe void SetColorRed (float red, float green, float blue)
		{
			if (id_setColorRed_FFF == IntPtr.Zero)
				id_setColorRed_FFF = JNIEnv.GetMethodID (class_ref, "setColorRed", "(FFF)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (red);
				__args [1] = new JValue (green);
				__args [2] = new JValue (blue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setColorRed_FFF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setColorRed", "(FFF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setIntensity_F;
#pragma warning disable 0169
		static Delegate GetSetIntensity_FHandler ()
		{
			if (cb_setIntensity_F == null)
				cb_setIntensity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetIntensity_F);
			return cb_setIntensity_F;
		}

		static void n_SetIntensity_F (IntPtr jnienv, IntPtr native__this, float intensity)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMonochromeFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageMonochromeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetIntensity (intensity);
		}
#pragma warning restore 0169

		static IntPtr id_setIntensity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageMonochromeFilter']/method[@name='setIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setIntensity", "(F)V", "GetSetIntensity_FHandler")]
		public virtual unsafe void SetIntensity (float intensity)
		{
			if (id_setIntensity_F == IntPtr.Zero)
				id_setIntensity_F = JNIEnv.GetMethodID (class_ref, "setIntensity", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (intensity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIntensity_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setIntensity", "(F)V"), __args);
			} finally {
			}
		}

	}
}
