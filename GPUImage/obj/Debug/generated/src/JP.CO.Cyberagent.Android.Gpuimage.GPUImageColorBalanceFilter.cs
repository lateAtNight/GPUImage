using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageColorBalanceFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageColorBalanceFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']/field[@name='GPU_IMAGE_COLOR_BALANCE_FRAGMENT_SHADER']"
		[Register ("GPU_IMAGE_COLOR_BALANCE_FRAGMENT_SHADER")]
		public const string GpuImageColorBalanceFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000auniform sampler2D inputImageTexture;\u000auniform lowp vec3 shadowsShift;\u000auniform lowp vec3 midtonesShift;\u000auniform lowp vec3 highlightsShift;\u000auniform int preserveLuminosity;\u000alowp vec3 RGBToHSL(lowp vec3 color)\u000a{\u000alowp vec3 hsl; // init to 0 to avoid warnings ? (and reverse if + remove first part)\u000alowp float fmin = min(min(color.r, color.g), color.b);    //Min. value of RGB\u000alowp float fmax = max(max(color.r, color.g), color.b);    //Max. value of RGB\u000alowp float delta = fmax - fmin;             //Delta RGB value\u000ahsl.z = (fmax + fmin) / 2.0; // Luminance\u000aif (delta == 0.0)\u0009\u0009//This is a gray, no chroma...\u000a{\u000a    hsl.x = 0.0;\u0009// Hue\u000a    hsl.y = 0.0;\u0009// Saturation\u000a}\u000aelse                                    //Chromatic data...\u000a{\u000a    if (hsl.z < 0.5)\u000a        hsl.y = delta / (fmax + fmin); // Saturation\u000a    else\u000a        hsl.y = delta / (2.0 - fmax - fmin); // Saturation\u000a\u000a    lowp float deltaR = (((fmax - color.r) / 6.0) + (delta / 2.0)) / delta;\u000a    lowp float deltaG = (((fmax - color.g) / 6.0) + (delta / 2.0)) / delta;\u000a    lowp float deltaB = (((fmax - color.b) / 6.0) + (delta / 2.0)) / delta;\u000a\u000a    if (color.r == fmax )\u000a        hsl.x = deltaB - deltaG; // Hue\u000a    else if (color.g == fmax)\u000a        hsl.x = (1.0 / 3.0) + deltaR - deltaB; // Hue\u000a    else if (color.b == fmax)\u000a        hsl.x = (2.0 / 3.0) + deltaG - deltaR; // Hue\u000a    if (hsl.x < 0.0)\u000a        hsl.x += 1.0; // Hue\u000a    else if (hsl.x > 1.0)\u000a        hsl.x -= 1.0; // Hue\u000a}\u000a\u000areturn hsl;\u000a}\u000alowp float HueToRGB(lowp float f1, lowp float f2, lowp float hue)\u000a{\u000a    if (hue < 0.0)\u000a        hue += 1.0;\u000a    else if (hue > 1.0)\u000a        hue -= 1.0;\u000a    lowp float res;\u000a    if ((6.0 * hue) < 1.0)\u000a        res = f1 + (f2 - f1) * 6.0 * hue;\u000a    else if ((2.0 * hue) < 1.0)\u000a        res = f2;\u000a    else if ((3.0 * hue) < 2.0)\u000a        res = f1 + (f2 - f1) * ((2.0 / 3.0) - hue) * 6.0;\u000a    else\u000a        res = f1;\u000a    return res;\u000a}\u000alowp vec3 HSLToRGB(lowp vec3 hsl)\u000a{\u000a    lowp vec3 rgb;\u000a    if (hsl.y == 0.0)\u000a        rgb = vec3(hsl.z); // Luminance\u000a    else\u000a    {\u000a        lowp float f2;\u000a        if (hsl.z < 0.5)\u000a            f2 = hsl.z * (1.0 + hsl.y);\u000a        else\u000a            f2 = (hsl.z + hsl.y) - (hsl.y * hsl.z);\u000a        lowp float f1 = 2.0 * hsl.z - f2;\u000a        rgb.r = HueToRGB(f1, f2, hsl.x + (1.0/3.0));\u000a        rgb.g = HueToRGB(f1, f2, hsl.x);\u000a        rgb.b= HueToRGB(f1, f2, hsl.x - (1.0/3.0));\u000a    }\u000a    return rgb;\u000a  }\u000alowp float RGBToL(lowp vec3 color)\u000a{\u000a    lowp float fmin = min(min(color.r, color.g), color.b);    //Min. value of RGB\u000a    lowp float fmax = max(max(color.r, color.g), color.b);    //Max. value of RGB\u000a    return (fmax + fmin) / 2.0; // Luminance\u000a}\u000avoid main()\u000a{\u000a    lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a    // Alternative way:\u000a    //lowp vec3 lightness = RGBToL(textureColor.rgb);\u000a    lowp vec3 lightness = textureColor.rgb;\u000a    const lowp float a = 0.25;\u000a    const lowp float b = 0.333;\u000a    const lowp float scale = 0.7;\u000a    lowp vec3 shadows = shadowsShift * (clamp((lightness - b) / -a + 0.5, 0.0, 1.0) * scale);\u000a    lowp vec3 midtones = midtonesShift * (clamp((lightness - b) / a + 0.5, 0.0, 1.0) *\u000a        clamp((lightness + b - 1.0) / -a + 0.5, 0.0, 1.0) * scale);\u000a    lowp vec3 highlights = highlightsShift * (clamp((lightness + b - 1.0) / a + 0.5, 0.0, 1.0) * scale);\u000a    mediump vec3 newColor = textureColor.rgb + shadows + midtones + highlights;\u000a    newColor = clamp(newColor, 0.0, 1.0);\u000a        if (preserveLuminosity != 0) {\u000a           lowp vec3 newHSL = RGBToHSL(newColor);\u000a        lowp float oldLum = RGBToL(textureColor.rgb);\u000a        textureColor.rgb = HSLToRGB(vec3(newHSL.x, newHSL.y, oldLum));\u000a        gl_FragColor = textureColor;\u000a    } else {\u000a        gl_FragColor = vec4(newColor.rgb, textureColor.w);\u000a    }\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageColorBalanceFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageColorBalanceFilter); }
		}

		protected GPUImageColorBalanceFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']/constructor[@name='GPUImageColorBalanceFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageColorBalanceFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageColorBalanceFilter)) {
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

		static Delegate cb_setHighlights_arrayF;
#pragma warning disable 0169
		static Delegate GetSetHighlights_arrayFHandler ()
		{
			if (cb_setHighlights_arrayF == null)
				cb_setHighlights_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHighlights_arrayF);
			return cb_setHighlights_arrayF;
		}

		static void n_SetHighlights_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_highlights)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] highlights = (float[]) JNIEnv.GetArray (native_highlights, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetHighlights (highlights);
			if (highlights != null)
				JNIEnv.CopyArray (highlights, native_highlights);
		}
