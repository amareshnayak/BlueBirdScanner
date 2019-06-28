using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Runtime.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='PerObjectMap']"
	[global::Android.Runtime.Register ("org/aspectj/runtime/internal/PerObjectMap", DoNotGenerateAcw=true)]
	public partial class PerObjectMap : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("org/aspectj/runtime/internal/PerObjectMap", typeof (PerObjectMap));
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

		protected PerObjectMap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.aspectj.runtime.internal']/class[@name='PerObjectMap']/constructor[@name='PerObjectMap' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PerObjectMap ()
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

	}
}
