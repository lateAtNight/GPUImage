using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageVignetteFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageVignetteFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/field[@name='VIGNETTING_FRAGMENT_SHADER']"
		[Register ("VIGNETTING_FRAGMENT_SHADER")]
		public const string VignettingFragmentShader = (string) " uniform sampler2D inputImageTexture;\u000a varying highp vec2 textureCoordinate;\u000a \u000a uniform lowp vec2 vignetteCenter;\u000a uniform lowp vec3 vignetteColor;\u000a uniform highp float vignetteStart;\u000a uniform highp float vignetteEnd;\u000a \u000a void main()\u000a {\u000a     /*\u000a     lowp vec3 rgb = texture2D(inputImageTexture, textureCoordinate).rgb;\u000a     lowp float d = distance(textureCoordinate, vec2(0.5,0.5));\u000a     rgb *= (1.0 - smoothstep(vignetteStart, vignetteEnd, d));\u000a     gl_FragColor = vec4(vec3(rgb),1.0);\u000a      */\u000a     \u000a     lowp vec3 rgb = texture2D(inputImageTexture, textureCoordinate).rgb;\u000a     lowp float d = distance(textureCoordinate, vec2(vignetteCenter.x, vignetteCenter.y));\u000a     lowp float percent = smoothstep(vignetteStart, vignetteEnd, d);\u000a     gl_FragColor = vec4(mix(rgb.x, vignetteColor.x, percent), mix(rgb.y, vignetteColor.y, percent), mix(rgb.z, vignetteColor.z, percent), 1.0);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageVignetteFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageVignetteFilter); }
		}

		protected GPUImageVignetteFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/constructor[@name='GPUImageVignetteFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageVignetteFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageVignetteFilter)) {
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

		static IntPtr id_ctor_Landroid_graphics_PointF_arrayFFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/constructor[@name='GPUImageVignetteFilter' and count(parameter)=4 and parameter[1][@type='android.graphics.PointF'] and parameter[2][@type='float[]'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register (".ctor", "(Landroid/graphics/PointF;[FFF)V", "")]
		public unsafe GPUImageVignetteFilter (global::Android.Graphics.PointF vignetteCenter, float[] vignetteColor, float vignetteStart, float vignetteEnd)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vignetteColor = JNIEnv.NewArray (vignetteColor);
			try {
				JValue* __args = stackalloc JValue [4];
				__args [0] = new JValue (vignetteCenter);
				__args [1] = new JValue (native_vignetteColor);
				__args [2] = new JValue (vignetteStart);
				__args [3] = new JValue (vignetteEnd);
				if (((object) this).GetType () != typeof (GPUImageVignetteFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/PointF;[FFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/PointF;[FFF)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_PointF_arrayFFF == IntPtr.Zero)
					id_ctor_Landroid_graphics_PointF_arrayFFF = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/PointF;[FFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_PointF_arrayFFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_PointF_arrayFFF, __args);
			} finally {
				if (vignetteColor != null) {
					JNIEnv.CopyArray (native_vignetteColor, vignetteColor);
					JNIEnv.DeleteLocalRef (native_vignetteColor);
				}
			}
		}

		static Delegate cb_setVignetteCenter_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetVignetteCenter_Landroid_graphics_PointF_Handler ()
		{
			if (cb_setVignetteCenter_Landroid_graphics_PointF_ == null)
				cb_setVignetteCenter_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVignetteCenter_Landroid_graphics_PointF_);
			return cb_setVignetteCenter_Landroid_graphics_PointF_;
		}

		static void n_SetVignetteCenter_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vignetteCenter)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF vignetteCenter = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_vignetteCenter, JniHandleOwnership.DoNotTransfer);
			__this.SetVignetteCenter (vignetteCenter);
		}
