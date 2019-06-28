using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoDevice", DoNotGenerateAcw=true)]
	public partial class MorphoDevice : global::Java.Lang.Object, global::Java.Lang.ICloneable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/field[@name='ACTION_SCREEN_RECEIVER']"
		[Register ("ACTION_SCREEN_RECEIVER")]
		public static string ActionScreenReceiver {
			get {
				const string __id = "ACTION_SCREEN_RECEIVER.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ACTION_SCREEN_RECEIVER.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/field[@name='CONFIG_KEY_USER_TAG']"
		[Register ("CONFIG_KEY_USER_TAG")]
		public const int ConfigKeyUserTag = (int) 4627;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/field[@name='CONFIG_SENSOR_WIN_POSITION_TAG']"
		[Register ("CONFIG_SENSOR_WIN_POSITION_TAG")]
		public const int ConfigSensorWinPositionTag = (int) 3600;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/field[@name='CONFIG_UI_CONFIG_TAG']"
		[Register ("CONFIG_UI_CONFIG_TAG")]
		public const int ConfigUiConfigTag = (int) 5136;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/field[@name='CONFIG_UI_RESET_TAG']"
		[Register ("CONFIG_UI_RESET_TAG")]
		public const int ConfigUiResetTag = (int) 5137;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/field[@name='cppMemOwn']"
		[Register ("cppMemOwn")]
		protected bool CppMemOwn {
			get {
				const string __id = "cppMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "cppMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']"
		[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice", DoNotGenerateAcw=true)]
		public sealed partial class MorphoDevicePrivacyModeDBProcessingChoice : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']/field[@name='PRIVACY_MODE_DB_PROCESSING_CIPHER_TRANCIPHER']"
			[Register ("PRIVACY_MODE_DB_PROCESSING_CIPHER_TRANCIPHER")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice PrivacyModeDbProcessingCipherTrancipher {
				get {
					const string __id = "PRIVACY_MODE_DB_PROCESSING_CIPHER_TRANCIPHER.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']/field[@name='PRIVACY_MODE_DB_PROCESSING_ERASE']"
			[Register ("PRIVACY_MODE_DB_PROCESSING_ERASE")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice PrivacyModeDbProcessingErase {
				get {
					const string __id = "PRIVACY_MODE_DB_PROCESSING_ERASE.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']/field[@name='PRIVACY_MODE_DB_PROCESSING_NOTHING']"
			[Register ("PRIVACY_MODE_DB_PROCESSING_NOTHING")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice PrivacyModeDbProcessingNothing {
				get {
					const string __id = "PRIVACY_MODE_DB_PROCESSING_NOTHING.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice", typeof (MorphoDevicePrivacyModeDBProcessingChoice));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal MorphoDevicePrivacyModeDBProcessingChoice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;", "")]
			public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;", "")]
			public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice[] Values ()
			{
				const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']"
		[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus", DoNotGenerateAcw=true)]
		public sealed partial class MorphoDevicePrivacyModeStatus : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/field[@name='PRIVACY_MODE_DISABLED']"
			[Register ("PRIVACY_MODE_DISABLED")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus PrivacyModeDisabled {
				get {
					const string __id = "PRIVACY_MODE_DISABLED.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/field[@name='PRIVACY_MODE_ENABLED']"
			[Register ("PRIVACY_MODE_ENABLED")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus PrivacyModeEnabled {
				get {
					const string __id = "PRIVACY_MODE_ENABLED.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/field[@name='PRIVACY_MODE_PARTIAL_ENABLED']"
			[Register ("PRIVACY_MODE_PARTIAL_ENABLED")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus PrivacyModePartialEnabled {
				get {
					const string __id = "PRIVACY_MODE_PARTIAL_ENABLED.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/field[@name='PRIVACY_MODE_STANDALONE_ENABLED']"
			[Register ("PRIVACY_MODE_STANDALONE_ENABLED")]
			public static global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus PrivacyModeStandaloneEnabled {
				get {
					const string __id = "PRIVACY_MODE_STANDALONE_ENABLED.Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus", typeof (MorphoDevicePrivacyModeStatus));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal MorphoDevicePrivacyModeStatus (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			public unsafe int Value {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/method[@name='getValue' and count(parameter)=0]"
				[Register ("getValue", "()I", "GetGetValueHandler")]
				get {
					const string __id = "getValue.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;", "")]
			public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus ValueOf (string p0)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;";
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_p0);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.MorphoDevicePrivacyModeStatus']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;", "")]
			public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus[] Values ()
			{
				const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.ScreenBroadcastReceiver']"
		[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoDevice$ScreenBroadcastReceiver", DoNotGenerateAcw=true)]
		public partial class ScreenBroadcastReceiver : global::Android.Content.BroadcastReceiver {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoDevice$ScreenBroadcastReceiver", typeof (ScreenBroadcastReceiver));
			internal static new IntPtr class_ref {
				get {
					return _members.JniPeerType.PeerReference.Handle;
				}
			}

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected ScreenBroadcastReceiver (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.ScreenBroadcastReceiver']/constructor[@name='MorphoDevice.ScreenBroadcastReceiver' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoDevice']]"
			[Register (".ctor", "(Lcom/morpho/morphosmart/sdk/MorphoDevice;)V", "")]
			public unsafe ScreenBroadcastReceiver (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
#pragma warning disable 0169
			static Delegate GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler ()
			{
				if (cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ == null)
					cb_onReceive_Landroid_content_Context_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnReceive_Landroid_content_Context_Landroid_content_Intent_);
				return cb_onReceive_Landroid_content_Context_Landroid_content_Intent_;
			}

			static void n_OnReceive_Landroid_content_Context_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_intent)
			{
				global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.ScreenBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.ScreenBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
				global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
				__this.OnReceive (context, intent);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.ScreenBroadcastReceiver']/method[@name='onReceive' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.content.Intent']]"
			[Register ("onReceive", "(Landroid/content/Context;Landroid/content/Intent;)V", "GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler")]
			public override unsafe void OnReceive (global::Android.Content.Context context, global::Android.Content.Intent intent)
			{
				const string __id = "onReceive.(Landroid/content/Context;Landroid/content/Intent;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_setDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_;
#pragma warning disable 0169
			static Delegate GetSetDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_Handler ()
			{
				if (cb_setDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_ == null)
					cb_setDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_);
				return cb_setDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_;
			}

			static void n_SetDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_device)
			{
				global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.ScreenBroadcastReceiver __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.ScreenBroadcastReceiver> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::Com.Morpho.Morphosmart.Sdk.MorphoDevice device = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (native_device, JniHandleOwnership.DoNotTransfer);
				__this.SetDevice (device);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice.ScreenBroadcastReceiver']/method[@name='setDevice' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoDevice']]"
			[Register ("setDevice", "(Lcom/morpho/morphosmart/sdk/MorphoDevice;)V", "GetSetDevice_Lcom_morpho_morphosmart_sdk_MorphoDevice_Handler")]
			public virtual unsafe void SetDevice (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice device)
			{
				const string __id = "setDevice.(Lcom/morpho/morphosmart/sdk/MorphoDevice;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoDevice", typeof (MorphoDevice));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected MorphoDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/constructor[@name='MorphoDevice' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoDevice ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/constructor[@name='MorphoDevice' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoDevice']]"
		[Register (".ctor", "(Lcom/morpho/morphosmart/sdk/MorphoDevice;)V", "")]
		public unsafe MorphoDevice (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice device)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/morpho/morphosmart/sdk/MorphoDevice;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((device == null) ? IntPtr.Zero : ((global::Java.Lang.Object) device).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getComType;
#pragma warning disable 0169
		static Delegate GetGetComTypeHandler ()
		{
			if (cb_getComType == null)
				cb_getComType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetComType);
			return cb_getComType;
		}

		static int n_GetComType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ComType;
		}
#pragma warning restore 0169

		public virtual unsafe int ComType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getComType' and count(parameter)=0]"
			[Register ("getComType", "()I", "GetGetComTypeHandler")]
			get {
				const string __id = "getComType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFFDLogs;
#pragma warning disable 0169
		static Delegate GetGetFFDLogsHandler ()
		{
			if (cb_getFFDLogs == null)
				cb_getFFDLogs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFFDLogs);
			return cb_getFFDLogs;
		}

		static IntPtr n_GetFFDLogs (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FFDLogs);
		}
#pragma warning restore 0169

		public virtual unsafe string FFDLogs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getFFDLogs' and count(parameter)=0]"
			[Register ("getFFDLogs", "()Ljava/lang/String;", "GetGetFFDLogsHandler")]
			get {
				const string __id = "getFFDLogs.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInternalError;
#pragma warning disable 0169
		static Delegate GetGetInternalErrorHandler ()
		{
			if (cb_getInternalError == null)
				cb_getInternalError = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInternalError);
			return cb_getInternalError;
		}

		static int n_GetInternalError (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InternalError;
		}
#pragma warning restore 0169

		public virtual unsafe int InternalError {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getInternalError' and count(parameter)=0]"
			[Register ("getInternalError", "()I", "GetGetInternalErrorHandler")]
			get {
				const string __id = "getInternalError.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCSEnabled;
#pragma warning disable 0169
		static Delegate GetIsCSEnabledHandler ()
		{
			if (cb_isCSEnabled == null)
				cb_isCSEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCSEnabled);
			return cb_isCSEnabled;
		}

		static bool n_IsCSEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCSEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCSEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='isCSEnabled' and count(parameter)=0]"
			[Register ("isCSEnabled", "()Z", "GetIsCSEnabledHandler")]
			get {
				const string __id = "isCSEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDataEncryptionEnabled;
#pragma warning disable 0169
		static Delegate GetIsDataEncryptionEnabledHandler ()
		{
			if (cb_isDataEncryptionEnabled == null)
				cb_isDataEncryptionEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDataEncryptionEnabled);
			return cb_isDataEncryptionEnabled;
		}

		static bool n_IsDataEncryptionEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDataEncryptionEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDataEncryptionEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='isDataEncryptionEnabled' and count(parameter)=0]"
			[Register ("isDataEncryptionEnabled", "()Z", "GetIsDataEncryptionEnabledHandler")]
			get {
				const string __id = "isDataEncryptionEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOpenedUsbDeviceName;
#pragma warning disable 0169
		static Delegate GetGetOpenedUsbDeviceNameHandler ()
		{
			if (cb_getOpenedUsbDeviceName == null)
				cb_getOpenedUsbDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpenedUsbDeviceName);
			return cb_getOpenedUsbDeviceName;
		}

		static IntPtr n_GetOpenedUsbDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpenedUsbDeviceName);
		}
#pragma warning restore 0169

		public virtual unsafe string OpenedUsbDeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getOpenedUsbDeviceName' and count(parameter)=0]"
			[Register ("getOpenedUsbDeviceName", "()Ljava/lang/String;", "GetGetOpenedUsbDeviceNameHandler")]
			get {
				const string __id = "getOpenedUsbDeviceName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProductDescriptor;
#pragma warning disable 0169
		static Delegate GetGetProductDescriptorHandler ()
		{
			if (cb_getProductDescriptor == null)
				cb_getProductDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductDescriptor);
			return cb_getProductDescriptor;
		}

		static IntPtr n_GetProductDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductDescriptor);
		}
#pragma warning restore 0169

		public virtual unsafe string ProductDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getProductDescriptor' and count(parameter)=0]"
			[Register ("getProductDescriptor", "()Ljava/lang/String;", "GetGetProductDescriptorHandler")]
			get {
				const string __id = "getProductDescriptor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecurityLevel;
#pragma warning disable 0169
		static Delegate GetGetSecurityLevelHandler ()
		{
			if (cb_getSecurityLevel == null)
				cb_getSecurityLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSecurityLevel);
			return cb_getSecurityLevel;
		}

		static int n_GetSecurityLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecurityLevel;
		}
#pragma warning restore 0169

		public virtual unsafe int SecurityLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getSecurityLevel' and count(parameter)=0]"
			[Register ("getSecurityLevel", "()I", "GetGetSecurityLevelHandler")]
			get {
				const string __id = "getSecurityLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSensorDescriptor;
#pragma warning disable 0169
		static Delegate GetGetSensorDescriptorHandler ()
		{
			if (cb_getSensorDescriptor == null)
				cb_getSensorDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSensorDescriptor);
			return cb_getSensorDescriptor;
		}

		static IntPtr n_GetSensorDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SensorDescriptor);
		}
#pragma warning restore 0169

		public virtual unsafe string SensorDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getSensorDescriptor' and count(parameter)=0]"
			[Register ("getSensorDescriptor", "()Ljava/lang/String;", "GetGetSensorDescriptorHandler")]
			get {
				const string __id = "getSensorDescriptor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSoftwareDescriptor;
#pragma warning disable 0169
		static Delegate GetGetSoftwareDescriptorHandler ()
		{
			if (cb_getSoftwareDescriptor == null)
				cb_getSoftwareDescriptor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSoftwareDescriptor);
			return cb_getSoftwareDescriptor;
		}

		static IntPtr n_GetSoftwareDescriptor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SoftwareDescriptor);
		}
#pragma warning restore 0169

		public virtual unsafe string SoftwareDescriptor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getSoftwareDescriptor' and count(parameter)=0]"
			[Register ("getSoftwareDescriptor", "()Ljava/lang/String;", "GetGetSoftwareDescriptorHandler")]
			get {
				const string __id = "getSoftwareDescriptor.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStrategyAcquisitionMode;
#pragma warning disable 0169
		static Delegate GetGetStrategyAcquisitionModeHandler ()
		{
			if (cb_getStrategyAcquisitionMode == null)
				cb_getStrategyAcquisitionMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStrategyAcquisitionMode);
			return cb_getStrategyAcquisitionMode;
		}

		static IntPtr n_GetStrategyAcquisitionMode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.StrategyAcquisitionMode);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode StrategyAcquisitionMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getStrategyAcquisitionMode' and count(parameter)=0]"
			[Register ("getStrategyAcquisitionMode", "()Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;", "GetGetStrategyAcquisitionModeHandler")]
			get {
				const string __id = "getStrategyAcquisitionMode.()Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_SecuReadCertificate_ILjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSecuReadCertificate_ILjava_util_ArrayList_Handler ()
		{
			if (cb_SecuReadCertificate_ILjava_util_ArrayList_ == null)
				cb_SecuReadCertificate_ILjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_SecuReadCertificate_ILjava_util_ArrayList_);
			return cb_SecuReadCertificate_ILjava_util_ArrayList_;
		}

		static int n_SecuReadCertificate_ILjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_devCertif)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var devCertif = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_devCertif, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SecuReadCertificate (index, devCertif);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='SecuReadCertificate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("SecuReadCertificate", "(ILjava/util/ArrayList;)I", "GetSecuReadCertificate_ILjava_util_ArrayList_Handler")]
		public virtual unsafe int SecuReadCertificate (int index, global::System.Collections.Generic.IList<global::Java.Lang.Byte> devCertif)
		{
			const string __id = "SecuReadCertificate.(ILjava/util/ArrayList;)I";
			IntPtr native_devCertif = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (devCertif);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (native_devCertif);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_devCertif);
			}
		}

		static Delegate cb_cancelLiveAcquisition;
#pragma warning disable 0169
		static Delegate GetCancelLiveAcquisitionHandler ()
		{
			if (cb_cancelLiveAcquisition == null)
				cb_cancelLiveAcquisition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CancelLiveAcquisition);
			return cb_cancelLiveAcquisition;
		}

		static int n_CancelLiveAcquisition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CancelLiveAcquisition ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='cancelLiveAcquisition' and count(parameter)=0]"
		[Register ("cancelLiveAcquisition", "()I", "GetCancelLiveAcquisitionHandler")]
		public virtual unsafe int CancelLiveAcquisition ()
		{
			const string __id = "cancelLiveAcquisition.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_capture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetCapture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Handler ()
		{
			if (cb_capture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_ == null)
				cb_capture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, int, IntPtr, int>) n_Capture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_);
			return cb_capture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_;
		}

		[Obsolete]
		static int n_Capture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_ (IntPtr jnienv, IntPtr native__this, int timeout, int acquisitionThreshold, int advancedSecurityLevelsRequired, int fingerNumber, IntPtr native_templateType, IntPtr native_templateFVPType, int maxSizeTemplate, IntPtr native_enrollType, IntPtr native_latentDetection, IntPtr native_coderChoice, int detectModeChoice, IntPtr native_templateList, int callbackCmd, IntPtr native__callback)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateType> (native_templateType, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType templateFVPType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (native_templateFVPType, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.EnrollmentType enrollType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.EnrollmentType> (native_enrollType, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.LatentDetection latentDetection = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.LatentDetection> (native_latentDetection, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Coder coderChoice = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (native_coderChoice, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (native_templateList, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Capture (timeout, acquisitionThreshold, advancedSecurityLevelsRequired, fingerNumber, templateType, templateFVPType, maxSizeTemplate, enrollType, latentDetection, coderChoice, detectModeChoice, templateList, callbackCmd, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='capture' and count(parameter)=14 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='com.morpho.morphosmart.sdk.TemplateType'] and parameter[6][@type='com.morpho.morphosmart.sdk.TemplateFVPType'] and parameter[7][@type='int'] and parameter[8][@type='com.morpho.morphosmart.sdk.EnrollmentType'] and parameter[9][@type='com.morpho.morphosmart.sdk.LatentDetection'] and parameter[10][@type='com.morpho.morphosmart.sdk.Coder'] and parameter[11][@type='int'] and parameter[12][@type='com.morpho.morphosmart.sdk.TemplateList'] and parameter[13][@type='int'] and parameter[14][@type='java.util.Observer']]"
		[Obsolete (@"deprecated")]
		[Register ("capture", "(IIIILcom/morpho/morphosmart/sdk/TemplateType;Lcom/morpho/morphosmart/sdk/TemplateFVPType;ILcom/morpho/morphosmart/sdk/EnrollmentType;Lcom/morpho/morphosmart/sdk/LatentDetection;Lcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/TemplateList;ILjava/util/Observer;)I", "GetCapture_IIIILcom_morpho_morphosmart_sdk_TemplateType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ILcom_morpho_morphosmart_sdk_EnrollmentType_Lcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Handler")]
		public virtual unsafe int Capture (int timeout, int acquisitionThreshold, int advancedSecurityLevelsRequired, int fingerNumber, global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType, global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType templateFVPType, int maxSizeTemplate, global::Com.Morpho.Morphosmart.Sdk.EnrollmentType enrollType, global::Com.Morpho.Morphosmart.Sdk.LatentDetection latentDetection, global::Com.Morpho.Morphosmart.Sdk.Coder coderChoice, int detectModeChoice, global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList, int callbackCmd, global::Java.Util.IObserver @callback)
		{
			const string __id = "capture.(IIIILcom/morpho/morphosmart/sdk/TemplateType;Lcom/morpho/morphosmart/sdk/TemplateFVPType;ILcom/morpho/morphosmart/sdk/EnrollmentType;Lcom/morpho/morphosmart/sdk/LatentDetection;Lcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/TemplateList;ILjava/util/Observer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue (acquisitionThreshold);
				__args [2] = new JniArgumentValue (advancedSecurityLevelsRequired);
				__args [3] = new JniArgumentValue (fingerNumber);
				__args [4] = new JniArgumentValue ((templateType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateType).Handle);
				__args [5] = new JniArgumentValue ((templateFVPType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateFVPType).Handle);
				__args [6] = new JniArgumentValue (maxSizeTemplate);
				__args [7] = new JniArgumentValue ((enrollType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) enrollType).Handle);
				__args [8] = new JniArgumentValue ((latentDetection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latentDetection).Handle);
				__args [9] = new JniArgumentValue ((coderChoice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coderChoice).Handle);
				__args [10] = new JniArgumentValue (detectModeChoice);
				__args [11] = new JniArgumentValue ((templateList == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateList).Handle);
				__args [12] = new JniArgumentValue (callbackCmd);
				__args [13] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
		public virtual unsafe global::Java.Lang.Object Clone ()
		{
			const string __id = "clone.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_closeDevice;
#pragma warning disable 0169
		static Delegate GetCloseDeviceHandler ()
		{
			if (cb_closeDevice == null)
				cb_closeDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CloseDevice);
			return cb_closeDevice;
		}

		static int n_CloseDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseDevice ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='closeDevice' and count(parameter)=0]"
		[Register ("closeDevice", "()I", "GetCloseDeviceHandler")]
		public virtual unsafe int CloseDevice ()
		{
			const string __id = "closeDevice.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_comReceive_I;
#pragma warning disable 0169
		static Delegate GetComReceive_IHandler ()
		{
			if (cb_comReceive_I == null)
				cb_comReceive_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ComReceive_I);
			return cb_comReceive_I;
		}

		static IntPtr n_ComReceive_I (IntPtr jnienv, IntPtr native__this, int timeOut)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ComReceive (timeOut));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='comReceive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("comReceive", "(I)[B", "GetComReceive_IHandler")]
		public virtual unsafe byte[] ComReceive (int timeOut)
		{
			const string __id = "comReceive.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeOut);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_comSend_IarrayB;
#pragma warning disable 0169
		static Delegate GetComSend_IarrayBHandler ()
		{
			if (cb_comSend_IarrayB == null)
				cb_comSend_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ComSend_IarrayB);
			return cb_comSend_IarrayB;
		}

		static int n_ComSend_IarrayB (IntPtr jnienv, IntPtr native__this, int timeOut, IntPtr native_data)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ComSend (timeOut, data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='comSend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("comSend", "(I[B)I", "GetComSend_IarrayBHandler")]
		public virtual unsafe int ComSend (int timeOut, byte[] data)
		{
			const string __id = "comSend.(I[B)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeOut);
				__args [1] = new JniArgumentValue (native_data);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_enableCS_Z;
#pragma warning disable 0169
		static Delegate GetEnableCS_ZHandler ()
		{
			if (cb_enableCS_Z == null)
				cb_enableCS_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_EnableCS_Z);
			return cb_enableCS_Z;
		}

		static int n_EnableCS_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnableCS (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='enableCS' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("enableCS", "(Z)I", "GetEnableCS_ZHandler")]
		public virtual unsafe int EnableCS (bool enable)
		{
			const string __id = "enableCS.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_enableDataEncryption_ZarrayB;
#pragma warning disable 0169
		static Delegate GetEnableDataEncryption_ZarrayBHandler ()
		{
			if (cb_enableDataEncryption_ZarrayB == null)
				cb_enableDataEncryption_ZarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, int>) n_EnableDataEncryption_ZarrayB);
			return cb_enableDataEncryption_ZarrayB;
		}

		static int n_EnableDataEncryption_ZarrayB (IntPtr jnienv, IntPtr native__this, bool enable, IntPtr native_diversificationData)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] diversificationData = (byte[]) JNIEnv.GetArray (native_diversificationData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.EnableDataEncryption (enable, diversificationData);
			if (diversificationData != null)
				JNIEnv.CopyArray (diversificationData, native_diversificationData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='enableDataEncryption' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='byte[]']]"
		[Register ("enableDataEncryption", "(Z[B)I", "GetEnableDataEncryption_ZarrayBHandler")]
		public virtual unsafe int EnableDataEncryption (bool enable, byte[] diversificationData)
		{
			const string __id = "enableDataEncryption.(Z[B)I";
			IntPtr native_diversificationData = JNIEnv.NewArray (diversificationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (enable);
				__args [1] = new JniArgumentValue (native_diversificationData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (diversificationData != null) {
					JNIEnv.CopyArray (native_diversificationData, diversificationData);
					JNIEnv.DeleteLocalRef (native_diversificationData);
				}
			}
		}

		static Delegate cb_enableDataEncryption_ZLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnableDataEncryption_ZLjava_lang_String_Handler ()
		{
			if (cb_enableDataEncryption_ZLjava_lang_String_ == null)
				cb_enableDataEncryption_ZLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr, int>) n_EnableDataEncryption_ZLjava_lang_String_);
			return cb_enableDataEncryption_ZLjava_lang_String_;
		}

		static int n_EnableDataEncryption_ZLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool enable, IntPtr native_diversificationData)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string diversificationData = JNIEnv.GetString (native_diversificationData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EnableDataEncryption (enable, diversificationData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='enableDataEncryption' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("enableDataEncryption", "(ZLjava/lang/String;)I", "GetEnableDataEncryption_ZLjava_lang_String_Handler")]
		public virtual unsafe int EnableDataEncryption (bool enable, string diversificationData)
		{
			const string __id = "enableDataEncryption.(ZLjava/lang/String;)I";
			IntPtr native_diversificationData = JNIEnv.NewString (diversificationData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (enable);
				__args [1] = new JniArgumentValue (native_diversificationData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_diversificationData);
			}
		}

		static Delegate cb_getConfigParam_I;
#pragma warning disable 0169
		static Delegate GetGetConfigParam_IHandler ()
		{
			if (cb_getConfigParam_I == null)
				cb_getConfigParam_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetConfigParam_I);
			return cb_getConfigParam_I;
		}

		static IntPtr n_GetConfigParam_I (IntPtr jnienv, IntPtr native__this, int parameterIdentifier)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetConfigParam (parameterIdentifier));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getConfigParam' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getConfigParam", "(I)[B", "GetGetConfigParam_IHandler")]
		public virtual unsafe byte[] GetConfigParam (int parameterIdentifier)
		{
			const string __id = "getConfigParam.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (parameterIdentifier);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_;
#pragma warning disable 0169
		static Delegate GetGetDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_Handler ()
		{
			if (cb_getDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_ == null)
				cb_getDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_);
			return cb_getDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_;
		}

		static int n_GetDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_ (IntPtr jnienv, IntPtr native__this, int databaseIndex, IntPtr native_morphoDatabase)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase morphoDatabase = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (native_morphoDatabase, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDatabase (databaseIndex, morphoDatabase);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getDatabase' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoDatabase']]"
		[Register ("getDatabase", "(ILcom/morpho/morphosmart/sdk/MorphoDatabase;)I", "GetGetDatabase_ILcom_morpho_morphosmart_sdk_MorphoDatabase_Handler")]
		public virtual unsafe int GetDatabase (int databaseIndex, global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase morphoDatabase)
		{
			const string __id = "getDatabase.(ILcom/morpho/morphosmart/sdk/MorphoDatabase;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (databaseIndex);
				__args [1] = new JniArgumentValue ((morphoDatabase == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoDatabase).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_;
#pragma warning disable 0169
		static Delegate GetGetImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_Handler ()
		{
			if (cb_getImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_ == null)
				cb_getImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, int, IntPtr, IntPtr, int, IntPtr, int>) n_GetImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_);
			return cb_getImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_;
		}

		static int n_GetImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_ (IntPtr jnienv, IntPtr native__this, int timeOut, int acquisitionThreshold, IntPtr native_compressAlgo, int compressRate, int detectModeChoice, IntPtr native_latentDetection, IntPtr native_morphoImage, int callbackCmd, IntPtr native__callback)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm compressAlgo = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (native_compressAlgo, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.LatentDetection latentDetection = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.LatentDetection> (native_latentDetection, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage morphoImage = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (native_morphoImage, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetImage (timeOut, acquisitionThreshold, compressAlgo, compressRate, detectModeChoice, latentDetection, morphoImage, callbackCmd, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getImage' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.CompressionAlgorithm'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.morpho.morphosmart.sdk.LatentDetection'] and parameter[7][@type='com.morpho.morphosmart.sdk.MorphoImage'] and parameter[8][@type='int'] and parameter[9][@type='java.util.Observer']]"
		[Register ("getImage", "(IILcom/morpho/morphosmart/sdk/CompressionAlgorithm;IILcom/morpho/morphosmart/sdk/LatentDetection;Lcom/morpho/morphosmart/sdk/MorphoImage;ILjava/util/Observer;)I", "GetGetImage_IILcom_morpho_morphosmart_sdk_CompressionAlgorithm_IILcom_morpho_morphosmart_sdk_LatentDetection_Lcom_morpho_morphosmart_sdk_MorphoImage_ILjava_util_Observer_Handler")]
		public virtual unsafe int GetImage (int timeOut, int acquisitionThreshold, global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm compressAlgo, int compressRate, int detectModeChoice, global::Com.Morpho.Morphosmart.Sdk.LatentDetection latentDetection, global::Com.Morpho.Morphosmart.Sdk.MorphoImage morphoImage, int callbackCmd, global::Java.Util.IObserver @callback)
		{
			const string __id = "getImage.(IILcom/morpho/morphosmart/sdk/CompressionAlgorithm;IILcom/morpho/morphosmart/sdk/LatentDetection;Lcom/morpho/morphosmart/sdk/MorphoImage;ILjava/util/Observer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (timeOut);
				__args [1] = new JniArgumentValue (acquisitionThreshold);
				__args [2] = new JniArgumentValue ((compressAlgo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compressAlgo).Handle);
				__args [3] = new JniArgumentValue (compressRate);
				__args [4] = new JniArgumentValue (detectModeChoice);
				__args [5] = new JniArgumentValue ((latentDetection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) latentDetection).Handle);
				__args [6] = new JniArgumentValue ((morphoImage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoImage).Handle);
				__args [7] = new JniArgumentValue (callbackCmd);
				__args [8] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_;
#pragma warning disable 0169
		static Delegate GetGetIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_Handler ()
		{
			if (cb_getIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_ == null)
				cb_getIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_);
			return cb_getIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_;
		}

		static int n_GetIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_descriptorIdentifier)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.DescriptorID descriptorIdentifier = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DescriptorID> (native_descriptorIdentifier, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIntDescriptorBin (descriptorIdentifier);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getIntDescriptorBin' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.DescriptorID']]"
		[Register ("getIntDescriptorBin", "(Lcom/morpho/morphosmart/sdk/DescriptorID;)I", "GetGetIntDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_Handler")]
		public virtual unsafe int GetIntDescriptorBin (global::Com.Morpho.Morphosmart.Sdk.DescriptorID descriptorIdentifier)
		{
			const string __id = "getIntDescriptorBin.(Lcom/morpho/morphosmart/sdk/DescriptorID;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((descriptorIdentifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptorIdentifier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayB;
#pragma warning disable 0169
		static Delegate GetGetKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayBHandler ()
		{
			if (cb_getKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayB == null)
				cb_getKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayB);
			return cb_getKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayB;
		}

		static IntPtr n_GetKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_keyID, IntPtr native_secretID)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID keyID = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID> (native_keyID, JniHandleOwnership.DoNotTransfer);
			byte[] secretID = (byte[]) JNIEnv.GetArray (native_secretID, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.GetKCV (keyID, secretID));
			if (secretID != null)
				JNIEnv.CopyArray (secretID, native_secretID);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getKCV' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoKCVID'] and parameter[2][@type='byte[]']]"
		[Register ("getKCV", "(Lcom/morpho/morphosmart/sdk/MorphoKCVID;[B)[B", "GetGetKCV_Lcom_morpho_morphosmart_sdk_MorphoKCVID_arrayBHandler")]
		public virtual unsafe byte[] GetKCV (global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID keyID, byte[] secretID)
		{
			const string __id = "getKCV.(Lcom/morpho/morphosmart/sdk/MorphoKCVID;[B)[B";
			IntPtr native_secretID = JNIEnv.NewArray (secretID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyID == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyID).Handle);
				__args [1] = new JniArgumentValue (native_secretID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (secretID != null) {
					JNIEnv.CopyArray (native_secretID, secretID);
					JNIEnv.DeleteLocalRef (native_secretID);
				}
			}
		}

		static Delegate cb_getKCV_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetKCV_IHandler ()
		{
			if (cb_getKCV_I == null)
				cb_getKCV_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetKCV_I);
			return cb_getKCV_I;
		}

		[Obsolete]
		static IntPtr n_GetKCV_I (IntPtr jnienv, IntPtr native__this, int keyID)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetKCV (keyID));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getKCV' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getKCV", "(I)Ljava/lang/String;", "GetGetKCV_IHandler")]
		public virtual unsafe string GetKCV (int keyID)
		{
			const string __id = "getKCV.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (keyID);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_;
#pragma warning disable 0169
		static Delegate GetGetPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Handler ()
		{
			if (cb_getPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_ == null)
				cb_getPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_);
			return cb_getPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_;
		}

		static int n_GetPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus[] status = (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus[]) JNIEnv.GetArray (native_status, JniHandleOwnership.DoNotTransfer, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus));
			int __ret = __this.GetPrivacyModeStatus (status);
			if (status != null)
				JNIEnv.CopyArray (status, native_status);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getPrivacyModeStatus' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoDevice.MorphoDevicePrivacyModeStatus[]']]"
		[Register ("getPrivacyModeStatus", "([Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;)I", "GetGetPrivacyModeStatus_arrayLcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Handler")]
		public virtual unsafe int GetPrivacyModeStatus (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus[] status)
		{
			const string __id = "getPrivacyModeStatus.([Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;)I";
			IntPtr native_status = JNIEnv.NewArray (status);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_status);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (status != null) {
					JNIEnv.CopyArray (native_status, status);
					JNIEnv.DeleteLocalRef (native_status);
				}
			}
		}

		static Delegate cb_getPrivacySeed;
