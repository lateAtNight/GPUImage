using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageBulgeDistortionFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageBulgeDistortionFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']/field[@name='BULGE_FRAGMENT_SHADER']"
		[Register ("BULGE_FRAGMENT_SHADER")]
		public const string BulgeFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform highp float aspectRatio;\u000auniform highp vec2 center;\u000auniform highp float radius;\u000auniform highp float scale;\u000a\u000avoid main()\u000a{\u000ahighp vec2 textureCoordinateToUse = vec2(textureCoordinate.x, (textureCoordinate.y * aspectRatio + 0.5 - 0.5 * aspectRatio));\u000ahighp float dist = distance(center, textureCoordinateToUse);\u000atextureCoordinateToUse = textureCoordinate;\u000a\u000aif (dist < radius)\u000a{\u000atextureCoordinateToUse -= center;\u000ahighp float percent = 1.0 - ((radius - dist) / radius) * scale;\u000apercent = percent * percent;\u000a\u000atextureCoordinateToUse = textureCoordinateToUse * percent;\u000atextureCoordinateToUse += center;\u000a}\u000a\u000agl_FragColor = texture2D(inputImageTexture, textureCoordinateToUse );    \u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageBulgeDistortionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageBulgeDistortionFilter); }
		}

		protected GPUImageBulgeDistortionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']/constructor[@name='GPUImageBulgeDistortionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageBulgeDistortionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageBulgeDistortionFilter)) {
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

		static IntPtr id_ctor_FFLandroid_graphics_PointF_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']/constructor[@name='GPUImageBulgeDistortionFilter' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.PointF']]"
		[Register (".ctor", "(FFLandroid/graphics/PointF;)V", "")]
		public unsafe GPUImageBulgeDistortionFilter (float radius, float scale, global::Android.Graphics.PointF center)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (radius);
				__args [1] = new JValue (scale);
				__args [2] = new JValue (center);
				if (((object) this).GetType () != typeof (GPUImageBulgeDistortionFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(FFLandroid/graphics/PointF;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(FFLandroid/graphics/PointF;)V", __args);
					return;
				}

				if (id_ctor_FFLandroid_graphics_PointF_ == IntPtr.Zero)
					id_ctor_FFLandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "<init>", "(FFLandroid/graphics/PointF;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_FFLandroid_graphics_PointF_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_FFLandroid_graphics_PointF_, __args);
			} finally {
			}
		}

		static Delegate cb_setCenter_Landroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetCenter_Landroid_graphics_PointF_Handler ()
		{
			if (cb_setCenter_Landroid_graphics_PointF_ == null)
				cb_setCenter_Landroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenter_Landroid_graphics_PointF_);
			return cb_setCenter_Landroid_graphics_PointF_;
		}

		static void n_SetCenter_Landroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_center)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBulgeDistortionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBulgeDistortionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF center = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_center, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (center);
		}
#pragma warning restore 0169

		static IntPtr id_setCenter_Landroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
		[Register ("setCenter", "(Landroid/graphics/PointF;)V", "GetSetCenter_Landroid_graphics_PointF_Handler")]
		public virtual unsafe void SetCenter (global::Android.Graphics.PointF center)
		{
			if (id_setCenter_Landroid_graphics_PointF_ == IntPtr.Zero)
				id_setCenter_Landroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setCenter", "(Landroid/graphics/PointF;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (center);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setCenter_Landroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setCenter", "(Landroid/graphics/PointF;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setRadius_F;
#pragma warning disable 0169
		static Delegate GetSetRadius_FHandler ()
		{
			if (cb_setRadius_F == null)
				cb_setRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRadius_F);
			return cb_setRadius_F;
		}

		static void n_SetRadius_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBulgeDistortionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBulgeDistortionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		static IntPtr id_setRadius_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRadius", "(F)V", "GetSetRadius_FHandler")]
		public virtual unsafe void SetRadius (float radius)
		{
			if (id_setRadius_F == IntPtr.Zero)
				id_setRadius_F = JNIEnv.GetMethodID (class_ref, "setRadius", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (radius);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRadius_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRadius", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float scale)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBulgeDistortionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageBulgeDistortionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (scale);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageBulgeDistortionFilter']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
		public virtual unsafe void SetScale (float scale)
		{
			if (id_setScale_F == IntPtr.Zero)
				id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (scale);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setScale_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)V"), __args);
			} finally {
			}
		}

	}
}
