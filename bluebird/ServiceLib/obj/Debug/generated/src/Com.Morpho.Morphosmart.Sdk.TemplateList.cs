using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/TemplateList", DoNotGenerateAcw=true)]
	public partial class TemplateList : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/TemplateList", typeof (TemplateList));
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

		protected TemplateList (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/constructor[@name='TemplateList' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TemplateList ()
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

		static Delegate cb_isActivateFullImageRetrieving;
#pragma warning disable 0169
		static Delegate GetIsActivateFullImageRetrievingHandler ()
		{
			if (cb_isActivateFullImageRetrieving == null)
				cb_isActivateFullImageRetrieving = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsActivateFullImageRetrieving);
			return cb_isActivateFullImageRetrieving;
		}

		static bool n_IsActivateFullImageRetrieving (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ActivateFullImageRetrieving;
		}
#pragma warning restore 0169

		static Delegate cb_setActivateFullImageRetrieving_Z;
#pragma warning disable 0169
		static Delegate GetSetActivateFullImageRetrieving_ZHandler ()
		{
			if (cb_setActivateFullImageRetrieving_Z == null)
				cb_setActivateFullImageRetrieving_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetActivateFullImageRetrieving_Z);
			return cb_setActivateFullImageRetrieving_Z;
		}

		static void n_SetActivateFullImageRetrieving_Z (IntPtr jnienv, IntPtr native__this, bool activateFullImageRetrieving)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ActivateFullImageRetrieving = activateFullImageRetrieving;
		}
#pragma warning restore 0169

		public virtual unsafe bool ActivateFullImageRetrieving {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='isActivateFullImageRetrieving' and count(parameter)=0]"
			[Register ("isActivateFullImageRetrieving", "()Z", "GetIsActivateFullImageRetrievingHandler")]
			get {
				const string __id = "isActivateFullImageRetrieving.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='setActivateFullImageRetrieving' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setActivateFullImageRetrieving", "(Z)V", "GetSetActivateFullImageRetrieving_ZHandler")]
			set {
				const string __id = "setActivateFullImageRetrieving.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNbFVPTemplate;
#pragma warning disable 0169
		static Delegate GetGetNbFVPTemplateHandler ()
		{
			if (cb_getNbFVPTemplate == null)
				cb_getNbFVPTemplate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbFVPTemplate);
			return cb_getNbFVPTemplate;
		}

		static int n_GetNbFVPTemplate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbFVPTemplate;
		}
#pragma warning restore 0169

		public virtual unsafe int NbFVPTemplate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='getNbFVPTemplate' and count(parameter)=0]"
			[Register ("getNbFVPTemplate", "()I", "GetGetNbFVPTemplateHandler")]
			get {
				const string __id = "getNbFVPTemplate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNbTemplate;
#pragma warning disable 0169
		static Delegate GetGetNbTemplateHandler ()
		{
			if (cb_getNbTemplate == null)
				cb_getNbTemplate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbTemplate);
			return cb_getNbTemplate;
		}

		static int n_GetNbTemplate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbTemplate;
		}
