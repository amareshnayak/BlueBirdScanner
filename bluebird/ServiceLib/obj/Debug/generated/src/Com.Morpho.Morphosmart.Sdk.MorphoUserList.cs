using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUserList']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoUserList", DoNotGenerateAcw=true)]
	public partial class MorphoUserList : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoUserList", typeof (MorphoUserList));
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

		protected MorphoUserList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUserList']/constructor[@name='MorphoUserList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoUserList ()
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

		static Delegate cb_getNbUser;
#pragma warning disable 0169
		static Delegate GetGetNbUserHandler ()
		{
			if (cb_getNbUser == null)
				cb_getNbUser = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbUser);
			return cb_getNbUser;
		}

		static int n_GetNbUser (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUserList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUserList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbUser;
		}
#pragma warning restore 0169

		public virtual unsafe int NbUser {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUserList']/method[@name='getNbUser' and count(parameter)=0]"
			[Register ("getNbUser", "()I", "GetGetNbUserHandler")]
			get {
				const string __id = "getNbUser.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUser_I;
#pragma warning disable 0169
		static Delegate GetGetUser_IHandler ()
		{
			if (cb_getUser_I == null)
				cb_getUser_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetUser_I);
			return cb_getUser_I;
		}

		static IntPtr n_GetUser_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUserList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUserList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetUser (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUserList']/method[@name='getUser' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUser", "(I)Lcom/morpho/morphosmart/sdk/MorphoUser;", "GetGetUser_IHandler")]
		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoUser GetUser (int index)
		{
			const string __id = "getUser.(I)Lcom/morpho/morphosmart/sdk/MorphoUser;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
