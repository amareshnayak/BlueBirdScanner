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
    class SecurityOption
    {
        public Boolean activated = false;
        public String title = "";

        public SecurityOption(Boolean activated, String title)
        {
            this.activated = activated;
            this.title = title;
        }

        public String toString(String no, String yes)
        {
            String act = no;
            if (activated)
                act = yes;
            return act + "\t" + title;
        }
    }
}