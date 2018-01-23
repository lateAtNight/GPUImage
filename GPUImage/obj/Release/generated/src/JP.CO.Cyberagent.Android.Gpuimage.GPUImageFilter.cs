using System;
using System.Collections.Generic;
using Android.Runtime;

namespace JP.CO.Cyberagent.Android.Gpuimage {

	// Metadata.xml XPath class reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']"
	[global::Android.Runtime.Register ("jp/co/cyberagent/android/gpuimage/GPUImageFilter", DoNotGenerateAcw=true)]
	public partial class GPUImageFilter : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='NO_FILTER_FRAGMENT_SHADER']"
		[Register ("NO_FILTER_FRAGMENT_SHADER")]
		public const string NoFilterFragmentShader = (string) "varying highp vec2 textureCoordinate;\u000a \u000auniform sampler2D inputImageTexture;\u000a \u000avoid main()\u000a{\u000a     gl_FragColor = texture2D(inputImageTexture, textureCoordinate);\u000a}";

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='NO_FILTER_VERTEX_SHADER']"
		[Register ("NO_FILTER_VERTEX_SHADER")]
		public const string NoFilterVertexShader = (string) "attribute vec4 position;\u000aattribute vec4 inputTextureCoordinate;\u000a \u000avarying vec2 textureCoordinate;\u000a \u000avoid main()\u000a{\u000a    gl_Position = position;\u000a    textureCoordinate = inputTextureCoordinate.xy;\u000a}";

		static IntPtr mGLAttribPosition_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='mGLAttribPosition']"
		[Register ("mGLAttribPosition")]
		protected int MGLAttribPosition {
			get {
				if (mGLAttribPosition_jfieldId == IntPtr.Zero)
					mGLAttribPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLAttribPosition", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mGLAttribPosition_jfieldId);
			}
			set {
				if (mGLAttribPosition_jfieldId == IntPtr.Zero)
					mGLAttribPosition_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLAttribPosition", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGLAttribPosition_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mGLAttribTextureCoordinate_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='mGLAttribTextureCoordinate']"
		[Register ("mGLAttribTextureCoordinate")]
		protected int MGLAttribTextureCoordinate {
			get {
				if (mGLAttribTextureCoordinate_jfieldId == IntPtr.Zero)
					mGLAttribTextureCoordinate_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLAttribTextureCoordinate", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mGLAttribTextureCoordinate_jfieldId);
			}
			set {
				if (mGLAttribTextureCoordinate_jfieldId == IntPtr.Zero)
					mGLAttribTextureCoordinate_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLAttribTextureCoordinate", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGLAttribTextureCoordinate_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mGLProgId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='mGLProgId']"
		[Register ("mGLProgId")]
		protected int MGLProgId {
			get {
				if (mGLProgId_jfieldId == IntPtr.Zero)
					mGLProgId_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLProgId", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mGLProgId_jfieldId);
			}
			set {
				if (mGLProgId_jfieldId == IntPtr.Zero)
					mGLProgId_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLProgId", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGLProgId_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mGLUniformTexture_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='mGLUniformTexture']"
		[Register ("mGLUniformTexture")]
		protected int MGLUniformTexture {
			get {
				if (mGLUniformTexture_jfieldId == IntPtr.Zero)
					mGLUniformTexture_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLUniformTexture", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mGLUniformTexture_jfieldId);
			}
			set {
				if (mGLUniformTexture_jfieldId == IntPtr.Zero)
					mGLUniformTexture_jfieldId = JNIEnv.GetFieldID (class_ref, "mGLUniformTexture", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mGLUniformTexture_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOutputHeight_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='mOutputHeight']"
		[Register ("mOutputHeight")]
		protected int MOutputHeight {
			get {
				if (mOutputHeight_jfieldId == IntPtr.Zero)
					mOutputHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mOutputHeight", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mOutputHeight_jfieldId);
			}
			set {
				if (mOutputHeight_jfieldId == IntPtr.Zero)
					mOutputHeight_jfieldId = JNIEnv.GetFieldID (class_ref, "mOutputHeight", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOutputHeight_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mOutputWidth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/field[@name='mOutputWidth']"
		[Register ("mOutputWidth")]
		protected int MOutputWidth {
			get {
				if (mOutputWidth_jfieldId == IntPtr.Zero)
					mOutputWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mOutputWidth", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mOutputWidth_jfieldId);
			}
			set {
				if (mOutputWidth_jfieldId == IntPtr.Zero)
					mOutputWidth_jfieldId = JNIEnv.GetFieldID (class_ref, "mOutputWidth", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mOutputWidth_jfieldId, value);
				} finally {
				}
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("jp/co/cyberagent/android/gpuimage/GPUImageFilter", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GPUImageFilter); }
		}

		protected GPUImageFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/constructor[@name='GPUImageFilter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe GPUImageFilter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (GPUImageFilter)) {
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

		static IntPtr id_ctor_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/constructor[@name='GPUImageFilter' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe GPUImageFilter (string vertexShader, string fragmentShader)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vertexShader = JNIEnv.NewString (vertexShader);
			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_vertexShader);
				__args [1] = new JValue (native_fragmentShader);
				if (((object) this).GetType () != typeof (GPUImageFilter)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/String;Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_vertexShader);
				JNIEnv.DeleteLocalRef (native_fragmentShader);
			}
		}

		static Delegate cb_getAttribPosition;
#pragma warning disable 0169
		static Delegate GetGetAttribPositionHandler ()
		{
			if (cb_getAttribPosition == null)
				cb_getAttribPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAttribPosition);
			return cb_getAttribPosition;
		}

		static int n_GetAttribPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttribPosition;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribPosition;
		public virtual unsafe int AttribPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='getAttribPosition' and count(parameter)=0]"
			[Register ("getAttribPosition", "()I", "GetGetAttribPositionHandler")]
			get {
				if (id_getAttribPosition == IntPtr.Zero)
					id_getAttribPosition = JNIEnv.GetMethodID (class_ref, "getAttribPosition", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAttribPosition);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribPosition", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getAttribTextureCoordinate;
#pragma warning disable 0169
		static Delegate GetGetAttribTextureCoordinateHandler ()
		{
			if (cb_getAttribTextureCoordinate == null)
				cb_getAttribTextureCoordinate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAttribTextureCoordinate);
			return cb_getAttribTextureCoordinate;
		}

		static int n_GetAttribTextureCoordinate (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AttribTextureCoordinate;
		}
#pragma warning restore 0169

		static IntPtr id_getAttribTextureCoordinate;
		public virtual unsafe int AttribTextureCoordinate {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='getAttribTextureCoordinate' and count(parameter)=0]"
			[Register ("getAttribTextureCoordinate", "()I", "GetGetAttribTextureCoordinateHandler")]
			get {
				if (id_getAttribTextureCoordinate == IntPtr.Zero)
					id_getAttribTextureCoordinate = JNIEnv.GetMethodID (class_ref, "getAttribTextureCoordinate", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAttribTextureCoordinate);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAttribTextureCoordinate", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInitialized);
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		static IntPtr id_isInitialized;
		public virtual unsafe bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler")]
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInitialized", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOutputHeight;
#pragma warning disable 0169
		static Delegate GetGetOutputHeightHandler ()
		{
			if (cb_getOutputHeight == null)
				cb_getOutputHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputHeight);
			return cb_getOutputHeight;
		}

		static int n_GetOutputHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputHeight;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputHeight;
		public virtual unsafe int OutputHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='getOutputHeight' and count(parameter)=0]"
			[Register ("getOutputHeight", "()I", "GetGetOutputHeightHandler")]
			get {
				if (id_getOutputHeight == IntPtr.Zero)
					id_getOutputHeight = JNIEnv.GetMethodID (class_ref, "getOutputHeight", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOutputHeight);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputHeight", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getOutputWidth;
#pragma warning disable 0169
		static Delegate GetGetOutputWidthHandler ()
		{
			if (cb_getOutputWidth == null)
				cb_getOutputWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetOutputWidth);
			return cb_getOutputWidth;
		}

		static int n_GetOutputWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OutputWidth;
		}
#pragma warning restore 0169

		static IntPtr id_getOutputWidth;
		public virtual unsafe int OutputWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='getOutputWidth' and count(parameter)=0]"
			[Register ("getOutputWidth", "()I", "GetGetOutputWidthHandler")]
			get {
				if (id_getOutputWidth == IntPtr.Zero)
					id_getOutputWidth = JNIEnv.GetMethodID (class_ref, "getOutputWidth", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOutputWidth);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputWidth", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getProgram;
#pragma warning disable 0169
		static Delegate GetGetProgramHandler ()
		{
			if (cb_getProgram == null)
				cb_getProgram = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProgram);
			return cb_getProgram;
		}

		static int n_GetProgram (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Program;
		}
#pragma warning restore 0169

		static IntPtr id_getProgram;
		public virtual unsafe int Program {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='getProgram' and count(parameter)=0]"
			[Register ("getProgram", "()I", "GetGetProgramHandler")]
			get {
				if (id_getProgram == IntPtr.Zero)
					id_getProgram = JNIEnv.GetMethodID (class_ref, "getProgram", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getProgram);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getProgram", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getUniformTexture;
#pragma warning disable 0169
		static Delegate GetGetUniformTextureHandler ()
		{
			if (cb_getUniformTexture == null)
				cb_getUniformTexture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUniformTexture);
			return cb_getUniformTexture;
		}

		static int n_GetUniformTexture (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UniformTexture;
		}
#pragma warning restore 0169

		static IntPtr id_getUniformTexture;
		public virtual unsafe int UniformTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='getUniformTexture' and count(parameter)=0]"
			[Register ("getUniformTexture", "()I", "GetGetUniformTextureHandler")]
			get {
				if (id_getUniformTexture == IntPtr.Zero)
					id_getUniformTexture = JNIEnv.GetMethodID (class_ref, "getUniformTexture", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getUniformTexture);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getUniformTexture", "()I"));
				} finally {
				}
			}
		}

		static IntPtr id_convertStreamToString_Ljava_io_InputStream_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='convertStreamToString' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;", "")]
		public static unsafe string ConvertStreamToString (global::System.IO.Stream @is)
		{
			if (id_convertStreamToString_Ljava_io_InputStream_ == IntPtr.Zero)
				id_convertStreamToString_Ljava_io_InputStream_ = JNIEnv.GetStaticMethodID (class_ref, "convertStreamToString", "(Ljava/io/InputStream;)Ljava/lang/String;");
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native__is);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_convertStreamToString_Ljava_io_InputStream_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
			}
		}

		static IntPtr id_destroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='destroy' and count(parameter)=0]"
		[Register ("destroy", "()V", "")]
		public unsafe void Destroy ()
		{
			if (id_destroy == IntPtr.Zero)
				id_destroy = JNIEnv.GetMethodID (class_ref, "destroy", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_destroy);
			} finally {
			}
		}

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "")]
		public unsafe void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");
			try {
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_init);
			} finally {
			}
		}

		static IntPtr id_loadShader_Ljava_lang_String_Landroid_content_Context_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='loadShader' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Context']]"
		[Register ("loadShader", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;", "")]
		public static unsafe string LoadShader (string file, global::Android.Content.Context context)
		{
			if (id_loadShader_Ljava_lang_String_Landroid_content_Context_ == IntPtr.Zero)
				id_loadShader_Ljava_lang_String_Landroid_content_Context_ = JNIEnv.GetStaticMethodID (class_ref, "loadShader", "(Ljava/lang/String;Landroid/content/Context;)Ljava/lang/String;");
			IntPtr native_file = JNIEnv.NewString (file);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_file);
				__args [1] = new JValue (context);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_loadShader_Ljava_lang_String_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_file);
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		static IntPtr id_onDestroy;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			if (id_onDestroy == IntPtr.Zero)
				id_onDestroy = JNIEnv.GetMethodID (class_ref, "onDestroy", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDestroy);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDestroy", "()V"));
			} finally {
			}
		}

		static Delegate cb_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
