using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoDeviceConnectionType", DoNotGenerateAcw=true)]
	public sealed partial class MorphoDeviceConnectionType : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/field[@name='COM_TYPE_NOT_SET']"
		[Register ("COM_TYPE_NOT_SET")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType ComTypeNotSet {
			get {
				const string __id = "COM_TYPE_NOT_SET.Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/field[@name='RS232_COM_TYPE']"
		[Register ("RS232_COM_TYPE")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType Rs232ComType {
			get {
				const string __id = "RS232_COM_TYPE.Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/field[@name='USB_COM_TYPE']"
		[Register ("USB_COM_TYPE")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType UsbComType {
			get {
				const string __id = "USB_COM_TYPE.Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/field[@name='USER_COM_TYPE']"
		[Register ("USER_COM_TYPE")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType UserComType {
			get {
				const string __id = "USER_COM_TYPE.Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoDeviceConnectionType", typeof (MorphoDeviceConnectionType));
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

		internal MorphoDeviceConnectionType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler")]
			get {
				const string __id = "getCode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDeviceConnectionType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MorphoDeviceConnectionType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoDeviceConnectionType));
			} finally {
			}
		}

	}
}
