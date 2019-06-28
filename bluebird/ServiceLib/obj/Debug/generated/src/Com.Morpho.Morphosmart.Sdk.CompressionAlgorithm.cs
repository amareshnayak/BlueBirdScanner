using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/CompressionAlgorithm", DoNotGenerateAcw=true)]
	public sealed partial class CompressionAlgorithm : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/field[@name='MORPHO_COMPRESS_V1']"
		[Register ("MORPHO_COMPRESS_V1")]
		public static global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm MorphoCompressV1 {
			get {
				const string __id = "MORPHO_COMPRESS_V1.Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/field[@name='MORPHO_COMPRESS_WSQ']"
		[Register ("MORPHO_COMPRESS_WSQ")]
		public static global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm MorphoCompressWsq {
			get {
				const string __id = "MORPHO_COMPRESS_WSQ.Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/field[@name='MORPHO_NO_COMPRESS']"
		[Register ("MORPHO_NO_COMPRESS")]
		public static global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm MorphoNoCompress {
			get {
				const string __id = "MORPHO_NO_COMPRESS.Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/field[@name='NO_IMAGE']"
		[Register ("NO_IMAGE")]
		public static global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm NoImage {
			get {
				const string __id = "NO_IMAGE.Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/CompressionAlgorithm", typeof (CompressionAlgorithm));
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

		internal CompressionAlgorithm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='getExtension' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='getLabel' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='GetCompressionAlgorithm' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetCompressionAlgorithm", "(I)Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm GetCompressionAlgorithm (int firmwareCompressionAlgorithm)
		{
			const string __id = "GetCompressionAlgorithm.(I)Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (firmwareCompressionAlgorithm);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValue", "(I)Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;", "")]
		protected static unsafe global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm GetValue (int id)
		{
			const string __id = "getValue.(I)Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CompressionAlgorithm']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm));
			} finally {
			}
		}

	}
}