#pragma warning restore 0169

		static IntPtr id_setVignetteCenter_Landroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/method[@name='setVignetteCenter' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("setVignetteCenter", "(Landroid/graphics/PointF;)V", "GetSetVignetteCenter_Landroid_graphics_PointF_Handler")]
		public virtual unsafe void SetVignetteCenter (global::Android.Graphics.PointF vignetteCenter)
		{
			if (id_setVignetteCenter_Landroid_graphics_PointF_ == IntPtr.Zero)
				id_setVignetteCenter_Landroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setVignetteCenter", "(Landroid/graphics/PointF;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (vignetteCenter);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVignetteCenter_Landroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVignetteCenter", "(Landroid/graphics/PointF;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVignetteColor_arrayF;
#pragma warning disable 0169
		static Delegate GetSetVignetteColor_arrayFHandler ()
		{
			if (cb_setVignetteColor_arrayF == null)
				cb_setVignetteColor_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVignetteColor_arrayF);
			return cb_setVignetteColor_arrayF;
		}

		static void n_SetVignetteColor_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_vignetteColor)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] vignetteColor = (float[]) JNIEnv.GetArray (native_vignetteColor, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetVignetteColor (vignetteColor);
			if (vignetteColor != null)
				JNIEnv.CopyArray (vignetteColor, native_vignetteColor);
		}
#pragma warning restore 0169

		static IntPtr id_setVignetteColor_arrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/method[@name='setVignetteColor' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setVignetteColor", "([F)V", "GetSetVignetteColor_arrayFHandler")]
		public virtual unsafe void SetVignetteColor (float[] vignetteColor)
		{
			if (id_setVignetteColor_arrayF == IntPtr.Zero)
				id_setVignetteColor_arrayF = JNIEnv.GetMethodID (class_ref, "setVignetteColor", "([F)V");
			IntPtr native_vignetteColor = JNIEnv.NewArray (vignetteColor);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_vignetteColor);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVignetteColor_arrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVignetteColor", "([F)V"), __args);
			} finally {
				if (vignetteColor != null) {
					JNIEnv.CopyArray (native_vignetteColor, vignetteColor);
					JNIEnv.DeleteLocalRef (native_vignetteColor);
				}
			}
		}

		static Delegate cb_setVignetteEnd_F;
#pragma warning disable 0169
		static Delegate GetSetVignetteEnd_FHandler ()
		{
			if (cb_setVignetteEnd_F == null)
				cb_setVignetteEnd_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVignetteEnd_F);
			return cb_setVignetteEnd_F;
		}

		static void n_SetVignetteEnd_F (IntPtr jnienv, IntPtr native__this, float vignetteEnd)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVignetteEnd (vignetteEnd);
		}
#pragma warning restore 0169

		static IntPtr id_setVignetteEnd_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/method[@name='setVignetteEnd' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVignetteEnd", "(F)V", "GetSetVignetteEnd_FHandler")]
		public virtual unsafe void SetVignetteEnd (float vignetteEnd)
		{
			if (id_setVignetteEnd_F == IntPtr.Zero)
				id_setVignetteEnd_F = JNIEnv.GetMethodID (class_ref, "setVignetteEnd", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (vignetteEnd);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVignetteEnd_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVignetteEnd", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setVignetteStart_F;
#pragma warning disable 0169
		static Delegate GetSetVignetteStart_FHandler ()
		{
			if (cb_setVignetteStart_F == null)
				cb_setVignetteStart_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVignetteStart_F);
			return cb_setVignetteStart_F;
		}

		static void n_SetVignetteStart_F (IntPtr jnienv, IntPtr native__this, float vignetteStart)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageVignetteFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVignetteStart (vignetteStart);
		}
#pragma warning restore 0169

		static IntPtr id_setVignetteStart_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageVignetteFilter']/method[@name='setVignetteStart' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVignetteStart", "(F)V", "GetSetVignetteStart_FHandler")]
		public virtual unsafe void SetVignetteStart (float vignetteStart)
		{
			if (id_setVignetteStart_F == IntPtr.Zero)
				id_setVignetteStart_F = JNIEnv.GetMethodID (class_ref, "setVignetteStart", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (vignetteStart);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVignetteStart_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setVignetteStart", "(F)V"), __args);
			} finally {
			}
		}

	}
}
