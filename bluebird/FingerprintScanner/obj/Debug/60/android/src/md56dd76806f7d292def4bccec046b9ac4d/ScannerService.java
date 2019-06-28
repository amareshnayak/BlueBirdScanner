package md56dd76806f7d292def4bccec046b9ac4d;


public class ScannerService
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		java.util.Observer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_update:(Ljava/util/Observable;Ljava/lang/Object;)V:GetUpdate_Ljava_util_Observable_Ljava_lang_Object_Handler:Java.Util.IObserverInvoker, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null\n" +
			"";
		mono.android.Runtime.register ("FingerprintScanner.ScannerService, FingerprintScanner", ScannerService.class, __md_methods);
	}


	public ScannerService ()
	{
		super ();
		if (getClass () == ScannerService.class)
			mono.android.TypeManager.Activate ("FingerprintScanner.ScannerService, FingerprintScanner", "", this, new java.lang.Object[] {  });
	}

	public ScannerService (android.app.Activity p0)
	{
		super ();
		if (getClass () == ScannerService.class)
			mono.android.TypeManager.Activate ("FingerprintScanner.ScannerService, FingerprintScanner", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void update (java.util.Observable p0, java.lang.Object p1)
	{
		n_update (p0, p1);
	}

	private native void n_update (java.util.Observable p0, java.lang.Object p1);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