#pragma warning disable 0169
		static Delegate GetGetPrivacySeedHandler ()
		{
			if (cb_getPrivacySeed == null)
				cb_getPrivacySeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPrivacySeed);
			return cb_getPrivacySeed;
		}

		static IntPtr n_GetPrivacySeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetPrivacySeed ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getPrivacySeed' and count(parameter)=0]"
		[Register ("getPrivacySeed", "()[B", "GetGetPrivacySeedHandler")]
		public virtual unsafe byte[] GetPrivacySeed ()
		{
			const string __id = "getPrivacySeed.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_;
#pragma warning disable 0169
		static Delegate GetGetSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_Handler ()
		{
			if (cb_getSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_ == null)
				cb_getSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_);
			return cb_getSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_;
		}

		static int n_GetSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secuConfig)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig secuConfig = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (native_secuConfig, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetSecuConfig (secuConfig);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getSecuConfig' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.SecuConfig']]"
		[Register ("getSecuConfig", "(Lcom/morpho/morphosmart/sdk/SecuConfig;)I", "GetGetSecuConfig_Lcom_morpho_morphosmart_sdk_SecuConfig_Handler")]
		public virtual unsafe int GetSecuConfig (global::Com.Morpho.Morphosmart.Sdk.SecuConfig secuConfig)
		{
			const string __id = "getSecuConfig.(Lcom/morpho/morphosmart/sdk/SecuConfig;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((secuConfig == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secuConfig).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_;
#pragma warning disable 0169
		static Delegate GetGetStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_Handler ()
		{
			if (cb_getStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_ == null)
				cb_getStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_);
			return cb_getStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_;
		}

		static IntPtr n_GetStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_ (IntPtr jnienv, IntPtr native__this, IntPtr native_descriptorIdentifier)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.DescriptorID descriptorIdentifier = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DescriptorID> (native_descriptorIdentifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetStringDescriptorBin (descriptorIdentifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getStringDescriptorBin' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.DescriptorID']]"
		[Register ("getStringDescriptorBin", "(Lcom/morpho/morphosmart/sdk/DescriptorID;)Ljava/lang/String;", "GetGetStringDescriptorBin_Lcom_morpho_morphosmart_sdk_DescriptorID_Handler")]
		public virtual unsafe string GetStringDescriptorBin (global::Com.Morpho.Morphosmart.Sdk.DescriptorID descriptorIdentifier)
		{
			const string __id = "getStringDescriptorBin.(Lcom/morpho/morphosmart/sdk/DescriptorID;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((descriptorIdentifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) descriptorIdentifier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUnlockSeed;
#pragma warning disable 0169
		static Delegate GetGetUnlockSeedHandler ()
		{
			if (cb_getUnlockSeed == null)
				cb_getUnlockSeed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUnlockSeed);
			return cb_getUnlockSeed;
		}

		static IntPtr n_GetUnlockSeed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUnlockSeed ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getUnlockSeed' and count(parameter)=0]"
		[Register ("getUnlockSeed", "()[B", "GetGetUnlockSeedHandler")]
		public virtual unsafe byte[] GetUnlockSeed ()
		{
			const string __id = "getUnlockSeed.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getUsbDeviceName_I;
#pragma warning disable 0169
		static Delegate GetGetUsbDeviceName_IHandler ()
		{
			if (cb_getUsbDeviceName_I == null)
				cb_getUsbDeviceName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetUsbDeviceName_I);
			return cb_getUsbDeviceName_I;
		}

		static IntPtr n_GetUsbDeviceName_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetUsbDeviceName (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getUsbDeviceName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUsbDeviceName", "(I)Ljava/lang/String;", "GetGetUsbDeviceName_IHandler")]
		public virtual unsafe string GetUsbDeviceName (int index)
		{
			const string __id = "getUsbDeviceName.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUsbDevicePropertie_I;
#pragma warning disable 0169
		static Delegate GetGetUsbDevicePropertie_IHandler ()
		{
			if (cb_getUsbDevicePropertie_I == null)
				cb_getUsbDevicePropertie_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetUsbDevicePropertie_I);
			return cb_getUsbDevicePropertie_I;
		}

		static IntPtr n_GetUsbDevicePropertie_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetUsbDevicePropertie (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getUsbDevicePropertie' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUsbDevicePropertie", "(I)Ljava/lang/String;", "GetGetUsbDevicePropertie_IHandler")]
		public virtual unsafe string GetUsbDevicePropertie (int index)
		{
			const string __id = "getUsbDevicePropertie.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUserAreaData;
#pragma warning disable 0169
		static Delegate GetGetUserAreaDataHandler ()
		{
			if (cb_getUserAreaData == null)
				cb_getUserAreaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserAreaData);
			return cb_getUserAreaData;
		}

		static IntPtr n_GetUserAreaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetUserAreaData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='getUserAreaData' and count(parameter)=0]"
		[Register ("getUserAreaData", "()[B", "GetGetUserAreaDataHandler")]
		public virtual unsafe byte[] GetUserAreaData ()
		{
			const string __id = "getUserAreaData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_initUsbDevicesNameEnum_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetInitUsbDevicesNameEnum_Ljava_lang_Integer_Handler ()
		{
			if (cb_initUsbDevicesNameEnum_Ljava_lang_Integer_ == null)
				cb_initUsbDevicesNameEnum_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_InitUsbDevicesNameEnum_Ljava_lang_Integer_);
			return cb_initUsbDevicesNameEnum_Ljava_lang_Integer_;
		}

		static int n_InitUsbDevicesNameEnum_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbUsbDevice)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer nbUsbDevice = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_nbUsbDevice, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.InitUsbDevicesNameEnum (nbUsbDevice);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='initUsbDevicesNameEnum' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("initUsbDevicesNameEnum", "(Ljava/lang/Integer;)I", "GetInitUsbDevicesNameEnum_Ljava_lang_Integer_Handler")]
		public virtual unsafe int InitUsbDevicesNameEnum (global::Java.Lang.Integer nbUsbDevice)
		{
			const string __id = "initUsbDevicesNameEnum.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbUsbDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbUsbDevice).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_loadKprivacy_arrayB;
#pragma warning disable 0169
		static Delegate GetLoadKprivacy_arrayBHandler ()
		{
			if (cb_loadKprivacy_arrayB == null)
				cb_loadKprivacy_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LoadKprivacy_arrayB);
			return cb_loadKprivacy_arrayB;
		}

		static int n_LoadKprivacy_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadKprivacy (key);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadKprivacy' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("loadKprivacy", "([B)I", "GetLoadKprivacy_arrayBHandler")]
		public virtual unsafe int LoadKprivacy (byte[] key)
		{
			const string __id = "loadKprivacy.([B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static Delegate cb_loadKprivacySecurely_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadKprivacySecurely_arrayBarrayBHandler ()
		{
			if (cb_loadKprivacySecurely_arrayBarrayB == null)
				cb_loadKprivacySecurely_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoadKprivacySecurely_arrayBarrayB);
			return cb_loadKprivacySecurely_arrayBarrayB;
		}

		static int n_LoadKprivacySecurely_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_cryptogram)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] cryptogram = (byte[]) JNIEnv.GetArray (native_cryptogram, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadKprivacySecurely (key, cryptogram);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (cryptogram != null)
				JNIEnv.CopyArray (cryptogram, native_cryptogram);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadKprivacySecurely' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("loadKprivacySecurely", "([B[B)I", "GetLoadKprivacySecurely_arrayBarrayBHandler")]
		public virtual unsafe int LoadKprivacySecurely (byte[] key, byte[] cryptogram)
		{
			const string __id = "loadKprivacySecurely.([B[B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_cryptogram = JNIEnv.NewArray (cryptogram);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_cryptogram);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (cryptogram != null) {
					JNIEnv.CopyArray (native_cryptogram, cryptogram);
					JNIEnv.DeleteLocalRef (native_cryptogram);
				}
			}
		}

		static Delegate cb_loadKs_arrayB;