#pragma warning disable 0169
		static Delegate GetOnDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Handler ()
		{
			if (cb_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ == null)
				cb_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OnDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_);
			return cb_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
		}

		static void n_OnDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ (IntPtr jnienv, IntPtr native__this, int textureId, IntPtr native_cubeBuffer, IntPtr native_textureBuffer)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer cubeBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_cubeBuffer, JniHandleOwnership.DoNotTransfer);
			global::Java.Nio.FloatBuffer textureBuffer = global::Java.Lang.Object.GetObject<global::Java.Nio.FloatBuffer> (native_textureBuffer, JniHandleOwnership.DoNotTransfer);
			__this.OnDraw (textureId, cubeBuffer, textureBuffer);
		}
#pragma warning restore 0169

		static IntPtr id_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='onDraw' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.nio.FloatBuffer'] and parameter[3][@type='java.nio.FloatBuffer']]"
		[Register ("onDraw", "(ILjava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V", "GetOnDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_Handler")]
		public virtual unsafe void OnDraw (int textureId, global::Java.Nio.FloatBuffer cubeBuffer, global::Java.Nio.FloatBuffer textureBuffer)
		{
			if (id_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ == IntPtr.Zero)
				id_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_ = JNIEnv.GetMethodID (class_ref, "onDraw", "(ILjava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (textureId);
				__args [1] = new JValue (cubeBuffer);
				__args [2] = new JValue (textureBuffer);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDraw_ILjava_nio_FloatBuffer_Ljava_nio_FloatBuffer_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDraw", "(ILjava/nio/FloatBuffer;Ljava/nio/FloatBuffer;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onDrawArraysPre;
#pragma warning disable 0169
		static Delegate GetOnDrawArraysPreHandler ()
		{
			if (cb_onDrawArraysPre == null)
				cb_onDrawArraysPre = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnDrawArraysPre);
			return cb_onDrawArraysPre;
		}

		static void n_OnDrawArraysPre (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawArraysPre ();
		}
#pragma warning restore 0169

		static IntPtr id_onDrawArraysPre;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='onDrawArraysPre' and count(parameter)=0]"
		[Register ("onDrawArraysPre", "()V", "GetOnDrawArraysPreHandler")]
		protected virtual unsafe void OnDrawArraysPre ()
		{
			if (id_onDrawArraysPre == IntPtr.Zero)
				id_onDrawArraysPre = JNIEnv.GetMethodID (class_ref, "onDrawArraysPre", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawArraysPre);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onDrawArraysPre", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInit;
#pragma warning disable 0169
		static Delegate GetOnInitHandler ()
		{
			if (cb_onInit == null)
				cb_onInit = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInit);
			return cb_onInit;
		}

		static void n_OnInit (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInit ();
		}
#pragma warning restore 0169

		static IntPtr id_onInit;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='onInit' and count(parameter)=0]"
		[Register ("onInit", "()V", "GetOnInitHandler")]
		public virtual unsafe void OnInit ()
		{
			if (id_onInit == IntPtr.Zero)
				id_onInit = JNIEnv.GetMethodID (class_ref, "onInit", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInit);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInit", "()V"));
			} finally {
			}
		}

		static Delegate cb_onInitialized;
