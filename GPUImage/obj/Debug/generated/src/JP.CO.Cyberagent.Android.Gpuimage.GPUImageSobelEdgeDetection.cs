using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelEdgeDetection']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageSobelEdgeDetection", DoNotGenerateAcw=true)]
	public partial class GPUImageSobelEdgeDetection : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilterGroup {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelEdgeDetection']/field[@name='SOBEL_EDGE_DETECTION']"
		[Register ("SOBEL_EDGE_DETECTION")]
		public const string SobelEdgeDetection = (string) "precision mediump float;\u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000a    float bottomLeftIntensity = texture2D(inputImageTexture, bottomLeftTextureCoordinate).r;\u000a    float topRightIntensity = texture2D(inputImageTexture, topRightTextureCoordinate).r;\u000a    float topLeftIntensity = texture2D(inputImageTexture, topLeftTextureCoordinate).r;\u000a    float bottomRightIntensity = texture2D(inputImageTexture, bottomRightTextureCoordinate).r;\u000a    float leftIntensity = texture2D(inputImageTexture, leftTextureCoordinate).r;\u000a    float rightIntensity = texture2D(inputImageTexture, rightTextureCoordinate).r;\u000a    float bottomIntensity = texture2D(inputImageTexture, bottomTextureCoordinate).r;\u000a    float topIntensity = texture2D(inputImageTexture, topTextureCoordinate).r;\u000a    float h = -topLeftIntensity - 2.0 * topIntensity - topRightIntensity + bottomLeftIntensity + 2.0 * bottomIntensity + bottomRightIntensity;\u000a    float v = -bottomLeftIntensity - 2.0 * leftIntensity - topLeftIntensity + bottomRightIntensity + 2.0 * rightIntensity + topRightIntensity;\u000a\u000a    float mag = length(vec2(h, v));\u000a\u000a    gl_FragColor = vec4(vec3(mag), 1.0);\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageSobelEdgeDetection", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageSobelEdgeDetection); }
		}

		protected GPUImageSobelEdgeDetection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelEdgeDetection']/constructor[@name='GPUImageSobelEdgeDetection' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageSobelEdgeDetection ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageSobelEdgeDetection)) {
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

		static Delegate cb_setLineSize_F;
#pragma warning disable 0169
		static Delegate GetSetLineSize_FHandler ()
		{
			if (cb_setLineSize_F == null)
				cb_setLineSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineSize_F);
			return cb_setLineSize_F;
		}

		static void n_SetLineSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSobelEdgeDetection __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSobelEdgeDetection> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLineSize (size);
		}
#pragma warning restore 0169

		static IntPtr id_setLineSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSobelEdgeDetection']/method[@name='setLineSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setLineSize", "(F)V", "GetSetLineSize_FHandler")]
		public virtual unsafe void SetLineSize (float size)
		{
			if (id_setLineSize_F == IntPtr.Zero)
				id_setLineSize_F = JNIEnv.GetMethodID (class_ref, "setLineSize", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (size);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLineSize_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setLineSize", "(F)V"), __args);
			} finally {
			}
		}

	}
}
