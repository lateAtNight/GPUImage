using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageKuwaharaFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageKuwaharaFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageKuwaharaFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageKuwaharaFilter']/field[@name='KUWAHARA_FRAGMENT_SHADER']"
		[Register ("KUWAHARA_FRAGMENT_SHADER")]
		public const string KuwaharaFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000auniform sampler2D inputImageTexture;\u000auniform int radius;\u000a\u000aprecision highp float;\u000a\u000aconst vec2 src_size = vec2 (1.0 / 768.0, 1.0 / 1024.0);\u000a\u000avoid main (void) \u000a{\u000avec2 uv = textureCoordinate;\u000afloat n = float((radius + 1) * (radius + 1));\u000aint i; int j;\u000avec3 m0 = vec3(0.0); vec3 m1 = vec3(0.0); vec3 m2 = vec3(0.0); vec3 m3 = vec3(0.0);\u000avec3 s0 = vec3(0.0); vec3 s1 = vec3(0.0); vec3 s2 = vec3(0.0); vec3 s3 = vec3(0.0);\u000avec3 c;\u000a\u000afor (j = -radius; j <= 0; ++j)  {\u000afor (i = -radius; i <= 0; ++i)  {\u000ac = texture2D(inputImageTexture, uv + vec2(i,j) * src_size).rgb;\u000am0 += c;\u000as0 += c * c;\u000a}\u000a}\u000a\u000afor (j = -radius; j <= 0; ++j)  {\u000afor (i = 0; i <= radius; ++i)  {\u000ac = texture2D(inputImageTexture, uv + vec2(i,j) * src_size).rgb;\u000am1 += c;\u000as1 += c * c;\u000a}\u000a}\u000a\u000afor (j = 0; j <= radius; ++j)  {\u000afor (i = 0; i <= radius; ++i)  {\u000ac = texture2D(inputImageTexture, uv + vec2(i,j) * src_size).rgb;\u000am2 += c;\u000as2 += c * c;\u000a}\u000a}\u000a\u000afor (j = 0; j <= radius; ++j)  {\u000afor (i = -radius; i <= 0; ++i)  {\u000ac = texture2D(inputImageTexture, uv + vec2(i,j) * src_size).rgb;\u000am3 += c;\u000as3 += c * c;\u000a}\u000a}\u000a\u000a\u000afloat min_sigma2 = 1e+2;\u000am0 /= n;\u000as0 = abs(s0 / n - m0 * m0);\u000a\u000afloat sigma2 = s0.r + s0.g + s0.b;\u000aif (sigma2 < min_sigma2) {\u000amin_sigma2 = sigma2;\u000agl_FragColor = vec4(m0, 1.0);\u000a}\u000a\u000am1 /= n;\u000as1 = abs(s1 / n - m1 * m1);\u000a\u000asigma2 = s1.r + s1.g + s1.b;\u000aif (sigma2 < min_sigma2) {\u000amin_sigma2 = sigma2;\u000agl_FragColor = vec4(m1, 1.0);\u000a}\u000a\u000am2 /= n;\u000as2 = abs(s2 / n - m2 * m2);\u000a\u000asigma2 = s2.r + s2.g + s2.b;\u000aif (sigma2 < min_sigma2) {\u000amin_sigma2 = sigma2;\u000agl_FragColor = vec4(m2, 1.0);\u000a}\u000a\u000am3 /= n;\u000as3 = abs(s3 / n - m3 * m3);\u000a\u000asigma2 = s3.r + s3.g + s3.b;\u000aif (sigma2 < min_sigma2) {\u000amin_sigma2 = sigma2;\u000agl_FragColor = vec4(m3, 1.0);\u000a}\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageKuwaharaFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageKuwaharaFilter); }
		}

		protected GPUImageKuwaharaFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageKuwaharaFilter']/constructor[@name='GPUImageKuwaharaFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageKuwaharaFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageKuwaharaFilter)) {
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

		static IntPtr id_ctor_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageKuwaharaFilter']/constructor[@name='GPUImageKuwaharaFilter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe GPUImageKuwaharaFilter (int radius)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (radius);
				if (((object) this).GetType () != typeof (GPUImageKuwaharaFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(I)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(I)V", __args);
					return;
				}

				if (id_ctor_I == IntPtr.Zero)
					id_ctor_I = JNIEnv.GetMethodID (class_ref, "<init>", "(I)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_I, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_I, __args);
			} finally {
			}
		}

		static Delegate cb_setRadius_I;
#pragma warning disable 0169
		static Delegate GetSetRadius_IHandler ()
		{
			if (cb_setRadius_I == null)
				cb_setRadius_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetRadius_I);
			return cb_setRadius_I;
		}

		static void n_SetRadius_I (IntPtr jnienv, IntPtr native__this, int radius)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageKuwaharaFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageKuwaharaFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		static IntPtr id_setRadius_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageKuwaharaFilter']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRadius", "(I)V", "GetSetRadius_IHandler")]
		public virtual unsafe void SetRadius (int radius)
		{
			if (id_setRadius_I == IntPtr.Zero)
				id_setRadius_I = JNIEnv.GetMethodID (class_ref, "setRadius", "(I)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (radius);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRadius", "(I)V"), __args);
			} finally {
			}
		}

	}
}