#pragma warning disable 0169
		static Delegate GetLoadKs_arrayBHandler ()
		{
			if (cb_loadKs_arrayB == null)
				cb_loadKs_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LoadKs_arrayB);
			return cb_loadKs_arrayB;
		}

		static int n_LoadKs_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadKs (key);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadKs' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("loadKs", "([B)I", "GetLoadKs_arrayBHandler")]
		public virtual unsafe int LoadKs (byte[] key)
		{
			const string __id = "loadKs.([B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static Delegate cb_loadKsSecurely_arrayB;
#pragma warning disable 0169
		static Delegate GetLoadKsSecurely_arrayBHandler ()
		{
			if (cb_loadKsSecurely_arrayB == null)
				cb_loadKsSecurely_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LoadKsSecurely_arrayB);
			return cb_loadKsSecurely_arrayB;
		}

		static int n_LoadKsSecurely_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadKsSecurely (key);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadKsSecurely' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("loadKsSecurely", "([B)I", "GetLoadKsSecurely_arrayBHandler")]
		public virtual unsafe int LoadKsSecurely (byte[] key)
		{
			const string __id = "loadKsSecurely.([B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}
		}

		static Delegate cb_loadKsSecurely_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadKsSecurely_arrayBarrayBarrayBHandler ()
		{
			if (cb_loadKsSecurely_arrayBarrayBarrayB == null)
				cb_loadKsSecurely_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoadKsSecurely_arrayBarrayBarrayB);
			return cb_loadKsSecurely_arrayBarrayBarrayB;
		}

		static int n_LoadKsSecurely_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_signature, IntPtr native_host_certificate)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] signature = (byte[]) JNIEnv.GetArray (native_signature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] host_certificate = (byte[]) JNIEnv.GetArray (native_host_certificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadKsSecurely (key, signature, host_certificate);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (signature != null)
				JNIEnv.CopyArray (signature, native_signature);
			if (host_certificate != null)
				JNIEnv.CopyArray (host_certificate, native_host_certificate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadKsSecurely' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadKsSecurely", "([B[B[B)I", "GetLoadKsSecurely_arrayBarrayBarrayBHandler")]
		public virtual unsafe int LoadKsSecurely (byte[] key, byte[] signature, byte[] host_certificate)
		{
			const string __id = "loadKsSecurely.([B[B[B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_signature = JNIEnv.NewArray (signature);
			IntPtr native_host_certificate = JNIEnv.NewArray (host_certificate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_signature);
				__args [2] = new JniArgumentValue (native_host_certificate);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (signature != null) {
					JNIEnv.CopyArray (native_signature, signature);
					JNIEnv.DeleteLocalRef (native_signature);
				}
				if (host_certificate != null) {
					JNIEnv.CopyArray (native_host_certificate, host_certificate);
					JNIEnv.DeleteLocalRef (native_host_certificate);
				}
			}
		}

		static Delegate cb_loadMocKey_arrayB;
#pragma warning disable 0169
		static Delegate GetLoadMocKey_arrayBHandler ()
		{
			if (cb_loadMocKey_arrayB == null)
				cb_loadMocKey_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_LoadMocKey_arrayB);
			return cb_loadMocKey_arrayB;
		}

		static int n_LoadMocKey_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key_enc_Ciffered_by_KencTrans)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key_enc_Ciffered_by_KencTrans = (byte[]) JNIEnv.GetArray (native_key_enc_Ciffered_by_KencTrans, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadMocKey (key_enc_Ciffered_by_KencTrans);
			if (key_enc_Ciffered_by_KencTrans != null)
				JNIEnv.CopyArray (key_enc_Ciffered_by_KencTrans, native_key_enc_Ciffered_by_KencTrans);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadMocKey' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("loadMocKey", "([B)I", "GetLoadMocKey_arrayBHandler")]
		public virtual unsafe int LoadMocKey (byte[] key_enc_Ciffered_by_KencTrans)
		{
			const string __id = "loadMocKey.([B)I";
			IntPtr native_key_enc_Ciffered_by_KencTrans = JNIEnv.NewArray (key_enc_Ciffered_by_KencTrans);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_key_enc_Ciffered_by_KencTrans);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key_enc_Ciffered_by_KencTrans != null) {
					JNIEnv.CopyArray (native_key_enc_Ciffered_by_KencTrans, key_enc_Ciffered_by_KencTrans);
					JNIEnv.DeleteLocalRef (native_key_enc_Ciffered_by_KencTrans);
				}
			}
		}

		static Delegate cb_loadMocKey_arrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetLoadMocKey_arrayBarrayBarrayBHandler ()
		{
			if (cb_loadMocKey_arrayBarrayBarrayB == null)
				cb_loadMocKey_arrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_LoadMocKey_arrayBarrayBarrayB);
			return cb_loadMocKey_arrayBarrayBarrayB;
		}

		static int n_LoadMocKey_arrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key_enc_Ciffered_by_Certificate, IntPtr native_key_enc_Ciffered_by_Certificate_Signature, IntPtr native_hostCertificate)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key_enc_Ciffered_by_Certificate = (byte[]) JNIEnv.GetArray (native_key_enc_Ciffered_by_Certificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] key_enc_Ciffered_by_Certificate_Signature = (byte[]) JNIEnv.GetArray (native_key_enc_Ciffered_by_Certificate_Signature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] hostCertificate = (byte[]) JNIEnv.GetArray (native_hostCertificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.LoadMocKey (key_enc_Ciffered_by_Certificate, key_enc_Ciffered_by_Certificate_Signature, hostCertificate);
			if (key_enc_Ciffered_by_Certificate != null)
				JNIEnv.CopyArray (key_enc_Ciffered_by_Certificate, native_key_enc_Ciffered_by_Certificate);
			if (key_enc_Ciffered_by_Certificate_Signature != null)
				JNIEnv.CopyArray (key_enc_Ciffered_by_Certificate_Signature, native_key_enc_Ciffered_by_Certificate_Signature);
			if (hostCertificate != null)
				JNIEnv.CopyArray (hostCertificate, native_hostCertificate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='loadMocKey' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]']]"
		[Register ("loadMocKey", "([B[B[B)I", "GetLoadMocKey_arrayBarrayBarrayBHandler")]
		public virtual unsafe int LoadMocKey (byte[] key_enc_Ciffered_by_Certificate, byte[] key_enc_Ciffered_by_Certificate_Signature, byte[] hostCertificate)
		{
			const string __id = "loadMocKey.([B[B[B)I";
			IntPtr native_key_enc_Ciffered_by_Certificate = JNIEnv.NewArray (key_enc_Ciffered_by_Certificate);
			IntPtr native_key_enc_Ciffered_by_Certificate_Signature = JNIEnv.NewArray (key_enc_Ciffered_by_Certificate_Signature);
			IntPtr native_hostCertificate = JNIEnv.NewArray (hostCertificate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key_enc_Ciffered_by_Certificate);
				__args [1] = new JniArgumentValue (native_key_enc_Ciffered_by_Certificate_Signature);
				__args [2] = new JniArgumentValue (native_hostCertificate);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key_enc_Ciffered_by_Certificate != null) {
					JNIEnv.CopyArray (native_key_enc_Ciffered_by_Certificate, key_enc_Ciffered_by_Certificate);
					JNIEnv.DeleteLocalRef (native_key_enc_Ciffered_by_Certificate);
				}
				if (key_enc_Ciffered_by_Certificate_Signature != null) {
					JNIEnv.CopyArray (native_key_enc_Ciffered_by_Certificate_Signature, key_enc_Ciffered_by_Certificate_Signature);
					JNIEnv.DeleteLocalRef (native_key_enc_Ciffered_by_Certificate_Signature);
				}
				if (hostCertificate != null) {
					JNIEnv.CopyArray (native_hostCertificate, hostCertificate);
					JNIEnv.DeleteLocalRef (native_hostCertificate);
				}
			}
		}

		static Delegate cb_offeredSecuClose;
