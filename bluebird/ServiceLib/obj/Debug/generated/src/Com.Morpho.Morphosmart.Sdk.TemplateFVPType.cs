using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/TemplateFVPType", DoNotGenerateAcw=true)]
	public sealed partial class TemplateFVPType : global::Java.Lang.Enum, global::Com.Morpho.Morphosmart.Sdk.ITemplateType {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/field[@name='MORPHO_NO_PK_FVP']"
		[Register ("MORPHO_NO_PK_FVP")]
		public static global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType MorphoNoPkFvp {
			get {
				const string __id = "MORPHO_NO_PK_FVP.Lcom/morpho/morphosmart/sdk/TemplateFVPType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/field[@name='MORPHO_PK_FVP']"
		[Register ("MORPHO_PK_FVP")]
		public static global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType MorphoPkFvp {
			get {
				const string __id = "MORPHO_PK_FVP.Lcom/morpho/morphosmart/sdk/TemplateFVPType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/field[@name='MORPHO_PK_FVP_MATCH']"
		[Register ("MORPHO_PK_FVP_MATCH")]
		public static global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType MorphoPkFvpMatch {
			get {
				const string __id = "MORPHO_PK_FVP_MATCH.Lcom/morpho/morphosmart/sdk/TemplateFVPType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/TemplateFVPType", typeof (TemplateFVPType));
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

		internal TemplateFVPType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/method[@name='getCode' and count(parameter)=0]"
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

		public unsafe string Extension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/method[@name='getExtension' and count(parameter)=0]"
			[Register ("getExtension", "()Ljava/lang/String;", "GetGetExtensionHandler")]
			get {
				const string __id = "getExtension.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				const string __id = "getLabel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValue", "(I)Lcom/morpho/morphosmart/sdk/TemplateFVPType;", "")]
		protected static unsafe global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType GetValue (int id)
		{
			const string __id = "getValue.(I)Lcom/morpho/morphosmart/sdk/TemplateFVPType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/TemplateFVPType;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/TemplateFVPType;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateFVPType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/TemplateFVPType;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/TemplateFVPType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType));
			} finally {
			}
		}

	}
}
