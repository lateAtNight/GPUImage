using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCrosshatchFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageCrosshatchFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageCrosshatchFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCrosshatchFilter']/field[@name='CROSSHATCH_FRAGMENT_SHADER']"
		[Register ("CROSSHATCH_FRAGMENT_SHADER")]
		public const string CrosshatchFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000auniform sampler2D inputImageTexture;\u000auniform highp float crossHatchSpacing;\u000auniform highp float lineWidth;\u000aconst highp vec3 W = vec3(0.2125, 0.7154, 0.0721);\u000avoid main()\u000a{\u000ahighp float luminance = dot(texture2D(inputImageTexture, textureCoordinate).rgb, W);\u000alowp vec4 colorToDisplay = vec4(1.0, 1.0, 1.0, 1.0);\u000aif (luminance < 1.00)\u000a{\u000aif (mod(textureCoordinate.x + textureCoordinate.y, crossHatchSpacing) <= lineWidth)\u000a{\u000acolorToDisplay = vec4(0.0, 0.0, 0.0, 1.0);\u000a}\u000a}\u000aif (luminance < 0.75)\u000a{\u000aif (mod(textureCoordinate.x - textureCoordinate.y, crossHatchSpacing) <= lineWidth)\u000a{\u000acolorToDisplay = vec4(0.0, 0.0, 0.0, 1.0);\u000a}\u000a}\u000aif (luminance < 0.50)\u000a{\u000aif (mod(textureCoordinate.x + textureCoordinate.y - (crossHatchSpacing / 2.0), crossHatchSpacing) <= lineWidth)\u000a{\u000acolorToDisplay = vec4(0.0, 0.0, 0.0, 1.0);\u000a}\u000a}\u000aif (luminance < 0.3)\u000a{\u000aif (mod(textureCoordinate.x - textureCoordinate.y - (crossHatchSpacing / 2.0), crossHatchSpacing) <= lineWidth)\u000a{\u000acolorToDisplay = vec4(0.0, 0.0, 0.0, 1.0);\u000a}\u000a}\u000agl_FragColor = colorToDisplay;\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageCrosshatchFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageCrosshatchFilter); }
		}

		protected GPUImageCrosshatchFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCrosshatchFilter']/constructor[@name='GPUImageCrosshatchFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageCrosshatchFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageCrosshatchFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCrosshatchFilter']/constructor[@name='GPUImageCrosshatchFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe GPUImageCrosshatchFilter (float crossHatchSpacing, float lineWidth)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (crossHatchSpacing);
				__args [1] = new JValue (lineWidth);
				if (((object) this).GetType () != typeof (GPUImageCrosshatchFilter)) {
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

		static Delegate cb_setCrossHatchSpacing_F;
#pragma warning disable 0169
		static Delegate GetSetCrossHatchSpacing_FHandler ()
		{
			if (cb_setCrossHatchSpacing_F == null)
				cb_setCrossHatchSpacing_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCrossHatchSpacing_F);
			return cb_setCrossHatchSpacing_F;
		}

		static void n_SetCrossHatchSpacing_F (IntPtr jnienv, IntPtr native__this, float crossHatchSpacing)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageCrosshatchFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageCrosshatchFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCrossHatchSpacing (crossHatchSpacing);
		}
#pragma warning restore 0169

		static IntPtr id_setCrossHatchSpacing_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCrosshatchFilter']/method[@name='setCrossHatchSpacing' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setCrossHatchSpacing", "(F)V", "GetSetCrossHatchSpacing_FHandler")]
		public virtual unsafe void SetCrossHatchSpacing (float crossHatchSpacing)
		{
			if (id_setCrossHatchSpacing_F == IntPtr.Zero)
				id_setCrossHatchSpacing_F = JNIEnv.GetMethodID (class_ref, "setCrossHatchSpacing", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (crossHatchSpacing);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCrossHatchSpacing_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCrossHatchSpacing", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float lineWidth)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageCrosshatchFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageCrosshatchFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLineWidth (lineWidth);
		}
#pragma warning restore 0169

		static IntPtr id_setLineWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageCrosshatchFilter']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
		public virtual unsafe void SetLineWidth (float lineWidth)
		{
			if (id_setLineWidth_F == IntPtr.Zero)
				id_setLineWidth_F = JNIEnv.GetMethodID (class_ref, "setLineWidth", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (lineWidth);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLineWidth_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineWidth", "(F)V"), __args);
			} finally {
			}
		}

	}
}
