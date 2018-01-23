using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHighlightShadowFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageHighlightShadowFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageHighlightShadowFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHighlightShadowFilter']/field[@name='HIGHLIGHT_SHADOW_FRAGMENT_SHADER']"
		[Register ("HIGHLIGHT_SHADOW_FRAGMENT_SHADER")]
		public const string HighlightShadowFragmentShader = (string) " uniform sampler2D inputImageTexture;\u000a varying highp vec2 textureCoordinate;\u000a  \u000a uniform lowp float shadows;\u000a uniform lowp float highlights;\u000a \u000a const mediump vec3 luminanceWeighting = vec3(0.3, 0.3, 0.3);\u000a \u000a void main()\u000a {\u000a \u0009lowp vec4 source = texture2D(inputImageTexture, textureCoordinate);\u000a \u0009mediump float luminance = dot(source.rgb, luminanceWeighting);\u000a \u000a \u0009mediump float shadow = clamp((pow(luminance, 1.0/(shadows+1.0)) + (-0.76)*pow(luminance, 2.0/(shadows+1.0))) - luminance, 0.0, 1.0);\u000a \u0009mediump float highlight = clamp((1.0 - (pow(1.0-luminance, 1.0/(2.0-highlights)) + (-0.8)*pow(1.0-luminance, 2.0/(2.0-highlights)))) - luminance, -1.0, 0.0);\u000a \u0009lowp vec3 result = vec3(0.0, 0.0, 0.0) + ((luminance + shadow + highlight) - 0.0) * ((source.rgb - vec3(0.0, 0.0, 0.0))/(luminance - 0.0));\u000a \u000a \u0009gl_FragColor = vec4(result.rgb, source.a);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageHighlightShadowFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageHighlightShadowFilter); }
		}

		protected GPUImageHighlightShadowFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHighlightShadowFilter']/constructor[@name='GPUImageHighlightShadowFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageHighlightShadowFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageHighlightShadowFilter)) {
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

		static IntPtr id_ctor_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHighlightShadowFilter']/constructor[@name='GPUImageHighlightShadowFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe GPUImageHighlightShadowFilter (float shadows, float highlights)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (shadows);
				__args [1] = new JValue (highlights);
				if (((object) this).GetType () != typeof (GPUImageHighlightShadowFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FF)V", __args);
					return;
				}

				if (id_ctor_FF == IntPtr.Zero)
					id_ctor_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(FF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FF, __args);
			} finally {
			}
		}

		static Delegate cb_setHighlights_F;
#pragma warning disable 0169
		static Delegate GetSetHighlights_FHandler ()
		{
			if (cb_setHighlights_F == null)
				cb_setHighlights_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHighlights_F);
			return cb_setHighlights_F;
		}

		static void n_SetHighlights_F (IntPtr jnienv, IntPtr native__this, float highlights)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHighlightShadowFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHighlightShadowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlights (highlights);
		}
#pragma warning restore 0169

		static IntPtr id_setHighlights_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHighlightShadowFilter']/method[@name='setHighlights' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHighlights", "(F)V", "GetSetHighlights_FHandler")]
		public virtual unsafe void SetHighlights (float highlights)
		{
			if (id_setHighlights_F == IntPtr.Zero)
				id_setHighlights_F = JNIEnv.GetMethodID (class_ref, "setHighlights", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (highlights);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHighlights_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setHighlights", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setShadows_F;
#pragma warning disable 0169
		static Delegate GetSetShadows_FHandler ()
		{
			if (cb_setShadows_F == null)
				cb_setShadows_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetShadows_F);
			return cb_setShadows_F;
		}

		static void n_SetShadows_F (IntPtr jnienv, IntPtr native__this, float shadows)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHighlightShadowFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHighlightShadowFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetShadows (shadows);
		}
#pragma warning restore 0169

		static IntPtr id_setShadows_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHighlightShadowFilter']/method[@name='setShadows' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setShadows", "(F)V", "GetSetShadows_FHandler")]
		public virtual unsafe void SetShadows (float shadows)
		{
			if (id_setShadows_F == IntPtr.Zero)
				id_setShadows_F = JNIEnv.GetMethodID (class_ref, "setShadows", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (shadows);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShadows_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setShadows", "(F)V"), __args);
			} finally {
			}
		}

	}
}
