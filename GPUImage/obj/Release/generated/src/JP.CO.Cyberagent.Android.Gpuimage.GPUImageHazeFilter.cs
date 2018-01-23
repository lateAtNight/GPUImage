using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHazeFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageHazeFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageHazeFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHazeFilter']/field[@name='HAZE_FRAGMENT_SHADER']"
		[Register ("HAZE_FRAGMENT_SHADER")]
		public const string HazeFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform lowp float distance;\u000auniform highp float slope;\u000a\u000avoid main()\u000a{\u000a\u0009//todo reconsider precision modifiers\u0009 \u000a\u0009 highp vec4 color = vec4(1.0);//todo reimplement as a parameter\u000a\u000a\u0009 highp float  d = textureCoordinate.y * slope  +  distance; \u000a\u000a\u0009 highp vec4 c = texture2D(inputImageTexture, textureCoordinate) ; // consider using unpremultiply\u000a\u000a\u0009 c = (c - d * color) / (1.0 -d);\u000a\u000a\u0009 gl_FragColor = c; //consider using premultiply(c);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageHazeFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageHazeFilter); }
		}

		protected GPUImageHazeFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHazeFilter']/constructor[@name='GPUImageHazeFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageHazeFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageHazeFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHazeFilter']/constructor[@name='GPUImageHazeFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe GPUImageHazeFilter (float distance, float slope)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (distance);
				__args [1] = new JValue (slope);
				if (((object) this).GetType () != typeof (GPUImageHazeFilter)) {
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

		static Delegate cb_setDistance_F;
#pragma warning disable 0169
		static Delegate GetSetDistance_FHandler ()
		{
			if (cb_setDistance_F == null)
				cb_setDistance_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDistance_F);
			return cb_setDistance_F;
		}

		static void n_SetDistance_F (IntPtr jnienv, IntPtr native__this, float distance)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHazeFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHazeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDistance (distance);
		}
#pragma warning restore 0169

		static IntPtr id_setDistance_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHazeFilter']/method[@name='setDistance' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDistance", "(F)V", "GetSetDistance_FHandler")]
		public virtual unsafe void SetDistance (float distance)
		{
			if (id_setDistance_F == IntPtr.Zero)
				id_setDistance_F = JNIEnv.GetMethodID (class_ref, "setDistance", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (distance);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDistance_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDistance", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setSlope_F;
#pragma warning disable 0169
		static Delegate GetSetSlope_FHandler ()
		{
			if (cb_setSlope_F == null)
				cb_setSlope_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSlope_F);
			return cb_setSlope_F;
		}

		static void n_SetSlope_F (IntPtr jnienv, IntPtr native__this, float slope)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHazeFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageHazeFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSlope (slope);
		}
#pragma warning restore 0169

		static IntPtr id_setSlope_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageHazeFilter']/method[@name='setSlope' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSlope", "(F)V", "GetSetSlope_FHandler")]
		public virtual unsafe void SetSlope (float slope)
		{
			if (id_setSlope_F == IntPtr.Zero)
				id_setSlope_F = JNIEnv.GetMethodID (class_ref, "setSlope", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (slope);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSlope_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSlope", "(F)V"), __args);
			} finally {
			}
		}

	}
}
