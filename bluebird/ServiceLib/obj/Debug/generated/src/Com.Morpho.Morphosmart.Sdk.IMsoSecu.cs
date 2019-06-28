using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']"
	[Register ("com/morpho/morphosmart/sdk/IMsoSecu", "", "Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker")]
	public partial interface IMsoSecu : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='computeCRC32' and count(parameter)=7 and parameter[1][@type='byte[]'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='long'] and parameter[7][@type='long[]']]"
		[Register ("computeCRC32", "([BJJZZJ[J)I", "GetComputeCRC32_arrayBJJZZJarrayJHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int ComputeCRC32 (byte[] p0, long p1, long p2, bool p3, bool p4, long p5, long[] p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='decryptAes128Cbc' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("decryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I", "GetDecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int DecryptAes128Cbc (byte[] p0, byte[] p1, byte[] p2, bool p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='desCrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("desCrypt", "([B[BLjava/util/ArrayList;)I", "GetDesCrypt_arrayBarrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int DesCrypt (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='encrypt3DesCbcNopad' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]']]"
		[Register ("encrypt3DesCbcNopad", "([B[B[B[B)I", "GetEncrypt3DesCbcNopad_arrayBarrayBarrayBarrayBHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int Encrypt3DesCbcNopad (byte[] p0, byte[] p1, byte[] p2, byte[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='encryptAes128Cbc' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("encryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I", "GetEncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int EncryptAes128Cbc (byte[] p0, byte[] p1, byte[] p2, bool p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='genRandom' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("genRandom", "([B)I", "GetGenRandom_arrayBHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int GenRandom (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='getHostCertif' and count(parameter)=1 and parameter[1][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("getHostCertif", "(Ljava/util/ArrayList;)I", "GetGetHostCertif_Ljava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int GetHostCertif (global::System.Collections.Generic.IList<global::Java.Lang.Byte> p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='rsaEncrypt' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("rsaEncrypt", "([B[BLjava/util/ArrayList;)I", "GetRsaEncrypt_arrayBarrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int RsaEncrypt (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='setOpenSSLPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setOpenSSLPath", "(Ljava/lang/String;)I", "GetSetOpenSSLPath_Ljava_lang_String_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int SetOpenSSLPath (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='signRSA' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("signRSA", "([B[BLjava/util/ArrayList;)I", "GetSignRSA_arrayBarrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int SignRSA (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tripleDesCrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesCrypt", "([BLjava/util/ArrayList;)I", "GetTripleDesCrypt_arrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TripleDesCrypt (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tripleDesCryptByKey' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesCryptByKey", "([B[BLjava/util/ArrayList;)I", "GetTripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TripleDesCryptByKey (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tripleDesDecrypt' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesDecrypt", "([BLjava/util/ArrayList;)I", "GetTripleDesDecrypt_arrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TripleDesDecrypt (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tripleDesSign' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tripleDesSign", "([BLjava/util/ArrayList;)I", "GetTripleDesSign_arrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TripleDesSign (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tripleDesVerifSign' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='boolean[]']]"
		[Register ("tripleDesVerifSign", "([B[B[Z)I", "GetTripleDesVerifSign_arrayBarrayBarrayZHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TripleDesVerifSign (byte[] p0, byte[] p1, bool[] p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tunnelingInit1' and count(parameter)=5 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='byte[]'] and parameter[5][@type='java.util.ArrayList&lt;java.lang.Byte&gt;']]"
		[Register ("tunnelingInit1", "([B[B[B[BLjava/util/ArrayList;)I", "GetTunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_Handler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TunnelingInit1 (byte[] p0, byte[] p1, byte[] p2, byte[] p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='tunnelingInit2' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("tunnelingInit2", "([B)I", "GetTunnelingInit2_arrayBHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int TunnelingInit2 (byte[] p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='verifCertif' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='int[]']]"
		[Register ("verifCertif", "([B[I)I", "GetVerifCertif_arrayBarrayIHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int VerifCertif (byte[] p0, int[] p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='verifOfferedSecuritySignature' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifOfferedSecuritySignature", "([B[B[B[I)I", "GetVerifOfferedSecuritySignature_arrayBarrayBarrayBarrayIHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int VerifOfferedSecuritySignature (byte[] p0, byte[] p1, byte[] p2, int[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='verifSignDSA' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifSignDSA", "([B[B[B[I)I", "GetVerifSignDSA_arrayBarrayBarrayBarrayIHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int VerifSignDSA (byte[] p0, byte[] p1, byte[] p2, int[] p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/interface[@name='IMsoSecu']/method[@name='verifSignRSA' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='byte[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='int[]']]"
		[Register ("verifSignRSA", "([B[B[B[I)I", "GetVerifSignRSA_arrayBarrayBarrayBarrayIHandler:Com.Morpho.Morphosmart.Sdk.IMsoSecuInvoker, ServiceLib")]
		int VerifSignRSA (byte[] p0, byte[] p1, byte[] p2, int[] p3);

	}

	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/IMsoSecu", DoNotGenerateAcw=true)]
	internal class IMsoSecuInvoker : global::Java.Lang.Object, IMsoSecu {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/morpho/morphosmart/sdk/IMsoSecu", typeof (IMsoSecuInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IMsoSecu GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMsoSecu> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.morpho.morphosmart.sdk.IMsoSecu"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMsoSecuInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_computeCRC32_arrayBJJZZJarrayJ;
#pragma warning disable 0169
		static Delegate GetComputeCRC32_arrayBJJZZJarrayJHandler ()
		{
			if (cb_computeCRC32_arrayBJJZZJarrayJ == null)
				cb_computeCRC32_arrayBJJZZJarrayJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long, long, bool, bool, long, IntPtr, int>) n_ComputeCRC32_arrayBJJZZJarrayJ);
			return cb_computeCRC32_arrayBJJZZJarrayJ;
		}

		static int n_ComputeCRC32_arrayBJJZZJarrayJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, long p1, long p2, bool p3, bool p4, long p5, IntPtr native_p6)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			long[] p6 = (long[]) JNIEnv.GetArray (native_p6, JniHandleOwnership.DoNotTransfer, typeof (long));
			int __ret = __this.ComputeCRC32 (p0, p1, p2, p3, p4, p5, p6);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p6 != null)
				JNIEnv.CopyArray (p6, native_p6);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_computeCRC32_arrayBJJZZJarrayJ;
		public unsafe int ComputeCRC32 (byte[] p0, long p1, long p2, bool p3, bool p4, long p5, long[] p6)
		{
			if (id_computeCRC32_arrayBJJZZJarrayJ == IntPtr.Zero)
				id_computeCRC32_arrayBJJZZJarrayJ = JNIEnv.GetMethodID (class_ref, "computeCRC32", "([BJJZZJ[J)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p6 = JNIEnv.NewArray (p6);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue (p5);
			__args [6] = new JValue (native_p6);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_computeCRC32_arrayBJJZZJarrayJ, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p6 != null) {
				JNIEnv.CopyArray (native_p6, p6);
				JNIEnv.DeleteLocalRef (native_p6);
			}
			return __ret;
		}

		static Delegate cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetDecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler ()
		{
			if (cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ == null)
				cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, int>) n_DecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_);
			return cb_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
		}

		static int n_DecryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, IntPtr native_p4)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecryptAes128Cbc (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
		public unsafe int DecryptAes128Cbc (byte[] p0, byte[] p1, byte[] p2, bool p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4)
		{
			if (id_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ == IntPtr.Zero)
				id_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "decryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_decryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_, __args);
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
			return __ret;
		}

		static Delegate cb_desCrypt_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetDesCrypt_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_desCrypt_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_desCrypt_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_DesCrypt_arrayBarrayBLjava_util_ArrayList_);
			return cb_desCrypt_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_DesCrypt_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DesCrypt (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_desCrypt_arrayBarrayBLjava_util_ArrayList_;
		public unsafe int DesCrypt (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			if (id_desCrypt_arrayBarrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_desCrypt_arrayBarrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "desCrypt", "([B[BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_desCrypt_arrayBarrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB;
#pragma warning disable 0169
		static Delegate GetEncrypt3DesCbcNopad_arrayBarrayBarrayBarrayBHandler ()
		{
			if (cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB == null)
				cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB);
			return cb_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB;
		}

		static int n_Encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Encrypt3DesCbcNopad (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB;
		public unsafe int Encrypt3DesCbcNopad (byte[] p0, byte[] p1, byte[] p2, byte[] p3)
		{
			if (id_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB == IntPtr.Zero)
				id_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB = JNIEnv.GetMethodID (class_ref, "encrypt3DesCbcNopad", "([B[B[B[B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_encrypt3DesCbcNopad_arrayBarrayBarrayBarrayB, __args);
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
			return __ret;
		}

		static Delegate cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetEncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_Handler ()
		{
			if (cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ == null)
				cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr, int>) n_EncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_);
			return cb_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
		}

		static int n_EncryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, bool p3, IntPtr native_p4)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncryptAes128Cbc (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_;
		public unsafe int EncryptAes128Cbc (byte[] p0, byte[] p1, byte[] p2, bool p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4)
		{
			if (id_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ == IntPtr.Zero)
				id_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "encryptAes128Cbc", "([B[B[BZLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (native_p4);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_encryptAes128Cbc_arrayBarrayBarrayBZLjava_util_ArrayList_, __args);
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
			return __ret;
		}

		static Delegate cb_genRandom_arrayB;
#pragma warning disable 0169
		static Delegate GetGenRandom_arrayBHandler ()
		{
			if (cb_genRandom_arrayB == null)
				cb_genRandom_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GenRandom_arrayB);
			return cb_genRandom_arrayB;
		}

		static int n_GenRandom_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GenRandom (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_genRandom_arrayB;
		public unsafe int GenRandom (byte[] p0)
		{
			if (id_genRandom_arrayB == IntPtr.Zero)
				id_genRandom_arrayB = JNIEnv.GetMethodID (class_ref, "genRandom", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_genRandom_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_getHostCertif_Ljava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetGetHostCertif_Ljava_util_ArrayList_Handler ()
		{
			if (cb_getHostCertif_Ljava_util_ArrayList_ == null)
				cb_getHostCertif_Ljava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetHostCertif_Ljava_util_ArrayList_);
			return cb_getHostCertif_Ljava_util_ArrayList_;
		}

		static int n_GetHostCertif_Ljava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetHostCertif (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getHostCertif_Ljava_util_ArrayList_;
		public unsafe int GetHostCertif (global::System.Collections.Generic.IList<global::Java.Lang.Byte> p0)
		{
			if (id_getHostCertif_Ljava_util_ArrayList_ == IntPtr.Zero)
				id_getHostCertif_Ljava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "getHostCertif", "(Ljava/util/ArrayList;)I");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHostCertif_Ljava_util_ArrayList_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetRsaEncrypt_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_RsaEncrypt_arrayBarrayBLjava_util_ArrayList_);
			return cb_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_RsaEncrypt_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.RsaEncrypt (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_;
		public unsafe int RsaEncrypt (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			if (id_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "rsaEncrypt", "([B[BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_rsaEncrypt_arrayBarrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_setOpenSSLPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetOpenSSLPath_Ljava_lang_String_Handler ()
		{
			if (cb_setOpenSSLPath_Ljava_lang_String_ == null)
				cb_setOpenSSLPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_SetOpenSSLPath_Ljava_lang_String_);
			return cb_setOpenSSLPath_Ljava_lang_String_;
		}

		static int n_SetOpenSSLPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SetOpenSSLPath (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_setOpenSSLPath_Ljava_lang_String_;
		public unsafe int SetOpenSSLPath (string p0)
		{
			if (id_setOpenSSLPath_Ljava_lang_String_ == IntPtr.Zero)
				id_setOpenSSLPath_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setOpenSSLPath", "(Ljava/lang/String;)I");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_setOpenSSLPath_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_signRSA_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetSignRSA_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_signRSA_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_signRSA_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SignRSA_arrayBarrayBLjava_util_ArrayList_);
			return cb_signRSA_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_SignRSA_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.SignRSA (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_signRSA_arrayBarrayBLjava_util_ArrayList_;
		public unsafe int SignRSA (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			if (id_signRSA_arrayBarrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_signRSA_arrayBarrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "signRSA", "([B[BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_signRSA_arrayBarrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_tripleDesCrypt_arrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesCrypt_arrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesCrypt_arrayBLjava_util_ArrayList_ == null)
				cb_tripleDesCrypt_arrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesCrypt_arrayBLjava_util_ArrayList_);
			return cb_tripleDesCrypt_arrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesCrypt_arrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesCrypt (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tripleDesCrypt_arrayBLjava_util_ArrayList_;
		public unsafe int TripleDesCrypt (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			if (id_tripleDesCrypt_arrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_tripleDesCrypt_arrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "tripleDesCrypt", "([BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tripleDesCrypt_arrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ == null)
				cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_);
			return cb_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesCryptByKey (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_;
		public unsafe int TripleDesCryptByKey (byte[] p0, byte[] p1, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p2)
		{
			if (id_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "tripleDesCryptByKey", "([B[BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tripleDesCryptByKey_arrayBarrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

		static Delegate cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesDecrypt_arrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_ == null)
				cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesDecrypt_arrayBLjava_util_ArrayList_);
			return cb_tripleDesDecrypt_arrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesDecrypt_arrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesDecrypt (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tripleDesDecrypt_arrayBLjava_util_ArrayList_;
		public unsafe int TripleDesDecrypt (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			if (id_tripleDesDecrypt_arrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_tripleDesDecrypt_arrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "tripleDesDecrypt", "([BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tripleDesDecrypt_arrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_tripleDesSign_arrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTripleDesSign_arrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tripleDesSign_arrayBLjava_util_ArrayList_ == null)
				cb_tripleDesSign_arrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesSign_arrayBLjava_util_ArrayList_);
			return cb_tripleDesSign_arrayBLjava_util_ArrayList_;
		}

		static int n_TripleDesSign_arrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TripleDesSign (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tripleDesSign_arrayBLjava_util_ArrayList_;
		public unsafe int TripleDesSign (byte[] p0, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p1)
		{
			if (id_tripleDesSign_arrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_tripleDesSign_arrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "tripleDesSign", "([BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tripleDesSign_arrayBLjava_util_ArrayList_, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

		static Delegate cb_tripleDesVerifSign_arrayBarrayBarrayZ;
#pragma warning disable 0169
		static Delegate GetTripleDesVerifSign_arrayBarrayBarrayZHandler ()
		{
			if (cb_tripleDesVerifSign_arrayBarrayBarrayZ == null)
				cb_tripleDesVerifSign_arrayBarrayBarrayZ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TripleDesVerifSign_arrayBarrayBarrayZ);
			return cb_tripleDesVerifSign_arrayBarrayBarrayZ;
		}

		static int n_TripleDesVerifSign_arrayBarrayBarrayZ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			bool[] p2 = (bool[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (bool));
			int __ret = __this.TripleDesVerifSign (p0, p1, p2);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tripleDesVerifSign_arrayBarrayBarrayZ;
		public unsafe int TripleDesVerifSign (byte[] p0, byte[] p1, bool[] p2)
		{
			if (id_tripleDesVerifSign_arrayBarrayBarrayZ == IntPtr.Zero)
				id_tripleDesVerifSign_arrayBarrayBarrayZ = JNIEnv.GetMethodID (class_ref, "tripleDesVerifSign", "([B[B[Z)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tripleDesVerifSign_arrayBarrayBarrayZ, __args);
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
			return __ret;
		}

		static Delegate cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_;
#pragma warning disable 0169
		static Delegate GetTunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_Handler ()
		{
			if (cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ == null)
				cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_TunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_);
			return cb_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_;
		}

		static int n_TunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p3 = (byte[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.FromJniHandle (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.TunnelingInit1 (p0, p1, p2, p3, p4);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_;
		public unsafe int TunnelingInit1 (byte[] p0, byte[] p1, byte[] p2, byte[] p3, global::System.Collections.Generic.IList<global::Java.Lang.Byte> p4)
		{
			if (id_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ == IntPtr.Zero)
				id_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_ = JNIEnv.GetMethodID (class_ref, "tunnelingInit1", "([B[B[B[BLjava/util/ArrayList;)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			IntPtr native_p4 = global::Android.Runtime.JavaList<global::Java.Lang.Byte>.ToLocalJniHandle (p4);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			__args [4] = new JValue (native_p4);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tunnelingInit1_arrayBarrayBarrayBarrayBLjava_util_ArrayList_, __args);
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
			return __ret;
		}

		static Delegate cb_tunnelingInit2_arrayB;
#pragma warning disable 0169
		static Delegate GetTunnelingInit2_arrayBHandler ()
		{
			if (cb_tunnelingInit2_arrayB == null)
				cb_tunnelingInit2_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_TunnelingInit2_arrayB);
			return cb_tunnelingInit2_arrayB;
		}

		static int n_TunnelingInit2_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.TunnelingInit2 (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_tunnelingInit2_arrayB;
		public unsafe int TunnelingInit2 (byte[] p0)
		{
			if (id_tunnelingInit2_arrayB == IntPtr.Zero)
				id_tunnelingInit2_arrayB = JNIEnv.GetMethodID (class_ref, "tunnelingInit2", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_tunnelingInit2_arrayB, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_verifCertif_arrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifCertif_arrayBarrayIHandler ()
		{
			if (cb_verifCertif_arrayBarrayI == null)
				cb_verifCertif_arrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifCertif_arrayBarrayI);
			return cb_verifCertif_arrayBarrayI;
		}

		static int n_VerifCertif_arrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] p1 = (int[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifCertif (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_verifCertif_arrayBarrayI;
		public unsafe int VerifCertif (byte[] p0, int[] p1)
		{
			if (id_verifCertif_arrayBarrayI == IntPtr.Zero)
				id_verifCertif_arrayBarrayI = JNIEnv.GetMethodID (class_ref, "verifCertif", "([B[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_verifCertif_arrayBarrayI, __args);
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			if (p1 != null) {
				JNIEnv.CopyArray (native_p1, p1);
				JNIEnv.DeleteLocalRef (native_p1);
			}
			return __ret;
		}

		static Delegate cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifOfferedSecuritySignature_arrayBarrayBarrayBarrayIHandler ()
		{
			if (cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI == null)
				cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifOfferedSecuritySignature_arrayBarrayBarrayBarrayI);
			return cb_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI;
		}

		static int n_VerifOfferedSecuritySignature_arrayBarrayBarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifOfferedSecuritySignature (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI;
		public unsafe int VerifOfferedSecuritySignature (byte[] p0, byte[] p1, byte[] p2, int[] p3)
		{
			if (id_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI == IntPtr.Zero)
				id_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI = JNIEnv.GetMethodID (class_ref, "verifOfferedSecuritySignature", "([B[B[B[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_verifOfferedSecuritySignature_arrayBarrayBarrayBarrayI, __args);
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
			return __ret;
		}

		static Delegate cb_verifSignDSA_arrayBarrayBarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifSignDSA_arrayBarrayBarrayBarrayIHandler ()
		{
			if (cb_verifSignDSA_arrayBarrayBarrayBarrayI == null)
				cb_verifSignDSA_arrayBarrayBarrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifSignDSA_arrayBarrayBarrayBarrayI);
			return cb_verifSignDSA_arrayBarrayBarrayBarrayI;
		}

		static int n_VerifSignDSA_arrayBarrayBarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifSignDSA (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_verifSignDSA_arrayBarrayBarrayBarrayI;
		public unsafe int VerifSignDSA (byte[] p0, byte[] p1, byte[] p2, int[] p3)
		{
			if (id_verifSignDSA_arrayBarrayBarrayBarrayI == IntPtr.Zero)
				id_verifSignDSA_arrayBarrayBarrayBarrayI = JNIEnv.GetMethodID (class_ref, "verifSignDSA", "([B[B[B[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_verifSignDSA_arrayBarrayBarrayBarrayI, __args);
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
			return __ret;
		}

		static Delegate cb_verifSignRSA_arrayBarrayBarrayBarrayI;
#pragma warning disable 0169
		static Delegate GetVerifSignRSA_arrayBarrayBarrayBarrayIHandler ()
		{
			if (cb_verifSignRSA_arrayBarrayBarrayBarrayI == null)
				cb_verifSignRSA_arrayBarrayBarrayBarrayI = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_VerifSignRSA_arrayBarrayBarrayBarrayI);
			return cb_verifSignRSA_arrayBarrayBarrayBarrayI;
		}

		static int n_VerifSignRSA_arrayBarrayBarrayBarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Com.Morpho.Morphosmart.Sdk.IMsoSecu __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.IMsoSecu> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p1 = (byte[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (byte));
			byte[] p2 = (byte[]) JNIEnv.GetArray (native_p2, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int[] p3 = (int[]) JNIEnv.GetArray (native_p3, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.VerifSignRSA (p0, p1, p2, p3);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
			if (p2 != null)
				JNIEnv.CopyArray (p2, native_p2);
			if (p3 != null)
				JNIEnv.CopyArray (p3, native_p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_verifSignRSA_arrayBarrayBarrayBarrayI;
		public unsafe int VerifSignRSA (byte[] p0, byte[] p1, byte[] p2, int[] p3)
		{
			if (id_verifSignRSA_arrayBarrayBarrayBarrayI == IntPtr.Zero)
				id_verifSignRSA_arrayBarrayBarrayBarrayI = JNIEnv.GetMethodID (class_ref, "verifSignRSA", "([B[B[B[I)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			IntPtr native_p3 = JNIEnv.NewArray (p3);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			__args [3] = new JValue (native_p3);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_verifSignRSA_arrayBarrayBarrayBarrayI, __args);
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
			return __ret;
		}

	}

}
