using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Lang.Reflect {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SignaturePattern']"
	[Register ("org/aspectj/lang/reflect/SignaturePattern", "", "Org.Aspectj.Lang.Reflect.ISignaturePatternInvoker")]
	public partial interface ISignaturePattern : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.lang.reflect']/interface[@name='SignaturePattern']/method[@name='asString' and count(parameter)=0]"
		[Register ("asString", "()Ljava/lang/String;", "GetAsStringHandler:Org.Aspectj.Lang.Reflect.ISignaturePatternInvoker, ServiceLib")]
		string AsString ();

	}

	[global::Android.Runtime.Register ("org/aspectj/lang/reflect/SignaturePattern", DoNotGenerateAcw=true)]
	internal class ISignaturePatternInvoker : global::Java.Lang.Object, ISignaturePattern {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/aspectj/lang/reflect/SignaturePattern", typeof (ISignaturePatternInvoker));

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

		public static ISignaturePattern GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISignaturePattern> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.lang.reflect.SignaturePattern"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISignaturePatternInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_asString;
#pragma warning disable 0169
		static Delegate GetAsStringHandler ()
		{
			if (cb_asString == null)
				cb_asString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AsString);
			return cb_asString;
		}

		static IntPtr n_AsString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Lang.Reflect.ISignaturePattern __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.Reflect.ISignaturePattern> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AsString ());
		}
#pragma warning restore 0169

		IntPtr id_asString;
		public unsafe string AsString ()
		{
			if (id_asString == IntPtr.Zero)
				id_asString = JNIEnv.GetMethodID (class_ref, "asString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_asString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
