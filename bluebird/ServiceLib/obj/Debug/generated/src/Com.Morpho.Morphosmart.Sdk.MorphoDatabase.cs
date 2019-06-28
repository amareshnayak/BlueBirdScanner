using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoDatabase", DoNotGenerateAcw=true)]
	public partial class MorphoDatabase : global::Java.Lang.Object, global::Java.Lang.ICloneable {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/field[@name='MORPHO_FINGER_MAX']"
		[Register ("MORPHO_FINGER_MAX")]
		public const int MorphoFingerMax = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/field[@name='MORPHO_LEN_FIELD_MAX']"
		[Register ("MORPHO_LEN_FIELD_MAX")]
		public const int MorphoLenFieldMax = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/field[@name='MORPHO_NB_DATABASE_MAX']"
		[Register ("MORPHO_NB_DATABASE_MAX")]
		public const int MorphoNbDatabaseMax = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/field[@name='MORPHO_NB_FIELD_MAX']"
		[Register ("MORPHO_NB_FIELD_MAX")]
		public const int MorphoNbFieldMax = (int) 20;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/field[@name='MORPHO_NB_RECORD_MIN']"
		[Register ("MORPHO_NB_RECORD_MIN")]
		public const int MorphoNbRecordMin = (int) 1;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/field[@name='cppMemOwn']"
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
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoDatabase", typeof (MorphoDatabase));
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

		protected MorphoDatabase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/constructor[@name='MorphoDatabase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoDatabase ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/constructor[@name='MorphoDatabase' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoDatabase']]"
		[Register (".ctor", "(Lcom/morpho/morphosmart/sdk/MorphoDatabase;)V", "")]
		public unsafe MorphoDatabase (global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase database)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/morpho/morphosmart/sdk/MorphoDatabase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((database == null) ? IntPtr.Zero : ((global::Java.Lang.Object) database).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMorphoDatabasePointerCPP;
#pragma warning disable 0169
		static Delegate GetGetMorphoDatabasePointerCPPHandler ()
		{
			if (cb_getMorphoDatabasePointerCPP == null)
				cb_getMorphoDatabasePointerCPP = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetMorphoDatabasePointerCPP);
			return cb_getMorphoDatabasePointerCPP;
		}

		static long n_GetMorphoDatabasePointerCPP (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MorphoDatabasePointerCPP;
		}
#pragma warning restore 0169

		static Delegate cb_setMorphoDatabasePointerCPP_J;
#pragma warning disable 0169
		static Delegate GetSetMorphoDatabasePointerCPP_JHandler ()
		{
			if (cb_setMorphoDatabasePointerCPP_J == null)
				cb_setMorphoDatabasePointerCPP_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_SetMorphoDatabasePointerCPP_J);
			return cb_setMorphoDatabasePointerCPP_J;
		}

		static void n_SetMorphoDatabasePointerCPP_J (IntPtr jnienv, IntPtr native__this, long morphoDatabasePointerCPP)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MorphoDatabasePointerCPP = morphoDatabasePointerCPP;
		}