#pragma warning disable 0169
		static Delegate GetOnInitializedHandler ()
		{
			if (cb_onInitialized == null)
				cb_onInitialized = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnInitialized);
			return cb_onInitialized;
		}

		static void n_OnInitialized (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnInitialized ();
		}
#pragma warning restore 0169

		static IntPtr id_onInitialized;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='onInitialized' and count(parameter)=0]"
		[Register ("onInitialized", "()V", "GetOnInitializedHandler")]
		public virtual unsafe void OnInitialized ()
		{
			if (id_onInitialized == IntPtr.Zero)
				id_onInitialized = JNIEnv.GetMethodID (class_ref, "onInitialized", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onInitialized);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onInitialized", "()V"));
			} finally {
			}
		}

		static Delegate cb_onOutputSizeChanged_II;
#pragma warning disable 0169
		static Delegate GetOnOutputSizeChanged_IIHandler ()
		{
			if (cb_onOutputSizeChanged_II == null)
				cb_onOutputSizeChanged_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_OnOutputSizeChanged_II);
			return cb_onOutputSizeChanged_II;
		}

		static void n_OnOutputSizeChanged_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnOutputSizeChanged (width, height);
		}
#pragma warning restore 0169

		static IntPtr id_onOutputSizeChanged_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='onOutputSizeChanged' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("onOutputSizeChanged", "(II)V", "GetOnOutputSizeChanged_IIHandler")]
		public virtual unsafe void OnOutputSizeChanged (int width, int height)
		{
			if (id_onOutputSizeChanged_II == IntPtr.Zero)
				id_onOutputSizeChanged_II = JNIEnv.GetMethodID (class_ref, "onOutputSizeChanged", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (width);
				__args [1] = new JValue (height);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onOutputSizeChanged_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onOutputSizeChanged", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_runOnDraw_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRunOnDraw_Ljava_lang_Runnable_Handler ()
		{
			if (cb_runOnDraw_Ljava_lang_Runnable_ == null)
				cb_runOnDraw_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RunOnDraw_Ljava_lang_Runnable_);
			return cb_runOnDraw_Ljava_lang_Runnable_;
		}

		static void n_RunOnDraw_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_runnable)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable runnable = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_runnable, JniHandleOwnership.DoNotTransfer);
			__this.RunOnDraw (runnable);
		}
