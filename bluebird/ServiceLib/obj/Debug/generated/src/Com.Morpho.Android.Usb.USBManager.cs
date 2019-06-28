using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Android.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']"
	[global::Android.Runtime.Register ("com/morpho/android/usb/USBManager", DoNotGenerateAcw=true)]
	public partial class USBManager : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='ACTION_USB_PERMISSION']"
		[Register ("ACTION_USB_PERMISSION")]
		public static string ActionUsbPermission {
			get {
				const string __id = "ACTION_USB_PERMISSION.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "ACTION_USB_PERMISSION.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_CBM']"
		[Register ("SOFTWAREID_CBM")]
		public const string SoftwareidCbm = (string) "CBM";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_CBME3']"
		[Register ("SOFTWAREID_CBME3")]
		public const string SoftwareidCbme3 = (string) "CBM-E3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_CBMV3']"
		[Register ("SOFTWAREID_CBMV3")]
		public const string SoftwareidCbmv3 = (string) "CBM-V3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_FVP']"
		[Register ("SOFTWAREID_FVP")]
		public const string SoftwareidFvp = (string) "MSO FVP";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_FVP_C']"
		[Register ("SOFTWAREID_FVP_C")]
		public const string SoftwareidFvpC = (string) "MSO FVP_C";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_FVP_CL']"
		[Register ("SOFTWAREID_FVP_CL")]
		public const string SoftwareidFvpCl = (string) "MSO FVP_CL";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MASIGMA']"
		[Register ("SOFTWAREID_MASIGMA")]
		public const string SoftwareidMasigma = (string) "MA SIGMA";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MEP']"
		[Register ("SOFTWAREID_MEP")]
		public const string SoftwareidMep = (string) "MEPUSB";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO100']"
		[Register ("SOFTWAREID_MSO100")]
		public const string SoftwareidMso100 = (string) "MSO100";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO1300E3']"
		[Register ("SOFTWAREID_MSO1300E3")]
		public const string SoftwareidMso1300e3 = (string) "MSO1300-E3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO1300V3']"
		[Register ("SOFTWAREID_MSO1300V3")]
		public const string SoftwareidMso1300v3 = (string) "MSO1300-V3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO1350']"
		[Register ("SOFTWAREID_MSO1350")]
		public const string SoftwareidMso1350 = (string) "MSO1350";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO1350E3']"
		[Register ("SOFTWAREID_MSO1350E3")]
		public const string SoftwareidMso1350e3 = (string) "MSO1350-E3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO1350V3']"
		[Register ("SOFTWAREID_MSO1350V3")]
		public const string SoftwareidMso1350v3 = (string) "MSO1350-V3";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO300']"
		[Register ("SOFTWAREID_MSO300")]
		public const string SoftwareidMso300 = (string) "MSO300";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='SOFTWAREID_MSO350']"
		[Register ("SOFTWAREID_MSO350")]
		public const string SoftwareidMso350 = (string) "MSO350";


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='WakeLockEnabled']"
		[Register ("WakeLockEnabled")]
		public static bool WakeLockEnabled {
			get {
				const string __id = "WakeLockEnabled.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "WakeLockEnabled.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='context']"
		[Register ("context")]
		public static global::Android.Content.Context Context {
			get {
				const string __id = "context.Landroid/content/Context;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "context.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='screenReceiverMap']"
		[Register ("screenReceiverMap")]
		public static global::System.Collections.IDictionary ScreenReceiverMap {
			get {
				const string __id = "screenReceiverMap.Ljava/util/Map;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "screenReceiverMap.Ljava/util/Map;";

				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/field[@name='waitReboot']"
		[Register ("waitReboot")]
		public static bool WaitReboot {
			get {
				const string __id = "waitReboot.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "waitReboot.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager.MphDevice']"
		[global::Android.Runtime.Register ("com/morpho/android/usb/USBManager$MphDevice", DoNotGenerateAcw=true)]
		public partial class MphDevice : global::Java.Lang.Object {

			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/android/usb/USBManager$MphDevice", typeof (MphDevice));
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

			protected MphDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager.MphDevice']/constructor[@name='USBManager.MphDevice' and count(parameter)=1 and parameter[1][@type='com.morpho.android.usb.USBManager']]"
			[Register (".ctor", "(Lcom/morpho/android/usb/USBManager;)V", "")]
			public unsafe MphDevice (global::Com.Morpho.Android.Usb.USBManager __self)
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager.MphDevice']/constructor[@name='USBManager.MphDevice' and count(parameter)=4 and parameter[1][@type='com.morpho.android.usb.USBManager'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.hardware.usb.UsbDevice'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Lcom/morpho/android/usb/USBManager;Ljava/lang/String;Landroid/hardware/usb/UsbDevice;I)V", "")]
			public unsafe MphDevice (global::Com.Morpho.Android.Usb.USBManager __self, string devName, global::Android.Hardware.Usb.UsbDevice usbDevice, int usbEvent)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Ljava/lang/String;Landroid/hardware/usb/UsbDevice;I)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_devName = JNIEnv.NewString (devName);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue (native_devName);
					__args [2] = new JniArgumentValue ((usbDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) usbDevice).Handle);
					__args [3] = new JniArgumentValue (usbEvent);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_devName);
				}
			}

			static Delegate cb_getDevName;
#pragma warning disable 0169
			static Delegate GetGetDevNameHandler ()
			{
				if (cb_getDevName == null)
					cb_getDevName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDevName);
				return cb_getDevName;
			}

			static IntPtr n_GetDevName (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Morpho.Android.Usb.USBManager.MphDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager.MphDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.DevName);
			}
