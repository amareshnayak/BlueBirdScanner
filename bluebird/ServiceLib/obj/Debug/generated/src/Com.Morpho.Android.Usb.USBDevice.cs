using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Android.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']"
	[global::Android.Runtime.Register ("com/morpho/android/usb/USBDevice", DoNotGenerateAcw=true)]
	public partial class USBDevice : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mAttributes']"
		[Register ("mAttributes")]
		public global::Com.Morpho.Android.Usb.USBDeviceAttributes MAttributes {
			get {
				const string __id = "mAttributes.Lcom/morpho/android/usb/USBDeviceAttributes;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAttributes.Lcom/morpho/android/usb/USBDeviceAttributes;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mConnection']"
		[Register ("mConnection")]
		public global::Android.Hardware.Usb.UsbDeviceConnection MConnection {
			get {
				const string __id = "mConnection.Landroid/hardware/usb/UsbDeviceConnection;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDeviceConnection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConnection.Landroid/hardware/usb/UsbDeviceConnection;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mDevice']"
		[Register ("mDevice")]
		public global::Android.Hardware.Usb.UsbDevice MDevice {
			get {
				const string __id = "mDevice.Landroid/hardware/usb/UsbDevice;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbDevice> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDevice.Landroid/hardware/usb/UsbDevice;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mEndpointIn']"
		[Register ("mEndpointIn")]
		public global::Android.Hardware.Usb.UsbEndpoint MEndpointIn {
			get {
				const string __id = "mEndpointIn.Landroid/hardware/usb/UsbEndpoint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbEndpoint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mEndpointIn.Landroid/hardware/usb/UsbEndpoint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mEndpointOut']"
		[Register ("mEndpointOut")]
		public global::Android.Hardware.Usb.UsbEndpoint MEndpointOut {
			get {
				const string __id = "mEndpointOut.Landroid/hardware/usb/UsbEndpoint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbEndpoint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mEndpointOut.Landroid/hardware/usb/UsbEndpoint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mFreindlyName']"
		[Register ("mFreindlyName")]
		public string MFreindlyName {
			get {
				const string __id = "mFreindlyName.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFreindlyName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mInterface']"
		[Register ("mInterface")]
		public global::Android.Hardware.Usb.UsbInterface MInterface {
			get {
				const string __id = "mInterface.Landroid/hardware/usb/UsbInterface;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbInterface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mInterface.Landroid/hardware/usb/UsbInterface;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mManager']"
		[Register ("mManager")]
		public static global::Android.Hardware.Usb.UsbManager MManager {
			get {
				const string __id = "mManager.Landroid/hardware/usb/UsbManager;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbManager> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mManager.Landroid/hardware/usb/UsbManager;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mMaxPacketInSize']"
		[Register ("mMaxPacketInSize")]
		public int MMaxPacketInSize {
			get {
				const string __id = "mMaxPacketInSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxPacketInSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/field[@name='mMaxPacketOutSize']"
		[Register ("mMaxPacketOutSize")]
		public int MMaxPacketOutSize {
			get {
				const string __id = "mMaxPacketOutSize.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxPacketOutSize.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/android/usb/USBDevice", typeof (USBDevice));
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

		protected USBDevice (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/constructor[@name='USBDevice' and count(parameter)=3 and parameter[1][@type='com.morpho.android.usb.USBDeviceAttributes'] and parameter[2][@type='android.hardware.usb.UsbManager'] and parameter[3][@type='android.hardware.usb.UsbDevice']]"
		[Register (".ctor", "(Lcom/morpho/android/usb/USBDeviceAttributes;Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)V", "")]
		public unsafe USBDevice (global::Com.Morpho.Android.Usb.USBDeviceAttributes iAttributes, global::Android.Hardware.Usb.UsbManager iManager, global::Android.Hardware.Usb.UsbDevice iDevice)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/morpho/android/usb/USBDeviceAttributes;Landroid/hardware/usb/UsbManager;Landroid/hardware/usb/UsbDevice;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((iAttributes == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iAttributes).Handle);
				__args [1] = new JniArgumentValue ((iManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iManager).Handle);
				__args [2] = new JniArgumentValue ((iDevice == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iDevice).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAttributes;
#pragma warning disable 0169
		static Delegate GetGetAttributesHandler ()
		{
			if (cb_getAttributes == null)
				cb_getAttributes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAttributes);
			return cb_getAttributes;
		}

		static IntPtr n_GetAttributes (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Attributes);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Android.Usb.USBDeviceAttributes Attributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='getAttributes' and count(parameter)=0]"
			[Register ("getAttributes", "()Lcom/morpho/android/usb/USBDeviceAttributes;", "GetGetAttributesHandler")]
			get {
				const string __id = "getAttributes.()Lcom/morpho/android/usb/USBDeviceAttributes;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasPermission;
#pragma warning disable 0169
		static Delegate GetHasPermissionHandler ()
		{
			if (cb_hasPermission == null)
				cb_hasPermission = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasPermission);
			return cb_hasPermission;
		}

		static bool n_HasPermission (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasPermission;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasPermission {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='hasPermission' and count(parameter)=0]"
			[Register ("hasPermission", "()Z", "GetHasPermissionHandler")]
			get {
				const string __id = "hasPermission.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxPacketInSize;
#pragma warning disable 0169
		static Delegate GetGetMaxPacketInSizeHandler ()
		{
			if (cb_getMaxPacketInSize == null)
				cb_getMaxPacketInSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxPacketInSize);
			return cb_getMaxPacketInSize;
		}

		static int n_GetMaxPacketInSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxPacketInSize;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxPacketInSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='getMaxPacketInSize' and count(parameter)=0]"
			[Register ("getMaxPacketInSize", "()I", "GetGetMaxPacketInSizeHandler")]
			get {
				const string __id = "getMaxPacketInSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxPacketOutSize;
#pragma warning disable 0169
		static Delegate GetGetMaxPacketOutSizeHandler ()
		{
			if (cb_getMaxPacketOutSize == null)
				cb_getMaxPacketOutSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxPacketOutSize);
			return cb_getMaxPacketOutSize;
		}

		static int n_GetMaxPacketOutSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxPacketOutSize;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxPacketOutSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='getMaxPacketOutSize' and count(parameter)=0]"
			[Register ("getMaxPacketOutSize", "()I", "GetGetMaxPacketOutSizeHandler")]
			get {
				const string __id = "getMaxPacketOutSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProductString;
#pragma warning disable 0169
		static Delegate GetGetProductStringHandler ()
		{
			if (cb_getProductString == null)
				cb_getProductString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProductString);
			return cb_getProductString;
		}

		static IntPtr n_GetProductString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProductString);
		}
#pragma warning restore 0169

		public virtual unsafe string ProductString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='getProductString' and count(parameter)=0]"
			[Register ("getProductString", "()Ljava/lang/String;", "GetGetProductStringHandler")]
			get {
				const string __id = "getProductString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumberString;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberStringHandler ()
		{
			if (cb_getSerialNumberString == null)
				cb_getSerialNumberString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumberString);
			return cb_getSerialNumberString;
		}

		static IntPtr n_GetSerialNumberString (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumberString);
		}
#pragma warning restore 0169

		public virtual unsafe string SerialNumberString {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='getSerialNumberString' and count(parameter)=0]"
			[Register ("getSerialNumberString", "()Ljava/lang/String;", "GetGetSerialNumberStringHandler")]
			get {
				const string __id = "getSerialNumberString.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_CreateInterface_I;
#pragma warning disable 0169
		static Delegate GetCreateInterface_IHandler ()
		{
			if (cb_CreateInterface_I == null)
				cb_CreateInterface_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_CreateInterface_I);
			return cb_CreateInterface_I;
		}

		static IntPtr n_CreateInterface_I (IntPtr jnienv, IntPtr native__this, int interfaceNumber)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CreateInterface (interfaceNumber));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='CreateInterface' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("CreateInterface", "(I)Landroid/hardware/usb/UsbInterface;", "GetCreateInterface_IHandler")]
		public virtual unsafe global::Android.Hardware.Usb.UsbInterface CreateInterface (int interfaceNumber)
		{
			const string __id = "CreateInterface.(I)Landroid/hardware/usb/UsbInterface;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (interfaceNumber);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_claimInterface;
#pragma warning disable 0169
		static Delegate GetClaimInterfaceHandler ()
		{
			if (cb_claimInterface == null)
				cb_claimInterface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ClaimInterface);
			return cb_claimInterface;
		}

		static IntPtr n_ClaimInterface (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClaimInterface ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='claimInterface' and count(parameter)=0]"
		[Register ("claimInterface", "()Landroid/hardware/usb/UsbInterface;", "GetClaimInterfaceHandler")]
		public virtual unsafe global::Android.Hardware.Usb.UsbInterface ClaimInterface ()
		{
			const string __id = "claimInterface.()Landroid/hardware/usb/UsbInterface;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Hardware.Usb.UsbInterface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Close);
			return cb_close;
		}

		static int n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()I", "GetCloseHandler")]
		public virtual unsafe int Close ()
		{
			const string __id = "close.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_findEndPoint;
#pragma warning disable 0169
		static Delegate GetFindEndPointHandler ()
		{
			if (cb_findEndPoint == null)
				cb_findEndPoint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_FindEndPoint);
			return cb_findEndPoint;
		}

		static int n_FindEndPoint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FindEndPoint ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='findEndPoint' and count(parameter)=0]"
		[Register ("findEndPoint", "()I", "GetFindEndPointHandler")]
		public virtual unsafe int FindEndPoint ()
		{
			const string __id = "findEndPoint.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getStringSimple_arrayBI;
#pragma warning disable 0169
		static Delegate GetGetStringSimple_arrayBIHandler ()
		{
			if (cb_getStringSimple_arrayBI == null)
				cb_getStringSimple_arrayBI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_GetStringSimple_arrayBI);
			return cb_getStringSimple_arrayBI;
		}

		static int n_GetStringSimple_arrayBI (IntPtr jnienv, IntPtr native__this, IntPtr native_buffer, int index)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] buffer = (byte[]) JNIEnv.GetArray (native_buffer, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetStringSimple (buffer, index);
			if (buffer != null)
				JNIEnv.CopyArray (buffer, native_buffer);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='getStringSimple' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int']]"
		[Register ("getStringSimple", "([BI)I", "GetGetStringSimple_arrayBIHandler")]
		public virtual unsafe int GetStringSimple (byte[] buffer, int index)
		{
			const string __id = "getStringSimple.([BI)I";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
			}
		}

		static Delegate cb_open;
#pragma warning disable 0169
		static Delegate GetOpenHandler ()
		{
			if (cb_open == null)
				cb_open = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Open);
			return cb_open;
		}

		static int n_Open (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='open' and count(parameter)=0]"
		[Register ("open", "()I", "GetOpenHandler")]
		public virtual unsafe int Open ()
		{
			const string __id = "open.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_read_arrayBII;
#pragma warning disable 0169
		static Delegate GetRead_arrayBIIHandler ()
		{
			if (cb_read_arrayBII == null)
				cb_read_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Read_arrayBII);
			return cb_read_arrayBII;
		}

		static int n_Read_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int datasize, int timeout)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (data, datasize, timeout);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='read' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("read", "([BII)I", "GetRead_arrayBIIHandler")]
		public virtual unsafe int Read (byte[] data, int datasize, int timeout)
		{
			const string __id = "read.([BII)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (datasize);
				__args [2] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_write_arrayBII;
#pragma warning disable 0169
		static Delegate GetWrite_arrayBIIHandler ()
		{
			if (cb_write_arrayBII == null)
				cb_write_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Write_arrayBII);
			return cb_write_arrayBII;
		}

		static int n_Write_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int datasize, int timeout)
		{
			global::Com.Morpho.Android.Usb.USBDevice __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDevice> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Write (data, datasize, timeout);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDevice']/method[@name='write' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("write", "([BII)I", "GetWrite_arrayBIIHandler")]
		public virtual unsafe int Write (byte[] data, int datasize, int timeout)
		{
			const string __id = "write.([BII)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (datasize);
				__args [2] = new JniArgumentValue (timeout);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

	}
}
