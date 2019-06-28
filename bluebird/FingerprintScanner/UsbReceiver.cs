using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Hardware.Usb;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Morpho.Android.Usb;

namespace FingerprintScanner
{
    [BroadcastReceiver(Enabled = true, Exported = true)]
    class UsbReceiver : BroadcastReceiver
    {

        private static string TAG = "FP Scanner";

        public override void OnReceive(Context context, Intent intent)
        {
            String action = intent.Action;
            Log.Info(TAG, "onReceive action : " + action);

            if (USBManager.ActionUsbPermission.Equals(action))
            {
                UsbDevice device = (UsbDevice)intent.GetParcelableExtra(UsbManager.ExtraDevice);
                if (intent.GetBooleanExtra(UsbManager.ExtraPermissionGranted, false))
                {
                    if (device != null)
                    {
                        Log.Info(TAG, "Detected Device : " + device.DeviceName);
                    }
                }
                else
                {
                    Log.Info(TAG, "Permission denied for device : " + device.DeviceName);
                }
            }
            else if (UsbManager.ActionUsbDeviceAttached.Equals(action))
            {
                UsbDevice device = (UsbDevice)intent.GetParcelableExtra(UsbManager.ExtraDevice);
                grantDevicePermission(device);
            }
            else if (UsbManager.ActionUsbDeviceDetached.Equals(action))
            {
                UsbDevice device = (UsbDevice)intent.GetParcelableExtra(UsbManager.ExtraDevice);
                USBDeviceAttributes l_attr = new USBDeviceAttributes(device.VendorId, device.ProductId);
                if (USBManager.Instance.IsSupported(l_attr))
                {
                    Log.Info(TAG, "MORPHO DEVICE DETACHED, Device Model : " +
                            USBManager.Instance.GetDeviceModel(l_attr));
                }
            }
        }

        public int grantDevicePermission(UsbDevice device)
        {
            Context context = USBManager.Context;
            if (context != null)
            {
                UsbManager usbManager = (UsbManager)context.GetSystemService(Context.UsbService);
                USBDeviceAttributes l_attr = new USBDeviceAttributes(device.VendorId, device.ProductId);
                if (USBManager.Instance.IsSupported(l_attr))
                {
                    Boolean hasPermission = usbManager.HasPermission(device);
                    if (!hasPermission)
                    {
                        // Request permission for using the device
                        Log.Info(TAG, "Request permission for using the device");
                        usbManager.RequestPermission(device, PendingIntent.GetBroadcast(context, 0, new Intent(USBManager.ActionUsbPermission), 0));
                    }
                }
            }

            return 0;
        }
    }
}