#pragma warning restore 0169

		static IntPtr id_runOnDraw_Ljava_lang_Runnable_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='runOnDraw' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("runOnDraw", "(Ljava/lang/Runnable;)V", "GetRunOnDraw_Ljava_lang_Runnable_Handler")]
		protected virtual unsafe void RunOnDraw (global::Java.Lang.IRunnable runnable)
		{
			if (id_runOnDraw_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_runOnDraw_Ljava_lang_Runnable_ = JNIEnv.GetMethodID (class_ref, "runOnDraw", "(Ljava/lang/Runnable;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (runnable);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runOnDraw_Ljava_lang_Runnable_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runOnDraw", "(Ljava/lang/Runnable;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_runPendingOnDrawTasks;
#pragma warning disable 0169
		static Delegate GetRunPendingOnDrawTasksHandler ()
		{
			if (cb_runPendingOnDrawTasks == null)
				cb_runPendingOnDrawTasks = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RunPendingOnDrawTasks);
			return cb_runPendingOnDrawTasks;
		}

		static void n_RunPendingOnDrawTasks (IntPtr jnienv, IntPtr native__this)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RunPendingOnDrawTasks ();
		}
#pragma warning restore 0169

		static IntPtr id_runPendingOnDrawTasks;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='runPendingOnDrawTasks' and count(parameter)=0]"
		[Register ("runPendingOnDrawTasks", "()V", "GetRunPendingOnDrawTasksHandler")]
		protected virtual unsafe void RunPendingOnDrawTasks ()
		{
			if (id_runPendingOnDrawTasks == IntPtr.Zero)
				id_runPendingOnDrawTasks = JNIEnv.GetMethodID (class_ref, "runPendingOnDrawTasks", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_runPendingOnDrawTasks);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "runPendingOnDrawTasks", "()V"));
			} finally {
			}
		}

		static Delegate cb_setFloat_IF;
