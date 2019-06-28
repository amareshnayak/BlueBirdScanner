using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/SecuConfig", DoNotGenerateAcw=true)]
	public partial class SecuConfig : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/SecuConfig", typeof (SecuConfig));
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

		protected SecuConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/constructor[@name='SecuConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SecuConfig ()
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

		static Delegate cb_isAcceptsOnlySignedTemplates;
#pragma warning disable 0169
		static Delegate GetIsAcceptsOnlySignedTemplatesHandler ()
		{
			if (cb_isAcceptsOnlySignedTemplates == null)
				cb_isAcceptsOnlySignedTemplates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAcceptsOnlySignedTemplates);
			return cb_isAcceptsOnlySignedTemplates;
		}

		static bool n_IsAcceptsOnlySignedTemplates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAcceptsOnlySignedTemplates;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAcceptsOnlySignedTemplates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='isAcceptsOnlySignedTemplates' and count(parameter)=0]"
			[Register ("isAcceptsOnlySignedTemplates", "()Z", "GetIsAcceptsOnlySignedTemplatesHandler")]
			get {
				const string __id = "isAcceptsOnlySignedTemplates.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDownloadIsProtected;
#pragma warning disable 0169
		static Delegate GetIsDownloadIsProtectedHandler ()
		{
			if (cb_isDownloadIsProtected == null)
				cb_isDownloadIsProtected = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDownloadIsProtected);
			return cb_isDownloadIsProtected;
		}

		static bool n_IsDownloadIsProtected (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDownloadIsProtected;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDownloadIsProtected {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='isDownloadIsProtected' and count(parameter)=0]"
			[Register ("isDownloadIsProtected", "()Z", "GetIsDownloadIsProtectedHandler")]
			get {
				const string __id = "isDownloadIsProtected.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isExportScore;
#pragma warning disable 0169
		static Delegate GetIsExportScoreHandler ()
		{
			if (cb_isExportScore == null)
				cb_isExportScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExportScore);
			return cb_isExportScore;
		}

		static bool n_IsExportScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExportScore;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsExportScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='isExportScore' and count(parameter)=0]"
			[Register ("isExportScore", "()Z", "GetIsExportScoreHandler")]
			get {
				const string __id = "isExportScore.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isModeOfferedSecurity;
#pragma warning disable 0169
		static Delegate GetIsModeOfferedSecurityHandler ()
		{
			if (cb_isModeOfferedSecurity == null)
				cb_isModeOfferedSecurity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsModeOfferedSecurity);
			return cb_isModeOfferedSecurity;
		}

		static bool n_IsModeOfferedSecurity (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsModeOfferedSecurity;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsModeOfferedSecurity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='isModeOfferedSecurity' and count(parameter)=0]"
			[Register ("isModeOfferedSecurity", "()Z", "GetIsModeOfferedSecurityHandler")]
			get {
				const string __id = "isModeOfferedSecurity.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isModeTunneling;
#pragma warning disable 0169
		static Delegate GetIsModeTunnelingHandler ()
		{
			if (cb_isModeTunneling == null)
				cb_isModeTunneling = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsModeTunneling);
			return cb_isModeTunneling;
		}

		static bool n_IsModeTunneling (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsModeTunneling;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsModeTunneling {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='isModeTunneling' and count(parameter)=0]"
			[Register ("isModeTunneling", "()Z", "GetIsModeTunnelingHandler")]
			get {
				const string __id = "isModeTunneling.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinMultimodalSecurityLevel;
#pragma warning disable 0169
		static Delegate GetGetMinMultimodalSecurityLevelHandler ()
		{
			if (cb_getMinMultimodalSecurityLevel == null)
				cb_getMinMultimodalSecurityLevel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMinMultimodalSecurityLevel);
			return cb_getMinMultimodalSecurityLevel;
		}

		static int n_GetMinMultimodalSecurityLevel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinMultimodalSecurityLevel;
		}
#pragma warning restore 0169

		static Delegate cb_setMinMultimodalSecurityLevel_I;
#pragma warning disable 0169
		static Delegate GetSetMinMultimodalSecurityLevel_IHandler ()
		{
			if (cb_setMinMultimodalSecurityLevel_I == null)
				cb_setMinMultimodalSecurityLevel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMinMultimodalSecurityLevel_I);
			return cb_setMinMultimodalSecurityLevel_I;
		}

		static void n_SetMinMultimodalSecurityLevel_I (IntPtr jnienv, IntPtr native__this, int minMultimodalSecurityLevel)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinMultimodalSecurityLevel = minMultimodalSecurityLevel;
		}
