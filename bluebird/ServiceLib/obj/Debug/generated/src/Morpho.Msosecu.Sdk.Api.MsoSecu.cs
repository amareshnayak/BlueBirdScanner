using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Morpho.Msosecu.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']"
	[global::Android.Runtime.Register ("morpho/msosecu/sdk/api/MsoSecu", DoNotGenerateAcw=true)]
	public partial class MsoSecu : global::Java.Lang.Object, global::Com.Morpho.Morphosmart.Sdk.IMsoSecu {


		public static class InterfaceConsts {

			// The following are fields from: morpho.msosecu.sdk.api.MsoSecuConstants


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='AES128_BLOCK_LENGTH']"
			[Register ("AES128_BLOCK_LENGTH")]
			public static int Aes128BlockLength {
				get {
					const string __id = "AES128_BLOCK_LENGTH.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='DES_BLOCK_LENGTH']"
			[Register ("DES_BLOCK_LENGTH")]
			public static int DesBlockLength {
				get {
					const string __id = "DES_BLOCK_LENGTH.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_AES128_FINAL_ERR']"
			[Register ("MSOSECU_AES128_FINAL_ERR")]
			public static int MsosecuAes128FinalErr {
				get {
					const string __id = "MSOSECU_AES128_FINAL_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_AES128_INIT_ERR']"
			[Register ("MSOSECU_AES128_INIT_ERR")]
			public static int MsosecuAes128InitErr {
				get {
					const string __id = "MSOSECU_AES128_INIT_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_AES128_UPDATE_ERR']"
			[Register ("MSOSECU_AES128_UPDATE_ERR")]
			public static int MsosecuAes128UpdateErr {
				get {
					const string __id = "MSOSECU_AES128_UPDATE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_ALLOC_ERR']"
			[Register ("MSOSECU_ALLOC_ERR")]
			public static int MsosecuAllocErr {
				get {
					const string __id = "MSOSECU_ALLOC_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_BAD_PARAMETER']"
			[Register ("MSOSECU_BAD_PARAMETER")]
			public static int MsosecuBadParameter {
				get {
					const string __id = "MSOSECU_BAD_PARAMETER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_BIO_NEW_MEM_ERR']"
			[Register ("MSOSECU_BIO_NEW_MEM_ERR")]
			public static int MsosecuBioNewMemErr {
				get {
					const string __id = "MSOSECU_BIO_NEW_MEM_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_CRYPTO_PROTOCOLE_ERR']"
			[Register ("MSOSECU_CRYPTO_PROTOCOLE_ERR")]
			public static int MsosecuCryptoProtocoleErr {
				get {
					const string __id = "MSOSECU_CRYPTO_PROTOCOLE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_DELETE_FILE_ERR']"
			[Register ("MSOSECU_DELETE_FILE_ERR")]
			public static int MsosecuDeleteFileErr {
				get {
					const string __id = "MSOSECU_DELETE_FILE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_DSA_KEY_ERR']"
			[Register ("MSOSECU_DSA_KEY_ERR")]
			public static int MsosecuDsaKeyErr {
				get {
					const string __id = "MSOSECU_DSA_KEY_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_DSS1_FINAL_ERR']"
			[Register ("MSOSECU_DSS1_FINAL_ERR")]
			public static int MsosecuDss1FinalErr {
				get {
					const string __id = "MSOSECU_DSS1_FINAL_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_DSS1_INIT_ERR']"
			[Register ("MSOSECU_DSS1_INIT_ERR")]
			public static int MsosecuDss1InitErr {
				get {
					const string __id = "MSOSECU_DSS1_INIT_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_DSS1_UPDATE_ERR']"
			[Register ("MSOSECU_DSS1_UPDATE_ERR")]
			public static int MsosecuDss1UpdateErr {
				get {
					const string __id = "MSOSECU_DSS1_UPDATE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_FILE_EMPTY']"
			[Register ("MSOSECU_FILE_EMPTY")]
			public static int MsosecuFileEmpty {
				get {
					const string __id = "MSOSECU_FILE_EMPTY.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_FILE_ERR']"
			[Register ("MSOSECU_FILE_ERR")]
			public static int MsosecuFileErr {
				get {
					const string __id = "MSOSECU_FILE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_INVALID_CERTIF']"
			[Register ("MSOSECU_INVALID_CERTIF")]
			public static int MsosecuInvalidCertif {
				get {
					const string __id = "MSOSECU_INVALID_CERTIF.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_MODE_DSA_ERR']"
			[Register ("MSOSECU_MODE_DSA_ERR")]
			public static int MsosecuModeDsaErr {
				get {
					const string __id = "MSOSECU_MODE_DSA_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_OK']"
			[Register ("MSOSECU_OK")]
			public static int MsosecuOk {
				get {
					const string __id = "MSOSECU_OK.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_OPEN_FILE_ERR']"
			[Register ("MSOSECU_OPEN_FILE_ERR")]
			public static int MsosecuOpenFileErr {
				get {
					const string __id = "MSOSECU_OPEN_FILE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_OPEN_SSL']"
			[Register ("MSOSECU_OPEN_SSL")]
			public static int MsosecuOpenSsl {
				get {
					const string __id = "MSOSECU_OPEN_SSL.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR']"
			[Register ("MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR")]
			public static int MsosecuParseDataToX509structErr {
				get {
					const string __id = "MSOSECU_PARSE_DATA_TO_X509STRUCT_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_PARSE_DER_TO_X509STRUCT_ERR']"
			[Register ("MSOSECU_PARSE_DER_TO_X509STRUCT_ERR")]
			public static int MsosecuParseDerToX509structErr {
				get {
					const string __id = "MSOSECU_PARSE_DER_TO_X509STRUCT_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_PEM_READ_BIO_ERR']"
			[Register ("MSOSECU_PEM_READ_BIO_ERR")]
			public static int MsosecuPemReadBioErr {
				get {
					const string __id = "MSOSECU_PEM_READ_BIO_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_PUBLIC_KEY_ERR']"
			[Register ("MSOSECU_PUBLIC_KEY_ERR")]
			public static int MsosecuPublicKeyErr {
				get {
					const string __id = "MSOSECU_PUBLIC_KEY_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_READ_FILE_ERR']"
			[Register ("MSOSECU_READ_FILE_ERR")]
			public static int MsosecuReadFileErr {
				get {
					const string __id = "MSOSECU_READ_FILE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_RSA_KEY_ERR']"
			[Register ("MSOSECU_RSA_KEY_ERR")]
			public static int MsosecuRsaKeyErr {
				get {
					const string __id = "MSOSECU_RSA_KEY_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_SHA1_FINAL_ERR']"
			[Register ("MSOSECU_SHA1_FINAL_ERR")]
			public static int MsosecuSha1FinalErr {
				get {
					const string __id = "MSOSECU_SHA1_FINAL_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_SHA1_INIT_ERR']"
			[Register ("MSOSECU_SHA1_INIT_ERR")]
			public static int MsosecuSha1InitErr {
				get {
					const string __id = "MSOSECU_SHA1_INIT_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_SHA1_UPDATE_ERR']"
			[Register ("MSOSECU_SHA1_UPDATE_ERR")]
			public static int MsosecuSha1UpdateErr {
				get {
					const string __id = "MSOSECU_SHA1_UPDATE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_STORE_LOAD_LOCATIONS_ERR']"
			[Register ("MSOSECU_STORE_LOAD_LOCATIONS_ERR")]
			public static int MsosecuStoreLoadLocationsErr {
				get {
					const string __id = "MSOSECU_STORE_LOAD_LOCATIONS_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_STORE_NEW_ERR']"
			[Register ("MSOSECU_STORE_NEW_ERR")]
			public static int MsosecuStoreNewErr {
				get {
					const string __id = "MSOSECU_STORE_NEW_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='MSOSECU_WRITE_FILE_ERR']"
			[Register ("MSOSECU_WRITE_FILE_ERR")]
			public static int MsosecuWriteFileErr {
				get {
					const string __id = "MSOSECU_WRITE_FILE_ERR.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='morpho.msosecu.sdk.api']/interface[@name='MsoSecuConstants']/field[@name='TRIPLE_DES_KEY_LENGTH']"
			[Register ("TRIPLE_DES_KEY_LENGTH")]
			public static int TripleDesKeyLength {
				get {
					const string __id = "TRIPLE_DES_KEY_LENGTH.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
			}
		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("morpho/msosecu/sdk/api/MsoSecu", typeof (MsoSecu));
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

		protected MsoSecu (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/constructor[@name='MsoSecu' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MsoSecu ()
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

		static Delegate cb_computeCRC32_arrayBJJZZJarrayJ;
#pragma warning disable 0169
		static Delegate GetComputeCRC32_arrayBJJZZJarrayJHandler ()
		{
			if (cb_computeCRC32_arrayBJJZZJarrayJ == null)
				cb_computeCRC32_arrayBJJZZJarrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, bool, bool, long, IntPtr, int>) n_ComputeCRC32_arrayBJJZZJarrayJ);
			return cb_computeCRC32_arrayBJJZZJarrayJ;
		}

		static int n_ComputeCRC32_arrayBJJZZJarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_data, long polynomial, long initialCRCValue, bool inputReflected, bool outputReflected, long outputXOR, IntPtr native_crcValue)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long[] crcValue = (long[]) JNIEnv.GetArray (native_crcValue, JniHandleOwnership.DoNotTransfer, typeof (long));
			int __ret = __this.ComputeCRC32 (data, polynomial, initialCRCValue, inputReflected, outputReflected, outputXOR, crcValue);
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			if (crcValue != null)
				JNIEnv.CopyArray (crcValue, native_crcValue);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='computeCRC32' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='long'] and parameter[7][@type='long[]']]"
		[Register ("computeCRC32", "([BJJZZJ[J)I", "GetComputeCRC32_arrayBJJZZJarrayJHandler")]
		public virtual unsafe int ComputeCRC32 (byte[] data, long polynomial, long initialCRCValue, bool inputReflected, bool outputReflected, long outputXOR, long[] crcValue)
		{
			const string __id = "computeCRC32.([BJJZZJ[J)I";
			IntPtr native_data = JNIEnv.NewArray (data);
			IntPtr native_crcValue = JNIEnv.NewArray (crcValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (polynomial);
				__args [2] = new JniArgumentValue (initialCRCValue);
				__args [3] = new JniArgumentValue (inputReflected);
				__args [4] = new JniArgumentValue (outputReflected);
				__args [5] = new JniArgumentValue (outputXOR);
				__args [6] = new JniArgumentValue (native_crcValue);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				if (crcValue != null) {
					JNIEnv.CopyArray (native_crcValue, crcValue);
					JNIEnv.DeleteLocalRef (native_crcValue);
				}
			}
		}

		static Delegate cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetDecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler ()
		{
			if (cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ == null)
				cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, int>) n_DecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_);
			return cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
		}

		static int n_DecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_aes128CbcCryptedData, IntPtr native_iv, bool usePadding, IntPtr native_aes128CbcClearData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] aes128CbcCryptedData = (byte[]) JNIEnv.GetArray (native_aes128CbcCryptedData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] iv = (byte[]) JNIEnv.GetArray (native_iv, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var aes128CbcClearData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_aes128CbcClearData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecryptAes128Cbc (key, aes128CbcCryptedData, iv, usePadding, aes128CbcClearData);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (aes128CbcCryptedData != null)
				JNIEnv.CopyArray (aes128CbcCryptedData, native_aes128CbcCryptedData);
			if (iv != null)
				JNIEnv.CopyArray (iv, native_iv);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='decryptAes128Cbc' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("decryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I", "GetDecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler")]
		public virtual unsafe int DecryptAes128Cbc (byte[] key, byte[] aes128CbcCryptedData, byte[] iv, bool usePadding, global::System.Collections.Generic.IList<global::Java.Lang.Byte> aes128CbcClearData)
		{
			const string __id = "decryptAes128Cbc.([B[B[BZLjava/util/ArrayList;)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_aes128CbcCryptedData = JNIEnv.NewArray (aes128CbcCryptedData);
			IntPtr native_iv = JNIEnv.NewArray (iv);
			IntPtr native_aes128CbcClearData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (aes128CbcClearData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_aes128CbcCryptedData);
				__args [2] = new JniArgumentValue (native_iv);
				__args [3] = new JniArgumentValue (usePadding);
				__args [4] = new JniArgumentValue (native_aes128CbcClearData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (aes128CbcCryptedData != null) {
					JNIEnv.CopyArray (native_aes128CbcCryptedData, aes128CbcCryptedData);
					JNIEnv.DeleteLocalRef (native_aes128CbcCryptedData);
				}
				if (iv != null) {
					JNIEnv.CopyArray (native_iv, iv);
					JNIEnv.DeleteLocalRef (native_iv);
				}
				JNIEnv.DeleteLocalRef (native_aes128CbcClearData);
			}
		}

		static Delegate cb_desCrypt_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetDesCrypt_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_desCrypt_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_desCrypt_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DesCrypt_arrayBarrayBLjava_util_ArrayList_);
			return cb_desCrypt_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_DesCrypt_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_desClearData, IntPtr native_desCryptData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] desClearData = (byte[]) JNIEnv.GetArray (native_desClearData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var desCryptData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_desCryptData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesCrypt (key, desClearData, desCryptData);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (desClearData != null)
				JNIEnv.CopyArray (desClearData, native_desClearData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='desCrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("desCrypt", "([B[BLjava/util/ArrayList;)I", "GetDesCrypt_arrayBarrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int DesCrypt (byte[] key, byte[] desClearData, global::System.Collections.Generic.IList<global::Java.Lang.Byte> desCryptData)
		{
			const string __id = "desCrypt.([B[BLjava/util/ArrayList;)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_desClearData = JNIEnv.NewArray (desClearData);
			IntPtr native_desCryptData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (desCryptData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_desClearData);
				__args [2] = new JniArgumentValue (native_desCryptData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (desClearData != null) {
					JNIEnv.CopyArray (native_desClearData, desClearData);
					JNIEnv.DeleteLocalRef (native_desClearData);
				}
				JNIEnv.DeleteLocalRef (native_desCryptData);
			}
		}

		static Delegate cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetEncrypt3DesCbcNopad_arrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB == null)
				cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB);
			return cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB;
		}

		static int n_Encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_tripleDesCbcNoPadClearData, IntPtr native_iv, IntPtr native_tripleDesCbcNoPadCryptData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] tripleDesCbcNoPadClearData = (byte[]) JNIEnv.GetArray (native_tripleDesCbcNoPadClearData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] iv = (byte[]) JNIEnv.GetArray (native_iv, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] tripleDesCbcNoPadCryptData = (byte[]) JNIEnv.GetArray (native_tripleDesCbcNoPadCryptData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Encrypt3DesCbcNopad (key, tripleDesCbcNoPadClearData, iv, tripleDesCbcNoPadCryptData);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (tripleDesCbcNoPadClearData != null)
				JNIEnv.CopyArray (tripleDesCbcNoPadClearData, native_tripleDesCbcNoPadClearData);
			if (iv != null)
				JNIEnv.CopyArray (iv, native_iv);
			if (tripleDesCbcNoPadCryptData != null)
				JNIEnv.CopyArray (tripleDesCbcNoPadCryptData, native_tripleDesCbcNoPadCryptData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='encrypt3DesCbcNopad' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("encrypt3DesCbcNopad", "([B[B[B[B)I", "GetEncrypt3DesCbcNopad_arrayBarrayBarrayBarrayBHandler")]
		public virtual unsafe int Encrypt3DesCbcNopad (byte[] key, byte[] tripleDesCbcNoPadClearData, byte[] iv, byte[] tripleDesCbcNoPadCryptData)
		{
			const string __id = "encrypt3DesCbcNopad.([B[B[B[B)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_tripleDesCbcNoPadClearData = JNIEnv.NewArray (tripleDesCbcNoPadClearData);
			IntPtr native_iv = JNIEnv.NewArray (iv);
			IntPtr native_tripleDesCbcNoPadCryptData = JNIEnv.NewArray (tripleDesCbcNoPadCryptData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_tripleDesCbcNoPadClearData);
				__args [2] = new JniArgumentValue (native_iv);
				__args [3] = new JniArgumentValue (native_tripleDesCbcNoPadCryptData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (tripleDesCbcNoPadClearData != null) {
					JNIEnv.CopyArray (native_tripleDesCbcNoPadClearData, tripleDesCbcNoPadClearData);
					JNIEnv.DeleteLocalRef (native_tripleDesCbcNoPadClearData);
				}
				if (iv != null) {
					JNIEnv.CopyArray (native_iv, iv);
					JNIEnv.DeleteLocalRef (native_iv);
				}
				if (tripleDesCbcNoPadCryptData != null) {
					JNIEnv.CopyArray (native_tripleDesCbcNoPadCryptData, tripleDesCbcNoPadCryptData);
					JNIEnv.DeleteLocalRef (native_tripleDesCbcNoPadCryptData);
				}
			}
		}

		static Delegate cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetEncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler ()
		{
			if (cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ == null)
				cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, int>) n_EncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_);
			return cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
		}

		static int n_EncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_aes128CbcClearData, IntPtr native_iv, bool usePadding, IntPtr native_aes128CbcCryptedData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] aes128CbcClearData = (byte[]) JNIEnv.GetArray (native_aes128CbcClearData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] iv = (byte[]) JNIEnv.GetArray (native_iv, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var aes128CbcCryptedData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_aes128CbcCryptedData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncryptAes128Cbc (key, aes128CbcClearData, iv, usePadding, aes128CbcCryptedData);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (aes128CbcClearData != null)
				JNIEnv.CopyArray (aes128CbcClearData, native_aes128CbcClearData);
			if (iv != null)
				JNIEnv.CopyArray (iv, native_iv);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='encryptAes128Cbc' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("encryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I", "GetEncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler")]
		public virtual unsafe int EncryptAes128Cbc (byte[] key, byte[] aes128CbcClearData, byte[] iv, bool usePadding, global::System.Collections.Generic.IList<global::Java.Lang.Byte> aes128CbcCryptedData)
		{
			const string __id = "encryptAes128Cbc.([B[B[BZLjava/util/ArrayList;)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_aes128CbcClearData = JNIEnv.NewArray (aes128CbcClearData);
			IntPtr native_iv = JNIEnv.NewArray (iv);
			IntPtr native_aes128CbcCryptedData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (aes128CbcCryptedData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_aes128CbcClearData);
				__args [2] = new JniArgumentValue (native_iv);
				__args [3] = new JniArgumentValue (usePadding);
				__args [4] = new JniArgumentValue (native_aes128CbcCryptedData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (aes128CbcClearData != null) {
					JNIEnv.CopyArray (native_aes128CbcClearData, aes128CbcClearData);
					JNIEnv.DeleteLocalRef (native_aes128CbcClearData);
				}
				if (iv != null) {
					JNIEnv.CopyArray (native_iv, iv);
					JNIEnv.DeleteLocalRef (native_iv);
				}
				JNIEnv.DeleteLocalRef (native_aes128CbcCryptedData);
			}
		}

		static Delegate cb_genRandom_arrayB;
#pragma warning disable 0169
		static Delegate GetGenRandom_arrayBHandler ()
		{
			if (cb_genRandom_arrayB == null)
				cb_genRandom_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GenRandom_arrayB);
			return cb_genRandom_arrayB;
		}

		static int n_GenRandom_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_randomData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] randomData = (byte[]) JNIEnv.GetArray (native_randomData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GenRandom (randomData);
			if (randomData != null)
				JNIEnv.CopyArray (randomData, native_randomData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='genRandom' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("genRandom", "([B)I", "GetGenRandom_arrayBHandler")]
		public virtual unsafe int GenRandom (byte[] randomData)
		{
			const string __id = "genRandom.([B)I";
			IntPtr native_randomData = JNIEnv.NewArray (randomData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_randomData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (randomData != null) {
					JNIEnv.CopyArray (native_randomData, randomData);
					JNIEnv.DeleteLocalRef (native_randomData);
				}
			}
		}

		static Delegate cb_getHostCertif_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetHostCertif_Ljava_util_ArrayList_Handler ()
		{
			if (cb_getHostCertif_Ljava_util_ArrayList_ == null)
				cb_getHostCertif_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetHostCertif_Ljava_util_ArrayList_);
			return cb_getHostCertif_Ljava_util_ArrayList_;
		}

		static int n_GetHostCertif_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hostCertificate)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var hostCertificate = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_hostCertificate, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetHostCertif (hostCertificate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='getHostCertif' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("getHostCertif", "(Ljava/util/ArrayList;)I", "GetGetHostCertif_Ljava_util_ArrayList_Handler")]
		public virtual unsafe int GetHostCertif (global::System.Collections.Generic.IList<global::Java.Lang.Byte> hostCertificate)
		{
			const string __id = "getHostCertif.(Ljava/util/ArrayList;)I";
			IntPtr native_hostCertificate = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (hostCertificate);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hostCertificate);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_hostCertificate);
			}
		}

		static Delegate cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetRsaEncrypt_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RsaEncrypt_arrayBarrayBLjava_util_ArrayList_);
			return cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_RsaEncrypt_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate, IntPtr native_rsaClearData, IntPtr native_rsaCryptData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] certificate = (byte[]) JNIEnv.GetArray (native_certificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] rsaClearData = (byte[]) JNIEnv.GetArray (native_rsaClearData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var rsaCryptData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_rsaCryptData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RsaEncrypt (certificate, rsaClearData, rsaCryptData);
			if (certificate != null)
				JNIEnv.CopyArray (certificate, native_certificate);
			if (rsaClearData != null)
				JNIEnv.CopyArray (rsaClearData, native_rsaClearData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='rsaEncrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("rsaEncrypt", "([B[BLjava/util/ArrayList;)I", "GetRsaEncrypt_arrayBarrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int RsaEncrypt (byte[] certificate, byte[] rsaClearData, global::System.Collections.Generic.IList<global::Java.Lang.Byte> rsaCryptData)
		{
			const string __id = "rsaEncrypt.([B[BLjava/util/ArrayList;)I";
			IntPtr native_certificate = JNIEnv.NewArray (certificate);
			IntPtr native_rsaClearData = JNIEnv.NewArray (rsaClearData);
			IntPtr native_rsaCryptData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (rsaCryptData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_certificate);
				__args [1] = new JniArgumentValue (native_rsaClearData);
				__args [2] = new JniArgumentValue (native_rsaCryptData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (certificate != null) {
					JNIEnv.CopyArray (native_certificate, certificate);
					JNIEnv.DeleteLocalRef (native_certificate);
				}
				if (rsaClearData != null) {
					JNIEnv.CopyArray (native_rsaClearData, rsaClearData);
					JNIEnv.DeleteLocalRef (native_rsaClearData);
				}
				JNIEnv.DeleteLocalRef (native_rsaCryptData);
			}
		}

		static Delegate cb_setOpenSSLPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpenSSLPath_Ljava_lang_String_Handler ()
		{
			if (cb_setOpenSSLPath_Ljava_lang_String_ == null)
				cb_setOpenSSLPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetOpenSSLPath_Ljava_lang_String_);
			return cb_setOpenSSLPath_Ljava_lang_String_;
		}

		static int n_SetOpenSSLPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_openSSLPath)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string openSSLPath = JNIEnv.GetString (native_openSSLPath, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetOpenSSLPath (openSSLPath);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='setOpenSSLPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOpenSSLPath", "(Ljava/lang/String;)I", "GetSetOpenSSLPath_Ljava_lang_String_Handler")]
		public virtual unsafe int SetOpenSSLPath (string openSSLPath)
		{
			const string __id = "setOpenSSLPath.(Ljava/lang/String;)I";
			IntPtr native_openSSLPath = JNIEnv.NewString (openSSLPath);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_openSSLPath);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_openSSLPath);
			}
		}

		static Delegate cb_signRSA_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSignRSA_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_signRSA_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_signRSA_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SignRSA_arrayBarrayBLjava_util_ArrayList_);
			return cb_signRSA_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_SignRSA_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_rsaDataToSign, IntPtr native_rsaSignature)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] rsaDataToSign = (byte[]) JNIEnv.GetArray (native_rsaDataToSign, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var rsaSignature = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_rsaSignature, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SignRSA (key, rsaDataToSign, rsaSignature);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (rsaDataToSign != null)
				JNIEnv.CopyArray (rsaDataToSign, native_rsaDataToSign);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='signRSA' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("signRSA", "([B[BLjava/util/ArrayList;)I", "GetSignRSA_arrayBarrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int SignRSA (byte[] key, byte[] rsaDataToSign, global::System.Collections.Generic.IList<global::Java.Lang.Byte> rsaSignature)
		{
			const string __id = "signRSA.([B[BLjava/util/ArrayList;)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_rsaDataToSign = JNIEnv.NewArray (rsaDataToSign);
			IntPtr native_rsaSignature = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (rsaSignature);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_rsaDataToSign);
				__args [2] = new JniArgumentValue (native_rsaSignature);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (rsaDataToSign != null) {
					JNIEnv.CopyArray (native_rsaDataToSign, rsaDataToSign);
					JNIEnv.DeleteLocalRef (native_rsaDataToSign);
				}
				JNIEnv.DeleteLocalRef (native_rsaSignature);
			}
		}

		static Delegate cb_tripleDesCrypt_arrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesCrypt_arrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesCrypt_arrayBLjava_util_ArrayList_ == null)
				cb_tripleDesCrypt_arrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesCrypt_arrayBLjava_util_ArrayList_);
			return cb_tripleDesCrypt_arrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesCrypt_arrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tripleDesClearData, IntPtr native_tripleDesCryptData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] tripleDesClearData = (byte[]) JNIEnv.GetArray (native_tripleDesClearData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var tripleDesCryptData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_tripleDesCryptData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesCrypt (tripleDesClearData, tripleDesCryptData);
			if (tripleDesClearData != null)
				JNIEnv.CopyArray (tripleDesClearData, native_tripleDesClearData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tripleDesCrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesCrypt", "([BLjava/util/ArrayList;)I", "GetTripleDesCrypt_arrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int TripleDesCrypt (byte[] tripleDesClearData, global::System.Collections.Generic.IList<global::Java.Lang.Byte> tripleDesCryptData)
		{
			const string __id = "tripleDesCrypt.([BLjava/util/ArrayList;)I";
			IntPtr native_tripleDesClearData = JNIEnv.NewArray (tripleDesClearData);
			IntPtr native_tripleDesCryptData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (tripleDesCryptData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tripleDesClearData);
				__args [1] = new JniArgumentValue (native_tripleDesCryptData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (tripleDesClearData != null) {
					JNIEnv.CopyArray (native_tripleDesClearData, tripleDesClearData);
					JNIEnv.DeleteLocalRef (native_tripleDesClearData);
				}
				JNIEnv.DeleteLocalRef (native_tripleDesCryptData);
			}
		}

		static Delegate cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_);
			return cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_tripleDesClearData, IntPtr native_tripleDesCryptDataByKey)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] key = (byte[]) JNIEnv.GetArray (native_key, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] tripleDesClearData = (byte[]) JNIEnv.GetArray (native_tripleDesClearData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var tripleDesCryptDataByKey = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_tripleDesCryptDataByKey, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesCryptByKey (key, tripleDesClearData, tripleDesCryptDataByKey);
			if (key != null)
				JNIEnv.CopyArray (key, native_key);
			if (tripleDesClearData != null)
				JNIEnv.CopyArray (tripleDesClearData, native_tripleDesClearData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tripleDesCryptByKey' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesCryptByKey", "([B[BLjava/util/ArrayList;)I", "GetTripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int TripleDesCryptByKey (byte[] key, byte[] tripleDesClearData, global::System.Collections.Generic.IList<global::Java.Lang.Byte> tripleDesCryptDataByKey)
		{
			const string __id = "tripleDesCryptByKey.([B[BLjava/util/ArrayList;)I";
			IntPtr native_key = JNIEnv.NewArray (key);
			IntPtr native_tripleDesClearData = JNIEnv.NewArray (tripleDesClearData);
			IntPtr native_tripleDesCryptDataByKey = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (tripleDesCryptDataByKey);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_tripleDesClearData);
				__args [2] = new JniArgumentValue (native_tripleDesCryptDataByKey);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (key != null) {
					JNIEnv.CopyArray (native_key, key);
					JNIEnv.DeleteLocalRef (native_key);
				}
				if (tripleDesClearData != null) {
					JNIEnv.CopyArray (native_tripleDesClearData, tripleDesClearData);
					JNIEnv.DeleteLocalRef (native_tripleDesClearData);
				}
				JNIEnv.DeleteLocalRef (native_tripleDesCryptDataByKey);
			}
		}

		static Delegate cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesDecrypt_arrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_ == null)
				cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesDecrypt_arrayBLjava_util_ArrayList_);
			return cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesDecrypt_arrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tripleDesCryptData, IntPtr native_tripleDesClearData)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] tripleDesCryptData = (byte[]) JNIEnv.GetArray (native_tripleDesCryptData, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var tripleDesClearData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_tripleDesClearData, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesDecrypt (tripleDesCryptData, tripleDesClearData);
			if (tripleDesCryptData != null)
				JNIEnv.CopyArray (tripleDesCryptData, native_tripleDesCryptData);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tripleDesDecrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesDecrypt", "([BLjava/util/ArrayList;)I", "GetTripleDesDecrypt_arrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int TripleDesDecrypt (byte[] tripleDesCryptData, global::System.Collections.Generic.IList<global::Java.Lang.Byte> tripleDesClearData)
		{
			const string __id = "tripleDesDecrypt.([BLjava/util/ArrayList;)I";
			IntPtr native_tripleDesCryptData = JNIEnv.NewArray (tripleDesCryptData);
			IntPtr native_tripleDesClearData = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (tripleDesClearData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tripleDesCryptData);
				__args [1] = new JniArgumentValue (native_tripleDesClearData);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (tripleDesCryptData != null) {
					JNIEnv.CopyArray (native_tripleDesCryptData, tripleDesCryptData);
					JNIEnv.DeleteLocalRef (native_tripleDesCryptData);
				}
				JNIEnv.DeleteLocalRef (native_tripleDesClearData);
			}
		}

		static Delegate cb_tripleDesSign_arrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesSign_arrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesSign_arrayBLjava_util_ArrayList_ == null)
				cb_tripleDesSign_arrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesSign_arrayBLjava_util_ArrayList_);
			return cb_tripleDesSign_arrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesSign_arrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tripleDesDataToSign, IntPtr native_tripleDesSignature)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] tripleDesDataToSign = (byte[]) JNIEnv.GetArray (native_tripleDesDataToSign, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var tripleDesSignature = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_tripleDesSignature, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesSign (tripleDesDataToSign, tripleDesSignature);
			if (tripleDesDataToSign != null)
				JNIEnv.CopyArray (tripleDesDataToSign, native_tripleDesDataToSign);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tripleDesSign' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesSign", "([BLjava/util/ArrayList;)I", "GetTripleDesSign_arrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int TripleDesSign (byte[] tripleDesDataToSign, global::System.Collections.Generic.IList<global::Java.Lang.Byte> tripleDesSignature)
		{
			const string __id = "tripleDesSign.([BLjava/util/ArrayList;)I";
			IntPtr native_tripleDesDataToSign = JNIEnv.NewArray (tripleDesDataToSign);
			IntPtr native_tripleDesSignature = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (tripleDesSignature);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tripleDesDataToSign);
				__args [1] = new JniArgumentValue (native_tripleDesSignature);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (tripleDesDataToSign != null) {
					JNIEnv.CopyArray (native_tripleDesDataToSign, tripleDesDataToSign);
					JNIEnv.DeleteLocalRef (native_tripleDesDataToSign);
				}
				JNIEnv.DeleteLocalRef (native_tripleDesSignature);
			}
		}

		static Delegate cb_tripleDesVerifSign_arrayBarrayBarrayZ;
#pragma warning disable 0169
		static Delegate GetTripleDesVerifSign_arrayBarrayBarrayZHandler ()
		{
			if (cb_tripleDesVerifSign_arrayBarrayBarrayZ == null)
				cb_tripleDesVerifSign_arrayBarrayBarrayZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesVerifSign_arrayBarrayBarrayZ);
			return cb_tripleDesVerifSign_arrayBarrayBarrayZ;
		}

		static int n_TripleDesVerifSign_arrayBarrayBarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_tripleDesDataToVerifSign, IntPtr native_tripleDesDataSignature, IntPtr native_tripleDesSignVerifResult)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] tripleDesDataToVerifSign = (byte[]) JNIEnv.GetArray (native_tripleDesDataToVerifSign, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] tripleDesDataSignature = (byte[]) JNIEnv.GetArray (native_tripleDesDataSignature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool[] tripleDesSignVerifResult = (bool[]) JNIEnv.GetArray (native_tripleDesSignVerifResult, JniHandleOwnership.DoNotTransfer, typeof (bool));
			int __ret = __this.TripleDesVerifSign (tripleDesDataToVerifSign, tripleDesDataSignature, tripleDesSignVerifResult);
			if (tripleDesDataToVerifSign != null)
				JNIEnv.CopyArray (tripleDesDataToVerifSign, native_tripleDesDataToVerifSign);
			if (tripleDesDataSignature != null)
				JNIEnv.CopyArray (tripleDesDataSignature, native_tripleDesDataSignature);
			if (tripleDesSignVerifResult != null)
				JNIEnv.CopyArray (tripleDesSignVerifResult, native_tripleDesSignVerifResult);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tripleDesVerifSign' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean[]']]"
		[Register ("tripleDesVerifSign", "([B[B[Z)I", "GetTripleDesVerifSign_arrayBarrayBarrayZHandler")]
		public virtual unsafe int TripleDesVerifSign (byte[] tripleDesDataToVerifSign, byte[] tripleDesDataSignature, bool[] tripleDesSignVerifResult)
		{
			const string __id = "tripleDesVerifSign.([B[B[Z)I";
			IntPtr native_tripleDesDataToVerifSign = JNIEnv.NewArray (tripleDesDataToVerifSign);
			IntPtr native_tripleDesDataSignature = JNIEnv.NewArray (tripleDesDataSignature);
			IntPtr native_tripleDesSignVerifResult = JNIEnv.NewArray (tripleDesSignVerifResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_tripleDesDataToVerifSign);
				__args [1] = new JniArgumentValue (native_tripleDesDataSignature);
				__args [2] = new JniArgumentValue (native_tripleDesSignVerifResult);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (tripleDesDataToVerifSign != null) {
					JNIEnv.CopyArray (native_tripleDesDataToVerifSign, tripleDesDataToVerifSign);
					JNIEnv.DeleteLocalRef (native_tripleDesDataToVerifSign);
				}
				if (tripleDesDataSignature != null) {
					JNIEnv.CopyArray (native_tripleDesDataSignature, tripleDesDataSignature);
					JNIEnv.DeleteLocalRef (native_tripleDesDataSignature);
				}
				if (tripleDesSignVerifResult != null) {
					JNIEnv.CopyArray (native_tripleDesSignVerifResult, tripleDesSignVerifResult);
					JNIEnv.DeleteLocalRef (native_tripleDesSignVerifResult);
				}
			}
		}

		static Delegate cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ == null)
				cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_);
			return cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_;
		}

		static int n_TunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenMso, IntPtr native_msoCertificate, IntPtr native_msoHash, IntPtr native_hostHash, IntPtr native_tokenHostMso)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] tokenMso = (byte[]) JNIEnv.GetArray (native_tokenMso, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] msoCertificate = (byte[]) JNIEnv.GetArray (native_msoCertificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] msoHash = (byte[]) JNIEnv.GetArray (native_msoHash, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] hostHash = (byte[]) JNIEnv.GetArray (native_hostHash, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var tokenHostMso = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_tokenHostMso, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TunnelingInit1 (tokenMso, msoCertificate, msoHash, hostHash, tokenHostMso);
			if (tokenMso != null)
				JNIEnv.CopyArray (tokenMso, native_tokenMso);
			if (msoCertificate != null)
				JNIEnv.CopyArray (msoCertificate, native_msoCertificate);
			if (msoHash != null)
				JNIEnv.CopyArray (msoHash, native_msoHash);
			if (hostHash != null)
				JNIEnv.CopyArray (hostHash, native_hostHash);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tunnelingInit1' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tunnelingInit1", "([B[B[B[BLjava/util/ArrayList;)I", "GetTunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_Handler")]
		public virtual unsafe int TunnelingInit1 (byte[] tokenMso, byte[] msoCertificate, byte[] msoHash, byte[] hostHash, global::System.Collections.Generic.IList<global::Java.Lang.Byte> tokenHostMso)
		{
			const string __id = "tunnelingInit1.([B[B[B[BLjava/util/ArrayList;)I";
			IntPtr native_tokenMso = JNIEnv.NewArray (tokenMso);
			IntPtr native_msoCertificate = JNIEnv.NewArray (msoCertificate);
			IntPtr native_msoHash = JNIEnv.NewArray (msoHash);
			IntPtr native_hostHash = JNIEnv.NewArray (hostHash);
			IntPtr native_tokenHostMso = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (tokenHostMso);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_tokenMso);
				__args [1] = new JniArgumentValue (native_msoCertificate);
				__args [2] = new JniArgumentValue (native_msoHash);
				__args [3] = new JniArgumentValue (native_hostHash);
				__args [4] = new JniArgumentValue (native_tokenHostMso);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (tokenMso != null) {
					JNIEnv.CopyArray (native_tokenMso, tokenMso);
					JNIEnv.DeleteLocalRef (native_tokenMso);
				}
				if (msoCertificate != null) {
					JNIEnv.CopyArray (native_msoCertificate, msoCertificate);
					JNIEnv.DeleteLocalRef (native_msoCertificate);
				}
				if (msoHash != null) {
					JNIEnv.CopyArray (native_msoHash, msoHash);
					JNIEnv.DeleteLocalRef (native_msoHash);
				}
				if (hostHash != null) {
					JNIEnv.CopyArray (native_hostHash, hostHash);
					JNIEnv.DeleteLocalRef (native_hostHash);
				}
				JNIEnv.DeleteLocalRef (native_tokenHostMso);
			}
		}

		static Delegate cb_tunnelingInit2_arrayB;
#pragma warning disable 0169
		static Delegate GetTunnelingInit2_arrayBHandler ()
		{
			if (cb_tunnelingInit2_arrayB == null)
				cb_tunnelingInit2_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_TunnelingInit2_arrayB);
			return cb_tunnelingInit2_arrayB;
		}

		static int n_TunnelingInit2_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_tokenMso)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] tokenMso = (byte[]) JNIEnv.GetArray (native_tokenMso, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TunnelingInit2 (tokenMso);
			if (tokenMso != null)
				JNIEnv.CopyArray (tokenMso, native_tokenMso);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='tunnelingInit2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("tunnelingInit2", "([B)I", "GetTunnelingInit2_arrayBHandler")]
		public virtual unsafe int TunnelingInit2 (byte[] tokenMso)
		{
			const string __id = "tunnelingInit2.([B)I";
			IntPtr native_tokenMso = JNIEnv.NewArray (tokenMso);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tokenMso);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (tokenMso != null) {
					JNIEnv.CopyArray (native_tokenMso, tokenMso);
					JNIEnv.DeleteLocalRef (native_tokenMso);
				}
			}
		}

		static Delegate cb_verifCertif_arrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifCertif_arrayBarrayIHandler ()
		{
			if (cb_verifCertif_arrayBarrayI == null)
				cb_verifCertif_arrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifCertif_arrayBarrayI);
			return cb_verifCertif_arrayBarrayI;
		}

		static int n_VerifCertif_arrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_certificate, IntPtr native_certVerifResult)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] certificate = (byte[]) JNIEnv.GetArray (native_certificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] certVerifResult = (int[]) JNIEnv.GetArray (native_certVerifResult, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifCertif (certificate, certVerifResult);
			if (certificate != null)
				JNIEnv.CopyArray (certificate, native_certificate);
			if (certVerifResult != null)
				JNIEnv.CopyArray (certVerifResult, native_certVerifResult);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='verifCertif' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
		[Register ("verifCertif", "([B[I)I", "GetVerifCertif_arrayBarrayIHandler")]
		public virtual unsafe int VerifCertif (byte[] certificate, int[] certVerifResult)
		{
			const string __id = "verifCertif.([B[I)I";
			IntPtr native_certificate = JNIEnv.NewArray (certificate);
			IntPtr native_certVerifResult = JNIEnv.NewArray (certVerifResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_certificate);
				__args [1] = new JniArgumentValue (native_certVerifResult);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (certificate != null) {
					JNIEnv.CopyArray (native_certificate, certificate);
					JNIEnv.DeleteLocalRef (native_certificate);
				}
				if (certVerifResult != null) {
					JNIEnv.CopyArray (native_certVerifResult, certVerifResult);
					JNIEnv.DeleteLocalRef (native_certVerifResult);
				}
			}
		}

		static Delegate cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifOfferedSecuritySignature_arrayBarrayBarrayBarrayIHandler ()
		{
			if (cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI == null)
				cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifOfferedSecuritySignature_arrayBarrayBarrayBarrayI);
			return cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI;
		}

		static int n_VerifOfferedSecuritySignature_arrayBarrayBarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_msoCertificate, IntPtr native_signature, IntPtr native_dataToVerifSign, IntPtr native_signVerifResult)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] msoCertificate = (byte[]) JNIEnv.GetArray (native_msoCertificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] signature = (byte[]) JNIEnv.GetArray (native_signature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] dataToVerifSign = (byte[]) JNIEnv.GetArray (native_dataToVerifSign, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] signVerifResult = (int[]) JNIEnv.GetArray (native_signVerifResult, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifOfferedSecuritySignature (msoCertificate, signature, dataToVerifSign, signVerifResult);
			if (msoCertificate != null)
				JNIEnv.CopyArray (msoCertificate, native_msoCertificate);
			if (signature != null)
				JNIEnv.CopyArray (signature, native_signature);
			if (dataToVerifSign != null)
				JNIEnv.CopyArray (dataToVerifSign, native_dataToVerifSign);
			if (signVerifResult != null)
				JNIEnv.CopyArray (signVerifResult, native_signVerifResult);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='verifOfferedSecuritySignature' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifOfferedSecuritySignature", "([B[B[B[I)I", "GetVerifOfferedSecuritySignature_arrayBarrayBarrayBarrayIHandler")]
		public virtual unsafe int VerifOfferedSecuritySignature (byte[] msoCertificate, byte[] signature, byte[] dataToVerifSign, int[] signVerifResult)
		{
			const string __id = "verifOfferedSecuritySignature.([B[B[B[I)I";
			IntPtr native_msoCertificate = JNIEnv.NewArray (msoCertificate);
			IntPtr native_signature = JNIEnv.NewArray (signature);
			IntPtr native_dataToVerifSign = JNIEnv.NewArray (dataToVerifSign);
			IntPtr native_signVerifResult = JNIEnv.NewArray (signVerifResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_msoCertificate);
				__args [1] = new JniArgumentValue (native_signature);
				__args [2] = new JniArgumentValue (native_dataToVerifSign);
				__args [3] = new JniArgumentValue (native_signVerifResult);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (msoCertificate != null) {
					JNIEnv.CopyArray (native_msoCertificate, msoCertificate);
					JNIEnv.DeleteLocalRef (native_msoCertificate);
				}
				if (signature != null) {
					JNIEnv.CopyArray (native_signature, signature);
					JNIEnv.DeleteLocalRef (native_signature);
				}
				if (dataToVerifSign != null) {
					JNIEnv.CopyArray (native_dataToVerifSign, dataToVerifSign);
					JNIEnv.DeleteLocalRef (native_dataToVerifSign);
				}
				if (signVerifResult != null) {
					JNIEnv.CopyArray (native_signVerifResult, signVerifResult);
					JNIEnv.DeleteLocalRef (native_signVerifResult);
				}
			}
		}

		static Delegate cb_verifSignDSA_arrayBarrayBarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifSignDSA_arrayBarrayBarrayBarrayIHandler ()
		{
			if (cb_verifSignDSA_arrayBarrayBarrayBarrayI == null)
				cb_verifSignDSA_arrayBarrayBarrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifSignDSA_arrayBarrayBarrayBarrayI);
			return cb_verifSignDSA_arrayBarrayBarrayBarrayI;
		}

		static int n_VerifSignDSA_arrayBarrayBarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_msoCertificate, IntPtr native_signature, IntPtr native_dataToVerifSign, IntPtr native_signVerifResult)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] msoCertificate = (byte[]) JNIEnv.GetArray (native_msoCertificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] signature = (byte[]) JNIEnv.GetArray (native_signature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] dataToVerifSign = (byte[]) JNIEnv.GetArray (native_dataToVerifSign, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] signVerifResult = (int[]) JNIEnv.GetArray (native_signVerifResult, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifSignDSA (msoCertificate, signature, dataToVerifSign, signVerifResult);
			if (msoCertificate != null)
				JNIEnv.CopyArray (msoCertificate, native_msoCertificate);
			if (signature != null)
				JNIEnv.CopyArray (signature, native_signature);
			if (dataToVerifSign != null)
				JNIEnv.CopyArray (dataToVerifSign, native_dataToVerifSign);
			if (signVerifResult != null)
				JNIEnv.CopyArray (signVerifResult, native_signVerifResult);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='verifSignDSA' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifSignDSA", "([B[B[B[I)I", "GetVerifSignDSA_arrayBarrayBarrayBarrayIHandler")]
		public virtual unsafe int VerifSignDSA (byte[] msoCertificate, byte[] signature, byte[] dataToVerifSign, int[] signVerifResult)
		{
			const string __id = "verifSignDSA.([B[B[B[I)I";
			IntPtr native_msoCertificate = JNIEnv.NewArray (msoCertificate);
			IntPtr native_signature = JNIEnv.NewArray (signature);
			IntPtr native_dataToVerifSign = JNIEnv.NewArray (dataToVerifSign);
			IntPtr native_signVerifResult = JNIEnv.NewArray (signVerifResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_msoCertificate);
				__args [1] = new JniArgumentValue (native_signature);
				__args [2] = new JniArgumentValue (native_dataToVerifSign);
				__args [3] = new JniArgumentValue (native_signVerifResult);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (msoCertificate != null) {
					JNIEnv.CopyArray (native_msoCertificate, msoCertificate);
					JNIEnv.DeleteLocalRef (native_msoCertificate);
				}
				if (signature != null) {
					JNIEnv.CopyArray (native_signature, signature);
					JNIEnv.DeleteLocalRef (native_signature);
				}
				if (dataToVerifSign != null) {
					JNIEnv.CopyArray (native_dataToVerifSign, dataToVerifSign);
					JNIEnv.DeleteLocalRef (native_dataToVerifSign);
				}
				if (signVerifResult != null) {
					JNIEnv.CopyArray (native_signVerifResult, signVerifResult);
					JNIEnv.DeleteLocalRef (native_signVerifResult);
				}
			}
		}

		static Delegate cb_verifSignRSA_arrayBarrayBarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifSignRSA_arrayBarrayBarrayBarrayIHandler ()
		{
			if (cb_verifSignRSA_arrayBarrayBarrayBarrayI == null)
				cb_verifSignRSA_arrayBarrayBarrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifSignRSA_arrayBarrayBarrayBarrayI);
			return cb_verifSignRSA_arrayBarrayBarrayBarrayI;
		}

		static int n_VerifSignRSA_arrayBarrayBarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_msoCertificate, IntPtr native_signature, IntPtr native_dataToVerifSign, IntPtr native_signVerifResult)
		{
			global::Morpho.Msosecu.Sdk.Api.MsoSecu __this = global::Java.Lang.Object.GetObject<global::Morpho.Msosecu.Sdk.Api.MsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] msoCertificate = (byte[]) JNIEnv.GetArray (native_msoCertificate, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] signature = (byte[]) JNIEnv.GetArray (native_signature, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] dataToVerifSign = (byte[]) JNIEnv.GetArray (native_dataToVerifSign, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] signVerifResult = (int[]) JNIEnv.GetArray (native_signVerifResult, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifSignRSA (msoCertificate, signature, dataToVerifSign, signVerifResult);
			if (msoCertificate != null)
				JNIEnv.CopyArray (msoCertificate, native_msoCertificate);
			if (signature != null)
				JNIEnv.CopyArray (signature, native_signature);
			if (dataToVerifSign != null)
				JNIEnv.CopyArray (dataToVerifSign, native_dataToVerifSign);
			if (signVerifResult != null)
				JNIEnv.CopyArray (signVerifResult, native_signVerifResult);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='morpho.msosecu.sdk.api']/class[@name='MsoSecu']/method[@name='verifSignRSA' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifSignRSA", "([B[B[B[I)I", "GetVerifSignRSA_arrayBarrayBarrayBarrayIHandler")]
		public virtual unsafe int VerifSignRSA (byte[] msoCertificate, byte[] signature, byte[] dataToVerifSign, int[] signVerifResult)
		{
			const string __id = "verifSignRSA.([B[B[B[I)I";
			IntPtr native_msoCertificate = JNIEnv.NewArray (msoCertificate);
			IntPtr native_signature = JNIEnv.NewArray (signature);
			IntPtr native_dataToVerifSign = JNIEnv.NewArray (dataToVerifSign);
			IntPtr native_signVerifResult = JNIEnv.NewArray (signVerifResult);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_msoCertificate);
				__args [1] = new JniArgumentValue (native_signature);
				__args [2] = new JniArgumentValue (native_dataToVerifSign);
				__args [3] = new JniArgumentValue (native_signVerifResult);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (msoCertificate != null) {
					JNIEnv.CopyArray (native_msoCertificate, msoCertificate);
					JNIEnv.DeleteLocalRef (native_msoCertificate);
				}
				if (signature != null) {
					JNIEnv.CopyArray (native_signature, signature);
					JNIEnv.DeleteLocalRef (native_signature);
				}
				if (dataToVerifSign != null) {
					JNIEnv.CopyArray (native_dataToVerifSign, dataToVerifSign);
					JNIEnv.DeleteLocalRef (native_dataToVerifSign);
				}
				if (signVerifResult != null) {
					JNIEnv.CopyArray (native_signVerifResult, signVerifResult);
					JNIEnv.DeleteLocalRef (native_signVerifResult);
				}
			}
		}

	}
}
