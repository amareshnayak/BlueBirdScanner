using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Morphosmart.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='ResultMatching']"
	[global::Android.Runtime.Register ("com/morpho/morphosmart/sdk/ResultMatching", DoNotGenerateAcw=true)]
	public partial class ResultMatching : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/morphosmart/sdk/ResultMatching", typeof (ResultMatching));
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

		protected ResultMatching (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='ResultMatching']/constructor[@name='ResultMatching' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ResultMatching ()
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

		static Delegate cb_getMatchingPKNumber;
#pragma warning disable 0169
		static Delegate GetGetMatchingPKNumberHandler ()
		{
			if (cb_getMatchingPKNumber == null)
				cb_getMatchingPKNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMatchingPKNumber);
			return cb_getMatchingPKNumber;
		}

		static int n_GetMatchingPKNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MatchingPKNumber;
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingPKNumber_I;
#pragma warning disable 0169
		static Delegate GetSetMatchingPKNumber_IHandler ()
		{
			if (cb_setMatchingPKNumber_I == null)
				cb_setMatchingPKNumber_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMatchingPKNumber_I);
			return cb_setMatchingPKNumber_I;
		}

		static void n_SetMatchingPKNumber_I (IntPtr jnienv, IntPtr native__this, int matchingPKNumber)
		{
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MatchingPKNumber = matchingPKNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int MatchingPKNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='ResultMatching']/method[@name='getMatchingPKNumber' and count(parameter)=0]"
			[Register ("getMatchingPKNumber", "()I", "GetGetMatchingPKNumberHandler")]
			get {
				const string __id = "getMatchingPKNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='ResultMatching']/method[@name='setMatchingPKNumber' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMatchingPKNumber", "(I)V", "GetSetMatchingPKNumber_IHandler")]
			set {
				const string __id = "setMatchingPKNumber.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMatchingScore;
#pragma warning disable 0169
		static Delegate GetGetMatchingScoreHandler ()
		{
			if (cb_getMatchingScore == null)
				cb_getMatchingScore = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMatchingScore);
			return cb_getMatchingScore;
		}

		static int n_GetMatchingScore (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MatchingScore;
		}
#pragma warning restore 0169

		static Delegate cb_setMatchingScore_I;
#pragma warning disable 0169
		static Delegate GetSetMatchingScore_IHandler ()
		{
			if (cb_setMatchingScore_I == null)
				cb_setMatchingScore_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMatchingScore_I);
			return cb_setMatchingScore_I;
		}

		static void n_SetMatchingScore_I (IntPtr jnienv, IntPtr native__this, int matchingScore)
		{
			global::Com.Morpho.Morphosmart.Sdk.ResultMatching __this = global::Java.Lang.Object.GetObject<global::Com.Morpho.Morphosmart.Sdk.ResultMatching> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MatchingScore = matchingScore;
		}
#pragma warning restore 0169

		public virtual unsafe int MatchingScore {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='ResultMatching']/method[@name='getMatchingScore' and count(parameter)=0]"
			[Register ("getMatchingScore", "()I", "GetGetMatchingScoreHandler")]
			get {
				const string __id = "getMatchingScore.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.morpho.morphosmart.sdk']/class[@name='ResultMatching']/method[@name='setMatchingScore' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMatchingScore", "(I)V", "GetSetMatchingScore_IHandler")]
			set {
				const string __id = "setMatchingScore.(I)V";
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
