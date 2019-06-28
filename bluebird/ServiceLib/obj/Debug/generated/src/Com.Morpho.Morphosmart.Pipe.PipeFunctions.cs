using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Pipe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/pipe/PipeFunctions", DoNotGenerateAcw=true)]
	public partial class PipeFunctions : global::Java.Lang.Object {


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

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/pipe/PipeFunctions", typeof (PipeFunctions));
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

		protected PipeFunctions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/constructor[@name='PipeFunctions' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PipeFunctions ()
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

		static Delegate cb_getSocket;
#pragma warning disable 0169
		static Delegate GetGetSocketHandler ()
		{
			if (cb_getSocket == null)
				cb_getSocket = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSocket);
			return cb_getSocket;
		}

		static IntPtr n_GetSocket (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Socket);
		}
#pragma warning restore 0169

		static Delegate cb_setSocket_Ljava_net_Socket_;
#pragma warning disable 0169
		static Delegate GetSetSocket_Ljava_net_Socket_Handler ()
		{
			if (cb_setSocket_Ljava_net_Socket_ == null)
				cb_setSocket_Ljava_net_Socket_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSocket_Ljava_net_Socket_);
			return cb_setSocket_Ljava_net_Socket_;
		}

		static void n_SetSocket_Ljava_net_Socket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Net.Socket p0 = global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Socket = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.Socket Socket {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='getSocket' and count(parameter)=0]"
			[Register ("getSocket", "()Ljava/net/Socket;", "GetGetSocketHandler")]
			get {
				const string __id = "getSocket.()Ljava/net/Socket;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.Socket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='setSocket' and count(parameter)=1 and parameter[1][@type='java.net.Socket']]"
			[Register ("setSocket", "(Ljava/net/Socket;)V", "GetSetSocket_Ljava_net_Socket_Handler")]
			set {
				const string __id = "setSocket.(Ljava/net/Socket;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_Sp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_;
#pragma warning disable 0169
		static Delegate GetSp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_Handler ()
		{
			if (cb_Sp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_ == null)
				cb_Sp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Sp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_);
			return cb_Sp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_;
		}

		static int n_Sp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Pipe.Holder p0 = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.Holder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Sp_Pipe_Receive_LenAndDatas (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='Sp_Pipe_Receive_LenAndDatas' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.pipe.Holder&lt;byte[]&gt;']]"
		[Register ("Sp_Pipe_Receive_LenAndDatas", "(Lcom/morpho/morphosmart/pipe/Holder;)I", "GetSp_Pipe_Receive_LenAndDatas_Lcom_morpho_morphosmart_pipe_Holder_Handler")]
		public virtual unsafe int Sp_Pipe_Receive_LenAndDatas (global::Com.Morpho.Morphosmart.Pipe.Holder p0)
		{
			const string __id = "Sp_Pipe_Receive_LenAndDatas.(Lcom/morpho/morphosmart/pipe/Holder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_Sp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_II;
#pragma warning disable 0169
		static Delegate GetSp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_IIHandler ()
		{
			if (cb_Sp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_II == null)
				cb_Sp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_Sp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_II);
			return cb_Sp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_II;
		}

		static int n_Sp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Pipe.Holder p0 = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.Holder> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Sp_Pipe_Receive_Responses (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='Sp_Pipe_Receive_Responses' and count(parameter)=3 and parameter[1][@type='com.morpho.morphosmart.pipe.Holder&lt;byte[]&gt;'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("Sp_Pipe_Receive_Responses", "(Lcom/morpho/morphosmart/pipe/Holder;II)I", "GetSp_Pipe_Receive_Responses_Lcom_morpho_morphosmart_pipe_Holder_IIHandler")]
		public virtual unsafe int Sp_Pipe_Receive_Responses (global::Com.Morpho.Morphosmart.Pipe.Holder p0, int p1, int p2)
		{
			const string __id = "Sp_Pipe_Receive_Responses.(Lcom/morpho/morphosmart/pipe/Holder;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_Sp_Pipe_Receive_Status;
#pragma warning disable 0169
		static Delegate GetSp_Pipe_Receive_StatusHandler ()
		{
			if (cb_Sp_Pipe_Receive_Status == null)
				cb_Sp_Pipe_Receive_Status = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Sp_Pipe_Receive_Status);
			return cb_Sp_Pipe_Receive_Status;
		}

		static int n_Sp_Pipe_Receive_Status (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sp_Pipe_Receive_Status ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='Sp_Pipe_Receive_Status' and count(parameter)=0]"
		[Register ("Sp_Pipe_Receive_Status", "()I", "GetSp_Pipe_Receive_StatusHandler")]
		public virtual unsafe int Sp_Pipe_Receive_Status ()
		{
			const string __id = "Sp_Pipe_Receive_Status.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_Sp_Pipe_Send_LenAndDatas_arrayB;
#pragma warning disable 0169
		static Delegate GetSp_Pipe_Send_LenAndDatas_arrayBHandler ()
		{
			if (cb_Sp_Pipe_Send_LenAndDatas_arrayB == null)
				cb_Sp_Pipe_Send_LenAndDatas_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Sp_Pipe_Send_LenAndDatas_arrayB);
			return cb_Sp_Pipe_Send_LenAndDatas_arrayB;
		}

		static int n_Sp_Pipe_Send_LenAndDatas_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Sp_Pipe_Send_LenAndDatas (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='Sp_Pipe_Send_LenAndDatas' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("Sp_Pipe_Send_LenAndDatas", "([B)I", "GetSp_Pipe_Send_LenAndDatas_arrayBHandler")]
		public virtual unsafe int Sp_Pipe_Send_LenAndDatas (byte[] p0)
		{
			const string __id = "Sp_Pipe_Send_LenAndDatas.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_Sp_Pipe_Send_TagAndStatus_BI;
#pragma warning disable 0169
		static Delegate GetSp_Pipe_Send_TagAndStatus_BIHandler ()
		{
			if (cb_Sp_Pipe_Send_TagAndStatus_BI == null)
				cb_Sp_Pipe_Send_TagAndStatus_BI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte, int, int>) n_Sp_Pipe_Send_TagAndStatus_BI);
			return cb_Sp_Pipe_Send_TagAndStatus_BI;
		}

		static int n_Sp_Pipe_Send_TagAndStatus_BI (IntPtr jnienv, IntPtr native__this, sbyte p0, int p1)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Sp_Pipe_Send_TagAndStatus (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='Sp_Pipe_Send_TagAndStatus' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='int']]"
		[Register ("Sp_Pipe_Send_TagAndStatus", "(BI)I", "GetSp_Pipe_Send_TagAndStatus_BIHandler")]
		public virtual unsafe int Sp_Pipe_Send_TagAndStatus (sbyte p0, int p1)
		{
			const string __id = "Sp_Pipe_Send_TagAndStatus.(BI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_TCP_Client_Close;
#pragma warning disable 0169
		static Delegate GetTCP_Client_CloseHandler ()
		{
			if (cb_TCP_Client_Close == null)
				cb_TCP_Client_Close = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_TCP_Client_Close);
			return cb_TCP_Client_Close;
		}

		static int n_TCP_Client_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TCP_Client_Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='TCP_Client_Close' and count(parameter)=0]"
		[Register ("TCP_Client_Close", "()I", "GetTCP_Client_CloseHandler")]
		public virtual unsafe int TCP_Client_Close ()
		{
			const string __id = "TCP_Client_Close.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_TCP_Client_Connect_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetTCP_Client_Connect_Ljava_lang_String_IHandler ()
		{
			if (cb_TCP_Client_Connect_Ljava_lang_String_I == null)
				cb_TCP_Client_Connect_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_TCP_Client_Connect_Ljava_lang_String_I);
			return cb_TCP_Client_Connect_Ljava_lang_String_I;
		}

		static int n_TCP_Client_Connect_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TCP_Client_Connect (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='TCP_Client_Connect' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("TCP_Client_Connect", "(Ljava/lang/String;I)I", "GetTCP_Client_Connect_Ljava_lang_String_IHandler")]
		public virtual unsafe int TCP_Client_Connect (string p0, int p1)
		{
			const string __id = "TCP_Client_Connect.(Ljava/lang/String;I)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_TCP_Recv_arrayBII;
#pragma warning disable 0169
		static Delegate GetTCP_Recv_arrayBIIHandler ()
		{
			if (cb_TCP_Recv_arrayBII == null)
				cb_TCP_Recv_arrayBII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_TCP_Recv_arrayBII);
			return cb_TCP_Recv_arrayBII;
		}

		static int n_TCP_Recv_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TCP_Recv (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='TCP_Recv' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("TCP_Recv", "([BII)I", "GetTCP_Recv_arrayBIIHandler")]
		public virtual unsafe int TCP_Recv (byte[] p0, int p1, int p2)
		{
			const string __id = "TCP_Recv.([BII)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_TCP_Send_arrayB;
#pragma warning disable 0169
		static Delegate GetTCP_Send_arrayBHandler ()
		{
			if (cb_TCP_Send_arrayB == null)
				cb_TCP_Send_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_TCP_Send_arrayB);
			return cb_TCP_Send_arrayB;
		}

		static int n_TCP_Send_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TCP_Send (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='TCP_Send' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("TCP_Send", "([B)I", "GetTCP_Send_arrayBHandler")]
		public virtual unsafe int TCP_Send (byte[] p0)
		{
			const string __id = "TCP_Send.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_reverse4Byte_arrayB;
#pragma warning disable 0169
		static Delegate GetReverse4Byte_arrayBHandler ()
		{
			if (cb_reverse4Byte_arrayB == null)
				cb_reverse4Byte_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Reverse4Byte_arrayB);
			return cb_reverse4Byte_arrayB;
		}

		static int n_Reverse4Byte_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Reverse4Byte (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='reverse4Byte' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("reverse4Byte", "([B)I", "GetReverse4Byte_arrayBHandler")]
		public virtual unsafe int Reverse4Byte (byte[] p0)
		{
			const string __id = "reverse4Byte.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		static Delegate cb_reverseInt_I;
#pragma warning disable 0169
		static Delegate GetReverseInt_IHandler ()
		{
			if (cb_reverseInt_I == null)
				cb_reverseInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReverseInt_I);
			return cb_reverseInt_I;
		}

		static IntPtr n_ReverseInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReverseInt (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='reverseInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("reverseInt", "(I)[B", "GetReverseInt_IHandler")]
		public virtual unsafe byte[] ReverseInt (int p0)
		{
			const string __id = "reverseInt.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setFinish_Z;
#pragma warning disable 0169
		static Delegate GetSetFinish_ZHandler ()
		{
			if (cb_setFinish_Z == null)
				cb_setFinish_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetFinish_Z);
			return cb_setFinish_Z;
		}

		static void n_SetFinish_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Morpho.Morphosmart.Pipe.PipeFunctions __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Pipe.PipeFunctions> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFinish (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.pipe']/class[@name='PipeFunctions']/method[@name='setFinish' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFinish", "(Z)V", "GetSetFinish_ZHandler")]
		public virtual unsafe void SetFinish (bool p0)
		{
			const string __id = "setFinish.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
