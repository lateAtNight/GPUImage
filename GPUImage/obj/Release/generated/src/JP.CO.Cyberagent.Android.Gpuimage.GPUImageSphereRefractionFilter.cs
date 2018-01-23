using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageSphereRefractionFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageSphereRefractionFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']/field[@name='SPHERE_FRAGMENT_SHADER']"
		[Register ("SPHERE_FRAGMENT_SHADER")]
		public const string SphereFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000auniform highp vec2 center;\u000auniform highp float radius;\u000auniform highp float aspectRatio;\u000auniform highp float refractiveIndex;\u000a\u000avoid main()\u000a{\u000ahighp vec2 textureCoordinateToUse = vec2(textureCoordinate.x, (textureCoordinate.y * aspectRatio + 0.5 - 0.5 * aspectRatio));\u000ahighp float distanceFromCenter = distance(center, textureCoordinateToUse);\u000alowp float checkForPresenceWithinSphere = step(distanceFromCenter, radius);\u000a\u000adistanceFromCenter = distanceFromCenter / radius;\u000a\u000ahighp float normalizedDepth = radius * sqrt(1.0 - distanceFromCenter * distanceFromCenter);\u000ahighp vec3 sphereNormal = normalize(vec3(textureCoordinateToUse - center, normalizedDepth));\u000a\u000ahighp vec3 refractedVector = refract(vec3(0.0, 0.0, -1.0), sphereNormal, refractiveIndex);\u000a\u000agl_FragColor = texture2D(inputImageTexture, (refractedVector.xy + 1.0) * 0.5) * checkForPresenceWithinSphere;     \u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageSphereRefractionFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageSphereRefractionFilter); }
		}

		protected GPUImageSphereRefractionFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']/constructor[@name='GPUImageSphereRefractionFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageSphereRefractionFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageSphereRefractionFilter)) {
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

		static IntPtr id_ctor_Landroid_graphics_PointF_FF;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']/constructor[@name='GPUImageSphereRefractionFilter' and count(parameter)=3 and parameter[1][@type='android.graphics.PointF'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(Landroid/graphics/PointF;FF)V", "")]
		public unsafe GPUImageSphereRefractionFilter (global::Android.Graphics.PointF center, float radius, float refractiveIndex)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (center);
				__args [1] = new JValue (radius);
				__args [2] = new JValue (refractiveIndex);
				if (((object) this).GetType () != typeof (GPUImageSphereRefractionFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/graphics/PointF;FF)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/graphics/PointF;FF)V", __args);
					return;
				}

				if (id_ctor_Landroid_graphics_PointF_FF == IntPtr.Zero)
					id_ctor_Landroid_graphics_PointF_FF = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/graphics/PointF;FF)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_graphics_PointF_FF, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_graphics_PointF_FF, __args);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSphereRefractionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSphereRefractionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF center = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_center, JniHandleOwnership.DoNotTransfer);
			__this.SetCenter (center);
		}
#pragma warning restore 0169

		static IntPtr id_setCenter_Landroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']/method[@name='setCenter' and count(parameter)=1 and parameter[1][@type='android.graphics.PointF']]"
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSphereRefractionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSphereRefractionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRadius (radius);
		}
#pragma warning restore 0169

		static IntPtr id_setRadius_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']/method[@name='setRadius' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_setRefractiveIndex_F;
#pragma warning disable 0169
		static Delegate GetSetRefractiveIndex_FHandler ()
		{
			if (cb_setRefractiveIndex_F == null)
				cb_setRefractiveIndex_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRefractiveIndex_F);
			return cb_setRefractiveIndex_F;
		}

		static void n_SetRefractiveIndex_F (IntPtr jnienv, IntPtr native__this, float refractiveIndex)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSphereRefractionFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageSphereRefractionFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRefractiveIndex (refractiveIndex);
		}
#pragma warning restore 0169

		static IntPtr id_setRefractiveIndex_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageSphereRefractionFilter']/method[@name='setRefractiveIndex' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRefractiveIndex", "(F)V", "GetSetRefractiveIndex_FHandler")]
		public virtual unsafe void SetRefractiveIndex (float refractiveIndex)
		{
			if (id_setRefractiveIndex_F == IntPtr.Zero)
				id_setRefractiveIndex_F = JNIEnv.GetMethodID (class_ref, "setRefractiveIndex", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (refractiveIndex);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRefractiveIndex_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRefractiveIndex", "(F)V"), __args);
			} finally {
			}
		}

	}
}
