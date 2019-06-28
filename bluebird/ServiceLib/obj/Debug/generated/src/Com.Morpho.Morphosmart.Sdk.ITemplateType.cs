using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='ITemplateType']"
	[Register ("com/morpho/morphosmart/sdk/ITemplateType", "", "Com.Morpho.Morphosmart.Sdk.ITemplateTypeInvoker")]
	public partial interface ITemplateType : IJavaObject {

		int Code {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='ITemplateType']/method[@name='getCode' and count(parameter)=0]"
			[Register ("getCode", "()I", "GetGetCodeHandler:Com.Morpho.Morphosmart.Sdk.ITemplateTypeInvoker, ServiceLib")] get;
		}

		string Extension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='ITemplateType']/method[@name='getExtension' and count(parameter)=0]"
			[Register ("getExtension", "()Ljava/lang/String;", "GetGetExtensionHandler:Com.Morpho.Morphosmart.Sdk.ITemplateTypeInvoker, ServiceLib")] get;
		}

		string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='ITemplateType']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler:Com.Morpho.Morphosmart.Sdk.ITemplateTypeInvoker, ServiceLib")] get;
		}

	}

	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/ITemplateType", DoNotGenerateAcw=true)]
	internal class ITemplateTypeInvoker : global::Java.Lang.Object, ITemplateType {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/morpho/morphosmart/sdk/ITemplateType", typeof (ITemplateTypeInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ITemplateType GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITemplateType> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.morpho.morphosmart.sdk.ITemplateType"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITemplateTypeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCode;
#pragma warning disable 0169
		static Delegate GetGetCodeHandler ()
		{
			if (cb_getCode == null)
				cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
			return cb_getCode;
		}

		static int n_GetCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.ITemplateType __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ITemplateType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Code;
		}
#pragma warning restore 0169

		IntPtr id_getCode;
		public unsafe int Code {
			get {
				if (id_getCode == IntPtr.Zero)
					id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
			}
		}

		static Delegate cb_getExtension;
#pragma warning disable 0169
		static Delegate GetGetExtensionHandler ()
		{
			if (cb_getExtension == null)
				cb_getExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtension);
			return cb_getExtension;
		}

		static IntPtr n_GetExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.ITemplateType __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ITemplateType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Extension);
		}
#pragma warning restore 0169

		IntPtr id_getExtension;
		public unsafe string Extension {
			get {
				if (id_getExtension == IntPtr.Zero)
					id_getExtension = JNIEnv.GetMethodID (class_ref, "getExtension", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExtension), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.ITemplateType __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ITemplateType> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		IntPtr id_getLabel;
		public unsafe string Label {
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
			}
		}

	}

}
