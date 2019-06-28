using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/MorphoImageHeader", DoNotGenerateAcw=true)]
	public partial class MorphoImageHeader : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/MorphoImageHeader", typeof (MorphoImageHeader));
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

		protected MorphoImageHeader (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/constructor[@name='MorphoImageHeader' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MorphoImageHeader ()
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

		static Delegate cb_getCompressionRatio;
#pragma warning disable 0169
		static Delegate GetGetCompressionRatioHandler ()
		{
			if (cb_getCompressionRatio == null)
				cb_getCompressionRatio = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCompressionRatio);
			return cb_getCompressionRatio;
		}

		static int n_GetCompressionRatio (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CompressionRatio;
		}
#pragma warning restore 0169

		static Delegate cb_setCompressionRatio_I;
#pragma warning disable 0169
		static Delegate GetSetCompressionRatio_IHandler ()
		{
			if (cb_setCompressionRatio_I == null)
				cb_setCompressionRatio_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCompressionRatio_I);
			return cb_setCompressionRatio_I;
		}

		static void n_SetCompressionRatio_I (IntPtr jnienv, IntPtr native__this, int compressionRatio)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CompressionRatio = compressionRatio;
		}
#pragma warning restore 0169

		public virtual unsafe int CompressionRatio {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='getCompressionRatio' and count(parameter)=0]"
			[Register ("getCompressionRatio", "()I", "GetGetCompressionRatioHandler")]
			get {
				const string __id = "getCompressionRatio.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='setCompressionRatio' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCompressionRatio", "(I)V", "GetSetCompressionRatio_IHandler")]
			set {
				const string __id = "setCompressionRatio.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNbBitsPerPixel;
#pragma warning disable 0169
		static Delegate GetGetNbBitsPerPixelHandler ()
		{
			if (cb_getNbBitsPerPixel == null)
				cb_getNbBitsPerPixel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbBitsPerPixel);
			return cb_getNbBitsPerPixel;
		}

		static int n_GetNbBitsPerPixel (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbBitsPerPixel;
		}
#pragma warning restore 0169

		static Delegate cb_setNbBitsPerPixel_I;
#pragma warning disable 0169
		static Delegate GetSetNbBitsPerPixel_IHandler ()
		{
			if (cb_setNbBitsPerPixel_I == null)
				cb_setNbBitsPerPixel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNbBitsPerPixel_I);
			return cb_setNbBitsPerPixel_I;
		}

		static void n_SetNbBitsPerPixel_I (IntPtr jnienv, IntPtr native__this, int nbBitsPerPixel)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NbBitsPerPixel = nbBitsPerPixel;
		}
#pragma warning restore 0169

		public virtual unsafe int NbBitsPerPixel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='getNbBitsPerPixel' and count(parameter)=0]"
			[Register ("getNbBitsPerPixel", "()I", "GetGetNbBitsPerPixelHandler")]
			get {
				const string __id = "getNbBitsPerPixel.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='setNbBitsPerPixel' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNbBitsPerPixel", "(I)V", "GetSetNbBitsPerPixel_IHandler")]
			set {
				const string __id = "setNbBitsPerPixel.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNbColumn;
#pragma warning disable 0169
		static Delegate GetGetNbColumnHandler ()
		{
			if (cb_getNbColumn == null)
				cb_getNbColumn = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbColumn);
			return cb_getNbColumn;
		}

		static int n_GetNbColumn (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbColumn;
		}
#pragma warning restore 0169

		static Delegate cb_setNbColumn_I;
#pragma warning disable 0169
		static Delegate GetSetNbColumn_IHandler ()
		{
			if (cb_setNbColumn_I == null)
				cb_setNbColumn_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNbColumn_I);
			return cb_setNbColumn_I;
		}

		static void n_SetNbColumn_I (IntPtr jnienv, IntPtr native__this, int nbColumn)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NbColumn = nbColumn;
		}
#pragma warning restore 0169

		public virtual unsafe int NbColumn {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='getNbColumn' and count(parameter)=0]"
			[Register ("getNbColumn", "()I", "GetGetNbColumnHandler")]
			get {
				const string __id = "getNbColumn.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='setNbColumn' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNbColumn", "(I)V", "GetSetNbColumn_IHandler")]
			set {
				const string __id = "setNbColumn.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNbRow;
#pragma warning disable 0169
		static Delegate GetGetNbRowHandler ()
		{
			if (cb_getNbRow == null)
				cb_getNbRow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNbRow);
			return cb_getNbRow;
		}

		static int n_GetNbRow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbRow;
		}
#pragma warning restore 0169

		static Delegate cb_setNbRow_I;
#pragma warning disable 0169
		static Delegate GetSetNbRow_IHandler ()
		{
			if (cb_setNbRow_I == null)
				cb_setNbRow_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNbRow_I);
			return cb_setNbRow_I;
		}

		static void n_SetNbRow_I (IntPtr jnienv, IntPtr native__this, int nbRow)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NbRow = nbRow;
		}
#pragma warning restore 0169

		public virtual unsafe int NbRow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='getNbRow' and count(parameter)=0]"
			[Register ("getNbRow", "()I", "GetGetNbRowHandler")]
			get {
				const string __id = "getNbRow.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='setNbRow' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNbRow", "(I)V", "GetSetNbRow_IHandler")]
			set {
				const string __id = "setNbRow.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResX;
#pragma warning disable 0169
		static Delegate GetGetResXHandler ()
		{
			if (cb_getResX == null)
				cb_getResX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResX);
			return cb_getResX;
		}

		static int n_GetResX (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResX;
		}
#pragma warning restore 0169

		static Delegate cb_setResX_I;
#pragma warning disable 0169
		static Delegate GetSetResX_IHandler ()
		{
			if (cb_setResX_I == null)
				cb_setResX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResX_I);
			return cb_setResX_I;
		}

		static void n_SetResX_I (IntPtr jnienv, IntPtr native__this, int resX)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResX = resX;
		}
#pragma warning restore 0169

		public virtual unsafe int ResX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='getResX' and count(parameter)=0]"
			[Register ("getResX", "()I", "GetGetResXHandler")]
			get {
				const string __id = "getResX.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='setResX' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResX", "(I)V", "GetSetResX_IHandler")]
			set {
				const string __id = "setResX.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getResY;
#pragma warning disable 0169
		static Delegate GetGetResYHandler ()
		{
			if (cb_getResY == null)
				cb_getResY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetResY);
			return cb_getResY;
		}

		static int n_GetResY (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ResY;
		}
#pragma warning restore 0169

		static Delegate cb_setResY_I;
#pragma warning disable 0169
		static Delegate GetSetResY_IHandler ()
		{
			if (cb_setResY_I == null)
				cb_setResY_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetResY_I);
			return cb_setResY_I;
		}

		static void n_SetResY_I (IntPtr jnienv, IntPtr native__this, int resY)
		{
			global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.MorphoImageHeader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResY = resY;
		}
#pragma warning restore 0169

		public virtual unsafe int ResY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='getResY' and count(parameter)=0]"
			[Register ("getResY", "()I", "GetGetResYHandler")]
			get {
				const string __id = "getResY.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='MorphoImageHeader']/method[@name='setResY' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setResY", "(I)V", "GetSetResY_IHandler")]
			set {
				const string __id = "setResY.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