#pragma warning restore 0169

		public virtual unsafe int NbTemplate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='getNbTemplate' and count(parameter)=0]"
			[Register ("getNbTemplate", "()I", "GetGetNbTemplateHandler")]
			get {
				const string __id = "getNbTemplate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFVPTemplate_I;
#pragma warning disable 0169
		static Delegate GetGetFVPTemplate_IHandler ()
		{
			if (cb_getFVPTemplate_I == null)
				cb_getFVPTemplate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFVPTemplate_I);
			return cb_getFVPTemplate_I;
		}

		static IntPtr n_GetFVPTemplate_I (IntPtr jnienv, IntPtr native__this, int templateFVPIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetFVPTemplate (templateFVPIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='getFVPTemplate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFVPTemplate", "(I)Lcom/morpho/morphosmart/sdk/TemplateFVP;", "GetGetFVPTemplate_IHandler")]
		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.TemplateFVP GetFVPTemplate (int templateFVPIndex)
		{
			const string __id = "getFVPTemplate.(I)Lcom/morpho/morphosmart/sdk/TemplateFVP;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (templateFVPIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVP> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getImage_I;
#pragma warning disable 0169
		static Delegate GetGetImage_IHandler ()
		{
			if (cb_getImage_I == null)
				cb_getImage_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetImage_I);
			return cb_getImage_I;
		}

		static IntPtr n_GetImage_I (IntPtr jnienv, IntPtr native__this, int imageIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetImage (imageIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='getImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getImage", "(I)Lcom/morpho/morphosmart/sdk/MorphoImage;", "GetGetImage_IHandler")]
		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoImage GetImage (int imageIndex)
		{
			const string __id = "getImage.(I)Lcom/morpho/morphosmart/sdk/MorphoImage;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (imageIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTemplate_I;
#pragma warning disable 0169
		static Delegate GetGetTemplate_IHandler ()
		{
			if (cb_getTemplate_I == null)
				cb_getTemplate_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTemplate_I);
			return cb_getTemplate_I;
		}

		static IntPtr n_GetTemplate_I (IntPtr jnienv, IntPtr native__this, int templateIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTemplate (templateIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='getTemplate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTemplate", "(I)Lcom/morpho/morphosmart/sdk/Template;", "GetGetTemplate_IHandler")]
		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.Template GetTemplate (int templateIndex)
		{
			const string __id = "getTemplate.(I)Lcom/morpho/morphosmart/sdk/Template;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (templateIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_;
#pragma warning disable 0169
		static Delegate GetPutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Handler ()
		{
			if (cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_ == null)
				cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_);
			return cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_;
		}

		static void n_PutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateFVP)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateFVP templateFVP = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVP> (native_templateFVP, JniHandleOwnership.DoNotTransfer);
			__this.PutFVPTemplate (templateFVP);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='putFVPTemplate' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.TemplateFVP']]"
		[Register ("putFVPTemplate", "(Lcom/morpho/morphosmart/sdk/TemplateFVP;)V", "GetPutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Handler")]
		public virtual unsafe void PutFVPTemplate (global::Com.Morpho.Morphosmart.Sdk.TemplateFVP templateFVP)
		{
			const string __id = "putFVPTemplate.(Lcom/morpho/morphosmart/sdk/TemplateFVP;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((templateFVP == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateFVP).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_;
#pragma warning disable 0169
		static Delegate GetPutTemplate_Lcom_morpho_morphosmart_sdk_Template_Handler ()
		{
			if (cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_ == null)
				cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PutTemplate_Lcom_morpho_morphosmart_sdk_Template_);
			return cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_;
		}

		static void n_PutTemplate_Lcom_morpho_morphosmart_sdk_Template_ (IntPtr jnienv, IntPtr native__this, IntPtr native_template)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Template template = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (native_template, JniHandleOwnership.DoNotTransfer);
			__this.PutTemplate (template);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='putTemplate' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.Template']]"
		[Register ("putTemplate", "(Lcom/morpho/morphosmart/sdk/Template;)V", "GetPutTemplate_Lcom_morpho_morphosmart_sdk_Template_Handler")]
		public virtual unsafe void PutTemplate (global::Com.Morpho.Morphosmart.Sdk.Template template)
		{
			const string __id = "putTemplate.(Lcom/morpho/morphosmart/sdk/Template;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((template == null) ? IntPtr.Zero : ((global::Java.Lang.Object) template).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImage_Lcom_morpho_morphosmart_sdk_MorphoImage_;
#pragma warning disable 0169
		static Delegate GetSetImage_Lcom_morpho_morphosmart_sdk_MorphoImage_Handler ()
		{
			if (cb_setImage_Lcom_morpho_morphosmart_sdk_MorphoImage_ == null)
				cb_setImage_Lcom_morpho_morphosmart_sdk_MorphoImage_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Lcom_morpho_morphosmart_sdk_MorphoImage_);
			return cb_setImage_Lcom_morpho_morphosmart_sdk_MorphoImage_;
		}

		static void n_SetImage_Lcom_morpho_morphosmart_sdk_MorphoImage_ (IntPtr jnienv, IntPtr native__this, IntPtr native_morphoImage)
		{
			global::Com.Morpho.Morphosmart.Sdk.TemplateList __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage morphoImage = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (native_morphoImage, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (morphoImage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='TemplateList']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoImage']]"
		[Register ("setImage", "(Lcom/morpho/morphosmart/sdk/MorphoImage;)V", "GetSetImage_Lcom_morpho_morphosmart_sdk_MorphoImage_Handler")]
		public virtual unsafe void SetImage (global::Com.Morpho.Morphosmart.Sdk.MorphoImage morphoImage)
		{
			const string __id = "setImage.(Lcom/morpho/morphosmart/sdk/MorphoImage;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((morphoImage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoImage).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
