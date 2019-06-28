using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoImage", DoNotGenerateAcw=true)]
	public partial class MorphoImage : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoImage", typeof (MorphoImage));
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

		protected MorphoImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/constructor[@name='MorphoImage' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoImage ()
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

		static Delegate cb_getCompressionAlgorithm;
#pragma warning disable 0169
		static Delegate GetGetCompressionAlgorithmHandler ()
		{
			if (cb_getCompressionAlgorithm == null)
				cb_getCompressionAlgorithm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompressionAlgorithm);
			return cb_getCompressionAlgorithm;
		}

		static IntPtr n_GetCompressionAlgorithm (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CompressionAlgorithm);
		}
#pragma warning restore 0169

		static Delegate cb_setCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_;
#pragma warning disable 0169
		static Delegate GetSetCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_Handler ()
		{
			if (cb_setCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_ == null)
				cb_setCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_);
			return cb_setCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_;
		}

		static void n_SetCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compressionAlgorithm)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm compressionAlgorithm = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (native_compressionAlgorithm, JniHandleOwnership.DoNotTransfer);
			__this.CompressionAlgorithm = compressionAlgorithm;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm CompressionAlgorithm {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='getCompressionAlgorithm' and count(parameter)=0]"
			[Register ("getCompressionAlgorithm", "()Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;", "GetGetCompressionAlgorithmHandler")]
			get {
				const string __id = "getCompressionAlgorithm.()Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.CompressionAlgorithm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='setCompressionAlgorithm' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.CompressionAlgorithm']]"
			[Register ("setCompressionAlgorithm", "(Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;)V", "GetSetCompressionAlgorithm_Lcom_morpho_morphosmart_sdk_CompressionAlgorithm_Handler")]
			set {
				const string __id = "setCompressionAlgorithm.(Lcom/morpho/morphosmart/sdk/CompressionAlgorithm;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMorphoImageHeader;
#pragma warning disable 0169
		static Delegate GetGetMorphoImageHeaderHandler ()
		{
			if (cb_getMorphoImageHeader == null)
				cb_getMorphoImageHeader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMorphoImageHeader);
			return cb_getMorphoImageHeader;
		}

		static IntPtr n_GetMorphoImageHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MorphoImageHeader);
		}
#pragma warning restore 0169

		static Delegate cb_setMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_;
#pragma warning disable 0169
		static Delegate GetSetMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_Handler ()
		{
			if (cb_setMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_ == null)
				cb_setMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_);
			return cb_setMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_;
		}

		static void n_SetMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_ (IntPtr jnienv, IntPtr native__this, IntPtr native_morphoImageHeader)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader morphoImageHeader = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (native_morphoImageHeader, JniHandleOwnership.DoNotTransfer);
			__this.MorphoImageHeader = morphoImageHeader;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader MorphoImageHeader {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='getMorphoImageHeader' and count(parameter)=0]"
			[Register ("getMorphoImageHeader", "()Lcom/morpho/morphosmart/sdk/MorphoImageHeader;", "GetGetMorphoImageHeaderHandler")]
			get {
				const string __id = "getMorphoImageHeader.()Lcom/morpho/morphosmart/sdk/MorphoImageHeader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='setMorphoImageHeader' and count(parameter)=1 and parameter[1][@type='com.morpho.morphosmart.sdk.MorphoImageHeader']]"
			[Register ("setMorphoImageHeader", "(Lcom/morpho/morphosmart/sdk/MorphoImageHeader;)V", "GetSetMorphoImageHeader_Lcom_morpho_morphosmart_sdk_MorphoImageHeader_Handler")]
			set {
				const string __id = "setMorphoImageHeader.(Lcom/morpho/morphosmart/sdk/MorphoImageHeader;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCompressedImage;
#pragma warning disable 0169
		static Delegate GetGetCompressedImageHandler ()
		{
			if (cb_getCompressedImage == null)
				cb_getCompressedImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCompressedImage);
			return cb_getCompressedImage;
		}

		static IntPtr n_GetCompressedImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetCompressedImage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='getCompressedImage' and count(parameter)=0]"
		[Register ("getCompressedImage", "()[B", "GetGetCompressedImageHandler")]
		public virtual unsafe byte[] GetCompressedImage ()
		{
			const string __id = "getCompressedImage.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getImage;
#pragma warning disable 0169
		static Delegate GetGetImageHandler ()
		{
			if (cb_getImage == null)
				cb_getImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImage);
			return cb_getImage;
		}

		static IntPtr n_GetImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetImage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='getImage' and count(parameter)=0]"
		[Register ("getImage", "()[B", "GetGetImageHandler")]
		public virtual unsafe byte[] GetImage ()
		{
			const string __id = "getImage.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='getMorphoImageFromLive' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getMorphoImageFromLive", "([B)Lcom/morpho/morphosmart/sdk/MorphoImage;", "")]
		public static unsafe global::Com.Morpho.Morphosmart.Sdk.MorphoImage GetMorphoImageFromLive (byte[] imageStructure)
		{
			const string __id = "getMorphoImageFromLive.([B)Lcom/morpho/morphosmart/sdk/MorphoImage;";
			IntPtr native_imageStructure = JNIEnv.NewArray (imageStructure);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_imageStructure);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (imageStructure != null) {
					JNIEnv.CopyArray (native_imageStructure, imageStructure);
					JNIEnv.DeleteLocalRef (native_imageStructure);
				}
			}
		}

		static Delegate cb_setCompressedImage_arrayB;
