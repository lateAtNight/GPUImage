using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageRGBDilationFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageRGBDilationFilter : global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageTwoPassTextureSamplingFilter {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='FRAGMENT_SHADER_1']"
		[Register ("FRAGMENT_SHADER_1")]
		public const string FragmentShader1 = (string) "precision highp float;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000alowp vec4 centerIntensity = texture2D(inputImageTexture, centerTextureCoordinate);\u000alowp vec4 oneStepPositiveIntensity = texture2D(inputImageTexture, oneStepPositiveTextureCoordinate);\u000alowp vec4 oneStepNegativeIntensity = texture2D(inputImageTexture, oneStepNegativeTextureCoordinate);\u000a\u000alowp vec4 maxValue = max(centerIntensity, oneStepPositiveIntensity);\u000a\u000agl_FragColor = max(maxValue, oneStepNegativeIntensity);\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='FRAGMENT_SHADER_2']"
		[Register ("FRAGMENT_SHADER_2")]
		public const string FragmentShader2 = (string) "precision highp float;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000avarying vec2 twoStepsPositiveTextureCoordinate;\u000avarying vec2 twoStepsNegativeTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000alowp vec4 centerIntensity = texture2D(inputImageTexture, centerTextureCoordinate);\u000alowp vec4 oneStepPositiveIntensity = texture2D(inputImageTexture, oneStepPositiveTextureCoordinate);\u000alowp vec4 oneStepNegativeIntensity = texture2D(inputImageTexture, oneStepNegativeTextureCoordinate);\u000alowp vec4 twoStepsPositiveIntensity = texture2D(inputImageTexture, twoStepsPositiveTextureCoordinate);\u000alowp vec4 twoStepsNegativeIntensity = texture2D(inputImageTexture, twoStepsNegativeTextureCoordinate);\u000a\u000alowp vec4 maxValue = max(centerIntensity, oneStepPositiveIntensity);\u000amaxValue = max(maxValue, oneStepNegativeIntensity);\u000amaxValue = max(maxValue, twoStepsPositiveIntensity);\u000amaxValue = max(maxValue, twoStepsNegativeIntensity);\u000a\u000agl_FragColor = max(maxValue, twoStepsNegativeIntensity);\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='FRAGMENT_SHADER_3']"
		[Register ("FRAGMENT_SHADER_3")]
		public const string FragmentShader3 = (string) "precision highp float;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000avarying vec2 twoStepsPositiveTextureCoordinate;\u000avarying vec2 twoStepsNegativeTextureCoordinate;\u000avarying vec2 threeStepsPositiveTextureCoordinate;\u000avarying vec2 threeStepsNegativeTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000alowp vec4 centerIntensity = texture2D(inputImageTexture, centerTextureCoordinate);\u000alowp vec4 oneStepPositiveIntensity = texture2D(inputImageTexture, oneStepPositiveTextureCoordinate);\u000alowp vec4 oneStepNegativeIntensity = texture2D(inputImageTexture, oneStepNegativeTextureCoordinate);\u000alowp vec4 twoStepsPositiveIntensity = texture2D(inputImageTexture, twoStepsPositiveTextureCoordinate);\u000alowp vec4 twoStepsNegativeIntensity = texture2D(inputImageTexture, twoStepsNegativeTextureCoordinate);\u000alowp vec4 threeStepsPositiveIntensity = texture2D(inputImageTexture, threeStepsPositiveTextureCoordinate);\u000alowp vec4 threeStepsNegativeIntensity = texture2D(inputImageTexture, threeStepsNegativeTextureCoordinate);\u000a\u000alowp vec4 maxValue = max(centerIntensity, oneStepPositiveIntensity);\u000amaxValue = max(maxValue, oneStepNegativeIntensity);\u000amaxValue = max(maxValue, twoStepsPositiveIntensity);\u000amaxValue = max(maxValue, twoStepsNegativeIntensity);\u000amaxValue = max(maxValue, threeStepsPositiveIntensity);\u000a\u000agl_FragColor = max(maxValue, threeStepsNegativeIntensity);\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='FRAGMENT_SHADER_4']"
		[Register ("FRAGMENT_SHADER_4")]
		public const string FragmentShader4 = (string) "precision highp float;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000avarying vec2 twoStepsPositiveTextureCoordinate;\u000avarying vec2 twoStepsNegativeTextureCoordinate;\u000avarying vec2 threeStepsPositiveTextureCoordinate;\u000avarying vec2 threeStepsNegativeTextureCoordinate;\u000avarying vec2 fourStepsPositiveTextureCoordinate;\u000avarying vec2 fourStepsNegativeTextureCoordinate;\u000a\u000auniform sampler2D inputImageTexture;\u000a\u000avoid main()\u000a{\u000alowp vec4 centerIntensity = texture2D(inputImageTexture, centerTextureCoordinate);\u000alowp vec4 oneStepPositiveIntensity = texture2D(inputImageTexture, oneStepPositiveTextureCoordinate);\u000alowp vec4 oneStepNegativeIntensity = texture2D(inputImageTexture, oneStepNegativeTextureCoordinate);\u000alowp vec4 twoStepsPositiveIntensity = texture2D(inputImageTexture, twoStepsPositiveTextureCoordinate);\u000alowp vec4 twoStepsNegativeIntensity = texture2D(inputImageTexture, twoStepsNegativeTextureCoordinate);\u000alowp vec4 threeStepsPositiveIntensity = texture2D(inputImageTexture, threeStepsPositiveTextureCoordinate);\u000alowp vec4 threeStepsNegativeIntensity = texture2D(inputImageTexture, threeStepsNegativeTextureCoordinate);\u000alowp vec4 fourStepsPositiveIntensity = texture2D(inputImageTexture, fourStepsPositiveTextureCoordinate);\u000alowp vec4 fourStepsNegativeIntensity = texture2D(inputImageTexture, fourStepsNegativeTextureCoordinate);\u000a\u000alowp vec4 maxValue = max(centerIntensity, oneStepPositiveIntensity);\u000amaxValue = max(maxValue, oneStepNegativeIntensity);\u000amaxValue = max(maxValue, twoStepsPositiveIntensity);\u000amaxValue = max(maxValue, twoStepsNegativeIntensity);\u000amaxValue = max(maxValue, threeStepsPositiveIntensity);\u000amaxValue = max(maxValue, threeStepsNegativeIntensity);\u000amaxValue = max(maxValue, fourStepsPositiveIntensity);\u000a\u000agl_FragColor = max(maxValue, fourStepsNegativeIntensity);\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='VERTEX_SHADER_1']"
		[Register ("VERTEX_SHADER_1")]
		public const string VertexShader1 = (string) "attribute vec4 position;\u000aattribute vec2 inputTextureCoordinate;\u000a\u000auniform float texelWidthOffset; \u000auniform float texelHeightOffset; \u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000a\u000avoid main()\u000a{\u000agl_Position = position;\u000a\u000avec2 offset = vec2(texelWidthOffset, texelHeightOffset);\u000a\u000acenterTextureCoordinate = inputTextureCoordinate;\u000aoneStepNegativeTextureCoordinate = inputTextureCoordinate - offset;\u000aoneStepPositiveTextureCoordinate = inputTextureCoordinate + offset;\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='VERTEX_SHADER_2']"
		[Register ("VERTEX_SHADER_2")]
		public const string VertexShader2 = (string) "attribute vec4 position;\u000aattribute vec2 inputTextureCoordinate;\u000a\u000auniform float texelWidthOffset;\u000auniform float texelHeightOffset;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000avarying vec2 twoStepsPositiveTextureCoordinate;\u000avarying vec2 twoStepsNegativeTextureCoordinate;\u000a\u000avoid main()\u000a{\u000agl_Position = position;\u000a\u000avec2 offset = vec2(texelWidthOffset, texelHeightOffset);\u000a\u000acenterTextureCoordinate = inputTextureCoordinate;\u000aoneStepNegativeTextureCoordinate = inputTextureCoordinate - offset;\u000aoneStepPositiveTextureCoordinate = inputTextureCoordinate + offset;\u000atwoStepsNegativeTextureCoordinate = inputTextureCoordinate - (offset * 2.0);\u000atwoStepsPositiveTextureCoordinate = inputTextureCoordinate + (offset * 2.0);\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='VERTEX_SHADER_3']"
		[Register ("VERTEX_SHADER_3")]
		public const string VertexShader3 = (string) "attribute vec4 position;\u000aattribute vec2 inputTextureCoordinate;\u000a\u000auniform float texelWidthOffset;\u000auniform float texelHeightOffset;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000avarying vec2 twoStepsPositiveTextureCoordinate;\u000avarying vec2 twoStepsNegativeTextureCoordinate;\u000avarying vec2 threeStepsPositiveTextureCoordinate;\u000avarying vec2 threeStepsNegativeTextureCoordinate;\u000a\u000avoid main()\u000a{\u000agl_Position = position;\u000a\u000avec2 offset = vec2(texelWidthOffset, texelHeightOffset);\u000a\u000acenterTextureCoordinate = inputTextureCoordinate;\u000aoneStepNegativeTextureCoordinate = inputTextureCoordinate - offset;\u000aoneStepPositiveTextureCoordinate = inputTextureCoordinate + offset;\u000atwoStepsNegativeTextureCoordinate = inputTextureCoordinate - (offset * 2.0);\u000atwoStepsPositiveTextureCoordinate = inputTextureCoordinate + (offset * 2.0);\u000athreeStepsNegativeTextureCoordinate = inputTextureCoordinate - (offset * 3.0);\u000athreeStepsPositiveTextureCoordinate = inputTextureCoordinate + (offset * 3.0);\u000a}\u000a";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/field[@name='VERTEX_SHADER_4']"
		[Register ("VERTEX_SHADER_4")]
		public const string VertexShader4 = (string) "attribute vec4 position;\u000aattribute vec2 inputTextureCoordinate;\u000a\u000auniform float texelWidthOffset;\u000auniform float texelHeightOffset;\u000a\u000avarying vec2 centerTextureCoordinate;\u000avarying vec2 oneStepPositiveTextureCoordinate;\u000avarying vec2 oneStepNegativeTextureCoordinate;\u000avarying vec2 twoStepsPositiveTextureCoordinate;\u000avarying vec2 twoStepsNegativeTextureCoordinate;\u000avarying vec2 threeStepsPositiveTextureCoordinate;\u000avarying vec2 threeStepsNegativeTextureCoordinate;\u000avarying vec2 fourStepsPositiveTextureCoordinate;\u000avarying vec2 fourStepsNegativeTextureCoordinate;\u000a\u000avoid main()\u000a{\u000agl_Position = position;\u000a\u000avec2 offset = vec2(texelWidthOffset, texelHeightOffset);\u000a\u000acenterTextureCoordinate = inputTextureCoordinate;\u000aoneStepNegativeTextureCoordinate = inputTextureCoordinate - offset;\u000aoneStepPositiveTextureCoordinate = inputTextureCoordinate + offset;\u000atwoStepsNegativeTextureCoordinate = inputTextureCoordinate - (offset * 2.0);\u000atwoStepsPositiveTextureCoordinate = inputTextureCoordinate + (offset * 2.0);\u000athreeStepsNegativeTextureCoordinate = inputTextureCoordinate - (offset * 3.0);\u000athreeStepsPositiveTextureCoordinate = inputTextureCoordinate + (offset * 3.0);\u000afourStepsNegativeTextureCoordinate = inputTextureCoordinate - (offset * 4.0);\u000afourStepsPositiveTextureCoordinate = inputTextureCoordinate + (offset * 4.0);\u000a}\u000a";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageRGBDilationFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageRGBDilationFilter); }
		}

		protected GPUImageRGBDilationFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/constructor[@name='GPUImageRGBDilationFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageRGBDilationFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageRGBDilationFilter)) {
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
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageRGBDilationFilter']/constructor[@name='GPUImageRGBDilationFilter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe GPUImageRGBDilationFilter (int radius)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (radius);
				if (((object) this).GetType () != typeof (GPUImageRGBDilationFilter)) {
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

	}
}
