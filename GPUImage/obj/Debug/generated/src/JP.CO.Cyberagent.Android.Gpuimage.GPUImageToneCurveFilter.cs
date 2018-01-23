using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageToneCurveFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageToneCurveFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/field[@name='TONE_CURVE_FRAGMENT_SHADER']"
		[Register ("TONE_CURVE_FRAGMENT_SHADER")]
		public const string ToneCurveFragmentShader = (string) " varying highp vec2 textureCoordinate;\u000a uniform sampler2D inputImageTexture;\u000a uniform sampler2D toneCurveTexture;\u000a\u000a void main()\u000a {\u000a     lowp vec4 textureColor = texture2D(inputImageTexture, textureCoordinate);\u000a     lowp float redCurveValue = texture2D(toneCurveTexture, vec2(textureColor.r, 0.0)).r;\u000a     lowp float greenCurveValue = texture2D(toneCurveTexture, vec2(textureColor.g, 0.0)).g;\u000a     lowp float blueCurveValue = texture2D(toneCurveTexture, vec2(textureColor.b, 0.0)).b;\u000a\u000a     gl_FragColor = vec4(redCurveValue, greenCurveValue, blueCurveValue, textureColor.a);\u000a }";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageToneCurveFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageToneCurveFilter); }
		}

		protected GPUImageToneCurveFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/constructor[@name='GPUImageToneCurveFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageToneCurveFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageToneCurveFilter)) {
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

		static Delegate cb_setBlueControlPoints_arrayLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetBlueControlPoints_arrayLandroid_graphics_PointF_Handler ()
		{
			if (cb_setBlueControlPoints_arrayLandroid_graphics_PointF_ == null)
				cb_setBlueControlPoints_arrayLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBlueControlPoints_arrayLandroid_graphics_PointF_);
			return cb_setBlueControlPoints_arrayLandroid_graphics_PointF_;
		}

		static void n_SetBlueControlPoints_arrayLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_points)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF[] points = (global::Android.Graphics.PointF[]) JNIEnv.GetArray (native_points, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.PointF));
			__this.SetBlueControlPoints (points);
			if (points != null)
				JNIEnv.CopyArray (points, native_points);
		}
#pragma warning restore 0169

		static IntPtr id_setBlueControlPoints_arrayLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/method[@name='setBlueControlPoints' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF[]']]"
		[Register ("setBlueControlPoints", "([Landroid/graphics/PointF;)V", "GetSetBlueControlPoints_arrayLandroid_graphics_PointF_Handler")]
		public virtual unsafe void SetBlueControlPoints (global::Android.Graphics.PointF[] points)
		{
			if (id_setBlueControlPoints_arrayLandroid_graphics_PointF_ == IntPtr.Zero)
				id_setBlueControlPoints_arrayLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setBlueControlPoints", "([Landroid/graphics/PointF;)V");
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_points);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBlueControlPoints_arrayLandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBlueControlPoints", "([Landroid/graphics/PointF;)V"), __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
			}
		}

		static Delegate cb_setFromCurveFileInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetFromCurveFileInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_setFromCurveFileInputStream_Ljava_io_InputStream_ == null)
				cb_setFromCurveFileInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFromCurveFileInputStream_Ljava_io_InputStream_);
			return cb_setFromCurveFileInputStream_Ljava_io_InputStream_;
		}

		static void n_SetFromCurveFileInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_input)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream input = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_input, JniHandleOwnership.DoNotTransfer);
			__this.SetFromCurveFileInputStream (input);
		}
#pragma warning restore 0169

		static IntPtr id_setFromCurveFileInputStream_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/method[@name='setFromCurveFileInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setFromCurveFileInputStream", "(Ljava/io/InputStream;)V", "GetSetFromCurveFileInputStream_Ljava_io_InputStream_Handler")]
		public virtual unsafe void SetFromCurveFileInputStream (global::System.IO.Stream input)
		{
			if (id_setFromCurveFileInputStream_Ljava_io_InputStream_ == IntPtr.Zero)
				id_setFromCurveFileInputStream_Ljava_io_InputStream_ = JNIEnv.GetMethodID (class_ref, "setFromCurveFileInputStream", "(Ljava/io/InputStream;)V");
			IntPtr native_input = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (input);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_input);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFromCurveFileInputStream_Ljava_io_InputStream_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFromCurveFileInputStream", "(Ljava/io/InputStream;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_input);
			}
		}

		static Delegate cb_setGreenControlPoints_arrayLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetGreenControlPoints_arrayLandroid_graphics_PointF_Handler ()
		{
			if (cb_setGreenControlPoints_arrayLandroid_graphics_PointF_ == null)
				cb_setGreenControlPoints_arrayLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGreenControlPoints_arrayLandroid_graphics_PointF_);
			return cb_setGreenControlPoints_arrayLandroid_graphics_PointF_;
		}

		static void n_SetGreenControlPoints_arrayLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_points)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF[] points = (global::Android.Graphics.PointF[]) JNIEnv.GetArray (native_points, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.PointF));
			__this.SetGreenControlPoints (points);
			if (points != null)
				JNIEnv.CopyArray (points, native_points);
		}
