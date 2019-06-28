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
using Com.Morpho.Morphosmart.Device;
using Com.Morpho.Morphosmart.Logger;
using Com.Morpho.Morphosmart.Pipe;
using Java.Lang;

namespace FingerprintScanner
{
    class PipeService : Java.Lang.Object, ISubscriber
    {

        private Activity mContext;
        private PipeServer pipeServer;
        private IMophoDeviceManager morphoDevice;
        private Logger logger;
        private UsbReceiver usbReceiver;

        private static string TAG = "FP Scanner";

        public PipeService(Activity context)
        {
            mContext = context;
            morphoDevice = new AndroidDeviceManager();
        }

        public void InitializeService()
        {
            
            IntentFilter filter = new IntentFilter(USBManager.ActionUsbPermission);
            filter.AddAction(UsbManager.ActionUsbDeviceAttached);
            filter.AddAction(UsbManager.ActionUsbDeviceDetached);

            usbReceiver = new UsbReceiver();
            mContext.RegisterReceiver(usbReceiver, filter);

            pipeServer = new PipeServer(morphoDevice);
            logger = Logger.Instance;
            Logger.Subscribe(this);
            pipeServer.Setlogger(logger);

            USBManager.Instance.Initialize(mContext, "com.bluebird.fingerprintscanner.USB_ACTION", true);

            if (USBManager.Instance.IsDevicesHasPermission == true)
            {
                Toast.MakeText(mContext, "USB Permissions are granted", ToastLength.Long);
            }
        }

        public void StartPipeServer()
        {
            if (!pipeServer.IsRunningServer)
            {
                pipeServer.Start();
            }
        }

        public void StopPipeServer()
        {
            if (pipeServer.IsRunningServer)
                pipeServer.Stop();
        }

        

        public void Notification(LogLevel p0, Java.Lang.Object p1)
        {
            string str = "[" + p0.Name() + "] : " + p1.ToString() + "\n";
            Log.Info(TAG, str);
        }
    }
}