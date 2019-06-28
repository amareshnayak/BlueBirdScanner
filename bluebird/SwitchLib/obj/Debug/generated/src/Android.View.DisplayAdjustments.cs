using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.View {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']"
	[global::Android.Runtime.Register ("android/view/DisplayAdjustments", DoNotGenerateAcw=true)]
	public partial class DisplayAdjustments : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/field[@name='DEFAULT_DISPLAY_ADJUSTMENTS']"
		[Register ("DEFAULT_DISPLAY_ADJUSTMENTS")]
		public static global::Android.View.DisplayAdjustments DefaultDisplayAdjustments {
			get {
				const string __id = "DEFAULT_DISPLAY_ADJUSTMENTS.Landroid/view/DisplayAdjustments;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.View.DisplayAdjustments> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/field[@name='DEVELOPMENT_RESOURCES_DEPEND_ON_ACTIVITY_TOKEN']"
		[Register ("DEVELOPMENT_RESOURCES_DEPEND_ON_ACTIVITY_TOKEN")]
		public const bool DevelopmentResourcesDependOnActivityToken = (bool) false;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/view/DisplayAdjustments", typeof (DisplayAdjustments));
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

		protected DisplayAdjustments (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/constructor[@name='DisplayAdjustments' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DisplayAdjustments ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/constructor[@name='DisplayAdjustments' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register (".ctor", "(Landroid/content/res/Configuration;)V", "")]
		public unsafe DisplayAdjustments (global::Android.Content.Res.Configuration configuration)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/Configuration;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((configuration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) configuration).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/constructor[@name='DisplayAdjustments' and count(parameter)=1 and parameter[1][@type='android.view.DisplayAdjustments']]"
		[Register (".ctor", "(Landroid/view/DisplayAdjustments;)V", "")]
		public unsafe DisplayAdjustments (global::Android.View.DisplayAdjustments daj)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/DisplayAdjustments;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((daj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) daj).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getConfiguration;
#pragma warning disable 0169
		static Delegate GetGetConfigurationHandler ()
		{
			if (cb_getConfiguration == null)
				cb_getConfiguration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfiguration);
			return cb_getConfiguration;
		}

		static IntPtr n_GetConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.View.DisplayAdjustments __this = global::Java.Lang.Object.GetObject<global::Android.View.DisplayAdjustments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		static Delegate cb_setConfiguration_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetSetConfiguration_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_setConfiguration_Landroid_content_res_Configuration_ == null)
				cb_setConfiguration_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetConfiguration_Landroid_content_res_Configuration_);
			return cb_setConfiguration_Landroid_content_res_Configuration_;
		}

		static void n_SetConfiguration_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_configuration)
		{
			global::Android.View.DisplayAdjustments __this = global::Java.Lang.Object.GetObject<global::Android.View.DisplayAdjustments> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration configuration = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_configuration, JniHandleOwnership.DoNotTransfer);
			__this.Configuration = configuration;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Res.Configuration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Landroid/content/res/Configuration;", "GetGetConfigurationHandler")]
			get {
				const string __id = "getConfiguration.()Landroid/content/res/Configuration;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='android.view']/class[@name='DisplayAdjustments']/method[@name='setConfiguration' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
			[Register ("setConfiguration", "(Landroid/content/res/Configuration;)V", "GetSetConfiguration_Landroid_content_res_Configuration_Handler")]
			set {
				const string __id = "setConfiguration.(Landroid/content/res/Configuration;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
