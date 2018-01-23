using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageGaussianBlurFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageGaussianBlurFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']/field[@name='FRAGMENT_SHADER']"
		[Register ("FRAGMENT_SHADER")]
		public const string FragmentShader = (string) "uniform sampler2D inputImageTexture;\u000a\u000aconst lowp int GAUSSIAN_SAMPLES = 9;\u000a\u000avarying highp vec2 textureCoordinate;\u000avarying highp vec2 blurCoordinates[GAUSSIAN_SAMPLES];\u000a\u000avoid main()\u000a{\u000a\u0009lowp vec3 sum = vec3(0.0);\u000a   lowp vec4 fragColor=texture2D(inputImageTexture,textureCoordinate);\u000a\u0009\u000a    sum += texture2D(inputImageTexture, blurCoordinates[0]).rgb * 0.05;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[1]).rgb * 0.09;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[2]).rgb * 0.12;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[3]).rgb * 0.15;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[4]).rgb * 0.18;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[5]).rgb * 0.15;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[6]).rgb * 0.12;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[7]).rgb * 0.09;\u000a    sum += texture2D(inputImageTexture, blurCoordinates[8]).rgb * 0.05;\u000a\u000a\u0009gl_FragColor = vec4(sum,fragColor.a);\u000a}";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']/field[@name='VERTEX_SHADER']"
		[Register ("VERTEX_SHADER")]
		public const string VertexShader = (string) "attribute vec4 position;\u000aattribute vec4 inputTextureCoordinate;\u000a\u000aconst int GAUSSIAN_SAMPLES = 9;\u000a\u000auniform float texelWidthOffset;\u000auniform float texelHeightOffset;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 blurCoordinates[GAUSSIAN_SAMPLES];\u000a\u000avoid main()\u000a{\u000a\u0009gl_Position = position;\u000a\u0009textureCoordinate = inputTextureCoordinate.xy;\u000a\u0009\u000a\u0009// Calculate the positions for the blur\u000a\u0009int multiplier = 0;\u000a\u0009vec2 blurStep;\u000a   vec2 singleStepOffset = vec2(texelHeightOffset, texelWidthOffset);\u000a    \u000a\u0009for (int i = 0; i < GAUSSIAN_SAMPLES; i++)\u000a   {\u000a\u0009\u0009multiplier = (i - ((GAUSSIAN_SAMPLES - 1) / 2));\u000a       // Blur in x (horizontal)\u000a       blurStep = float(multiplier) * singleStepOffset;\u000a\u0009\u0009blurCoordinates[i] = inputTextureCoordinate.xy + blurStep;\u000a\u0009}\u000a}\u000a";

		static IntPtr mBlurSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']/field[@name='mBlurSize']"
		[Register ("mBlurSize")]
		protected float MBlurSize {
			get {
				if (mBlurSize_jfieldId == IntPtr.Zero)
					mBlurSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mBlurSize", "F");
				return JNIEnv.GetFloatField (((global::Java.Lang.Object) this).Handle, mBlurSize_jfieldId);
			}
			set {
				if (mBlurSize_jfieldId == IntPtr.Zero)
					mBlurSize_jfieldId = JNIEnv.GetFieldID (class_ref, "mBlurSize", "F");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBlurSize_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageGaussianBlurFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageGaussianBlurFilter); }
		}

		protected GPUImageGaussianBlurFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']/constructor[@name='GPUImageGaussianBlurFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageGaussianBlurFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageGaussianBlurFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']/constructor[@name='GPUImageGaussianBlurFilter' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe GPUImageGaussianBlurFilter (float blurSize)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (blurSize);
				if (((object) this).GetType () != typeof (GPUImageGaussianBlurFilter)) {
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageGaussianBlurFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageGaussianBlurFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBlurSize (blurSize);
		}
#pragma warning restore 0169

		static IntPtr id_setBlurSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageGaussianBlurFilter']/method[@name='setBlurSize' and count(parameter)=1 and parameter[1][@type='float']]"
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