#pragma warning disable 0169
		static Delegate GetOfferedSecuCloseHandler ()
		{
			if (cb_offeredSecuClose == null)
				cb_offeredSecuClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_OfferedSecuClose);
			return cb_offeredSecuClose;
		}

		static int n_OfferedSecuClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OfferedSecuClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='offeredSecuClose' and count(parameter)=0]"
		[Register ("offeredSecuClose", "()I", "GetOfferedSecuCloseHandler")]
		public virtual unsafe int OfferedSecuClose ()
		{
			const string __id = "offeredSecuClose.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_offeredSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_;
#pragma warning disable 0169
		static Delegate GetOfferedSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_Handler ()
		{
			if (cb_offeredSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_ == null)
				cb_offeredSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_OfferedSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_);
			return cb_offeredSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_;
		}

		static int n_OfferedSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msosecuCallbackObject)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu msosecuCallbackObject = (global::Com.Morpho.Morphosmart.Sdk.IMsoSecu)global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (native_msosecuCallbackObject, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OfferedSecuOpen (msosecuCallbackObject);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='offeredSecuOpen' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.IMsoSecu']]"
		[Register ("offeredSecuOpen", "(Lcom/morpho/morphosmart/sdk/IMsoSecu;)I", "GetOfferedSecuOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_Handler")]
		public virtual unsafe int OfferedSecuOpen (global::Com.Morpho.Morphosmart.Sdk.IMsoSecu msosecuCallbackObject)
		{
			const string __id = "offeredSecuOpen.(Lcom/morpho/morphosmart/sdk/IMsoSecu;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((msosecuCallbackObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msosecuCallbackObject).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_openDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpenDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_IHandler ()
		{
			if (cb_openDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_I == null)
				cb_openDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, int, int>) n_OpenDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_I);
			return cb_openDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_I;
		}

		static int n_OpenDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_callBack, IntPtr native_ip, int port, IntPtr native_serialNumber, int timeout)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.IMsoPipe callBack = (global::Com.Morpho.Morphosmart.Sdk.IMsoPipe)global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoPipe> (native_callBack, JniHandleOwnership.DoNotTransfer);
			string ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
			string serialNumber = JNIEnv.GetString (native_serialNumber, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenDevicePipe (callBack, ip, port, serialNumber, timeout);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='openDevicePipe' and count(parameter)=5 and parameter[1][@type='com.morpho.morphosmart.sdk.IMsoPipe'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='int']]"
		[Register ("openDevicePipe", "(Lcom/morpho/morphosmart/sdk/IMsoPipe;Ljava/lang/String;ILjava/lang/String;I)I", "GetOpenDevicePipe_Lcom_morpho_morphosmart_sdk_IMsoPipe_Ljava_lang_String_ILjava_lang_String_IHandler")]
		public virtual unsafe int OpenDevicePipe (global::Com.Morpho.Morphosmart.Sdk.IMsoPipe callBack, string ip, int port, string serialNumber, int timeout)
		{
			const string __id = "openDevicePipe.(Lcom/morpho/morphosmart/sdk/IMsoPipe;Ljava/lang/String;ILjava/lang/String;I)I";
			IntPtr native_ip = JNIEnv.NewString (ip);
			IntPtr native_serialNumber = JNIEnv.NewString (serialNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((callBack == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callBack).Handle);
				__args [1] = new JniArgumentValue (native_ip);
				__args [2] = new JniArgumentValue (port);
				__args [3] = new JniArgumentValue (native_serialNumber);
				__args [4] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
				JNIEnv.DeleteLocalRef (native_serialNumber);
			}
		}

		static Delegate cb_openUsbDevice_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpenUsbDevice_Ljava_lang_String_IHandler ()
		{
			if (cb_openUsbDevice_Ljava_lang_String_I == null)
				cb_openUsbDevice_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_OpenUsbDevice_Ljava_lang_String_I);
			return cb_openUsbDevice_Ljava_lang_String_I;
		}

		static int n_OpenUsbDevice_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_sensorName, int timeOut)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string sensorName = JNIEnv.GetString (native_sensorName, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenUsbDevice (sensorName, timeOut);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='openUsbDevice' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("openUsbDevice", "(Ljava/lang/String;I)I", "GetOpenUsbDevice_Ljava_lang_String_IHandler")]
		public virtual unsafe int OpenUsbDevice (string sensorName, int timeOut)
		{
			const string __id = "openUsbDevice.(Ljava/lang/String;I)I";
			IntPtr native_sensorName = JNIEnv.NewString (sensorName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_sensorName);
				__args [1] = new JniArgumentValue (timeOut);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_sensorName);
			}
		}

		static Delegate cb_openUsbDeviceFD_IIII;
