using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoString']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoString", DoNotGenerateAcw=true)]
	public partial class MorphoString : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoString", typeof (MorphoString));
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

		protected MorphoString (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoString']/constructor[@name='MorphoString' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoString ()
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

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoString __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_lang_String_Handler ()
		{
			if (cb_setData_Ljava_lang_String_ == null)
				cb_setData_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_lang_String_);
			return cb_setData_Ljava_lang_String_;
		}

		static void n_SetData_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoString __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string data = JNIEnv.GetString (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Data = data;
		}
#pragma warning restore 0169

		public virtual unsafe string Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoString']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/String;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoString']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setData", "(Ljava/lang/String;)V", "GetSetData_Ljava_lang_String_Handler")]
			set {
				const string __id = "setData.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBufferData;
#pragma warning disable 0169
		static Delegate GetGetBufferDataHandler ()
		{
			if (cb_getBufferData == null)
				cb_getBufferData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBufferData);
			return cb_getBufferData;
		}

		static IntPtr n_GetBufferData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoString __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBufferData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoString']/method[@name='getBufferData' and count(parameter)=0]"
		[Register ("getBufferData", "()[B", "GetGetBufferDataHandler")]
		public virtual unsafe byte[] GetBufferData ()
		{
			const string __id = "getBufferData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setBufferData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetBufferData_arrayBHandler ()
		{
			if (cb_setBufferData_arrayB == null)
				cb_setBufferData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBufferData_arrayB);
			return cb_setBufferData_arrayB;
		}

		static void n_SetBufferData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_bufferData)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoString __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoString> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] bufferData = (byte[]) JNIEnv.GetArray (native_bufferData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetBufferData (bufferData);
			if (bufferData != null)
				JNIEnv.CopyArray (bufferData, native_bufferData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoString']/method[@name='setBufferData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setBufferData", "([B)V", "GetSetBufferData_arrayBHandler")]
		public virtual unsafe void SetBufferData (byte[] bufferData)
		{
			const string __id = "setBufferData.([B)V";
			IntPtr native_bufferData = JNIEnv.NewArray (bufferData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bufferData);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (bufferData != null) {
					JNIEnv.CopyArray (native_bufferData, bufferData);
					JNIEnv.DeleteLocalRef (native_bufferData);
				}
			}
		}

	}
}