#pragma warning restore 0169

		static IntPtr id_setHighlights_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']/method[@name='setHighlights' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setHighlights", "([F)V", "GetSetHighlights_arrayFHandler")]
		public virtual unsafe void SetHighlights (float[] highlights)
		{
			if (id_setHighlights_arrayF == IntPtr.Zero)
				id_setHighlights_arrayF = JNIEnv.GetMethodID (class_ref, "setHighlights", "([F)V");
			IntPtr native_highlights = JNIEnv.NewArray (highlights);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_highlights);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHighlights_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHighlights", "([F)V"), __args);
			} finally {
				if (highlights != null) {
					JNIEnv.CopyArray (native_highlights, highlights);
					JNIEnv.DeleteLocalRef (native_highlights);
				}
			}
		}

		static Delegate cb_setMidtones_arrayF;
#pragma warning disable 0169
		static Delegate GetSetMidtones_arrayFHandler ()
		{
			if (cb_setMidtones_arrayF == null)
				cb_setMidtones_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMidtones_arrayF);
			return cb_setMidtones_arrayF;
		}

		static void n_SetMidtones_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_midtones)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] midtones = (float[]) JNIEnv.GetArray (native_midtones, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetMidtones (midtones);
			if (midtones != null)
				JNIEnv.CopyArray (midtones, native_midtones);
		}
