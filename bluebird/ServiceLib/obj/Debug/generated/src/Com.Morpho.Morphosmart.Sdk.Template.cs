using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/Template", DoNotGenerateAcw=true)]
	public partial class Template : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/Template", typeof (Template));
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

		protected Template (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/constructor[@name='Template' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Template ()
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

		static Delegate cb_getDataIndex;
#pragma warning disable 0169
		static Delegate GetGetDataIndexHandler ()
		{
			if (cb_getDataIndex == null)
				cb_getDataIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataIndex);
			return cb_getDataIndex;
		}

		static int n_GetDataIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setDataIndex_I;
#pragma warning disable 0169
		static Delegate GetSetDataIndex_IHandler ()
		{
			if (cb_setDataIndex_I == null)
				cb_setDataIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDataIndex_I);
			return cb_setDataIndex_I;
		}

		static void n_SetDataIndex_I (IntPtr jnienv, IntPtr native__this, int dataIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DataIndex = dataIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int DataIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='getDataIndex' and count(parameter)=0]"
			[Register ("getDataIndex", "()I", "GetGetDataIndexHandler")]
			get {
				const string __id = "getDataIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setDataIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDataIndex", "(I)V", "GetSetDataIndex_IHandler")]
			set {
				const string __id = "setDataIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTemplateFVPType;
#pragma warning disable 0169
		static Delegate GetGetTemplateFVPTypeHandler ()
		{
			if (cb_getTemplateFVPType == null)
				cb_getTemplateFVPType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTemplateFVPType);
			return cb_getTemplateFVPType;
		}

		static IntPtr n_GetTemplateFVPType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TemplateFVPType);
		}
#pragma warning restore 0169

		static Delegate cb_setTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_;
#pragma warning disable 0169
		static Delegate GetSetTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_Handler ()
		{
			if (cb_setTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ == null)
				cb_setTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_);
			return cb_setTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_;
		}

		static void n_SetTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateFVPType)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType templateFVPType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (native_templateFVPType, JniHandleOwnership.DoNotTransfer);
			__this.TemplateFVPType = templateFVPType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType TemplateFVPType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='getTemplateFVPType' and count(parameter)=0]"
			[Register ("getTemplateFVPType", "()Lcom/morpho/morphosmart/sdk/TemplateFVPType;", "GetGetTemplateFVPTypeHandler")]
			get {
				const string __id = "getTemplateFVPType.()Lcom/morpho/morphosmart/sdk/TemplateFVPType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVPType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setTemplateFVPType' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.TemplateFVPType']]"
			[Register ("setTemplateFVPType", "(Lcom/morpho/morphosmart/sdk/TemplateFVPType;)V", "GetSetTemplateFVPType_Lcom_morpho_morphosmart_sdk_TemplateFVPType_Handler")]
			set {
				const string __id = "setTemplateFVPType.(Lcom/morpho/morphosmart/sdk/TemplateFVPType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTemplateQuality;
#pragma warning disable 0169
		static Delegate GetGetTemplateQualityHandler ()
		{
			if (cb_getTemplateQuality == null)
				cb_getTemplateQuality = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTemplateQuality);
			return cb_getTemplateQuality;
		}

		static int n_GetTemplateQuality (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TemplateQuality;
		}
#pragma warning restore 0169

		static Delegate cb_setTemplateQuality_I;
#pragma warning disable 0169
		static Delegate GetSetTemplateQuality_IHandler ()
		{
			if (cb_setTemplateQuality_I == null)
				cb_setTemplateQuality_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTemplateQuality_I);
			return cb_setTemplateQuality_I;
		}

		static void n_SetTemplateQuality_I (IntPtr jnienv, IntPtr native__this, int templateQuality)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TemplateQuality = templateQuality;
		}
#pragma warning restore 0169

		public virtual unsafe int TemplateQuality {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='getTemplateQuality' and count(parameter)=0]"
			[Register ("getTemplateQuality", "()I", "GetGetTemplateQualityHandler")]
			get {
				const string __id = "getTemplateQuality.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setTemplateQuality' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTemplateQuality", "(I)V", "GetSetTemplateQuality_IHandler")]
			set {
				const string __id = "setTemplateQuality.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTemplateType;
#pragma warning disable 0169
		static Delegate GetGetTemplateTypeHandler ()
		{
			if (cb_getTemplateType == null)
				cb_getTemplateType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTemplateType);
			return cb_getTemplateType;
		}

		static IntPtr n_GetTemplateType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TemplateType);
		}
#pragma warning restore 0169

		static Delegate cb_setTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_;
#pragma warning disable 0169
		static Delegate GetSetTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_Handler ()
		{
			if (cb_setTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_ == null)
				cb_setTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_);
			return cb_setTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_;
		}

		static void n_SetTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateType)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateType> (native_templateType, JniHandleOwnership.DoNotTransfer);
			__this.TemplateType = templateType;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.TemplateType TemplateType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='getTemplateType' and count(parameter)=0]"
			[Register ("getTemplateType", "()Lcom/morpho/morphosmart/sdk/TemplateType;", "GetGetTemplateTypeHandler")]
			get {
				const string __id = "getTemplateType.()Lcom/morpho/morphosmart/sdk/TemplateType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setTemplateType' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.TemplateType']]"
			[Register ("setTemplateType", "(Lcom/morpho/morphosmart/sdk/TemplateType;)V", "GetSetTemplateType_Lcom_morpho_morphosmart_sdk_TemplateType_Handler")]
			set {
				const string __id = "setTemplateType.(Lcom/morpho/morphosmart/sdk/TemplateType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetData ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='getData' and count(parameter)=0]"
		[Register ("getData", "()[B", "GetGetDataHandler")]
		public virtual unsafe byte[] GetData ()
		{
			const string __id = "getData.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_setData_arrayB;
#pragma warning disable 0169
		static Delegate GetSetData_arrayBHandler ()
		{
			if (cb_setData_arrayB == null)
				cb_setData_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_arrayB);
			return cb_setData_arrayB;
		}

		static void n_SetData_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetData (data);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setData", "([B)V", "GetSetData_arrayBHandler")]
		public virtual unsafe void SetData (byte[] data)
		{
			const string __id = "setData.([B)V";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
			}
		}

		static Delegate cb_setTemplateFVPType_I;
#pragma warning disable 0169
		static Delegate GetSetTemplateFVPType_IHandler ()
		{
			if (cb_setTemplateFVPType_I == null)
				cb_setTemplateFVPType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTemplateFVPType_I);
			return cb_setTemplateFVPType_I;
		}

		static void n_SetTemplateFVPType_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTemplateFVPType (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setTemplateFVPType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTemplateFVPType", "(I)V", "GetSetTemplateFVPType_IHandler")]
		public virtual unsafe void SetTemplateFVPType (int id)
		{
			const string __id = "setTemplateFVPType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTemplateType_I;
#pragma warning disable 0169
		static Delegate GetSetTemplateType_IHandler ()
		{
			if (cb_setTemplateType_I == null)
				cb_setTemplateType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTemplateType_I);
			return cb_setTemplateType_I;
		}

		static void n_SetTemplateType_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			global::Com.Morpho.Morphosmart.Sdk.Template __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTemplateType (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='Template']/method[@name='setTemplateType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTemplateType", "(I)V", "GetSetTemplateType_IHandler")]
		public virtual unsafe void SetTemplateType (int id)
		{
			const string __id = "setTemplateType.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
