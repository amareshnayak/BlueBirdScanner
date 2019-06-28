using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Pipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/pipe/PipeServer", DoNotGenerateAcw=true)]
	public partial class PipeServer : global::Java.Lang.Object, global::Java.Lang.IRunnable {


		public static class InterfaceConsts {

			// The following are fields from: com.morpho.morphosmart.pipe.IMsoPipeConstants

			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='COMERR_TIMEOUT_RECEIVE']"
			[Register ("COMERR_TIMEOUT_RECEIVE")]
			public const int ComerrTimeoutReceive = (int) -10000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='MAX_RECV_TIME']"
			[Register ("MAX_RECV_TIME")]
			public const int MaxRecvTime = (int) 10000;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_COMRECV']"
			[Register ("SP_PIPE_TAG_COMRECV")]
			public const sbyte SpPipeTagComrecv = (sbyte) 82;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_COMSEND']"
			[Register ("SP_PIPE_TAG_COMSEND")]
			public const sbyte SpPipeTagComsend = (sbyte) 83;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_CONNECT_MSO']"
			[Register ("SP_PIPE_TAG_CONNECT_MSO")]
			public const sbyte SpPipeTagConnectMso = (sbyte) 67;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/interface[@name='IMsoPipeConstants']/field[@name='SP_PIPE_TAG_MSO_LIST']"
			[Register ("SP_PIPE_TAG_MSO_LIST")]
			public const sbyte SpPipeTagMsoList = (sbyte) 76;
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/pipe/PipeServer", typeof (PipeServer));
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

		protected PipeServer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/constructor[@name='PipeServer' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.device.IMophoDeviceManager']]"
		[Register (".ctor", "(Lcom/morpho/morphosmart/device/IMophoDeviceManager;)V", "")]
		public unsafe PipeServer (global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/morpho/morphosmart/device/IMophoDeviceManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/constructor[@name='PipeServer' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.device.IMophoDeviceManager']]"
		[Register (".ctor", "(ILcom/morpho/morphosmart/device/IMophoDeviceManager;)V", "")]
		public unsafe PipeServer (int p0, global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager p1)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILcom/morpho/morphosmart/device/IMophoDeviceManager;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isRunningServer;
#pragma warning disable 0169
		static Delegate GetIsRunningServerHandler ()
		{
			if (cb_isRunningServer == null)
				cb_isRunningServer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRunningServer);
			return cb_isRunningServer;
		}

		static bool n_IsRunningServer (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRunningServer;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRunningServer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='isRunningServer' and count(parameter)=0]"
			[Register ("isRunningServer", "()Z", "GetIsRunningServerHandler")]
			get {
				const string __id = "isRunningServer.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_process_client_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetProcess_client_Ljava_net_Socket_Handler ()
		{
			if (cb_process_client_Ljava_net_Socket_ == null)
				cb_process_client_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Process_client_Ljava_net_Socket_);
			return cb_process_client_Ljava_net_Socket_;
		}

		static void n_Process_client_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Process_client (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='process_client' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
		[Register ("process_client", "(Ljava/net/Socket;)V", "GetProcess_client_Ljava_net_Socket_Handler")]
		public virtual unsafe void Process_client (global::Java.Net.Socket p0)
		{
			const string __id = "process_client.(Ljava/net/Socket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_;
#pragma warning disable 0169
		static Delegate GetSetiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_Handler ()
		{
			if (cb_setiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_ == null)
				cb_setiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_);
			return cb_setiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_;
		}

		static void n_SetiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager p0 = (global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager)global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetiMorphoDevice (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='setiMorphoDevice' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.device.IMophoDeviceManager']]"
		[Register ("setiMorphoDevice", "(Lcom/morpho/morphosmart/device/IMophoDeviceManager;)V", "GetSetiMorphoDevice_Lcom_morpho_morphosmart_device_IMophoDeviceManager_Handler")]
		public virtual unsafe void SetiMorphoDevice (global::Com.Morpho.Morphosmart.Device.IMophoDeviceManager p0)
		{
			const string __id = "setiMorphoDevice.(Lcom/morpho/morphosmart/device/IMophoDeviceManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setlogger_Lcom_morpho_morphosmart_logger_Logger_;
#pragma warning disable 0169
		static Delegate GetSetlogger_Lcom_morpho_morphosmart_logger_Logger_Handler ()
		{
			if (cb_setlogger_Lcom_morpho_morphosmart_logger_Logger_ == null)
				cb_setlogger_Lcom_morpho_morphosmart_logger_Logger_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Setlogger_Lcom_morpho_morphosmart_logger_Logger_);
			return cb_setlogger_Lcom_morpho_morphosmart_logger_Logger_;
		}

		static void n_Setlogger_Lcom_morpho_morphosmart_logger_Logger_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Logger.Logger p0 = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.Logger> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Setlogger (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='setlogger' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.logger.Logger']]"
		[Register ("setlogger", "(Lcom/morpho/morphosmart/logger/Logger;)V", "GetSetlogger_Lcom_morpho_morphosmart_logger_Logger_Handler")]
		public virtual unsafe void Setlogger (global::Com.Morpho.Morphosmart.Logger.Logger p0)
		{
			const string __id = "setlogger.(Lcom/morpho/morphosmart/logger/Logger;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeServer __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeServer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeServer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
