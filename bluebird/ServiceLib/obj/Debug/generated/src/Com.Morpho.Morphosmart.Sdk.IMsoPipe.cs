using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoPipe']"
	[Register ("com/morpho/morphosmart/sdk/IMsoPipe", "", "Com.Morpho.Morphosmart.Sdk.IMsoPipeInvoker")]
	public partial interface IMsoPipe : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoPipe']/method[@name='clientPipe_CallbackComClose' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("clientPipe_CallbackComClose", "(Ljava/lang/Object;)I", "GetClientPipe_CallbackComClose_Ljava_lang_Object_Handler:Com.Morpho.Morphosmart.Sdk.IMsoPipeInvoker, ServiceLib")]
		int ClientPipe_CallbackComClose (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoPipe']/method[@name='clientPipe_CallbackComOpen' and count(parameter)=5 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='long'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("clientPipe_CallbackComOpen", "(Ljava/lang/Object;Ljava/lang/String;JILjava/lang/String;)I", "GetClientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_Handler:Com.Morpho.Morphosmart.Sdk.IMsoPipeInvoker, ServiceLib")]
		int ClientPipe_CallbackComOpen (global::Java.Lang.Object p0, string p1, long p2, int p3, string p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoPipe']/method[@name='clientPipe_CallbackComReceive' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("clientPipe_CallbackComReceive", "(Ljava/lang/Object;JLjava/util/ArrayList;)I", "GetClientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoPipeInvoker, ServiceLib")]
		int ClientPipe_CallbackComReceive (global::Java.Lang.Object p0, long p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoPipe']/method[@name='clientPipe_CallbackComReceiveFree' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("clientPipe_CallbackComReceiveFree", "(Ljava/lang/Object;Ljava/util/ArrayList;)I", "GetClientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoPipeInvoker, ServiceLib")]
		int ClientPipe_CallbackComReceiveFree (global::Java.Lang.Object p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoPipe']/method[@name='clientPipe_CallbackComSend' and count(parameter)=3 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='long'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("clientPipe_CallbackComSend", "(Ljava/lang/Object;JLjava/util/ArrayList;)I", "GetClientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoPipeInvoker, ServiceLib")]
		int ClientPipe_CallbackComSend (global::Java.Lang.Object p0, long p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2);

	}

	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/IMsoPipe", DoNotGenerateAcw=true)]
	internal class IMsoPipeInvoker : global::Java.Lang.Object, IMsoPipe {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/morpho/morphosmart/sdk/IMsoPipe", typeof (IMsoPipeInvoker));

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

		public static IMsoPipe GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMsoPipe> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.morpho.morphosmart.sdk.IMsoPipe"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMsoPipeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_clientPipe_CallbackComClose_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetClientPipe_CallbackComClose_Ljava_lang_Object_Handler ()
		{
			if (cb_clientPipe_CallbackComClose_Ljava_lang_Object_ == null)
				cb_clientPipe_CallbackComClose_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_ClientPipe_CallbackComClose_Ljava_lang_Object_);
			return cb_clientPipe_CallbackComClose_Ljava_lang_Object_;
		}

		static int n_ClientPipe_CallbackComClose_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoPipe __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoPipe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ClientPipe_CallbackComClose (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clientPipe_CallbackComClose_Ljava_lang_Object_;
		public unsafe int ClientPipe_CallbackComClose (global::Java.Lang.Object p0)
		{
			if (id_clientPipe_CallbackComClose_Ljava_lang_Object_ == IntPtr.Zero)
				id_clientPipe_CallbackComClose_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "clientPipe_CallbackComClose", "(Ljava/lang/Object;)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_clientPipe_CallbackComClose_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetClientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_Handler ()
		{
			if (cb_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_ == null)
				cb_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, long, int, IntPtr, int>) n_ClientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_);
			return cb_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_;
		}

		static int n_ClientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, long p2, int p3, IntPtr native_p4)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoPipe __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoPipe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ClientPipe_CallbackComOpen (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_;
		public unsafe int ClientPipe_CallbackComOpen (global::Java.Lang.Object p0, string p1, long p2, int p3, string p4)
		{
			if (id_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_ == IntPtr.Zero)
				id_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_ = JNIEnv.GetMethodID (class_ref, "clientPipe_CallbackComOpen", "(Ljava/lang/Object;Ljava/lang/String;JILjava/lang/String;)I");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p4 = JNIEnv.NewString (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_clientPipe_CallbackComOpen_Ljava_lang_Object_Ljava_lang_String_JILjava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p4);
			return __ret;
		}

		static Delegate cb_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetClientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_Handler ()
		{
			if (cb_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_ == null)
				cb_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, int>) n_ClientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_);
			return cb_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_;
		}

		static int n_ClientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoPipe __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoPipe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ClientPipe_CallbackComReceive (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_;
		public unsafe int ClientPipe_CallbackComReceive (global::Java.Lang.Object p0, long p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			if (id_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_ == IntPtr.Zero)
				id_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "clientPipe_CallbackComReceive", "(Ljava/lang/Object;JLjava/util/ArrayList;)I");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_clientPipe_CallbackComReceive_Ljava_lang_Object_JLjava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetClientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_Handler ()
		{
			if (cb_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_ == null)
				cb_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ClientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_);
			return cb_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_;
		}

		static int n_ClientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoPipe __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoPipe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ClientPipe_CallbackComReceiveFree (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_;
		public unsafe int ClientPipe_CallbackComReceiveFree (global::Java.Lang.Object p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			if (id_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "clientPipe_CallbackComReceiveFree", "(Ljava/lang/Object;Ljava/util/ArrayList;)I");
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_clientPipe_CallbackComReceiveFree_Ljava_lang_Object_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetClientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_Handler ()
		{
			if (cb_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_ == null)
				cb_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, int>) n_ClientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_);
			return cb_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_;
		}

		static int n_ClientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoPipe __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoPipe> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ClientPipe_CallbackComSend (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_;
		public unsafe int ClientPipe_CallbackComSend (global::Java.Lang.Object p0, long p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			if (id_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_ == IntPtr.Zero)
				id_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "clientPipe_CallbackComSend", "(Ljava/lang/Object;JLjava/util/ArrayList;)I");
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_clientPipe_CallbackComSend_Ljava_lang_Object_JLjava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
