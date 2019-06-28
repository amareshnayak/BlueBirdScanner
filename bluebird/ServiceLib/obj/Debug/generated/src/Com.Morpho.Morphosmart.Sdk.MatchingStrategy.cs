using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MatchingStrategy", DoNotGenerateAcw=true)]
	public sealed partial class MatchingStrategy : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/field[@name='MORPHO_ADVANCED_MATCHING_STRATEGY']"
		[Register ("MORPHO_ADVANCED_MATCHING_STRATEGY")]
		public static global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy MorphoAdvancedMatchingStrategy {
			get {
				const string __id = "MORPHO_ADVANCED_MATCHING_STRATEGY.Lcom/morpho/morphosmart/sdk/MatchingStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/field[@name='MORPHO_STANDARD_MATCHING_STRATEGY']"
		[Register ("MORPHO_STANDARD_MATCHING_STRATEGY")]
		public static global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy MorphoStandardMatchingStrategy {
			get {
				const string __id = "MORPHO_STANDARD_MATCHING_STRATEGY.Lcom/morpho/morphosmart/sdk/MatchingStrategy;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MatchingStrategy", typeof (MatchingStrategy));
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

		internal MatchingStrategy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/method[@name='getLabel' and count(parameter)=0]"
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

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/method[@name='fromString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("fromString", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MatchingStrategy;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy FromString (string label)
		{
			const string __id = "fromString.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MatchingStrategy;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MatchingStrategy;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MatchingStrategy;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MatchingStrategy']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MatchingStrategy;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MatchingStrategy;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy));
			} finally {
			}
		}

	}
}