#pragma warning disable 0169
		static Delegate GetOpenUsbDeviceFD_IIIIHandler ()
		{
			if (cb_openUsbDeviceFD_IIII == null)
				cb_openUsbDeviceFD_IIII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int, int, int>) n_OpenUsbDeviceFD_IIII);
			return cb_openUsbDeviceFD_IIII;
		}

		static int n_OpenUsbDeviceFD_IIII (IntPtr jnienv, IntPtr native__this, int bus, int address, int fd, int timeOut)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OpenUsbDeviceFD (bus, address, fd, timeOut);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='openUsbDeviceFD' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("openUsbDeviceFD", "(IIII)I", "GetOpenUsbDeviceFD_IIIIHandler")]
		public virtual unsafe int OpenUsbDeviceFD (int bus, int address, int fd, int timeOut)
		{
			const string __id = "openUsbDeviceFD.(IIII)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (bus);
				__args [1] = new JniArgumentValue (address);
				__args [2] = new JniArgumentValue (fd);
				__args [3] = new JniArgumentValue (timeOut);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ping;
#pragma warning disable 0169
		static Delegate GetPingHandler ()
		{
			if (cb_ping == null)
				cb_ping = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Ping);
			return cb_ping;
		}

		static int n_Ping (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ping ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='ping' and count(parameter)=0]"
		[Register ("ping", "()I", "GetPingHandler")]
		public virtual unsafe int Ping ()
		{
			const string __id = "ping.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_rebootSoft_ILjava_util_Observer_;
#pragma warning disable 0169
		static Delegate GetRebootSoft_ILjava_util_Observer_Handler ()
		{
			if (cb_rebootSoft_ILjava_util_Observer_ == null)
				cb_rebootSoft_ILjava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_RebootSoft_ILjava_util_Observer_);
			return cb_rebootSoft_ILjava_util_Observer_;
		}

		static int n_RebootSoft_ILjava_util_Observer_ (IntPtr jnienv, IntPtr native__this, int timeOut, IntPtr native__callback)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RebootSoft (timeOut, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='rebootSoft' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Observer']]"
		[Register ("rebootSoft", "(ILjava/util/Observer;)I", "GetRebootSoft_ILjava_util_Observer_Handler")]
		public virtual unsafe int RebootSoft (int timeOut, global::Java.Util.IObserver @callback)
		{
			const string __id = "rebootSoft.(ILjava/util/Observer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeOut);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeUserAreaData;
#pragma warning disable 0169
		static Delegate GetRemoveUserAreaDataHandler ()
		{
			if (cb_removeUserAreaData == null)
				cb_removeUserAreaData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_RemoveUserAreaData);
			return cb_removeUserAreaData;
		}

		static int n_RemoveUserAreaData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveUserAreaData ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='removeUserAreaData' and count(parameter)=0]"
		[Register ("removeUserAreaData", "()I", "GetRemoveUserAreaDataHandler")]
		public virtual unsafe int RemoveUserAreaData ()
		{
			const string __id = "removeUserAreaData.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resumeConnection_ILjava_util_Observer_;
#pragma warning disable 0169
		static Delegate GetResumeConnection_ILjava_util_Observer_Handler ()
		{
			if (cb_resumeConnection_ILjava_util_Observer_ == null)
				cb_resumeConnection_ILjava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ResumeConnection_ILjava_util_Observer_);
			return cb_resumeConnection_ILjava_util_Observer_;
		}

		static int n_ResumeConnection_ILjava_util_Observer_ (IntPtr jnienv, IntPtr native__this, int timeOut, IntPtr native_observer)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver observer = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native_observer, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ResumeConnection (timeOut, observer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='resumeConnection' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.util.Observer']]"
		[Register ("resumeConnection", "(ILjava/util/Observer;)I", "GetResumeConnection_ILjava_util_Observer_Handler")]
		public virtual unsafe int ResumeConnection (int timeOut, global::Java.Util.IObserver observer)
		{
			const string __id = "resumeConnection.(ILjava/util/Observer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (timeOut);
				__args [1] = new JniArgumentValue ((observer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) observer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setConfigParam_IarrayB;
#pragma warning disable 0169
		static Delegate GetSetConfigParam_IarrayBHandler ()
		{
			if (cb_setConfigParam_IarrayB == null)
				cb_setConfigParam_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_SetConfigParam_IarrayB);
			return cb_setConfigParam_IarrayB;
		}

		static int n_SetConfigParam_IarrayB (IntPtr jnienv, IntPtr native__this, int tag, IntPtr native_paramValue)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] paramValue = (byte[]) JNIEnv.GetArray (native_paramValue, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SetConfigParam (tag, paramValue);
			if (paramValue != null)
				JNIEnv.CopyArray (paramValue, native_paramValue);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setConfigParam' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("setConfigParam", "(I[B)I", "GetSetConfigParam_IarrayBHandler")]
		public virtual unsafe int SetConfigParam (int tag, byte[] paramValue)
		{
			const string __id = "setConfigParam.(I[B)I";
			IntPtr native_paramValue = JNIEnv.NewArray (paramValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (tag);
				__args [1] = new JniArgumentValue (native_paramValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (paramValue != null) {
					JNIEnv.CopyArray (native_paramValue, paramValue);
					JNIEnv.DeleteLocalRef (native_paramValue);
				}
			}
		}

		static Delegate cb_setLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_;
#pragma warning disable 0169
		static Delegate GetSetLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_Handler ()
		{
			if (cb_setLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_ == null)
				cb_setLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_SetLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_);
			return cb_setLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_;
		}

		static int n_SetLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_ (IntPtr jnienv, IntPtr native__this, int groupID, IntPtr native_morphoLogLevel)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel morphoLogLevel = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (native_morphoLogLevel, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetLoggingLevelOfGroup (groupID, morphoLogLevel);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setLoggingLevelOfGroup' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoLogLevel']]"
		[Register ("setLoggingLevelOfGroup", "(ILcom/morpho/morphosmart/sdk/MorphoLogLevel;)I", "GetSetLoggingLevelOfGroup_ILcom_morpho_morphosmart_sdk_MorphoLogLevel_Handler")]
		public virtual unsafe int SetLoggingLevelOfGroup (int groupID, global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel morphoLogLevel)
		{
			const string __id = "setLoggingLevelOfGroup.(ILcom/morpho/morphosmart/sdk/MorphoLogLevel;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (groupID);
				__args [1] = new JniArgumentValue ((morphoLogLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoLogLevel).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_;
#pragma warning disable 0169
		static Delegate GetSetLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_Handler ()
		{
			if (cb_setLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_ == null)
				cb_setLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_);
			return cb_setLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_;
		}

		static int n_SetLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_morphoLogMode)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoLogMode morphoLogMode = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogMode> (native_morphoLogMode, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetLoggingMode (morphoLogMode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setLoggingMode' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoLogMode']]"
		[Register ("setLoggingMode", "(Lcom/morpho/morphosmart/sdk/MorphoLogMode;)I", "GetSetLoggingMode_Lcom_morpho_morphosmart_sdk_MorphoLogMode_Handler")]
		public virtual unsafe int SetLoggingMode (global::Com.Morpho.Morphosmart.Sdk.MorphoLogMode morphoLogMode)
		{
			const string __id = "setLoggingMode.(Lcom/morpho/morphosmart/sdk/MorphoLogMode;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((morphoLogMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoLogMode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setMorphoDeviceNativePointerCPP_J;
#pragma warning disable 0169
		static Delegate GetSetMorphoDeviceNativePointerCPP_JHandler ()
		{
			if (cb_setMorphoDeviceNativePointerCPP_J == null)
				cb_setMorphoDeviceNativePointerCPP_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMorphoDeviceNativePointerCPP_J);
			return cb_setMorphoDeviceNativePointerCPP_J;
		}

		static void n_SetMorphoDeviceNativePointerCPP_J (IntPtr jnienv, IntPtr native__this, long morphoDevicePointerCPP)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMorphoDeviceNativePointerCPP (morphoDevicePointerCPP);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setMorphoDeviceNativePointerCPP' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setMorphoDeviceNativePointerCPP", "(J)V", "GetSetMorphoDeviceNativePointerCPP_JHandler")]
		public virtual unsafe void SetMorphoDeviceNativePointerCPP (long morphoDevicePointerCPP)
		{
			const string __id = "setMorphoDeviceNativePointerCPP.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (morphoDevicePointerCPP);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_;
#pragma warning disable 0169
		static Delegate GetSetPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_Handler ()
		{
			if (cb_setPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_ == null)
				cb_setPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SetPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_);
			return cb_setPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_;
		}

		static int n_SetPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_ (IntPtr jnienv, IntPtr native__this, IntPtr native_status, IntPtr native_dbProcessing)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus status = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus> (native_status, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice dbProcessing = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice> (native_dbProcessing, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetPrivacyModeStatus (status, dbProcessing);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setPrivacyModeStatus' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoDevice.MorphoDevicePrivacyModeStatus'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice']]"
		[Register ("setPrivacyModeStatus", "(Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;)I", "GetSetPrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeStatus_Lcom_morpho_morphosmart_sdk_MorphoDevice_MorphoDevicePrivacyModeDBProcessingChoice_Handler")]
		public virtual unsafe int SetPrivacyModeStatus (global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeStatus status, global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.MorphoDevicePrivacyModeDBProcessingChoice dbProcessing)
		{
			const string __id = "setPrivacyModeStatus.(Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeStatus;Lcom/morpho/morphosmart/sdk/MorphoDevice$MorphoDevicePrivacyModeDBProcessingChoice;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((status == null) ? IntPtr.Zero : ((global::Java.Lang.Object) status).Handle);
				__args [1] = new JniArgumentValue ((dbProcessing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dbProcessing).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_;
#pragma warning disable 0169
		static Delegate GetSetSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_Handler ()
		{
			if (cb_setSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_ == null)
				cb_setSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_);
			return cb_setSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_;
		}

		static int n_SetSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_securityLevel)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.SecurityLevel securityLevel = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecurityLevel> (native_securityLevel, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetSecurityLevel (securityLevel);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setSecurityLevel' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.SecurityLevel']]"
		[Register ("setSecurityLevel", "(Lcom/morpho/morphosmart/sdk/SecurityLevel;)I", "GetSetSecurityLevel_Lcom_morpho_morphosmart_sdk_SecurityLevel_Handler")]
		public virtual unsafe int SetSecurityLevel (global::Com.Morpho.Morphosmart.Sdk.SecurityLevel securityLevel)
		{
			const string __id = "setSecurityLevel.(Lcom/morpho/morphosmart/sdk/SecurityLevel;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((securityLevel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) securityLevel).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_;
#pragma warning disable 0169
		static Delegate GetSetStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_Handler ()
		{
			if (cb_setStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_ == null)
				cb_setStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_);
			return cb_setStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_;
		}

		static int n_SetStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_strategyAcquisitionMode)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode strategyAcquisitionMode = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (native_strategyAcquisitionMode, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetStrategyAcquisitionMode (strategyAcquisitionMode);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setStrategyAcquisitionMode' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.StrategyAcquisitionMode']]"
		[Register ("setStrategyAcquisitionMode", "(Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;)I", "GetSetStrategyAcquisitionMode_Lcom_morpho_morphosmart_sdk_StrategyAcquisitionMode_Handler")]
		public virtual unsafe int SetStrategyAcquisitionMode (global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode strategyAcquisitionMode)
		{
			const string __id = "setStrategyAcquisitionMode.(Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((strategyAcquisitionMode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) strategyAcquisitionMode).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setUserAreaData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetUserAreaData_arrayBHandler ()
		{
			if (cb_setUserAreaData_arrayB == null)
				cb_setUserAreaData_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetUserAreaData_arrayB);
			return cb_setUserAreaData_arrayB;
		}

		static int n_SetUserAreaData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_userAreaData)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] userAreaData = (byte[]) JNIEnv.GetArray (native_userAreaData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.SetUserAreaData (userAreaData);
			if (userAreaData != null)
				JNIEnv.CopyArray (userAreaData, native_userAreaData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='setUserAreaData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setUserAreaData", "([B)I", "GetSetUserAreaData_arrayBHandler")]
		public virtual unsafe int SetUserAreaData (byte[] userAreaData)
		{
			const string __id = "setUserAreaData.([B)I";
			IntPtr native_userAreaData = JNIEnv.NewArray (userAreaData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userAreaData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (userAreaData != null) {
					JNIEnv.CopyArray (native_userAreaData, userAreaData);
					JNIEnv.DeleteLocalRef (native_userAreaData);
				}
			}
		}

		static Delegate cb_tunnelingClose;
#pragma warning disable 0169
		static Delegate GetTunnelingCloseHandler ()
		{
			if (cb_tunnelingClose == null)
				cb_tunnelingClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TunnelingClose);
			return cb_tunnelingClose;
		}

		static int n_TunnelingClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TunnelingClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='tunnelingClose' and count(parameter)=0]"
		[Register ("tunnelingClose", "()I", "GetTunnelingCloseHandler")]
		public virtual unsafe int TunnelingClose ()
		{
			const string __id = "tunnelingClose.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_tunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayB;
#pragma warning disable 0169
		static Delegate GetTunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayBHandler ()
		{
			if (cb_tunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayB == null)
				cb_tunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayB);
			return cb_tunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayB;
		}

		static int n_TunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_msosecuCallbackObject, IntPtr native_hostCertificate)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu msosecuCallbackObject = (global::Com.Morpho.Morphosmart.Sdk.IMsoSecu)global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (native_msosecuCallbackObject, JniHandleOwnership.DoNotTransfer);
			byte[] hostCertificate = (byte[]) JNIEnv.GetArray (native_hostCertificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TunnelingOpen (msosecuCallbackObject, hostCertificate);
			if (hostCertificate != null)
				JNIEnv.CopyArray (hostCertificate, native_hostCertificate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='tunnelingOpen' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.sdk.IMsoSecu'] and parameter[2][@type='byte[]']]"
		[Register ("tunnelingOpen", "(Lcom/morpho/morphosmart/sdk/IMsoSecu;[B)I", "GetTunnelingOpen_Lcom_morpho_morphosmart_sdk_IMsoSecu_arrayBHandler")]
		public virtual unsafe int TunnelingOpen (global::Com.Morpho.Morphosmart.Sdk.IMsoSecu msosecuCallbackObject, byte[] hostCertificate)
		{
			const string __id = "tunnelingOpen.(Lcom/morpho/morphosmart/sdk/IMsoSecu;[B)I";
			IntPtr native_hostCertificate = JNIEnv.NewArray (hostCertificate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((msosecuCallbackObject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) msosecuCallbackObject).Handle);
				__args [1] = new JniArgumentValue (native_hostCertificate);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (hostCertificate != null) {
					JNIEnv.CopyArray (native_hostCertificate, hostCertificate);
					JNIEnv.DeleteLocalRef (native_hostCertificate);
				}
			}
		}

		static Delegate cb_unlock_arrayBarrayB;
#pragma warning disable 0169
		static Delegate GetUnlock_arrayBarrayBHandler ()
		{
			if (cb_unlock_arrayBarrayB == null)
				cb_unlock_arrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Unlock_arrayBarrayB);
			return cb_unlock_arrayBarrayB;
		}

		static int n_Unlock_arrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_secretID, IntPtr native_cipheredSeed)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] secretID = (byte[]) JNIEnv.GetArray (native_secretID, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] cipheredSeed = (byte[]) JNIEnv.GetArray (native_cipheredSeed, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Unlock (secretID, cipheredSeed);
			if (secretID != null)
				JNIEnv.CopyArray (secretID, native_secretID);
			if (cipheredSeed != null)
				JNIEnv.CopyArray (cipheredSeed, native_cipheredSeed);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='unlock' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]']]"
		[Register ("unlock", "([B[B)I", "GetUnlock_arrayBarrayBHandler")]
		public virtual unsafe int Unlock (byte[] secretID, byte[] cipheredSeed)
		{
			const string __id = "unlock.([B[B)I";
			IntPtr native_secretID = JNIEnv.NewArray (secretID);
			IntPtr native_cipheredSeed = JNIEnv.NewArray (cipheredSeed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_secretID);
				__args [1] = new JniArgumentValue (native_cipheredSeed);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (secretID != null) {
					JNIEnv.CopyArray (native_secretID, secretID);
					JNIEnv.DeleteLocalRef (native_secretID);
				}
				if (cipheredSeed != null) {
					JNIEnv.CopyArray (native_cipheredSeed, cipheredSeed);
					JNIEnv.DeleteLocalRef (native_cipheredSeed);
				}
			}
		}

		static Delegate cb_unlock_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetUnlock_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_unlock_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_unlock_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Unlock_Ljava_lang_String_Ljava_lang_String_);
			return cb_unlock_Ljava_lang_String_Ljava_lang_String_;
		}

		[Obsolete]
		static int n_Unlock_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_secretID, IntPtr native_cipheredSeed)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string secretID = JNIEnv.GetString (native_secretID, JniHandleOwnership.DoNotTransfer);
			string cipheredSeed = JNIEnv.GetString (native_cipheredSeed, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Unlock (secretID, cipheredSeed);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='unlock' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Obsolete (@"deprecated")]
		[Register ("unlock", "(Ljava/lang/String;Ljava/lang/String;)I", "GetUnlock_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe int Unlock (string secretID, string cipheredSeed)
		{
			const string __id = "unlock.(Ljava/lang/String;Ljava/lang/String;)I";
			IntPtr native_secretID = JNIEnv.NewString (secretID);
			IntPtr native_cipheredSeed = JNIEnv.NewString (cipheredSeed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_secretID);
				__args [1] = new JniArgumentValue (native_cipheredSeed);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_secretID);
				JNIEnv.DeleteLocalRef (native_cipheredSeed);
			}
		}

		static Delegate cb_verify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_;
