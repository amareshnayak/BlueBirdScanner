using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']"
	[global::Android.Runtime.Register ("android/content/ContextWrapper", DoNotGenerateAcw=true)]
	public partial class ContextWrapper : global::Android.Content.Context {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/ContextWrapper", typeof (ContextWrapper));
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

		protected ContextWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/constructor[@name='ContextWrapper' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ContextWrapper (global::Android.Content.Context @base)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetApplicationContextHandler ()
		{
			if (cb_getApplicationContext == null)
				cb_getApplicationContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationContext);
			return cb_getApplicationContext;
		}

		static IntPtr n_GetApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				const string __id = "getApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getApplicationInfo;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfoHandler ()
		{
			if (cb_getApplicationInfo == null)
				cb_getApplicationInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationInfo);
			return cb_getApplicationInfo;
		}

		static IntPtr n_GetApplicationInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationInfo);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.PM.ApplicationInfo ApplicationInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getApplicationInfo' and count(parameter)=0]"
			[Register ("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", "GetGetApplicationInfoHandler")]
			get {
				const string __id = "getApplicationInfo.()Landroid/content/pm/ApplicationInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAssets;
#pragma warning disable 0169
		static Delegate GetGetAssetsHandler ()
		{
			if (cb_getAssets == null)
				cb_getAssets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssets);
			return cb_getAssets;
		}

		static IntPtr n_GetAssets (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Assets);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.Res.AssetManager Assets {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getAssets' and count(parameter)=0]"
			[Register ("getAssets", "()Landroid/content/res/AssetManager;", "GetGetAssetsHandler")]
			get {
				const string __id = "getAssets.()Landroid/content/res/AssetManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.AssetManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBaseContext;
#pragma warning disable 0169
		static Delegate GetGetBaseContextHandler ()
		{
			if (cb_getBaseContext == null)
				cb_getBaseContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseContext);
			return cb_getBaseContext;
		}

		static IntPtr n_GetBaseContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BaseContext);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context BaseContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getBaseContext' and count(parameter)=0]"
			[Register ("getBaseContext", "()Landroid/content/Context;", "GetGetBaseContextHandler")]
			get {
				const string __id = "getBaseContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBasePackageName;
#pragma warning disable 0169
		static Delegate GetGetBasePackageNameHandler ()
		{
			if (cb_getBasePackageName == null)
				cb_getBasePackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBasePackageName);
			return cb_getBasePackageName;
		}

		static IntPtr n_GetBasePackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BasePackageName);
		}
#pragma warning restore 0169

		public override unsafe string BasePackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getBasePackageName' and count(parameter)=0]"
			[Register ("getBasePackageName", "()Ljava/lang/String;", "GetGetBasePackageNameHandler")]
			get {
				const string __id = "getBasePackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCacheDir;
#pragma warning disable 0169
		static Delegate GetGetCacheDirHandler ()
		{
			if (cb_getCacheDir == null)
				cb_getCacheDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheDir);
			return cb_getCacheDir;
		}

		static IntPtr n_GetCacheDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDir);
		}
#pragma warning restore 0169

		public override unsafe global::Java.IO.File CacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getCacheDir' and count(parameter)=0]"
			[Register ("getCacheDir", "()Ljava/io/File;", "GetGetCacheDirHandler")]
			get {
				const string __id = "getCacheDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getClassLoader;
#pragma warning disable 0169
		static Delegate GetGetClassLoaderHandler ()
		{
			if (cb_getClassLoader == null)
				cb_getClassLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassLoader);
			return cb_getClassLoader;
		}

		static IntPtr n_GetClassLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClassLoader);
		}
#pragma warning restore 0169

		public override unsafe global::Java.Lang.ClassLoader ClassLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getClassLoader' and count(parameter)=0]"
			[Register ("getClassLoader", "()Ljava/lang/ClassLoader;", "GetGetClassLoaderHandler")]
			get {
				const string __id = "getClassLoader.()Ljava/lang/ClassLoader;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCodeCacheDir;
#pragma warning disable 0169
		static Delegate GetGetCodeCacheDirHandler ()
		{
			if (cb_getCodeCacheDir == null)
				cb_getCodeCacheDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodeCacheDir);
			return cb_getCodeCacheDir;
		}

		static IntPtr n_GetCodeCacheDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CodeCacheDir);
		}
#pragma warning restore 0169

		public override unsafe global::Java.IO.File CodeCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getCodeCacheDir' and count(parameter)=0]"
			[Register ("getCodeCacheDir", "()Ljava/io/File;", "GetGetCodeCacheDirHandler")]
			get {
				const string __id = "getCodeCacheDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentResolver;
#pragma warning disable 0169
		static Delegate GetGetContentResolverHandler ()
		{
			if (cb_getContentResolver == null)
				cb_getContentResolver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentResolver);
			return cb_getContentResolver;
		}

		static IntPtr n_GetContentResolver (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentResolver);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.ContentResolver ContentResolver {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getContentResolver' and count(parameter)=0]"
			[Register ("getContentResolver", "()Landroid/content/ContentResolver;", "GetGetContentResolverHandler")]
			get {
				const string __id = "getContentResolver.()Landroid/content/ContentResolver;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExternalCacheDir;
#pragma warning disable 0169
		static Delegate GetGetExternalCacheDirHandler ()
		{
			if (cb_getExternalCacheDir == null)
				cb_getExternalCacheDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalCacheDir);
			return cb_getExternalCacheDir;
		}

		static IntPtr n_GetExternalCacheDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExternalCacheDir);
		}
#pragma warning restore 0169

		public override unsafe global::Java.IO.File ExternalCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getExternalCacheDir' and count(parameter)=0]"
			[Register ("getExternalCacheDir", "()Ljava/io/File;", "GetGetExternalCacheDirHandler")]
			get {
				const string __id = "getExternalCacheDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFilesDir;
#pragma warning disable 0169
		static Delegate GetGetFilesDirHandler ()
		{
			if (cb_getFilesDir == null)
				cb_getFilesDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilesDir);
			return cb_getFilesDir;
		}

		static IntPtr n_GetFilesDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FilesDir);
		}
#pragma warning restore 0169

		public override unsafe global::Java.IO.File FilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getFilesDir' and count(parameter)=0]"
			[Register ("getFilesDir", "()Ljava/io/File;", "GetGetFilesDirHandler")]
			get {
				const string __id = "getFilesDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMainLooper;
#pragma warning disable 0169
		static Delegate GetGetMainLooperHandler ()
		{
			if (cb_getMainLooper == null)
				cb_getMainLooper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainLooper);
			return cb_getMainLooper;
		}

		static IntPtr n_GetMainLooper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MainLooper);
		}
#pragma warning restore 0169

		public override unsafe global::Android.OS.Looper MainLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getMainLooper' and count(parameter)=0]"
			[Register ("getMainLooper", "()Landroid/os/Looper;", "GetGetMainLooperHandler")]
			get {
				const string __id = "getMainLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getNoBackupFilesDir;
#pragma warning disable 0169
		static Delegate GetGetNoBackupFilesDirHandler ()
		{
			if (cb_getNoBackupFilesDir == null)
				cb_getNoBackupFilesDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNoBackupFilesDir);
			return cb_getNoBackupFilesDir;
		}

		static IntPtr n_GetNoBackupFilesDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoBackupFilesDir);
		}
#pragma warning restore 0169

		public override unsafe global::Java.IO.File NoBackupFilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getNoBackupFilesDir' and count(parameter)=0]"
			[Register ("getNoBackupFilesDir", "()Ljava/io/File;", "GetGetNoBackupFilesDirHandler")]
			get {
				const string __id = "getNoBackupFilesDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getObbDir;
#pragma warning disable 0169
		static Delegate GetGetObbDirHandler ()
		{
			if (cb_getObbDir == null)
				cb_getObbDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObbDir);
			return cb_getObbDir;
		}

		static IntPtr n_GetObbDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObbDir);
		}
#pragma warning restore 0169

		public override unsafe global::Java.IO.File ObbDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getObbDir' and count(parameter)=0]"
			[Register ("getObbDir", "()Ljava/io/File;", "GetGetObbDirHandler")]
			get {
				const string __id = "getObbDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOpPackageName;
#pragma warning disable 0169
		static Delegate GetGetOpPackageNameHandler ()
		{
			if (cb_getOpPackageName == null)
				cb_getOpPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpPackageName);
			return cb_getOpPackageName;
		}

		static IntPtr n_GetOpPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpPackageName);
		}
#pragma warning restore 0169

		public override unsafe string OpPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getOpPackageName' and count(parameter)=0]"
			[Register ("getOpPackageName", "()Ljava/lang/String;", "GetGetOpPackageNameHandler")]
			get {
				const string __id = "getOpPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageCodePath;
#pragma warning disable 0169
		static Delegate GetGetPackageCodePathHandler ()
		{
			if (cb_getPackageCodePath == null)
				cb_getPackageCodePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageCodePath);
			return cb_getPackageCodePath;
		}

		static IntPtr n_GetPackageCodePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageCodePath);
		}
#pragma warning restore 0169

		public override unsafe string PackageCodePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getPackageCodePath' and count(parameter)=0]"
			[Register ("getPackageCodePath", "()Ljava/lang/String;", "GetGetPackageCodePathHandler")]
			get {
				const string __id = "getPackageCodePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageManager;
#pragma warning disable 0169
		static Delegate GetGetPackageManagerHandler ()
		{
			if (cb_getPackageManager == null)
				cb_getPackageManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageManager);
			return cb_getPackageManager;
		}

		static IntPtr n_GetPackageManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackageManager);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.PM.PackageManager PackageManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getPackageManager' and count(parameter)=0]"
			[Register ("getPackageManager", "()Landroid/content/pm/PackageManager;", "GetGetPackageManagerHandler")]
			get {
				const string __id = "getPackageManager.()Landroid/content/pm/PackageManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.PackageManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public override unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPackageResourcePath;
#pragma warning disable 0169
		static Delegate GetGetPackageResourcePathHandler ()
		{
			if (cb_getPackageResourcePath == null)
				cb_getPackageResourcePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageResourcePath);
			return cb_getPackageResourcePath;
		}

		static IntPtr n_GetPackageResourcePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageResourcePath);
		}