#pragma warning restore 0169

			public virtual unsafe string DevName {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager.MphDevice']/method[@name='getDevName' and count(parameter)=0]"
				[Register ("getDevName", "()Ljava/lang/String;", "GetGetDevNameHandler")]
				get {
					const string __id = "getDevName.()Ljava/lang/String;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getUsbDevice;
#pragma warning disable 0169
			static Delegate GetGetUsbDeviceHandler ()
			{
				if (cb_getUsbDevice == null)
					cb_getUsbDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsbDevice);
				return cb_getUsbDevice;
			}

			static IntPtr n_GetUsbDevice (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Morpho.Android.Usb.USBManager.MphDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager.MphDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.UsbDevice);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Hardware.Usb.UsbDevice UsbDevice {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager.MphDevice']/method[@name='getUsbDevice' and count(parameter)=0]"
				[Register ("getUsbDevice", "()Landroid/hardware/usb/UsbDevice;", "GetGetUsbDeviceHandler")]
				get {
					const string __id = "getUsbDevice.()Landroid/hardware/usb/UsbDevice;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getUsbEvent;
#pragma warning disable 0169
			static Delegate GetGetUsbEventHandler ()
			{
				if (cb_getUsbEvent == null)
					cb_getUsbEvent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUsbEvent);
				return cb_getUsbEvent;
			}

			static int n_GetUsbEvent (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Morpho.Android.Usb.USBManager.MphDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager.MphDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.UsbEvent;
			}
#pragma warning restore 0169

			public virtual unsafe int UsbEvent {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager.MphDevice']/method[@name='getUsbEvent' and count(parameter)=0]"
				[Register ("getUsbEvent", "()I", "GetGetUsbEventHandler")]
				get {
					const string __id = "getUsbEvent.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/android/usb/USBManager", typeof (USBManager));
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

		protected USBManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Morpho.Android.Usb.USBManager Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/morpho/android/usb/USBManager;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/morpho/android/usb/USBManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDevicesHasPermission;
#pragma warning disable 0169
		static Delegate GetIsDevicesHasPermissionHandler ()
		{
			if (cb_isDevicesHasPermission == null)
				cb_isDevicesHasPermission = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDevicesHasPermission);
			return cb_isDevicesHasPermission;
		}

		static bool n_IsDevicesHasPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDevicesHasPermission;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDevicesHasPermission {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='isDevicesHasPermission' and count(parameter)=0]"
			[Register ("isDevicesHasPermission", "()Z", "GetIsDevicesHasPermissionHandler")]
			get {
				const string __id = "isDevicesHasPermission.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNbDevices;
#pragma warning disable 0169
		static Delegate GetGetNbDevicesHandler ()
		{
			if (cb_getNbDevices == null)
				cb_getNbDevices = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbDevices);
			return cb_getNbDevices;
		}

		static int n_GetNbDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbDevices;
		}
#pragma warning restore 0169

		public virtual unsafe int NbDevices {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getNbDevices' and count(parameter)=0]"
			[Register ("getNbDevices", "()I", "GetGetNbDevicesHandler")]
			get {
				const string __id = "getNbDevices.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUsbDaemonVersion;
#pragma warning disable 0169
		static Delegate GetGetUsbDaemonVersionHandler ()
		{
			if (cb_getUsbDaemonVersion == null)
				cb_getUsbDaemonVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUsbDaemonVersion);
			return cb_getUsbDaemonVersion;
		}

		static IntPtr n_GetUsbDaemonVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UsbDaemonVersion);
		}
