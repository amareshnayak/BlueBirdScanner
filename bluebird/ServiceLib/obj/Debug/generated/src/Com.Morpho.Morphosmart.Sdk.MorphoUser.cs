using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoUser", DoNotGenerateAcw=true)]
	public partial class MorphoUser : global::Java.Lang.Object, global::Java.Lang.ICloneable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/field[@name='cppMemOwn']"
		[Register ("cppMemOwn")]
		protected bool CppMemOwn {
			get {
				const string __id = "cppMemOwn.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "cppMemOwn.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoUser", typeof (MorphoUser));
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

		protected MorphoUser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/constructor[@name='MorphoUser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoUser ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/constructor[@name='MorphoUser' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Register (".ctor", "(Lcom/morpho/morphosmart/sdk/MorphoUser;)V", "")]
		public unsafe MorphoUser (global::Com.Morpho.Morphosmart.Sdk.MorphoUser user)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/morpho/morphosmart/sdk/MorphoUser;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/constructor[@name='MorphoUser' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe MorphoUser (string userID)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_userID = JNIEnv.NewString (userID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_userID);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_userID);
			}
		}

		static Delegate cb_getEnrollmentType;
#pragma warning disable 0169
		static Delegate GetGetEnrollmentTypeHandler ()
		{
			if (cb_getEnrollmentType == null)
				cb_getEnrollmentType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEnrollmentType);
			return cb_getEnrollmentType;
		}

		static int n_GetEnrollmentType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EnrollmentType;
		}
#pragma warning restore 0169

		public virtual unsafe int EnrollmentType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getEnrollmentType' and count(parameter)=0]"
			[Register ("getEnrollmentType", "()I", "GetGetEnrollmentTypeHandler")]
			get {
				const string __id = "getEnrollmentType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMorphoUserPointerCPP;
#pragma warning disable 0169
		static Delegate GetGetMorphoUserPointerCPPHandler ()
		{
			if (cb_getMorphoUserPointerCPP == null)
				cb_getMorphoUserPointerCPP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMorphoUserPointerCPP);
			return cb_getMorphoUserPointerCPP;
		}

		static long n_GetMorphoUserPointerCPP (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MorphoUserPointerCPP;
		}
#pragma warning restore 0169

		static Delegate cb_setMorphoUserPointerCPP_J;
#pragma warning disable 0169
		static Delegate GetSetMorphoUserPointerCPP_JHandler ()
		{
			if (cb_setMorphoUserPointerCPP_J == null)
				cb_setMorphoUserPointerCPP_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMorphoUserPointerCPP_J);
			return cb_setMorphoUserPointerCPP_J;
		}

		static void n_SetMorphoUserPointerCPP_J (IntPtr jnienv, IntPtr native__this, long morphoUserPointerCPP)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MorphoUserPointerCPP = morphoUserPointerCPP;
		}
#pragma warning restore 0169

		public virtual unsafe long MorphoUserPointerCPP {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getMorphoUserPointerCPP' and count(parameter)=0]"
			[Register ("getMorphoUserPointerCPP", "()J", "GetGetMorphoUserPointerCPPHandler")]
			get {
				const string __id = "getMorphoUserPointerCPP.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='setMorphoUserPointerCPP' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMorphoUserPointerCPP", "(J)V", "GetSetMorphoUserPointerCPP_JHandler")]
			set {
				const string __id = "setMorphoUserPointerCPP.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUserID;
#pragma warning disable 0169
		static Delegate GetGetUserIDHandler ()
		{
			if (cb_getUserID == null)
				cb_getUserID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetUserID);
			return cb_getUserID;
		}

		static IntPtr n_GetUserID (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UserID);
		}
