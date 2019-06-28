using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Logger {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.morpho.morphosmart.logger']/interface[@name='ISubscriber']"
	[Register ("com/morpho/morphosmart/logger/ISubscriber", "", "Com.Morpho.Morphosmart.Logger.ISubscriberInvoker")]
	public partial interface ISubscriber : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/interface[@name='ISubscriber']/method[@name='notification' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.logger.LogLevel'] and parameter[2][@type='java.lang.Object']]"
		[Register ("notification", "(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/Object;)V", "GetNotification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_Handler:Com.Morpho.Morphosmart.Logger.ISubscriberInvoker, ServiceLib")]
		void Notification (global::Com.Morpho.Morphosmart.Logger.LogLevel p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/morpho/morphosmart/logger/ISubscriber", DoNotGenerateAcw=true)]
	internal class ISubscriberInvoker : global::Java.Lang.Object, ISubscriber {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/morpho/morphosmart/logger/ISubscriber", typeof (ISubscriberInvoker));

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

		public static ISubscriber GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISubscriber> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.morpho.morphosmart.logger.ISubscriber"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISubscriberInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetNotification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_Handler ()
		{
			if (cb_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_ == null)
				cb_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_);
			return cb_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_;
		}

		static void n_Notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Logger.ISubscriber __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.ISubscriber> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Logger.LogLevel p0 = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Notification (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_;
		public unsafe void Notification (global::Com.Morpho.Morphosmart.Logger.LogLevel p0, global::Java.Lang.Object p1)
		{
			if (id_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_ == IntPtr.Zero)
				id_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "notification", "(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/Object;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_notification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_, __args);
		}

	}

}