#pragma warning restore 0169

		public virtual unsafe string UsbDaemonVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getUsbDaemonVersion' and count(parameter)=0]"
			[Register ("getUsbDaemonVersion", "()Ljava/lang/String;", "GetGetUsbDaemonVersionHandler")]
			get {
				const string __id = "getUsbDaemonVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_IsUsbDaemonStarted;
#pragma warning disable 0169
		static Delegate GetIsUsbDaemonStartedHandler ()
		{
			if (cb_IsUsbDaemonStarted == null)
				cb_IsUsbDaemonStarted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_IsUsbDaemonStarted);
			return cb_IsUsbDaemonStarted;
		}

		static int n_IsUsbDaemonStarted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUsbDaemonStarted ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='IsUsbDaemonStarted' and count(parameter)=0]"
		[Register ("IsUsbDaemonStarted", "()I", "GetIsUsbDaemonStartedHandler")]
		public virtual unsafe int IsUsbDaemonStarted ()
		{
			const string __id = "IsUsbDaemonStarted.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkWakeLockPermission_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetCheckWakeLockPermission_Landroid_content_Context_Handler ()
		{
			if (cb_checkWakeLockPermission_Landroid_content_Context_ == null)
				cb_checkWakeLockPermission_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CheckWakeLockPermission_Landroid_content_Context_);
			return cb_checkWakeLockPermission_Landroid_content_Context_;
		}

		static void n_CheckWakeLockPermission_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.CheckWakeLockPermission (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='checkWakeLockPermission' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("checkWakeLockPermission", "(Landroid/content/Context;)V", "GetCheckWakeLockPermission_Landroid_content_Context_Handler")]
		public virtual unsafe void CheckWakeLockPermission (global::Android.Content.Context context)
		{
			const string __id = "checkWakeLockPermission.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_closeUsbDeviceConnection;
#pragma warning disable 0169
		static Delegate GetCloseUsbDeviceConnectionHandler ()
		{
			if (cb_closeUsbDeviceConnection == null)
				cb_closeUsbDeviceConnection = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CloseUsbDeviceConnection);
			return cb_closeUsbDeviceConnection;
		}

		static void n_CloseUsbDeviceConnection (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseUsbDeviceConnection ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='closeUsbDeviceConnection' and count(parameter)=0]"
		[Register ("closeUsbDeviceConnection", "()V", "GetCloseUsbDeviceConnectionHandler")]
		public virtual unsafe void CloseUsbDeviceConnection ()
		{
			const string __id = "closeUsbDeviceConnection.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enumerate;
#pragma warning disable 0169
		static Delegate GetEnumerateHandler ()
		{
			if (cb_enumerate == null)
				cb_enumerate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Enumerate);
			return cb_enumerate;
		}

		static IntPtr n_Enumerate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.Enumerate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='enumerate' and count(parameter)=0]"
		[Register ("enumerate", "()[Lcom/morpho/android/usb/USBDeviceAttributes;", "GetEnumerateHandler")]
		public virtual unsafe global::Com.Morpho.Android.Usb.USBDeviceAttributes[] Enumerate ()
		{
			const string __id = "enumerate.()[Lcom/morpho/android/usb/USBDeviceAttributes;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Com.Morpho.Android.Usb.USBDeviceAttributes[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Android.Usb.USBDeviceAttributes));
			} finally {
			}
		}

		static Delegate cb_getDevice_I;
