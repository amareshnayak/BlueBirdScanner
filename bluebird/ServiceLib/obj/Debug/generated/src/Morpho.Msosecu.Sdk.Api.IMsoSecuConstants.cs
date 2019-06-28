using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Morpho.Msosecu.Sdk.Api {

	[Register ("morpho/msosecu/sdk/api/MsoSecuConstants", DoNotGenerateAcw=true)]
	public abstract class MsoSecuConstants : Java.Lang.Object {

		internal MsoSecuConstants ()
		{
		}


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

		new static JniPeerMembers _members = new JniPeerMembers ("morpho/msosecu/sdk/api/MsoSecuConstants", typeof (MsoSecuConstants));
	}

	[Register ("morpho/msosecu/sdk/api/MsoSecuConstants", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'MsoSecuConstants' type. This type will be removed in a future release.")]
	public abstract class MsoSecuConstantsConsts : MsoSecuConstants {

		private MsoSecuConstantsConsts ()
		{
		}
	}

}
