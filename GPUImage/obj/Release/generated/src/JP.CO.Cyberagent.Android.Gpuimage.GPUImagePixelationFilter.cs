using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePixelationFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImagePixelationFilter", DoNotGenerateAcw=true)]
	public partial class GPUImagePixelationFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePixelationFilter']/field[@name='PIXELATION_FRAGMENT_SHADER']"
		[Register ("PIXELATION_FRAGMENT_SHADER")]
		public const string PixelationFragmentShader = (string) "precision highp float;\u000avarying vec2 textureCoordinate;\u000auniform float imageWidthFactor;\u000auniform float imageHeightFactor;\u000auniform sampler2D inputImageTexture;\u000auniform float pixel;\u000avoid main()\u000a{\u000a  vec2 uv  = textureCoordinate.xy;\u000a  float dx = pixel * imageWidthFactor;\u000a  float dy = pixel * imageHeightFactor;\u000a  vec2 coord = vec2(dx * floor(uv.x / dx), dy * floor(uv.y / dy));\u000a  vec3 tc = texture2D(inputImageTexture, coord).xyz;\u000a  gl_FragColor = vec4(tc, 1.0);\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImagePixelationFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImagePixelationFilter); }
		}

		protected GPUImagePixelationFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePixelationFilter']/constructor[@name='GPUImagePixelationFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImagePixelationFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImagePixelationFilter)) {
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

		static Delegate cb_setPixel_F;
#pragma warning disable 0169
		static Delegate GetSetPixel_FHandler ()
		{
			if (cb_setPixel_F == null)
				cb_setPixel_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPixel_F);
			return cb_setPixel_F;
		}

		static void n_SetPixel_F (IntPtr jnienv, IntPtr native__this, float pixel)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImagePixelationFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImagePixelationFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixel (pixel);
		}
#pragma warning restore 0169

		static IntPtr id_setPixel_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImagePixelationFilter']/method[@name='setPixel' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPixel", "(F)V", "GetSetPixel_FHandler")]
		public virtual unsafe void SetPixel (float pixel)
		{
			if (id_setPixel_F == IntPtr.Zero)
				id_setPixel_F = JNIEnv.GetMethodID (class_ref, "setPixel", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (pixel);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPixel_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPixel", "(F)V"), __args);
			} finally {
			}
		}

	}
}