#pragma warning disable 0169
		static Delegate GetGetDevice_IHandler ()
		{
			if (cb_getDevice_I == null)
				cb_getDevice_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDevice_I);
			return cb_getDevice_I;
		}

		static IntPtr n_GetDevice_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDevice (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getDevice' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDevice", "(I)Lcom/morpho/android/usb/USBDevice;", "GetGetDevice_IHandler")]
		public virtual unsafe global::Com.Morpho.Android.Usb.USBDevice GetDevice (int index)
		{
			const string __id = "getDevice.(I)Lcom/morpho/android/usb/USBDevice;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDeviceInformations_Ljava_lang_String_arrayIarrayIarrayI;
#pragma warning disable 0169
		static Delegate GetGetDeviceInformations_Ljava_lang_String_arrayIarrayIarrayIHandler ()
		{
			if (cb_getDeviceInformations_Ljava_lang_String_arrayIarrayIarrayI == null)
				cb_getDeviceInformations_Ljava_lang_String_arrayIarrayIarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetDeviceInformations_Ljava_lang_String_arrayIarrayIarrayI);
			return cb_getDeviceInformations_Ljava_lang_String_arrayIarrayIarrayI;
		}

		static int n_GetDeviceInformations_Ljava_lang_String_arrayIarrayIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_serialNumber, IntPtr native_bus, IntPtr native_address, IntPtr native_fd)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string serialNumber = JNIEnv.GetString (native_serialNumber, JniHandleOwnership.DoNotTransfer);
			int[] bus = (int[]) JNIEnv.GetArray (native_bus, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] address = (int[]) JNIEnv.GetArray (native_address, JniHandleOwnership.DoNotTransfer, typeof (int));
			int[] fd = (int[]) JNIEnv.GetArray (native_fd, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.GetDeviceInformations (serialNumber, bus, address, fd);
			if (bus != null)
				JNIEnv.CopyArray (bus, native_bus);
			if (address != null)
				JNIEnv.CopyArray (address, native_address);
			if (fd != null)
				JNIEnv.CopyArray (fd, native_fd);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getDeviceInformations' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int[]'] and parameter[3][@type='int[]'] and parameter[4][@type='int[]']]"
		[Register ("getDeviceInformations", "(Ljava/lang/String;[I[I[I)I", "GetGetDeviceInformations_Ljava_lang_String_arrayIarrayIarrayIHandler")]
		public virtual unsafe int GetDeviceInformations (string serialNumber, int[] bus, int[] address, int[] fd)
		{
			const string __id = "getDeviceInformations.(Ljava/lang/String;[I[I[I)I";
			IntPtr native_serialNumber = JNIEnv.NewString (serialNumber);
			IntPtr native_bus = JNIEnv.NewArray (bus);
			IntPtr native_address = JNIEnv.NewArray (address);
			IntPtr native_fd = JNIEnv.NewArray (fd);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_serialNumber);
				__args [1] = new JniArgumentValue (native_bus);
				__args [2] = new JniArgumentValue (native_address);
				__args [3] = new JniArgumentValue (native_fd);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_serialNumber);
				if (bus != null) {
					JNIEnv.CopyArray (native_bus, bus);
					JNIEnv.DeleteLocalRef (native_bus);
				}
				if (address != null) {
					JNIEnv.CopyArray (native_address, address);
					JNIEnv.DeleteLocalRef (native_address);
				}
				if (fd != null) {
					JNIEnv.CopyArray (native_fd, fd);
					JNIEnv.DeleteLocalRef (native_fd);
				}
			}
		}

		static Delegate cb_getDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_;
