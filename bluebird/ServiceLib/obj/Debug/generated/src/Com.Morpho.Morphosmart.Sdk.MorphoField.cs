using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoField", DoNotGenerateAcw=true)]
	public partial class MorphoField : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/field[@name='MORPHO_FIELD_NAME_LEN']"
		[Register ("MORPHO_FIELD_NAME_LEN")]
		public const int MorphoFieldNameLen = (int) 6;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoField", typeof (MorphoField));
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

		protected MorphoField (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/constructor[@name='MorphoField' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoField ()
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

		static Delegate cb_getFieldAttribute;
#pragma warning disable 0169
		static Delegate GetGetFieldAttributeHandler ()
		{
			if (cb_getFieldAttribute == null)
				cb_getFieldAttribute = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFieldAttribute);
			return cb_getFieldAttribute;
		}

		static IntPtr n_GetFieldAttribute (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FieldAttribute);
		}
#pragma warning restore 0169

		static Delegate cb_setFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_;
#pragma warning disable 0169
		static Delegate GetSetFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_Handler ()
		{
			if (cb_setFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_ == null)
				cb_setFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_);
			return cb_setFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_;
		}

		static void n_SetFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldAttribute)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.FieldAttribute fieldAttribute = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.FieldAttribute> (native_fieldAttribute, JniHandleOwnership.DoNotTransfer);
			__this.FieldAttribute = fieldAttribute;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.FieldAttribute FieldAttribute {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='getFieldAttribute' and count(parameter)=0]"
			[Register ("getFieldAttribute", "()Lcom/morpho/morphosmart/sdk/FieldAttribute;", "GetGetFieldAttributeHandler")]
			get {
				const string __id = "getFieldAttribute.()Lcom/morpho/morphosmart/sdk/FieldAttribute;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.FieldAttribute> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='setFieldAttribute' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.FieldAttribute']]"
			[Register ("setFieldAttribute", "(Lcom/morpho/morphosmart/sdk/FieldAttribute;)V", "GetSetFieldAttribute_Lcom_morpho_morphosmart_sdk_FieldAttribute_Handler")]
			set {
				const string __id = "setFieldAttribute.(Lcom/morpho/morphosmart/sdk/FieldAttribute;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFieldAttributeIntValue;
#pragma warning disable 0169
		static Delegate GetGetFieldAttributeIntValueHandler ()
		{
			if (cb_getFieldAttributeIntValue == null)
				cb_getFieldAttributeIntValue = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFieldAttributeIntValue);
			return cb_getFieldAttributeIntValue;
		}

		static int n_GetFieldAttributeIntValue (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FieldAttributeIntValue;
		}
#pragma warning restore 0169

		static Delegate cb_setFieldAttributeIntValue_I;
#pragma warning disable 0169
		static Delegate GetSetFieldAttributeIntValue_IHandler ()
		{
			if (cb_setFieldAttributeIntValue_I == null)
				cb_setFieldAttributeIntValue_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFieldAttributeIntValue_I);
			return cb_setFieldAttributeIntValue_I;
		}

		static void n_SetFieldAttributeIntValue_I (IntPtr jnienv, IntPtr native__this, int fieldAttributeInteger)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FieldAttributeIntValue = fieldAttributeInteger;
		}
#pragma warning restore 0169

		public virtual unsafe int FieldAttributeIntValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='getFieldAttributeIntValue' and count(parameter)=0]"
			[Register ("getFieldAttributeIntValue", "()I", "GetGetFieldAttributeIntValueHandler")]
			get {
				const string __id = "getFieldAttributeIntValue.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='setFieldAttributeIntValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFieldAttributeIntValue", "(I)V", "GetSetFieldAttributeIntValue_IHandler")]
			set {
				const string __id = "setFieldAttributeIntValue.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxSize;
#pragma warning disable 0169
		static Delegate GetGetMaxSizeHandler ()
		{
			if (cb_getMaxSize == null)
				cb_getMaxSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxSize);
			return cb_getMaxSize;
		}

		static int n_GetMaxSize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxSize_I;
#pragma warning disable 0169
		static Delegate GetSetMaxSize_IHandler ()
		{
			if (cb_setMaxSize_I == null)
				cb_setMaxSize_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxSize_I);
			return cb_setMaxSize_I;
		}

		static void n_SetMaxSize_I (IntPtr jnienv, IntPtr native__this, int maxSize)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxSize = maxSize;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()I", "GetGetMaxSizeHandler")]
			get {
				const string __id = "getMaxSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='setMaxSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxSize", "(I)V", "GetSetMaxSize_IHandler")]
			set {
				const string __id = "setMaxSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		static Delegate cb_setName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetName_Ljava_lang_String_Handler ()
		{
			if (cb_setName_Ljava_lang_String_ == null)
				cb_setName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetName_Ljava_lang_String_);
			return cb_setName_Ljava_lang_String_;
		}

		static void n_SetName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoField __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.Name = name;
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoField']/method[@name='setName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setName", "(Ljava/lang/String;)V", "GetSetName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setName.(Ljava/lang/String;)V";
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

	}
}
