using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Android.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']"
	[global::Android.Runtime.Register ("com/morpho/android/usb/USBDeviceAttributes", DoNotGenerateAcw=true)]
	public partial class USBDeviceAttributes : global::Java.Lang.Object, global::Android.OS.IParcelable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/android/usb/USBDeviceAttributes", typeof (USBDeviceAttributes));
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

		protected USBDeviceAttributes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/constructor[@name='USBDeviceAttributes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe USBDeviceAttributes (int vendorId, int productId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (vendorId);
				__args [1] = new JniArgumentValue (productId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/constructor[@name='USBDeviceAttributes' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(III)V", "")]
		public unsafe USBDeviceAttributes (int vendorId, int productId, int devType)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (vendorId);
				__args [1] = new JniArgumentValue (productId);
				__args [2] = new JniArgumentValue (devType);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/constructor[@name='USBDeviceAttributes' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;III)V", "")]
		public unsafe USBDeviceAttributes (string path, int vendorId, int productId, int interfaceNumber)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;III)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_path);
				__args [1] = new JniArgumentValue (vendorId);
				__args [2] = new JniArgumentValue (productId);
				__args [3] = new JniArgumentValue (interfaceNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		static Delegate cb_getDeviceType;
#pragma warning disable 0169
		static Delegate GetGetDeviceTypeHandler ()
		{
			if (cb_getDeviceType == null)
				cb_getDeviceType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDeviceType);
			return cb_getDeviceType;
		}

		static int n_GetDeviceType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DeviceType;
		}
#pragma warning restore 0169

		static Delegate cb_setDeviceType_I;
#pragma warning disable 0169
		static Delegate GetSetDeviceType_IHandler ()
		{
			if (cb_setDeviceType_I == null)
				cb_setDeviceType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDeviceType_I);
			return cb_setDeviceType_I;
		}

		static void n_SetDeviceType_I (IntPtr jnienv, IntPtr native__this, int deviceType)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DeviceType = deviceType;
		}
#pragma warning restore 0169

		public virtual unsafe int DeviceType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getDeviceType' and count(parameter)=0]"
			[Register ("getDeviceType", "()I", "GetGetDeviceTypeHandler")]
			get {
				const string __id = "getDeviceType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='setDeviceType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDeviceType", "(I)V", "GetSetDeviceType_IHandler")]
			set {
				const string __id = "setDeviceType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFreindlyName;
#pragma warning disable 0169
		static Delegate GetGetFreindlyNameHandler ()
		{
			if (cb_getFreindlyName == null)
				cb_getFreindlyName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFreindlyName);
			return cb_getFreindlyName;
		}

		static IntPtr n_GetFreindlyName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.FreindlyName);
		}
#pragma warning restore 0169

		static Delegate cb_setFreindlyName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFreindlyName_Ljava_lang_String_Handler ()
		{
			if (cb_setFreindlyName_Ljava_lang_String_ == null)
				cb_setFreindlyName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFreindlyName_Ljava_lang_String_);
			return cb_setFreindlyName_Ljava_lang_String_;
		}

		static void n_SetFreindlyName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_freindlyName)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string freindlyName = JNIEnv.GetString (native_freindlyName, JniHandleOwnership.DoNotTransfer);
			__this.FreindlyName = freindlyName;
		}