#pragma warning restore 0169

		public virtual unsafe int MinMultimodalSecurityLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='getMinMultimodalSecurityLevel' and count(parameter)=0]"
			[Register ("getMinMultimodalSecurityLevel", "()I", "GetGetMinMultimodalSecurityLevelHandler")]
			get {
				const string __id = "getMinMultimodalSecurityLevel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='setMinMultimodalSecurityLevel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMinMultimodalSecurityLevel", "(I)V", "GetSetMinMultimodalSecurityLevel_IHandler")]
			set {
				const string __id = "setMinMultimodalSecurityLevel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecurityFAR;
#pragma warning disable 0169
		static Delegate GetGetSecurityFARHandler ()
		{
			if (cb_getSecurityFAR == null)
				cb_getSecurityFAR = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSecurityFAR);
			return cb_getSecurityFAR;
		}

		static int n_GetSecurityFAR (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecurityFAR;
		}
#pragma warning restore 0169

		static Delegate cb_setSecurityFAR_I;
#pragma warning disable 0169
		static Delegate GetSetSecurityFAR_IHandler ()
		{
			if (cb_setSecurityFAR_I == null)
				cb_setSecurityFAR_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSecurityFAR_I);
			return cb_setSecurityFAR_I;
		}

		static void n_SetSecurityFAR_I (IntPtr jnienv, IntPtr native__this, int securityFAR)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SecurityFAR = securityFAR;
		}
#pragma warning restore 0169

		public virtual unsafe int SecurityFAR {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='getSecurityFAR' and count(parameter)=0]"
			[Register ("getSecurityFAR", "()I", "GetGetSecurityFARHandler")]
			get {
				const string __id = "getSecurityFAR.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='setSecurityFAR' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSecurityFAR", "(I)V", "GetSetSecurityFAR_IHandler")]
			set {
				const string __id = "setSecurityFAR.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecurityFARDescription;
#pragma warning disable 0169
		static Delegate GetGetSecurityFARDescriptionHandler ()
		{
			if (cb_getSecurityFARDescription == null)
				cb_getSecurityFARDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSecurityFARDescription);
			return cb_getSecurityFARDescription;
		}

		static IntPtr n_GetSecurityFARDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecurityFARDescription);
		}
#pragma warning restore 0169

		public virtual unsafe string SecurityFARDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='getSecurityFARDescription' and count(parameter)=0]"
			[Register ("getSecurityFARDescription", "()Ljava/lang/String;", "GetGetSecurityFARDescriptionHandler")]
			get {
				const string __id = "getSecurityFARDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecurityOptions;
#pragma warning disable 0169
		static Delegate GetGetSecurityOptionsHandler ()
		{
			if (cb_getSecurityOptions == null)
				cb_getSecurityOptions = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, char>) n_GetSecurityOptions);
			return cb_getSecurityOptions;
		}

		static char n_GetSecurityOptions (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecurityOptions;
		}
#pragma warning restore 0169

		static Delegate cb_setSecurityOptions_C;
#pragma warning disable 0169
		static Delegate GetSetSecurityOptions_CHandler ()
		{
			if (cb_setSecurityOptions_C == null)
				cb_setSecurityOptions_C = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, char>) n_SetSecurityOptions_C);
			return cb_setSecurityOptions_C;
		}

		static void n_SetSecurityOptions_C (IntPtr jnienv, IntPtr native__this, char securityOptions)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SecurityOptions = securityOptions;
		}
#pragma warning restore 0169

		public virtual unsafe char SecurityOptions {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='getSecurityOptions' and count(parameter)=0]"
			[Register ("getSecurityOptions", "()C", "GetGetSecurityOptionsHandler")]
			get {
				const string __id = "getSecurityOptions.()C";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualCharMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='setSecurityOptions' and count(parameter)=1 and parameter[1][@type='char']]"
			[Register ("setSecurityOptions", "(C)V", "GetSetSecurityOptions_CHandler")]
			set {
				const string __id = "setSecurityOptions.(C)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetSerialNumberHandler ()
		{
			if (cb_getSerialNumber == null)
				cb_getSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSerialNumber);
			return cb_getSerialNumber;
		}

		static IntPtr n_GetSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SerialNumber);
		}
#pragma warning restore 0169

		static Delegate cb_setSerialNumber_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSerialNumber_Ljava_lang_String_Handler ()
		{
			if (cb_setSerialNumber_Ljava_lang_String_ == null)
				cb_setSerialNumber_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSerialNumber_Ljava_lang_String_);
			return cb_setSerialNumber_Ljava_lang_String_;
		}

		static void n_SetSerialNumber_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serialNumber)
		{
			global::Com.Morpho.Morphosmart.Sdk.SecuConfig __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.SecuConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string serialNumber = JNIEnv.GetString (native_serialNumber, JniHandleOwnership.DoNotTransfer);
			__this.SerialNumber = serialNumber;
		}
#pragma warning restore 0169

		public virtual unsafe string SerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='getSerialNumber' and count(parameter)=0]"
			[Register ("getSerialNumber", "()Ljava/lang/String;", "GetGetSerialNumberHandler")]
			get {
				const string __id = "getSerialNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='SecuConfig']/method[@name='setSerialNumber' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSerialNumber", "(Ljava/lang/String;)V", "GetSetSerialNumber_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSerialNumber.(Ljava/lang/String;)V";
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
