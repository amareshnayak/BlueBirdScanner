using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/StrategyAcquisitionMode", DoNotGenerateAcw=true)]
	public sealed partial class StrategyAcquisitionMode : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/field[@name='MORPHO_ACQ_ANTI_SPOOFING_MODE']"
		[Register ("MORPHO_ACQ_ANTI_SPOOFING_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode MorphoAcqAntiSpoofingMode {
			get {
				const string __id = "MORPHO_ACQ_ANTI_SPOOFING_MODE.Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/field[@name='MORPHO_ACQ_EXPERT_MODE']"
		[Register ("MORPHO_ACQ_EXPERT_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode MorphoAcqExpertMode {
			get {
				const string __id = "MORPHO_ACQ_EXPERT_MODE.Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/field[@name='MORPHO_ACQ_FULL_MULTIMODAL_MODE']"
		[Register ("MORPHO_ACQ_FULL_MULTIMODAL_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode MorphoAcqFullMultimodalMode {
			get {
				const string __id = "MORPHO_ACQ_FULL_MULTIMODAL_MODE.Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/field[@name='MORPHO_ACQ_UNIVERSAL_ACCURATE_MODE']"
		[Register ("MORPHO_ACQ_UNIVERSAL_ACCURATE_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode MorphoAcqUniversalAccurateMode {
			get {
				const string __id = "MORPHO_ACQ_UNIVERSAL_ACCURATE_MODE.Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/field[@name='MORPHO_ACQ_UNIVERSAL_FAST_MODE']"
		[Register ("MORPHO_ACQ_UNIVERSAL_FAST_MODE")]
		public static global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode MorphoAcqUniversalFastMode {
			get {
				const string __id = "MORPHO_ACQ_UNIVERSAL_FAST_MODE.Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/StrategyAcquisitionMode", typeof (StrategyAcquisitionMode));
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

		internal StrategyAcquisitionMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/method[@name='getCode' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/method[@name='getLabel' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode FromString (string label)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/method[@name='getValue' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValue", "(I)Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode GetValue (int id)
		{
			const string __id = "getValue.(I)Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='StrategyAcquisitionMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/StrategyAcquisitionMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.StrategyAcquisitionMode));
			} finally {
			}
		}

	}
}