#pragma warning restore 0169

		public override unsafe string PackageResourcePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getPackageResourcePath' and count(parameter)=0]"
			[Register ("getPackageResourcePath", "()Ljava/lang/String;", "GetGetPackageResourcePathHandler")]
			get {
				const string __id = "getPackageResourcePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getResources;
#pragma warning disable 0169
		static Delegate GetGetResourcesHandler ()
		{
			if (cb_getResources == null)
				cb_getResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResources);
			return cb_getResources;
		}

		static IntPtr n_GetResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resources);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				const string __id = "getResources.()Landroid/content/res/Resources;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTheme;
#pragma warning disable 0169
		static Delegate GetGetThemeHandler ()
		{
			if (cb_getTheme == null)
				cb_getTheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTheme);
			return cb_getTheme;
		}

		static IntPtr n_GetTheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Theme);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Content.Res.Resources.Theme Theme {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getTheme' and count(parameter)=0]"
			[Register ("getTheme", "()Landroid/content/res/Resources$Theme;", "GetGetThemeHandler")]
			get {
				const string __id = "getTheme.()Landroid/content/res/Resources$Theme;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getThemeResId;
#pragma warning disable 0169
		static Delegate GetGetThemeResIdHandler ()
		{
			if (cb_getThemeResId == null)
				cb_getThemeResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThemeResId);
			return cb_getThemeResId;
		}

		static int n_GetThemeResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThemeResId;
		}
#pragma warning restore 0169

		public override unsafe int ThemeResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getThemeResId' and count(parameter)=0]"
			[Register ("getThemeResId", "()I", "GetGetThemeResIdHandler")]
			get {
				const string __id = "getThemeResId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserId);
			return cb_getUserId;
		}

		static int n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserId;
		}
#pragma warning restore 0169

		public override unsafe int UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()I", "GetGetUserIdHandler")]
			get {
				const string __id = "getUserId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWallpaper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetWallpaperHandler ()
		{
			if (cb_getWallpaper == null)
				cb_getWallpaper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWallpaper);
			return cb_getWallpaper;
		}

		[Obsolete]
		static IntPtr n_GetWallpaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Wallpaper);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public override unsafe global::Android.Graphics.Drawables.Drawable Wallpaper {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getWallpaper' and count(parameter)=0]"
			[Register ("getWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetGetWallpaperHandler")]
			get {
				const string __id = "getWallpaper.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getWallpaperDesiredMinimumHeight;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetWallpaperDesiredMinimumHeightHandler ()
		{
			if (cb_getWallpaperDesiredMinimumHeight == null)
				cb_getWallpaperDesiredMinimumHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWallpaperDesiredMinimumHeight);
			return cb_getWallpaperDesiredMinimumHeight;
		}

		[Obsolete]
		static int n_GetWallpaperDesiredMinimumHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WallpaperDesiredMinimumHeight;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public override unsafe int WallpaperDesiredMinimumHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getWallpaperDesiredMinimumHeight' and count(parameter)=0]"
			[Register ("getWallpaperDesiredMinimumHeight", "()I", "GetGetWallpaperDesiredMinimumHeightHandler")]
			get {
				const string __id = "getWallpaperDesiredMinimumHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWallpaperDesiredMinimumWidth;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetWallpaperDesiredMinimumWidthHandler ()
		{
			if (cb_getWallpaperDesiredMinimumWidth == null)
				cb_getWallpaperDesiredMinimumWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWallpaperDesiredMinimumWidth);
			return cb_getWallpaperDesiredMinimumWidth;
		}

		[Obsolete]
		static int n_GetWallpaperDesiredMinimumWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WallpaperDesiredMinimumWidth;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public override unsafe int WallpaperDesiredMinimumWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getWallpaperDesiredMinimumWidth' and count(parameter)=0]"
			[Register ("getWallpaperDesiredMinimumWidth", "()I", "GetGetWallpaperDesiredMinimumWidthHandler")]
			get {
				const string __id = "getWallpaperDesiredMinimumWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_attachBaseContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetAttachBaseContext_Landroid_content_Context_Handler ()
		{
			if (cb_attachBaseContext_Landroid_content_Context_ == null)
				cb_attachBaseContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AttachBaseContext_Landroid_content_Context_);
			return cb_attachBaseContext_Landroid_content_Context_;
		}

		static void n_AttachBaseContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native__base)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context @base = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native__base, JniHandleOwnership.DoNotTransfer);
			__this.AttachBaseContext (@base);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='attachBaseContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("attachBaseContext", "(Landroid/content/Context;)V", "GetAttachBaseContext_Landroid_content_Context_Handler")]
		protected virtual unsafe void AttachBaseContext (global::Android.Content.Context @base)
		{
			const string __id = "attachBaseContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@base == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @base).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I;
#pragma warning disable 0169
		static Delegate GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler ()
		{
			if (cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I == null)
				cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_BindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I);
			return cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I;
		}

		static bool n_BindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_conn, int flags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent service = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_service, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IServiceConnection conn = (global::Android.Content.IServiceConnection)global::Java.Lang.Object.GetObject<global::Android.Content.IServiceConnection> (native_conn, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BindService (service, conn, flags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='bindService' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.ServiceConnection'] and parameter[3][@type='int']]"
		[Register ("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", "GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler")]
		public override unsafe bool BindService (global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags)
		{
			const string __id = "bindService.(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [2] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetBindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_Handler ()
		{
			if (cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_ == null)
				cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_BindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_);
			return cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_;
		}

		static bool n_BindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_conn, int flags, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent service = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_service, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IServiceConnection conn = (global::Android.Content.IServiceConnection)global::Java.Lang.Object.GetObject<global::Android.Content.IServiceConnection> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BindServiceAsUser (service, conn, flags, user);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='bindServiceAsUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.ServiceConnection'] and parameter[3][@type='int'] and parameter[4][@type='android.os.UserHandle']]"
		[Register ("bindServiceAsUser", "(Landroid/content/Intent;Landroid/content/ServiceConnection;ILandroid/os/UserHandle;)Z", "GetBindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_Handler")]
		public override unsafe bool BindServiceAsUser (global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags, global::Android.OS.UserHandle user)
		{
			const string __id = "bindServiceAsUser.(Landroid/content/Intent;Landroid/content/ServiceConnection;ILandroid/os/UserHandle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [2] = new JniArgumentValue (flags);
				__args [3] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canStartActivityForResult;
#pragma warning disable 0169
		static Delegate GetCanStartActivityForResultHandler ()
		{
			if (cb_canStartActivityForResult == null)
				cb_canStartActivityForResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanStartActivityForResult);
			return cb_canStartActivityForResult;
		}

		static bool n_CanStartActivityForResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanStartActivityForResult ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='canStartActivityForResult' and count(parameter)=0]"
		[Register ("canStartActivityForResult", "()Z", "GetCanStartActivityForResultHandler")]
		public override unsafe bool CanStartActivityForResult ()
		{
			const string __id = "canStartActivityForResult.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkCallingOrSelfPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckCallingOrSelfPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkCallingOrSelfPermission_Ljava_lang_String_ == null)
				cb_checkCallingOrSelfPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckCallingOrSelfPermission_Ljava_lang_String_);
			return cb_checkCallingOrSelfPermission_Ljava_lang_String_;
		}

		static int n_CheckCallingOrSelfPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingOrSelfPermission (permission);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkCallingOrSelfPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", "GetCheckCallingOrSelfPermission_Ljava_lang_String_Handler")]
		public override unsafe int CheckCallingOrSelfPermission (string permission)
		{
			const string __id = "checkCallingOrSelfPermission.(Ljava/lang/String;)I";
			IntPtr native_permission = JNIEnv.NewString (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_permission);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
			}
		}

		static Delegate cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetCheckCallingOrSelfUriPermission_Landroid_net_Uri_IHandler ()
		{
			if (cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I == null)
				cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_CheckCallingOrSelfUriPermission_Landroid_net_Uri_I);
			return cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I;
		}

		static int n_CheckCallingOrSelfUriPermission_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int modeFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingOrSelfUriPermission (uri, modeFlags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkCallingOrSelfUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingOrSelfUriPermission_Landroid_net_Uri_IHandler")]
		public override unsafe int CheckCallingOrSelfUriPermission (global::Android.Net.Uri uri, int modeFlags)
		{
			const string __id = "checkCallingOrSelfUriPermission.(Landroid/net/Uri;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (modeFlags);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkCallingPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckCallingPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkCallingPermission_Ljava_lang_String_ == null)
				cb_checkCallingPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckCallingPermission_Ljava_lang_String_);
			return cb_checkCallingPermission_Ljava_lang_String_;
		}

		static int n_CheckCallingPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingPermission (permission);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkCallingPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkCallingPermission", "(Ljava/lang/String;)I", "GetCheckCallingPermission_Ljava_lang_String_Handler")]
		public override unsafe int CheckCallingPermission (string permission)
		{
			const string __id = "checkCallingPermission.(Ljava/lang/String;)I";
			IntPtr native_permission = JNIEnv.NewString (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_permission);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
			}
		}

		static Delegate cb_checkCallingUriPermission_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetCheckCallingUriPermission_Landroid_net_Uri_IHandler ()
		{
			if (cb_checkCallingUriPermission_Landroid_net_Uri_I == null)
				cb_checkCallingUriPermission_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_CheckCallingUriPermission_Landroid_net_Uri_I);
			return cb_checkCallingUriPermission_Landroid_net_Uri_I;
		}

		static int n_CheckCallingUriPermission_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int modeFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingUriPermission (uri, modeFlags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkCallingUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("checkCallingUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingUriPermission_Landroid_net_Uri_IHandler")]
		public override unsafe int CheckCallingUriPermission (global::Android.Net.Uri uri, int modeFlags)
		{
			const string __id = "checkCallingUriPermission.(Landroid/net/Uri;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (modeFlags);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkPermission_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetCheckPermission_Ljava_lang_String_IIHandler ()
		{
			if (cb_checkPermission_Ljava_lang_String_II == null)
				cb_checkPermission_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_CheckPermission_Ljava_lang_String_II);
			return cb_checkPermission_Ljava_lang_String_II;
		}

		static int n_CheckPermission_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_permission, int pid, int uid)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckPermission (permission, pid, uid);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkPermission' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPermission", "(Ljava/lang/String;II)I", "GetCheckPermission_Ljava_lang_String_IIHandler")]
		public override unsafe int CheckPermission (string permission, int pid, int uid)
		{
			const string __id = "checkPermission.(Ljava/lang/String;II)I";
			IntPtr native_permission = JNIEnv.NewString (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_permission);
				__args [1] = new JniArgumentValue (pid);
				__args [2] = new JniArgumentValue (uid);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
			}
		}

		static Delegate cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetCheckPermission_Ljava_lang_String_IILandroid_os_IBinder_Handler ()
		{
			if (cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_ == null)
				cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>) n_CheckPermission_Ljava_lang_String_IILandroid_os_IBinder_);
			return cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_;
		}

		static int n_CheckPermission_Ljava_lang_String_IILandroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission, int pid, int uid, IntPtr native_callerToken)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder callerToken = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_callerToken, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckPermission (permission, pid, uid, callerToken);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkPermission' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.IBinder']]"
		[Register ("checkPermission", "(Ljava/lang/String;IILandroid/os/IBinder;)I", "GetCheckPermission_Ljava_lang_String_IILandroid_os_IBinder_Handler")]
		public override unsafe int CheckPermission (string permission, int pid, int uid, global::Android.OS.IBinder callerToken)
		{
			const string __id = "checkPermission.(Ljava/lang/String;IILandroid/os/IBinder;)I";
			IntPtr native_permission = JNIEnv.NewString (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_permission);
				__args [1] = new JniArgumentValue (pid);
				__args [2] = new JniArgumentValue (uid);
				__args [3] = new JniArgumentValue ((callerToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerToken).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
			}
		}

		static Delegate cb_checkSelfPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckSelfPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkSelfPermission_Ljava_lang_String_ == null)
				cb_checkSelfPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckSelfPermission_Ljava_lang_String_);
			return cb_checkSelfPermission_Ljava_lang_String_;
		}

		static int n_CheckSelfPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckSelfPermission (permission);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkSelfPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkSelfPermission", "(Ljava/lang/String;)I", "GetCheckSelfPermission_Ljava_lang_String_Handler")]
		public override unsafe int CheckSelfPermission (string permission)
		{
			const string __id = "checkSelfPermission.(Ljava/lang/String;)I";
			IntPtr native_permission = JNIEnv.NewString (permission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_permission);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
			}
		}

		static Delegate cb_checkUriPermission_Landroid_net_Uri_III;
