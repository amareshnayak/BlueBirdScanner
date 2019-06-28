using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Morpho.Android.Usb {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']"
	[global::Android.Runtime.Register ("com/morpho/android/usb/USBConstants", DoNotGenerateAcw=true)]
	public partial class USBConstants : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='DEFAULT_PACKET_SIZE']"
		[Register ("DEFAULT_PACKET_SIZE")]
		public const int DefaultPacketSize = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='DEFAULT_STRING_DESCRIPTOR_SIZE']"
		[Register ("DEFAULT_STRING_DESCRIPTOR_SIZE")]
		public const int DefaultStringDescriptorSize = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='FORCE_CLAIM']"
		[Register ("FORCE_CLAIM")]
		public const bool ForceClaim = (bool) true;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='INVALID_USB_INTERFACE']"
		[Register ("INVALID_USB_INTERFACE")]
		public const int InvalidUsbInterface = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='OFFSET_MANUFACTRURER_IDX']"
		[Register ("OFFSET_MANUFACTRURER_IDX")]
		public const int OffsetManufactrurerIdx = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='OFFSET_MAX_PACKET_SIZE']"
		[Register ("OFFSET_MAX_PACKET_SIZE")]
		public const int OffsetMaxPacketSize = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='OFFSET_PRODUCT_IDX']"
		[Register ("OFFSET_PRODUCT_IDX")]
		public const int OffsetProductIdx = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='OFFSET_SERIAL_IDX']"
		[Register ("OFFSET_SERIAL_IDX")]
		public const int OffsetSerialIdx = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_CANNOT_CLAIM_INTERFACE']"
		[Register ("RETURN_ERROR_CANNOT_CLAIM_INTERFACE")]
		public const int ReturnErrorCannotClaimInterface = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_CANNOT_GET_STRING_DESCRIPTOR']"
		[Register ("RETURN_ERROR_CANNOT_GET_STRING_DESCRIPTOR")]
		public const int ReturnErrorCannotGetStringDescriptor = (int) -4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_CANNOT_RELEASE_INTERFACE']"
		[Register ("RETURN_ERROR_CANNOT_RELEASE_INTERFACE")]
		public const int ReturnErrorCannotReleaseInterface = (int) -5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_DEVICE_NOT_CONNECTED']"
		[Register ("RETURN_ERROR_DEVICE_NOT_CONNECTED")]
		public const int ReturnErrorDeviceNotConnected = (int) -6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_FEATURE_REPORT_GET_FAILURE']"
		[Register ("RETURN_ERROR_FEATURE_REPORT_GET_FAILURE")]
		public const int ReturnErrorFeatureReportGetFailure = (int) -3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_FEATURE_REPORT_SEND_FAILURE']"
		[Register ("RETURN_ERROR_FEATURE_REPORT_SEND_FAILURE")]
		public const int ReturnErrorFeatureReportSendFailure = (int) -2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_UNABLE_TO_READ_DATA']"
		[Register ("RETURN_ERROR_UNABLE_TO_READ_DATA")]
		public const int ReturnErrorUnableToReadData = (int) -8;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_ERROR_UNABLE_TO_WRITE_DATA']"
		[Register ("RETURN_ERROR_UNABLE_TO_WRITE_DATA")]
		public const int ReturnErrorUnableToWriteData = (int) -7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='RETURN_SUCCESS']"
		[Register ("RETURN_SUCCESS")]
		public const int ReturnSuccess = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='SPUSB_TIMEOUT_INFINITE']"
		[Register ("SPUSB_TIMEOUT_INFINITE")]
		public const long SpusbTimeoutInfinite = (long) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='TIMEOUT']"
		[Register ("TIMEOUT")]
		public const int Timeout = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_DESCRIPTOR_DEVICE']"
		[Register ("USB_DESCRIPTOR_DEVICE")]
		public const int UsbDescriptorDevice = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_DESCRIPTOR_REPORT']"
		[Register ("USB_DESCRIPTOR_REPORT")]
		public const int UsbDescriptorReport = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_DESCRIPTOR_STRING']"
		[Register ("USB_DESCRIPTOR_STRING")]
		public const int UsbDescriptorString = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_DEVICE_DESCRIPTOR_LANGUAGE_ENGLISH']"
		[Register ("USB_DEVICE_DESCRIPTOR_LANGUAGE_ENGLISH")]
		public const int UsbDeviceDescriptorLanguageEnglish = (int) 1033;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_DEVICE_DESCRIPTOR_LENGTH']"
		[Register ("USB_DEVICE_DESCRIPTOR_LENGTH")]
		public const int UsbDeviceDescriptorLength = (int) 18;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_ADDRESS_MASK']"
		[Register ("USB_ENDPOINT_ADDRESS_MASK")]
		public const int UsbEndpointAddressMask = (int) 15;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_DIR_MASK']"
		[Register ("USB_ENDPOINT_DIR_MASK")]
		public const int UsbEndpointDirMask = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_IN']"
		[Register ("USB_ENDPOINT_IN")]
		public const int UsbEndpointIn = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_OUT']"
		[Register ("USB_ENDPOINT_OUT")]
		public const int UsbEndpointOut = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_TYPE_BULK']"
		[Register ("USB_ENDPOINT_TYPE_BULK")]
		public const int UsbEndpointTypeBulk = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_TYPE_CONTROL']"
		[Register ("USB_ENDPOINT_TYPE_CONTROL")]
		public const int UsbEndpointTypeControl = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_TYPE_INTERRUPT']"
		[Register ("USB_ENDPOINT_TYPE_INTERRUPT")]
		public const int UsbEndpointTypeInterrupt = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_TYPE_ISOCHRONOUS']"
		[Register ("USB_ENDPOINT_TYPE_ISOCHRONOUS")]
		public const int UsbEndpointTypeIsochronous = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_ENDPOINT_TYPE_MASK']"
		[Register ("USB_ENDPOINT_TYPE_MASK")]
		public const int UsbEndpointTypeMask = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_MAXINTERFACES']"
		[Register ("USB_MAXINTERFACES")]
		public const int UsbMaxinterfaces = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_RECIPIENT_INTERFACE']"
		[Register ("USB_RECIPIENT_INTERFACE")]
		public const int UsbRecipientInterface = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REPORT_TYPE_FEATURE']"
		[Register ("USB_REPORT_TYPE_FEATURE")]
		public const int UsbReportTypeFeature = (int) 768;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REPORT_TYPE_STRING']"
		[Register ("USB_REPORT_TYPE_STRING")]
		public const int UsbReportTypeString = (int) 768;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REQUEST_GET_DESCRIPTOR']"
		[Register ("USB_REQUEST_GET_DESCRIPTOR")]
		public const int UsbRequestGetDescriptor = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REQUEST_GET_FEATURE']"
		[Register ("USB_REQUEST_GET_FEATURE")]
		public const int UsbRequestGetFeature = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REQUEST_SET_FEATURE']"
		[Register ("USB_REQUEST_SET_FEATURE")]
		public const int UsbRequestSetFeature = (int) 9;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REQUEST_TYPE_CLASS']"
		[Register ("USB_REQUEST_TYPE_CLASS")]
		public const int UsbRequestTypeClass = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/field[@name='USB_REQUEST_TYPE_STANDARD']"
		[Register ("USB_REQUEST_TYPE_STANDARD")]
		public const int UsbRequestTypeStandard = (int) 0;
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/morpho/android/usb/USBConstants", typeof (USBConstants));
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

		protected USBConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.morpho.android.usb']/class[@name='USBConstants']/constructor[@name='USBConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe USBConstants ()
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

	}
}