#pragma warning disable 0169
		static Delegate GetSetCompressedImage_arrayBHandler ()
		{
			if (cb_setCompressedImage_arrayB == null)
				cb_setCompressedImage_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompressedImage_arrayB);
			return cb_setCompressedImage_arrayB;
		}

		static void n_SetCompressedImage_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_compressedImage)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] compressedImage = (byte[]) JNIEnv.GetArray (native_compressedImage, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetCompressedImage (compressedImage);
			if (compressedImage != null)
				JNIEnv.CopyArray (compressedImage, native_compressedImage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='setCompressedImage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setCompressedImage", "([B)V", "GetSetCompressedImage_arrayBHandler")]
		public virtual unsafe void SetCompressedImage (byte[] compressedImage)
		{
			const string __id = "setCompressedImage.([B)V";
			IntPtr native_compressedImage = JNIEnv.NewArray (compressedImage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_compressedImage);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (compressedImage != null) {
					JNIEnv.CopyArray (native_compressedImage, compressedImage);
					JNIEnv.DeleteLocalRef (native_compressedImage);
				}
			}
		}

		static Delegate cb_setCompressedImage_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetCompressedImage_Ljava_lang_Object_Handler ()
		{
			if (cb_setCompressedImage_Ljava_lang_Object_ == null)
				cb_setCompressedImage_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCompressedImage_Ljava_lang_Object_);
			return cb_setCompressedImage_Ljava_lang_Object_;
		}

		static void n_SetCompressedImage_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_compressedImage)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object compressedImage = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_compressedImage, JniHandleOwnership.DoNotTransfer);
			__this.SetCompressedImage (compressedImage);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='setCompressedImage' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setCompressedImage", "(Ljava/lang/Object;)V", "GetSetCompressedImage_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetCompressedImage (global::Java.Lang.Object compressedImage)
		{
			const string __id = "setCompressedImage.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((compressedImage == null) ? IntPtr.Zero : ((global::Java.Lang.Object) compressedImage).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setImage_arrayB;
#pragma warning disable 0169
		static Delegate GetSetImage_arrayBHandler ()
		{
			if (cb_setImage_arrayB == null)
				cb_setImage_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_arrayB);
			return cb_setImage_arrayB;
		}

		static void n_SetImage_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] image = (byte[]) JNIEnv.GetArray (native_image, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetImage (image);
			if (image != null)
				JNIEnv.CopyArray (image, native_image);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setImage", "([B)V", "GetSetImage_arrayBHandler")]
		public virtual unsafe void SetImage (byte[] image)
		{
			const string __id = "setImage.([B)V";
			IntPtr native_image = JNIEnv.NewArray (image);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_image);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (image != null) {
					JNIEnv.CopyArray (native_image, image);
					JNIEnv.DeleteLocalRef (native_image);
				}
			}
		}

		static Delegate cb_setImage_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetImage_Ljava_lang_Object_Handler ()
		{
			if (cb_setImage_Ljava_lang_Object_ == null)
				cb_setImage_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetImage_Ljava_lang_Object_);
			return cb_setImage_Ljava_lang_Object_;
		}

		static void n_SetImage_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_image)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImage __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object image = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_image, JniHandleOwnership.DoNotTransfer);
			__this.SetImage (image);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImage']/method[@name='setImage' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("setImage", "(Ljava/lang/Object;)V", "GetSetImage_Ljava_lang_Object_Handler")]
		public virtual unsafe void SetImage (global::Java.Lang.Object image)
		{
			const string __id = "setImage.(Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
