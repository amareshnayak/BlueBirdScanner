using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoTypeDeletion']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoTypeDeletion", DoNotGenerateAcw=true)]
	public sealed partial class MorphoTypeDeletion : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoTypeDeletion']/field[@name='MORPHO_DESTROY_BASE']"
		[Register ("MORPHO_DESTROY_BASE")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion MorphoDestroyBase {
			get {
				const string __id = "MORPHO_DESTROY_BASE.Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoTypeDeletion']/field[@name='MORPHO_ERASE_BASE']"
		[Register ("MORPHO_ERASE_BASE")]
		public static global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion MorphoEraseBase {
			get {
				const string __id = "MORPHO_ERASE_BASE.Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoTypeDeletion", typeof (MorphoTypeDeletion));
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

		internal MorphoTypeDeletion (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int Value {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoTypeDeletion']/method[@name='getValue' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoTypeDeletion']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoTypeDeletion']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion));
			} finally {
			}
		}

	}
}
