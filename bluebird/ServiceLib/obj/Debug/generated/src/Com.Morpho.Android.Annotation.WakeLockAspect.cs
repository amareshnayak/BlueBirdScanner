using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Android.Annotation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.android.annotation']/class[@name='WakeLockAspect']"
	[global::Android.Runtime.Register ("com/morpho/android/annotation/WakeLockAspect", DoNotGenerateAcw=true)]
	public partial class WakeLockAspect : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/android/annotation/WakeLockAspect", typeof (WakeLockAspect));
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

		protected WakeLockAspect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.annotation']/class[@name='WakeLockAspect']/constructor[@name='WakeLockAspect' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe WakeLockAspect ()
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

		public static unsafe bool HasAspect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.annotation']/class[@name='WakeLockAspect']/method[@name='hasAspect' and count(parameter)=0]"
			[Register ("hasAspect", "()Z", "GetHasAspectHandler")]
			get {
				const string __id = "hasAspect.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_aroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_;
#pragma warning disable 0169
		static Delegate GetAroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_Handler ()
		{
			if (cb_aroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_ == null)
				cb_aroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_AroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_);
			return cb_aroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_;
		}

		static IntPtr n_AroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_joinPoint)
		{
			global::Com.Morpho.Android.Annotation.WakeLockAspect __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Annotation.WakeLockAspect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Org.Aspectj.Lang.IProceedingJoinPoint joinPoint = (global::Org.Aspectj.Lang.IProceedingJoinPoint)global::Java.Lang.Object.GetObject<global::Org.Aspectj.Lang.IProceedingJoinPoint> (native_joinPoint, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AroundAdvice (joinPoint));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.annotation']/class[@name='WakeLockAspect']/method[@name='aroundAdvice' and count(parameter)=1 and parameter[1][@type='org.aspectj.lang.ProceedingJoinPoint']]"
		[Register ("aroundAdvice", "(Lorg/aspectj/lang/ProceedingJoinPoint;)Ljava/lang/Object;", "GetAroundAdvice_Lorg_aspectj_lang_ProceedingJoinPoint_Handler")]
		public virtual unsafe global::Java.Lang.Object AroundAdvice (global::Org.Aspectj.Lang.IProceedingJoinPoint joinPoint)
		{
			const string __id = "aroundAdvice.(Lorg/aspectj/lang/ProceedingJoinPoint;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((joinPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) joinPoint).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.android.annotation']/class[@name='WakeLockAspect']/method[@name='aspectOf' and count(parameter)=0]"
		[Register ("aspectOf", "()Lcom/morpho/android/annotation/WakeLockAspect;", "")]
		public static unsafe global::Com.Morpho.Android.Annotation.WakeLockAspect AspectOf ()
		{
			const string __id = "aspectOf.()Lcom/morpho/android/annotation/WakeLockAspect;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Morpho.Android.Annotation.WakeLockAspect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
