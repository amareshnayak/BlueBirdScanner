using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateQuality']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/TemplateQuality", DoNotGenerateAcw=true)]
	public partial class TemplateQuality : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/TemplateQuality", typeof (TemplateQuality));
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

		protected TemplateQuality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateQuality']/constructor[@name='TemplateQuality' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TemplateQuality ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getTemplateQuality;
#pragma warning disable 0169
		static Delegate GetGetTemplateQualityHandler ()
		{
			if (cb_getTemplateQuality == null)
				cb_getTemplateQuality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTemplateQuality);
			return cb_getTemplateQuality;
		}

		static IntPtr n_GetTemplateQuality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateQuality __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTemplateQuality ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateQuality']/method[@name='getTemplateQuality' and count(parameter)=0]"
		[Register ("getTemplateQuality", "()[B", "GetGetTemplateQualityHandler")]
		public virtual unsafe byte[] GetTemplateQuality ()
		{
			const string __id = "getTemplateQuality.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setTemplateQuality_arrayB;
#pragma warning disable 0169
		static Delegate GetSetTemplateQuality_arrayBHandler ()
		{
			if (cb_setTemplateQuality_arrayB == null)
				cb_setTemplateQuality_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTemplateQuality_arrayB);
			return cb_setTemplateQuality_arrayB;
		}

		static void n_SetTemplateQuality_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_templateQuality)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateQuality __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] templateQuality = (byte[]) JNIEnv.GetArray (native_templateQuality, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetTemplateQuality (templateQuality);
			if (templateQuality != null)
				JNIEnv.CopyArray (templateQuality, native_templateQuality);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateQuality']/method[@name='setTemplateQuality' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setTemplateQuality", "([B)V", "GetSetTemplateQuality_arrayBHandler")]
		public virtual unsafe void SetTemplateQuality (byte[] templateQuality)
		{
			const string __id = "setTemplateQuality.([B)V";
			IntPtr native_templateQuality = JNIEnv.NewArray (templateQuality);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_templateQuality);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (templateQuality != null) {
					JNIEnv.CopyArray (native_templateQuality, templateQuality);
					JNIEnv.DeleteLocalRef (native_templateQuality);
				}
			}
		}

	}
}
