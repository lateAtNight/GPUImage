using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelThresholdFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageSobelThresholdFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageSobelThresholdFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelThresholdFilter']/field[@name='SOBEL_THRESHOLD_EDGE_DETECTION']"
		[Register ("SOBEL_THRESHOLD_EDGE_DETECTION")]
		public const string SobelThresholdEdgeDetection = (string) "precision mediump float;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000auniform lowp float threshold;\u000a\u000aconst highp vec3 W = vec3(0.2125, 0.7154, 0.0721);\u000a\u000avoid main()\u000a{\u000a    float bottomLeftIntensity = texture2D(inputImageTexture, bottomLeftTextureCoordinate).r;\u000a    float topRightIntensity = texture2D(inputImageTexture, topRightTextureCoordinate).r;\u000a    float topLeftIntensity = texture2D(inputImageTexture, topLeftTextureCoordinate).r;\u000a    float bottomRightIntensity = texture2D(inputImageTexture, bottomRightTextureCoordinate).r;\u000a    float leftIntensity = texture2D(inputImageTexture, leftTextureCoordinate).r;\u000a    float rightIntensity = texture2D(inputImageTexture, rightTextureCoordinate).r;\u000a    float bottomIntensity = texture2D(inputImageTexture, bottomTextureCoordinate).r;\u000a    float topIntensity = texture2D(inputImageTexture, topTextureCoordinate).r;\u000a    float h = -topLeftIntensity - 2.0 * topIntensity - topRightIntensity + bottomLeftIntensity + 2.0 * bottomIntensity + bottomRightIntensity;\u000a    float v = -bottomLeftIntensity - 2.0 * leftIntensity - topLeftIntensity + bottomRightIntensity + 2.0 * rightIntensity + topRightIntensity;\u000a\u000a    float mag = 1.0 - length(vec2(h, v));\u000a    mag = step(threshold, mag);\u000a\u000a    gl_FragColor = vec4(vec3(mag), 1.0);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageSobelThresholdFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageSobelThresholdFilter); }
		}

		protected GPUImageSobelThresholdFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelThresholdFilter']/constructor[@name='GPUImageSobelThresholdFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageSobelThresholdFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageSobelThresholdFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelThresholdFilter']/constructor[@name='GPUImageSobelThresholdFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageSobelThresholdFilter (float threshold)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threshold);
				if (((object) this).GetType () != typeof (GPUImageSobelThresholdFilter)) {
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

		static Delegate cb_setThreshold_F;
#pragma warning disable 0169
		static Delegate GetSetThreshold_FHandler ()
		{
			if (cb_setThreshold_F == null)
				cb_setThreshold_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetThreshold_F);
			return cb_setThreshold_F;
		}

		static void n_SetThreshold_F (IntPtr jnienv, IntPtr native__this, float threshold)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSobelThresholdFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSobelThresholdFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThreshold (threshold);
		}
#pragma warning restore 0169

		static IntPtr id_setThreshold_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelThresholdFilter']/method[@name='setThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setThreshold", "(F)V", "GetSetThreshold_FHandler")]
		public virtual unsafe void SetThreshold (float threshold)
		{
			if (id_setThreshold_F == IntPtr.Zero)
				id_setThreshold_F = JNIEnv.GetMethodID (class_ref, "setThreshold", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (threshold);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setThreshold_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setThreshold", "(F)V"), __args);
			} finally {
			}
		}

	}
}
