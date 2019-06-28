using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Bluebird.Sled {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.bluebird.sled']/class[@name='ISledManagerService.Stub']"
	[global::Android.Runtime.Register ("com/bluebird/sled/ISledManagerService$Stub", DoNotGenerateAcw=true)]
	public abstract partial class SledManagerServiceStub : global::Android.OS.Binder, global::Com.Bluebird.Sled.ISledManagerService {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/bluebird/sled/ISledManagerService$Stub", typeof (SledManagerServiceStub));
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

		protected SledManagerServiceStub (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.bluebird.sled']/class[@name='ISledManagerService.Stub']/constructor[@name='ISledManagerService.Stub' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SledManagerServiceStub ()
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

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='ISledManagerService.Stub']/method[@name='asBinder' and count(parameter)=0]"
		[Register ("asBinder", "()Landroid/os/IBinder;", "GetAsBinderHandler")]
		public virtual unsafe global::Android.OS.IBinder AsBinder ()
		{
			const string __id = "asBinder.()Landroid/os/IBinder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='ISledManagerService.Stub']/method[@name='asInterface' and count(parameter)=1 and parameter[1][@type='android.os.IBinder']]"
		[Register ("asInterface", "(Landroid/os/IBinder;)Lcom/bluebird/sled/ISledManagerService;", "")]
		public static unsafe global::Com.Bluebird.Sled.ISledManagerService AsInterface (global::Android.OS.IBinder obj)
		{
			const string __id = "asInterface.(Landroid/os/IBinder;)Lcom/bluebird/sled/ISledManagerService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I == null)
				cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int, bool>) n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I);
			return cb_onTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I;
		}

		static bool n_OnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data, IntPtr native_reply, int flags)
		{
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel data = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_data, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel reply = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_reply, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTransact (code, data, reply, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/class[@name='ISledManagerService.Stub']/method[@name='onTransact' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='android.os.Parcel'] and parameter[3][@type='android.os.Parcel'] and parameter[4][@type='int']]"
		[Register ("onTransact", "(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z", "GetOnTransact_ILandroid_os_Parcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe bool OnTransact (int code, global::Android.OS.Parcel data, global::Android.OS.Parcel reply, int flags)
		{
			const string __id = "onTransact.(ILandroid/os/Parcel;Landroid/os/Parcel;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [2] = new JniArgumentValue ((reply == null) ? IntPtr.Zero : ((global::Java.Lang.Object) reply).Handle);
				__args [3] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBBarcodeClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBBarcodeClose' and count(parameter)=0]"
		[Register ("BBBarcodeClose", "()I", "GetBBBarcodeCloseHandler")]
		public abstract int BBBarcodeClose ();

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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBBarcodeOpen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBBarcodeOpen' and count(parameter)=0]"
		[Register ("BBBarcodeOpen", "()I", "GetBBBarcodeOpenHandler")]
		public abstract int BBBarcodeOpen ();

		static Delegate cb_BBSetFngrPower_I;
#pragma warning disable 0169
		static Delegate GetBBSetFngrPower_IHandler ()
		{
			if (cb_BBSetFngrPower_I == null)
				cb_BBSetFngrPower_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_BBSetFngrPower_I);
			return cb_BBSetFngrPower_I;
		}

		static int n_BBSetFngrPower_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSetFngrPower (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSetFngrPower' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("BBSetFngrPower", "(I)I", "GetBBSetFngrPower_IHandler")]
		public abstract int BBSetFngrPower (int p0);

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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledClose' and count(parameter)=0]"
		[Register ("BBSledClose", "()I", "GetBBSledCloseHandler")]
		public abstract int BBSledClose ();

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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledGetversion ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledGetversion' and count(parameter)=0]"
		[Register ("BBSledGetversion", "()I", "GetBBSledGetversionHandler")]
		public abstract int BBSledGetversion ();

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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledOpen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledOpen' and count(parameter)=0]"
		[Register ("BBSledOpen", "()I", "GetBBSledOpenHandler")]
		public abstract int BBSledOpen ();

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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BBSledRead ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledRead' and count(parameter)=0]"
		[Register ("BBSledRead", "()[B", "GetBBSledReadHandler")]
		public abstract byte[] BBSledRead ();

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
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledWakeup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledWakeup' and count(parameter)=0]"
		[Register ("BBSledWakeup", "()I", "GetBBSledWakeupHandler")]
		public abstract int BBSledWakeup ();

		static Delegate cb_BBSledWrite_arrayB;
#pragma warning disable 0169
		static Delegate GetBBSledWrite_arrayBHandler ()
		{
			if (cb_BBSledWrite_arrayB == null)
				cb_BBSledWrite_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_BBSledWrite_arrayB);
			return cb_BBSledWrite_arrayB;
		}

		static int n_BBSledWrite_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluebird.Sled.SledManagerServiceStub __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.SledManagerServiceStub> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.BBSledWrite (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("BBSledWrite", "([B)I", "GetBBSledWrite_arrayBHandler")]
		public abstract int BBSledWrite (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/bluebird/sled/ISledManagerService$Stub", DoNotGenerateAcw=true)]
	internal partial class SledManagerServiceStubInvoker : SledManagerServiceStub {

		public SledManagerServiceStubInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/bluebird/sled/ISledManagerService$Stub", typeof (SledManagerServiceStubInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBBarcodeClose' and count(parameter)=0]"
		[Register ("BBBarcodeClose", "()I", "GetBBBarcodeCloseHandler")]
		public override unsafe int BBBarcodeClose ()
		{
			const string __id = "BBBarcodeClose.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBBarcodeOpen' and count(parameter)=0]"
		[Register ("BBBarcodeOpen", "()I", "GetBBBarcodeOpenHandler")]
		public override unsafe int BBBarcodeOpen ()
		{
			const string __id = "BBBarcodeOpen.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSetFngrPower' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("BBSetFngrPower", "(I)I", "GetBBSetFngrPower_IHandler")]
		public override unsafe int BBSetFngrPower (int p0)
		{
			const string __id = "BBSetFngrPower.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledClose' and count(parameter)=0]"
		[Register ("BBSledClose", "()I", "GetBBSledCloseHandler")]
		public override unsafe int BBSledClose ()
		{
			const string __id = "BBSledClose.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledGetversion' and count(parameter)=0]"
		[Register ("BBSledGetversion", "()I", "GetBBSledGetversionHandler")]
		public override unsafe int BBSledGetversion ()
		{
			const string __id = "BBSledGetversion.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledOpen' and count(parameter)=0]"
		[Register ("BBSledOpen", "()I", "GetBBSledOpenHandler")]
		public override unsafe int BBSledOpen ()
		{
			const string __id = "BBSledOpen.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledRead' and count(parameter)=0]"
		[Register ("BBSledRead", "()[B", "GetBBSledReadHandler")]
		public override unsafe byte[] BBSledRead ()
		{
			const string __id = "BBSledRead.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledWakeup' and count(parameter)=0]"
		[Register ("BBSledWakeup", "()I", "GetBBSledWakeupHandler")]
		public override unsafe int BBSledWakeup ()
		{
			const string __id = "BBSledWakeup.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("BBSledWrite", "([B)I", "GetBBSledWrite_arrayBHandler")]
		public override unsafe int BBSledWrite (byte[] p0)
		{
			const string __id = "BBSledWrite.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

	}


	// Metadata.xml XPath interface reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']"
	[Register ("com/bluebird/sled/ISledManagerService", "", "Com.Bluebird.Sled.ISledManagerServiceInvoker")]
	public partial interface ISledManagerService : global::Android.OS.IInterface {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBBarcodeClose' and count(parameter)=0]"
		[Register ("BBBarcodeClose", "()I", "GetBBBarcodeCloseHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBBarcodeClose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBBarcodeOpen' and count(parameter)=0]"
		[Register ("BBBarcodeOpen", "()I", "GetBBBarcodeOpenHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBBarcodeOpen ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSetFngrPower' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("BBSetFngrPower", "(I)I", "GetBBSetFngrPower_IHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBSetFngrPower (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledClose' and count(parameter)=0]"
		[Register ("BBSledClose", "()I", "GetBBSledCloseHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBSledClose ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledGetversion' and count(parameter)=0]"
		[Register ("BBSledGetversion", "()I", "GetBBSledGetversionHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBSledGetversion ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledOpen' and count(parameter)=0]"
		[Register ("BBSledOpen", "()I", "GetBBSledOpenHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBSledOpen ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledRead' and count(parameter)=0]"
		[Register ("BBSledRead", "()[B", "GetBBSledReadHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		byte[] BBSledRead ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledWakeup' and count(parameter)=0]"
		[Register ("BBSledWakeup", "()I", "GetBBSledWakeupHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBSledWakeup ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.bluebird.sled']/interface[@name='ISledManagerService']/method[@name='BBSledWrite' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("BBSledWrite", "([B)I", "GetBBSledWrite_arrayBHandler:Com.Bluebird.Sled.ISledManagerServiceInvoker, SwitchLib")]
		int BBSledWrite (byte[] p0);

	}

	[global::Android.Runtime.Register ("com/bluebird/sled/ISledManagerService", DoNotGenerateAcw=true)]
	internal class ISledManagerServiceInvoker : global::Java.Lang.Object, ISledManagerService {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/bluebird/sled/ISledManagerService", typeof (ISledManagerServiceInvoker));

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

		public static ISledManagerService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISledManagerService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.bluebird.sled.ISledManagerService"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISledManagerServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBBarcodeClose ();
		}
#pragma warning restore 0169

		IntPtr id_BBBarcodeClose;
		public unsafe int BBBarcodeClose ()
		{
			if (id_BBBarcodeClose == IntPtr.Zero)
				id_BBBarcodeClose = JNIEnv.GetMethodID (class_ref, "BBBarcodeClose", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBBarcodeClose);
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBBarcodeOpen ();
		}
#pragma warning restore 0169

		IntPtr id_BBBarcodeOpen;
		public unsafe int BBBarcodeOpen ()
		{
			if (id_BBBarcodeOpen == IntPtr.Zero)
				id_BBBarcodeOpen = JNIEnv.GetMethodID (class_ref, "BBBarcodeOpen", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBBarcodeOpen);
		}

		static Delegate cb_BBSetFngrPower_I;
#pragma warning disable 0169
		static Delegate GetBBSetFngrPower_IHandler ()
		{
			if (cb_BBSetFngrPower_I == null)
				cb_BBSetFngrPower_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_BBSetFngrPower_I);
			return cb_BBSetFngrPower_I;
		}

		static int n_BBSetFngrPower_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSetFngrPower (p0);
		}
#pragma warning restore 0169

		IntPtr id_BBSetFngrPower_I;
		public unsafe int BBSetFngrPower (int p0)
		{
			if (id_BBSetFngrPower_I == IntPtr.Zero)
				id_BBSetFngrPower_I = JNIEnv.GetMethodID (class_ref, "BBSetFngrPower", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBSetFngrPower_I, __args);
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledClose ();
		}
#pragma warning restore 0169

		IntPtr id_BBSledClose;
		public unsafe int BBSledClose ()
		{
			if (id_BBSledClose == IntPtr.Zero)
				id_BBSledClose = JNIEnv.GetMethodID (class_ref, "BBSledClose", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBSledClose);
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledGetversion ();
		}
#pragma warning restore 0169

		IntPtr id_BBSledGetversion;
		public unsafe int BBSledGetversion ()
		{
			if (id_BBSledGetversion == IntPtr.Zero)
				id_BBSledGetversion = JNIEnv.GetMethodID (class_ref, "BBSledGetversion", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBSledGetversion);
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledOpen ();
		}
#pragma warning restore 0169

		IntPtr id_BBSledOpen;
		public unsafe int BBSledOpen ()
		{
			if (id_BBSledOpen == IntPtr.Zero)
				id_BBSledOpen = JNIEnv.GetMethodID (class_ref, "BBSledOpen", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBSledOpen);
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.BBSledRead ());
		}
#pragma warning restore 0169

		IntPtr id_BBSledRead;
		public unsafe byte[] BBSledRead ()
		{
			if (id_BBSledRead == IntPtr.Zero)
				id_BBSledRead = JNIEnv.GetMethodID (class_ref, "BBSledRead", "()[B");
			return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_BBSledRead), JniHandleOwnership.TransferLocalRef, typeof (byte));
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
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BBSledWakeup ();
		}
#pragma warning restore 0169

		IntPtr id_BBSledWakeup;
		public unsafe int BBSledWakeup ()
		{
			if (id_BBSledWakeup == IntPtr.Zero)
				id_BBSledWakeup = JNIEnv.GetMethodID (class_ref, "BBSledWakeup", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBSledWakeup);
		}

		static Delegate cb_BBSledWrite_arrayB;
#pragma warning disable 0169
		static Delegate GetBBSledWrite_arrayBHandler ()
		{
			if (cb_BBSledWrite_arrayB == null)
				cb_BBSledWrite_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_BBSledWrite_arrayB);
			return cb_BBSledWrite_arrayB;
		}

		static int n_BBSledWrite_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.BBSledWrite (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_BBSledWrite_arrayB;
		public unsafe int BBSledWrite (byte[] p0)
		{
			if (id_BBSledWrite_arrayB == IntPtr.Zero)
				id_BBSledWrite_arrayB = JNIEnv.GetMethodID (class_ref, "BBSledWrite", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_BBSledWrite_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_asBinder;
#pragma warning disable 0169
		static Delegate GetAsBinderHandler ()
		{
			if (cb_asBinder == null)
				cb_asBinder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsBinder);
			return cb_asBinder;
		}

		static IntPtr n_AsBinder (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Bluebird.Sled.ISledManagerService __this = global::Java.Lang.Object.GetObject<global::Com.Bluebird.Sled.ISledManagerService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AsBinder ());
		}
#pragma warning restore 0169

		IntPtr id_asBinder;
		public unsafe global::Android.OS.IBinder AsBinder ()
		{
			if (id_asBinder == IntPtr.Zero)
				id_asBinder = JNIEnv.GetMethodID (class_ref, "asBinder", "()Landroid/os/IBinder;");
			return global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asBinder), JniHandleOwnership.TransferLocalRef);
		}

	}

}
