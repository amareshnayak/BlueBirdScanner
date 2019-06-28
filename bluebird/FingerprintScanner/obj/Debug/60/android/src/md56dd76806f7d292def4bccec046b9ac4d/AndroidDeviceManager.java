package md56dd76806f7d292def4bccec046b9ac4d;


public class AndroidDeviceManager
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.morpho.morphosmart.device.IMophoDeviceManager
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_closeDevice:()I:GetCloseDeviceHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib\n" +
			"n_comReceive:(I)[B:GetComReceive_IHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib\n" +
			"n_comSend:(I[B)I:GetComSend_IarrayBHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib\n" +
			"n_getUsbDeviceName:(I)Ljava/lang/String;:GetGetUsbDeviceName_IHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib\n" +
			"n_initUsbDevicesNameEnum:([I)I:GetInitUsbDevicesNameEnum_arrayIHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib\n" +
			"n_openUsbDevice:(Ljava/lang/String;I)I:GetOpenUsbDevice_Ljava_lang_String_IHandler:Com.Morpho.Morphosmart.Device.IMophoDeviceManagerInvoker, ServiceLib\n" +
			"";
		mono.android.Runtime.register ("FingerprintScanner.AndroidDeviceManager, FingerprintScanner", AndroidDeviceManager.class, __md_methods);
	}


	public AndroidDeviceManager ()
	{
		super ();
		if (getClass () == AndroidDeviceManager.class)
			mono.android.TypeManager.Activate ("FingerprintScanner.AndroidDeviceManager, FingerprintScanner", "", this, new java.lang.Object[] {  });
	}


	public int closeDevice ()
	{
		return n_closeDevice ();
	}

	private native int n_closeDevice ();


	public byte[] comReceive (int p0)
	{
		return n_comReceive (p0);
	}

	private native byte[] n_comReceive (int p0);


	public int comSend (int p0, byte[] p1)
	{
		return n_comSend (p0, p1);
	}

	private native int n_comSend (int p0, byte[] p1);


	public java.lang.String getUsbDeviceName (int p0)
	{
		return n_getUsbDeviceName (p0);
	}

	private native java.lang.String n_getUsbDeviceName (int p0);


	public int initUsbDevicesNameEnum (int[] p0)
	{
		return n_initUsbDevicesNameEnum (p0);
	}

	private native int n_initUsbDevicesNameEnum (int[] p0);


	public int openUsbDevice (java.lang.String p0, int p1)
	{
		return n_openUsbDevice (p0, p1);
	}

	private native int n_openUsbDevice (java.lang.String p0, int p1);

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