#pragma warning restore 0169

		static IntPtr id_setMidtones_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']/method[@name='setMidtones' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setMidtones", "([F)V", "GetSetMidtones_arrayFHandler")]
		public virtual unsafe void SetMidtones (float[] midtones)
		{
			if (id_setMidtones_arrayF == IntPtr.Zero)
				id_setMidtones_arrayF = JNIEnv.GetMethodID (class_ref, "setMidtones", "([F)V");
			IntPtr native_midtones = JNIEnv.NewArray (midtones);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_midtones);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setMidtones_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMidtones", "([F)V"), __args);
			} finally {
				if (midtones != null) {
					JNIEnv.CopyArray (native_midtones, midtones);
					JNIEnv.DeleteLocalRef (native_midtones);
				}
			}
		}

		static Delegate cb_setPreserveLuminosity_Z;
#pragma warning disable 0169
		static Delegate GetSetPreserveLuminosity_ZHandler ()
		{
			if (cb_setPreserveLuminosity_Z == null)
				cb_setPreserveLuminosity_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPreserveLuminosity_Z);
			return cb_setPreserveLuminosity_Z;
		}

		static void n_SetPreserveLuminosity_Z (IntPtr jnienv, IntPtr native__this, bool preserveLuminosity)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPreserveLuminosity (preserveLuminosity);
		}
#pragma warning restore 0169

		static IntPtr id_setPreserveLuminosity_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']/method[@name='setPreserveLuminosity' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPreserveLuminosity", "(Z)V", "GetSetPreserveLuminosity_ZHandler")]
		public virtual unsafe void SetPreserveLuminosity (bool preserveLuminosity)
		{
			if (id_setPreserveLuminosity_Z == IntPtr.Zero)
				id_setPreserveLuminosity_Z = JNIEnv.GetMethodID (class_ref, "setPreserveLuminosity", "(Z)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (preserveLuminosity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreserveLuminosity_Z, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPreserveLuminosity", "(Z)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShowdows_arrayF;
#pragma warning disable 0169
		static Delegate GetSetShowdows_arrayFHandler ()
		{
			if (cb_setShowdows_arrayF == null)
				cb_setShowdows_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShowdows_arrayF);
			return cb_setShowdows_arrayF;
		}

		static void n_SetShowdows_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_showdows)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageColorBalanceFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] showdows = (float[]) JNIEnv.GetArray (native_showdows, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetShowdows (showdows);
			if (showdows != null)
				JNIEnv.CopyArray (showdows, native_showdows);
		}
#pragma warning restore 0169

		static IntPtr id_setShowdows_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageColorBalanceFilter']/method[@name='setShowdows' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setShowdows", "([F)V", "GetSetShowdows_arrayFHandler")]
		public virtual unsafe void SetShowdows (float[] showdows)
		{
			if (id_setShowdows_arrayF == IntPtr.Zero)
				id_setShowdows_arrayF = JNIEnv.GetMethodID (class_ref, "setShowdows", "([F)V");
			IntPtr native_showdows = JNIEnv.NewArray (showdows);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_showdows);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShowdows_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShowdows", "([F)V"), __args);
			} finally {
				if (showdows != null) {
					JNIEnv.CopyArray (native_showdows, showdows);
					JNIEnv.DeleteLocalRef (native_showdows);
				}
			}
		}

	}
}