#pragma warning restore 0169

		public virtual unsafe string FreindlyName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getFreindlyName' and count(parameter)=0]"
			[Register ("getFreindlyName", "()Ljava/lang/String;", "GetGetFreindlyNameHandler")]
			get {
				const string __id = "getFreindlyName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='setFreindlyName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setFreindlyName", "(Ljava/lang/String;)V", "GetSetFreindlyName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setFreindlyName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getInterfaceNumber;
#pragma warning disable 0169
		static Delegate GetGetInterfaceNumberHandler ()
		{
			if (cb_getInterfaceNumber == null)
				cb_getInterfaceNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetInterfaceNumber);
			return cb_getInterfaceNumber;
		}

		static int n_GetInterfaceNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.InterfaceNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int InterfaceNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getInterfaceNumber' and count(parameter)=0]"
			[Register ("getInterfaceNumber", "()I", "GetGetInterfaceNumberHandler")]
			get {
				const string __id = "getInterfaceNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getManufacturer;
#pragma warning disable 0169
		static Delegate GetGetManufacturerHandler ()
		{
			if (cb_getManufacturer == null)
				cb_getManufacturer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetManufacturer);
			return cb_getManufacturer;
		}

		static IntPtr n_GetManufacturer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Manufacturer);
		}
#pragma warning restore 0169

		public virtual unsafe string Manufacturer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getManufacturer' and count(parameter)=0]"
			[Register ("getManufacturer", "()Ljava/lang/String;", "GetGetManufacturerHandler")]
			get {
				const string __id = "getManufacturer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPath;
#pragma warning disable 0169
		static Delegate GetGetPathHandler ()
		{
			if (cb_getPath == null)
				cb_getPath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPath);
			return cb_getPath;
		}

		static IntPtr n_GetPath (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Path);
		}
#pragma warning restore 0169

		public virtual unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "GetGetPathHandler")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProduct;
#pragma warning disable 0169
		static Delegate GetGetProductHandler ()
		{
			if (cb_getProduct == null)
				cb_getProduct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetProduct);
			return cb_getProduct;
		}

		static IntPtr n_GetProduct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Product);
		}
#pragma warning restore 0169

		static Delegate cb_setProduct_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetProduct_Ljava_lang_String_Handler ()
		{
			if (cb_setProduct_Ljava_lang_String_ == null)
				cb_setProduct_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetProduct_Ljava_lang_String_);
			return cb_setProduct_Ljava_lang_String_;
		}

		static void n_SetProduct_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_product)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string product = JNIEnv.GetString (native_product, JniHandleOwnership.DoNotTransfer);
			__this.Product = product;
		}
#pragma warning restore 0169

		public virtual unsafe string Product {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getProduct' and count(parameter)=0]"
			[Register ("getProduct", "()Ljava/lang/String;", "GetGetProductHandler")]
			get {
				const string __id = "getProduct.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='setProduct' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setProduct", "(Ljava/lang/String;)V", "GetSetProduct_Ljava_lang_String_Handler")]
			set {
				const string __id = "setProduct.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getProductId;
#pragma warning disable 0169
		static Delegate GetGetProductIdHandler ()
		{
			if (cb_getProductId == null)
				cb_getProductId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetProductId);
			return cb_getProductId;
		}

		static int n_GetProductId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ProductId;
		}
#pragma warning restore 0169

		public virtual unsafe int ProductId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getProductId' and count(parameter)=0]"
			[Register ("getProductId", "()I", "GetGetProductIdHandler")]
			get {
				const string __id = "getProductId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVendorId;
#pragma warning disable 0169
		static Delegate GetGetVendorIdHandler ()
		{
			if (cb_getVendorId == null)
				cb_getVendorId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetVendorId);
			return cb_getVendorId;
		}

		static int n_GetVendorId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VendorId;
		}
#pragma warning restore 0169

		public virtual unsafe int VendorId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='getVendorId' and count(parameter)=0]"
			[Register ("getVendorId", "()I", "GetGetVendorIdHandler")]
			get {
				const string __id = "getVendorId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			const string __id = "describeContents.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int native_flags)
		{
			global::Com.Morpho.Android.Usb.USBDeviceAttributes __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Usb.USBDeviceAttributes> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel dest = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_dest, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags flags = (global::Android.OS.ParcelableWriteFlags) native_flags;
			__this.WriteToParcel (dest, flags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBDeviceAttributes']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel dest, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags flags)
		{
			const string __id = "writeToParcel.(Landroid/os/Parcel;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue ((int) flags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
