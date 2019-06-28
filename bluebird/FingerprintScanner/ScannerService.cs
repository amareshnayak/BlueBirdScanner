using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Morpho.Android.Usb;
using Com.Morpho.Morphosmart.Sdk;
using Java.IO;
using Java.Lang;
using Java.Text;
using Java.Util;

namespace FingerprintScanner
{
    class ScannerService : Java.Lang.Object, Java.Util.IObserver
    {
        private Activity mContext;
        private MorphoDevice morphoDevice;
        private string sensorName;

        private int sensorBus = -1;
        private int sensorAddress = -1;
        private int sensorFileDescriptor = -1;
        private int index;
        private int ret = -1;
        public static bool isRebootSoft = false;
        private bool isCaptureVerif = false;
        private DeviceDetectionMode detectionMode = DeviceDetectionMode.SdkDetection;

        public static string TAG = "FP Scanner";

        public ScannerService(Activity ctx)
        {
            mContext = ctx;
        }

        public void InitializeScanner()
        {
            morphoDevice = new MorphoDevice();
            //morphoDevice = ProcessInfo.getInstance().getDevice();

            //int ret = USBManager.Instance.Initialize(mContext, "com.bluebird.fingerprintscanner.USB_ACTION");
            //Toast.MakeText(mContext, "Scanner Initialize ret := " + ret, ToastLength.Long).Show();
        }

