using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/CallbackMask", DoNotGenerateAcw=true)]
	public sealed partial class CallbackMask : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/field[@name='MORPHO_CALLBACK_CODEQUALITY']"
		[Register ("MORPHO_CALLBACK_CODEQUALITY")]
		public static global::Com.Morpho.Morphosmart.Sdk.CallbackMask MorphoCallbackCodequality {
			get {
				const string __id = "MORPHO_CALLBACK_CODEQUALITY.Lcom/morpho/morphosmart/sdk/CallbackMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/field[@name='MORPHO_CALLBACK_COMMAND_CMD']"
		[Register ("MORPHO_CALLBACK_COMMAND_CMD")]
		public static global::Com.Morpho.Morphosmart.Sdk.CallbackMask MorphoCallbackCommandCmd {
			get {
				const string __id = "MORPHO_CALLBACK_COMMAND_CMD.Lcom/morpho/morphosmart/sdk/CallbackMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/field[@name='MORPHO_CALLBACK_DETECTQUALITY']"
		[Register ("MORPHO_CALLBACK_DETECTQUALITY")]
		public static global::Com.Morpho.Morphosmart.Sdk.CallbackMask MorphoCallbackDetectquality {
			get {
				const string __id = "MORPHO_CALLBACK_DETECTQUALITY.Lcom/morpho/morphosmart/sdk/CallbackMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/field[@name='MORPHO_CALLBACK_ENROLLMENT_CMD']"
		[Register ("MORPHO_CALLBACK_ENROLLMENT_CMD")]
		public static global::Com.Morpho.Morphosmart.Sdk.CallbackMask MorphoCallbackEnrollmentCmd {
			get {
				const string __id = "MORPHO_CALLBACK_ENROLLMENT_CMD.Lcom/morpho/morphosmart/sdk/CallbackMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/field[@name='MORPHO_CALLBACK_IMAGE_CMD']"
		[Register ("MORPHO_CALLBACK_IMAGE_CMD")]
		public static global::Com.Morpho.Morphosmart.Sdk.CallbackMask MorphoCallbackImageCmd {
			get {
				const string __id = "MORPHO_CALLBACK_IMAGE_CMD.Lcom/morpho/morphosmart/sdk/CallbackMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/field[@name='MORPHO_CALLBACK_LAST_IMAGE_FULL_RES_CMD']"
		[Register ("MORPHO_CALLBACK_LAST_IMAGE_FULL_RES_CMD")]
		public static global::Com.Morpho.Morphosmart.Sdk.CallbackMask MorphoCallbackLastImageFullResCmd {
			get {
				const string __id = "MORPHO_CALLBACK_LAST_IMAGE_FULL_RES_CMD.Lcom/morpho/morphosmart/sdk/CallbackMask;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/CallbackMask", typeof (CallbackMask));
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

		internal CallbackMask (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/method[@name='setValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setValue", "(I)V", "GetSetValue_IHandler")]
			set {
				const string __id = "setValue.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/CallbackMask;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.CallbackMask ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/CallbackMask;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CallbackMask> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='CallbackMask']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/CallbackMask;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.CallbackMask[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/CallbackMask;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.CallbackMask[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.CallbackMask));
			} finally {
			}
		}

	}
}
