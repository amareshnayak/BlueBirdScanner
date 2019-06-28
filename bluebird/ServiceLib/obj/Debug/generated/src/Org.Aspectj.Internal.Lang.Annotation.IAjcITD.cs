using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Aspectj.Internal.Lang.Annotation {

	// Metadata.xml XPath interface reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcITD']"
	[Register ("org/aspectj/internal/lang/annotation/ajcITD", "", "Org.Aspectj.Internal.Lang.Annotation.IAjcITDInvoker")]
	public partial interface IAjcITD : global::Java.Lang.Annotation.IAnnotation {

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcITD']/method[@name='modifiers' and count(parameter)=0]"
		[Register ("modifiers", "()I", "GetModifiersHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcITDInvoker, ServiceLib")]
		int Modifiers ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcITD']/method[@name='name' and count(parameter)=0]"
		[Register ("name", "()Ljava/lang/String;", "GetNameHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcITDInvoker, ServiceLib")]
		string Name ();

		// Metadata.xml XPath method reference: path="/api/package[@name='org.aspectj.internal.lang.annotation']/interface[@name='ajcITD']/method[@name='targetType' and count(parameter)=0]"
		[Register ("targetType", "()Ljava/lang/String;", "GetTargetTypeHandler:Org.Aspectj.Internal.Lang.Annotation.IAjcITDInvoker, ServiceLib")]
		string TargetType ();

	}

	[global::Android.Runtime.Register ("org/aspectj/internal/lang/annotation/ajcITD", DoNotGenerateAcw=true)]
	internal class IAjcITDInvoker : global::Java.Lang.Object, IAjcITD {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("org/aspectj/internal/lang/annotation/ajcITD", typeof (IAjcITDInvoker));

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

		public static IAjcITD GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAjcITD> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "org.aspectj.internal.lang.annotation.ajcITD"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAjcITDInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_modifiers;
#pragma warning disable 0169
		static Delegate GetModifiersHandler ()
		{
			if (cb_modifiers == null)
				cb_modifiers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Modifiers);
			return cb_modifiers;
		}

		static int n_Modifiers (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Modifiers ();
		}
#pragma warning restore 0169

		IntPtr id_modifiers;
		public unsafe int Modifiers ()
		{
			if (id_modifiers == IntPtr.Zero)
				id_modifiers = JNIEnv.GetMethodID (class_ref, "modifiers", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_modifiers);
		}

		static Delegate cb_name;
#pragma warning disable 0169
		static Delegate GetNameHandler ()
		{
			if (cb_name == null)
				cb_name = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Name);
			return cb_name;
		}

		static IntPtr n_Name (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name ());
		}
#pragma warning restore 0169

		IntPtr id_name;
		public unsafe string Name ()
		{
			if (id_name == IntPtr.Zero)
				id_name = JNIEnv.GetMethodID (class_ref, "name", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_name), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_targetType;
#pragma warning disable 0169
		static Delegate GetTargetTypeHandler ()
		{
			if (cb_targetType == null)
				cb_targetType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_TargetType);
			return cb_targetType;
		}

		static IntPtr n_TargetType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TargetType ());
		}
#pragma warning restore 0169

		IntPtr id_targetType;
		public unsafe string TargetType ()
		{
			if (id_targetType == IntPtr.Zero)
				id_targetType = JNIEnv.GetMethodID (class_ref, "targetType", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_targetType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_annotationType;
#pragma warning disable 0169
		static Delegate GetAnnotationTypeHandler ()
		{
			if (cb_annotationType == null)
				cb_annotationType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_AnnotationType);
			return cb_annotationType;
		}

		static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
		}
#pragma warning restore 0169

		IntPtr id_annotationType;
		public unsafe global::Java.Lang.Class AnnotationType ()
		{
			if (id_annotationType == IntPtr.Zero)
				id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEquals_Ljava_lang_Object_Handler ()
		{
			if (cb_equals_Ljava_lang_Object_ == null)
				cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Equals_Ljava_lang_Object_);
			return cb_equals_Ljava_lang_Object_;
		}

		static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (obj);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_equals_Ljava_lang_Object_;
		public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
		{
			if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
				id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
			return __ret;
		}

		static Delegate cb_hashCode;
#pragma warning disable 0169
		static Delegate GetGetHashCodeHandler ()
		{
			if (cb_hashCode == null)
				cb_hashCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHashCode);
			return cb_hashCode;
		}

		static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetHashCode ();
		}
#pragma warning restore 0169

		IntPtr id_hashCode;
		public unsafe global::System.Int32 GetHashCode ()
		{
			if (id_hashCode == IntPtr.Zero)
				id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
		}

		static Delegate cb_toString;
#pragma warning disable 0169
		static Delegate GetToStringHandler ()
		{
			if (cb_toString == null)
				cb_toString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToString);
			return cb_toString;
		}

		static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
		{
			global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD __this = global::Java.Lang.Object.GetObject<global::Org.Aspectj.Internal.Lang.Annotation.IAjcITD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToString ());
		}
#pragma warning restore 0169

		IntPtr id_toString;
		public unsafe global::System.String ToString ()
		{
			if (id_toString == IntPtr.Zero)
				id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
		}

	}

}
