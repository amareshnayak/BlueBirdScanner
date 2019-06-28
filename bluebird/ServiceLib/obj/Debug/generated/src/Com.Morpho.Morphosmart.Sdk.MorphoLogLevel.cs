using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoLogLevel", DoNotGenerateAcw=true)]
	public sealed partial class MorphoLogLevel : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/field[@name='MORPHO_LOG_DEBUG']"
		[Register ("MORPHO_LOG_DEBUG")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel MorphoLogDebug {
			get {
				const string __id = "MORPHO_LOG_DEBUG.Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/field[@name='MORPHO_LOG_ERROR']"
		[Register ("MORPHO_LOG_ERROR")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel MorphoLogError {
			get {
				const string __id = "MORPHO_LOG_ERROR.Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/field[@name='MORPHO_LOG_INFO']"
		[Register ("MORPHO_LOG_INFO")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel MorphoLogInfo {
			get {
				const string __id = "MORPHO_LOG_INFO.Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/field[@name='MORPHO_LOG_NOLOG']"
		[Register ("MORPHO_LOG_NOLOG")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel MorphoLogNolog {
			get {
				const string __id = "MORPHO_LOG_NOLOG.Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/field[@name='MORPHO_LOG_WARNING']"
		[Register ("MORPHO_LOG_WARNING")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel MorphoLogWarning {
			get {
				const string __id = "MORPHO_LOG_WARNING.Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoLogLevel", typeof (MorphoLogLevel));
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

		internal MorphoLogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/method[@name='getCode' and count(parameter)=0]"
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

		public unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/method[@name='getLabel' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoLogLevel;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel FromString (string label)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoLogLevel;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoLogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MorphoLogLevel;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MorphoLogLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoLogLevel));
			} finally {
			}
		}

	}
}
