using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoKCVID", DoNotGenerateAcw=true)]
	public sealed partial class MorphoKCVID : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/field[@name='ID_KENC']"
		[Register ("ID_KENC")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID IdKenc {
			get {
				const string __id = "ID_KENC.Lcom/morpho/morphosmart/sdk/MorphoKCVID;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/field[@name='ID_KPRIVACY']"
		[Register ("ID_KPRIVACY")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID IdKprivacy {
			get {
				const string __id = "ID_KPRIVACY.Lcom/morpho/morphosmart/sdk/MorphoKCVID;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/field[@name='ID_KS']"
		[Register ("ID_KS")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID IdKs {
			get {
				const string __id = "ID_KS.Lcom/morpho/morphosmart/sdk/MorphoKCVID;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/field[@name='ID_KSECRET']"
		[Register ("ID_KSECRET")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID IdKsecret {
			get {
				const string __id = "ID_KSECRET.Lcom/morpho/morphosmart/sdk/MorphoKCVID;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoKCVID", typeof (MorphoKCVID));
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

		internal MorphoKCVID (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/method[@name='getCode' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoKCVID;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoKCVID;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoKCVID']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MorphoKCVID;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MorphoKCVID;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoKCVID));
			} finally {
			}
		}

	}
}