#pragma warning disable 0169
		static Delegate GetGetDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_Handler ()
		{
			if (cb_getDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_ == null)
				cb_getDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_);
			return cb_getDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_;
		}

		static IntPtr n_GetDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attribs)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Android.Usb.USBDeviceAttributes attribs = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (native_attribs, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDeviceModel (attribs));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getDeviceModel' and count(parameter)=1 and parameter[1][@type='com.morpho.android.usb.USBDeviceAttributes']]"
		[Register ("getDeviceModel", "(Lcom/morpho/android/usb/USBDeviceAttributes;)Ljava/lang/String;", "GetGetDeviceModel_Lcom_morpho_android_usb_USBDeviceAttributes_Handler")]
		public virtual unsafe string GetDeviceModel (global::Com.Morpho.Android.Usb.USBDeviceAttributes attribs)
		{
			const string __id = "getDeviceModel.(Lcom/morpho/android/usb/USBDeviceAttributes;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((attribs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attribs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getFileDescriptor_II;
#pragma warning disable 0169
		static Delegate GetGetFileDescriptor_IIHandler ()
		{
			if (cb_getFileDescriptor_II == null)
				cb_getFileDescriptor_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_GetFileDescriptor_II);
			return cb_getFileDescriptor_II;
		}

		static int n_GetFileDescriptor_II (IntPtr jnienv, IntPtr native__this, int bus, int deviceAddress)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetFileDescriptor (bus, deviceAddress);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='getFileDescriptor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("getFileDescriptor", "(II)I", "GetGetFileDescriptor_IIHandler")]
		public virtual unsafe int GetFileDescriptor (int bus, int deviceAddress)
		{
			const string __id = "getFileDescriptor.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bus);
				__args [1] = new JniArgumentValue (deviceAddress);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_initialize;
#pragma warning disable 0169
		static Delegate GetInitializeHandler ()
		{
			if (cb_initialize == null)
				cb_initialize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Initialize);
			return cb_initialize;
		}

		static void n_Initialize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Initialize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='initialize' and count(parameter)=0]"
		[Register ("initialize", "()V", "GetInitializeHandler")]
		public virtual unsafe void Initialize ()
		{
			const string __id = "initialize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initialize_Landroid_app_Activity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_app_Activity_Ljava_lang_String_Handler ()
		{
			if (cb_initialize_Landroid_app_Activity_Ljava_lang_String_ == null)
				cb_initialize_Landroid_app_Activity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Initialize_Landroid_app_Activity_Ljava_lang_String_);
			return cb_initialize_Landroid_app_Activity_Ljava_lang_String_;
		}

		static int n_Initialize_Landroid_app_Activity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_packagePath)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity context = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_context, JniHandleOwnership.DoNotTransfer);
			string packagePath = JNIEnv.GetString (native_packagePath, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Initialize (context, packagePath);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Landroid/app/Activity;Ljava/lang/String;)I", "GetInitialize_Landroid_app_Activity_Ljava_lang_String_Handler")]
		public virtual unsafe int Initialize (global::Android.App.Activity context, string packagePath)
		{
			const string __id = "initialize.(Landroid/app/Activity;Ljava/lang/String;)I";
			IntPtr native_packagePath = JNIEnv.NewString (packagePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_packagePath);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packagePath);
			}
		}

		static Delegate cb_initialize_Landroid_content_Context_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Ljava_lang_String_Handler ()
		{
			if (cb_initialize_Landroid_content_Context_Ljava_lang_String_ == null)
				cb_initialize_Landroid_content_Context_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Initialize_Landroid_content_Context_Ljava_lang_String_);
			return cb_initialize_Landroid_content_Context_Ljava_lang_String_;
		}

		static int n_Initialize_Landroid_content_Context_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_packagePath)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string packagePath = JNIEnv.GetString (native_packagePath, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Initialize (context, packagePath);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='initialize' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;)I", "GetInitialize_Landroid_content_Context_Ljava_lang_String_Handler")]
		public virtual unsafe int Initialize (global::Android.Content.Context context, string packagePath)
		{
			const string __id = "initialize.(Landroid/content/Context;Ljava/lang/String;)I";
			IntPtr native_packagePath = JNIEnv.NewString (packagePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_packagePath);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packagePath);
			}
		}

		static Delegate cb_initialize_Landroid_content_Context_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Ljava_lang_String_ZHandler ()
		{
			if (cb_initialize_Landroid_content_Context_Ljava_lang_String_Z == null)
				cb_initialize_Landroid_content_Context_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, int>) n_Initialize_Landroid_content_Context_Ljava_lang_String_Z);
			return cb_initialize_Landroid_content_Context_Ljava_lang_String_Z;
		}

		static int n_Initialize_Landroid_content_Context_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_context, IntPtr native_packagePath, bool enableWakeLock)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			string packagePath = JNIEnv.GetString (native_packagePath, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Initialize (context, packagePath, enableWakeLock);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='initialize' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("initialize", "(Landroid/content/Context;Ljava/lang/String;Z)I", "GetInitialize_Landroid_content_Context_Ljava_lang_String_ZHandler")]
		public virtual unsafe int Initialize (global::Android.Content.Context context, string packagePath, bool enableWakeLock)
		{
			const string __id = "initialize.(Landroid/content/Context;Ljava/lang/String;Z)I";
			IntPtr native_packagePath = JNIEnv.NewString (packagePath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_packagePath);
				__args [2] = new JniArgumentValue (enableWakeLock);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_packagePath);
			}
		}

		static Delegate cb_isSupported_Lcom_morpho_android_usb_USBDeviceAttributes_;
