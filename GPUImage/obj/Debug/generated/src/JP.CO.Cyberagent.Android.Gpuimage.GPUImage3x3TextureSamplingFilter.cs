using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImage3x3TextureSamplingFilter", DoNotGenerateAcw=true)]
	public partial class GPUImage3x3TextureSamplingFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']/field[@name='THREE_X_THREE_TEXTURE_SAMPLING_VERTEX_SHADER']"
		[Register ("THREE_X_THREE_TEXTURE_SAMPLING_VERTEX_SHADER")]
		public const string ThreeXThreeTextureSamplingVertexShader = (string) "attribute vec4 position;\u000aattribute vec4 inputTextureCoordinate;\u000a\u000auniform highp float texelWidth; \u000auniform highp float texelHeight; \u000a\u000avarying vec2 textureCoordinate;\u000avarying vec2 leftTextureCoordinate;\u000avarying vec2 rightTextureCoordinate;\u000a\u000avarying vec2 topTextureCoordinate;\u000avarying vec2 topLeftTextureCoordinate;\u000avarying vec2 topRightTextureCoordinate;\u000a\u000avarying vec2 bottomTextureCoordinate;\u000avarying vec2 bottomLeftTextureCoordinate;\u000avarying vec2 bottomRightTextureCoordinate;\u000a\u000avoid main()\u000a{\u000a    gl_Position = position;\u000a\u000a    vec2 widthStep = vec2(texelWidth, 0.0);\u000a    vec2 heightStep = vec2(0.0, texelHeight);\u000a    vec2 widthHeightStep = vec2(texelWidth, texelHeight);\u000a    vec2 widthNegativeHeightStep = vec2(texelWidth, -texelHeight);\u000a\u000a    textureCoordinate = inputTextureCoordinate.xy;\u000a    leftTextureCoordinate = inputTextureCoordinate.xy - widthStep;\u000a    rightTextureCoordinate = inputTextureCoordinate.xy + widthStep;\u000a\u000a    topTextureCoordinate = inputTextureCoordinate.xy - heightStep;\u000a    topLeftTextureCoordinate = inputTextureCoordinate.xy - widthHeightStep;\u000a    topRightTextureCoordinate = inputTextureCoordinate.xy + widthNegativeHeightStep;\u000a\u000a    bottomTextureCoordinate = inputTextureCoordinate.xy + heightStep;\u000a    bottomLeftTextureCoordinate = inputTextureCoordinate.xy - widthNegativeHeightStep;\u000a    bottomRightTextureCoordinate = inputTextureCoordinate.xy + widthHeightStep;\u000a}";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImage3x3TextureSamplingFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImage3x3TextureSamplingFilter); }
		}

		protected GPUImage3x3TextureSamplingFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']/constructor[@name='GPUImage3x3TextureSamplingFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImage3x3TextureSamplingFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImage3x3TextureSamplingFilter)) {
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

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']/constructor[@name='GPUImage3x3TextureSamplingFilter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe GPUImage3x3TextureSamplingFilter (string fragmentShader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_fragmentShader);
				if (((object) this).GetType () != typeof (GPUImage3x3TextureSamplingFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fragmentShader);
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
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLineSize (size);
		}
#pragma warning restore 0169

		static IntPtr id_setLineSize_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']/method[@name='setLineSize' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_setTexelHeight_F;
#pragma warning disable 0169
		static Delegate GetSetTexelHeight_FHandler ()
		{
			if (cb_setTexelHeight_F == null)
				cb_setTexelHeight_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTexelHeight_F);
			return cb_setTexelHeight_F;
		}

		static void n_SetTexelHeight_F (IntPtr jnienv, IntPtr native__this, float texelHeight)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTexelHeight (texelHeight);
		}
#pragma warning restore 0169

		static IntPtr id_setTexelHeight_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']/method[@name='setTexelHeight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTexelHeight", "(F)V", "GetSetTexelHeight_FHandler")]
		public virtual unsafe void SetTexelHeight (float texelHeight)
		{
			if (id_setTexelHeight_F == IntPtr.Zero)
				id_setTexelHeight_F = JNIEnv.GetMethodID (class_ref, "setTexelHeight", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (texelHeight);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTexelHeight_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTexelHeight", "(F)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setTexelWidth_F;
#pragma warning disable 0169
		static Delegate GetSetTexelWidth_FHandler ()
		{
			if (cb_setTexelWidth_F == null)
				cb_setTexelWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTexelWidth_F);
			return cb_setTexelWidth_F;
		}

		static void n_SetTexelWidth_F (IntPtr jnienv, IntPtr native__this, float texelWidth)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImage3x3TextureSamplingFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTexelWidth (texelWidth);
		}
#pragma warning restore 0169

		static IntPtr id_setTexelWidth_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImage3x3TextureSamplingFilter']/method[@name='setTexelWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setTexelWidth", "(F)V", "GetSetTexelWidth_FHandler")]
		public virtual unsafe void SetTexelWidth (float texelWidth)
		{
			if (id_setTexelWidth_F == IntPtr.Zero)
				id_setTexelWidth_F = JNIEnv.GetMethodID (class_ref, "setTexelWidth", "(F)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (texelWidth);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTexelWidth_F, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setTexelWidth", "(F)V"), __args);
			} finally {
			}
		}

	}
}
