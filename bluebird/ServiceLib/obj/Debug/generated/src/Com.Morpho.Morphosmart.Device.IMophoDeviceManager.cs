using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Device {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']"
	[Register ("com/morpho/morphosmart/device/IMophoDeviceManager", "", "Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker")]
	public partial interface IMophoDeviceManager : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']/method[@name='closeDevice' and count(parameter)=0]"
		[Register ("closeDevice", "()I", "GetCloseDeviceHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib")]
		int CloseDevice ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']/method[@name='comReceive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("comReceive", "(I)[B", "GetComReceive_IHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib")]
		byte[] ComReceive (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']/method[@name='comSend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("comSend", "(I[B)I", "GetComSend_IarrayBHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib")]
		int ComSend (int p0, byte[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']/method[@name='getUsbDeviceName' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUsbDeviceName", "(I)Ljava/lang/String;", "GetGetUsbDeviceName_IHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib")]
		string GetUsbDeviceName (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']/method[@name='initUsbDevicesNameEnum' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("initUsbDevicesNameEnum", "([I)I", "GetInitUsbDevicesNameEnum_arrayIHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib")]
		int InitUsbDevicesNameEnum (int[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.device']/interface[@name='IMophoDeviceManager']/method[@name='openUsbDevice' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("openUsbDevice", "(Ljava/lang/String;I)I", "GetOpenUsbDevice_Ljava_lang_String_IHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib")]
		int OpenUsbDevice (string p0, int p1);

	}

	[global::Android.Runtime.Register ("com/morpho/morphosmart/device/IMophoDeviceManager", DoNotGenerateAcw=true)]
	internal class IMophoDeviceManagerInvoker : global::Java.Lang.Object, IMophoDeviceManager {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/morpho/morphosmart/device/IMophoDeviceManager", typeof (IMophoDeviceManagerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMophoDeviceManager GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMophoDeviceManager> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.morpho.morphosmart.device.IMophoDeviceManager"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMophoDeviceManagerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CloseDevice ();
		}
#pragma warning restore 0169

		IntPtr id_closeDevice;
		public unsafe int CloseDevice ()
		{
			if (id_closeDevice == IntPtr.Zero)
				id_closeDevice = JNIEnv.GetMethodID (class_ref, "closeDevice", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_closeDevice);
		}

		static Delegate cb_comReceive_I;
#pragma warning disable 0169
		static Delegate GetComReceive_IHandler ()
		{
			if (cb_comReceive_I == null)
				cb_comReceive_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ComReceive_I);
			return cb_comReceive_I;
		}

		static IntPtr n_ComReceive_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ComReceive (p0));
		}
#pragma warning restore 0169

		IntPtr id_comReceive_I;
		public unsafe byte[] ComReceive (int p0)
		{
			if (id_comReceive_I == IntPtr.Zero)
				id_comReceive_I = JNIEnv.GetMethodID (class_ref, "comReceive", "(I)[B");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_comReceive_I, __args), JniHandleOwnership.TransferLocalRef, typeof (byte));
		}

		static Delegate cb_comSend_IarrayB;
#pragma warning disable 0169
		static Delegate GetComSend_IarrayBHandler ()
		{
			if (cb_comSend_IarrayB == null)
				cb_comSend_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_ComSend_IarrayB);
			return cb_comSend_IarrayB;
		}

		static int n_ComSend_IarrayB (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.ComSend (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_comSend_IarrayB;
		public unsafe int ComSend (int p0, byte[] p1)
		{
			if (id_comSend_IarrayB == IntPtr.Zero)
				id_comSend_IarrayB = JNIEnv.GetMethodID (class_ref, "comSend", "(I[B)I");
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_comSend_IarrayB, __args);
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_getUsbDeviceName_I;
#pragma warning disable 0169
		static Delegate GetGetUsbDeviceName_IHandler ()
		{
			if (cb_getUsbDeviceName_I == null)
				cb_getUsbDeviceName_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetUsbDeviceName_I);
			return cb_getUsbDeviceName_I;
		}

		static IntPtr n_GetUsbDeviceName_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetUsbDeviceName (p0));
		}
#pragma warning restore 0169

		IntPtr id_getUsbDeviceName_I;
		public unsafe string GetUsbDeviceName (int p0)
		{
			if (id_getUsbDeviceName_I == IntPtr.Zero)
				id_getUsbDeviceName_I = JNIEnv.GetMethodID (class_ref, "getUsbDeviceName", "(I)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getUsbDeviceName_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_initUsbDevicesNameEnum_arrayI;
#pragma warning disable 0169
		static Delegate GetInitUsbDevicesNameEnum_arrayIHandler ()
		{
			if (cb_initUsbDevicesNameEnum_arrayI == null)
				cb_initUsbDevicesNameEnum_arrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_InitUsbDevicesNameEnum_arrayI);
			return cb_initUsbDevicesNameEnum_arrayI;
		}

		static int n_InitUsbDevicesNameEnum_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] p0 = (int[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.InitUsbDevicesNameEnum (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initUsbDevicesNameEnum_arrayI;
		public unsafe int InitUsbDevicesNameEnum (int[] p0)
		{
			if (id_initUsbDevicesNameEnum_arrayI == IntPtr.Zero)
				id_initUsbDevicesNameEnum_arrayI = JNIEnv.GetMethodID (class_ref, "initUsbDevicesNameEnum", "([I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_initUsbDevicesNameEnum_arrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_openUsbDevice_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpenUsbDevice_Ljava_lang_String_IHandler ()
		{
			if (cb_openUsbDevice_Ljava_lang_String_I == null)
				cb_openUsbDevice_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_OpenUsbDevice_Ljava_lang_String_I);
			return cb_openUsbDevice_Ljava_lang_String_I;
		}

		static int n_OpenUsbDevice_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OpenUsbDevice (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_openUsbDevice_Ljava_lang_String_I;
		public unsafe int OpenUsbDevice (string p0, int p1)
		{
			if (id_openUsbDevice_Ljava_lang_String_I == IntPtr.Zero)
				id_openUsbDevice_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "openUsbDevice", "(Ljava/lang/String;I)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_openUsbDevice_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