        public int HasUsbPermission()
        {
            if (USBManager.Instance.IsDevicesHasPermission == true)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public void GrantPermission()
        {
            USBManager.Instance.Initialize(mContext, "com.bluebird.fingerprintscanner.USB_ACTION");
        }

        public string EnumerateDevices()
        {
            Integer nbUsbDevice = new Integer(0);
            int ret = morphoDevice.InitUsbDevicesNameEnum(nbUsbDevice);

            if (ret == ErrorCodes.MorphoOk)
            {
                if ((int)nbUsbDevice > 0)
                {
                    sensorName = morphoDevice.GetUsbDeviceName(0);
                    return sensorName;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public void Connection()
        {
            int ret = morphoDevice.OpenUsbDevice(sensorName, 0);
            //Toast.makeText(mContext, "morphoDevice.ping() in connection := " + morphoDevice.ping(), Toast.LENGTH_LONG).show();

            if (ret == ErrorCodes.MorphoOk)
            {
                ProcessInfo.getInstance().setMSOSerialNumber(sensorName);
                ProcessInfo.getInstance().setMSOBus(sensorBus);
                ProcessInfo.getInstance().setMSOAddress(sensorAddress);
                ProcessInfo.getInstance().setMSOFD(sensorFileDescriptor);
                ProcessInfo.getInstance().setMsoDetectionMode(detectionMode);
                
                string productDescriptor = morphoDevice.ProductDescriptor;
                Java.Util.StringTokenizer tokenizer = new Java.Util.StringTokenizer(productDescriptor, "\n");
                if (tokenizer.HasMoreTokens)
                {
                    string l_s_current = tokenizer.NextToken();
                    if (l_s_current.Contains("FINGER VP") || l_s_current.Contains("FVP"))
                    {
                        MorphoInfo.m_b_fvp = true;
                    }
                }

                //morphoDevice.closeDevice();
                InitDeviceSettings();

                /*MorphoDatabase morphoDatabase = new MorphoDatabase();
                ret = morphoDevice.GetDatabase(0, morphoDatabase);

                if (ret == ErrorCodes.MorphoOk)
                {
                    //morphoDevice.closeDevice();
                    InitDeviceSettings();
                }
                else
                {
                    Toast.MakeText(mContext, "An error occurred", ToastLength.Long).Show();
                }*/
            }
        }

        public void InitDeviceSettings()
        {
            /*USBManager.Instance.Initialize(mContext, "com.bluebird.fingerprintscanner.USB_ACTION");
            string sensorName = EnumerateDevices();
            Toast.MakeText(mContext, "InitDeviceSettings sensorName := " + sensorName, ToastLength.Long).Show();
            int ret = morphoDevice.OpenUsbDevice(sensorName, 0);
            Toast.MakeText(mContext, "InitDeviceSettings OpenUsbDevice() ret := " + ret, ToastLength.Long).Show();*/

            //MorphoDatabase morphoDatabase = new MorphoDatabase();

            /*if (ProcessInfo.getInstance().getMorphoDevice() == null)
            {
                string sensorName = ProcessInfo.getInstance().getMSOSerialNumber();
                morphoDevice.OpenUsbDevice(sensorName, 0);

                if (ret == ErrorCodes.MorphoOk)
                {
                    ret = morphoDevice.GetDatabase(0, morphoDatabase);
                    Log.Info("MORPHO_USB", "morphoDevice.getDatabase = " + ret);
                }
            }*/

            ProcessInfo.getInstance().setMorphoDevice(morphoDevice);
            //ProcessInfo.getInstance().setMorphoDatabase(morphoDatabase);

            ProcessInfo.getInstance().setNoCheck(false);
            ProcessInfo.getInstance().setDatabaseItems(null);
            ProcessInfo.getInstance().setCurrentNumberOfRecordValue(0);
            ProcessInfo.getInstance().setNumberOfFingerPerRecord(0);
            ProcessInfo.getInstance().setCurrentNumberOfUsedRecordValue(0);
            ProcessInfo.getInstance().setMaximumNumberOfRecordValue(0);
            ProcessInfo.getInstance().setEncryptDatabaseValue("NO");

            // initBioSettingsInformations
            ProcessInfo.getInstance().setMatchingThreshold(5);
            ProcessInfo.getInstance().setTimeout(30);
            ProcessInfo.getInstance().setCoder(Coder.MorphoMsoV9Coder);
            ProcessInfo.getInstance().setSecurityLevel(SecurityLevel.FfdSecurityLevelLowHost);
            ProcessInfo.getInstance().setMatchingStrategy(MatchingStrategy.MorphoStandardMatchingStrategy);
            ProcessInfo.getInstance().setStrategyAcquisitionMode(StrategyAcquisitionMode.MorphoAcqExpertMode);
            ProcessInfo.getInstance().setForceFingerPlacementOnTop(true);
            ProcessInfo.getInstance().setAdvancedSecLevCompReq(false);
            ProcessInfo.getInstance().setFingerprintQualityThresholdvalue(0);

            // initOptionsInformations
            ProcessInfo.getInstance().setImageViewer(true);
            ProcessInfo.getInstance().setAsyncPositioningCommand(true);
            ProcessInfo.getInstance().setAsyncEnrollmentCommand(true);
            ProcessInfo.getInstance().setAsyncDetectQuality(true);
            ProcessInfo.getInstance().setAsyncCodeQuality(true);
            ProcessInfo.getInstance().setExportMatchingPkNumber(false);
            ProcessInfo.getInstance().setWakeUpWithLedOff(false);
            ProcessInfo.getInstance().setSensorWindowPosition(SensorWindowPosition.Normal_0);

            if (morphoDevice != null)
            {
                if (!isRebootSoft)
                {
                    Toast.MakeText(mContext, "morphoDevice.ping() := " + morphoDevice.Ping(), ToastLength.Long).Show();
                    if (morphoDevice.Ping() != ErrorCodes.MorphoOk)
                    {
                        //Toast.makeText(mContext, "Sensor Configuration - An error occurred", Toast.LENGTH_LONG).show();
                    }
                    else
                    {
                        //Toast.makeText(mContext, "Sensor Configuration - NO ERROR", Toast.LENGTH_LONG).show();
                    }
                }
            }

            //int ret = morphoDevice.resumeConnection(30,this);
            if (morphoDevice.ResumeConnection(30, this) == ErrorCodes.MorphoOk)
            {
                StartScan();
            }
        }

        public void StopScan()
        {
            //unlockScreenOrientation();

            ProcessInfo.getInstance().setStarted(false);
            if (ProcessInfo.getInstance().isCommandBioStart())
            {
                ProcessInfo.getInstance().getMorphoDevice().CancelLiveAcquisition();
            }
        }

        public void StartScan()
        {
            if (ProcessInfo.getInstance().IsStarted())
            {
                Stop();
            }
            else
            {
                try
                {
                    /*EnrollInfo.getInstance().setIDNumber("123456");
                    EnrollInfo.getInstance().setFirstName("test");
                    EnrollInfo.getInstance().setLastName("test");
                    ProcessInfo.getInstance().setMorphoInfo(EnrollInfo.getInstance());*/

                    CaptureInfo.getInstance().setIDNumber("abcdqwerty");
                    CaptureInfo.getInstance().setFirstName("test");
                    CaptureInfo.getInstance().setLastName("test");
                    ProcessInfo.getInstance().setMorphoInfo(CaptureInfo.getInstance());
                    //ProcessInfo.getInstance().setMorphoSample(this);
                    ProcessInfo.getInstance().setCommandBioStart(true);
                    ProcessInfo.getInstance().setStarted(true);
                    //lockScreenOrientation();
                    //enrollUser(this);
                    MorphoDeviceCapture(this);
                }
                catch (Java.Lang.Exception e)
                {
                }
            }
        }

        public void MorphoDeviceCapture(IObserver observer)
        {
            new System.Threading.Thread(new ThreadStart(delegate {
                index = 0;
                isCaptureVerif = false;
                TemplateList templateList = new TemplateList();
                MorphoInfo morphoInfo = ProcessInfo.getInstance().getMorphoInfo();
                ProcessInfo processInfo = ProcessInfo.getInstance();
                int timeout;
                int acquisitionThreshold = 0;
                int advancedSecurityLevelsRequired;
                TemplateType templateType;
                TemplateFVPType templateFVPType;
                int maxSizeTemplate = 255;
                EnrollmentType enrollType;
                LatentDetection latentDetection;
                Coder coderChoice;
                int detectModeChoice;

                bool exportFVP = false, exportFP = false;
                timeout = processInfo.getTimeout();
                timeout = 30;

                if (processInfo.isFingerprintQualityThreshold())
                {
                    acquisitionThreshold = processInfo.getFingerprintQualityThresholdvalue();
                }

                templateType = ((CaptureInfo)morphoInfo).getTemplateType();
                templateFVPType = ((CaptureInfo)morphoInfo).getTemplateFVPType();

                if (templateType != TemplateType.MorphoNoPkFp)
                {
                    exportFP = true;
                    if (templateType == TemplateType.MorphoPkMat || templateType == TemplateType.MorphoPkMatNorm || templateType == TemplateType.MorphoPkPklite)
                    {
                        maxSizeTemplate = 1;
                    }
                    else
                    {
                        maxSizeTemplate = 255;
                    }
                }
                else
                {
                    if (MorphoInfo.m_b_fvp == false)
                    {
                        templateType = TemplateType.MorphoPkComp;
                    }
                    maxSizeTemplate = 255;
                }

                if (templateFVPType != TemplateFVPType.MorphoNoPkFvp)
                {
                    exportFVP = true;
                }

                if (MorphoInfo.m_b_fvp)
                {
                    if (((CaptureInfo)morphoInfo).getCaptureType() != CaptureType.Verif)
                    {
                        templateFVPType = TemplateFVPType.MorphoPkFvp;
                    }
                    else
                    {
                        templateFVPType = TemplateFVPType.MorphoPkFvpMatch;
                    }
                }
                else
                {
                    templateFVPType = TemplateFVPType.MorphoNoPkFvp;
                }

                if (((CaptureInfo)morphoInfo).getCaptureType() == CaptureType.Enroll)
                {
                    //enrollType = EnrollmentType.THREE_ACQUISITIONS;
                    enrollType = EnrollmentType.OneAcquisitions;
                }
                else
                {
                    isCaptureVerif = true;
                    //currentCaptureBitmapId = R.id.imageView2;
                    enrollType = EnrollmentType.OneAcquisitions;
                }

                if (((CaptureInfo)morphoInfo).isLatentDetect())
                {
                    latentDetection = LatentDetection.LatentDetectEnable;
                }
                else
                {
                    latentDetection = LatentDetection.LatentDetectDisable;
                }

                coderChoice = processInfo.getCoder();

                detectModeChoice = DetectionMode.MorphoEnrollDetectMode.Value;

                if (processInfo.isForceFingerPlacementOnTop())
                {
                    detectModeChoice |= DetectionMode.MorphoForceFingerOnTopDetectMode.Value;
                }

                if (processInfo.isWakeUpWithLedOff())
                {
                    detectModeChoice |= MorphoWakeUpMode.MorphoWakeupLedOff.Code;
                }

                //advancedSecurityLevelsRequired = 0;
                if (((CaptureInfo)morphoInfo).getCaptureType() != CaptureType.Verif)
                {

                    if (processInfo.isAdvancedSecLevCompReq())
                    {
                        advancedSecurityLevelsRequired = 1;
                    }
                    else
                    {
                        advancedSecurityLevelsRequired = 0;
                    }
                }
                else
                {
                    advancedSecurityLevelsRequired = 0xFF;
                    if (processInfo.isAdvancedSecLevCompReq())
                    {
                        advancedSecurityLevelsRequired = 1;
                    }
                }

                int callbackCmd = ProcessInfo.getInstance().getCallbackCmd();

                int nbFinger = ((CaptureInfo)morphoInfo).getFingerNumber();
                string idUser = ((CaptureInfo)morphoInfo).getIDNumber();

                int ret = morphoDevice.SetStrategyAcquisitionMode(ProcessInfo.getInstance().getStrategyAcquisitionMode());
                /*mContext.runOnUiThread(new Runnable() {
                    @Override
                    public void run() {
                        Toast.makeText(mContext, "setStrategyAcquisitionMode() := " + morphoDevice.setStrategyAcquisitionMode(ProcessInfo.getInstance().getStrategyAcquisitionMode()), Toast.LENGTH_LONG).show();
                    }
                });*/

                if (ret == 0)
                {
                    
                    ret = morphoDevice.Capture(timeout, acquisitionThreshold, advancedSecurityLevelsRequired,
                            nbFinger, templateType, templateFVPType, maxSizeTemplate, enrollType,
                            latentDetection, coderChoice, detectModeChoice, /*CompressionAlgorithm.MorphoNoCompress, 0,*/ templateList, callbackCmd, observer);

                    Print(ret, timeout, acquisitionThreshold, advancedSecurityLevelsRequired,
                            nbFinger, templateType, templateFVPType, maxSizeTemplate, enrollType,
                            latentDetection, coderChoice, detectModeChoice, CompressionAlgorithm.MorphoNoCompress, 0, templateList, callbackCmd, observer);
                }

                ProcessInfo.getInstance().setCommandBioStart(false);

                GetAndWriteFFDLogs();

                string message = "";
                try
                {
                    if (ret == ErrorCodes.MorphoOk)
                    {
                
                        int NbTemplateFVP = templateList.NbFVPTemplate;
                        int NbTemplate = templateList.NbTemplate;
                        if (MorphoInfo.m_b_fvp)
                        {
                            if (NbTemplateFVP > 0)
                            {
                                TemplateFVP t = templateList.GetFVPTemplate(0);
                                message += "Advanced Security Levels Compatibility: " + (t.AdvancedSecurityLevelsCompatibility == true ? "Yes" : "NO") + "\n";
                                for (int i = 0; i < NbTemplateFVP; i++)
                                {
                                    t = templateList.GetFVPTemplate(i);
                                    message += "Finger #" + (i + 1) + " - Quality Score: " + t.TemplateQuality + "\n";
                                }
                            }
                        }
                        else
                        {
                            if (NbTemplate > 0)
                            {
                                for (int i = 0; i < NbTemplateFVP; i++)
                                {
                                    Template t = templateList.GetTemplate(i);
                                    message += "Finger #" + (i + 1) + " - Quality Score: " + t.TemplateQuality + "\n";
                                }
                            }
                        }

                        if (exportFVP)
                        {
                            for (int i = 0; i < NbTemplateFVP; i++)
                            {
                                TemplateFVP t = templateList.GetFVPTemplate(i);
                                FileOutputStream fos = new FileOutputStream("sdcard/TemplateFVP_" + idUser + "_f" + (i + 1) + templateFVPType.Extension);
                                byte[] data = t.GetData();
                                fos.Write(data);
                                fos.Close();
                                message += "Finger #" + (i + 1) + " - FVP Template successfully exported in file [sdcard/TemplateFVP_" + idUser + "_f" + (i + 1) + templateFVPType.Extension
                                        + "]\n";
                            }
                        }

                        if (exportFP)
                        {

                            for (int i = 0; i < NbTemplate; i++)
                            {
                                Template t = templateList.GetTemplate(i);
                                FileOutputStream fos = new FileOutputStream("sdcard/TemplateFP_" + idUser + "_f" + (i + 1) + templateType.Extension);
                                byte[] data = t.GetData();
                                fos.Write(data);
                                fos.Close();
                                message += "Finger #" + (i + 1) + " - FP Template successfully exported in file [sdcard/TemplateFP_" + idUser + "_f" + (i + 1) + templateType.Extension + "]\n";
                            }
                        }
                    }

                }
                catch (FileNotFoundException e)
                {
                    Log.Info("CAPTURE", e.Message);
                }
                catch (IOException e)
                {
                    Log.Info("CAPTURE", e.Message);
                }
                catch (Java.Lang.Exception e)
                {
                    Log.Info("CAPTURE", e.Message);
                }

                string alertMessage = message;
                int internalError = morphoDevice.InternalError;
                int retvalue = ret;
                /*mHandler.post(new Runnable()
                {
                    @Override
                    public synchronized void run()
                    {
                        alert(retvalue, internalError, "Capture", alertMessage);
                    }
                });*/
                Stop();
            })).Start();
            
    }

        /*private void UnlockScreenOrientation()
        {
            mContext.RequestedOrientation = ActivityInfo.SCREEN_ORIENTATION_SENSOR;
        }

        private void LockScreenOrientation()
        {
            final int orientation = mContext.getResources().getConfiguration().orientation;
            final int rotation = mContext.getWindowManager().getDefaultDisplay().getOrientation();

            if (rotation == Surface.ROTATION_0 || rotation == Surface.ROTATION_90)
            {
                if (orientation == Configuration.ORIENTATION_PORTRAIT)
                {
                    mContext.setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_PORTRAIT);
                }
                else if (orientation == Configuration.ORIENTATION_LANDSCAPE)
                {
                    mContext.setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_LANDSCAPE);
                }
            }
            else if (rotation == Surface.ROTATION_180 || rotation == Surface.ROTATION_270)
            {
                if (orientation == Configuration.ORIENTATION_PORTRAIT)
                {
                    mContext.setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_REVERSE_PORTRAIT);
                }
                else if (orientation == Configuration.ORIENTATION_LANDSCAPE)
                {
                    mContext.setRequestedOrientation(ActivityInfo.SCREEN_ORIENTATION_REVERSE_LANDSCAPE);
                }
            }
        }*/

        private void Stop()
        {
            //unlockScreenOrientation();
            ProcessInfo.getInstance().setStarted(false);
            if (ProcessInfo.getInstance().isCommandBioStart())
            {
                ProcessInfo.getInstance().getMorphoDevice().CancelLiveAcquisition();
            }
        }

        public void Update(Observable observable, Java.Lang.Object data)
        {
            //throw new NotImplementedException();
        }

        public void GetAndWriteFFDLogs()
        {
            string ffdLogs = morphoDevice.FFDLogs;

            if (ffdLogs != null)
            {
                string serialNbr = ProcessInfo.getInstance().getMSOSerialNumber();
                SimpleDateFormat sdf = new SimpleDateFormat("yyyyMMdd");
                string currentDateandTime = sdf.Format(new Date());
                string saveFile = "sdcard/" + serialNbr + "_" + currentDateandTime + "_Audit.log";

                try
                {
                    Log.Error(TAG, ffdLogs);
                    /*FileWriter fstream = new FileWriter(saveFile, true);
                    BufferedWriter out = new BufferedWriter(fstream);
				    out.Write(ffdLogs);
				    out.Close();*/
                }
                catch (IOException e)
                {
                    Log.Error(TAG, e.Message);
                }
            }
        }

        public void Print(int ret, int timeout, int acquisitionThreshold, int advancedSecurityLevelsRequired, int fingerNumber,
                      TemplateType templateType, TemplateFVPType templateFVPType, int maxSizeTemplate,
                      EnrollmentType enrollType, LatentDetection latentDetection, Coder coderChoice,
                      int detectModeChoice, CompressionAlgorithm compressAlgo, int compressRate,
                      TemplateList templateList, int callbackCmd, IObserver callback)
        {
            mContext.RunOnUiThread(() => {
                Toast.MakeText(mContext, "In print() - ret := " + ret + ", timeout := " + timeout +
                        ", acquisitionThreshold := " + acquisitionThreshold + ", advancedSecurityLevelsRequired := " + advancedSecurityLevelsRequired +
                                ", advancedSecurityLevelsRequired := " + advancedSecurityLevelsRequired + ", fingerNumber := " + fingerNumber +
                                ", templateType := " + templateType.Code + ", templateFVPType := " + templateFVPType.Code +
                                ", maxSizeTemplate := " + maxSizeTemplate + ", enrollType := " + enrollType.Value +
                                ", latentDetection := " + latentDetection.Value + ", coderChoice := " + coderChoice.Code +
                                ", detectModeChoice := " + detectModeChoice + ", compressAlgo := " + compressAlgo.Code +
                                ", compressRate := " + compressRate + ", templateList := " + templateList + ", callbackCmd := " + callbackCmd,
                        ToastLength.Long).Show();
            });
   
        }
    }
}