#pragma warning restore 0169

		static IntPtr id_setGreenControlPoints_arrayLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/method[@name='setGreenControlPoints' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF[]']]"
		[Register ("setGreenControlPoints", "([Landroid/graphics/PointF;)V", "GetSetGreenControlPoints_arrayLandroid_graphics_PointF_Handler")]
		public virtual unsafe void SetGreenControlPoints (global::Android.Graphics.PointF[] points)
		{
			if (id_setGreenControlPoints_arrayLandroid_graphics_PointF_ == IntPtr.Zero)
				id_setGreenControlPoints_arrayLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setGreenControlPoints", "([Landroid/graphics/PointF;)V");
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_points);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setGreenControlPoints_arrayLandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setGreenControlPoints", "([Landroid/graphics/PointF;)V"), __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
			}
		}

		static Delegate cb_setRedControlPoints_arrayLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetRedControlPoints_arrayLandroid_graphics_PointF_Handler ()
		{
			if (cb_setRedControlPoints_arrayLandroid_graphics_PointF_ == null)
				cb_setRedControlPoints_arrayLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRedControlPoints_arrayLandroid_graphics_PointF_);
			return cb_setRedControlPoints_arrayLandroid_graphics_PointF_;
		}

		static void n_SetRedControlPoints_arrayLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_points)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF[] points = (global::Android.Graphics.PointF[]) JNIEnv.GetArray (native_points, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.PointF));
			__this.SetRedControlPoints (points);
			if (points != null)
				JNIEnv.CopyArray (points, native_points);
		}
#pragma warning restore 0169

		static IntPtr id_setRedControlPoints_arrayLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/method[@name='setRedControlPoints' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF[]']]"
		[Register ("setRedControlPoints", "([Landroid/graphics/PointF;)V", "GetSetRedControlPoints_arrayLandroid_graphics_PointF_Handler")]
		public virtual unsafe void SetRedControlPoints (global::Android.Graphics.PointF[] points)
		{
			if (id_setRedControlPoints_arrayLandroid_graphics_PointF_ == IntPtr.Zero)
				id_setRedControlPoints_arrayLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setRedControlPoints", "([Landroid/graphics/PointF;)V");
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_points);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRedControlPoints_arrayLandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRedControlPoints", "([Landroid/graphics/PointF;)V"), __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
			}
		}

		static Delegate cb_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetRgbCompositeControlPoints_arrayLandroid_graphics_PointF_Handler ()
		{
			if (cb_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_ == null)
				cb_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRgbCompositeControlPoints_arrayLandroid_graphics_PointF_);
			return cb_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_;
		}

		static void n_SetRgbCompositeControlPoints_arrayLandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_points)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageToneCurveFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF[] points = (global::Android.Graphics.PointF[]) JNIEnv.GetArray (native_points, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Graphics.PointF));
			__this.SetRgbCompositeControlPoints (points);
			if (points != null)
				JNIEnv.CopyArray (points, native_points);
		}
#pragma warning restore 0169

		static IntPtr id_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageToneCurveFilter']/method[@name='setRgbCompositeControlPoints' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF[]']]"
		[Register ("setRgbCompositeControlPoints", "([Landroid/graphics/PointF;)V", "GetSetRgbCompositeControlPoints_arrayLandroid_graphics_PointF_Handler")]
		public virtual unsafe void SetRgbCompositeControlPoints (global::Android.Graphics.PointF[] points)
		{
			if (id_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_ == IntPtr.Zero)
				id_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setRgbCompositeControlPoints", "([Landroid/graphics/PointF;)V");
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_points);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRgbCompositeControlPoints_arrayLandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRgbCompositeControlPoints", "([Landroid/graphics/PointF;)V"), __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
			}
		}

	}
}
