package md56dd76806f7d292def4bccec046b9ac4d;


public class PipeService
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.morpho.morphosmart.logger.ISubscriber
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_notification:(Lcom/morpho/morphosmart/logger/LogLevel;Ljava/lang/Object;)V:GetNotification_Lcom_morpho_morphosmart_logger_LogLevel_Ljava_lang_Object_Handler:Com.Morpho.Morphosmart.Logger.ISubscriberInvoker, ServiceLib\n" +
			"";
		mono.android.Runtime.register ("FingerprintScanner.PipeService, FingerprintScanner", PipeService.class, __md_methods);
	}


	public PipeService ()
	{
		super ();
		if (getClass () == PipeService.class)
			mono.android.TypeManager.Activate ("FingerprintScanner.PipeService, FingerprintScanner", "", this, new java.lang.Object[] {  });
	}

	public PipeService (android.app.Activity p0)
	{
		super ();
		if (getClass () == PipeService.class)
			mono.android.TypeManager.Activate ("FingerprintScanner.PipeService, FingerprintScanner", "Android.App.Activity, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public void notification (com.morpho.morphosmart.logger.LogLevel p0, java.lang.Object p1)
	{
		n_notification (p0, p1);
	}

	private native void n_notification (com.morpho.morphosmart.logger.LogLevel p0, java.lang.Object p1);

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