#pragma warning restore 0169

		public virtual unsafe long MorphoDatabasePointerCPP {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getMorphoDatabasePointerCPP' and count(parameter)=0]"
			[Register ("getMorphoDatabasePointerCPP", "()J", "GetGetMorphoDatabasePointerCPPHandler")]
			get {
				const string __id = "getMorphoDatabasePointerCPP.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='setMorphoDatabasePointerCPP' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setMorphoDatabasePointerCPP", "(J)V", "GetSetMorphoDatabasePointerCPP_JHandler")]
			set {
				const string __id = "setMorphoDatabasePointerCPP.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CancelLiveAcquisition ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='cancelLiveAcquisition' and count(parameter)=0]"
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
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='clone' and count(parameter)=0]"
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

		static Delegate cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_Handler ()
		{
			if (cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_ == null)
				cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int>) n_DbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_);
			return cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_;
		}

		[Obsolete]
		static int n_DbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_ (IntPtr jnienv, IntPtr native__this, int maxRecord, int maxNbFinger, IntPtr native_templateType)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateType> (native_templateType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbCreate (maxRecord, maxNbFinger, templateType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='dbCreate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.TemplateType']]"
		[Obsolete (@"deprecated")]
		[Register ("dbCreate", "(IILcom/morpho/morphosmart/sdk/TemplateType;)I", "GetDbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_Handler")]
		public virtual unsafe int DbCreate (int maxRecord, int maxNbFinger, global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType)
		{
			const string __id = "dbCreate.(IILcom/morpho/morphosmart/sdk/TemplateType;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (maxRecord);
				__args [1] = new JniArgumentValue (maxNbFinger);
				__args [2] = new JniArgumentValue ((templateType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IHandler ()
		{
			if (cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_I == null)
				cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, int>) n_DbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_I);
			return cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_I;
		}

		[Obsolete]
		static int n_DbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_I (IntPtr jnienv, IntPtr native__this, int maxRecord, int maxNbFinger, IntPtr native_templateType, int dataBaseIndex)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateType> (native_templateType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbCreate (maxRecord, maxNbFinger, templateType, dataBaseIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='dbCreate' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.TemplateType'] and parameter[4][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("dbCreate", "(IILcom/morpho/morphosmart/sdk/TemplateType;I)I", "GetDbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IHandler")]
		public virtual unsafe int DbCreate (int maxRecord, int maxNbFinger, global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType, int dataBaseIndex)
		{
			const string __id = "dbCreate.(IILcom/morpho/morphosmart/sdk/TemplateType;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (maxRecord);
				__args [1] = new JniArgumentValue (maxNbFinger);
				__args [2] = new JniArgumentValue ((templateType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateType).Handle);
				__args [3] = new JniArgumentValue (dataBaseIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZ;
#pragma warning disable 0169
		static Delegate GetDbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZHandler ()
		{
			if (cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZ == null)
				cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, bool, int>) n_DbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZ);
			return cb_dbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZ;
		}

		static int n_DbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZ (IntPtr jnienv, IntPtr native__this, int maxRecord, int maxNbFinger, IntPtr native_templateType, int dataBaseIndex, bool encryptDB)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateType> (native_templateType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbCreate (maxRecord, maxNbFinger, templateType, dataBaseIndex, encryptDB);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='dbCreate' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.TemplateType'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
		[Register ("dbCreate", "(IILcom/morpho/morphosmart/sdk/TemplateType;IZ)I", "GetDbCreate_IILcom_morpho_morphosmart_sdk_TemplateType_IZHandler")]
		public virtual unsafe int DbCreate (int maxRecord, int maxNbFinger, global::Com.Morpho.Morphosmart.Sdk.TemplateType templateType, int dataBaseIndex, bool encryptDB)
		{
			const string __id = "dbCreate.(IILcom/morpho/morphosmart/sdk/TemplateType;IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (maxRecord);
				__args [1] = new JniArgumentValue (maxNbFinger);
				__args [2] = new JniArgumentValue ((templateType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateType).Handle);
				__args [3] = new JniArgumentValue (dataBaseIndex);
				__args [4] = new JniArgumentValue (encryptDB);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_;
#pragma warning disable 0169
		static Delegate GetDbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_Handler ()
		{
			if (cb_dbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_ == null)
				cb_dbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_);
			return cb_dbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_;
		}

		static int n_DbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_ (IntPtr jnienv, IntPtr native__this, IntPtr native_morphoTypeDeletion)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion morphoTypeDeletion = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion> (native_morphoTypeDeletion, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbDelete (morphoTypeDeletion);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='dbDelete' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoTypeDeletion']]"
		[Register ("dbDelete", "(Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;)I", "GetDbDelete_Lcom_morpho_morphosmart_sdk_MorphoTypeDeletion_Handler")]
		public virtual unsafe int DbDelete (global::Com.Morpho.Morphosmart.Sdk.MorphoTypeDeletion morphoTypeDeletion)
		{
			const string __id = "dbDelete.(Lcom/morpho/morphosmart/sdk/MorphoTypeDeletion;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((morphoTypeDeletion == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoTypeDeletion).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_dbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		static Delegate GetDbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_dbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_dbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_DbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_dbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		static int n_DbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, int fieldIndex, IntPtr native_dataToFind, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string dataToFind = JNIEnv.GetString (native_dataToFind, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbQueryFirst (fieldIndex, dataToFind, morphoUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='dbQueryFirst' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Register ("dbQueryFirst", "(ILjava/lang/String;Lcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetDbQueryFirst_ILjava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int DbQueryFirst (int fieldIndex, string dataToFind, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "dbQueryFirst.(ILjava/lang/String;Lcom/morpho/morphosmart/sdk/MorphoUser;)I";
			IntPtr native_dataToFind = JNIEnv.NewString (dataToFind);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (fieldIndex);
				__args [1] = new JniArgumentValue (native_dataToFind);
				__args [2] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_dataToFind);
			}
		}

		static Delegate cb_dbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		static Delegate GetDbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_dbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_dbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_DbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_dbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		static int n_DbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DbQueryNext (morphoUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='dbQueryNext' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Register ("dbQueryNext", "(Lcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetDbQueryNext_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int DbQueryNext (global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "dbQueryNext.(Lcom/morpho/morphosmart/sdk/MorphoUser;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDbEncryptionStatus_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetDbEncryptionStatus_Ljava_lang_Integer_Handler ()
		{
			if (cb_getDbEncryptionStatus_Ljava_lang_Integer_ == null)
				cb_getDbEncryptionStatus_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDbEncryptionStatus_Ljava_lang_Integer_);
			return cb_getDbEncryptionStatus_Ljava_lang_Integer_;
		}

		static int n_GetDbEncryptionStatus_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encryptDB)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer encryptDB = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_encryptDB, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDbEncryptionStatus (encryptDB);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getDbEncryptionStatus' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getDbEncryptionStatus", "(Ljava/lang/Integer;)I", "GetGetDbEncryptionStatus_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetDbEncryptionStatus (global::Java.Lang.Integer encryptDB)
		{
			const string __id = "getDbEncryptionStatus.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((encryptDB == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encryptDB).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getField_ILcom_morpho_morphosmart_sdk_MorphoField_;
#pragma warning disable 0169
		static Delegate GetGetField_ILcom_morpho_morphosmart_sdk_MorphoField_Handler ()
		{
			if (cb_getField_ILcom_morpho_morphosmart_sdk_MorphoField_ == null)
				cb_getField_ILcom_morpho_morphosmart_sdk_MorphoField_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, int>) n_GetField_ILcom_morpho_morphosmart_sdk_MorphoField_);
			return cb_getField_ILcom_morpho_morphosmart_sdk_MorphoField_;
		}

		static int n_GetField_ILcom_morpho_morphosmart_sdk_MorphoField_ (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_morphoField)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoField morphoField = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (native_morphoField, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetField (index, morphoField);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getField' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoField']]"
		[Register ("getField", "(ILcom/morpho/morphosmart/sdk/MorphoField;)I", "GetGetField_ILcom_morpho_morphosmart_sdk_MorphoField_Handler")]
		public virtual unsafe int GetField (int index, global::Com.Morpho.Morphosmart.Sdk.MorphoField morphoField)
		{
			const string __id = "getField.(ILcom/morpho/morphosmart/sdk/MorphoField;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((morphoField == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoField).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getFormatPK_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetFormatPK_Ljava_lang_Integer_Handler ()
		{
			if (cb_getFormatPK_Ljava_lang_Integer_ == null)
				cb_getFormatPK_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetFormatPK_Ljava_lang_Integer_);
			return cb_getFormatPK_Ljava_lang_Integer_;
		}

		static int n_GetFormatPK_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_templateType)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer templateType = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_templateType, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetFormatPK (templateType);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getFormatPK' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getFormatPK", "(Ljava/lang/Integer;)I", "GetGetFormatPK_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetFormatPK (global::Java.Lang.Integer templateType)
		{
			const string __id = "getFormatPK.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((templateType == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateType).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getMaxDataBase_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetMaxDataBase_Ljava_lang_Integer_Handler ()
		{
			if (cb_getMaxDataBase_Ljava_lang_Integer_ == null)
				cb_getMaxDataBase_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMaxDataBase_Ljava_lang_Integer_);
			return cb_getMaxDataBase_Ljava_lang_Integer_;
		}

		static int n_GetMaxDataBase_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxdataBase)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxdataBase = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxdataBase, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMaxDataBase (maxdataBase);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getMaxDataBase' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getMaxDataBase", "(Ljava/lang/Integer;)I", "GetGetMaxDataBase_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetMaxDataBase (global::Java.Lang.Integer maxdataBase)
		{
			const string __id = "getMaxDataBase.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((maxdataBase == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxdataBase).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getMaxUser_Ljava_lang_Integer_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetMaxUser_Ljava_lang_Integer_Handler ()
		{
			if (cb_getMaxUser_Ljava_lang_Integer_ == null)
				cb_getMaxUser_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetMaxUser_Ljava_lang_Integer_);
			return cb_getMaxUser_Ljava_lang_Integer_;
		}

		[Obsolete]
		static int n_GetMaxUser_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxUser = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMaxUser (maxUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getMaxUser' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Obsolete (@"deprecated")]
		[Register ("getMaxUser", "(Ljava/lang/Integer;)I", "GetGetMaxUser_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetMaxUser (global::Java.Lang.Integer maxUser)
		{
			const string __id = "getMaxUser.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((maxUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_Handler ()
		{
			if (cb_getMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_ == null)
				cb_getMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_);
			return cb_getMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_;
		}

		static int n_GetMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maxUser, IntPtr native_maxFinger)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxUser = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxUser, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer maxFinger = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_maxFinger, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetMaxUser (maxUser, maxFinger);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getMaxUser' and count(parameter)=2 and parameter[1][@type='java.lang.Integer'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("getMaxUser", "(Ljava/lang/Integer;Ljava/lang/Integer;)I", "GetGetMaxUser_Ljava_lang_Integer_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetMaxUser (global::Java.Lang.Integer maxUser, global::Java.Lang.Integer maxFinger)
		{
			const string __id = "getMaxUser.(Ljava/lang/Integer;Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((maxUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxUser).Handle);
				__args [1] = new JniArgumentValue ((maxFinger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) maxFinger).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNbField_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetNbField_Ljava_lang_Long_Handler ()
		{
			if (cb_getNbField_Ljava_lang_Long_ == null)
				cb_getNbField_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbField_Ljava_lang_Long_);
			return cb_getNbField_Ljava_lang_Long_;
		}

		static int n_GetNbField_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbField)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long nbField = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_nbField, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbField (nbField);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getNbField' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getNbField", "(Ljava/lang/Long;)I", "GetGetNbField_Ljava_lang_Long_Handler")]
		public virtual unsafe int GetNbField (global::Java.Lang.Long nbField)
		{
			const string __id = "getNbField.(Ljava/lang/Long;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbField == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbField).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNbFinger_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetGetNbFinger_Ljava_lang_Integer_Handler ()
		{
			if (cb_getNbFinger_Ljava_lang_Integer_ == null)
				cb_getNbFinger_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbFinger_Ljava_lang_Integer_);
			return cb_getNbFinger_Ljava_lang_Integer_;
		}

		static int n_GetNbFinger_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbFinger)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer nbFinger = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_nbFinger, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbFinger (nbFinger);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getNbFinger' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("getNbFinger", "(Ljava/lang/Integer;)I", "GetGetNbFinger_Ljava_lang_Integer_Handler")]
		public virtual unsafe int GetNbFinger (global::Java.Lang.Integer nbFinger)
		{
			const string __id = "getNbFinger.(Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbFinger == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbFinger).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNbFreeRecord_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetNbFreeRecord_Ljava_lang_Long_Handler ()
		{
			if (cb_getNbFreeRecord_Ljava_lang_Long_ == null)
				cb_getNbFreeRecord_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbFreeRecord_Ljava_lang_Long_);
			return cb_getNbFreeRecord_Ljava_lang_Long_;
		}

		static int n_GetNbFreeRecord_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbFreeRecord)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long nbFreeRecord = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_nbFreeRecord, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbFreeRecord (nbFreeRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getNbFreeRecord' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getNbFreeRecord", "(Ljava/lang/Long;)I", "GetGetNbFreeRecord_Ljava_lang_Long_Handler")]
		public virtual unsafe int GetNbFreeRecord (global::Java.Lang.Long nbFreeRecord)
		{
			const string __id = "getNbFreeRecord.(Ljava/lang/Long;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbFreeRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbFreeRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNbTotalRecord_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetNbTotalRecord_Ljava_lang_Long_Handler ()
		{
			if (cb_getNbTotalRecord_Ljava_lang_Long_ == null)
				cb_getNbTotalRecord_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbTotalRecord_Ljava_lang_Long_);
			return cb_getNbTotalRecord_Ljava_lang_Long_;
		}

		static int n_GetNbTotalRecord_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbTotalRecord)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long nbTotalRecord = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_nbTotalRecord, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbTotalRecord (nbTotalRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getNbTotalRecord' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getNbTotalRecord", "(Ljava/lang/Long;)I", "GetGetNbTotalRecord_Ljava_lang_Long_Handler")]
		public virtual unsafe int GetNbTotalRecord (global::Java.Lang.Long nbTotalRecord)
		{
			const string __id = "getNbTotalRecord.(Ljava/lang/Long;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbTotalRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbTotalRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getNbUsedRecord_Ljava_lang_Long_;
#pragma warning disable 0169
		static Delegate GetGetNbUsedRecord_Ljava_lang_Long_Handler ()
		{
			if (cb_getNbUsedRecord_Ljava_lang_Long_ == null)
				cb_getNbUsedRecord_Ljava_lang_Long_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetNbUsedRecord_Ljava_lang_Long_);
			return cb_getNbUsedRecord_Ljava_lang_Long_;
		}

		static int n_GetNbUsedRecord_Ljava_lang_Long_ (IntPtr jnienv, IntPtr native__this, IntPtr native_nbUsedRecord)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Long nbUsedRecord = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_nbUsedRecord, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetNbUsedRecord (nbUsedRecord);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getNbUsedRecord' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("getNbUsedRecord", "(Ljava/lang/Long;)I", "GetGetNbUsedRecord_Ljava_lang_Long_Handler")]
		public virtual unsafe int GetNbUsedRecord (global::Java.Lang.Long nbUsedRecord)
		{
			const string __id = "getNbUsedRecord.(Ljava/lang/Long;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((nbUsedRecord == null) ? IntPtr.Zero : ((global::Java.Lang.Object) nbUsedRecord).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		static Delegate GetGetUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_getUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_getUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_getUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		static int n_GetUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userID, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string userID = JNIEnv.GetString (native_userID, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUser (userID, morphoUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getUser' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Register ("getUser", "(Ljava/lang/String;Lcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetGetUser_Ljava_lang_String_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int GetUser (string userID, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "getUser.(Ljava/lang/String;Lcom/morpho/morphosmart/sdk/MorphoUser;)I";
			IntPtr native_userID = JNIEnv.NewString (userID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_userID);
				__args [1] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_userID);
			}
		}

		static Delegate cb_getUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		static Delegate GetGetUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_getUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_getUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GetUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_getUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		static int n_GetUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, IntPtr native_userID, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] userID = (byte[]) JNIEnv.GetArray (native_userID, JniHandleOwnership.DoNotTransfer, typeof (byte));
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetUserBuffer (userID, morphoUser);
			if (userID != null)
				JNIEnv.CopyArray (userID, native_userID);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='getUserBuffer' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Register ("getUserBuffer", "([BLcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetGetUserBuffer_arrayBLcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int GetUserBuffer (byte[] userID, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "getUserBuffer.([BLcom/morpho/morphosmart/sdk/MorphoUser;)I";
			IntPtr native_userID = JNIEnv.NewArray (userID);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_userID);
				__args [1] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (userID != null) {
					JNIEnv.CopyArray (native_userID, userID);
					JNIEnv.DeleteLocalRef (native_userID);
				}
			}
		}

		static Delegate cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIdentify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, IntPtr, int, IntPtr, IntPtr, IntPtr, int>) n_Identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		[Obsolete]
		static int n_Identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, int timeout, int far, IntPtr native_coder, int detectModeChoice, IntPtr native_matchingStrategy, int callbackCmd, IntPtr native__callback, IntPtr native_resultMatching, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Coder coder = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (native_coder, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (native_matchingStrategy, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (native_resultMatching, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Identify (timeout, far, coder, detectModeChoice, matchingStrategy, callbackCmd, @callback, resultMatching, morphoUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='identify' and count(parameter)=9 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.Coder'] and parameter[4][@type='int'] and parameter[5][@type='com.morpho.morphosmart.sdk.MatchingStrategy'] and parameter[6][@type='int'] and parameter[7][@type='java.util.Observer'] and parameter[8][@type='com.morpho.morphosmart.sdk.ResultMatching'] and parameter[9][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Obsolete (@"deprecated")]
		[Register ("identify", "(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;Lcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetIdentify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int Identify (int timeout, int far, global::Com.Morpho.Morphosmart.Sdk.Coder coder, int detectModeChoice, global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy, int callbackCmd, global::Java.Util.IObserver @callback, global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "identify.(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;Lcom/morpho/morphosmart/sdk/MorphoUser;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue (far);
				__args [2] = new JniArgumentValue ((coder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coder).Handle);
				__args [3] = new JniArgumentValue (detectModeChoice);
				__args [4] = new JniArgumentValue ((matchingStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchingStrategy).Handle);
				__args [5] = new JniArgumentValue (callbackCmd);
				__args [6] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [7] = new JniArgumentValue ((resultMatching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultMatching).Handle);
				__args [8] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		static Delegate GetIdentify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, int, IntPtr, int, IntPtr, IntPtr, int, IntPtr, int>) n_Identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		static int n_Identify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, int timeout, int far, IntPtr native_coder, int detectModeChoice, IntPtr native_matchingStrategy, int callbackCmd, IntPtr native__callback, IntPtr native_resultMatching, int nbFingersToMatch, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.Coder coder = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.Coder> (native_coder, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy> (native_matchingStrategy, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IObserver @callback = (global::Java.Util.IObserver)global::Java.Lang.Object.GetObject<global::Java.Util.IObserver> (native__callback, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (native_resultMatching, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Identify (timeout, far, coder, detectModeChoice, matchingStrategy, callbackCmd, @callback, resultMatching, nbFingersToMatch, morphoUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='identify' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.morpho.morphosmart.sdk.Coder'] and parameter[4][@type='int'] and parameter[5][@type='com.morpho.morphosmart.sdk.MatchingStrategy'] and parameter[6][@type='int'] and parameter[7][@type='java.util.Observer'] and parameter[8][@type='com.morpho.morphosmart.sdk.ResultMatching'] and parameter[9][@type='int'] and parameter[10][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Register ("identify", "(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;ILcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetIdentify_IILcom_morpho_morphosmart_sdk_Coder_ILcom_morpho_morphosmart_sdk_MatchingStrategy_ILjava_util_Observer_Lcom_morpho_morphosmart_sdk_ResultMatching_ILcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int Identify (int timeout, int far, global::Com.Morpho.Morphosmart.Sdk.Coder coder, int detectModeChoice, global::Com.Morpho.Morphosmart.Sdk.MatchingStrategy matchingStrategy, int callbackCmd, global::Java.Util.IObserver @callback, global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching, int nbFingersToMatch, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "identify.(IILcom/morpho/morphosmart/sdk/Coder;ILcom/morpho/morphosmart/sdk/MatchingStrategy;ILjava/util/Observer;Lcom/morpho/morphosmart/sdk/ResultMatching;ILcom/morpho/morphosmart/sdk/MorphoUser;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (timeout);
				__args [1] = new JniArgumentValue (far);
				__args [2] = new JniArgumentValue ((coder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) coder).Handle);
				__args [3] = new JniArgumentValue (detectModeChoice);
				__args [4] = new JniArgumentValue ((matchingStrategy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matchingStrategy).Handle);
				__args [5] = new JniArgumentValue (callbackCmd);
				__args [6] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [7] = new JniArgumentValue ((resultMatching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultMatching).Handle);
				__args [8] = new JniArgumentValue (nbFingersToMatch);
				__args [9] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler ()
		{
			if (cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_ == null)
				cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_IdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_);
			return cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_;
		}

		[Obsolete]
		static int n_IdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_ (IntPtr jnienv, IntPtr native__this, int far, IntPtr native_templateList, IntPtr native_morphoUser)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (native_templateList, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IdentifyMatch (far, templateList, morphoUser);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='identifyMatch' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.TemplateList'] and parameter[3][@type='com.morpho.morphosmart.sdk.MorphoUser']]"
		[Obsolete (@"deprecated")]
		[Register ("identifyMatch", "(ILcom/morpho/morphosmart/sdk/TemplateList;Lcom/morpho/morphosmart/sdk/MorphoUser;)I", "GetIdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Handler")]
		public virtual unsafe int IdentifyMatch (int far, global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser)
		{
			const string __id = "identifyMatch.(ILcom/morpho/morphosmart/sdk/TemplateList;Lcom/morpho/morphosmart/sdk/MorphoUser;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (far);
				__args [1] = new JniArgumentValue ((templateList == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateList).Handle);
				__args [2] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_;
#pragma warning disable 0169
		static Delegate GetIdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_Handler ()
		{
			if (cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_ == null)
				cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int>) n_IdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_);
			return cb_identifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_;
		}

		static int n_IdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_ (IntPtr jnienv, IntPtr native__this, int far, IntPtr native_templateList, IntPtr native_morphoUser, IntPtr native_resultMatching)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.TemplateList> (native_templateList, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUser> (native_morphoUser, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (native_resultMatching, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.IdentifyMatch (far, templateList, morphoUser, resultMatching);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='identifyMatch' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='com.morpho.morphosmart.sdk.TemplateList'] and parameter[3][@type='com.morpho.morphosmart.sdk.MorphoUser'] and parameter[4][@type='com.morpho.morphosmart.sdk.ResultMatching']]"
		[Register ("identifyMatch", "(ILcom/morpho/morphosmart/sdk/TemplateList;Lcom/morpho/morphosmart/sdk/MorphoUser;Lcom/morpho/morphosmart/sdk/ResultMatching;)I", "GetIdentifyMatch_ILcom_morpho_morphosmart_sdk_TemplateList_Lcom_morpho_morphosmart_sdk_MorphoUser_Lcom_morpho_morphosmart_sdk_ResultMatching_Handler")]
		public virtual unsafe int IdentifyMatch (int far, global::Com.Morpho.Morphosmart.Sdk.TemplateList templateList, global::Com.Morpho.Morphosmart.Sdk.MorphoUser morphoUser, global::Com.Morpho.Morphosmart.Sdk.ResultMatching resultMatching)
		{
			const string __id = "identifyMatch.(ILcom/morpho/morphosmart/sdk/TemplateList;Lcom/morpho/morphosmart/sdk/MorphoUser;Lcom/morpho/morphosmart/sdk/ResultMatching;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (far);
				__args [1] = new JniArgumentValue ((templateList == null) ? IntPtr.Zero : ((global::Java.Lang.Object) templateList).Handle);
				__args [2] = new JniArgumentValue ((morphoUser == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUser).Handle);
				__args [3] = new JniArgumentValue ((resultMatching == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultMatching).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_putField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_;
#pragma warning disable 0169
		static Delegate GetPutField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_Handler ()
		{
			if (cb_putField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_ == null)
				cb_putField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_PutField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_);
			return cb_putField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_;
		}

		static int n_PutField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_morphoField, IntPtr native_index)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoField morphoField = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoField> (native_morphoField, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Integer index = global::Java.Lang.Object.GetObject<global::Java.Lang.Integer> (native_index, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutField (morphoField, index);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='putField' and count(parameter)=2 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoField'] and parameter[2][@type='java.lang.Integer']]"
		[Register ("putField", "(Lcom/morpho/morphosmart/sdk/MorphoField;Ljava/lang/Integer;)I", "GetPutField_Lcom_morpho_morphosmart_sdk_MorphoField_Ljava_lang_Integer_Handler")]
		public virtual unsafe int PutField (global::Com.Morpho.Morphosmart.Sdk.MorphoField morphoField, global::Java.Lang.Integer index)
		{
			const string __id = "putField.(Lcom/morpho/morphosmart/sdk/MorphoField;Ljava/lang/Integer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((morphoField == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoField).Handle);
				__args [1] = new JniArgumentValue ((index == null) ? IntPtr.Zero : ((global::Java.Lang.Object) index).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_readPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_;
#pragma warning disable 0169
		static Delegate GetReadPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_Handler ()
		{
			if (cb_readPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_ == null)
				cb_readPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_ReadPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_);
			return cb_readPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_;
		}

		static int n_ReadPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fieldsIndex, IntPtr native_morphoUserList)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoDatabase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] fieldsIndex = (int[]) JNIEnv.GetArray (native_fieldsIndex, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Com.Morpho.Morphosmart.Sdk.MorphoUserList morphoUserList = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoUserList> (native_morphoUserList, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadPublicFields (fieldsIndex, morphoUserList);
			if (fieldsIndex != null)
				JNIEnv.CopyArray (fieldsIndex, native_fieldsIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoDatabase']/method[@name='readPublicFields' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='com.morpho.morphosmart.sdk.MorphoUserList']]"
		[Register ("readPublicFields", "([ILcom/morpho/morphosmart/sdk/MorphoUserList;)I", "GetReadPublicFields_arrayILcom_morpho_morphosmart_sdk_MorphoUserList_Handler")]
		public virtual unsafe int ReadPublicFields (int[] fieldsIndex, global::Com.Morpho.Morphosmart.Sdk.MorphoUserList morphoUserList)
		{
			const string __id = "readPublicFields.([ILcom/morpho/morphosmart/sdk/MorphoUserList;)I";
			IntPtr native_fieldsIndex = JNIEnv.NewArray (fieldsIndex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fieldsIndex);
				__args [1] = new JniArgumentValue ((morphoUserList == null) ? IntPtr.Zero : ((global::Java.Lang.Object) morphoUserList).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (fieldsIndex != null) {
					JNIEnv.CopyArray (native_fieldsIndex, fieldsIndex);
					JNIEnv.DeleteLocalRef (native_fieldsIndex);
				}
			}
		}

	}
}
