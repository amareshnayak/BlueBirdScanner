using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Logger {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/logger/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='Logger']/field[@name='subscribers']"
		[Register ("subscribers")]
		public static global::System.Collections.IList Subscribers {
			get {
				const string __id = "subscribers.Ljava/util/List;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "subscribers.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/logger/Logger", typeof (Logger));
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

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public static unsafe global::Com.Morpho.Morphosmart.Logger.Logger Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='Logger']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/morpho/morphosmart/logger/Logger;", "GetGetInstanceHandler")]
			get {
				const string __id = "getInstance.()Lcom/morpho/morphosmart/logger/Logger;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.Logger> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_log_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetLog_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_Handler ()
		{
			if (cb_log_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_ == null)
				cb_log_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Log_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_);
			return cb_log_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_;
		}

		static void n_Log_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Logger.Logger __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Logger.LogLevel p0 = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Log (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='Logger']/method[@name='log' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.logger.LogLevel'] and parameter[2][@type='java.lang.String']]"
		[Register ("log", "(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/String;)V", "GetLog_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_String_Handler")]
		public virtual unsafe void Log (global::Com.Morpho.Morphosmart.Logger.LogLevel p0, string p1)
		{
			const string __id = "log.(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='Logger']/method[@name='sendNotification' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.logger.LogLevel'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendNotification", "(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/String;)V", "")]
		public static unsafe void SendNotification (global::Com.Morpho.Morphosmart.Logger.LogLevel p0, string p1)
		{
			const string __id = "sendNotification.(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='Logger']/method[@name='subscribe' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.logger.ISubscriber']]"
		[Register ("subscribe", "(Lcom/morpho/morphosmart/logger/ISubscriber;)V", "")]
		public static unsafe void Subscribe (global::Com.Morpho.Morphosmart.Logger.ISubscriber p0)
		{
			const string __id = "subscribe.(Lcom/morpho/morphosmart/logger/ISubscriber;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