#pragma warning disable 0169
		static Delegate GetIsSupported_Lcom_morpho_android_usb_USBDeviceAttributes_Handler ()
		{
			if (cb_isSupported_Lcom_morpho_android_usb_USBDeviceAttributes_ == null)
				cb_isSupported_Lcom_morpho_android_usb_USBDeviceAttributes_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsSupported_Lcom_morpho_android_usb_USBDeviceAttributes_);
			return cb_isSupported_Lcom_morpho_android_usb_USBDeviceAttributes_;
		}

		static bool n_IsSupported_Lcom_morpho_android_usb_USBDeviceAttributes_ (IntPtr jnienv, IntPtr native__this, IntPtr native_attribs)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Android.Usb.USBDeviceAttributes attribs = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (native_attribs, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsSupported (attribs);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='isSupported' and count(parameter)=1 and parameter[1][@type='com.morpho.android.usb.USBDeviceAttributes']]"
		[Register ("isSupported", "(Lcom/morpho/android/usb/USBDeviceAttributes;)Z", "GetIsSupported_Lcom_morpho_android_usb_USBDeviceAttributes_Handler")]
		public virtual unsafe bool IsSupported (global::Com.Morpho.Android.Usb.USBDeviceAttributes attribs)
		{
			const string __id = "isSupported.(Lcom/morpho/android/usb/USBDeviceAttributes;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((attribs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attribs).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_listDevices;
#pragma warning disable 0169
		static Delegate GetListDevicesHandler ()
		{
			if (cb_listDevices == null)
				cb_listDevices = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ListDevices);
			return cb_listDevices;
		}

		static void n_ListDevices (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ListDevices ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='listDevices' and count(parameter)=0]"
		[Register ("listDevices", "()V", "GetListDevicesHandler")]
		public virtual unsafe void ListDevices ()
		{
			const string __id = "listDevices.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scanDevice;
#pragma warning disable 0169
		static Delegate GetScanDeviceHandler ()
		{
			if (cb_scanDevice == null)
				cb_scanDevice = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ScanDevice);
			return cb_scanDevice;
		}

		static int n_ScanDevice (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScanDevice ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='scanDevice' and count(parameter)=0]"
		[Register ("scanDevice", "()I", "GetScanDeviceHandler")]
		public virtual unsafe int ScanDevice ()
		{
			const string __id = "scanDevice.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBManager']/method[@name='unRegister' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoDevice.ScreenBroadcastReceiver']]"
		[Register ("unRegister", "(Landroid/content/Context;Lcom/morpho/morphosmart/sdk/MorphoDevice$ScreenBroadcastReceiver;)V", "")]
		public static unsafe void UnRegister (global::Android.Content.Context ctx, global::Com.Morpho.Morphosmart.Sdk.MorphoDevice.ScreenBroadcastReceiver receiver)
		{
			const string __id = "unRegister.(Landroid/content/Context;Lcom/morpho/morphosmart/sdk/MorphoDevice$ScreenBroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				__args [1] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
