using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBoxBlurFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageBoxBlurFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageBoxBlurFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBoxBlurFilter']/field[@name='FRAGMENT_SHADER']"
		[Register ("FRAGMENT_SHADER")]
		public const string FragmentShader = (string) "precision highp float;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepLeftTextureCoordinate;\u000avarying vec2 twoStepsLeftTextureCoordinate;\u000avarying vec2 oneStepRightTextureCoordinate;\u000avarying vec2 twoStepsRightTextureCoordinate;\u000a\u000avoid main()\u000a{\u000alowp vec4 fragmentColor = texture2D(inputImageTexture, centerTextureCoordinate) * 0.2;\u000afragmentColor += texture2D(inputImageTexture, oneStepLeftTextureCoordinate) * 0.2;\u000afragmentColor += texture2D(inputImageTexture, oneStepRightTextureCoordinate) * 0.2;\u000afragmentColor += texture2D(inputImageTexture, twoStepsLeftTextureCoordinate) * 0.2;\u000afragmentColor += texture2D(inputImageTexture, twoStepsRightTextureCoordinate) * 0.2;\u000a\u000agl_FragColor = fragmentColor;\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBoxBlurFilter']/field[@name='VERTEX_SHADER']"
		[Register ("VERTEX_SHADER")]
		public const string VertexShader = (string) "attribute vec4 position;\u000aattribute vec2 inputTextureCoordinate;\u000a\u000auniform float texelWidthOffset; \u000auniform float texelHeightOffset; \u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepLeftTextureCoordinate;\u000avarying vec2 twoStepsLeftTextureCoordinate;\u000avarying vec2 oneStepRightTextureCoordinate;\u000avarying vec2 twoStepsRightTextureCoordinate;\u000a\u000avoid main()\u000a{\u000agl_Position = position;\u000a\u000avec2 firstOffset = vec2(1.5 * texelWidthOffset, 1.5 * texelHeightOffset);\u000avec2 secondOffset = vec2(3.5 * texelWidthOffset, 3.5 * texelHeightOffset);\u000a\u000acenterTextureCoordinate = inputTextureCoordinate;\u000aoneStepLeftTextureCoordinate = inputTextureCoordinate - firstOffset;\u000atwoStepsLeftTextureCoordinate = inputTextureCoordinate - secondOffset;\u000aoneStepRightTextureCoordinate = inputTextureCoordinate + firstOffset;\u000atwoStepsRightTextureCoordinate = inputTextureCoordinate + secondOffset;\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageBoxBlurFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageBoxBlurFilter); }
		}

		protected GPUImageBoxBlurFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBoxBlurFilter']/constructor[@name='GPUImageBoxBlurFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageBoxBlurFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageBoxBlurFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBoxBlurFilter']/constructor[@name='GPUImageBoxBlurFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageBoxBlurFilter (float blurSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (blurSize);
				if (((object) this).GetType () != typeof (GPUImageBoxBlurFilter)) {
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

		static Delegate cb_setBlurSize_F;
#pragma warning disable 0169
		static Delegate GetSetBlurSize_FHandler ()
		{
			if (cb_setBlurSize_F == null)
				cb_setBlurSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBlurSize_F);
			return cb_setBlurSize_F;
		}

		static void n_SetBlurSize_F (IntPtr jnienv, IntPtr native__this, float blurSize)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBoxBlurFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBoxBlurFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlurSize (blurSize);
		}
#pragma warning restore 0169

		static IntPtr id_setBlurSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBoxBlurFilter']/method[@name='setBlurSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBlurSize", "(F)V", "GetSetBlurSize_FHandler")]
		public virtual unsafe void SetBlurSize (float blurSize)
		{
			if (id_setBlurSize_F == IntPtr.Zero)
				id_setBlurSize_F = JNIEnv.GetMethodID (class_ref, "setBlurSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (blurSize);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlurSize_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlurSize", "(F)V"), __args);
			} finally {
			}
		}

	}
}
