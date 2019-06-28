using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Morpho.Msosecu.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']"
	[global::Android.Runtime.Register ("morpho/msosecu/sdk/api/MsoSecuJNI", DoNotGenerateAcw=true)]
	public partial class MsoSecuJNI : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("morpho/msosecu/sdk/api/MsoSecuJNI", typeof (MsoSecuJNI));
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

		protected MsoSecuJNI (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/constructor[@name='MsoSecuJNI' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MsoSecuJNI ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='AES128_BLOCK_LENGTH_get' and count(parameter)=0]"
		[Register ("AES128_BLOCK_LENGTH_get", "()I", "")]
		public static unsafe int AES128_BLOCK_LENGTH_get ()
		{
			const string __id = "AES128_BLOCK_LENGTH_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='DES_BLOCK_LENGTH_get' and count(parameter)=0]"
		[Register ("DES_BLOCK_LENGTH_get", "()I", "")]
		public static unsafe int DES_BLOCK_LENGTH_get ()
		{
			const string __id = "DES_BLOCK_LENGTH_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_AES128_FINAL_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_AES128_FINAL_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_AES128_FINAL_ERR_get ()
		{
			const string __id = "MSOSECU_AES128_FINAL_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_AES128_INIT_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_AES128_INIT_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_AES128_INIT_ERR_get ()
		{
			const string __id = "MSOSECU_AES128_INIT_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_AES128_UPDATE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_AES128_UPDATE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_AES128_UPDATE_ERR_get ()
		{
			const string __id = "MSOSECU_AES128_UPDATE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_ALLOC_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_ALLOC_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_ALLOC_ERR_get ()
		{
			const string __id = "MSOSECU_ALLOC_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_BAD_PARAMETER_get' and count(parameter)=0]"
		[Register ("MSOSECU_BAD_PARAMETER_get", "()I", "")]
		public static unsafe int MSOSECU_BAD_PARAMETER_get ()
		{
			const string __id = "MSOSECU_BAD_PARAMETER_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_BIO_NEW_MEM_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_BIO_NEW_MEM_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_BIO_NEW_MEM_ERR_get ()
		{
			const string __id = "MSOSECU_BIO_NEW_MEM_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_CRYPTO_PROTOCOLE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_CRYPTO_PROTOCOLE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_CRYPTO_PROTOCOLE_ERR_get ()
		{
			const string __id = "MSOSECU_CRYPTO_PROTOCOLE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_DELETE_FILE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_DELETE_FILE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_DELETE_FILE_ERR_get ()
		{
			const string __id = "MSOSECU_DELETE_FILE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_DSA_KEY_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_DSA_KEY_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_DSA_KEY_ERR_get ()
		{
			const string __id = "MSOSECU_DSA_KEY_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_DSS1_FINAL_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_DSS1_FINAL_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_DSS1_FINAL_ERR_get ()
		{
			const string __id = "MSOSECU_DSS1_FINAL_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_DSS1_INIT_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_DSS1_INIT_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_DSS1_INIT_ERR_get ()
		{
			const string __id = "MSOSECU_DSS1_INIT_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_DSS1_UPDATE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_DSS1_UPDATE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_DSS1_UPDATE_ERR_get ()
		{
			const string __id = "MSOSECU_DSS1_UPDATE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_FILE_EMPTY_get' and count(parameter)=0]"
		[Register ("MSOSECU_FILE_EMPTY_get", "()I", "")]
		public static unsafe int MSOSECU_FILE_EMPTY_get ()
		{
			const string __id = "MSOSECU_FILE_EMPTY_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_FILE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_FILE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_FILE_ERR_get ()
		{
			const string __id = "MSOSECU_FILE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_INVALID_CERTIF_get' and count(parameter)=0]"
		[Register ("MSOSECU_INVALID_CERTIF_get", "()I", "")]
		public static unsafe int MSOSECU_INVALID_CERTIF_get ()
		{
			const string __id = "MSOSECU_INVALID_CERTIF_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_MODE_DSA_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_MODE_DSA_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_MODE_DSA_ERR_get ()
		{
			const string __id = "MSOSECU_MODE_DSA_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_OK_get' and count(parameter)=0]"
		[Register ("MSOSECU_OK_get", "()I", "")]
		public static unsafe int MSOSECU_OK_get ()
		{
			const string __id = "MSOSECU_OK_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_OPEN_FILE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_OPEN_FILE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_OPEN_FILE_ERR_get ()
		{
			const string __id = "MSOSECU_OPEN_FILE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_OPEN_SSL_get' and count(parameter)=0]"
		[Register ("MSOSECU_OPEN_SSL_get", "()I", "")]
		public static unsafe int MSOSECU_OPEN_SSL_get ()
		{
			const string __id = "MSOSECU_OPEN_SSL_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR_get ()
		{
			const string __id = "MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_PARSE_DER_TO_X509STRUCT_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_PARSE_DER_TO_X509STRUCT_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_PARSE_DER_TO_X509STRUCT_ERR_get ()
		{
			const string __id = "MSOSECU_PARSE_DER_TO_X509STRUCT_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_PEM_READ_BIO_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_PEM_READ_BIO_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_PEM_READ_BIO_ERR_get ()
		{
			const string __id = "MSOSECU_PEM_READ_BIO_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_PUBLIC_KEY_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_PUBLIC_KEY_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_PUBLIC_KEY_ERR_get ()
		{
			const string __id = "MSOSECU_PUBLIC_KEY_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_READ_FILE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_READ_FILE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_READ_FILE_ERR_get ()
		{
			const string __id = "MSOSECU_READ_FILE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_RSA_KEY_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_RSA_KEY_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_RSA_KEY_ERR_get ()
		{
			const string __id = "MSOSECU_RSA_KEY_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_SHA1_FINAL_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_SHA1_FINAL_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_SHA1_FINAL_ERR_get ()
		{
			const string __id = "MSOSECU_SHA1_FINAL_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_SHA1_INIT_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_SHA1_INIT_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_SHA1_INIT_ERR_get ()
		{
			const string __id = "MSOSECU_SHA1_INIT_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_SHA1_UPDATE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_SHA1_UPDATE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_SHA1_UPDATE_ERR_get ()
		{
			const string __id = "MSOSECU_SHA1_UPDATE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_STORE_LOAD_LOCATIONS_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_STORE_LOAD_LOCATIONS_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_STORE_LOAD_LOCATIONS_ERR_get ()
		{
			const string __id = "MSOSECU_STORE_LOAD_LOCATIONS_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_STORE_NEW_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_STORE_NEW_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_STORE_NEW_ERR_get ()
		{
			const string __id = "MSOSECU_STORE_NEW_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='MSOSECU_WRITE_FILE_ERR_get' and count(parameter)=0]"
		[Register ("MSOSECU_WRITE_FILE_ERR_get", "()I", "")]
		public static unsafe int MSOSECU_WRITE_FILE_ERR_get ()
		{
			const string __id = "MSOSECU_WRITE_FILE_ERR_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='TRIPLE_DES_KEY_LENGTH_get' and count(parameter)=0]"
		[Register ("TRIPLE_DES_KEY_LENGTH_get", "()I", "")]
		public static unsafe int TRIPLE_DES_KEY_LENGTH_get ()
		{
			const string __id = "TRIPLE_DES_KEY_LENGTH_get.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='computeCRC32' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='long'] and parameter[7][@type='long[]']]"
		[Register ("computeCRC32", "([BJJZZJ[J)I", "")]
		public static unsafe int ComputeCRC32 (byte[] p0, long p1, long p2, bool p3, bool p4, long p5, long[] p6)
		{
			const string __id = "computeCRC32.([BJJZZJ[J)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p6 != null) {
					JNIEnv.CopyArray (native_p6, p6);
					JNIEnv.DeleteLocalRef (native_p6);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='decryptAes128Cbc' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("decryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I", "")]
		public static unsafe int DecryptAes128Cbc (byte[] p0, byte[] p1, byte[] p2, bool p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4)
		{
			const string __id = "decryptAes128Cbc.([B[B[BZLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='desCrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("desCrypt", "([B[BLjava/util/ArrayList;)I", "")]
		public static unsafe int DesCrypt (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			const string __id = "desCrypt.([B[BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='encrypt3DesCbcNopad' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("encrypt3DesCbcNopad", "([B[B[B[B)I", "")]
		public static unsafe int Encrypt3DesCbcNopad (byte[] p0, byte[] p1, byte[] p2, byte[] p3)
		{
			const string __id = "encrypt3DesCbcNopad.([B[B[B[B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='encryptAes128Cbc' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("encryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I", "")]
		public static unsafe int EncryptAes128Cbc (byte[] p0, byte[] p1, byte[] p2, bool p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4)
		{
			const string __id = "encryptAes128Cbc.([B[B[BZLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='genRandom' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("genRandom", "([B)I", "")]
		public static unsafe int GenRandom (byte[] p0)
		{
			const string __id = "genRandom.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='getHostCertif' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("getHostCertif", "(Ljava/util/ArrayList;)I", "")]
		public static unsafe int GetHostCertif (global::System.Collections.Generic.IList<global::Java.Lang.Byte> p0)
		{
			const string __id = "getHostCertif.(Ljava/util/ArrayList;)I";
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='rsaEncrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("rsaEncrypt", "([B[BLjava/util/ArrayList;)I", "")]
		public static unsafe int RsaEncrypt (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			const string __id = "rsaEncrypt.([B[BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='setOpenSSLPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOpenSSLPath", "(Ljava/lang/String;)I", "")]
		public static unsafe int SetOpenSSLPath (string p0)
		{
			const string __id = "setOpenSSLPath.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='signRSA' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("signRSA", "([B[BLjava/util/ArrayList;)I", "")]
		public static unsafe int SignRSA (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			const string __id = "signRSA.([B[BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tripleDesCrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesCrypt", "([BLjava/util/ArrayList;)I", "")]
		public static unsafe int TripleDesCrypt (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			const string __id = "tripleDesCrypt.([BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tripleDesCryptByKey' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesCryptByKey", "([B[BLjava/util/ArrayList;)I", "")]
		public static unsafe int TripleDesCryptByKey (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			const string __id = "tripleDesCryptByKey.([B[BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tripleDesDecrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesDecrypt", "([BLjava/util/ArrayList;)I", "")]
		public static unsafe int TripleDesDecrypt (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			const string __id = "tripleDesDecrypt.([BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tripleDesSign' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesSign", "([BLjava/util/ArrayList;)I", "")]
		public static unsafe int TripleDesSign (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			const string __id = "tripleDesSign.([BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tripleDesVerifSign' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean[]']]"
		[Register ("tripleDesVerifSign", "([B[B[Z)I", "")]
		public static unsafe int TripleDesVerifSign (byte[] p0, byte[] p1, bool[] p2)
		{
			const string __id = "tripleDesVerifSign.([B[B[Z)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tunnelingInit1' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tunnelingInit1", "([B[B[B[BLjava/util/ArrayList;)I", "")]
		public static unsafe int TunnelingInit1 (byte[] p0, byte[] p1, byte[] p2, byte[] p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4)
		{
			const string __id = "tunnelingInit1.([B[B[B[BLjava/util/ArrayList;)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue (native_p4);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='tunnelingInit2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("tunnelingInit2", "([B)I", "")]
		public static unsafe int TunnelingInit2 (byte[] p0)
		{
			const string __id = "tunnelingInit2.([B)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='verifCertif' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
		[Register ("verifCertif", "([B[I)I", "")]
		public static unsafe int VerifCertif (byte[] p0, int[] p1)
		{
			const string __id = "verifCertif.([B[I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='verifOfferedSecuritySignature' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifOfferedSecuritySignature", "([B[B[B[I)I", "")]
		public static unsafe int VerifOfferedSecuritySignature (byte[] p0, byte[] p1, byte[] p2, int[] p3)
		{
			const string __id = "verifOfferedSecuritySignature.([B[B[B[I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='verifSignDSA' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifSignDSA", "([B[B[B[I)I", "")]
		public static unsafe int VerifSignDSA (byte[] p0, byte[] p1, byte[] p2, int[] p3)
		{
			const string __id = "verifSignDSA.([B[B[B[I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecuJNI']/method[@name='verifSignRSA' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifSignRSA", "([B[B[B[I)I", "")]
		public static unsafe int VerifSignRSA (byte[] p0, byte[] p1, byte[] p2, int[] p3)
		{
			const string __id = "verifSignRSA.([B[B[B[I)I";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (native_p3);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
				if (p3 != null) {
					JNIEnv.CopyArray (native_p3, p3);
					JNIEnv.DeleteLocalRef (native_p3);
				}
			}
		}

	}
}