#pragma warning disable 0169
		static Delegate GetVerify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Handler ()
		{
			if (cb_verify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ == null)
				cb_verify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, int, IntPtr, int, IntPtr, IntPtr, int>) n_Verify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_);
			return cb_verify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_;
		}

		static int n_Verify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ (IntPtr jnienv, IntPtr native__this, int timeOut, int far, IntPtr native_coder, int detectModeChoice, int matchingStrategy, IntPtr native_templateList, int callbackCmd, IntPtr native__callback, IntPtr native_resultMatching)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Coder coder = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (native_coder, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (native_templateList, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (native_resultMatching, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Verify (timeOut, far, coder, detectModeChoice, matchingStrategy, templateList, callbackCmd, @callback, resultMatching);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='verify' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.Coder'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='com.morpho.morphosmart.sdk.TemplateList'] and parameter[7][@type='int'] and parameter[8][@type='java.util.Observer'] and parameter[9][@type='com.morpho.morphosmart.sdk.ResultMatching']]"
		[Register ("verify", "(IILcom/morpho/morphosmart/sdk/Coder;IILcom/morpho/morphosmart/sdk/TemplateList;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;)I", "GetVerify_IILcom_morpho_morphosmart_sdk_Coder_IILcom_morpho_morphosmart_sdk_TemplateList_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Handler")]
		public virtual unsafe int Verify (int timeOut, int far, global::Com.Morpho.Morphosmart.Sdk.Coder coder, int detectModeChoice, int matchingStrategy, global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList, int callbackCmd, global::Java.Util.IObserver @callback, global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching)
		{
			const string __id = "verify.(IILcom/morpho/morphosmart/sdk/Coder;IILcom/morpho/morphosmart/sdk/TemplateList;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (timeOut);
				__args [1] = new JniArgumentValue (far);
				__args [2] = new JniArgumentValue ((coder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coder).Handle);
				__args [3] = new JniArgumentValue (detectModeChoice);
				__args [4] = new JniArgumentValue (matchingStrategy);
				__args [5] = new JniArgumentValue ((templateList == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateList).Handle);
				__args [6] = new JniArgumentValue (callbackCmd);
				__args [7] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [8] = new JniArgumentValue ((resultMatching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultMatching).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_verifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetVerifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_Handler ()
		{
			if (cb_verifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_ == null)
				cb_verifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int>) n_VerifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_);
			return cb_verifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_;
		}

		static int n_VerifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, int far, IntPtr native_templateListSearch, IntPtr native_templateListReference, IntPtr native_matchingScore)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateList templateListSearch = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (native_templateListSearch, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateList templateListReference = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (native_templateListReference, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer matchingScore = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_matchingScore, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.VerifyMatch (far, templateListSearch, templateListReference, matchingScore);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDevice']/method[@name='verifyMatch' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.TemplateList'] and parameter[3][@type='com.morpho.morphosmart.sdk.TemplateList'] and parameter[4][@type='java.lang.Integer']]"
		[Register ("verifyMatch", "(ILcom/morpho/morphosmart/sdk/TemplateList;Lcom/morpho/morphosmart/sdk/TemplateList;Ljava/lang/Integer;)I", "GetVerifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_TemplateList_Ljava_lang_Integer_Handler")]
		public virtual unsafe int VerifyMatch (int far, global::Com.Morpho.Morphosmart.Sdk.TemplateList templateListSearch, global::Com.Morpho.Morphosmart.Sdk.TemplateList templateListReference, global::Java.Lang.Integer matchingScore)
		{
			const string __id = "verifyMatch.(ILcom/morpho/morphosmart/sdk/TemplateList;Lcom/morpho/morphosmart/sdk/TemplateList;Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (far);
				__args [1] = new JniArgumentValue ((templateListSearch == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateListSearch).Handle);
				__args [2] = new JniArgumentValue ((templateListReference == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateListReference).Handle);
				__args [3] = new JniArgumentValue ((matchingScore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchingScore).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
