using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageRGBFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageRGBFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']/field[@name='RGB_FRAGMENT_SHADER']"
		[Register ("RGB_FRAGMENT_SHADER")]
		public const string RgbFragmentShader = (string) "  varying highp vec2 textureCoordinate;\u000a  \u000a  uniform sampler2D inputImageTexture;\u000a  uniform highp float red;\u000a  uniform highp float green;\u000a  uniform highp float blue;\u000a  \u000a  void main()\u000a  {\u000a      highp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a      \u000a      gl_FragColor = vec4(textureColor.r * red, textureColor.g * green, textureColor.b * blue, 1.0);\u000a  }\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageRGBFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageRGBFilter); }
		}

		protected GPUImageRGBFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']/constructor[@name='GPUImageRGBFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageRGBFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageRGBFilter)) {
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

		static IntPtr id_ctor_FFF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']/constructor[@name='GPUImageRGBFilter' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(FFF)V", "")]
		public unsafe GPUImageRGBFilter (float red, float green, float blue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (red);
				__args [1] = new JValue (green);
				__args [2] = new JValue (blue);
				if (((object) this).GetType () != typeof (GPUImageRGBFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFF)V", __args);
					return;
				}

				if (id_ctor_FFF == IntPtr.Zero)
					id_ctor_FFF = JNIEnv.GetMethodID (class_ref, "<init>", "(FFF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFF, __args);
			} finally {
			}
		}

		static Delegate cb_setBlue_F;
#pragma warning disable 0169
		static Delegate GetSetBlue_FHandler ()
		{
			if (cb_setBlue_F == null)
				cb_setBlue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBlue_F);
			return cb_setBlue_F;
		}

		static void n_SetBlue_F (IntPtr jnienv, IntPtr native__this, float blue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRGBFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRGBFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlue (blue);
		}
#pragma warning restore 0169

		static IntPtr id_setBlue_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']/method[@name='setBlue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBlue", "(F)V", "GetSetBlue_FHandler")]
		public virtual unsafe void SetBlue (float blue)
		{
			if (id_setBlue_F == IntPtr.Zero)
				id_setBlue_F = JNIEnv.GetMethodID (class_ref, "setBlue", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (blue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlue_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlue", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setGreen_F;
#pragma warning disable 0169
		static Delegate GetSetGreen_FHandler ()
		{
			if (cb_setGreen_F == null)
				cb_setGreen_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGreen_F);
			return cb_setGreen_F;
		}

		static void n_SetGreen_F (IntPtr jnienv, IntPtr native__this, float green)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRGBFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRGBFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGreen (green);
		}
#pragma warning restore 0169

		static IntPtr id_setGreen_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']/method[@name='setGreen' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setGreen", "(F)V", "GetSetGreen_FHandler")]
		public virtual unsafe void SetGreen (float green)
		{
			if (id_setGreen_F == IntPtr.Zero)
				id_setGreen_F = JNIEnv.GetMethodID (class_ref, "setGreen", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (green);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGreen_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGreen", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRed_F;
#pragma warning disable 0169
		static Delegate GetSetRed_FHandler ()
		{
			if (cb_setRed_F == null)
				cb_setRed_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRed_F);
			return cb_setRed_F;
		}

		static void n_SetRed_F (IntPtr jnienv, IntPtr native__this, float red)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRGBFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageRGBFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRed (red);
		}
#pragma warning restore 0169

		static IntPtr id_setRed_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBFilter']/method[@name='setRed' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRed", "(F)V", "GetSetRed_FHandler")]
		public virtual unsafe void SetRed (float red)
		{
			if (id_setRed_F == IntPtr.Zero)
				id_setRed_F = JNIEnv.GetMethodID (class_ref, "setRed", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (red);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRed_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRed", "(F)V"), __args);
			} finally {
			}
		}

	}
}
