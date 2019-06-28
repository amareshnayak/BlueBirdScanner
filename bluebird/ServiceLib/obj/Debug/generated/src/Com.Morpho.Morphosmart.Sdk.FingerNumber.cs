using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FingerNumber']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/FingerNumber", DoNotGenerateAcw=true)]
	public partial class FingerNumber : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/FingerNumber", typeof (FingerNumber));
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

		protected FingerNumber (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FingerNumber']/constructor[@name='FingerNumber' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FingerNumber ()
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

		static Delegate cb_getFingerNumber;
#pragma warning disable 0169
		static Delegate GetGetFingerNumberHandler ()
		{
			if (cb_getFingerNumber == null)
				cb_getFingerNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFingerNumber);
			return cb_getFingerNumber;
		}

		static IntPtr n_GetFingerNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.FingerNumber __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.FingerNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetFingerNumber ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FingerNumber']/method[@name='getFingerNumber' and count(parameter)=0]"
		[Register ("getFingerNumber", "()[B", "GetGetFingerNumberHandler")]
		public virtual unsafe byte[] GetFingerNumber ()
		{
			const string __id = "getFingerNumber.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setFingerNumber_arrayB;
#pragma warning disable 0169
		static Delegate GetSetFingerNumber_arrayBHandler ()
		{
			if (cb_setFingerNumber_arrayB == null)
				cb_setFingerNumber_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFingerNumber_arrayB);
			return cb_setFingerNumber_arrayB;
		}

		static void n_SetFingerNumber_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_fingerNumber)
		{
			global::Com.Morpho.Morphosmart.Sdk.FingerNumber __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.FingerNumber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] fingerNumber = (byte[]) JNIEnv.GetArray (native_fingerNumber, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetFingerNumber (fingerNumber);
			if (fingerNumber != null)
				JNIEnv.CopyArray (fingerNumber, native_fingerNumber);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='FingerNumber']/method[@name='setFingerNumber' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setFingerNumber", "([B)V", "GetSetFingerNumber_arrayBHandler")]
		public virtual unsafe void SetFingerNumber (byte[] fingerNumber)
		{
			const string __id = "setFingerNumber.([B)V";
			IntPtr native_fingerNumber = JNIEnv.NewArray (fingerNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fingerNumber);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (fingerNumber != null) {
					JNIEnv.CopyArray (native_fingerNumber, fingerNumber);
					JNIEnv.DeleteLocalRef (native_fingerNumber);
				}
			}
		}

	}
}
