using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageOpacityFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageOpacityFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageOpacityFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageOpacityFilter']/field[@name='OPACITY_FRAGMENT_SHADER']"
		[Register ("OPACITY_FRAGMENT_SHADER")]
		public const string OpacityFragmentShader = (string) "  varying highp vec2 textureCoordinate;\u000a  \u000a  uniform sampler2D inputImageTexture;\u000a  uniform lowp float opacity;\u000a  \u000a  void main()\u000a  {\u000a      lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a      \u000a      gl_FragColor = vec4(textureColor.rgb, textureColor.a * opacity);\u000a  }\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageOpacityFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageOpacityFilter); }
		}

		protected GPUImageOpacityFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageOpacityFilter']/constructor[@name='GPUImageOpacityFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageOpacityFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageOpacityFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageOpacityFilter']/constructor[@name='GPUImageOpacityFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageOpacityFilter (float opacity)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (opacity);
				if (((object) this).GetType () != typeof (GPUImageOpacityFilter)) {
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

		static Delegate cb_setOpacity_F;
#pragma warning disable 0169
		static Delegate GetSetOpacity_FHandler ()
		{
			if (cb_setOpacity_F == null)
				cb_setOpacity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetOpacity_F);
			return cb_setOpacity_F;
		}

		static void n_SetOpacity_F (IntPtr jnienv, IntPtr native__this, float opacity)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageOpacityFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageOpacityFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOpacity (opacity);
		}
#pragma warning restore 0169

		static IntPtr id_setOpacity_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageOpacityFilter']/method[@name='setOpacity' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setOpacity", "(F)V", "GetSetOpacity_FHandler")]
		public virtual unsafe void SetOpacity (float opacity)
		{
			if (id_setOpacity_F == IntPtr.Zero)
				id_setOpacity_F = JNIEnv.GetMethodID (class_ref, "setOpacity", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (opacity);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setOpacity_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOpacity", "(F)V"), __args);
			} finally {
			}
		}

	}
}