#pragma warning disable 0169
		static Delegate GetSetFloat_IFHandler ()
		{
			if (cb_setFloat_IF == null)
				cb_setFloat_IF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, float>) n_SetFloat_IF);
			return cb_setFloat_IF;
		}

		static void n_SetFloat_IF (IntPtr jnienv, IntPtr native__this, int location, float floatValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFloat (location, floatValue);
		}
#pragma warning restore 0169

		static IntPtr id_setFloat_IF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setFloat' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float']]"
		[Register ("setFloat", "(IF)V", "GetSetFloat_IFHandler")]
		protected virtual unsafe void SetFloat (int location, float floatValue)
		{
			if (id_setFloat_IF == IntPtr.Zero)
				id_setFloat_IF = JNIEnv.GetMethodID (class_ref, "setFloat", "(IF)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (floatValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloat_IF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloat", "(IF)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setFloatArray_IarrayF;
#pragma warning disable 0169
		static Delegate GetSetFloatArray_IarrayFHandler ()
		{
			if (cb_setFloatArray_IarrayF == null)
				cb_setFloatArray_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetFloatArray_IarrayF);
			return cb_setFloatArray_IarrayF;
		}

		static void n_SetFloatArray_IarrayF (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_arrayValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] arrayValue = (float[]) JNIEnv.GetArray (native_arrayValue, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatArray (location, arrayValue);
			if (arrayValue != null)
				JNIEnv.CopyArray (arrayValue, native_arrayValue);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatArray_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setFloatArray' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("setFloatArray", "(I[F)V", "GetSetFloatArray_IarrayFHandler")]
		protected virtual unsafe void SetFloatArray (int location, float[] arrayValue)
		{
			if (id_setFloatArray_IarrayF == IntPtr.Zero)
				id_setFloatArray_IarrayF = JNIEnv.GetMethodID (class_ref, "setFloatArray", "(I[F)V");
			IntPtr native_arrayValue = JNIEnv.NewArray (arrayValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (native_arrayValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloatArray_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatArray", "(I[F)V"), __args);
			} finally {
				if (arrayValue != null) {
					JNIEnv.CopyArray (native_arrayValue, arrayValue);
					JNIEnv.DeleteLocalRef (native_arrayValue);
				}
			}
		}

		static Delegate cb_setFloatVec2_IarrayF;
#pragma warning disable 0169
		static Delegate GetSetFloatVec2_IarrayFHandler ()
		{
			if (cb_setFloatVec2_IarrayF == null)
				cb_setFloatVec2_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetFloatVec2_IarrayF);
			return cb_setFloatVec2_IarrayF;
		}

		static void n_SetFloatVec2_IarrayF (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_arrayValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] arrayValue = (float[]) JNIEnv.GetArray (native_arrayValue, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatVec2 (location, arrayValue);
			if (arrayValue != null)
				JNIEnv.CopyArray (arrayValue, native_arrayValue);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatVec2_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setFloatVec2' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("setFloatVec2", "(I[F)V", "GetSetFloatVec2_IarrayFHandler")]
		protected virtual unsafe void SetFloatVec2 (int location, float[] arrayValue)
		{
			if (id_setFloatVec2_IarrayF == IntPtr.Zero)
				id_setFloatVec2_IarrayF = JNIEnv.GetMethodID (class_ref, "setFloatVec2", "(I[F)V");
			IntPtr native_arrayValue = JNIEnv.NewArray (arrayValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (native_arrayValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloatVec2_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatVec2", "(I[F)V"), __args);
			} finally {
				if (arrayValue != null) {
					JNIEnv.CopyArray (native_arrayValue, arrayValue);
					JNIEnv.DeleteLocalRef (native_arrayValue);
				}
			}
		}

		static Delegate cb_setFloatVec3_IarrayF;
#pragma warning disable 0169
		static Delegate GetSetFloatVec3_IarrayFHandler ()
		{
			if (cb_setFloatVec3_IarrayF == null)
				cb_setFloatVec3_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetFloatVec3_IarrayF);
			return cb_setFloatVec3_IarrayF;
		}

		static void n_SetFloatVec3_IarrayF (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_arrayValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] arrayValue = (float[]) JNIEnv.GetArray (native_arrayValue, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatVec3 (location, arrayValue);
			if (arrayValue != null)
				JNIEnv.CopyArray (arrayValue, native_arrayValue);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatVec3_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setFloatVec3' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("setFloatVec3", "(I[F)V", "GetSetFloatVec3_IarrayFHandler")]
		protected virtual unsafe void SetFloatVec3 (int location, float[] arrayValue)
		{
			if (id_setFloatVec3_IarrayF == IntPtr.Zero)
				id_setFloatVec3_IarrayF = JNIEnv.GetMethodID (class_ref, "setFloatVec3", "(I[F)V");
			IntPtr native_arrayValue = JNIEnv.NewArray (arrayValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (native_arrayValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloatVec3_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatVec3", "(I[F)V"), __args);
			} finally {
				if (arrayValue != null) {
					JNIEnv.CopyArray (native_arrayValue, arrayValue);
					JNIEnv.DeleteLocalRef (native_arrayValue);
				}
			}
		}

		static Delegate cb_setFloatVec4_IarrayF;
#pragma warning disable 0169
		static Delegate GetSetFloatVec4_IarrayFHandler ()
		{
			if (cb_setFloatVec4_IarrayF == null)
				cb_setFloatVec4_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetFloatVec4_IarrayF);
			return cb_setFloatVec4_IarrayF;
		}

		static void n_SetFloatVec4_IarrayF (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_arrayValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] arrayValue = (float[]) JNIEnv.GetArray (native_arrayValue, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetFloatVec4 (location, arrayValue);
			if (arrayValue != null)
				JNIEnv.CopyArray (arrayValue, native_arrayValue);
		}
#pragma warning restore 0169

		static IntPtr id_setFloatVec4_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setFloatVec4' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("setFloatVec4", "(I[F)V", "GetSetFloatVec4_IarrayFHandler")]
		protected virtual unsafe void SetFloatVec4 (int location, float[] arrayValue)
		{
			if (id_setFloatVec4_IarrayF == IntPtr.Zero)
				id_setFloatVec4_IarrayF = JNIEnv.GetMethodID (class_ref, "setFloatVec4", "(I[F)V");
			IntPtr native_arrayValue = JNIEnv.NewArray (arrayValue);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (native_arrayValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFloatVec4_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setFloatVec4", "(I[F)V"), __args);
			} finally {
				if (arrayValue != null) {
					JNIEnv.CopyArray (native_arrayValue, arrayValue);
					JNIEnv.DeleteLocalRef (native_arrayValue);
				}
			}
		}

		static Delegate cb_setInteger_II;
#pragma warning disable 0169
		static Delegate GetSetInteger_IIHandler ()
		{
			if (cb_setInteger_II == null)
				cb_setInteger_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetInteger_II);
			return cb_setInteger_II;
		}

		static void n_SetInteger_II (IntPtr jnienv, IntPtr native__this, int location, int intValue)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInteger (location, intValue);
		}
#pragma warning restore 0169

		static IntPtr id_setInteger_II;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setInteger' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setInteger", "(II)V", "GetSetInteger_IIHandler")]
		protected virtual unsafe void SetInteger (int location, int intValue)
		{
			if (id_setInteger_II == IntPtr.Zero)
				id_setInteger_II = JNIEnv.GetMethodID (class_ref, "setInteger", "(II)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (intValue);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setInteger_II, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setInteger", "(II)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setPoint_ILandroid_graphics_PointF_;
#pragma warning disable 0169
		static Delegate GetSetPoint_ILandroid_graphics_PointF_Handler ()
		{
			if (cb_setPoint_ILandroid_graphics_PointF_ == null)
				cb_setPoint_ILandroid_graphics_PointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetPoint_ILandroid_graphics_PointF_);
			return cb_setPoint_ILandroid_graphics_PointF_;
		}

		static void n_SetPoint_ILandroid_graphics_PointF_ (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_point)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.PointF point = global::Java.Lang.Object.GetObject<global::Android.Graphics.PointF> (native_point, JniHandleOwnership.DoNotTransfer);
			__this.SetPoint (location, point);
		}
#pragma warning restore 0169

		static IntPtr id_setPoint_ILandroid_graphics_PointF_;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setPoint' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.PointF']]"
		[Register ("setPoint", "(ILandroid/graphics/PointF;)V", "GetSetPoint_ILandroid_graphics_PointF_Handler")]
		protected virtual unsafe void SetPoint (int location, global::Android.Graphics.PointF point)
		{
			if (id_setPoint_ILandroid_graphics_PointF_ == IntPtr.Zero)
				id_setPoint_ILandroid_graphics_PointF_ = JNIEnv.GetMethodID (class_ref, "setPoint", "(ILandroid/graphics/PointF;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (point);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPoint_ILandroid_graphics_PointF_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPoint", "(ILandroid/graphics/PointF;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setUniformMatrix3f_IarrayF;
#pragma warning disable 0169
		static Delegate GetSetUniformMatrix3f_IarrayFHandler ()
		{
			if (cb_setUniformMatrix3f_IarrayF == null)
				cb_setUniformMatrix3f_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetUniformMatrix3f_IarrayF);
			return cb_setUniformMatrix3f_IarrayF;
		}

		static void n_SetUniformMatrix3f_IarrayF (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_matrix)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] matrix = (float[]) JNIEnv.GetArray (native_matrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetUniformMatrix3f (location, matrix);
			if (matrix != null)
				JNIEnv.CopyArray (matrix, native_matrix);
		}
#pragma warning restore 0169

		static IntPtr id_setUniformMatrix3f_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setUniformMatrix3f' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("setUniformMatrix3f", "(I[F)V", "GetSetUniformMatrix3f_IarrayFHandler")]
		protected virtual unsafe void SetUniformMatrix3f (int location, float[] matrix)
		{
			if (id_setUniformMatrix3f_IarrayF == IntPtr.Zero)
				id_setUniformMatrix3f_IarrayF = JNIEnv.GetMethodID (class_ref, "setUniformMatrix3f", "(I[F)V");
			IntPtr native_matrix = JNIEnv.NewArray (matrix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (native_matrix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUniformMatrix3f_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUniformMatrix3f", "(I[F)V"), __args);
			} finally {
				if (matrix != null) {
					JNIEnv.CopyArray (native_matrix, matrix);
					JNIEnv.DeleteLocalRef (native_matrix);
				}
			}
		}

		static Delegate cb_setUniformMatrix4f_IarrayF;
#pragma warning disable 0169
		static Delegate GetSetUniformMatrix4f_IarrayFHandler ()
		{
			if (cb_setUniformMatrix4f_IarrayF == null)
				cb_setUniformMatrix4f_IarrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_SetUniformMatrix4f_IarrayF);
			return cb_setUniformMatrix4f_IarrayF;
		}

		static void n_SetUniformMatrix4f_IarrayF (IntPtr jnienv, IntPtr native__this, int location, IntPtr native_matrix)
		{
			global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter __this = global::Java.Lang.Object.GetObject<global::JP.CO.Cyberagent.Android.Gpuimage.GPUImageFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] matrix = (float[]) JNIEnv.GetArray (native_matrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetUniformMatrix4f (location, matrix);
			if (matrix != null)
				JNIEnv.CopyArray (matrix, native_matrix);
		}
#pragma warning restore 0169

		static IntPtr id_setUniformMatrix4f_IarrayF;
		// Metadata.xml XPath method reference: path="/api/package[@name='jp.co.cyberagent.android.gpuimage']/class[@name='GPUImageFilter']/method[@name='setUniformMatrix4f' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("setUniformMatrix4f", "(I[F)V", "GetSetUniformMatrix4f_IarrayFHandler")]
		protected virtual unsafe void SetUniformMatrix4f (int location, float[] matrix)
		{
			if (id_setUniformMatrix4f_IarrayF == IntPtr.Zero)
				id_setUniformMatrix4f_IarrayF = JNIEnv.GetMethodID (class_ref, "setUniformMatrix4f", "(I[F)V");
			IntPtr native_matrix = JNIEnv.NewArray (matrix);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (location);
				__args [1] = new JValue (native_matrix);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setUniformMatrix4f_IarrayF, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setUniformMatrix4f", "(I[F)V"), __args);
			} finally {
				if (matrix != null) {
					JNIEnv.CopyArray (native_matrix, matrix);
					JNIEnv.DeleteLocalRef (native_matrix);
				}
			}
		}

	}
}
