using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Morpho.Morphosmart.Device;
using Com.Morpho.Morphosmart.Sdk;
using Java.Lang;

namespace FingerprintScanner
{
    class AndroidDeviceManager : Java.Lang.Object, IMophoDeviceManager
    {
        private MorphoDevice device;
        private byte nbrOfDevice;

        public AndroidDeviceManager()
        {
            device = new MorphoDevice();
        }

        public int CloseDevice()
        {
            return device.CloseDevice();
        }

        public byte[] ComReceive(int timeout)
        {
            return device.ComReceive(timeout);
        }

        public int ComSend(int timeout, byte[] data)
        {
            return device.ComSend(timeout, data);
        }

        public string GetUsbDeviceName(int index)
        {
            if (nbrOfDevice <= 0)
            {
                int[] n = new int[1];
                InitUsbDevicesNameEnum(n);
            }

            if (index < nbrOfDevice && index >= 0 && nbrOfDevice > 0)
            {
                return device.GetUsbDeviceName(index);
            }
            return null;
        }

        public int InitUsbDevicesNameEnum(int[] nbr)
        {
            int ec = 0;

            if (nbr == null)
                return 0;

            Integer o_pul_NbUsbDevice = new Integer(0);

            ec = device.InitUsbDevicesNameEnum(o_pul_NbUsbDevice);

            //System.out.println("initUsbDevicesNameEnum : " + o_pul_NbUsbDevice.intValue());

            nbrOfDevice = (byte) o_pul_NbUsbDevice.ByteValue();

            nbr[0] = nbrOfDevice;

            return ec;
        }

        public int OpenUsbDevice(string serialNumber, int max_recv_time)
        {
            return device.OpenUsbDevice(serialNumber, max_recv_time);
        }
    }
}