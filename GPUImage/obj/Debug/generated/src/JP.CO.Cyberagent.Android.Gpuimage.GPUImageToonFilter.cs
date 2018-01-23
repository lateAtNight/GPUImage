using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToonFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageToonFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageToonFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToonFilter']/field[@name='TOON_FRAGMENT_SHADER']"
		[Register ("TOON_FRAGMENT_SHADER")]
		public const string ToonFragmentShader = (string) "precision highp float;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform highp float intensity;\u000auniform highp float threshold;\u000auniform highp float quantizationLevels;\u000a\u000aconst highp vec3 W = vec3(0.2125, 0.7154, 0.0721);\u000a\u000avoid main()\u000a{\u000avec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a\u000afloat bottomLeftIntensity = texture2D(inputImageTexture, bottomLeftTextureCoordinate).r;\u000afloat topRightIntensity = texture2D(inputImageTexture, topRightTextureCoordinate).r;\u000afloat topLeftIntensity = texture2D(inputImageTexture, topLeftTextureCoordinate).r;\u000afloat bottomRightIntensity = texture2D(inputImageTexture, bottomRightTextureCoordinate).r;\u000afloat leftIntensity = texture2D(inputImageTexture, leftTextureCoordinate).r;\u000afloat rightIntensity = texture2D(inputImageTexture, rightTextureCoordinate).r;\u000afloat bottomIntensity = texture2D(inputImageTexture, bottomTextureCoordinate).r;\u000afloat topIntensity = texture2D(inputImageTexture, topTextureCoordinate).r;\u000afloat h = -topLeftIntensity - 2.0 * topIntensity - topRightIntensity + bottomLeftIntensity + 2.0 * bottomIntensity + bottomRightIntensity;\u000afloat v = -bottomLeftIntensity - 2.0 * leftIntensity - topLeftIntensity + bottomRightIntensity + 2.0 * rightIntensity + topRightIntensity;\u000a\u000afloat mag = length(vec2(h, v));\u000a\u000avec3 posterizedImageColor = floor((textureColor.rgb * quantizationLevels) + 0.5) / quantizationLevels;\u000a\u000afloat thresholdTest = 1.0 - step(threshold, mag);\u000a\u000agl_FragColor = vec4(posterizedImageColor * thresholdTest, textureColor.a);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageToonFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageToonFilter); }
		}

		protected GPUImageToonFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToonFilter']/constructor[@name='GPUImageToonFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageToonFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageToonFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToonFilter']/constructor[@name='GPUImageToonFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe GPUImageToonFilter (float threshold, float quantizationLevels)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (threshold);
				__args [1] = new JValue (quantizationLevels);
				if (((object) this).GetType () != typeof (GPUImageToonFilter)) {
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

		static Delegate cb_setQuantizationLevels_F;
#pragma warning disable 0169
		static Delegate GetSetQuantizationLevels_FHandler ()
		{
			if (cb_setQuantizationLevels_F == null)
				cb_setQuantizationLevels_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetQuantizationLevels_F);
			return cb_setQuantizationLevels_F;
		}

		static void n_SetQuantizationLevels_F (IntPtr jnienv, IntPtr native__this, float quantizationLevels)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetQuantizationLevels (quantizationLevels);
		}
#pragma warning restore 0169

		static IntPtr id_setQuantizationLevels_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToonFilter']/method[@name='setQuantizationLevels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setQuantizationLevels", "(F)V", "GetSetQuantizationLevels_FHandler")]
		public virtual unsafe void SetQuantizationLevels (float quantizationLevels)
		{
			if (id_setQuantizationLevels_F == IntPtr.Zero)
				id_setQuantizationLevels_F = JNIEnv.GetMethodID (class_ref, "setQuantizationLevels", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (quantizationLevels);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setQuantizationLevels_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setQuantizationLevels", "(F)V"), __args);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToonFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToonFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetThreshold (threshold);
		}
#pragma warning restore 0169

		static IntPtr id_setThreshold_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToonFilter']/method[@name='setThreshold' and count(parameter)=1 and parameter[1][@type='float']]"
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
