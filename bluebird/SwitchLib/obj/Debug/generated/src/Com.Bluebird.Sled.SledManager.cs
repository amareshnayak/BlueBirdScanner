using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bluebird.Sled {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']"
	[global::Android.Runtime.Register ("com/bluebird/sled/SledManager", DoNotGenerateAcw=true)]
	public partial class SledManager : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/bluebird/sled/SledManager", typeof (SledManager));
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

		protected SledManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/constructor[@name='SledManager' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.bluebird.sled.ISledManagerService']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/bluebird/sled/ISledManagerService;)V", "")]
		public unsafe SledManager (global::Android.Content.Context ctx, global::Com.Bluebird.Sled.ISledManagerService service)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/bluebird/sled/ISledManagerService;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_BBBarcodeClose;
#pragma warning disable 0169
		static Delegate GetBBBarcodeCloseHandler ()
		{
			if (cb_BBBarcodeClose == null)
				cb_BBBarcodeClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BBBarcodeClose);
			return cb_BBBarcodeClose;
		}

		static int n_BBBarcodeClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBBarcodeClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBBarcodeClose' and count(parameter)=0]"
		[Register ("BBBarcodeClose", "()I", "GetBBBarcodeCloseHandler")]
		public virtual unsafe int BBBarcodeClose ()
		{
			const string __id = "BBBarcodeClose.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBBarcodeOpen;
#pragma warning disable 0169
		static Delegate GetBBBarcodeOpenHandler ()
		{
			if (cb_BBBarcodeOpen == null)
				cb_BBBarcodeOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BBBarcodeOpen);
			return cb_BBBarcodeOpen;
		}

		static int n_BBBarcodeOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBBarcodeOpen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBBarcodeOpen' and count(parameter)=0]"
		[Register ("BBBarcodeOpen", "()I", "GetBBBarcodeOpenHandler")]
		public virtual unsafe int BBBarcodeOpen ()
		{
			const string __id = "BBBarcodeOpen.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBSetFngrPower_I;
#pragma warning disable 0169
		static Delegate GetBBSetFngrPower_IHandler ()
		{
			if (cb_BBSetFngrPower_I == null)
				cb_BBSetFngrPower_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_BBSetFngrPower_I);
			return cb_BBSetFngrPower_I;
		}

		static int n_BBSetFngrPower_I (IntPtr jnienv, IntPtr native__this, int onoff)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSetFngrPower (onoff);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSetFngrPower' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("BBSetFngrPower", "(I)I", "GetBBSetFngrPower_IHandler")]
		public virtual unsafe int BBSetFngrPower (int onoff)
		{
			const string __id = "BBSetFngrPower.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (onoff);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBSledClose;
#pragma warning disable 0169
		static Delegate GetBBSledCloseHandler ()
		{
			if (cb_BBSledClose == null)
				cb_BBSledClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BBSledClose);
			return cb_BBSledClose;
		}

		static int n_BBSledClose (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSledClose' and count(parameter)=0]"
		[Register ("BBSledClose", "()I", "GetBBSledCloseHandler")]
		public virtual unsafe int BBSledClose ()
		{
			const string __id = "BBSledClose.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBSledGetversion;
#pragma warning disable 0169
		static Delegate GetBBSledGetversionHandler ()
		{
			if (cb_BBSledGetversion == null)
				cb_BBSledGetversion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BBSledGetversion);
			return cb_BBSledGetversion;
		}

		static int n_BBSledGetversion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledGetversion ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSledGetversion' and count(parameter)=0]"
		[Register ("BBSledGetversion", "()I", "GetBBSledGetversionHandler")]
		public virtual unsafe int BBSledGetversion ()
		{
			const string __id = "BBSledGetversion.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBSledOpen;
#pragma warning disable 0169
		static Delegate GetBBSledOpenHandler ()
		{
			if (cb_BBSledOpen == null)
				cb_BBSledOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BBSledOpen);
			return cb_BBSledOpen;
		}

		static int n_BBSledOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledOpen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSledOpen' and count(parameter)=0]"
		[Register ("BBSledOpen", "()I", "GetBBSledOpenHandler")]
		public virtual unsafe int BBSledOpen ()
		{
			const string __id = "BBSledOpen.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBSledRead;
#pragma warning disable 0169
		static Delegate GetBBSledReadHandler ()
		{
			if (cb_BBSledRead == null)
				cb_BBSledRead = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BBSledRead);
			return cb_BBSledRead;
		}

		static IntPtr n_BBSledRead (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BBSledRead ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSledRead' and count(parameter)=0]"
		[Register ("BBSledRead", "()[B", "GetBBSledReadHandler")]
		public virtual unsafe byte[] BBSledRead ()
		{
			const string __id = "BBSledRead.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_BBSledWakeup;
#pragma warning disable 0169
		static Delegate GetBBSledWakeupHandler ()
		{
			if (cb_BBSledWakeup == null)
				cb_BBSledWakeup = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_BBSledWakeup);
			return cb_BBSledWakeup;
		}

		static int n_BBSledWakeup (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledWakeup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSledWakeup' and count(parameter)=0]"
		[Register ("BBSledWakeup", "()I", "GetBBSledWakeupHandler")]
		public virtual unsafe int BBSledWakeup ()
		{
			const string __id = "BBSledWakeup.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_BBSledWrite_arrayB;
#pragma warning disable 0169
		static Delegate GetBBSledWrite_arrayBHandler ()
		{
			if (cb_BBSledWrite_arrayB == null)
				cb_BBSledWrite_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_BBSledWrite_arrayB);
			return cb_BBSledWrite_arrayB;
		}

		static int n_BBSledWrite_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_b)
		{
			global::Com.Bluebird.Sled.SledManager __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] b = (byte[]) JNIEnv.GetArray (native_b, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.BBSledWrite (b);
			if (b != null)
				JNIEnv.CopyArray (b, native_b);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='SledManager']/method[@name='BBSledWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("BBSledWrite", "([B)I", "GetBBSledWrite_arrayBHandler")]
		public virtual unsafe int BBSledWrite (byte[] b)
		{
			const string __id = "BBSledWrite.([B)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_b);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

	}
}