#pragma warning disable 0169
		static Delegate GetCheckUriPermission_Landroid_net_Uri_IIIHandler ()
		{
			if (cb_checkUriPermission_Landroid_net_Uri_III == null)
				cb_checkUriPermission_Landroid_net_Uri_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_CheckUriPermission_Landroid_net_Uri_III);
			return cb_checkUriPermission_Landroid_net_Uri_III;
		}

		static int n_CheckUriPermission_Landroid_net_Uri_III (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int pid, int uid, int modeFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckUriPermission (uri, pid, uid, modeFlags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkUriPermission' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;III)I", "GetCheckUriPermission_Landroid_net_Uri_IIIHandler")]
		public override unsafe int CheckUriPermission (global::Android.Net.Uri uri, int pid, int uid, int modeFlags)
		{
			const string __id = "checkUriPermission.(Landroid/net/Uri;III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (pid);
				__args [2] = new JniArgumentValue (uid);
				__args [3] = new JniArgumentValue (modeFlags);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetCheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_Handler ()
		{
			if (cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_ == null)
				cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, int>) n_CheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_);
			return cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_;
		}

		static int n_CheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int pid, int uid, int modeFlags, IntPtr native_callerToken)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder callerToken = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_callerToken, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckUriPermission (uri, pid, uid, modeFlags, callerToken);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkUriPermission' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.os.IBinder']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;IIILandroid/os/IBinder;)I", "GetCheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_Handler")]
		public override unsafe int CheckUriPermission (global::Android.Net.Uri uri, int pid, int uid, int modeFlags, global::Android.OS.IBinder callerToken)
		{
			const string __id = "checkUriPermission.(Landroid/net/Uri;IIILandroid/os/IBinder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (pid);
				__args [2] = new JniArgumentValue (uid);
				__args [3] = new JniArgumentValue (modeFlags);
				__args [4] = new JniArgumentValue ((callerToken == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callerToken).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetCheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIIHandler ()
		{
			if (cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III == null)
				cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int>) n_CheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III);
			return cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III;
		}

		static int n_CheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_readPermission, IntPtr native_writePermission, int pid, int uid, int modeFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string readPermission = JNIEnv.GetString (native_readPermission, JniHandleOwnership.DoNotTransfer);
			string writePermission = JNIEnv.GetString (native_writePermission, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckUriPermission (uri, readPermission, writePermission, pid, uid, modeFlags);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='checkUriPermission' and count(parameter)=6 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", "GetCheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public override unsafe int CheckUriPermission (global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags)
		{
			const string __id = "checkUriPermission.(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I";
			IntPtr native_readPermission = JNIEnv.NewString (readPermission);
			IntPtr native_writePermission = JNIEnv.NewString (writePermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_readPermission);
				__args [2] = new JniArgumentValue (native_writePermission);
				__args [3] = new JniArgumentValue (pid);
				__args [4] = new JniArgumentValue (uid);
				__args [5] = new JniArgumentValue (modeFlags);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_readPermission);
				JNIEnv.DeleteLocalRef (native_writePermission);
			}
		}

		static Delegate cb_clearWallpaper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetClearWallpaperHandler ()
		{
			if (cb_clearWallpaper == null)
				cb_clearWallpaper = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearWallpaper);
			return cb_clearWallpaper;
		}

		[Obsolete]
		static void n_ClearWallpaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearWallpaper ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='clearWallpaper' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearWallpaper", "()V", "GetClearWallpaperHandler")]
		public override unsafe void ClearWallpaper ()
		{
			const string __id = "clearWallpaper.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I;
#pragma warning disable 0169
		static Delegate GetCreateApplicationContext_Landroid_content_pm_ApplicationInfo_IHandler ()
		{
			if (cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I == null)
				cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreateApplicationContext_Landroid_content_pm_ApplicationInfo_I);
			return cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I;
		}

		static IntPtr n_CreateApplicationContext_Landroid_content_pm_ApplicationInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_application, int flags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.PM.ApplicationInfo application = global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (native_application, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateApplicationContext (application, flags));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='createApplicationContext' and count(parameter)=2 and parameter[1][@type='android.content.pm.ApplicationInfo'] and parameter[2][@type='int']]"
		[Register ("createApplicationContext", "(Landroid/content/pm/ApplicationInfo;I)Landroid/content/Context;", "GetCreateApplicationContext_Landroid_content_pm_ApplicationInfo_IHandler")]
		public override unsafe global::Android.Content.Context CreateApplicationContext (global::Android.Content.PM.ApplicationInfo application, int flags)
		{
			const string __id = "createApplicationContext.(Landroid/content/pm/ApplicationInfo;I)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((application == null) ? IntPtr.Zero : ((global::Java.Lang.Object) application).Handle);
				__args [1] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createConfigurationContext_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_createConfigurationContext_Landroid_content_res_Configuration_ == null)
				cb_createConfigurationContext_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateConfigurationContext_Landroid_content_res_Configuration_);
			return cb_createConfigurationContext_Landroid_content_res_Configuration_;
		}

		static IntPtr n_CreateConfigurationContext_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overrideConfiguration)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration overrideConfiguration = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_overrideConfiguration, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConfigurationContext (overrideConfiguration));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='createConfigurationContext' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("createConfigurationContext", "(Landroid/content/res/Configuration;)Landroid/content/Context;", "GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler")]
		public override unsafe global::Android.Content.Context CreateConfigurationContext (global::Android.Content.Res.Configuration overrideConfiguration)
		{
			const string __id = "createConfigurationContext.(Landroid/content/res/Configuration;)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((overrideConfiguration == null) ? IntPtr.Zero : ((global::Java.Lang.Object) overrideConfiguration).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createDisplayContext_Landroid_view_Display_;
#pragma warning disable 0169
		static Delegate GetCreateDisplayContext_Landroid_view_Display_Handler ()
		{
			if (cb_createDisplayContext_Landroid_view_Display_ == null)
				cb_createDisplayContext_Landroid_view_Display_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDisplayContext_Landroid_view_Display_);
			return cb_createDisplayContext_Landroid_view_Display_;
		}

		static IntPtr n_CreateDisplayContext_Landroid_view_Display_ (IntPtr jnienv, IntPtr native__this, IntPtr native_display)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Display display = global::Java.Lang.Object.GetObject<global::Android.Views.Display> (native_display, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDisplayContext (display));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='createDisplayContext' and count(parameter)=1 and parameter[1][@type='android.view.Display']]"
		[Register ("createDisplayContext", "(Landroid/view/Display;)Landroid/content/Context;", "GetCreateDisplayContext_Landroid_view_Display_Handler")]
		public override unsafe global::Android.Content.Context CreateDisplayContext (global::Android.Views.Display display)
		{
			const string __id = "createDisplayContext.(Landroid/view/Display;)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((display == null) ? IntPtr.Zero : ((global::Java.Lang.Object) display).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_createPackageContext_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCreatePackageContext_Ljava_lang_String_IHandler ()
		{
			if (cb_createPackageContext_Ljava_lang_String_I == null)
				cb_createPackageContext_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreatePackageContext_Ljava_lang_String_I);
			return cb_createPackageContext_Ljava_lang_String_I;
		}

		static IntPtr n_CreatePackageContext_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName, int flags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePackageContext (packageName, flags));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='createPackageContext' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", "GetCreatePackageContext_Ljava_lang_String_IHandler")]
		public override unsafe global::Android.Content.Context CreatePackageContext (string packageName, int flags)
		{
			const string __id = "createPackageContext.(Ljava/lang/String;I)Landroid/content/Context;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (flags);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetCreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_Handler ()
		{
			if (cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_ == null)
				cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_);
			return cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_;
		}

		static IntPtr n_CreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packageName, int flags, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string packageName = JNIEnv.GetString (native_packageName, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePackageContextAsUser (packageName, flags, user));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='createPackageContextAsUser' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("createPackageContextAsUser", "(Ljava/lang/String;ILandroid/os/UserHandle;)Landroid/content/Context;", "GetCreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_Handler")]
		public override unsafe global::Android.Content.Context CreatePackageContextAsUser (string packageName, int flags, global::Android.OS.UserHandle user)
		{
			const string __id = "createPackageContextAsUser.(Ljava/lang/String;ILandroid/os/UserHandle;)Landroid/content/Context;";
			IntPtr native_packageName = JNIEnv.NewString (packageName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_packageName);
				__args [1] = new JniArgumentValue (flags);
				__args [2] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_packageName);
			}
		}

		static Delegate cb_databaseList;
