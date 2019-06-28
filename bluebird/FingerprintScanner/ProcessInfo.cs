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
    class ProcessInfo
    {
        private static ProcessInfo mInstance = null;

        public static ProcessInfo getInstance()
        {
            if (mInstance == null)
            {
                mInstance = new ProcessInfo();
                mInstance.reset();
            }
            return mInstance;
        }

        private ProcessInfo()
        {
        }

        public void reset()
        {

            // MorphoDevice
            morphoDevice = null;

            //MorphoDataBase
            morphoDatabase = null;

            setStarted(false);

            // Current Tab First Part Info
            morphoInfo = null;

            // Second Part Bottom info
            baseStatusOk = true;
            noCheck = false;

            // Database record list
            //databaseItems = null;
            databaseSelectedIndex = -1;

            // MSO Configuration
            MSOSerialNumber = "";
            MSOBus = -1;
            MSOAddress = -1;
            MSOFD = -1;
            SecurityOptions = new System.Collections.Generic.List<SecurityOption>();

            // Database information
            maximumNumberofDatabaseValue = 1;
            maximumNumberOfRecordValue = 500;
            numberOfFingerPerRecord = 2;
            currentNumberofRecordValue = 0;
            currentNumberOfFreeRecordValue = 0;
            currentNumberOfUsedRecordValue = 0;
            pkFormat = "SAGEM PkComp";
            fieldsNumber = 0;

            // General Biometric Info
            matchingThreshold = 5;
            Timeout = 0;
            setCoder(Coder.MorphoDefaultCoder);
            securityLevel = SecurityLevel.FfdSecurityLevelLowHost;
            matchingStrategy = MatchingStrategy.MorphoStandardMatchingStrategy;
            forceFingerPlacementOnTop = true;
            advancedSecLevCompReq = false;
            fingerprintQualityThreshold = false;
            fingerprintQualityThresholdvalue = 0;

            // Options
            imageViewer = true;
            asyncPositioningCommand = true;
            asyncEnrollmentCommand = true;
            asyncDetectQuality = true;
            asyncCodeQuality = true;
            exportMatchingPkNumber = false;
            wakeUpWithLedOff = false;
            sensorWindowPosition = SensorWindowPosition.Normal_0;
            encryptDatabaseValue = "N/A";

            logLevel = MorphoLogLevel.MorphoLogNolog;
            logMode = MorphoLogMode.MorphoLogDisable;
        }

        // MorphoDevice
        private MorphoDevice morphoDevice = null;
        private MorphoDevice device = null;

        private MorphoDatabase morphoDatabase = null;

        private Boolean isStarted = false;

        // Current Tab First Part Info
        private MorphoInfo morphoInfo = null;

        // Second Part Bottom info
        private Boolean baseStatusOk = true;
        private Boolean noCheck = false;

        // Database record list
        private int databaseSelectedIndex = -1;
        private Java.Util.ArrayList databaseItems = null;

        // Database information
        private String encryptDatabaseValue = "N/A";
        private int maximumNumberofDatabaseValue = 0;
        private long maximumNumberOfRecordValue = 0;
        private int numberOfFingerPerRecord = 0;
        private int currentNumberofRecordValue = 0;
        private long currentNumberOfFreeRecordValue = 0;
        private long currentNumberOfUsedRecordValue = 0;
        private String pkFormat = "SAGEM PkComp";
        private long fieldsNumber = 0;

        // General Biometric Info
        private int matchingThreshold = 5;
        private int Timeout = 0;
        private Coder coder = Coder.MorphoDefaultCoder;
        private SecurityLevel securityLevel = SecurityLevel.FfdSecurityLevelLowHost;
        private MatchingStrategy matchingStrategy = MatchingStrategy.MorphoStandardMatchingStrategy;
        private StrategyAcquisitionMode strategyAcquisitionMode = StrategyAcquisitionMode.MorphoAcqExpertMode;
        private Boolean forceFingerPlacementOnTop = true;
        private Boolean advancedSecLevCompReq = false;
        private Boolean fingerprintQualityThreshold = true;
        private int fingerprintQualityThresholdvalue = 0;

        // Logging Parameters
        private MorphoLogLevel logLevel = MorphoLogLevel.MorphoLogNolog;
        private MorphoLogMode logMode = MorphoLogMode.MorphoLogDisable;


        // Options
        private Boolean imageViewer = true;
        private Boolean asyncPositioningCommand = true;
        private Boolean asyncEnrollmentCommand = true;
        private Boolean asyncDetectQuality = true;
        private Boolean asyncCodeQuality = true;
        private Boolean exportMatchingPkNumber = false;
        private Boolean wakeUpWithLedOff = false;
        private SensorWindowPosition sensorWindowPosition = SensorWindowPosition.Normal_0;
        private int callbackCmd = CallbackMask.MorphoCallbackImageCmd.Value
                | CallbackMask.MorphoCallbackEnrollmentCmd.Value
                | CallbackMask.MorphoCallbackCommandCmd.Value
                | CallbackMask.MorphoCallbackCodequality.Value
                | CallbackMask.MorphoCallbackDetectquality.Value;

        // MSO configuration
        DeviceDetectionMode MsoDetectionMode = DeviceDetectionMode.SdkDetection;
        private String MSOSerialNumber = "";
        private int MSOBus = -1;
        private int MSOAddress = -1;
        private int MSOFD = -1;
        private String MaxFAR = "";
        private System.Collections.Generic.List<SecurityOption> SecurityOptions = new System.Collections.Generic.List<SecurityOption>();

        private volatile Boolean commandBioStart = false;

        //private MorphoSample				morphoSample						= null;

        public MorphoInfo getMorphoInfo()
        {
            return morphoInfo;
        }

        public void setMorphoInfo(MorphoInfo morphoInfo)
        {
            this.morphoInfo = morphoInfo;
        }

        public Boolean isBaseStatusOk()
        {
            return baseStatusOk;
        }

        public void setBaseStatusOk(Boolean baseStatusOk)
        {
            this.baseStatusOk = baseStatusOk;
        }

        public String getPKFormat()
        {
            return this.pkFormat;
        }

        public void setPKFormat(String pkformat)
        {
            this.pkFormat = pkformat;
        }

        public long getFieldsNumber()
        {
            return this.fieldsNumber;
        }

        public void setFieldsNumber(long fieldsnumber)
        {
            this.fieldsNumber = fieldsnumber;
        }

        public Boolean isNoCheck()
        {
            return noCheck;
        }

        public void setNoCheck(Boolean noCheck)
        {
            this.noCheck = noCheck;
        }

        public Java.Util.ArrayList getDatabaseItems()
        {
            return null;
        }

        public void setDatabaseItems(Java.Util.ArrayList databaseItems)
        {
            this.databaseItems = databaseItems;
        }

        public int getDatabaseSelectedIndex()
        {
            return databaseSelectedIndex;
        }

        public void setDatabaseSelectedIndex(int databaseSelectedIndex)
        {
            this.databaseSelectedIndex = databaseSelectedIndex;
        }

        public long getMaximumNumberOfRecordValue()
        {
            return maximumNumberOfRecordValue;
        }

        public void setMaximumNumberOfRecordValue(long maximumNumberOfRecordValue)
        {
            this.maximumNumberOfRecordValue = maximumNumberOfRecordValue;
        }

        public int getMaximumNumberOfDBsValue()
        {
            return maximumNumberofDatabaseValue;
        }

        public void setMaximumNumberOfDBsValue(int maximumNumberofDatabaseValue)
        {
            this.maximumNumberofDatabaseValue = maximumNumberofDatabaseValue;
        }

        public int getNumberOfFingerPerRecord()
        {
            return numberOfFingerPerRecord;
        }

        public void setNumberOfFingerPerRecord(int numberOfFingerPerRecord)
        {
            this.numberOfFingerPerRecord = numberOfFingerPerRecord;
        }

        public int getCurrentNumberOfRecordValue()
        {
            return currentNumberofRecordValue;
        }

        public void setCurrentNumberOfRecordValue(int currentNumberOfRecordValue)
        {
            this.currentNumberofRecordValue = currentNumberOfRecordValue;
        }

        public long getCurrentNumberOfFreeRecordValue()
        {
            return currentNumberOfFreeRecordValue;
        }

        public void setCurrentNumberOfFreeRecordValue(long currentNumberOfFreeRecordValue)
        {
            this.currentNumberOfFreeRecordValue = currentNumberOfFreeRecordValue;
        }

        public long getCurrentNumberOfUsedRecordValue()
        {
            return currentNumberOfUsedRecordValue;
        }

        public void setCurrentNumberOfUsedRecordValue(long currentNumberOfUsedRecordValue)
        {
            this.currentNumberOfUsedRecordValue = currentNumberOfUsedRecordValue;
        }


        public DeviceDetectionMode getMsoDetectionMode()
        {
            return MsoDetectionMode;
        }

        public void setMsoDetectionMode(DeviceDetectionMode msoDetectionMode)
        {
            MsoDetectionMode = msoDetectionMode;
        }

        public String getMSOSerialNumber()
        {
            return MSOSerialNumber;
        }

        public void setMSOSerialNumber(String mSOSerialNumber)
        {
            MSOSerialNumber = mSOSerialNumber;
        }

        public int getMSOBus()
        {
            return MSOBus;
        }

        public void setMSOBus(int mSOBus)
        {
            MSOBus = mSOBus;
        }

        public int getMSOAddress()
        {
            return MSOAddress;
        }

        public void setMSOAddress(int mSOAddress)
        {
            MSOAddress = mSOAddress;
        }

        public int getMSOFD()
        {
            return MSOFD;
        }

        public void setMSOFD(int mSOFD)
        {
            MSOFD = mSOFD;
        }

        public String getMaxFAR()
        {
            return MaxFAR;
        }

        public void setMaxFAR(String maxFAR)
        {
            MaxFAR = maxFAR;
        }

        public System.Collections.Generic.List<SecurityOption> getSecurityOptions()
        {
            return SecurityOptions;
        }

        public void setSecurityOptions(System.Collections.Generic.List<SecurityOption> securityOptions)
        {
            SecurityOptions = securityOptions;
        }

        /**
         * @return the morphoDevice
         */
        public MorphoDevice getMorphoDevice()
        {
            return morphoDevice;
        }

        /**
         * @param morphoDevice the morphoDevice to set
         */
        public void setMorphoDevice(MorphoDevice morphoDevice)
        {
            this.morphoDevice = morphoDevice;
        }

        /**
         * @return the device
         */
        public MorphoDevice getDevice()
        {
            return device;
        }

        /**
         * @param device the morphoDevice to set
         */
        public void setDevice(MorphoDevice device)
        {
            this.device = device;
        }

        /**
         * @return the isStarted
         */
        public Boolean IsStarted()
        {
            return isStarted;
        }

        /**
         * @param isStarted the isStarted to set
         */
        public void setStarted(Boolean isStarted)
        {
            this.isStarted = isStarted;
        }

        public Boolean isImageViewer()
        {
            return imageViewer;
        }

        public void setImageViewer(Boolean imageViewer)
        {
            this.imageViewer = imageViewer;
            if (imageViewer)
            {
                callbackCmd |= CallbackMask.MorphoCallbackImageCmd.Value;
            }
            else
            {
                callbackCmd &= ~CallbackMask.MorphoCallbackImageCmd.Value;
            }
        }

        public Boolean isAsyncPositioningCommand()
        {
            return asyncPositioningCommand;
        }

        public void setAsyncPositioningCommand(Boolean asyncPositioningCommand)
        {
            this.asyncPositioningCommand = asyncPositioningCommand;
            if (asyncPositioningCommand)
            {
                callbackCmd |= CallbackMask.MorphoCallbackCommandCmd.Value;
            }
            else
            {
                callbackCmd &= ~CallbackMask.MorphoCallbackCommandCmd.Value;
            }
        }

        public Boolean isAsyncEnrollmentCommand()
        {
            return asyncEnrollmentCommand;
        }

        public void setAsyncEnrollmentCommand(Boolean asyncEnrollmentCommand)
        {
            this.asyncEnrollmentCommand = asyncEnrollmentCommand;
            if (asyncEnrollmentCommand)
            {
                callbackCmd |= CallbackMask.MorphoCallbackEnrollmentCmd.Value;
            }
            else
            {
                callbackCmd &= ~CallbackMask.MorphoCallbackEnrollmentCmd.Value;
            }
        }

        public Boolean isAsyncDetectQuality()
        {
            return asyncDetectQuality;
        }

        public void setAsyncDetectQuality(Boolean asyncDetectQuality)
        {
            this.asyncDetectQuality = asyncDetectQuality;
            if (asyncDetectQuality)
            {
                callbackCmd |= CallbackMask.MorphoCallbackDetectquality.Value;
            }
            else
            {
                callbackCmd &= ~CallbackMask.MorphoCallbackDetectquality.Value;
            }
        }

        public Boolean isAsyncCodeQuality()
        {
            return asyncCodeQuality;
        }

        public void setAsyncCodeQuality(Boolean asyncCodeQuality)
        {
            this.asyncCodeQuality = asyncCodeQuality;
            if (asyncDetectQuality)
            {
                callbackCmd |= CallbackMask.MorphoCallbackCodequality.Value;
            }
            else
            {
                callbackCmd &= ~CallbackMask.MorphoCallbackCodequality.Value;
            }
        }

        public Boolean isExportMatchingPkNumber()
        {
            return exportMatchingPkNumber;
        }

        public void setExportMatchingPkNumber(Boolean exportMatchingPkNumber)
        {
            this.exportMatchingPkNumber = exportMatchingPkNumber;
        }

        public Boolean isWakeUpWithLedOff()
        {
            return wakeUpWithLedOff;
        }

        public void setWakeUpWithLedOff(Boolean wakeUpWithLedOff)
        {
            this.wakeUpWithLedOff = wakeUpWithLedOff;
        }

        public SensorWindowPosition getSensorWindowPosition()
        {
            return sensorWindowPosition;
        }

        public void setSensorWindowPosition(SensorWindowPosition sensorWindowPosition)
        {
            this.sensorWindowPosition = sensorWindowPosition;
        }

        public int getMatchingThreshold()
        {
            return matchingThreshold;
        }

        public int setMatchingThreshold(int matchingThreshold)
        {
            if ((matchingThreshold >= 0) && (matchingThreshold <= 10))
            {
                this.matchingThreshold = matchingThreshold;
            }
            else
            {
                this.matchingThreshold = matchingThreshold % 10;
            }
            return this.matchingThreshold;
        }

        public int getTimeout()
        {
            return Timeout;
        }

        public void setTimeout(int timeout)
        {
            Timeout = timeout;
        }

        public SecurityLevel getSecurityLevel()
        {
            return securityLevel;
        }

        public void setSecurityLevel(SecurityLevel securityLevel)
        {
            this.securityLevel = securityLevel;
        }

        public MatchingStrategy getMatchingStrategy()
        {
            return matchingStrategy;
        }

        public void setMatchingStrategy(MatchingStrategy matchingStrategy)
        {
            this.matchingStrategy = matchingStrategy;
        }

        public Boolean isForceFingerPlacementOnTop()
        {
            return forceFingerPlacementOnTop;
        }

        public void setForceFingerPlacementOnTop(Boolean forceFingerPacementOnTop)
        {
            this.forceFingerPlacementOnTop = forceFingerPacementOnTop;
        }

        public Boolean isFingerprintQualityThreshold()
        {
            return fingerprintQualityThreshold;
        }

        public void setFingerprintQualityThreshold(Boolean fingerprintQualityThreshold)
        {
            this.fingerprintQualityThreshold = fingerprintQualityThreshold;
        }

        public int getFingerprintQualityThresholdvalue()
        {
            return fingerprintQualityThresholdvalue;
        }

        public void setFingerprintQualityThresholdvalue(int fingerprintQualityThresholdvalue)
        {
            this.fingerprintQualityThresholdvalue = fingerprintQualityThresholdvalue;
        }

        /**
         * @return the coder
         */
        public Coder getCoder()
        {
            return coder;
        }

        /**
         * @param coder the coder to set
         */
        public void setCoder(Coder coder)
        {
            this.coder = coder;
        }

        /**
         * @return the morphoDatabase
         */
        public MorphoDatabase getMorphoDatabase()
        {
            return morphoDatabase;
        }

        /**
         * @param morphoDatabase the morphoDatabase to set
         */
        public void setMorphoDatabase(MorphoDatabase morphoDatabase)
        {
            this.morphoDatabase = morphoDatabase;
        }

        public void setAdvancedSecLevCompReq(Boolean advancedSecLevCompReq)
        {
            this.advancedSecLevCompReq = advancedSecLevCompReq;
        }

        /**
         * @return the boolean is Advanced Security Levels Compatibility Required
         */
        public Boolean isAdvancedSecLevCompReq()
        {
            return advancedSecLevCompReq;
        }

        /**
         * @return the commandBioStart
         */
        public Boolean isCommandBioStart()
        {
            return commandBioStart;
        }

        /**
         * @param commandBioStart the commandBioStart to set
         */
        public void setCommandBioStart(Boolean commandBioStart)
        {
            this.commandBioStart = commandBioStart;
        }

        public int getCallbackCmd()
        {
            return callbackCmd;
        }

        public void setCallbackCmd(int callbackCmd)
        {
            this.callbackCmd = callbackCmd;
        }

        /*public MorphoSample getMorphoSample()
        {
            return morphoSample;
        }

        public void setMorphoSample(MorphoSample morphoSample)
        {
            this.morphoSample = morphoSample;
        }*/

        public String getEncryptDatabaseValue()
        {
            return encryptDatabaseValue;
        }

        public void setEncryptDatabaseValue(String encryptDatabaseValue)
        {
            this.encryptDatabaseValue = encryptDatabaseValue;
        }

        public StrategyAcquisitionMode getStrategyAcquisitionMode()
        {
            return strategyAcquisitionMode;
        }

        public void setStrategyAcquisitionMode(StrategyAcquisitionMode strategyAcquisitionMode)
        {
            this.strategyAcquisitionMode = strategyAcquisitionMode;
        }

        public MorphoLogLevel getLogLevel()
        {
            return logLevel;
        }

        public void setLogLevel(MorphoLogLevel logLevel)
        {
            this.logLevel = logLevel;
        }

        public MorphoLogMode getLogMode()
        {
            return logMode;
        }

        public void setLogMode(MorphoLogMode logMode)
        {
            this.logMode = logMode;
        }
    }
}