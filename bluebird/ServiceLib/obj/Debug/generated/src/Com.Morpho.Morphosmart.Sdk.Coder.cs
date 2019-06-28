using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/Coder", DoNotGenerateAcw=true)]
	public sealed partial class Coder : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/field[@name='MORPHO_DEFAULT_CODER']"
		[Register ("MORPHO_DEFAULT_CODER")]
		public static global::Com.Morpho.Morphosmart.Sdk.Coder MorphoDefaultCoder {
			get {
				const string __id = "MORPHO_DEFAULT_CODER.Lcom/morpho/morphosmart/sdk/Coder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/field[@name='MORPHO_MSO_V9_CODER']"
		[Register ("MORPHO_MSO_V9_CODER")]
		public static global::Com.Morpho.Morphosmart.Sdk.Coder MorphoMsoV9Coder {
			get {
				const string __id = "MORPHO_MSO_V9_CODER.Lcom/morpho/morphosmart/sdk/Coder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/field[@name='MORPHO_MSO_V9_JUV_CODER']"
		[Register ("MORPHO_MSO_V9_JUV_CODER")]
		public static global::Com.Morpho.Morphosmart.Sdk.Coder MorphoMsoV9JuvCoder {
			get {
				const string __id = "MORPHO_MSO_V9_JUV_CODER.Lcom/morpho/morphosmart/sdk/Coder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/field[@name='MORPHO_MSO_V9_THIN_FINGER_CODER']"
		[Register ("MORPHO_MSO_V9_THIN_FINGER_CODER")]
		public static global::Com.Morpho.Morphosmart.Sdk.Coder MorphoMsoV9ThinFingerCoder {
			get {
				const string __id = "MORPHO_MSO_V9_THIN_FINGER_CODER.Lcom/morpho/morphosmart/sdk/Coder;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/Coder", typeof (Coder));
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

		internal Coder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/method[@name='getLabel' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/Coder;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.Coder FromString (string label)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/Coder;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/Coder;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.Coder ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/Coder;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Coder']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/Coder;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.Coder[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/Coder;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.Coder[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.Coder));
			} finally {
			}
		}

	}
}
