using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/DetectionMode", DoNotGenerateAcw=true)]
	public sealed partial class DetectionMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/field[@name='MORPHO_DEFAULT_DETECT_MODE']"
		[Register ("MORPHO_DEFAULT_DETECT_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.DetectionMode MorphoDefaultDetectMode {
			get {
				const string __id = "MORPHO_DEFAULT_DETECT_MODE.Lcom/morpho/morphosmart/sdk/DetectionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/field[@name='MORPHO_ENROLL_DETECT_MODE']"
		[Register ("MORPHO_ENROLL_DETECT_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.DetectionMode MorphoEnrollDetectMode {
			get {
				const string __id = "MORPHO_ENROLL_DETECT_MODE.Lcom/morpho/morphosmart/sdk/DetectionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/field[@name='MORPHO_FORCE_FINGER_ON_TOP_DETECT_MODE']"
		[Register ("MORPHO_FORCE_FINGER_ON_TOP_DETECT_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.DetectionMode MorphoForceFingerOnTopDetectMode {
			get {
				const string __id = "MORPHO_FORCE_FINGER_ON_TOP_DETECT_MODE.Lcom/morpho/morphosmart/sdk/DetectionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/field[@name='MORPHO_VERIF_DETECT_MODE']"
		[Register ("MORPHO_VERIF_DETECT_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.DetectionMode MorphoVerifDetectMode {
			get {
				const string __id = "MORPHO_VERIF_DETECT_MODE.Lcom/morpho/morphosmart/sdk/DetectionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/field[@name='MORPHO_WAKEUP_LED_OFF']"
		[Register ("MORPHO_WAKEUP_LED_OFF")]
		public static global::Com.Morpho.Morphosmart.Sdk.DetectionMode MorphoWakeupLedOff {
			get {
				const string __id = "MORPHO_WAKEUP_LED_OFF.Lcom/morpho/morphosmart/sdk/DetectionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/field[@name='MORPHO_WAKEUP_LED_ON']"
		[Register ("MORPHO_WAKEUP_LED_ON")]
		public static global::Com.Morpho.Morphosmart.Sdk.DetectionMode MorphoWakeupLedOn {
			get {
				const string __id = "MORPHO_WAKEUP_LED_ON.Lcom/morpho/morphosmart/sdk/DetectionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/DetectionMode", typeof (DetectionMode));
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

		internal DetectionMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/method[@name='getValue' and count(parameter)=0]"
			[Register ("getValue", "()I", "GetGetValueHandler")]
			get {
				const string __id = "getValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/DetectionMode;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.DetectionMode ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/DetectionMode;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.DetectionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='DetectionMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/DetectionMode;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.DetectionMode[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/DetectionMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.DetectionMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.DetectionMode));
			} finally {
			}
		}

	}
}
