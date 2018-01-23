using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWhiteBalanceFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageWhiteBalanceFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageWhiteBalanceFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWhiteBalanceFilter']/field[@name='WHITE_BALANCE_FRAGMENT_SHADER']"
		[Register ("WHITE_BALANCE_FRAGMENT_SHADER")]
		public const string WhiteBalanceFragmentShader = (string) "uniform sampler2D inputImageTexture;\u000avarying highp vec2 textureCoordinate;\u000a \u000auniform lowp float temperature;\u000auniform lowp float tint;\u000a\u000aconst lowp vec3 warmFilter = vec3(0.93, 0.54, 0.0);\u000a\u000aconst mediump mat3 RGBtoYIQ = mat3(0.299, 0.587, 0.114, 0.596, -0.274, -0.322, 0.212, -0.523, 0.311);\u000aconst mediump mat3 YIQtoRGB = mat3(1.0, 0.956, 0.621, 1.0, -0.272, -0.647, 1.0, -1.105, 1.702);\u000a\u000avoid main()\u000a{\u000a\u0009lowp vec4 source = texture2D(inputImageTexture, textureCoordinate);\u000a\u0009\u000a\u0009mediump vec3 yiq = RGBtoYIQ * source.rgb; //adjusting tint\u000a\u0009yiq.b = clamp(yiq.b + tint*0.5226*0.1, -0.5226, 0.5226);\u000a\u0009lowp vec3 rgb = YIQtoRGB * yiq;\u000a\u000a\u0009lowp vec3 processed = vec3(\u000a\u0009\u0009(rgb.r < 0.5 ? (2.0 * rgb.r * warmFilter.r) : (1.0 - 2.0 * (1.0 - rgb.r) * (1.0 - warmFilter.r))), //adjusting temperature\u000a\u0009\u0009(rgb.g < 0.5 ? (2.0 * rgb.g * warmFilter.g) : (1.0 - 2.0 * (1.0 - rgb.g) * (1.0 - warmFilter.g))), \u000a\u0009\u0009(rgb.b < 0.5 ? (2.0 * rgb.b * warmFilter.b) : (1.0 - 2.0 * (1.0 - rgb.b) * (1.0 - warmFilter.b))));\u000a\u000a\u0009gl_FragColor = vec4(mix(rgb, processed, temperature), source.a);\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageWhiteBalanceFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageWhiteBalanceFilter); }
		}

		protected GPUImageWhiteBalanceFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWhiteBalanceFilter']/constructor[@name='GPUImageWhiteBalanceFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageWhiteBalanceFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageWhiteBalanceFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWhiteBalanceFilter']/constructor[@name='GPUImageWhiteBalanceFilter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe GPUImageWhiteBalanceFilter (float temperature, float tint)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (temperature);
				__args [1] = new JValue (tint);
				if (((object) this).GetType () != typeof (GPUImageWhiteBalanceFilter)) {
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

		static Delegate cb_setTemperature_F;
#pragma warning disable 0169
		static Delegate GetSetTemperature_FHandler ()
		{
			if (cb_setTemperature_F == null)
				cb_setTemperature_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTemperature_F);
			return cb_setTemperature_F;
		}

		static void n_SetTemperature_F (IntPtr jnienv, IntPtr native__this, float temperature)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageWhiteBalanceFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageWhiteBalanceFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTemperature (temperature);
		}
#pragma warning restore 0169

		static IntPtr id_setTemperature_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWhiteBalanceFilter']/method[@name='setTemperature' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTemperature", "(F)V", "GetSetTemperature_FHandler")]
		public virtual unsafe void SetTemperature (float temperature)
		{
			if (id_setTemperature_F == IntPtr.Zero)
				id_setTemperature_F = JNIEnv.GetMethodID (class_ref, "setTemperature", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (temperature);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTemperature_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTemperature", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTint_F;
#pragma warning disable 0169
		static Delegate GetSetTint_FHandler ()
		{
			if (cb_setTint_F == null)
				cb_setTint_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTint_F);
			return cb_setTint_F;
		}

		static void n_SetTint_F (IntPtr jnienv, IntPtr native__this, float tint)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageWhiteBalanceFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageWhiteBalanceFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTint (tint);
		}
#pragma warning restore 0169

		static IntPtr id_setTint_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageWhiteBalanceFilter']/method[@name='setTint' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTint", "(F)V", "GetSetTint_FHandler")]
		public virtual unsafe void SetTint (float tint)
		{
			if (id_setTint_F == IntPtr.Zero)
				id_setTint_F = JNIEnv.GetMethodID (class_ref, "setTint", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (tint);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTint_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTint", "(F)V"), __args);
			} finally {
			}
		}

	}
}
