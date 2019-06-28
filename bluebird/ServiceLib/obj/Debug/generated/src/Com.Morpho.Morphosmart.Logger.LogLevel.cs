using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Logger {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/logger/LogLevel", DoNotGenerateAcw=true)]
	public sealed partial class LogLevel : global::Java.Lang.Enum {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static global::Com.Morpho.Morphosmart.Logger.LogLevel Debug {
			get {
				const string __id = "DEBUG.Lcom/morpho/morphosmart/logger/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/field[@name='ERROR']"
		[Register ("ERROR")]
		public static global::Com.Morpho.Morphosmart.Logger.LogLevel Error {
			get {
				const string __id = "ERROR.Lcom/morpho/morphosmart/logger/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/field[@name='INFO']"
		[Register ("INFO")]
		public static global::Com.Morpho.Morphosmart.Logger.LogLevel Info {
			get {
				const string __id = "INFO.Lcom/morpho/morphosmart/logger/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/field[@name='VERBOSE']"
		[Register ("VERBOSE")]
		public static global::Com.Morpho.Morphosmart.Logger.LogLevel Verbose {
			get {
				const string __id = "VERBOSE.Lcom/morpho/morphosmart/logger/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/field[@name='WARN']"
		[Register ("WARN")]
		public static global::Com.Morpho.Morphosmart.Logger.LogLevel Warn {
			get {
				const string __id = "WARN.Lcom/morpho/morphosmart/logger/LogLevel;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/logger/LogLevel", typeof (LogLevel));
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

		internal LogLevel (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/morpho/morphosmart/logger/LogLevel;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Logger.LogLevel ValueOf (string p0)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lcom/morpho/morphosmart/logger/LogLevel;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Logger.LogLevel> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.logger']/class[@name='LogLevel']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/morpho/morphosmart/logger/LogLevel;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Logger.LogLevel[] Values ()
		{
			const string __id = "values.()[Lcom/morpho/morphosmart/logger/LogLevel;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Com.Morpho.Morphosmart.Logger.LogLevel[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Morpho.Morphosmart.Logger.LogLevel));
			} finally {
			}
		}

	}
}
