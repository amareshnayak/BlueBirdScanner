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

namespace FingerprintScanner
{
    abstract class MorphoInfo
    {
        public static Boolean m_b_fvp = false;
        public static Boolean mLatentDetect = false;

        public abstract String toString();
    }
}