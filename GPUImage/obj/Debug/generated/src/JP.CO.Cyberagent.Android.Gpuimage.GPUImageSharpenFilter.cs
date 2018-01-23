using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSharpenFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageSharpenFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageSharpenFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSharpenFilter']/field[@name='SHARPEN_FRAGMENT_SHADER']"
		[Register ("SHARPEN_FRAGMENT_SHADER")]
		public const string SharpenFragmentShader = (string) "precision highp float;\u000a\u000avarying highp vec2 textureCoordinate;\u000avarying highp vec2 leftTextureCoordinate;\u000avarying highp vec2 rightTextureCoordinate; \u000avarying highp vec2 topTextureCoordinate;\u000avarying highp vec2 bottomTextureCoordinate;\u000a\u000avarying highp float centerMultiplier;\u000avarying highp float edgeMultiplier;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000a    mediump vec3 textureColor = texture2D(inputImageTexture, textureCoordinate).rgb;\u000a    mediump vec3 leftTextureColor = texture2D(inputImageTexture, leftTextureCoordinate).rgb;\u000a    mediump vec3 rightTextureColor = texture2D(inputImageTexture, rightTextureCoordinate).rgb;\u000a    mediump vec3 topTextureColor = texture2D(inputImageTexture, topTextureCoordinate).rgb;\u000a    mediump vec3 bottomTextureColor = texture2D(inputImageTexture, bottomTextureCoordinate).rgb;\u000a\u000a    gl_FragColor = vec4((textureColor * centerMultiplier - (leftTextureColor * edgeMultiplier + rightTextureColor * edgeMultiplier + topTextureColor * edgeMultiplier + bottomTextureColor * edgeMultiplier)), texture2D(inputImageTexture, bottomTextureCoordinate).w);\u000a}";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSharpenFilter']/field[@name='SHARPEN_VERTEX_SHADER']"
		[Register ("SHARPEN_VERTEX_SHADER")]
		public const string SharpenVertexShader = (string) "attribute vec4 position;\u000aattribute vec4 inputTextureCoordinate;\u000a\u000auniform float imageWidthFactor; \u000auniform float imageHeightFactor; \u000auniform float sharpness;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate; \u000avarying vec2 topTextureCoordinate;\u000avarying vec2 bottomTextureCoordinate;\u000a\u000avarying float centerMultiplier;\u000avarying float edgeMultiplier;\u000a\u000avoid main()\u000a{\u000a    gl_Position = position;\u000a    \u000a    mediump vec2 widthStep = vec2(imageWidthFactor, 0.0);\u000a    mediump vec2 heightStep = vec2(0.0, imageHeightFactor);\u000a    \u000a    textureCoordinate = inputTextureCoordinate.xy;\u000a    leftTextureCoordinate = inputTextureCoordinate.xy - widthStep;\u000a    rightTextureCoordinate = inputTextureCoordinate.xy + widthStep;\u000a    topTextureCoordinate = inputTextureCoordinate.xy + heightStep;     \u000a    bottomTextureCoordinate = inputTextureCoordinate.xy - heightStep;\u000a    \u000a    centerMultiplier = 1.0 + 4.0 * sharpness;\u000a    edgeMultiplier = sharpness;\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageSharpenFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageSharpenFilter); }
		}

		protected GPUImageSharpenFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSharpenFilter']/constructor[@name='GPUImageSharpenFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageSharpenFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageSharpenFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSharpenFilter']/constructor[@name='GPUImageSharpenFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageSharpenFilter (float sharpness)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sharpness);
				if (((object) this).GetType () != typeof (GPUImageSharpenFilter)) {
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

		static Delegate cb_setSharpness_F;
#pragma warning disable 0169
		static Delegate GetSetSharpness_FHandler ()
		{
			if (cb_setSharpness_F == null)
				cb_setSharpness_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSharpness_F);
			return cb_setSharpness_F;
		}

		static void n_SetSharpness_F (IntPtr jnienv, IntPtr native__this, float sharpness)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSharpenFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSharpenFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSharpness (sharpness);
		}
#pragma warning restore 0169

		static IntPtr id_setSharpness_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSharpenFilter']/method[@name='setSharpness' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setSharpness", "(F)V", "GetSetSharpness_FHandler")]
		public virtual unsafe void SetSharpness (float sharpness)
		{
			if (id_setSharpness_F == IntPtr.Zero)
				id_setSharpness_F = JNIEnv.GetMethodID (class_ref, "setSharpness", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (sharpness);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setSharpness_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setSharpness", "(F)V"), __args);
			} finally {
			}
		}

	}
}