#pragma warning disable 0169
		static Delegate GetDatabaseListHandler ()
		{
			if (cb_databaseList == null)
				cb_databaseList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DatabaseList);
			return cb_databaseList;
		}

		static IntPtr n_DatabaseList (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.DatabaseList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='databaseList' and count(parameter)=0]"
		[Register ("databaseList", "()[Ljava/lang/String;", "GetDatabaseListHandler")]
		public override unsafe string[] DatabaseList ()
		{
			const string __id = "databaseList.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_deleteDatabase_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteDatabase_Ljava_lang_String_Handler ()
		{
			if (cb_deleteDatabase_Ljava_lang_String_ == null)
				cb_deleteDatabase_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteDatabase_Ljava_lang_String_);
			return cb_deleteDatabase_Ljava_lang_String_;
		}

		static bool n_DeleteDatabase_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteDatabase (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='deleteDatabase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteDatabase", "(Ljava/lang/String;)Z", "GetDeleteDatabase_Ljava_lang_String_Handler")]
		public override unsafe bool DeleteDatabase (string name)
		{
			const string __id = "deleteDatabase.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_deleteFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_ == null)
				cb_deleteFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteFile_Ljava_lang_String_);
			return cb_deleteFile_Ljava_lang_String_;
		}

		static bool n_DeleteFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFile (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "GetDeleteFile_Ljava_lang_String_Handler")]
		public override unsafe bool DeleteFile (string name)
		{
			const string __id = "deleteFile.(Ljava/lang/String;)Z";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_);
			return cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingOrSelfPermission (permission, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforceCallingOrSelfPermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void EnforceCallingOrSelfPermission (string permission, string message)
		{
			const string __id = "enforceCallingOrSelfPermission.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_permission = JNIEnv.NewString (permission);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_permission);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler ()
		{
			if (cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ == null)
				cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_EnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_);
			return cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_;
		}

		static void n_EnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int modeFlags, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingOrSelfUriPermission (uri, modeFlags, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforceCallingOrSelfUriPermission' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public override unsafe void EnforceCallingOrSelfUriPermission (global::Android.Net.Uri uri, int modeFlags, string message)
		{
			const string __id = "enforceCallingOrSelfUriPermission.(Landroid/net/Uri;ILjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (modeFlags);
				__args [2] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_);
			return cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingPermission (permission, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforceCallingPermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void EnforceCallingPermission (string permission, string message)
		{
			const string __id = "enforceCallingPermission.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_permission = JNIEnv.NewString (permission);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_permission);
				__args [1] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler ()
		{
			if (cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ == null)
				cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_EnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_);
			return cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_;
		}

		static void n_EnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int modeFlags, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingUriPermission (uri, modeFlags, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforceCallingUriPermission' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public override unsafe void EnforceCallingUriPermission (global::Android.Net.Uri uri, int modeFlags, string message)
		{
			const string __id = "enforceCallingUriPermission.(Landroid/net/Uri;ILjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (modeFlags);
				__args [2] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforcePermission_Ljava_lang_String_IILjava_lang_String_Handler ()
		{
			if (cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_ == null)
				cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_EnforcePermission_Ljava_lang_String_IILjava_lang_String_);
			return cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_;
		}

		static void n_EnforcePermission_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_permission, int pid, int uid, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string permission = JNIEnv.GetString (native_permission, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforcePermission (permission, pid, uid, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforcePermission' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", "GetEnforcePermission_Ljava_lang_String_IILjava_lang_String_Handler")]
		public override unsafe void EnforcePermission (string permission, int pid, int uid, string message)
		{
			const string __id = "enforcePermission.(Ljava/lang/String;IILjava/lang/String;)V";
			IntPtr native_permission = JNIEnv.NewString (permission);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_permission);
				__args [1] = new JniArgumentValue (pid);
				__args [2] = new JniArgumentValue (uid);
				__args [3] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_permission);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_Handler ()
		{
			if (cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ == null)
				cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_EnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_);
			return cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_;
		}

		static void n_EnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int pid, int uid, int modeFlags, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforceUriPermission (uri, pid, uid, modeFlags, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforceUriPermission' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_Handler")]
		public override unsafe void EnforceUriPermission (global::Android.Net.Uri uri, int pid, int uid, int modeFlags, string message)
		{
			const string __id = "enforceUriPermission.(Landroid/net/Uri;IIILjava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (pid);
				__args [2] = new JniArgumentValue (uid);
				__args [3] = new JniArgumentValue (modeFlags);
				__args [4] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler ()
		{
			if (cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ == null)
				cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_EnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_);
			return cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
		}

		static void n_EnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, IntPtr native_readPermission, IntPtr native_writePermission, int pid, int uid, int modeFlags, IntPtr native_message)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			string readPermission = JNIEnv.GetString (native_readPermission, JniHandleOwnership.DoNotTransfer);
			string writePermission = JNIEnv.GetString (native_writePermission, JniHandleOwnership.DoNotTransfer);
			string message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.EnforceUriPermission (uri, readPermission, writePermission, pid, uid, modeFlags, message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='enforceUriPermission' and count(parameter)=7 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String']]"
		[Register ("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler")]
		public override unsafe void EnforceUriPermission (global::Android.Net.Uri uri, string readPermission, string writePermission, int pid, int uid, int modeFlags, string message)
		{
			const string __id = "enforceUriPermission.(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V";
			IntPtr native_readPermission = JNIEnv.NewString (readPermission);
			IntPtr native_writePermission = JNIEnv.NewString (writePermission);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (native_readPermission);
				__args [2] = new JniArgumentValue (native_writePermission);
				__args [3] = new JniArgumentValue (pid);
				__args [4] = new JniArgumentValue (uid);
				__args [5] = new JniArgumentValue (modeFlags);
				__args [6] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_readPermission);
				JNIEnv.DeleteLocalRef (native_writePermission);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_fileList;
#pragma warning disable 0169
		static Delegate GetFileListHandler ()
		{
			if (cb_fileList == null)
				cb_fileList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FileList);
			return cb_fileList;
		}

		static IntPtr n_FileList (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.FileList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='fileList' and count(parameter)=0]"
		[Register ("fileList", "()[Ljava/lang/String;", "GetFileListHandler")]
		public override unsafe string[] FileList ()
		{
			const string __id = "fileList.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getDatabasePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDatabasePath_Ljava_lang_String_Handler ()
		{
			if (cb_getDatabasePath_Ljava_lang_String_ == null)
				cb_getDatabasePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDatabasePath_Ljava_lang_String_);
			return cb_getDatabasePath_Ljava_lang_String_;
		}

		static IntPtr n_GetDatabasePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDatabasePath (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getDatabasePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetDatabasePath_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetDatabasePath (string name)
		{
			const string __id = "getDatabasePath.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDir_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetDir_Ljava_lang_String_IHandler ()
		{
			if (cb_getDir_Ljava_lang_String_I == null)
				cb_getDir_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetDir_Ljava_lang_String_I);
			return cb_getDir_Ljava_lang_String_I;
		}

		static IntPtr n_GetDir_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int mode)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDir (name, mode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getDir' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getDir", "(Ljava/lang/String;I)Ljava/io/File;", "GetGetDir_Ljava_lang_String_IHandler")]
		public override unsafe global::Java.IO.File GetDir (string name, int mode)
		{
			const string __id = "getDir.(Ljava/lang/String;I)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getDisplayAdjustments_I;
#pragma warning disable 0169
		static Delegate GetGetDisplayAdjustments_IHandler ()
		{
			if (cb_getDisplayAdjustments_I == null)
				cb_getDisplayAdjustments_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDisplayAdjustments_I);
			return cb_getDisplayAdjustments_I;
		}

		static IntPtr n_GetDisplayAdjustments_I (IntPtr jnienv, IntPtr native__this, int displayId)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDisplayAdjustments (displayId));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getDisplayAdjustments' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDisplayAdjustments", "(I)Landroid/view/DisplayAdjustments;", "GetGetDisplayAdjustments_IHandler")]
		public override unsafe global::Android.View.DisplayAdjustments GetDisplayAdjustments (int displayId)
		{
			const string __id = "getDisplayAdjustments.(I)Landroid/view/DisplayAdjustments;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (displayId);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.View.DisplayAdjustments> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getExternalCacheDirs;
#pragma warning disable 0169
		static Delegate GetGetExternalCacheDirsHandler ()
		{
			if (cb_getExternalCacheDirs == null)
				cb_getExternalCacheDirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalCacheDirs);
			return cb_getExternalCacheDirs;
		}

		static IntPtr n_GetExternalCacheDirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExternalCacheDirs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getExternalCacheDirs' and count(parameter)=0]"
		[Register ("getExternalCacheDirs", "()[Ljava/io/File;", "GetGetExternalCacheDirsHandler")]
		public override unsafe global::Java.IO.File[] GetExternalCacheDirs ()
		{
			const string __id = "getExternalCacheDirs.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		static Delegate cb_getExternalFilesDir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExternalFilesDir_Ljava_lang_String_Handler ()
		{
			if (cb_getExternalFilesDir_Ljava_lang_String_ == null)
				cb_getExternalFilesDir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExternalFilesDir_Ljava_lang_String_);
			return cb_getExternalFilesDir_Ljava_lang_String_;
		}

		static IntPtr n_GetExternalFilesDir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetExternalFilesDir (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getExternalFilesDir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", "GetGetExternalFilesDir_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetExternalFilesDir (string type)
		{
			const string __id = "getExternalFilesDir.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		static Delegate cb_getExternalFilesDirs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExternalFilesDirs_Ljava_lang_String_Handler ()
		{
			if (cb_getExternalFilesDirs_Ljava_lang_String_ == null)
				cb_getExternalFilesDirs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExternalFilesDirs_Ljava_lang_String_);
			return cb_getExternalFilesDirs_Ljava_lang_String_;
		}

		static IntPtr n_GetExternalFilesDirs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string type = JNIEnv.GetString (native_type, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetExternalFilesDirs (type));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getExternalFilesDirs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExternalFilesDirs", "(Ljava/lang/String;)[Ljava/io/File;", "GetGetExternalFilesDirs_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File[] GetExternalFilesDirs (string type)
		{
			const string __id = "getExternalFilesDirs.(Ljava/lang/String;)[Ljava/io/File;";
			IntPtr native_type = JNIEnv.NewString (type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
				JNIEnv.DeleteLocalRef (native_type);
			}
		}

		static Delegate cb_getExternalMediaDirs;
#pragma warning disable 0169
		static Delegate GetGetExternalMediaDirsHandler ()
		{
			if (cb_getExternalMediaDirs == null)
				cb_getExternalMediaDirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalMediaDirs);
			return cb_getExternalMediaDirs;
		}

		static IntPtr n_GetExternalMediaDirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExternalMediaDirs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getExternalMediaDirs' and count(parameter)=0]"
		[Register ("getExternalMediaDirs", "()[Ljava/io/File;", "GetGetExternalMediaDirsHandler")]
		public override unsafe global::Java.IO.File[] GetExternalMediaDirs ()
		{
			const string __id = "getExternalMediaDirs.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		static Delegate cb_getFileStreamPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFileStreamPath_Ljava_lang_String_Handler ()
		{
			if (cb_getFileStreamPath_Ljava_lang_String_ == null)
				cb_getFileStreamPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFileStreamPath_Ljava_lang_String_);
			return cb_getFileStreamPath_Ljava_lang_String_;
		}

		static IntPtr n_GetFileStreamPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFileStreamPath (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getFileStreamPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetFileStreamPath_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetFileStreamPath (string name)
		{
			const string __id = "getFileStreamPath.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getObbDirs;
#pragma warning disable 0169
		static Delegate GetGetObbDirsHandler ()
		{
			if (cb_getObbDirs == null)
				cb_getObbDirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObbDirs);
			return cb_getObbDirs;
		}

		static IntPtr n_GetObbDirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetObbDirs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getObbDirs' and count(parameter)=0]"
		[Register ("getObbDirs", "()[Ljava/io/File;", "GetGetObbDirsHandler")]
		public override unsafe global::Java.IO.File[] GetObbDirs ()
		{
			const string __id = "getObbDirs.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		static Delegate cb_getSharedPreferences_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetSharedPreferences_Ljava_lang_String_IHandler ()
		{
			if (cb_getSharedPreferences_Ljava_lang_String_I == null)
				cb_getSharedPreferences_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetSharedPreferences_Ljava_lang_String_I);
			return cb_getSharedPreferences_Ljava_lang_String_I;
		}

		static IntPtr n_GetSharedPreferences_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int mode)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSharedPreferences (name, mode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getSharedPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", "GetGetSharedPreferences_Ljava_lang_String_IHandler")]
		public override unsafe global::Android.Content.ISharedPreferences GetSharedPreferences (string name, int mode)
		{
			const string __id = "getSharedPreferences.(Ljava/lang/String;I)Landroid/content/SharedPreferences;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getSharedPrefsFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSharedPrefsFile_Ljava_lang_String_Handler ()
		{
			if (cb_getSharedPrefsFile_Ljava_lang_String_ == null)
				cb_getSharedPrefsFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSharedPrefsFile_Ljava_lang_String_);
			return cb_getSharedPrefsFile_Ljava_lang_String_;
		}

		static IntPtr n_GetSharedPrefsFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSharedPrefsFile (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getSharedPrefsFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSharedPrefsFile", "(Ljava/lang/String;)Ljava/io/File;", "GetGetSharedPrefsFile_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetSharedPrefsFile (string name)
		{
			const string __id = "getSharedPrefsFile.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getSystemService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSystemService_Ljava_lang_String_Handler ()
		{
			if (cb_getSystemService_Ljava_lang_String_ == null)
				cb_getSystemService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSystemService_Ljava_lang_String_);
			return cb_getSystemService_Ljava_lang_String_;
		}

		static IntPtr n_GetSystemService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSystemService (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getSystemService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetSystemService_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Lang.Object GetSystemService (string name)
		{
			const string __id = "getSystemService.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_getSystemServiceName_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetSystemServiceName_Ljava_lang_Class_Handler ()
		{
			if (cb_getSystemServiceName_Ljava_lang_Class_ == null)
				cb_getSystemServiceName_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSystemServiceName_Ljava_lang_Class_);
			return cb_getSystemServiceName_Ljava_lang_Class_;
		}

		static IntPtr n_GetSystemServiceName_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_serviceClass)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class serviceClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_serviceClass, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSystemServiceName (serviceClass));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='getSystemServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getSystemServiceName", "(Ljava/lang/Class;)Ljava/lang/String;", "GetGetSystemServiceName_Ljava_lang_Class_Handler")]
		public override unsafe string GetSystemServiceName (global::Java.Lang.Class serviceClass)
		{
			const string __id = "getSystemServiceName.(Ljava/lang/Class;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serviceClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceClass).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetGrantUriPermission_Ljava_lang_String_Landroid_net_Uri_IHandler ()
		{
			if (cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I == null)
				cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GrantUriPermission_Ljava_lang_String_Landroid_net_Uri_I);
			return cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I;
		}

		static void n_GrantUriPermission_Ljava_lang_String_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_toPackage, IntPtr native_uri, int modeFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string toPackage = JNIEnv.GetString (native_toPackage, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.GrantUriPermission (toPackage, uri, modeFlags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='grantUriPermission' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", "GetGrantUriPermission_Ljava_lang_String_Landroid_net_Uri_IHandler")]
		public override unsafe void GrantUriPermission (string toPackage, global::Android.Net.Uri uri, int modeFlags)
		{
			const string __id = "grantUriPermission.(Ljava/lang/String;Landroid/net/Uri;I)V";
			IntPtr native_toPackage = JNIEnv.NewString (toPackage);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_toPackage);
				__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [2] = new JniArgumentValue (modeFlags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_toPackage);
			}
		}

		static Delegate cb_openFileInput_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenFileInput_Ljava_lang_String_Handler ()
		{
			if (cb_openFileInput_Ljava_lang_String_ == null)
				cb_openFileInput_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenFileInput_Ljava_lang_String_);
			return cb_openFileInput_Ljava_lang_String_;
		}

		static IntPtr n_OpenFileInput_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.OpenFileInput (name));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='openFileInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", "GetOpenFileInput_Ljava_lang_String_Handler")]
		public override unsafe global::System.IO.Stream OpenFileInput (string name)
		{
			const string __id = "openFileInput.(Ljava/lang/String;)Ljava/io/FileInputStream;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_openFileOutput_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpenFileOutput_Ljava_lang_String_IHandler ()
		{
			if (cb_openFileOutput_Ljava_lang_String_I == null)
				cb_openFileOutput_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OpenFileOutput_Ljava_lang_String_I);
			return cb_openFileOutput_Ljava_lang_String_I;
		}

		static IntPtr n_OpenFileOutput_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int mode)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OpenFileOutput (name, mode));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='openFileOutput' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", "GetOpenFileOutput_Ljava_lang_String_IHandler")]
		public override unsafe global::System.IO.Stream OpenFileOutput (string name, int mode)
		{
			const string __id = "openFileOutput.(Ljava/lang/String;I)Ljava/io/FileOutputStream;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (mode);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_;
#pragma warning disable 0169
		static Delegate GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Handler ()
		{
			if (cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ == null)
				cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_);
			return cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_;
		}

		static IntPtr n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int mode, IntPtr native_factory)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory = (global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory)global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenOrCreateDatabase (name, mode, factory));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='openOrCreateDatabase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory']]"
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Handler")]
		public override unsafe global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory)
		{
			const string __id = "openOrCreateDatabase.(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (mode);
				__args [2] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_;
#pragma warning disable 0169
		static Delegate GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_Handler ()
		{
			if (cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ == null)
				cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_);
			return cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_;
		}

		static IntPtr n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, int mode, IntPtr native_factory, IntPtr native_errorHandler)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory = (global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory)global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory> (native_factory, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.IDatabaseErrorHandler errorHandler = (global::Android.Database.IDatabaseErrorHandler)global::Java.Lang.Object.GetObject<global::Android.Database.IDatabaseErrorHandler> (native_errorHandler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenOrCreateDatabase (name, mode, factory, errorHandler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='openOrCreateDatabase' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory'] and parameter[4][@type='android.database.DatabaseErrorHandler']]"
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_Handler")]
		public override unsafe global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string name, int mode, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory factory, global::Android.Database.IDatabaseErrorHandler errorHandler)
		{
			const string __id = "openOrCreateDatabase.(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue (mode);
				__args [2] = new JniArgumentValue ((factory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) factory).Handle);
				__args [3] = new JniArgumentValue ((errorHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) errorHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_peekWallpaper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPeekWallpaperHandler ()
		{
			if (cb_peekWallpaper == null)
				cb_peekWallpaper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekWallpaper);
			return cb_peekWallpaper;
		}

		[Obsolete]
		static IntPtr n_PeekWallpaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekWallpaper ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='peekWallpaper' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetPeekWallpaperHandler")]
		public override unsafe global::Android.Graphics.Drawables.Drawable PeekWallpaper ()
		{
			const string __id = "peekWallpaper.()Landroid/graphics/drawable/Drawable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler ()
		{
			if (cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == null)
				cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_);
			return cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		}

		static IntPtr n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver, IntPtr native_filter)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter filter = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiver (receiver, filter));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='registerReceiver' and count(parameter)=2 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler")]
		public override unsafe global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter)
		{
			const string __id = "registerReceiver.(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [1] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler ()
		{
			if (cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ == null)
				cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_);
			return cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
		}

		static IntPtr n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver, IntPtr native_filter, IntPtr native_broadcastPermission, IntPtr native_scheduler)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter filter = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			string broadcastPermission = JNIEnv.GetString (native_broadcastPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiver (receiver, filter, broadcastPermission, scheduler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='registerReceiver' and count(parameter)=4 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Handler']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public override unsafe global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver receiver, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.OS.Handler scheduler)
		{
			const string __id = "registerReceiver.(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;";
			IntPtr native_broadcastPermission = JNIEnv.NewString (broadcastPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [1] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				__args [2] = new JniArgumentValue (native_broadcastPermission);
				__args [3] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_broadcastPermission);
			}
		}

		static Delegate cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler ()
		{
			if (cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ == null)
				cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_);
			return cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
		}

		static IntPtr n_RegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver, IntPtr native_user, IntPtr native_filter, IntPtr native_broadcastPermission, IntPtr native_scheduler)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter filter = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_filter, JniHandleOwnership.DoNotTransfer);
			string broadcastPermission = JNIEnv.GetString (native_broadcastPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiverAsUser (receiver, user, filter, broadcastPermission, scheduler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='registerReceiverAsUser' and count(parameter)=5 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='android.content.IntentFilter'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Handler']]"
		[Register ("registerReceiverAsUser", "(Landroid/content/BroadcastReceiver;Landroid/os/UserHandle;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public override unsafe global::Android.Content.Intent RegisterReceiverAsUser (global::Android.Content.BroadcastReceiver receiver, global::Android.OS.UserHandle user, global::Android.Content.IntentFilter filter, string broadcastPermission, global::Android.OS.Handler scheduler)
		{
			const string __id = "registerReceiverAsUser.(Landroid/content/BroadcastReceiver;Landroid/os/UserHandle;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;";
			IntPtr native_broadcastPermission = JNIEnv.NewString (broadcastPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue ((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filter).Handle);
				__args [3] = new JniArgumentValue (native_broadcastPermission);
				__args [4] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_broadcastPermission);
			}
		}

		static Delegate cb_removeStickyBroadcast_Landroid_content_Intent_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetRemoveStickyBroadcast_Landroid_content_Intent_Handler ()
		{
			if (cb_removeStickyBroadcast_Landroid_content_Intent_ == null)
				cb_removeStickyBroadcast_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveStickyBroadcast_Landroid_content_Intent_);
			return cb_removeStickyBroadcast_Landroid_content_Intent_;
		}

		[Obsolete]
		static void n_RemoveStickyBroadcast_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStickyBroadcast (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='removeStickyBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Obsolete (@"deprecated")]
		[Register ("removeStickyBroadcast", "(Landroid/content/Intent;)V", "GetRemoveStickyBroadcast_Landroid_content_Intent_Handler")]
		public override unsafe void RemoveStickyBroadcast (global::Android.Content.Intent intent)
		{
			const string __id = "removeStickyBroadcast.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetRemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		[Obsolete]
		static void n_RemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStickyBroadcastAsUser (intent, user);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='removeStickyBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Obsolete (@"deprecated")]
		[Register ("removeStickyBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetRemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void RemoveStickyBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user)
		{
			const string __id = "removeStickyBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_revokeUriPermission_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetRevokeUriPermission_Landroid_net_Uri_IHandler ()
		{
			if (cb_revokeUriPermission_Landroid_net_Uri_I == null)
				cb_revokeUriPermission_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_RevokeUriPermission_Landroid_net_Uri_I);
			return cb_revokeUriPermission_Landroid_net_Uri_I;
		}

		static void n_RevokeUriPermission_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_uri, int modeFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri uri = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_uri, JniHandleOwnership.DoNotTransfer);
			__this.RevokeUriPermission (uri, modeFlags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='revokeUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("revokeUriPermission", "(Landroid/net/Uri;I)V", "GetRevokeUriPermission_Landroid_net_Uri_IHandler")]
		public override unsafe void RevokeUriPermission (global::Android.Net.Uri uri, int modeFlags)
		{
			const string __id = "revokeUriPermission.(Landroid/net/Uri;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
				__args [1] = new JniArgumentValue (modeFlags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendBroadcast_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Handler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_ == null)
				cb_sendBroadcast_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendBroadcast_Landroid_content_Intent_);
			return cb_sendBroadcast_Landroid_content_Intent_;
		}

		static void n_SendBroadcast_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;)V", "GetSendBroadcast_Landroid_content_Intent_Handler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent intent)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_ == null)
				cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_);
			return cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_;
		}

		static void n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (intent, receiverPermission);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent intent, string receiverPermission)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
			}
		}

		static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission, IntPtr native_options)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (intent, receiverPermission, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent intent, string receiverPermission, global::Android.OS.Bundle options)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
			}
		}

		static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_IHandler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I == null)
				cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_I);
			return cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I;
		}

		static void n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission, int appOp)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (intent, receiverPermission, appOp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;I)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_IHandler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent intent, string receiverPermission, int appOp)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;Ljava/lang/String;I)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				__args [2] = new JniArgumentValue (appOp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
			}
		}

		static Delegate cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static void n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcastAsUser (intent, user);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void SendBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user)
		{
			const string __id = "sendBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Handler ()
		{
			if (cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ == null)
				cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_);
			return cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_;
		}

		static void n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user, IntPtr native_receiverPermission)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcastAsUser (intent, user, receiverPermission);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcastAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Handler")]
		public override unsafe void SendBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user, string receiverPermission)
		{
			const string __id = "sendBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue (native_receiverPermission);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
			}
		}

		static Delegate cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_IHandler ()
		{
			if (cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I == null)
				cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I);
			return cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I;
		}

		static void n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user, IntPtr native_receiverPermission, int appOp)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcastAsUser (intent, user, receiverPermission, appOp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcastAsUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;I)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_IHandler")]
		public override unsafe void SendBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user, string receiverPermission, int appOp)
		{
			const string __id = "sendBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;I)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue (native_receiverPermission);
				__args [3] = new JniArgumentValue (appOp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
			}
		}

		static Delegate cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_Handler ()
		{
			if (cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_ == null)
				cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_);
			return cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_;
		}

		static void n_SendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermissions)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string[] receiverPermissions = (string[]) JNIEnv.GetArray (native_receiverPermissions, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SendBroadcastMultiplePermissions (intent, receiverPermissions);
			if (receiverPermissions != null)
				JNIEnv.CopyArray (receiverPermissions, native_receiverPermissions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendBroadcastMultiplePermissions' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("sendBroadcastMultiplePermissions", "(Landroid/content/Intent;[Ljava/lang/String;)V", "GetSendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_Handler")]
		public override unsafe void SendBroadcastMultiplePermissions (global::Android.Content.Intent intent, string[] receiverPermissions)
		{
			const string __id = "sendBroadcastMultiplePermissions.(Landroid/content/Intent;[Ljava/lang/String;)V";
			IntPtr native_receiverPermissions = JNIEnv.NewArray (receiverPermissions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermissions);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (receiverPermissions != null) {
					JNIEnv.CopyArray (native_receiverPermissions, receiverPermissions);
					JNIEnv.DeleteLocalRef (native_receiverPermissions);
				}
			}
		}

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (intent, receiverPermission);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent intent, string receiverPermission)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
			}
		}

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (intent, receiverPermission, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcast' and count(parameter)=7 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.BroadcastReceiver'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent intent, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				__args [2] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [3] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [4] = new JniArgumentValue (initialCode);
				__args [5] = new JniArgumentValue (native_initialData);
				__args [6] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission, IntPtr native_options, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (intent, receiverPermission, options, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcast' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent intent, string receiverPermission, global::Android.OS.Bundle options, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				__args [2] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [3] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [4] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [5] = new JniArgumentValue (initialCode);
				__args [6] = new JniArgumentValue (native_initialData);
				__args [7] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_receiverPermission, int appOp, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (intent, receiverPermission, appOp, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcast' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent intent, string receiverPermission, int appOp, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue (native_receiverPermission);
				__args [2] = new JniArgumentValue (appOp);
				__args [3] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [4] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [5] = new JniArgumentValue (initialCode);
				__args [6] = new JniArgumentValue (native_initialData);
				__args [7] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user, IntPtr native_receiverPermission, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcastAsUser (intent, user, receiverPermission, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user, string receiverPermission, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue (native_receiverPermission);
				__args [3] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [4] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [5] = new JniArgumentValue (initialCode);
				__args [6] = new JniArgumentValue (native_initialData);
				__args [7] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user, IntPtr native_receiverPermission, int appOp, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcastAsUser (intent, user, receiverPermission, appOp, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=9 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='android.content.BroadcastReceiver'] and parameter[6][@type='android.os.Handler'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user, string receiverPermission, int appOp, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue (native_receiverPermission);
				__args [3] = new JniArgumentValue (appOp);
				__args [4] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [5] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [6] = new JniArgumentValue (initialCode);
				__args [7] = new JniArgumentValue (native_initialData);
				__args [8] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user, IntPtr native_receiverPermission, int appOp, IntPtr native_options, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			string receiverPermission = JNIEnv.GetString (native_receiverPermission, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcastAsUser (intent, user, receiverPermission, appOp, options, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=10 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='android.os.Bundle'] and parameter[6][@type='android.content.BroadcastReceiver'] and parameter[7][@type='android.os.Handler'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user, string receiverPermission, int appOp, global::Android.OS.Bundle options, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_receiverPermission = JNIEnv.NewString (receiverPermission);
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue (native_receiverPermission);
				__args [3] = new JniArgumentValue (appOp);
				__args [4] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [5] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [6] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [7] = new JniArgumentValue (initialCode);
				__args [8] = new JniArgumentValue (native_initialData);
				__args [9] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_receiverPermission);
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendStickyBroadcast_Landroid_content_Intent_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyBroadcast_Landroid_content_Intent_Handler ()
		{
			if (cb_sendStickyBroadcast_Landroid_content_Intent_ == null)
				cb_sendStickyBroadcast_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendStickyBroadcast_Landroid_content_Intent_);
			return cb_sendStickyBroadcast_Landroid_content_Intent_;
		}

		[Obsolete]
		static void n_SendStickyBroadcast_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyBroadcast (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendStickyBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyBroadcast", "(Landroid/content/Intent;)V", "GetSendStickyBroadcast_Landroid_content_Intent_Handler")]
		public override unsafe void SendStickyBroadcast (global::Android.Content.Intent intent)
		{
			const string __id = "sendStickyBroadcast.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		[Obsolete]
		static void n_SendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyBroadcastAsUser (intent, user);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendStickyBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetSendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void SendStickyBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user)
		{
			const string __id = "sendStickyBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		[Obsolete]
		static void n_SendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyOrderedBroadcast (intent, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendStickyOrderedBroadcast' and count(parameter)=6 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.BroadcastReceiver'] and parameter[3][@type='android.os.Handler'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.os.Bundle']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendStickyOrderedBroadcast (global::Android.Content.Intent intent, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendStickyOrderedBroadcast.(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [2] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [3] = new JniArgumentValue (initialCode);
				__args [4] = new JniArgumentValue (native_initialData);
				__args [5] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		[Obsolete]
		static void n_SendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user, IntPtr native_resultReceiver, IntPtr native_scheduler, int initialCode, IntPtr native_initialData, IntPtr native_initialExtras)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver resultReceiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_resultReceiver, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler scheduler = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_scheduler, JniHandleOwnership.DoNotTransfer);
			string initialData = JNIEnv.GetString (native_initialData, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle initialExtras = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_initialExtras, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyOrderedBroadcastAsUser (intent, user, resultReceiver, scheduler, initialCode, initialData, initialExtras);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='sendStickyOrderedBroadcastAsUser' and count(parameter)=7 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='android.content.BroadcastReceiver'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendStickyOrderedBroadcastAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user, global::Android.Content.BroadcastReceiver resultReceiver, global::Android.OS.Handler scheduler, int initialCode, string initialData, global::Android.OS.Bundle initialExtras)
		{
			const string __id = "sendStickyOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_initialData = JNIEnv.NewString (initialData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				__args [2] = new JniArgumentValue ((resultReceiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultReceiver).Handle);
				__args [3] = new JniArgumentValue ((scheduler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scheduler).Handle);
				__args [4] = new JniArgumentValue (initialCode);
				__args [5] = new JniArgumentValue (native_initialData);
				__args [6] = new JniArgumentValue ((initialExtras == null) ? IntPtr.Zero : ((global::Java.Lang.Object) initialExtras).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_initialData);
			}
		}

		static Delegate cb_setTheme_I;
#pragma warning disable 0169
		static Delegate GetSetTheme_IHandler ()
		{
			if (cb_setTheme_I == null)
				cb_setTheme_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTheme_I);
			return cb_setTheme_I;
		}

		static void n_SetTheme_I (IntPtr jnienv, IntPtr native__this, int resid)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTheme (resid);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTheme", "(I)V", "GetSetTheme_IHandler")]
		public override unsafe void SetTheme (int resid)
		{
			const string __id = "setTheme.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resid);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setWallpaper_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetWallpaper_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setWallpaper_Landroid_graphics_Bitmap_ == null)
				cb_setWallpaper_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWallpaper_Landroid_graphics_Bitmap_);
			return cb_setWallpaper_Landroid_graphics_Bitmap_;
		}

		[Obsolete]
		static void n_SetWallpaper_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.SetWallpaper (bitmap);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='setWallpaper' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Obsolete (@"deprecated")]
		[Register ("setWallpaper", "(Landroid/graphics/Bitmap;)V", "GetSetWallpaper_Landroid_graphics_Bitmap_Handler")]
		public override unsafe void SetWallpaper (global::Android.Graphics.Bitmap bitmap)
		{
			const string __id = "setWallpaper.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setWallpaper_Ljava_io_InputStream_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetWallpaper_Ljava_io_InputStream_Handler ()
		{
			if (cb_setWallpaper_Ljava_io_InputStream_ == null)
				cb_setWallpaper_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWallpaper_Ljava_io_InputStream_);
			return cb_setWallpaper_Ljava_io_InputStream_;
		}

		[Obsolete]
		static void n_SetWallpaper_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream data = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetWallpaper (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='setWallpaper' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Obsolete (@"deprecated")]
		[Register ("setWallpaper", "(Ljava/io/InputStream;)V", "GetSetWallpaper_Ljava_io_InputStream_Handler")]
		public override unsafe void SetWallpaper (global::System.IO.Stream data)
		{
			const string __id = "setWallpaper.(Ljava/io/InputStream;)V";
			IntPtr native_data = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_data);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_data);
			}
		}

		static Delegate cb_startActivities_arrayLandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivities_arrayLandroid_content_Intent_Handler ()
		{
			if (cb_startActivities_arrayLandroid_content_Intent_ == null)
				cb_startActivities_arrayLandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivities_arrayLandroid_content_Intent_);
			return cb_startActivities_arrayLandroid_content_Intent_;
		}

		static void n_StartActivities_arrayLandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intents)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent[] intents = (global::Android.Content.Intent[]) JNIEnv.GetArray (native_intents, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Content.Intent));
			__this.StartActivities (intents);
			if (intents != null)
				JNIEnv.CopyArray (intents, native_intents);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivities' and count(parameter)=1 and parameter[1][@type='android.content.Intent[]']]"
		[Register ("startActivities", "([Landroid/content/Intent;)V", "GetStartActivities_arrayLandroid_content_Intent_Handler")]
		public override unsafe void StartActivities (global::Android.Content.Intent[] intents)
		{
			const string __id = "startActivities.([Landroid/content/Intent;)V";
			IntPtr native_intents = JNIEnv.NewArray (intents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_intents);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (intents != null) {
					JNIEnv.CopyArray (native_intents, intents);
					JNIEnv.DeleteLocalRef (native_intents);
				}
			}
		}

		static Delegate cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_Handler ()
		{
			if (cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_ == null)
				cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_);
			return cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_;
		}

		static void n_StartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intents, IntPtr native_options)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent[] intents = (global::Android.Content.Intent[]) JNIEnv.GetArray (native_intents, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Content.Intent));
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.StartActivities (intents, options);
			if (intents != null)
				JNIEnv.CopyArray (intents, native_intents);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivities' and count(parameter)=2 and parameter[1][@type='android.content.Intent[]'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("startActivities", "([Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_Handler")]
		public override unsafe void StartActivities (global::Android.Content.Intent[] intents, global::Android.OS.Bundle options)
		{
			const string __id = "startActivities.([Landroid/content/Intent;Landroid/os/Bundle;)V";
			IntPtr native_intents = JNIEnv.NewArray (intents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_intents);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (intents != null) {
					JNIEnv.CopyArray (native_intents, intents);
					JNIEnv.DeleteLocalRef (native_intents);
				}
			}
		}

		static Delegate cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ == null)
				cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_);
			return cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
		}

		static void n_StartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intents, IntPtr native_options, IntPtr native_userHandle)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent[] intents = (global::Android.Content.Intent[]) JNIEnv.GetArray (native_intents, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Content.Intent));
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle userHandle = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_userHandle, JniHandleOwnership.DoNotTransfer);
			__this.StartActivitiesAsUser (intents, options, userHandle);
			if (intents != null)
				JNIEnv.CopyArray (intents, native_intents);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivitiesAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent[]'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("startActivitiesAsUser", "([Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V", "GetStartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler")]
		public override unsafe void StartActivitiesAsUser (global::Android.Content.Intent[] intents, global::Android.OS.Bundle options, global::Android.OS.UserHandle userHandle)
		{
			const string __id = "startActivitiesAsUser.([Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V";
			IntPtr native_intents = JNIEnv.NewArray (intents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_intents);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((userHandle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userHandle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (intents != null) {
					JNIEnv.CopyArray (native_intents, intents);
					JNIEnv.DeleteLocalRef (native_intents);
				}
			}
		}

		static Delegate cb_startActivity_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Landroid_content_Intent_Handler ()
		{
			if (cb_startActivity_Landroid_content_Intent_ == null)
				cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivity_Landroid_content_Intent_);
			return cb_startActivity_Landroid_content_Intent_;
		}

		static void n_StartActivity_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (intent);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivity' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public override unsafe void StartActivity (global::Android.Content.Intent intent)
		{
			const string __id = "startActivity.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler ()
		{
			if (cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ == null)
				cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_);
			return cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
		}

		static void n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_options)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (intent, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivity' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler")]
		public override unsafe void StartActivity (global::Android.Content.Intent intent, global::Android.OS.Bundle options)
		{
			const string __id = "startActivity.(Landroid/content/Intent;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ == null)
				cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_);
			return cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
		}

		static void n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_options, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityAsUser (intent, options, user);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivityAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("startActivityAsUser", "(Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V", "GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler")]
		public override unsafe void StartActivityAsUser (global::Android.Content.Intent intent, global::Android.OS.Bundle options, global::Android.OS.UserHandle user)
		{
			const string __id = "startActivityAsUser.(Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static void n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityAsUser (intent, user);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivityAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("startActivityAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void StartActivityAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user)
		{
			const string __id = "startActivityAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_Handler ()
		{
			if (cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
				cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_);
			return cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		static void n_StartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string who = JNIEnv.GetString (native_who, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (who, intent, requestCode, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startActivityForResult' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("startActivityForResult", "(Ljava/lang/String;Landroid/content/Intent;ILandroid/os/Bundle;)V", "GetStartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_Handler")]
		public override unsafe void StartActivityForResult (string who, global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options)
		{
			const string __id = "startActivityForResult.(Ljava/lang/String;Landroid/content/Intent;ILandroid/os/Bundle;)V";
			IntPtr native_who = JNIEnv.NewString (who);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_who);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [2] = new JniArgumentValue (requestCode);
				__args [3] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_who);
			}
		}

		static Delegate cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static bool n_StartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_className, IntPtr native_profileFile, IntPtr native_arguments)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName className = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_className, JniHandleOwnership.DoNotTransfer);
			string profileFile = JNIEnv.GetString (native_profileFile, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle arguments = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_arguments, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartInstrumentation (className, profileFile, arguments);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startInstrumentation' and count(parameter)=3 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", "GetStartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe bool StartInstrumentation (global::Android.Content.ComponentName className, string profileFile, global::Android.OS.Bundle arguments)
		{
			const string __id = "startInstrumentation.(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z";
			IntPtr native_profileFile = JNIEnv.NewString (profileFile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((className == null) ? IntPtr.Zero : ((global::Java.Lang.Object) className).Handle);
				__args [1] = new JniArgumentValue (native_profileFile);
				__args [2] = new JniArgumentValue ((arguments == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arguments).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_profileFile);
			}
		}

		static Delegate cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III;
#pragma warning disable 0169
		static Delegate GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIIHandler ()
		{
			if (cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III == null)
				cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>) n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III);
			return cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III;
		}

		static void n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_fillInIntent, int flagsMask, int flagsValues, int extraFlags)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentSender intent = global::Java.Lang.Object.GetObject<global::Android.Content.IntentSender> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent fillInIntent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_fillInIntent, JniHandleOwnership.DoNotTransfer);
			__this.StartIntentSender (intent, fillInIntent, flagsMask, flagsValues, extraFlags);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startIntentSender' and count(parameter)=5 and parameter[1][@type='android.content.IntentSender'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIIHandler")]
		public override unsafe void StartIntentSender (global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags)
		{
			const string __id = "startIntentSender.(Landroid/content/IntentSender;Landroid/content/Intent;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((fillInIntent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fillInIntent).Handle);
				__args [2] = new JniArgumentValue (flagsMask);
				__args [3] = new JniArgumentValue (flagsValues);
				__args [4] = new JniArgumentValue (extraFlags);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_ == null)
				cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_);
			return cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_;
		}

		static void n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_fillInIntent, int flagsMask, int flagsValues, int extraFlags, IntPtr native_options)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentSender intent = global::Java.Lang.Object.GetObject<global::Android.Content.IntentSender> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent fillInIntent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_fillInIntent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.StartIntentSender (intent, fillInIntent, flagsMask, flagsValues, extraFlags, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startIntentSender' and count(parameter)=6 and parameter[1][@type='android.content.IntentSender'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;IIILandroid/os/Bundle;)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_Handler")]
		public override unsafe void StartIntentSender (global::Android.Content.IntentSender intent, global::Android.Content.Intent fillInIntent, int flagsMask, int flagsValues, int extraFlags, global::Android.OS.Bundle options)
		{
			const string __id = "startIntentSender.(Landroid/content/IntentSender;Landroid/content/Intent;IIILandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((fillInIntent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fillInIntent).Handle);
				__args [2] = new JniArgumentValue (flagsMask);
				__args [3] = new JniArgumentValue (flagsValues);
				__args [4] = new JniArgumentValue (extraFlags);
				__args [5] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startService_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartService_Landroid_content_Intent_Handler ()
		{
			if (cb_startService_Landroid_content_Intent_ == null)
				cb_startService_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartService_Landroid_content_Intent_);
			return cb_startService_Landroid_content_Intent_;
		}

		static IntPtr n_StartService_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_service)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent service = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_service, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartService (service));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startService' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", "GetStartService_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.Content.ComponentName StartService (global::Android.Content.Intent service)
		{
			const string __id = "startService.(Landroid/content/Intent;)Landroid/content/ComponentName;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static IntPtr n_StartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent service = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_service, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartServiceAsUser (service, user));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='startServiceAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("startServiceAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)Landroid/content/ComponentName;", "GetStartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe global::Android.Content.ComponentName StartServiceAsUser (global::Android.Content.Intent service, global::Android.OS.UserHandle user)
		{
			const string __id = "startServiceAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)Landroid/content/ComponentName;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stopService_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStopService_Landroid_content_Intent_Handler ()
		{
			if (cb_stopService_Landroid_content_Intent_ == null)
				cb_stopService_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StopService_Landroid_content_Intent_);
			return cb_stopService_Landroid_content_Intent_;
		}

		static bool n_StopService_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent name = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_name, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StopService (name);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='stopService' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("stopService", "(Landroid/content/Intent;)Z", "GetStopService_Landroid_content_Intent_Handler")]
		public override unsafe bool StopService (global::Android.Content.Intent name)
		{
			const string __id = "stopService.(Landroid/content/Intent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static bool n_StopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_user)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent name = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_name, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StopServiceAsUser (name, user);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='stopServiceAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("stopServiceAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)Z", "GetStopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe bool StopServiceAsUser (global::Android.Content.Intent name, global::Android.OS.UserHandle user)
		{
			const string __id = "stopServiceAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_unbindService_Landroid_content_ServiceConnection_;
#pragma warning disable 0169
		static Delegate GetUnbindService_Landroid_content_ServiceConnection_Handler ()
		{
			if (cb_unbindService_Landroid_content_ServiceConnection_ == null)
				cb_unbindService_Landroid_content_ServiceConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindService_Landroid_content_ServiceConnection_);
			return cb_unbindService_Landroid_content_ServiceConnection_;
		}

		static void n_UnbindService_Landroid_content_ServiceConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_conn)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IServiceConnection conn = (global::Android.Content.IServiceConnection)global::Java.Lang.Object.GetObject<global::Android.Content.IServiceConnection> (native_conn, JniHandleOwnership.DoNotTransfer);
			__this.UnbindService (conn);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='unbindService' and count(parameter)=1 and parameter[1][@type='android.content.ServiceConnection']]"
		[Register ("unbindService", "(Landroid/content/ServiceConnection;)V", "GetUnbindService_Landroid_content_ServiceConnection_Handler")]
		public override unsafe void UnbindService (global::Android.Content.IServiceConnection conn)
		{
			const string __id = "unbindService.(Landroid/content/ServiceConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterReceiver_Landroid_content_BroadcastReceiver_;
#pragma warning disable 0169
		static Delegate GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler ()
		{
			if (cb_unregisterReceiver_Landroid_content_BroadcastReceiver_ == null)
				cb_unregisterReceiver_Landroid_content_BroadcastReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterReceiver_Landroid_content_BroadcastReceiver_);
			return cb_unregisterReceiver_Landroid_content_BroadcastReceiver_;
		}

		static void n_UnregisterReceiver_Landroid_content_BroadcastReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_receiver)
		{
			global::Android.Content.ContextWrapper __this = global::Java.Lang.Object.GetObject<global::Android.Content.ContextWrapper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver receiver = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_receiver, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterReceiver (receiver);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='ContextWrapper']/method[@name='unregisterReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public override unsafe void UnregisterReceiver (global::Android.Content.BroadcastReceiver receiver)
		{
			const string __id = "unregisterReceiver.(Landroid/content/BroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((receiver == null) ? IntPtr.Zero : ((global::Java.Lang.Object) receiver).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
