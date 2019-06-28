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
using Com.Morpho.Morphosmart.Sdk;

namespace FingerprintScanner
{
    class CaptureInfo : MorphoInfo
    {
        private static CaptureInfo mInstance = null;

        public static CaptureInfo getInstance()
        {
            if (mInstance == null)
            {
                mInstance = new CaptureInfo();
                mInstance.reset();
            }
            return mInstance;
        }

        private CaptureInfo()
        {
        }

        public override String toString()
        {
            return "IDNumber:\t" + IDNumber + "\r\n" + "FirstName:\t" + FirstName + "\r\n" + "LastName:\t" + LastName + "\r\n" + "fingerNumber:\t" + fingerNumber + "\r\n" + "enrollType:\t" + captureType
                    + "\r\n" + "latentDetect:\t" + latentDetect + "\r\n" + "TemplateType:\t" + templateType;
        }

        public void reset()
        {
            IDNumber = "";
            FirstName = "";
            LastName = "";
            fingerNumber = 1;
            captureType = CaptureType.Enroll;
            latentDetect = false;
            templateType = TemplateType.MorphoNoPkFp;
            templateFVPType = TemplateFVPType.MorphoNoPkFvp;
        }

        private String IDNumber = "";
        private String FirstName = "";
        private String LastName = "";
        private int fingerNumber = 0;
        private CaptureType captureType = CaptureType.Enroll;
        private Boolean latentDetect = false;
        private TemplateType templateType = TemplateType.MorphoNoPkFp;
        private TemplateFVPType templateFVPType = TemplateFVPType.MorphoNoPkFvp;

        public String getIDNumber()
        {
            return IDNumber;
        }

        public void setIDNumber(String iDNumber)
        {
            IDNumber = iDNumber;
        }

        public String getFirstName()
        {
            return FirstName;
        }

        public void setFirstName(String firstName)
        {
            FirstName = firstName;
        }

        public String getLastName()
        {
            return LastName;
        }

        public void setLastName(String lastName)
        {
            LastName = lastName;
        }

        public int getFingerNumber()
        {
            return fingerNumber;
        }

        public void setFingerNumber(int fingerNumber)
        {
            this.fingerNumber = fingerNumber;
        }

        public CaptureType getCaptureType()
        {
            return captureType;
        }

        public void setCaptureType(CaptureType captureType)
        {
            this.captureType = captureType;
        }

        public Boolean isLatentDetect()
        {
            return latentDetect;
        }

        public void setLatentDetect(Boolean latentDetect)
        {
            this.latentDetect = latentDetect;
        }

        /**
         * @return the templateType
         */
        public TemplateType getTemplateType()
        {
            return templateType;
        }

        public TemplateFVPType getTemplateFVPType()
        {
            return templateFVPType;
        }

        /**
         * @param templateType the templateType to set
         */
        public void setTemplateType(TemplateType templateType)
        {
            this.templateType = templateType;
        }

        public void setTemplateFVPType(TemplateFVPType templateFVPType)
        {
            this.templateFVPType = templateFVPType;
        }
    }
}