#pragma warning restore 0169

		public virtual unsafe string UserID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getUserID' and count(parameter)=0]"
			[Register ("getUserID", "()Ljava/lang/String;", "GetGetUserIDHandler")]
			get {
				const string __id = "getUserID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_cancelLiveAcquisition;
#pragma warning disable 0169
		static Delegate GetCancelLiveAcquisitionHandler ()
		{
			if (cb_cancelLiveAcquisition == null)
				cb_cancelLiveAcquisition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_CancelLiveAcquisition);
			return cb_cancelLiveAcquisition;
		}

		static int n_CancelLiveAcquisition (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CancelLiveAcquisition ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='cancelLiveAcquisition' and count(parameter)=0]"
		[Register ("cancelLiveAcquisition", "()I", "GetCancelLiveAcquisitionHandler")]
		public virtual unsafe int CancelLiveAcquisition ()
		{
			const string __id = "cancelLiveAcquisition.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Ljava/lang/Object;", "GetCloneHandler")]
		public virtual unsafe global::Java.Lang.Object Clone ()
		{
			const string __id = "clone.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dbDelete;
#pragma warning disable 0169
		static Delegate GetDbDeleteHandler ()
		{
			if (cb_dbDelete == null)
				cb_dbDelete = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DbDelete);
			return cb_dbDelete;
		}

		static int n_DbDelete (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DbDelete ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='dbDelete' and count(parameter)=0]"
		[Register ("dbDelete", "()I", "GetDbDeleteHandler")]
		public virtual unsafe int DbDelete ()
		{
			const string __id = "dbDelete.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbStore;
#pragma warning disable 0169
		static Delegate GetDbStoreHandler ()
		{
			if (cb_dbStore == null)
				cb_dbStore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DbStore);
			return cb_dbStore;
		}

		static int n_DbStore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DbStore ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='dbStore' and count(parameter)=0]"
		[Register ("dbStore", "()I", "GetDbStoreHandler")]
		public virtual unsafe int DbStore ()
		{
			const string __id = "dbStore.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbUpdatePublicFields;
#pragma warning disable 0169
		static Delegate GetDbUpdatePublicFieldsHandler ()
		{
			if (cb_dbUpdatePublicFields == null)
				cb_dbUpdatePublicFields = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DbUpdatePublicFields);
			return cb_dbUpdatePublicFields;
		}

		static int n_DbUpdatePublicFields (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DbUpdatePublicFields ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='dbUpdatePublicFields' and count(parameter)=0]"
		[Register ("dbUpdatePublicFields", "()I", "GetDbUpdatePublicFieldsHandler")]
		public virtual unsafe int DbUpdatePublicFields ()
		{
			const string __id = "dbUpdatePublicFields.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_;
#pragma warning disable 0169
		static Delegate GetDbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Handler ()
		{
			if (cb_dbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_ == null)
				cb_dbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, IntPtr, int, IntPtr, int>) n_DbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_);
			return cb_dbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_;
		}

		static int n_DbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_ (IntPtr jnienv, IntPtr native__this, int timeout, int far, IntPtr native_coder, int detectModeChoice, IntPtr native_matchingStrategy, int callbackCmd, IntPtr native__callback)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Coder coder = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (native_coder, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (native_matchingStrategy, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbVerifyAndUpdate (timeout, far, coder, detectModeChoice, matchingStrategy, callbackCmd, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='dbVerifyAndUpdate' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.Coder'] and parameter[4][@type='int'] and parameter[5][@type='com.morpho.morphosmart.sdk.MatchingStrategy'] and parameter[6][@type='int'] and parameter[7][@type='java.util.Observer']]"
		[Register ("dbVerifyAndUpdate", "(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;)I", "GetDbVerifyAndUpdate_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Handler")]
		public virtual unsafe int DbVerifyAndUpdate (int timeout, int far, global::Com.Morpho.Morphosmart.Sdk.Coder coder, int detectModeChoice, global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy, int callbackCmd, global::Java.Util.IObserver @callback)
		{
			const string __id = "dbVerifyAndUpdate.(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue (far);
				__args [2] = new JniArgumentValue ((coder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coder).Handle);
				__args [3] = new JniArgumentValue (detectModeChoice);
				__args [4] = new JniArgumentValue ((matchingStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchingStrategy).Handle);
				__args [5] = new JniArgumentValue (callbackCmd);
				__args [6] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getBufferField_I;
#pragma warning disable 0169
		static Delegate GetGetBufferField_IHandler ()
		{
			if (cb_getBufferField_I == null)
				cb_getBufferField_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetBufferField_I);
			return cb_getBufferField_I;
		}

		static IntPtr n_GetBufferField_I (IntPtr jnienv, IntPtr native__this, int fieldIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBufferField (fieldIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getBufferField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getBufferField", "(I)[B", "GetGetBufferField_IHandler")]
		public virtual unsafe byte[] GetBufferField (int fieldIndex)
		{
			const string __id = "getBufferField.(I)[B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fieldIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_;
#pragma warning disable 0169
		static Delegate GetGetFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_Handler ()
		{
			if (cb_getFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_ == null)
				cb_getFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_);
			return cb_getFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_;
		}

		static int n_GetFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_ (IntPtr jnienv, IntPtr native__this, int templateIndex, IntPtr native_templateFVP)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateFVP templateFVP = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVP> (native_templateFVP, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetFVPTemplate (templateIndex, templateFVP);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getFVPTemplate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.TemplateFVP']]"
		[Register ("getFVPTemplate", "(ILcom/morpho/morphosmart/sdk/TemplateFVP;)I", "GetGetFVPTemplate_ILcom_morpho_morphosmart_sdk_TemplateFVP_Handler")]
		public virtual unsafe int GetFVPTemplate (int templateIndex, global::Com.Morpho.Morphosmart.Sdk.TemplateFVP templateFVP)
		{
			const string __id = "getFVPTemplate.(ILcom/morpho/morphosmart/sdk/TemplateFVP;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (templateIndex);
				__args [1] = new JniArgumentValue ((templateFVP == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateFVP).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getField_I;
#pragma warning disable 0169
		static Delegate GetGetField_IHandler ()
		{
			if (cb_getField_I == null)
				cb_getField_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetField_I);
			return cb_getField_I;
		}

		static IntPtr n_GetField_I (IntPtr jnienv, IntPtr native__this, int fieldIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetField (fieldIndex));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getField' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getField", "(I)Ljava/lang/String;", "GetGetField_IHandler")]
		public virtual unsafe string GetField (int fieldIndex)
		{
			const string __id = "getField.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fieldIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getNbTemplate_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetNbTemplate_Ljava_lang_Integer_Handler ()
		{
			if (cb_getNbTemplate_Ljava_lang_Integer_ == null)
				cb_getNbTemplate_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbTemplate_Ljava_lang_Integer_);
			return cb_getNbTemplate_Ljava_lang_Integer_;
		}

		static int n_GetNbTemplate_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbTemplate)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer nbTemplate = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_nbTemplate, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbTemplate (nbTemplate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getNbTemplate' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getNbTemplate", "(Ljava/lang/Integer;)I", "GetGetNbTemplate_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetNbTemplate (global::Java.Lang.Integer nbTemplate)
		{
			const string __id = "getNbTemplate.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbTemplate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbTemplate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNbTemplateFVP_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetNbTemplateFVP_Ljava_lang_Integer_Handler ()
		{
			if (cb_getNbTemplateFVP_Ljava_lang_Integer_ == null)
				cb_getNbTemplateFVP_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbTemplateFVP_Ljava_lang_Integer_);
			return cb_getNbTemplateFVP_Ljava_lang_Integer_;
		}

		static int n_GetNbTemplateFVP_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbTemplateFVP)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer nbTemplateFVP = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_nbTemplateFVP, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbTemplateFVP (nbTemplateFVP);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getNbTemplateFVP' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getNbTemplateFVP", "(Ljava/lang/Integer;)I", "GetGetNbTemplateFVP_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetNbTemplateFVP (global::Java.Lang.Integer nbTemplateFVP)
		{
			const string __id = "getNbTemplateFVP.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbTemplateFVP == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbTemplateFVP).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getTemplate_ILcom_morpho_morphosmart_sdk_Template_;
#pragma warning disable 0169
		static Delegate GetGetTemplate_ILcom_morpho_morphosmart_sdk_Template_Handler ()
		{
			if (cb_getTemplate_ILcom_morpho_morphosmart_sdk_Template_ == null)
				cb_getTemplate_ILcom_morpho_morphosmart_sdk_Template_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetTemplate_ILcom_morpho_morphosmart_sdk_Template_);
			return cb_getTemplate_ILcom_morpho_morphosmart_sdk_Template_;
		}

		static int n_GetTemplate_ILcom_morpho_morphosmart_sdk_Template_ (IntPtr jnienv, IntPtr native__this, int templateIndex, IntPtr native_template)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Template template = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (native_template, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetTemplate (templateIndex, template);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getTemplate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.Template']]"
		[Register ("getTemplate", "(ILcom/morpho/morphosmart/sdk/Template;)I", "GetGetTemplate_ILcom_morpho_morphosmart_sdk_Template_Handler")]
		public virtual unsafe int GetTemplate (int templateIndex, global::Com.Morpho.Morphosmart.Sdk.Template template)
		{
			const string __id = "getTemplate.(ILcom/morpho/morphosmart/sdk/Template;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (templateIndex);
				__args [1] = new JniArgumentValue ((template == null) ? IntPtr.Zero : ((global::Java.Lang.Object) template).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_;
#pragma warning disable 0169
		static Delegate GetGetUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_Handler ()
		{
			if (cb_getUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_ == null)
				cb_getUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int, long, IntPtr, IntPtr, int>) n_GetUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_);
			return cb_getUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_;
		}

		static int n_GetUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_ (IntPtr jnienv, IntPtr native__this, int indexDB, IntPtr native_userID, int userIdSize, long userIndex, IntPtr native_templateQuality, IntPtr native_fingerNumber)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string userID = JNIEnv.GetString (native_userID, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateQuality templateQuality = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateQuality> (native_templateQuality, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.FingerNumber fingerNumber = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.FingerNumber> (native_fingerNumber, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUserTemplateQuality (indexDB, userID, userIdSize, userIndex, templateQuality, fingerNumber);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='getUserTemplateQuality' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='com.morpho.morphosmart.sdk.TemplateQuality'] and parameter[6][@type='com.morpho.morphosmart.sdk.FingerNumber']]"
		[Register ("getUserTemplateQuality", "(ILjava/lang/String;IJLcom/morpho/morphosmart/sdk/TemplateQuality;Lcom/morpho/morphosmart/sdk/FingerNumber;)I", "GetGetUserTemplateQuality_ILjava_lang_String_IJLcom_morpho_morphosmart_sdk_TemplateQuality_Lcom_morpho_morphosmart_sdk_FingerNumber_Handler")]
		public virtual unsafe int GetUserTemplateQuality (int indexDB, string userID, int userIdSize, long userIndex, global::Com.Morpho.Morphosmart.Sdk.TemplateQuality templateQuality, global::Com.Morpho.Morphosmart.Sdk.FingerNumber fingerNumber)
		{
			const string __id = "getUserTemplateQuality.(ILjava/lang/String;IJLcom/morpho/morphosmart/sdk/TemplateQuality;Lcom/morpho/morphosmart/sdk/FingerNumber;)I";
			IntPtr native_userID = JNIEnv.NewString (userID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (indexDB);
				__args [1] = new JniArgumentValue (native_userID);
				__args [2] = new JniArgumentValue (userIdSize);
				__args [3] = new JniArgumentValue (userIndex);
				__args [4] = new JniArgumentValue ((templateQuality == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateQuality).Handle);
				__args [5] = new JniArgumentValue ((fingerNumber == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fingerNumber).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_userID);
			}
		}

		static Delegate cb_putBufferField_IarrayB;
#pragma warning disable 0169
		static Delegate GetPutBufferField_IarrayBHandler ()
		{
			if (cb_putBufferField_IarrayB == null)
				cb_putBufferField_IarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_PutBufferField_IarrayB);
			return cb_putBufferField_IarrayB;
		}

		static int n_PutBufferField_IarrayB (IntPtr jnienv, IntPtr native__this, int fieldIndex, IntPtr native_fieldData)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] fieldData = (byte[]) JNIEnv.GetArray (native_fieldData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.PutBufferField (fieldIndex, fieldData);
			if (fieldData != null)
				JNIEnv.CopyArray (fieldData, native_fieldData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='putBufferField' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("putBufferField", "(I[B)I", "GetPutBufferField_IarrayBHandler")]
		public virtual unsafe int PutBufferField (int fieldIndex, byte[] fieldData)
		{
			const string __id = "putBufferField.(I[B)I";
			IntPtr native_fieldData = JNIEnv.NewArray (fieldData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fieldIndex);
				__args [1] = new JniArgumentValue (native_fieldData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (fieldData != null) {
					JNIEnv.CopyArray (native_fieldData, fieldData);
					JNIEnv.DeleteLocalRef (native_fieldData);
				}
			}
		}

		static Delegate cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_Handler ()
		{
			if (cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_ == null)
				cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_PutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_);
			return cb_putFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_;
		}

		static int n_PutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateFVP, IntPtr native_templateFVPIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateFVP templateFVP = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateFVP> (native_templateFVP, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer templateFVPIndex = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_templateFVPIndex, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutFVPTemplate (templateFVP, templateFVPIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='putFVPTemplate' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.sdk.TemplateFVP'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("putFVPTemplate", "(Lcom/morpho/morphosmart/sdk/TemplateFVP;Ljava/lang/Integer;)I", "GetPutFVPTemplate_Lcom_morpho_morphosmart_sdk_TemplateFVP_Ljava_lang_Integer_Handler")]
		public virtual unsafe int PutFVPTemplate (global::Com.Morpho.Morphosmart.Sdk.TemplateFVP templateFVP, global::Java.Lang.Integer templateFVPIndex)
		{
			const string __id = "putFVPTemplate.(Lcom/morpho/morphosmart/sdk/TemplateFVP;Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((templateFVP == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateFVP).Handle);
				__args [1] = new JniArgumentValue ((templateFVPIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateFVPIndex).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_putField_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPutField_ILjava_lang_String_Handler ()
		{
			if (cb_putField_ILjava_lang_String_ == null)
				cb_putField_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_PutField_ILjava_lang_String_);
			return cb_putField_ILjava_lang_String_;
		}

		static int n_PutField_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int fieldIndex, IntPtr native_fieldData)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fieldData = JNIEnv.GetString (native_fieldData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutField (fieldIndex, fieldData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='putField' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("putField", "(ILjava/lang/String;)I", "GetPutField_ILjava_lang_String_Handler")]
		public virtual unsafe int PutField (int fieldIndex, string fieldData)
		{
			const string __id = "putField.(ILjava/lang/String;)I";
			IntPtr native_fieldData = JNIEnv.NewString (fieldData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fieldIndex);
				__args [1] = new JniArgumentValue (native_fieldData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fieldData);
			}
		}

		static Delegate cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPutTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_Handler ()
		{
			if (cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_ == null)
				cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_PutTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_);
			return cb_putTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_;
		}

		static int n_PutTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_template, IntPtr native_templateIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Template template = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Template> (native_template, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer templateIndex = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_templateIndex, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutTemplate (template, templateIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='putTemplate' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.sdk.Template'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("putTemplate", "(Lcom/morpho/morphosmart/sdk/Template;Ljava/lang/Integer;)I", "GetPutTemplate_Lcom_morpho_morphosmart_sdk_Template_Ljava_lang_Integer_Handler")]
		public virtual unsafe int PutTemplate (global::Com.Morpho.Morphosmart.Sdk.Template template, global::Java.Lang.Integer templateIndex)
		{
			const string __id = "putTemplate.(Lcom/morpho/morphosmart/sdk/Template;Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((template == null) ? IntPtr.Zero : ((global::Java.Lang.Object) template).Handle);
				__args [1] = new JniArgumentValue ((templateIndex == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateIndex).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_;
#pragma warning disable 0169
		static Delegate GetSetEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_Handler ()
		{
			if (cb_setEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_ == null)
				cb_setEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_);
			return cb_setEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_;
		}

		static int n_SetEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_enrollmentType)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.EnrollmentType enrollmentType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.EnrollmentType> (native_enrollmentType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetEnrollmentType (enrollmentType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='setEnrollmentType' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.EnrollmentType']]"
		[Register ("setEnrollmentType", "(Lcom/morpho/morphosmart/sdk/EnrollmentType;)I", "GetSetEnrollmentType_Lcom_morpho_morphosmart_sdk_EnrollmentType_Handler")]
		public virtual unsafe int SetEnrollmentType (global::Com.Morpho.Morphosmart.Sdk.EnrollmentType enrollmentType)
		{
			const string __id = "setEnrollmentType.(Lcom/morpho/morphosmart/sdk/EnrollmentType;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((enrollmentType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) enrollmentType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setNoCheckOnTemplateForDBStore_Z;
#pragma warning disable 0169
		static Delegate GetSetNoCheckOnTemplateForDBStore_ZHandler ()
		{
			if (cb_setNoCheckOnTemplateForDBStore_Z == null)
				cb_setNoCheckOnTemplateForDBStore_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, int>) n_SetNoCheckOnTemplateForDBStore_Z);
			return cb_setNoCheckOnTemplateForDBStore_Z;
		}

		static int n_SetNoCheckOnTemplateForDBStore_Z (IntPtr jnienv, IntPtr native__this, bool noCheckOnTemplate)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetNoCheckOnTemplateForDBStore (noCheckOnTemplate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='setNoCheckOnTemplateForDBStore' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNoCheckOnTemplateForDBStore", "(Z)I", "GetSetNoCheckOnTemplateForDBStore_ZHandler")]
		public virtual unsafe int SetNoCheckOnTemplateForDBStore (bool noCheckOnTemplate)
		{
			const string __id = "setNoCheckOnTemplateForDBStore.(Z)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (noCheckOnTemplate);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setTemplateUpdateMask_arrayZ;
#pragma warning disable 0169
		static Delegate GetSetTemplateUpdateMask_arrayZHandler ()
		{
			if (cb_setTemplateUpdateMask_arrayZ == null)
				cb_setTemplateUpdateMask_arrayZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetTemplateUpdateMask_arrayZ);
			return cb_setTemplateUpdateMask_arrayZ;
		}

		static int n_SetTemplateUpdateMask_arrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_fingerprintUpdateMask)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			bool[] fingerprintUpdateMask = (bool[]) JNIEnv.GetArray (native_fingerprintUpdateMask, JniHandleOwnership.DoNotTransfer, typeof (bool));
			int __ret = __this.SetTemplateUpdateMask (fingerprintUpdateMask);
			if (fingerprintUpdateMask != null)
				JNIEnv.CopyArray (fingerprintUpdateMask, native_fingerprintUpdateMask);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='setTemplateUpdateMask' and count(parameter)=1 and parameter[1][@type='boolean[]']]"
		[Register ("setTemplateUpdateMask", "([Z)I", "GetSetTemplateUpdateMask_arrayZHandler")]
		public virtual unsafe int SetTemplateUpdateMask (bool[] fingerprintUpdateMask)
		{
			const string __id = "setTemplateUpdateMask.([Z)I";
			IntPtr native_fingerprintUpdateMask = JNIEnv.NewArray (fingerprintUpdateMask);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fingerprintUpdateMask);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (fingerprintUpdateMask != null) {
					JNIEnv.CopyArray (native_fingerprintUpdateMask, fingerprintUpdateMask);
					JNIEnv.DeleteLocalRef (native_fingerprintUpdateMask);
				}
			}
		}

		static Delegate cb_verify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_;
#pragma warning disable 0169
		static Delegate GetVerify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Handler ()
		{
			if (cb_verify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ == null)
				cb_verify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, IntPtr, int, IntPtr, IntPtr, int>) n_Verify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_);
			return cb_verify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_;
		}

		static int n_Verify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ (IntPtr jnienv, IntPtr native__this, int timeout, int far, IntPtr native_coder, int detectModeChoice, IntPtr native_matchingStrategy, int callbackCmd, IntPtr native__callback, IntPtr native_resultMatching)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Coder coder = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (native_coder, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (native_matchingStrategy, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (native_resultMatching, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Verify (timeout, far, coder, detectModeChoice, matchingStrategy, callbackCmd, @callback, resultMatching);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoUser']/method[@name='verify' and count(parameter)=8 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.Coder'] and parameter[4][@type='int'] and parameter[5][@type='com.morpho.morphosmart.sdk.MatchingStrategy'] and parameter[6][@type='int'] and parameter[7][@type='java.util.Observer'] and parameter[8][@type='com.morpho.morphosmart.sdk.ResultMatching']]"
		[Register ("verify", "(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;)I", "GetVerify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Handler")]
		public virtual unsafe int Verify (int timeout, int far, global::Com.Morpho.Morphosmart.Sdk.Coder coder, int detectModeChoice, global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy, int callbackCmd, global::Java.Util.IObserver @callback, global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching)
		{
			const string __id = "verify.(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue (far);
				__args [2] = new JniArgumentValue ((coder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coder).Handle);
				__args [3] = new JniArgumentValue (detectModeChoice);
				__args [4] = new JniArgumentValue ((matchingStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchingStrategy).Handle);
				__args [5] = new JniArgumentValue (callbackCmd);
				__args [6] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [7] = new JniArgumentValue ((resultMatching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultMatching).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
