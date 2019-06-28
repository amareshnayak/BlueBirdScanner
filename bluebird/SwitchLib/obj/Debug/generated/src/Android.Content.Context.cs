using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Content {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.content']/class[@name='Context']"
	[global::Android.Runtime.Register ("android/content/Context", DoNotGenerateAcw=true)]
	public abstract partial class Context : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='ACCESSIBILITY_SERVICE']"
		[Register ("ACCESSIBILITY_SERVICE")]
		public const string AccessibilityService = (string) "accessibility";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='ACCOUNT_SERVICE']"
		[Register ("ACCOUNT_SERVICE")]
		public const string AccountService = (string) "account";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='ACTIVITY_SERVICE']"
		[Register ("ACTIVITY_SERVICE")]
		public const string ActivityService = (string) "activity";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='ALARM_SERVICE']"
		[Register ("ALARM_SERVICE")]
		public const string AlarmService = (string) "alarm";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='APPWIDGET_SERVICE']"
		[Register ("APPWIDGET_SERVICE")]
		public const string AppwidgetService = (string) "appwidget";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='APP_OPS_SERVICE']"
		[Register ("APP_OPS_SERVICE")]
		public const string AppOpsService = (string) "appops";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='AUDIO_SERVICE']"
		[Register ("AUDIO_SERVICE")]
		public const string AudioService = (string) "audio";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BACKUP_SERVICE']"
		[Register ("BACKUP_SERVICE")]
		public const string BackupService = (string) "backup";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BARCODE_REMOTE_CALLBACK']"
		[Register ("BARCODE_REMOTE_CALLBACK")]
		public const string BarcodeRemoteCallback = (string) "barcodeRemoteCallback";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BARCODE_REMOTE_SERVICE']"
		[Register ("BARCODE_REMOTE_SERVICE")]
		public const string BarcodeRemoteService = (string) "barcodeRemoteService";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BATTERY_SERVICE']"
		[Register ("BATTERY_SERVICE")]
		public const string BatteryService = (string) "batterymanager";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_ABOVE_CLIENT']"
		[Register ("BIND_ABOVE_CLIENT")]
		public const int BindAboveClient = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_ADJUST_WITH_ACTIVITY']"
		[Register ("BIND_ADJUST_WITH_ACTIVITY")]
		public const int BindAdjustWithActivity = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_ALLOW_OOM_MANAGEMENT']"
		[Register ("BIND_ALLOW_OOM_MANAGEMENT")]
		public const int BindAllowOomManagement = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_AUTO_CREATE']"
		[Register ("BIND_AUTO_CREATE")]
		public const int BindAutoCreate = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_DEBUG_UNBIND']"
		[Register ("BIND_DEBUG_UNBIND")]
		public const int BindDebugUnbind = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_FOREGROUND_SERVICE']"
		[Register ("BIND_FOREGROUND_SERVICE")]
		public const int BindForegroundService = (int) 67108864;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_FOREGROUND_SERVICE_WHILE_AWAKE']"
		[Register ("BIND_FOREGROUND_SERVICE_WHILE_AWAKE")]
		public const int BindForegroundServiceWhileAwake = (int) 33554432;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_IMPORTANT']"
		[Register ("BIND_IMPORTANT")]
		public const int BindImportant = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_NOT_FOREGROUND']"
		[Register ("BIND_NOT_FOREGROUND")]
		public const int BindNotForeground = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_NOT_VISIBLE']"
		[Register ("BIND_NOT_VISIBLE")]
		public const int BindNotVisible = (int) 1073741824;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_SHOWING_UI']"
		[Register ("BIND_SHOWING_UI")]
		public const int BindShowingUi = (int) 536870912;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_TREAT_LIKE_ACTIVITY']"
		[Register ("BIND_TREAT_LIKE_ACTIVITY")]
		public const int BindTreatLikeActivity = (int) 134217728;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_VISIBLE']"
		[Register ("BIND_VISIBLE")]
		public const int BindVisible = (int) 268435456;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BIND_WAIVE_PRIORITY']"
		[Register ("BIND_WAIVE_PRIORITY")]
		public const int BindWaivePriority = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BLUEEXTENDED_POLICY']"
		[Register ("BLUEEXTENDED_POLICY")]
		public const string BlueextendedPolicy = (string) "blue_extended_policy";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='BLUETOOTH_SERVICE']"
		[Register ("BLUETOOTH_SERVICE")]
		public const string BluetoothService = (string) "bluetooth";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CAMERA_SERVICE']"
		[Register ("CAMERA_SERVICE")]
		public const string CameraService = (string) "camera";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CAPTIONING_SERVICE']"
		[Register ("CAPTIONING_SERVICE")]
		public const string CaptioningService = (string) "captioning";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CARRIER_CONFIG_SERVICE']"
		[Register ("CARRIER_CONFIG_SERVICE")]
		public const string CarrierConfigService = (string) "carrier_config";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CLIPBOARD_SERVICE']"
		[Register ("CLIPBOARD_SERVICE")]
		public const string ClipboardService = (string) "clipboard";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CONNECTIVITY_SERVICE']"
		[Register ("CONNECTIVITY_SERVICE")]
		public const string ConnectivityService = (string) "connectivity";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CONSUMER_IR_SERVICE']"
		[Register ("CONSUMER_IR_SERVICE")]
		public const string ConsumerIrService = (string) "consumer_ir";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CONTEXT_IGNORE_SECURITY']"
		[Register ("CONTEXT_IGNORE_SECURITY")]
		public const int ContextIgnoreSecurity = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CONTEXT_INCLUDE_CODE']"
		[Register ("CONTEXT_INCLUDE_CODE")]
		public const int ContextIncludeCode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CONTEXT_REGISTER_PACKAGE']"
		[Register ("CONTEXT_REGISTER_PACKAGE")]
		public const int ContextRegisterPackage = (int) 1073741824;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CONTEXT_RESTRICTED']"
		[Register ("CONTEXT_RESTRICTED")]
		public const int ContextRestricted = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='COUNTRY_DETECTOR']"
		[Register ("COUNTRY_DETECTOR")]
		public const string CountryDetector = (string) "country_detector";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='CUSTOM_SETTINGS']"
		[Register ("CUSTOM_SETTINGS")]
		public const string CustomSettings = (string) "customizing";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='DEVICE_IDLE_CONTROLLER']"
		[Register ("DEVICE_IDLE_CONTROLLER")]
		public const string DeviceIdleController = (string) "deviceidle";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='DEVICE_POLICY_SERVICE']"
		[Register ("DEVICE_POLICY_SERVICE")]
		public const string DevicePolicyService = (string) "device_policy";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='DISPLAY_SERVICE']"
		[Register ("DISPLAY_SERVICE")]
		public const string DisplayService = (string) "display";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='DOWNLOAD_SERVICE']"
		[Register ("DOWNLOAD_SERVICE")]
		public const string DownloadService = (string) "download";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='DROPBOX_SERVICE']"
		[Register ("DROPBOX_SERVICE")]
		public const string DropboxService = (string) "dropbox";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='EPAYMENT_SERVICE']"
		[Register ("EPAYMENT_SERVICE")]
		public const string EpaymentService = (string) "epayment";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='ETHERNET_SERVICE']"
		[Register ("ETHERNET_SERVICE")]
		public const string EthernetService = (string) "ethernet";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='EXTNFC_SERVICE']"
		[Register ("EXTNFC_SERVICE")]
		public const string ExtnfcService = (string) "extnfc";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='FINGERPRINT_SERVICE']"
		[Register ("FINGERPRINT_SERVICE")]
		public const string FingerprintService = (string) "fingerprint";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='HDMI_CONTROL_SERVICE']"
		[Register ("HDMI_CONTROL_SERVICE")]
		public const string HdmiControlService = (string) "hdmi_control";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='INPUT_METHOD_SERVICE']"
		[Register ("INPUT_METHOD_SERVICE")]
		public const string InputMethodService = (string) "input_method";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='INPUT_SERVICE']"
		[Register ("INPUT_SERVICE")]
		public const string InputService = (string) "input";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='JOB_SCHEDULER_SERVICE']"
		[Register ("JOB_SCHEDULER_SERVICE")]
		public const string JobSchedulerService = (string) "jobscheduler";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='KEYGUARD_SERVICE']"
		[Register ("KEYGUARD_SERVICE")]
		public const string KeyguardService = (string) "keyguard";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='LAUNCHER_APPS_SERVICE']"
		[Register ("LAUNCHER_APPS_SERVICE")]
		public const string LauncherAppsService = (string) "launcherapps";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='LAYOUT_INFLATER_SERVICE']"
		[Register ("LAYOUT_INFLATER_SERVICE")]
		public const string LayoutInflaterService = (string) "layout_inflater";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='LOCATION_SERVICE']"
		[Register ("LOCATION_SERVICE")]
		public const string LocationService = (string) "location";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MEDIA_PROJECTION_SERVICE']"
		[Register ("MEDIA_PROJECTION_SERVICE")]
		public const string MediaProjectionService = (string) "media_projection";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MEDIA_ROUTER_SERVICE']"
		[Register ("MEDIA_ROUTER_SERVICE")]
		public const string MediaRouterService = (string) "media_router";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MEDIA_SESSION_SERVICE']"
		[Register ("MEDIA_SESSION_SERVICE")]
		public const string MediaSessionService = (string) "media_session";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MIDI_SERVICE']"
		[Register ("MIDI_SERVICE")]
		public const string MidiService = (string) "midi";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MODE_APPEND']"
		[Register ("MODE_APPEND")]
		public const int ModeAppend = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MODE_ENABLE_WRITE_AHEAD_LOGGING']"
		[Register ("MODE_ENABLE_WRITE_AHEAD_LOGGING")]
		public const int ModeEnableWriteAheadLogging = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MODE_MULTI_PROCESS']"
		[Register ("MODE_MULTI_PROCESS")]
		[Obsolete ("deprecated")]
		public const int ModeMultiProcess = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MODE_PRIVATE']"
		[Register ("MODE_PRIVATE")]
		public const int ModePrivate = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MODE_WORLD_READABLE']"
		[Register ("MODE_WORLD_READABLE")]
		[Obsolete ("deprecated")]
		public const int ModeWorldReadable = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='MODE_WORLD_WRITEABLE']"
		[Register ("MODE_WORLD_WRITEABLE")]
		[Obsolete ("deprecated")]
		public const int ModeWorldWriteable = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NETWORKMANAGEMENT_SERVICE']"
		[Register ("NETWORKMANAGEMENT_SERVICE")]
		public const string NetworkmanagementService = (string) "network_management";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NETWORK_POLICY_SERVICE']"
		[Register ("NETWORK_POLICY_SERVICE")]
		public const string NetworkPolicyService = (string) "netpolicy";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NETWORK_SCORE_SERVICE']"
		[Register ("NETWORK_SCORE_SERVICE")]
		public const string NetworkScoreService = (string) "network_score";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NETWORK_STATS_SERVICE']"
		[Register ("NETWORK_STATS_SERVICE")]
		public const string NetworkStatsService = (string) "netstats";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NFC_SERVICE']"
		[Register ("NFC_SERVICE")]
		public const string NfcService = (string) "nfc";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NOTIFICATION_SERVICE']"
		[Register ("NOTIFICATION_SERVICE")]
		public const string NotificationService = (string) "notification";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='NSD_SERVICE']"
		[Register ("NSD_SERVICE")]
		public const string NsdService = (string) "servicediscovery";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='PERSISTENT_DATA_BLOCK_SERVICE']"
		[Register ("PERSISTENT_DATA_BLOCK_SERVICE")]
		public const string PersistentDataBlockService = (string) "persistent_data_block";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='POWER_SERVICE']"
		[Register ("POWER_SERVICE")]
		public const string PowerService = (string) "power";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='PRINT_SERVICE']"
		[Register ("PRINT_SERVICE")]
		public const string PrintService = (string) "print";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='RADIO_SERVICE']"
		[Register ("RADIO_SERVICE")]
		public const string RadioService = (string) "radio";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='RESTRICTIONS_SERVICE']"
		[Register ("RESTRICTIONS_SERVICE")]
		public const string RestrictionsService = (string) "restrictions";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='SEARCH_SERVICE']"
		[Register ("SEARCH_SERVICE")]
		public const string SearchService = (string) "search";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='SENSOR_SERVICE']"
		[Register ("SENSOR_SERVICE")]
		public const string SensorService = (string) "sensor";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='SERIAL_SERVICE']"
		[Register ("SERIAL_SERVICE")]
		public const string SerialService = (string) "serial";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='SIP_SERVICE']"
		[Register ("SIP_SERVICE")]
		public const string SipService = (string) "sip";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='SLED_SERVICE']"
		[Register ("SLED_SERVICE")]
		public const string SledService = (string) "sled";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='STATUS_BAR_SERVICE']"
		[Register ("STATUS_BAR_SERVICE")]
		public const string StatusBarService = (string) "statusbar";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='STORAGE_SERVICE']"
		[Register ("STORAGE_SERVICE")]
		public const string StorageService = (string) "storage";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='SYSTEMUPDATE_SERVICE']"
		[Register ("SYSTEMUPDATE_SERVICE")]
		public const string SystemupdateService = (string) "system_update";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='TELECOM_SERVICE']"
		[Register ("TELECOM_SERVICE")]
		public const string TelecomService = (string) "telecom";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='TELEPHONY_SERVICE']"
		[Register ("TELEPHONY_SERVICE")]
		public const string TelephonyService = (string) "phone";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='TELEPHONY_SUBSCRIPTION_SERVICE']"
		[Register ("TELEPHONY_SUBSCRIPTION_SERVICE")]
		public const string TelephonySubscriptionService = (string) "telephony_subscription_service";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='TEXT_SERVICES_MANAGER_SERVICE']"
		[Register ("TEXT_SERVICES_MANAGER_SERVICE")]
		public const string TextServicesManagerService = (string) "textservices";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='TRUST_SERVICE']"
		[Register ("TRUST_SERVICE")]
		public const string TrustService = (string) "trust";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='TV_INPUT_SERVICE']"
		[Register ("TV_INPUT_SERVICE")]
		public const string TvInputService = (string) "tv_input";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='UI_MODE_SERVICE']"
		[Register ("UI_MODE_SERVICE")]
		public const string UiModeService = (string) "uimode";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='UPDATE_LOCK_SERVICE']"
		[Register ("UPDATE_LOCK_SERVICE")]
		public const string UpdateLockService = (string) "updatelock";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='USAGE_STATS_SERVICE']"
		[Register ("USAGE_STATS_SERVICE")]
		public const string UsageStatsService = (string) "usagestats";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='USB_SERVICE']"
		[Register ("USB_SERVICE")]
		public const string UsbService = (string) "usb";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='USER_SERVICE']"
		[Register ("USER_SERVICE")]
		public const string UserService = (string) "user";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='VIBRATOR_SERVICE']"
		[Register ("VIBRATOR_SERVICE")]
		public const string VibratorService = (string) "vibrator";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='VOICE_INTERACTION_MANAGER_SERVICE']"
		[Register ("VOICE_INTERACTION_MANAGER_SERVICE")]
		public const string VoiceInteractionManagerService = (string) "voiceinteraction";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WALLPAPER_SERVICE']"
		[Register ("WALLPAPER_SERVICE")]
		public const string WallpaperService = (string) "wallpaper";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WIFI_P2P_SERVICE']"
		[Register ("WIFI_P2P_SERVICE")]
		public const string WifiP2pService = (string) "wifip2p";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WIFI_PASSPOINT_SERVICE']"
		[Register ("WIFI_PASSPOINT_SERVICE")]
		public const string WifiPasspointService = (string) "wifipasspoint";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WIFI_RTT_SERVICE']"
		[Register ("WIFI_RTT_SERVICE")]
		public const string WifiRttService = (string) "rttmanager";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WIFI_SCANNING_SERVICE']"
		[Register ("WIFI_SCANNING_SERVICE")]
		public const string WifiScanningService = (string) "wifiscanner";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WIFI_SERVICE']"
		[Register ("WIFI_SERVICE")]
		public const string WifiService = (string) "wifi";

		// Metadata.xml XPath field reference: path="/api/package[@name='android.content']/class[@name='Context']/field[@name='WINDOW_SERVICE']"
		[Register ("WINDOW_SERVICE")]
		public const string WindowService = (string) "window";
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("android/content/Context", typeof (Context));
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

		protected Context (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.content']/class[@name='Context']/constructor[@name='Context' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Context ()
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

		static Delegate cb_getApplicationContext;
#pragma warning disable 0169
		static Delegate GetGetApplicationContextHandler ()
		{
			if (cb_getApplicationContext == null)
				cb_getApplicationContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationContext);
			return cb_getApplicationContext;
		}

		static IntPtr n_GetApplicationContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationContext);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")] get;
		}

		static Delegate cb_getApplicationInfo;
#pragma warning disable 0169
		static Delegate GetGetApplicationInfoHandler ()
		{
			if (cb_getApplicationInfo == null)
				cb_getApplicationInfo = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetApplicationInfo);
			return cb_getApplicationInfo;
		}

		static IntPtr n_GetApplicationInfo (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ApplicationInfo);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.PM.ApplicationInfo ApplicationInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getApplicationInfo' and count(parameter)=0]"
			[Register ("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", "GetGetApplicationInfoHandler")] get;
		}

		static Delegate cb_getAssets;
#pragma warning disable 0169
		static Delegate GetGetAssetsHandler ()
		{
			if (cb_getAssets == null)
				cb_getAssets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAssets);
			return cb_getAssets;
		}

		static IntPtr n_GetAssets (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Assets);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.Res.AssetManager Assets {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getAssets' and count(parameter)=0]"
			[Register ("getAssets", "()Landroid/content/res/AssetManager;", "GetGetAssetsHandler")] get;
		}

		static Delegate cb_getBasePackageName;
#pragma warning disable 0169
		static Delegate GetGetBasePackageNameHandler ()
		{
			if (cb_getBasePackageName == null)
				cb_getBasePackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBasePackageName);
			return cb_getBasePackageName;
		}

		static IntPtr n_GetBasePackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BasePackageName);
		}
#pragma warning restore 0169

		public abstract string BasePackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getBasePackageName' and count(parameter)=0]"
			[Register ("getBasePackageName", "()Ljava/lang/String;", "GetGetBasePackageNameHandler")] get;
		}

		static Delegate cb_getCacheDir;
#pragma warning disable 0169
		static Delegate GetGetCacheDirHandler ()
		{
			if (cb_getCacheDir == null)
				cb_getCacheDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCacheDir);
			return cb_getCacheDir;
		}

		static IntPtr n_GetCacheDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CacheDir);
		}
#pragma warning restore 0169

		public abstract global::Java.IO.File CacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getCacheDir' and count(parameter)=0]"
			[Register ("getCacheDir", "()Ljava/io/File;", "GetGetCacheDirHandler")] get;
		}

		static Delegate cb_getClassLoader;
#pragma warning disable 0169
		static Delegate GetGetClassLoaderHandler ()
		{
			if (cb_getClassLoader == null)
				cb_getClassLoader = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetClassLoader);
			return cb_getClassLoader;
		}

		static IntPtr n_GetClassLoader (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ClassLoader);
		}
#pragma warning restore 0169

		public abstract global::Java.Lang.ClassLoader ClassLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getClassLoader' and count(parameter)=0]"
			[Register ("getClassLoader", "()Ljava/lang/ClassLoader;", "GetGetClassLoaderHandler")] get;
		}

		static Delegate cb_getCodeCacheDir;
#pragma warning disable 0169
		static Delegate GetGetCodeCacheDirHandler ()
		{
			if (cb_getCodeCacheDir == null)
				cb_getCodeCacheDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCodeCacheDir);
			return cb_getCodeCacheDir;
		}

		static IntPtr n_GetCodeCacheDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CodeCacheDir);
		}
#pragma warning restore 0169

		public abstract global::Java.IO.File CodeCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getCodeCacheDir' and count(parameter)=0]"
			[Register ("getCodeCacheDir", "()Ljava/io/File;", "GetGetCodeCacheDirHandler")] get;
		}

		static Delegate cb_getContentResolver;
#pragma warning disable 0169
		static Delegate GetGetContentResolverHandler ()
		{
			if (cb_getContentResolver == null)
				cb_getContentResolver = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentResolver);
			return cb_getContentResolver;
		}

		static IntPtr n_GetContentResolver (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentResolver);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.ContentResolver ContentResolver {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getContentResolver' and count(parameter)=0]"
			[Register ("getContentResolver", "()Landroid/content/ContentResolver;", "GetGetContentResolverHandler")] get;
		}

		static Delegate cb_getExternalCacheDir;
#pragma warning disable 0169
		static Delegate GetGetExternalCacheDirHandler ()
		{
			if (cb_getExternalCacheDir == null)
				cb_getExternalCacheDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalCacheDir);
			return cb_getExternalCacheDir;
		}

		static IntPtr n_GetExternalCacheDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ExternalCacheDir);
		}
#pragma warning restore 0169

		public abstract global::Java.IO.File ExternalCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalCacheDir' and count(parameter)=0]"
			[Register ("getExternalCacheDir", "()Ljava/io/File;", "GetGetExternalCacheDirHandler")] get;
		}

		static Delegate cb_getFilesDir;
#pragma warning disable 0169
		static Delegate GetGetFilesDirHandler ()
		{
			if (cb_getFilesDir == null)
				cb_getFilesDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilesDir);
			return cb_getFilesDir;
		}

		static IntPtr n_GetFilesDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FilesDir);
		}
#pragma warning restore 0169

		public abstract global::Java.IO.File FilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getFilesDir' and count(parameter)=0]"
			[Register ("getFilesDir", "()Ljava/io/File;", "GetGetFilesDirHandler")] get;
		}

		static Delegate cb_isRestricted;
#pragma warning disable 0169
		static Delegate GetIsRestrictedHandler ()
		{
			if (cb_isRestricted == null)
				cb_isRestricted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsRestricted);
			return cb_isRestricted;
		}

		static bool n_IsRestricted (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRestricted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRestricted {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='isRestricted' and count(parameter)=0]"
			[Register ("isRestricted", "()Z", "GetIsRestrictedHandler")]
			get {
				const string __id = "isRestricted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMainLooper;
#pragma warning disable 0169
		static Delegate GetGetMainLooperHandler ()
		{
			if (cb_getMainLooper == null)
				cb_getMainLooper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMainLooper);
			return cb_getMainLooper;
		}

		static IntPtr n_GetMainLooper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MainLooper);
		}
#pragma warning restore 0169

		public abstract global::Android.OS.Looper MainLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getMainLooper' and count(parameter)=0]"
			[Register ("getMainLooper", "()Landroid/os/Looper;", "GetGetMainLooperHandler")] get;
		}

		static Delegate cb_getNoBackupFilesDir;
#pragma warning disable 0169
		static Delegate GetGetNoBackupFilesDirHandler ()
		{
			if (cb_getNoBackupFilesDir == null)
				cb_getNoBackupFilesDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNoBackupFilesDir);
			return cb_getNoBackupFilesDir;
		}

		static IntPtr n_GetNoBackupFilesDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NoBackupFilesDir);
		}
#pragma warning restore 0169

		public abstract global::Java.IO.File NoBackupFilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getNoBackupFilesDir' and count(parameter)=0]"
			[Register ("getNoBackupFilesDir", "()Ljava/io/File;", "GetGetNoBackupFilesDirHandler")] get;
		}

		static Delegate cb_getObbDir;
#pragma warning disable 0169
		static Delegate GetGetObbDirHandler ()
		{
			if (cb_getObbDir == null)
				cb_getObbDir = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObbDir);
			return cb_getObbDir;
		}

		static IntPtr n_GetObbDir (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ObbDir);
		}
#pragma warning restore 0169

		public abstract global::Java.IO.File ObbDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getObbDir' and count(parameter)=0]"
			[Register ("getObbDir", "()Ljava/io/File;", "GetGetObbDirHandler")] get;
		}

		static Delegate cb_getOpPackageName;
#pragma warning disable 0169
		static Delegate GetGetOpPackageNameHandler ()
		{
			if (cb_getOpPackageName == null)
				cb_getOpPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOpPackageName);
			return cb_getOpPackageName;
		}

		static IntPtr n_GetOpPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.OpPackageName);
		}
#pragma warning restore 0169

		public abstract string OpPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getOpPackageName' and count(parameter)=0]"
			[Register ("getOpPackageName", "()Ljava/lang/String;", "GetGetOpPackageNameHandler")] get;
		}

		static Delegate cb_getPackageCodePath;
#pragma warning disable 0169
		static Delegate GetGetPackageCodePathHandler ()
		{
			if (cb_getPackageCodePath == null)
				cb_getPackageCodePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageCodePath);
			return cb_getPackageCodePath;
		}

		static IntPtr n_GetPackageCodePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageCodePath);
		}
#pragma warning restore 0169

		public abstract string PackageCodePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageCodePath' and count(parameter)=0]"
			[Register ("getPackageCodePath", "()Ljava/lang/String;", "GetGetPackageCodePathHandler")] get;
		}

		static Delegate cb_getPackageManager;
#pragma warning disable 0169
		static Delegate GetGetPackageManagerHandler ()
		{
			if (cb_getPackageManager == null)
				cb_getPackageManager = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageManager);
			return cb_getPackageManager;
		}

		static IntPtr n_GetPackageManager (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PackageManager);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.PM.PackageManager PackageManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageManager' and count(parameter)=0]"
			[Register ("getPackageManager", "()Landroid/content/pm/PackageManager;", "GetGetPackageManagerHandler")] get;
		}

		static Delegate cb_getPackageName;
#pragma warning disable 0169
		static Delegate GetGetPackageNameHandler ()
		{
			if (cb_getPackageName == null)
				cb_getPackageName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageName);
			return cb_getPackageName;
		}

		static IntPtr n_GetPackageName (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageName);
		}
#pragma warning restore 0169

		public abstract string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")] get;
		}

		static Delegate cb_getPackageResourcePath;
#pragma warning disable 0169
		static Delegate GetGetPackageResourcePathHandler ()
		{
			if (cb_getPackageResourcePath == null)
				cb_getPackageResourcePath = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPackageResourcePath);
			return cb_getPackageResourcePath;
		}

		static IntPtr n_GetPackageResourcePath (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.PackageResourcePath);
		}
#pragma warning restore 0169

		public abstract string PackageResourcePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageResourcePath' and count(parameter)=0]"
			[Register ("getPackageResourcePath", "()Ljava/lang/String;", "GetGetPackageResourcePathHandler")] get;
		}

		static Delegate cb_getResources;
#pragma warning disable 0169
		static Delegate GetGetResourcesHandler ()
		{
			if (cb_getResources == null)
				cb_getResources = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetResources);
			return cb_getResources;
		}

		static IntPtr n_GetResources (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Resources);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")] get;
		}

		static Delegate cb_getTheme;
#pragma warning disable 0169
		static Delegate GetGetThemeHandler ()
		{
			if (cb_getTheme == null)
				cb_getTheme = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTheme);
			return cb_getTheme;
		}

		static IntPtr n_GetTheme (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Theme);
		}
#pragma warning restore 0169

		public abstract global::Android.Content.Res.Resources.Theme Theme {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getTheme' and count(parameter)=0]"
			[Register ("getTheme", "()Landroid/content/res/Resources$Theme;", "GetGetThemeHandler")] get;
		}

		static Delegate cb_getThemeResId;
#pragma warning disable 0169
		static Delegate GetGetThemeResIdHandler ()
		{
			if (cb_getThemeResId == null)
				cb_getThemeResId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetThemeResId);
			return cb_getThemeResId;
		}

		static int n_GetThemeResId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThemeResId;
		}
#pragma warning restore 0169

		public virtual unsafe int ThemeResId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getThemeResId' and count(parameter)=0]"
			[Register ("getThemeResId", "()I", "GetGetThemeResIdHandler")]
			get {
				const string __id = "getThemeResId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getUserId;
#pragma warning disable 0169
		static Delegate GetGetUserIdHandler ()
		{
			if (cb_getUserId == null)
				cb_getUserId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetUserId);
			return cb_getUserId;
		}

		static int n_GetUserId (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UserId;
		}
#pragma warning restore 0169

		public abstract int UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()I", "GetGetUserIdHandler")] get;
		}

		static Delegate cb_getWallpaper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetWallpaperHandler ()
		{
			if (cb_getWallpaper == null)
				cb_getWallpaper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetWallpaper);
			return cb_getWallpaper;
		}

		[Obsolete]
		static IntPtr n_GetWallpaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Wallpaper);
		}
#pragma warning restore 0169

		public abstract global::Android.Graphics.Drawables.Drawable Wallpaper {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getWallpaper' and count(parameter)=0]"
			[Register ("getWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetGetWallpaperHandler")] get;
		}

		static Delegate cb_getWallpaperDesiredMinimumHeight;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetWallpaperDesiredMinimumHeightHandler ()
		{
			if (cb_getWallpaperDesiredMinimumHeight == null)
				cb_getWallpaperDesiredMinimumHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWallpaperDesiredMinimumHeight);
			return cb_getWallpaperDesiredMinimumHeight;
		}

		[Obsolete]
		static int n_GetWallpaperDesiredMinimumHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WallpaperDesiredMinimumHeight;
		}
#pragma warning restore 0169

		public abstract int WallpaperDesiredMinimumHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getWallpaperDesiredMinimumHeight' and count(parameter)=0]"
			[Register ("getWallpaperDesiredMinimumHeight", "()I", "GetGetWallpaperDesiredMinimumHeightHandler")] get;
		}

		static Delegate cb_getWallpaperDesiredMinimumWidth;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetWallpaperDesiredMinimumWidthHandler ()
		{
			if (cb_getWallpaperDesiredMinimumWidth == null)
				cb_getWallpaperDesiredMinimumWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWallpaperDesiredMinimumWidth);
			return cb_getWallpaperDesiredMinimumWidth;
		}

		[Obsolete]
		static int n_GetWallpaperDesiredMinimumWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WallpaperDesiredMinimumWidth;
		}
#pragma warning restore 0169

		public abstract int WallpaperDesiredMinimumWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getWallpaperDesiredMinimumWidth' and count(parameter)=0]"
			[Register ("getWallpaperDesiredMinimumWidth", "()I", "GetGetWallpaperDesiredMinimumWidthHandler")] get;
		}

		static Delegate cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I;
#pragma warning disable 0169
		static Delegate GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler ()
		{
			if (cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I == null)
				cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_BindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I);
			return cb_bindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I;
		}

		static bool n_BindService_Landroid_content_Intent_Landroid_content_ServiceConnection_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IServiceConnection p1 = (global::Android.Content.IServiceConnection)global::Java.Lang.Object.GetObject<global::Android.Content.IServiceConnection> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BindService (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='bindService' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.ServiceConnection'] and parameter[3][@type='int']]"
		[Register ("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", "GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler")]
		public abstract bool BindService (global::Android.Content.Intent p0, global::Android.Content.IServiceConnection p1, int p2);

		static Delegate cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetBindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_Handler ()
		{
			if (cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_ == null)
				cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, bool>) n_BindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_);
			return cb_bindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_;
		}

		static bool n_BindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_service, IntPtr native_conn, int flags, IntPtr native_user)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent service = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_service, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IServiceConnection conn = (global::Android.Content.IServiceConnection)global::Java.Lang.Object.GetObject<global::Android.Content.IServiceConnection> (native_conn, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BindServiceAsUser (service, conn, flags, user);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='bindServiceAsUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.ServiceConnection'] and parameter[3][@type='int'] and parameter[4][@type='android.os.UserHandle']]"
		[Register ("bindServiceAsUser", "(Landroid/content/Intent;Landroid/content/ServiceConnection;ILandroid/os/UserHandle;)Z", "GetBindServiceAsUser_Landroid_content_Intent_Landroid_content_ServiceConnection_ILandroid_os_UserHandle_Handler")]
		public virtual unsafe bool BindServiceAsUser (global::Android.Content.Intent service, global::Android.Content.IServiceConnection conn, int flags, global::Android.OS.UserHandle user)
		{
			const string __id = "bindServiceAsUser.(Landroid/content/Intent;Landroid/content/ServiceConnection;ILandroid/os/UserHandle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				__args [1] = new JniArgumentValue ((conn == null) ? IntPtr.Zero : ((global::Java.Lang.Object) conn).Handle);
				__args [2] = new JniArgumentValue (flags);
				__args [3] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canStartActivityForResult;
#pragma warning disable 0169
		static Delegate GetCanStartActivityForResultHandler ()
		{
			if (cb_canStartActivityForResult == null)
				cb_canStartActivityForResult = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanStartActivityForResult);
			return cb_canStartActivityForResult;
		}

		static bool n_CanStartActivityForResult (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanStartActivityForResult ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='canStartActivityForResult' and count(parameter)=0]"
		[Register ("canStartActivityForResult", "()Z", "GetCanStartActivityForResultHandler")]
		public virtual unsafe bool CanStartActivityForResult ()
		{
			const string __id = "canStartActivityForResult.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_checkCallingOrSelfPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckCallingOrSelfPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkCallingOrSelfPermission_Ljava_lang_String_ == null)
				cb_checkCallingOrSelfPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckCallingOrSelfPermission_Ljava_lang_String_);
			return cb_checkCallingOrSelfPermission_Ljava_lang_String_;
		}

		static int n_CheckCallingOrSelfPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingOrSelfPermission (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingOrSelfPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", "GetCheckCallingOrSelfPermission_Ljava_lang_String_Handler")]
		public abstract int CheckCallingOrSelfPermission (string p0);

		static Delegate cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetCheckCallingOrSelfUriPermission_Landroid_net_Uri_IHandler ()
		{
			if (cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I == null)
				cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_CheckCallingOrSelfUriPermission_Landroid_net_Uri_I);
			return cb_checkCallingOrSelfUriPermission_Landroid_net_Uri_I;
		}

		static int n_CheckCallingOrSelfUriPermission_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingOrSelfUriPermission (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingOrSelfUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingOrSelfUriPermission_Landroid_net_Uri_IHandler")]
		public abstract int CheckCallingOrSelfUriPermission (global::Android.Net.Uri p0, int p1);

		static Delegate cb_checkCallingPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckCallingPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkCallingPermission_Ljava_lang_String_ == null)
				cb_checkCallingPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckCallingPermission_Ljava_lang_String_);
			return cb_checkCallingPermission_Ljava_lang_String_;
		}

		static int n_CheckCallingPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingPermission (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkCallingPermission", "(Ljava/lang/String;)I", "GetCheckCallingPermission_Ljava_lang_String_Handler")]
		public abstract int CheckCallingPermission (string p0);

		static Delegate cb_checkCallingUriPermission_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetCheckCallingUriPermission_Landroid_net_Uri_IHandler ()
		{
			if (cb_checkCallingUriPermission_Landroid_net_Uri_I == null)
				cb_checkCallingUriPermission_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_CheckCallingUriPermission_Landroid_net_Uri_I);
			return cb_checkCallingUriPermission_Landroid_net_Uri_I;
		}

		static int n_CheckCallingUriPermission_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckCallingUriPermission (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("checkCallingUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingUriPermission_Landroid_net_Uri_IHandler")]
		public abstract int CheckCallingUriPermission (global::Android.Net.Uri p0, int p1);

		static Delegate cb_checkPermission_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetCheckPermission_Ljava_lang_String_IIHandler ()
		{
			if (cb_checkPermission_Ljava_lang_String_II == null)
				cb_checkPermission_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int>) n_CheckPermission_Ljava_lang_String_II);
			return cb_checkPermission_Ljava_lang_String_II;
		}

		static int n_CheckPermission_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckPermission (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkPermission' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPermission", "(Ljava/lang/String;II)I", "GetCheckPermission_Ljava_lang_String_IIHandler")]
		public abstract int CheckPermission (string p0, int p1, int p2);

		static Delegate cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetCheckPermission_Ljava_lang_String_IILandroid_os_IBinder_Handler ()
		{
			if (cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_ == null)
				cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, IntPtr, int>) n_CheckPermission_Ljava_lang_String_IILandroid_os_IBinder_);
			return cb_checkPermission_Ljava_lang_String_IILandroid_os_IBinder_;
		}

		static int n_CheckPermission_Ljava_lang_String_IILandroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p3 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p3, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckPermission (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkPermission' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.IBinder']]"
		[Register ("checkPermission", "(Ljava/lang/String;IILandroid/os/IBinder;)I", "GetCheckPermission_Ljava_lang_String_IILandroid_os_IBinder_Handler")]
		public abstract int CheckPermission (string p0, int p1, int p2, global::Android.OS.IBinder p3);

		static Delegate cb_checkSelfPermission_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetCheckSelfPermission_Ljava_lang_String_Handler ()
		{
			if (cb_checkSelfPermission_Ljava_lang_String_ == null)
				cb_checkSelfPermission_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_CheckSelfPermission_Ljava_lang_String_);
			return cb_checkSelfPermission_Ljava_lang_String_;
		}

		static int n_CheckSelfPermission_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckSelfPermission (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkSelfPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkSelfPermission", "(Ljava/lang/String;)I", "GetCheckSelfPermission_Ljava_lang_String_Handler")]
		public abstract int CheckSelfPermission (string p0);

		static Delegate cb_checkUriPermission_Landroid_net_Uri_III;
#pragma warning disable 0169
		static Delegate GetCheckUriPermission_Landroid_net_Uri_IIIHandler ()
		{
			if (cb_checkUriPermission_Landroid_net_Uri_III == null)
				cb_checkUriPermission_Landroid_net_Uri_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, int>) n_CheckUriPermission_Landroid_net_Uri_III);
			return cb_checkUriPermission_Landroid_net_Uri_III;
		}

		static int n_CheckUriPermission_Landroid_net_Uri_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckUriPermission (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkUriPermission' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;III)I", "GetCheckUriPermission_Landroid_net_Uri_IIIHandler")]
		public abstract int CheckUriPermission (global::Android.Net.Uri p0, int p1, int p2, int p3);

		static Delegate cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetCheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_Handler ()
		{
			if (cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_ == null)
				cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr, int>) n_CheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_);
			return cb_checkUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_;
		}

		static int n_CheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.IBinder p4 = (global::Android.OS.IBinder)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_p4, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckUriPermission (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkUriPermission' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.os.IBinder']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;IIILandroid/os/IBinder;)I", "GetCheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_Handler")]
		public abstract int CheckUriPermission (global::Android.Net.Uri p0, int p1, int p2, int p3, global::Android.OS.IBinder p4);

		static Delegate cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III;
#pragma warning disable 0169
		static Delegate GetCheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIIHandler ()
		{
			if (cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III == null)
				cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, int>) n_CheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III);
			return cb_checkUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III;
		}

		static int n_CheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.CheckUriPermission (p0, p1, p2, p3, p4, p5);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkUriPermission' and count(parameter)=6 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", "GetCheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public abstract int CheckUriPermission (global::Android.Net.Uri p0, string p1, string p2, int p3, int p4, int p5);

		static Delegate cb_clearWallpaper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetClearWallpaperHandler ()
		{
			if (cb_clearWallpaper == null)
				cb_clearWallpaper = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearWallpaper);
			return cb_clearWallpaper;
		}

		[Obsolete]
		static void n_ClearWallpaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearWallpaper ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='clearWallpaper' and count(parameter)=0]"
		[Register ("clearWallpaper", "()V", "GetClearWallpaperHandler")]
		public abstract void ClearWallpaper ();

		static Delegate cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I;
#pragma warning disable 0169
		static Delegate GetCreateApplicationContext_Landroid_content_pm_ApplicationInfo_IHandler ()
		{
			if (cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I == null)
				cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreateApplicationContext_Landroid_content_pm_ApplicationInfo_I);
			return cb_createApplicationContext_Landroid_content_pm_ApplicationInfo_I;
		}

		static IntPtr n_CreateApplicationContext_Landroid_content_pm_ApplicationInfo_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.PM.ApplicationInfo p0 = global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateApplicationContext (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createApplicationContext' and count(parameter)=2 and parameter[1][@type='android.content.pm.ApplicationInfo'] and parameter[2][@type='int']]"
		[Register ("createApplicationContext", "(Landroid/content/pm/ApplicationInfo;I)Landroid/content/Context;", "GetCreateApplicationContext_Landroid_content_pm_ApplicationInfo_IHandler")]
		public abstract global::Android.Content.Context CreateApplicationContext (global::Android.Content.PM.ApplicationInfo p0, int p1);

		static Delegate cb_createConfigurationContext_Landroid_content_res_Configuration_;
#pragma warning disable 0169
		static Delegate GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler ()
		{
			if (cb_createConfigurationContext_Landroid_content_res_Configuration_ == null)
				cb_createConfigurationContext_Landroid_content_res_Configuration_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateConfigurationContext_Landroid_content_res_Configuration_);
			return cb_createConfigurationContext_Landroid_content_res_Configuration_;
		}

		static IntPtr n_CreateConfigurationContext_Landroid_content_res_Configuration_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Res.Configuration p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Res.Configuration> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateConfigurationContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createConfigurationContext' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("createConfigurationContext", "(Landroid/content/res/Configuration;)Landroid/content/Context;", "GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler")]
		public abstract global::Android.Content.Context CreateConfigurationContext (global::Android.Content.Res.Configuration p0);

		static Delegate cb_createDisplayContext_Landroid_view_Display_;
#pragma warning disable 0169
		static Delegate GetCreateDisplayContext_Landroid_view_Display_Handler ()
		{
			if (cb_createDisplayContext_Landroid_view_Display_ == null)
				cb_createDisplayContext_Landroid_view_Display_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_CreateDisplayContext_Landroid_view_Display_);
			return cb_createDisplayContext_Landroid_view_Display_;
		}

		static IntPtr n_CreateDisplayContext_Landroid_view_Display_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.Display p0 = global::Java.Lang.Object.GetObject<global::Android.Views.Display> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreateDisplayContext (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createDisplayContext' and count(parameter)=1 and parameter[1][@type='android.view.Display']]"
		[Register ("createDisplayContext", "(Landroid/view/Display;)Landroid/content/Context;", "GetCreateDisplayContext_Landroid_view_Display_Handler")]
		public abstract global::Android.Content.Context CreateDisplayContext (global::Android.Views.Display p0);

		static Delegate cb_createPackageContext_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetCreatePackageContext_Ljava_lang_String_IHandler ()
		{
			if (cb_createPackageContext_Ljava_lang_String_I == null)
				cb_createPackageContext_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_CreatePackageContext_Ljava_lang_String_I);
			return cb_createPackageContext_Ljava_lang_String_I;
		}

		static IntPtr n_CreatePackageContext_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePackageContext (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createPackageContext' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", "GetCreatePackageContext_Ljava_lang_String_IHandler")]
		public abstract global::Android.Content.Context CreatePackageContext (string p0, int p1);

		static Delegate cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetCreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_Handler ()
		{
			if (cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_ == null)
				cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_CreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_);
			return cb_createPackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_;
		}

		static IntPtr n_CreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.CreatePackageContextAsUser (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createPackageContextAsUser' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("createPackageContextAsUser", "(Ljava/lang/String;ILandroid/os/UserHandle;)Landroid/content/Context;", "GetCreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_Handler")]
		public abstract global::Android.Content.Context CreatePackageContextAsUser (string p0, int p1, global::Android.OS.UserHandle p2);

		static Delegate cb_databaseList;
#pragma warning disable 0169
		static Delegate GetDatabaseListHandler ()
		{
			if (cb_databaseList == null)
				cb_databaseList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_DatabaseList);
			return cb_databaseList;
		}

		static IntPtr n_DatabaseList (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.DatabaseList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='databaseList' and count(parameter)=0]"
		[Register ("databaseList", "()[Ljava/lang/String;", "GetDatabaseListHandler")]
		public abstract string[] DatabaseList ();

		static Delegate cb_deleteDatabase_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteDatabase_Ljava_lang_String_Handler ()
		{
			if (cb_deleteDatabase_Ljava_lang_String_ == null)
				cb_deleteDatabase_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteDatabase_Ljava_lang_String_);
			return cb_deleteDatabase_Ljava_lang_String_;
		}

		static bool n_DeleteDatabase_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteDatabase (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='deleteDatabase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteDatabase", "(Ljava/lang/String;)Z", "GetDeleteDatabase_Ljava_lang_String_Handler")]
		public abstract bool DeleteDatabase (string p0);

		static Delegate cb_deleteFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDeleteFile_Ljava_lang_String_Handler ()
		{
			if (cb_deleteFile_Ljava_lang_String_ == null)
				cb_deleteFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_DeleteFile_Ljava_lang_String_);
			return cb_deleteFile_Ljava_lang_String_;
		}

		static bool n_DeleteFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DeleteFile (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "GetDeleteFile_Ljava_lang_String_Handler")]
		public abstract bool DeleteFile (string p0);

		static Delegate cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_);
			return cb_enforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingOrSelfPermission (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingOrSelfPermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void EnforceCallingOrSelfPermission (string p0, string p1);

		static Delegate cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler ()
		{
			if (cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ == null)
				cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_EnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_);
			return cb_enforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_;
		}

		static void n_EnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingOrSelfUriPermission (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingOrSelfUriPermission' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public abstract void EnforceCallingOrSelfUriPermission (global::Android.Net.Uri p0, int p1, string p2);

		static Delegate cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_EnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_);
			return cb_enforceCallingPermission_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_EnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingPermission (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingPermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public abstract void EnforceCallingPermission (string p0, string p1);

		static Delegate cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler ()
		{
			if (cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ == null)
				cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_EnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_);
			return cb_enforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_;
		}

		static void n_EnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.EnforceCallingUriPermission (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingUriPermission' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public abstract void EnforceCallingUriPermission (global::Android.Net.Uri p0, int p1, string p2);

		static Delegate cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforcePermission_Ljava_lang_String_IILjava_lang_String_Handler ()
		{
			if (cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_ == null)
				cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, IntPtr>) n_EnforcePermission_Ljava_lang_String_IILjava_lang_String_);
			return cb_enforcePermission_Ljava_lang_String_IILjava_lang_String_;
		}

		static void n_EnforcePermission_Ljava_lang_String_IILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, IntPtr native_p3)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.EnforcePermission (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforcePermission' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", "GetEnforcePermission_Ljava_lang_String_IILjava_lang_String_Handler")]
		public abstract void EnforcePermission (string p0, int p1, int p2, string p3);

		static Delegate cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_Handler ()
		{
			if (cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ == null)
				cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_EnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_);
			return cb_enforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_;
		}

		static void n_EnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, int p3, IntPtr native_p4)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			__this.EnforceUriPermission (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceUriPermission' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_Handler")]
		public abstract void EnforceUriPermission (global::Android.Net.Uri p0, int p1, int p2, int p3, string p4);

		static Delegate cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetEnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler ()
		{
			if (cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ == null)
				cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_EnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_);
			return cb_enforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_;
		}

		static void n_EnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4, int p5, IntPtr native_p6)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.EnforceUriPermission (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceUriPermission' and count(parameter)=7 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String']]"
		[Register ("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler")]
		public abstract void EnforceUriPermission (global::Android.Net.Uri p0, string p1, string p2, int p3, int p4, int p5, string p6);

		static Delegate cb_fileList;
#pragma warning disable 0169
		static Delegate GetFileListHandler ()
		{
			if (cb_fileList == null)
				cb_fileList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FileList);
			return cb_fileList;
		}

		static IntPtr n_FileList (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.FileList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='fileList' and count(parameter)=0]"
		[Register ("fileList", "()[Ljava/lang/String;", "GetFileListHandler")]
		public abstract string[] FileList ();

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColor", "(I)I", "")]
		public unsafe int GetColor (int id)
		{
			const string __id = "getColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getColorStateList' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColorStateList", "(I)Landroid/content/res/ColorStateList;", "")]
		public unsafe global::Android.Content.Res.ColorStateList GetColorStateList (int id)
		{
			const string __id = "getColorStateList.(I)Landroid/content/res/ColorStateList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.ColorStateList> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDatabasePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDatabasePath_Ljava_lang_String_Handler ()
		{
			if (cb_getDatabasePath_Ljava_lang_String_ == null)
				cb_getDatabasePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDatabasePath_Ljava_lang_String_);
			return cb_getDatabasePath_Ljava_lang_String_;
		}

		static IntPtr n_GetDatabasePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDatabasePath (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDatabasePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetDatabasePath_Ljava_lang_String_Handler")]
		public abstract global::Java.IO.File GetDatabasePath (string p0);

		static Delegate cb_getDir_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetDir_Ljava_lang_String_IHandler ()
		{
			if (cb_getDir_Ljava_lang_String_I == null)
				cb_getDir_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetDir_Ljava_lang_String_I);
			return cb_getDir_Ljava_lang_String_I;
		}

		static IntPtr n_GetDir_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDir (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDir' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getDir", "(Ljava/lang/String;I)Ljava/io/File;", "GetGetDir_Ljava_lang_String_IHandler")]
		public abstract global::Java.IO.File GetDir (string p0, int p1);

		static Delegate cb_getDisplayAdjustments_I;
#pragma warning disable 0169
		static Delegate GetGetDisplayAdjustments_IHandler ()
		{
			if (cb_getDisplayAdjustments_I == null)
				cb_getDisplayAdjustments_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDisplayAdjustments_I);
			return cb_getDisplayAdjustments_I;
		}

		static IntPtr n_GetDisplayAdjustments_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDisplayAdjustments (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDisplayAdjustments' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDisplayAdjustments", "(I)Landroid/view/DisplayAdjustments;", "GetGetDisplayAdjustments_IHandler")]
		public abstract global::Android.View.DisplayAdjustments GetDisplayAdjustments (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDrawable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDrawable", "(I)Landroid/graphics/drawable/Drawable;", "")]
		public unsafe global::Android.Graphics.Drawables.Drawable GetDrawable (int id)
		{
			const string __id = "getDrawable.(I)Landroid/graphics/drawable/Drawable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getExternalCacheDirs;
#pragma warning disable 0169
		static Delegate GetGetExternalCacheDirsHandler ()
		{
			if (cb_getExternalCacheDirs == null)
				cb_getExternalCacheDirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalCacheDirs);
			return cb_getExternalCacheDirs;
		}

		static IntPtr n_GetExternalCacheDirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExternalCacheDirs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalCacheDirs' and count(parameter)=0]"
		[Register ("getExternalCacheDirs", "()[Ljava/io/File;", "GetGetExternalCacheDirsHandler")]
		public abstract global::Java.IO.File[] GetExternalCacheDirs ();

		static Delegate cb_getExternalFilesDir_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExternalFilesDir_Ljava_lang_String_Handler ()
		{
			if (cb_getExternalFilesDir_Ljava_lang_String_ == null)
				cb_getExternalFilesDir_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExternalFilesDir_Ljava_lang_String_);
			return cb_getExternalFilesDir_Ljava_lang_String_;
		}

		static IntPtr n_GetExternalFilesDir_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetExternalFilesDir (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalFilesDir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", "GetGetExternalFilesDir_Ljava_lang_String_Handler")]
		public abstract global::Java.IO.File GetExternalFilesDir (string p0);

		static Delegate cb_getExternalFilesDirs_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetExternalFilesDirs_Ljava_lang_String_Handler ()
		{
			if (cb_getExternalFilesDirs_Ljava_lang_String_ == null)
				cb_getExternalFilesDirs_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetExternalFilesDirs_Ljava_lang_String_);
			return cb_getExternalFilesDirs_Ljava_lang_String_;
		}

		static IntPtr n_GetExternalFilesDirs_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetExternalFilesDirs (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalFilesDirs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExternalFilesDirs", "(Ljava/lang/String;)[Ljava/io/File;", "GetGetExternalFilesDirs_Ljava_lang_String_Handler")]
		public abstract global::Java.IO.File[] GetExternalFilesDirs (string p0);

		static Delegate cb_getExternalMediaDirs;
#pragma warning disable 0169
		static Delegate GetGetExternalMediaDirsHandler ()
		{
			if (cb_getExternalMediaDirs == null)
				cb_getExternalMediaDirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExternalMediaDirs);
			return cb_getExternalMediaDirs;
		}

		static IntPtr n_GetExternalMediaDirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExternalMediaDirs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalMediaDirs' and count(parameter)=0]"
		[Register ("getExternalMediaDirs", "()[Ljava/io/File;", "GetGetExternalMediaDirsHandler")]
		public abstract global::Java.IO.File[] GetExternalMediaDirs ();

		static Delegate cb_getFileStreamPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetFileStreamPath_Ljava_lang_String_Handler ()
		{
			if (cb_getFileStreamPath_Ljava_lang_String_ == null)
				cb_getFileStreamPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetFileStreamPath_Ljava_lang_String_);
			return cb_getFileStreamPath_Ljava_lang_String_;
		}

		static IntPtr n_GetFileStreamPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFileStreamPath (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getFileStreamPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetFileStreamPath_Ljava_lang_String_Handler")]
		public abstract global::Java.IO.File GetFileStreamPath (string p0);

		static Delegate cb_getObbDirs;
#pragma warning disable 0169
		static Delegate GetGetObbDirsHandler ()
		{
			if (cb_getObbDirs == null)
				cb_getObbDirs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetObbDirs);
			return cb_getObbDirs;
		}

		static IntPtr n_GetObbDirs (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetObbDirs ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getObbDirs' and count(parameter)=0]"
		[Register ("getObbDirs", "()[Ljava/io/File;", "GetGetObbDirsHandler")]
		public abstract global::Java.IO.File[] GetObbDirs ();

		static Delegate cb_getSharedPreferences_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetGetSharedPreferences_Ljava_lang_String_IHandler ()
		{
			if (cb_getSharedPreferences_Ljava_lang_String_I == null)
				cb_getSharedPreferences_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_GetSharedPreferences_Ljava_lang_String_I);
			return cb_getSharedPreferences_Ljava_lang_String_I;
		}

		static IntPtr n_GetSharedPreferences_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSharedPreferences (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSharedPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", "GetGetSharedPreferences_Ljava_lang_String_IHandler")]
		public abstract global::Android.Content.ISharedPreferences GetSharedPreferences (string p0, int p1);

		static Delegate cb_getSharedPrefsFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSharedPrefsFile_Ljava_lang_String_Handler ()
		{
			if (cb_getSharedPrefsFile_Ljava_lang_String_ == null)
				cb_getSharedPrefsFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSharedPrefsFile_Ljava_lang_String_);
			return cb_getSharedPrefsFile_Ljava_lang_String_;
		}

		static IntPtr n_GetSharedPrefsFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSharedPrefsFile (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSharedPrefsFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSharedPrefsFile", "(Ljava/lang/String;)Ljava/io/File;", "GetGetSharedPrefsFile_Ljava_lang_String_Handler")]
		public abstract global::Java.IO.File GetSharedPrefsFile (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getString", "(I)Ljava/lang/String;", "")]
		public unsafe string GetString (int resId)
		{
			const string __id = "getString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.Object...']]"
		[Register ("getString", "(I[Ljava/lang/Object;)Ljava/lang/String;", "")]
		public unsafe string GetString (int resId, params global::Java.Lang.Object[] formatArgs)
		{
			const string __id = "getString.(I[Ljava/lang/Object;)Ljava/lang/String;";
			IntPtr native_formatArgs = JNIEnv.NewArray (formatArgs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resId);
				__args [1] = new JniArgumentValue (native_formatArgs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (formatArgs != null) {
					JNIEnv.CopyArray (native_formatArgs, formatArgs);
					JNIEnv.DeleteLocalRef (native_formatArgs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSystemService' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("getSystemService", "(Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public unsafe global::Java.Lang.Object GetSystemService (global::Java.Lang.Class serviceClass)
		{
			const string __id = "getSystemService.(Ljava/lang/Class;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((serviceClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) serviceClass).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getSystemService_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetSystemService_Ljava_lang_String_Handler ()
		{
			if (cb_getSystemService_Ljava_lang_String_ == null)
				cb_getSystemService_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSystemService_Ljava_lang_String_);
			return cb_getSystemService_Ljava_lang_String_;
		}

		static IntPtr n_GetSystemService_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetSystemService (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSystemService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetSystemService_Ljava_lang_String_Handler")]
		public abstract global::Java.Lang.Object GetSystemService (string p0);

		static Delegate cb_getSystemServiceName_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetGetSystemServiceName_Ljava_lang_Class_Handler ()
		{
			if (cb_getSystemServiceName_Ljava_lang_Class_ == null)
				cb_getSystemServiceName_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetSystemServiceName_Ljava_lang_Class_);
			return cb_getSystemServiceName_Ljava_lang_Class_;
		}

		static IntPtr n_GetSystemServiceName_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetSystemServiceName (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSystemServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getSystemServiceName", "(Ljava/lang/Class;)Ljava/lang/String;", "GetGetSystemServiceName_Ljava_lang_Class_Handler")]
		public abstract string GetSystemServiceName (global::Java.Lang.Class p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getText' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getText", "(I)Ljava/lang/CharSequence;", "")]
		public unsafe global::Java.Lang.ICharSequence GetTextFormatted (int resId)
		{
			const string __id = "getText.(I)Ljava/lang/CharSequence;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (resId);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public string GetText (int resId)
		{
			global::Java.Lang.ICharSequence __result = GetTextFormatted (resId);
			var __rsval = __result?.ToString ();
			return __rsval;
		}

		static Delegate cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetGrantUriPermission_Ljava_lang_String_Landroid_net_Uri_IHandler ()
		{
			if (cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I == null)
				cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_GrantUriPermission_Ljava_lang_String_Landroid_net_Uri_I);
			return cb_grantUriPermission_Ljava_lang_String_Landroid_net_Uri_I;
		}

		static void n_GrantUriPermission_Ljava_lang_String_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p1 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.GrantUriPermission (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='grantUriPermission' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", "GetGrantUriPermission_Ljava_lang_String_Landroid_net_Uri_IHandler")]
		public abstract void GrantUriPermission (string p0, global::Android.Net.Uri p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='obtainStyledAttributes' and count(parameter)=2 and parameter[1][@type='android.util.AttributeSet'] and parameter[2][@type='int[]']]"
		[Register ("obtainStyledAttributes", "(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;", "")]
		public unsafe global::Android.Content.Res.TypedArray ObtainStyledAttributes (global::Android.Util.IAttributeSet set, int[] attrs)
		{
			const string __id = "obtainStyledAttributes.(Landroid/util/AttributeSet;[I)Landroid/content/res/TypedArray;";
			IntPtr native_attrs = JNIEnv.NewArray (attrs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				__args [1] = new JniArgumentValue (native_attrs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.TypedArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (attrs != null) {
					JNIEnv.CopyArray (native_attrs, attrs);
					JNIEnv.DeleteLocalRef (native_attrs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='obtainStyledAttributes' and count(parameter)=4 and parameter[1][@type='android.util.AttributeSet'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("obtainStyledAttributes", "(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;", "")]
		public unsafe global::Android.Content.Res.TypedArray ObtainStyledAttributes (global::Android.Util.IAttributeSet set, int[] attrs, int defStyleAttr, int defStyleRes)
		{
			const string __id = "obtainStyledAttributes.(Landroid/util/AttributeSet;[III)Landroid/content/res/TypedArray;";
			IntPtr native_attrs = JNIEnv.NewArray (attrs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				__args [1] = new JniArgumentValue (native_attrs);
				__args [2] = new JniArgumentValue (defStyleAttr);
				__args [3] = new JniArgumentValue (defStyleRes);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.TypedArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (attrs != null) {
					JNIEnv.CopyArray (native_attrs, attrs);
					JNIEnv.DeleteLocalRef (native_attrs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='obtainStyledAttributes' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int[]']]"
		[Register ("obtainStyledAttributes", "(I[I)Landroid/content/res/TypedArray;", "")]
		public unsafe global::Android.Content.Res.TypedArray ObtainStyledAttributes (int resid, int[] attrs)
		{
			const string __id = "obtainStyledAttributes.(I[I)Landroid/content/res/TypedArray;";
			IntPtr native_attrs = JNIEnv.NewArray (attrs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resid);
				__args [1] = new JniArgumentValue (native_attrs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.TypedArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (attrs != null) {
					JNIEnv.CopyArray (native_attrs, attrs);
					JNIEnv.DeleteLocalRef (native_attrs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='obtainStyledAttributes' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("obtainStyledAttributes", "([I)Landroid/content/res/TypedArray;", "")]
		public unsafe global::Android.Content.Res.TypedArray ObtainStyledAttributes (int[] attrs)
		{
			const string __id = "obtainStyledAttributes.([I)Landroid/content/res/TypedArray;";
			IntPtr native_attrs = JNIEnv.NewArray (attrs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_attrs);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Res.TypedArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (attrs != null) {
					JNIEnv.CopyArray (native_attrs, attrs);
					JNIEnv.DeleteLocalRef (native_attrs);
				}
			}
		}

		static Delegate cb_openFileInput_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetOpenFileInput_Ljava_lang_String_Handler ()
		{
			if (cb_openFileInput_Ljava_lang_String_ == null)
				cb_openFileInput_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OpenFileInput_Ljava_lang_String_);
			return cb_openFileInput_Ljava_lang_String_;
		}

		static IntPtr n_OpenFileInput_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.OpenFileInput (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openFileInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", "GetOpenFileInput_Ljava_lang_String_Handler")]
		public abstract global::System.IO.Stream OpenFileInput (string p0);

		static Delegate cb_openFileOutput_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetOpenFileOutput_Ljava_lang_String_IHandler ()
		{
			if (cb_openFileOutput_Ljava_lang_String_I == null)
				cb_openFileOutput_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr>) n_OpenFileOutput_Ljava_lang_String_I);
			return cb_openFileOutput_Ljava_lang_String_I;
		}

		static IntPtr n_OpenFileOutput_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OpenFileOutput (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openFileOutput' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", "GetOpenFileOutput_Ljava_lang_String_IHandler")]
		public abstract global::System.IO.Stream OpenFileOutput (string p0, int p1);

		static Delegate cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_;
#pragma warning disable 0169
		static Delegate GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Handler ()
		{
			if (cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ == null)
				cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_);
			return cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_;
		}

		static IntPtr n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2 = (global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory)global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenOrCreateDatabase (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openOrCreateDatabase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory']]"
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Handler")]
		public abstract global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string p0, int p1, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2);

		static Delegate cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_;
#pragma warning disable 0169
		static Delegate GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_Handler ()
		{
			if (cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ == null)
				cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_);
			return cb_openOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_;
		}

		static IntPtr n_OpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2 = (global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory)global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Database.IDatabaseErrorHandler p3 = (global::Android.Database.IDatabaseErrorHandler)global::Java.Lang.Object.GetObject<global::Android.Database.IDatabaseErrorHandler> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OpenOrCreateDatabase (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openOrCreateDatabase' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory'] and parameter[4][@type='android.database.DatabaseErrorHandler']]"
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_Handler")]
		public abstract global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string p0, int p1, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2, global::Android.Database.IDatabaseErrorHandler p3);

		static Delegate cb_peekWallpaper;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPeekWallpaperHandler ()
		{
			if (cb_peekWallpaper == null)
				cb_peekWallpaper = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_PeekWallpaper);
			return cb_peekWallpaper;
		}

		[Obsolete]
		static IntPtr n_PeekWallpaper (IntPtr jnienv, IntPtr native__this)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PeekWallpaper ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='peekWallpaper' and count(parameter)=0]"
		[Register ("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetPeekWallpaperHandler")]
		public abstract global::Android.Graphics.Drawables.Drawable PeekWallpaper ();

		static Delegate cb_registerComponentCallbacks_Landroid_content_ComponentCallbacks_;
#pragma warning disable 0169
		static Delegate GetRegisterComponentCallbacks_Landroid_content_ComponentCallbacks_Handler ()
		{
			if (cb_registerComponentCallbacks_Landroid_content_ComponentCallbacks_ == null)
				cb_registerComponentCallbacks_Landroid_content_ComponentCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RegisterComponentCallbacks_Landroid_content_ComponentCallbacks_);
			return cb_registerComponentCallbacks_Landroid_content_ComponentCallbacks_;
		}

		static void n_RegisterComponentCallbacks_Landroid_content_ComponentCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IComponentCallbacks @callback = (global::Android.Content.IComponentCallbacks)global::Java.Lang.Object.GetObject<global::Android.Content.IComponentCallbacks> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.RegisterComponentCallbacks (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerComponentCallbacks' and count(parameter)=1 and parameter[1][@type='android.content.ComponentCallbacks']]"
		[Register ("registerComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", "GetRegisterComponentCallbacks_Landroid_content_ComponentCallbacks_Handler")]
		public virtual unsafe void RegisterComponentCallbacks (global::Android.Content.IComponentCallbacks @callback)
		{
			const string __id = "registerComponentCallbacks.(Landroid/content/ComponentCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler ()
		{
			if (cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ == null)
				cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_);
			return cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_;
		}

		static IntPtr n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter p1 = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiver (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerReceiver' and count(parameter)=2 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler")]
		public abstract global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver p0, global::Android.Content.IntentFilter p1);

		static Delegate cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler ()
		{
			if (cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ == null)
				cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_);
			return cb_registerReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
		}

		static IntPtr n_RegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter p1 = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiver (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerReceiver' and count(parameter)=4 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Handler']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public abstract global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver p0, global::Android.Content.IntentFilter p1, string p2, global::Android.OS.Handler p3);

		static Delegate cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
#pragma warning disable 0169
		static Delegate GetRegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler ()
		{
			if (cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ == null)
				cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_);
			return cb_registerReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_;
		}

		static IntPtr n_RegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentFilter p2 = global::Java.Lang.Object.GetObject<global::Android.Content.IntentFilter> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p3 = JNIEnv.GetString (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RegisterReceiverAsUser (p0, p1, p2, p3, p4));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerReceiverAsUser' and count(parameter)=5 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='android.content.IntentFilter'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Handler']]"
		[Register ("registerReceiverAsUser", "(Landroid/content/BroadcastReceiver;Landroid/os/UserHandle;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public abstract global::Android.Content.Intent RegisterReceiverAsUser (global::Android.Content.BroadcastReceiver p0, global::Android.OS.UserHandle p1, global::Android.Content.IntentFilter p2, string p3, global::Android.OS.Handler p4);

		static Delegate cb_removeStickyBroadcast_Landroid_content_Intent_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetRemoveStickyBroadcast_Landroid_content_Intent_Handler ()
		{
			if (cb_removeStickyBroadcast_Landroid_content_Intent_ == null)
				cb_removeStickyBroadcast_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveStickyBroadcast_Landroid_content_Intent_);
			return cb_removeStickyBroadcast_Landroid_content_Intent_;
		}

		[Obsolete]
		static void n_RemoveStickyBroadcast_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStickyBroadcast (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='removeStickyBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("removeStickyBroadcast", "(Landroid/content/Intent;)V", "GetRemoveStickyBroadcast_Landroid_content_Intent_Handler")]
		public abstract void RemoveStickyBroadcast (global::Android.Content.Intent p0);

		static Delegate cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetRemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_removeStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		[Obsolete]
		static void n_RemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RemoveStickyBroadcastAsUser (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='removeStickyBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("removeStickyBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetRemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public abstract void RemoveStickyBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1);

		static Delegate cb_revokeUriPermission_Landroid_net_Uri_I;
#pragma warning disable 0169
		static Delegate GetRevokeUriPermission_Landroid_net_Uri_IHandler ()
		{
			if (cb_revokeUriPermission_Landroid_net_Uri_I == null)
				cb_revokeUriPermission_Landroid_net_Uri_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_RevokeUriPermission_Landroid_net_Uri_I);
			return cb_revokeUriPermission_Landroid_net_Uri_I;
		}

		static void n_RevokeUriPermission_Landroid_net_Uri_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Net.Uri p0 = global::Java.Lang.Object.GetObject<global::Android.Net.Uri> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RevokeUriPermission (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='revokeUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("revokeUriPermission", "(Landroid/net/Uri;I)V", "GetRevokeUriPermission_Landroid_net_Uri_IHandler")]
		public abstract void RevokeUriPermission (global::Android.Net.Uri p0, int p1);

		static Delegate cb_sendBroadcast_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Handler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_ == null)
				cb_sendBroadcast_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendBroadcast_Landroid_content_Intent_);
			return cb_sendBroadcast_Landroid_content_Intent_;
		}

		static void n_SendBroadcast_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;)V", "GetSendBroadcast_Landroid_content_Intent_Handler")]
		public abstract void SendBroadcast (global::Android.Content.Intent p0);

		static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_ == null)
				cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_);
			return cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_;
		}

		static void n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public abstract void SendBroadcast (global::Android.Content.Intent p0, string p1);

		static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendBroadcast (global::Android.Content.Intent p0, string p1, global::Android.OS.Bundle p2);

		static Delegate cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_IHandler ()
		{
			if (cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I == null)
				cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_I);
			return cb_sendBroadcast_Landroid_content_Intent_Ljava_lang_String_I;
		}

		static void n_SendBroadcast_Landroid_content_Intent_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcast (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;I)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_IHandler")]
		public abstract void SendBroadcast (global::Android.Content.Intent p0, string p1, int p2);

		static Delegate cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static void n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcastAsUser (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public abstract void SendBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1);

		static Delegate cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Handler ()
		{
			if (cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ == null)
				cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_);
			return cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_;
		}

		static void n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcastAsUser (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Handler")]
		public abstract void SendBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2);

		static Delegate cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_IHandler ()
		{
			if (cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I == null)
				cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int>) n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I);
			return cb_sendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I;
		}

		static void n_SendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.SendBroadcastAsUser (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastAsUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;I)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_IHandler")]
		public abstract void SendBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, int p3);

		static Delegate cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_Handler ()
		{
			if (cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_ == null)
				cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_);
			return cb_sendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_;
		}

		static void n_SendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string[] p1 = (string[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SendBroadcastMultiplePermissions (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastMultiplePermissions' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("sendBroadcastMultiplePermissions", "(Landroid/content/Intent;[Ljava/lang/String;)V", "GetSendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_Handler")]
		public abstract void SendBroadcastMultiplePermissions (global::Android.Content.Intent p0, string[] p1);

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public abstract void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1);

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p2 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p6 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=7 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.BroadcastReceiver'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1, global::Android.Content.BroadcastReceiver p2, global::Android.OS.Handler p3, int p4, string p5, global::Android.OS.Bundle p6);

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p3 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p4, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p7 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1, global::Android.OS.Bundle p2, global::Android.Content.BroadcastReceiver p3, global::Android.OS.Handler p4, int p5, string p6, global::Android.OS.Bundle p7);

		static Delegate cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, IntPtr native_p3, IntPtr native_p4, int p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p3 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p4, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p7 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcast (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1, int p2, global::Android.Content.BroadcastReceiver p3, global::Android.OS.Handler p4, int p5, string p6, global::Android.OS.Bundle p7);

		static Delegate cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, IntPtr native_p4, int p5, IntPtr native_p6, IntPtr native_p7)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p3 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p3, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p4, JniHandleOwnership.DoNotTransfer);
			string p6 = JNIEnv.GetString (native_p6, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p7 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p7, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcastAsUser (p0, p1, p2, p3, p4, p5, p6, p7);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, global::Android.Content.BroadcastReceiver p3, global::Android.OS.Handler p4, int p5, string p6, global::Android.OS.Bundle p7);

		static Delegate cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5, int p6, IntPtr native_p7, IntPtr native_p8)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p4 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p5 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p5, JniHandleOwnership.DoNotTransfer);
			string p7 = JNIEnv.GetString (native_p7, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p8 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p8, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcastAsUser (p0, p1, p2, p3, p4, p5, p6, p7, p8);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=9 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='android.content.BroadcastReceiver'] and parameter[6][@type='android.os.Handler'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, int p3, global::Android.Content.BroadcastReceiver p4, global::Android.OS.Handler p5, int p6, string p7, global::Android.OS.Bundle p8);

		static Delegate cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		static void n_SendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5, IntPtr native_p6, int p7, IntPtr native_p8, IntPtr native_p9)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			string p2 = JNIEnv.GetString (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p4 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p5 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p6 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p6, JniHandleOwnership.DoNotTransfer);
			string p8 = JNIEnv.GetString (native_p8, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p9 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p9, JniHandleOwnership.DoNotTransfer);
			__this.SendOrderedBroadcastAsUser (p0, p1, p2, p3, p4, p5, p6, p7, p8, p9);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=10 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='android.os.Bundle'] and parameter[6][@type='android.content.BroadcastReceiver'] and parameter[7][@type='android.os.Handler'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, int p3, global::Android.OS.Bundle p4, global::Android.Content.BroadcastReceiver p5, global::Android.OS.Handler p6, int p7, string p8, global::Android.OS.Bundle p9);

		static Delegate cb_sendStickyBroadcast_Landroid_content_Intent_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyBroadcast_Landroid_content_Intent_Handler ()
		{
			if (cb_sendStickyBroadcast_Landroid_content_Intent_ == null)
				cb_sendStickyBroadcast_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendStickyBroadcast_Landroid_content_Intent_);
			return cb_sendStickyBroadcast_Landroid_content_Intent_;
		}

		[Obsolete]
		static void n_SendStickyBroadcast_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyBroadcast (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendStickyBroadcast", "(Landroid/content/Intent;)V", "GetSendStickyBroadcast_Landroid_content_Intent_Handler")]
		public abstract void SendStickyBroadcast (global::Android.Content.Intent p0);

		static Delegate cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_sendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		[Obsolete]
		static void n_SendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyBroadcastAsUser (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("sendStickyBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetSendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public abstract void SendStickyBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1);

		static Delegate cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		[Obsolete]
		static void n_SendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, int p3, IntPtr native_p4, IntPtr native_p5)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p1 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p2, JniHandleOwnership.DoNotTransfer);
			string p4 = JNIEnv.GetString (native_p4, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p5 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyOrderedBroadcast (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyOrderedBroadcast' and count(parameter)=6 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.BroadcastReceiver'] and parameter[3][@type='android.os.Handler'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendStickyOrderedBroadcast (global::Android.Content.Intent p0, global::Android.Content.BroadcastReceiver p1, global::Android.OS.Handler p2, int p3, string p4, global::Android.OS.Bundle p5);

		static Delegate cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ == null)
				cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr, IntPtr>) n_SendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_);
			return cb_sendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_;
		}

		[Obsolete]
		static void n_SendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, IntPtr native_p3, int p4, IntPtr native_p5, IntPtr native_p6)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p2 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Handler p3 = global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (native_p3, JniHandleOwnership.DoNotTransfer);
			string p5 = JNIEnv.GetString (native_p5, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p6 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p6, JniHandleOwnership.DoNotTransfer);
			__this.SendStickyOrderedBroadcastAsUser (p0, p1, p2, p3, p4, p5, p6);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyOrderedBroadcastAsUser' and count(parameter)=7 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='android.content.BroadcastReceiver'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Register ("sendStickyOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract void SendStickyOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, global::Android.Content.BroadcastReceiver p2, global::Android.OS.Handler p3, int p4, string p5, global::Android.OS.Bundle p6);

		static Delegate cb_setTheme_I;
#pragma warning disable 0169
		static Delegate GetSetTheme_IHandler ()
		{
			if (cb_setTheme_I == null)
				cb_setTheme_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTheme_I);
			return cb_setTheme_I;
		}

		static void n_SetTheme_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTheme (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTheme", "(I)V", "GetSetTheme_IHandler")]
		public abstract void SetTheme (int p0);

		static Delegate cb_setWallpaper_Landroid_graphics_Bitmap_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetWallpaper_Landroid_graphics_Bitmap_Handler ()
		{
			if (cb_setWallpaper_Landroid_graphics_Bitmap_ == null)
				cb_setWallpaper_Landroid_graphics_Bitmap_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWallpaper_Landroid_graphics_Bitmap_);
			return cb_setWallpaper_Landroid_graphics_Bitmap_;
		}

		[Obsolete]
		static void n_SetWallpaper_Landroid_graphics_Bitmap_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWallpaper (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='setWallpaper' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Register ("setWallpaper", "(Landroid/graphics/Bitmap;)V", "GetSetWallpaper_Landroid_graphics_Bitmap_Handler")]
		public abstract void SetWallpaper (global::Android.Graphics.Bitmap p0);

		static Delegate cb_setWallpaper_Ljava_io_InputStream_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetWallpaper_Ljava_io_InputStream_Handler ()
		{
			if (cb_setWallpaper_Ljava_io_InputStream_ == null)
				cb_setWallpaper_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetWallpaper_Ljava_io_InputStream_);
			return cb_setWallpaper_Ljava_io_InputStream_;
		}

		[Obsolete]
		static void n_SetWallpaper_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetWallpaper (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='setWallpaper' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setWallpaper", "(Ljava/io/InputStream;)V", "GetSetWallpaper_Ljava_io_InputStream_Handler")]
		public abstract void SetWallpaper (global::System.IO.Stream p0);

		static Delegate cb_startActivities_arrayLandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivities_arrayLandroid_content_Intent_Handler ()
		{
			if (cb_startActivities_arrayLandroid_content_Intent_ == null)
				cb_startActivities_arrayLandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivities_arrayLandroid_content_Intent_);
			return cb_startActivities_arrayLandroid_content_Intent_;
		}

		static void n_StartActivities_arrayLandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent[] p0 = (global::Android.Content.Intent[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Content.Intent));
			__this.StartActivities (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivities' and count(parameter)=1 and parameter[1][@type='android.content.Intent[]']]"
		[Register ("startActivities", "([Landroid/content/Intent;)V", "GetStartActivities_arrayLandroid_content_Intent_Handler")]
		public abstract void StartActivities (global::Android.Content.Intent[] p0);

		static Delegate cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_Handler ()
		{
			if (cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_ == null)
				cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_);
			return cb_startActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_;
		}

		static void n_StartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent[] p0 = (global::Android.Content.Intent[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Content.Intent));
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartActivities (p0, p1);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivities' and count(parameter)=2 and parameter[1][@type='android.content.Intent[]'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("startActivities", "([Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_Handler")]
		public abstract void StartActivities (global::Android.Content.Intent[] p0, global::Android.OS.Bundle p1);

		static Delegate cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ == null)
				cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_);
			return cb_startActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
		}

		static void n_StartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intents, IntPtr native_options, IntPtr native_userHandle)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent[] intents = (global::Android.Content.Intent[]) JNIEnv.GetArray (native_intents, JniHandleOwnership.DoNotTransfer, typeof (global::Android.Content.Intent));
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle userHandle = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_userHandle, JniHandleOwnership.DoNotTransfer);
			__this.StartActivitiesAsUser (intents, options, userHandle);
			if (intents != null)
				JNIEnv.CopyArray (intents, native_intents);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivitiesAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent[]'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("startActivitiesAsUser", "([Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V", "GetStartActivitiesAsUser_arrayLandroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler")]
		public virtual unsafe void StartActivitiesAsUser (global::Android.Content.Intent[] intents, global::Android.OS.Bundle options, global::Android.OS.UserHandle userHandle)
		{
			const string __id = "startActivitiesAsUser.([Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V";
			IntPtr native_intents = JNIEnv.NewArray (intents);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_intents);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((userHandle == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userHandle).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (intents != null) {
					JNIEnv.CopyArray (native_intents, intents);
					JNIEnv.DeleteLocalRef (native_intents);
				}
			}
		}

		static Delegate cb_startActivity_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Landroid_content_Intent_Handler ()
		{
			if (cb_startActivity_Landroid_content_Intent_ == null)
				cb_startActivity_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartActivity_Landroid_content_Intent_);
			return cb_startActivity_Landroid_content_Intent_;
		}

		static void n_StartActivity_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivity' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public abstract void StartActivity (global::Android.Content.Intent p0);

		static Delegate cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler ()
		{
			if (cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ == null)
				cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_);
			return cb_startActivity_Landroid_content_Intent_Landroid_os_Bundle_;
		}

		static void n_StartActivity_Landroid_content_Intent_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartActivity (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivity' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler")]
		public abstract void StartActivity (global::Android.Content.Intent p0, global::Android.OS.Bundle p1);

		static Delegate cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ == null)
				cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_);
			return cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_;
		}

		static void n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_options, IntPtr native_userId)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle userId = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_userId, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityAsUser (intent, options, userId);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivityAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.Bundle'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("startActivityAsUser", "(Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V", "GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_Bundle_Landroid_os_UserHandle_Handler")]
		public virtual unsafe void StartActivityAsUser (global::Android.Content.Intent intent, global::Android.OS.Bundle options, global::Android.OS.UserHandle userId)
		{
			const string __id = "startActivityAsUser.(Landroid/content/Intent;Landroid/os/Bundle;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				__args [2] = new JniArgumentValue ((userId == null) ? IntPtr.Zero : ((global::Java.Lang.Object) userId).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_startActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static void n_StartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_intent, IntPtr native_user)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle user = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_user, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityAsUser (intent, user);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivityAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("startActivityAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetStartActivityAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public virtual unsafe void StartActivityAsUser (global::Android.Content.Intent intent, global::Android.OS.UserHandle user)
		{
			const string __id = "startActivityAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [1] = new JniArgumentValue ((user == null) ? IntPtr.Zero : ((global::Java.Lang.Object) user).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_Handler ()
		{
			if (cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_ == null)
				cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, IntPtr>) n_StartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_);
			return cb_startActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_;
		}

		static void n_StartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_who, IntPtr native_intent, int requestCode, IntPtr native_options)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string who = JNIEnv.GetString (native_who, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent intent = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_intent, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle options = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_options, JniHandleOwnership.DoNotTransfer);
			__this.StartActivityForResult (who, intent, requestCode, options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivityForResult' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='android.os.Bundle']]"
		[Register ("startActivityForResult", "(Ljava/lang/String;Landroid/content/Intent;ILandroid/os/Bundle;)V", "GetStartActivityForResult_Ljava_lang_String_Landroid_content_Intent_ILandroid_os_Bundle_Handler")]
		public virtual unsafe void StartActivityForResult (string who, global::Android.Content.Intent intent, int requestCode, global::Android.OS.Bundle options)
		{
			const string __id = "startActivityForResult.(Ljava/lang/String;Landroid/content/Intent;ILandroid/os/Bundle;)V";
			IntPtr native_who = JNIEnv.NewString (who);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_who);
				__args [1] = new JniArgumentValue ((intent == null) ? IntPtr.Zero : ((global::Java.Lang.Object) intent).Handle);
				__args [2] = new JniArgumentValue (requestCode);
				__args [3] = new JniArgumentValue ((options == null) ? IntPtr.Zero : ((global::Java.Lang.Object) options).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_who);
			}
		}

		static Delegate cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_Handler ()
		{
			if (cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ == null)
				cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_);
			return cb_startInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_;
		}

		static bool n_StartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.ComponentName p0 = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p2 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p2, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StartInstrumentation (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startInstrumentation' and count(parameter)=3 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", "GetStartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public abstract bool StartInstrumentation (global::Android.Content.ComponentName p0, string p1, global::Android.OS.Bundle p2);

		static Delegate cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III;
#pragma warning disable 0169
		static Delegate GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIIHandler ()
		{
			if (cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III == null)
				cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int>) n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III);
			return cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III;
		}

		static void n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_III (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentSender p0 = global::Java.Lang.Object.GetObject<global::Android.Content.IntentSender> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.StartIntentSender (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startIntentSender' and count(parameter)=5 and parameter[1][@type='android.content.IntentSender'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIIHandler")]
		public abstract void StartIntentSender (global::Android.Content.IntentSender p0, global::Android.Content.Intent p1, int p2, int p3, int p4);

		static Delegate cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_Handler ()
		{
			if (cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_ == null)
				cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int, int, IntPtr>) n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_);
			return cb_startIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_;
		}

		static void n_StartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3, int p4, IntPtr native_p5)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IntentSender p0 = global::Java.Lang.Object.GetObject<global::Android.Content.IntentSender> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p1 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p5 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.StartIntentSender (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startIntentSender' and count(parameter)=6 and parameter[1][@type='android.content.IntentSender'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;IIILandroid/os/Bundle;)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_Handler")]
		public abstract void StartIntentSender (global::Android.Content.IntentSender p0, global::Android.Content.Intent p1, int p2, int p3, int p4, global::Android.OS.Bundle p5);

		static Delegate cb_startService_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStartService_Landroid_content_Intent_Handler ()
		{
			if (cb_startService_Landroid_content_Intent_ == null)
				cb_startService_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_StartService_Landroid_content_Intent_);
			return cb_startService_Landroid_content_Intent_;
		}

		static IntPtr n_StartService_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartService (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startService' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", "GetStartService_Landroid_content_Intent_Handler")]
		public abstract global::Android.Content.ComponentName StartService (global::Android.Content.Intent p0);

		static Delegate cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_StartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_startServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static IntPtr n_StartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.StartServiceAsUser (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startServiceAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("startServiceAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)Landroid/content/ComponentName;", "GetStartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public abstract global::Android.Content.ComponentName StartServiceAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1);

		static Delegate cb_stopService_Landroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetStopService_Landroid_content_Intent_Handler ()
		{
			if (cb_stopService_Landroid_content_Intent_ == null)
				cb_stopService_Landroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_StopService_Landroid_content_Intent_);
			return cb_stopService_Landroid_content_Intent_;
		}

		static bool n_StopService_Landroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StopService (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='stopService' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("stopService", "(Landroid/content/Intent;)Z", "GetStopService_Landroid_content_Intent_Handler")]
		public abstract bool StopService (global::Android.Content.Intent p0);

		static Delegate cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
#pragma warning disable 0169
		static Delegate GetStopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler ()
		{
			if (cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ == null)
				cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_StopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_);
			return cb_stopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_;
		}

		static bool n_StopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.UserHandle p1 = global::Java.Lang.Object.GetObject<global::Android.OS.UserHandle> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.StopServiceAsUser (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='stopServiceAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("stopServiceAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)Z", "GetStopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public abstract bool StopServiceAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1);

		static Delegate cb_unbindService_Landroid_content_ServiceConnection_;
#pragma warning disable 0169
		static Delegate GetUnbindService_Landroid_content_ServiceConnection_Handler ()
		{
			if (cb_unbindService_Landroid_content_ServiceConnection_ == null)
				cb_unbindService_Landroid_content_ServiceConnection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnbindService_Landroid_content_ServiceConnection_);
			return cb_unbindService_Landroid_content_ServiceConnection_;
		}

		static void n_UnbindService_Landroid_content_ServiceConnection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IServiceConnection p0 = (global::Android.Content.IServiceConnection)global::Java.Lang.Object.GetObject<global::Android.Content.IServiceConnection> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnbindService (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='unbindService' and count(parameter)=1 and parameter[1][@type='android.content.ServiceConnection']]"
		[Register ("unbindService", "(Landroid/content/ServiceConnection;)V", "GetUnbindService_Landroid_content_ServiceConnection_Handler")]
		public abstract void UnbindService (global::Android.Content.IServiceConnection p0);

		static Delegate cb_unregisterComponentCallbacks_Landroid_content_ComponentCallbacks_;
#pragma warning disable 0169
		static Delegate GetUnregisterComponentCallbacks_Landroid_content_ComponentCallbacks_Handler ()
		{
			if (cb_unregisterComponentCallbacks_Landroid_content_ComponentCallbacks_ == null)
				cb_unregisterComponentCallbacks_Landroid_content_ComponentCallbacks_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterComponentCallbacks_Landroid_content_ComponentCallbacks_);
			return cb_unregisterComponentCallbacks_Landroid_content_ComponentCallbacks_;
		}

		static void n_UnregisterComponentCallbacks_Landroid_content_ComponentCallbacks_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.IComponentCallbacks @callback = (global::Android.Content.IComponentCallbacks)global::Java.Lang.Object.GetObject<global::Android.Content.IComponentCallbacks> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterComponentCallbacks (@callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='unregisterComponentCallbacks' and count(parameter)=1 and parameter[1][@type='android.content.ComponentCallbacks']]"
		[Register ("unregisterComponentCallbacks", "(Landroid/content/ComponentCallbacks;)V", "GetUnregisterComponentCallbacks_Landroid_content_ComponentCallbacks_Handler")]
		public virtual unsafe void UnregisterComponentCallbacks (global::Android.Content.IComponentCallbacks @callback)
		{
			const string __id = "unregisterComponentCallbacks.(Landroid/content/ComponentCallbacks;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_unregisterReceiver_Landroid_content_BroadcastReceiver_;
#pragma warning disable 0169
		static Delegate GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler ()
		{
			if (cb_unregisterReceiver_Landroid_content_BroadcastReceiver_ == null)
				cb_unregisterReceiver_Landroid_content_BroadcastReceiver_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UnregisterReceiver_Landroid_content_BroadcastReceiver_);
			return cb_unregisterReceiver_Landroid_content_BroadcastReceiver_;
		}

		static void n_UnregisterReceiver_Landroid_content_BroadcastReceiver_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Android.Content.Context __this = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.BroadcastReceiver p0 = global::Java.Lang.Object.GetObject<global::Android.Content.BroadcastReceiver> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UnregisterReceiver (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='unregisterReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public abstract void UnregisterReceiver (global::Android.Content.BroadcastReceiver p0);

	}

	[global::Android.Runtime.Register ("android/content/Context", DoNotGenerateAcw=true)]
	internal partial class ContextInvoker : Context {

		public ContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("android/content/Context", typeof (ContextInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe global::Android.Content.Context ApplicationContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getApplicationContext' and count(parameter)=0]"
			[Register ("getApplicationContext", "()Landroid/content/Context;", "GetGetApplicationContextHandler")]
			get {
				const string __id = "getApplicationContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.PM.ApplicationInfo ApplicationInfo {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getApplicationInfo' and count(parameter)=0]"
			[Register ("getApplicationInfo", "()Landroid/content/pm/ApplicationInfo;", "GetGetApplicationInfoHandler")]
			get {
				const string __id = "getApplicationInfo.()Landroid/content/pm/ApplicationInfo;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.ApplicationInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.Res.AssetManager Assets {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getAssets' and count(parameter)=0]"
			[Register ("getAssets", "()Landroid/content/res/AssetManager;", "GetGetAssetsHandler")]
			get {
				const string __id = "getAssets.()Landroid/content/res/AssetManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.AssetManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string BasePackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getBasePackageName' and count(parameter)=0]"
			[Register ("getBasePackageName", "()Ljava/lang/String;", "GetGetBasePackageNameHandler")]
			get {
				const string __id = "getBasePackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.IO.File CacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getCacheDir' and count(parameter)=0]"
			[Register ("getCacheDir", "()Ljava/io/File;", "GetGetCacheDirHandler")]
			get {
				const string __id = "getCacheDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.Lang.ClassLoader ClassLoader {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getClassLoader' and count(parameter)=0]"
			[Register ("getClassLoader", "()Ljava/lang/ClassLoader;", "GetGetClassLoaderHandler")]
			get {
				const string __id = "getClassLoader.()Ljava/lang/ClassLoader;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.ClassLoader> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.IO.File CodeCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getCodeCacheDir' and count(parameter)=0]"
			[Register ("getCodeCacheDir", "()Ljava/io/File;", "GetGetCodeCacheDirHandler")]
			get {
				const string __id = "getCodeCacheDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.ContentResolver ContentResolver {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getContentResolver' and count(parameter)=0]"
			[Register ("getContentResolver", "()Landroid/content/ContentResolver;", "GetGetContentResolverHandler")]
			get {
				const string __id = "getContentResolver.()Landroid/content/ContentResolver;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.ContentResolver> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.IO.File ExternalCacheDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalCacheDir' and count(parameter)=0]"
			[Register ("getExternalCacheDir", "()Ljava/io/File;", "GetGetExternalCacheDirHandler")]
			get {
				const string __id = "getExternalCacheDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.IO.File FilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getFilesDir' and count(parameter)=0]"
			[Register ("getFilesDir", "()Ljava/io/File;", "GetGetFilesDirHandler")]
			get {
				const string __id = "getFilesDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.OS.Looper MainLooper {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getMainLooper' and count(parameter)=0]"
			[Register ("getMainLooper", "()Landroid/os/Looper;", "GetGetMainLooperHandler")]
			get {
				const string __id = "getMainLooper.()Landroid/os/Looper;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Looper> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.IO.File NoBackupFilesDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getNoBackupFilesDir' and count(parameter)=0]"
			[Register ("getNoBackupFilesDir", "()Ljava/io/File;", "GetGetNoBackupFilesDirHandler")]
			get {
				const string __id = "getNoBackupFilesDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Java.IO.File ObbDir {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getObbDir' and count(parameter)=0]"
			[Register ("getObbDir", "()Ljava/io/File;", "GetGetObbDirHandler")]
			get {
				const string __id = "getObbDir.()Ljava/io/File;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string OpPackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getOpPackageName' and count(parameter)=0]"
			[Register ("getOpPackageName", "()Ljava/lang/String;", "GetGetOpPackageNameHandler")]
			get {
				const string __id = "getOpPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string PackageCodePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageCodePath' and count(parameter)=0]"
			[Register ("getPackageCodePath", "()Ljava/lang/String;", "GetGetPackageCodePathHandler")]
			get {
				const string __id = "getPackageCodePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.PM.PackageManager PackageManager {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageManager' and count(parameter)=0]"
			[Register ("getPackageManager", "()Landroid/content/pm/PackageManager;", "GetGetPackageManagerHandler")]
			get {
				const string __id = "getPackageManager.()Landroid/content/pm/PackageManager;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.PM.PackageManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string PackageName {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageName' and count(parameter)=0]"
			[Register ("getPackageName", "()Ljava/lang/String;", "GetGetPackageNameHandler")]
			get {
				const string __id = "getPackageName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string PackageResourcePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getPackageResourcePath' and count(parameter)=0]"
			[Register ("getPackageResourcePath", "()Ljava/lang/String;", "GetGetPackageResourcePathHandler")]
			get {
				const string __id = "getPackageResourcePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.Res.Resources Resources {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getResources' and count(parameter)=0]"
			[Register ("getResources", "()Landroid/content/res/Resources;", "GetGetResourcesHandler")]
			get {
				const string __id = "getResources.()Landroid/content/res/Resources;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Content.Res.Resources.Theme Theme {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getTheme' and count(parameter)=0]"
			[Register ("getTheme", "()Landroid/content/res/Resources$Theme;", "GetGetThemeHandler")]
			get {
				const string __id = "getTheme.()Landroid/content/res/Resources$Theme;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Res.Resources.Theme> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int UserId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getUserId' and count(parameter)=0]"
			[Register ("getUserId", "()I", "GetGetUserIdHandler")]
			get {
				const string __id = "getUserId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public override unsafe global::Android.Graphics.Drawables.Drawable Wallpaper {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getWallpaper' and count(parameter)=0]"
			[Register ("getWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetGetWallpaperHandler")]
			get {
				const string __id = "getWallpaper.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public override unsafe int WallpaperDesiredMinimumHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getWallpaperDesiredMinimumHeight' and count(parameter)=0]"
			[Register ("getWallpaperDesiredMinimumHeight", "()I", "GetGetWallpaperDesiredMinimumHeightHandler")]
			get {
				const string __id = "getWallpaperDesiredMinimumHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		[Obsolete (@"deprecated")]
		public override unsafe int WallpaperDesiredMinimumWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getWallpaperDesiredMinimumWidth' and count(parameter)=0]"
			[Register ("getWallpaperDesiredMinimumWidth", "()I", "GetGetWallpaperDesiredMinimumWidthHandler")]
			get {
				const string __id = "getWallpaperDesiredMinimumWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='bindService' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.ServiceConnection'] and parameter[3][@type='int']]"
		[Register ("bindService", "(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z", "GetBindService_Landroid_content_Intent_Landroid_content_ServiceConnection_IHandler")]
		public override unsafe bool BindService (global::Android.Content.Intent p0, global::Android.Content.IServiceConnection p1, int p2)
		{
			const string __id = "bindService.(Landroid/content/Intent;Landroid/content/ServiceConnection;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingOrSelfPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkCallingOrSelfPermission", "(Ljava/lang/String;)I", "GetCheckCallingOrSelfPermission_Ljava_lang_String_Handler")]
		public override unsafe int CheckCallingOrSelfPermission (string p0)
		{
			const string __id = "checkCallingOrSelfPermission.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingOrSelfUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("checkCallingOrSelfUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingOrSelfUriPermission_Landroid_net_Uri_IHandler")]
		public override unsafe int CheckCallingOrSelfUriPermission (global::Android.Net.Uri p0, int p1)
		{
			const string __id = "checkCallingOrSelfUriPermission.(Landroid/net/Uri;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkCallingPermission", "(Ljava/lang/String;)I", "GetCheckCallingPermission_Ljava_lang_String_Handler")]
		public override unsafe int CheckCallingPermission (string p0)
		{
			const string __id = "checkCallingPermission.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkCallingUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("checkCallingUriPermission", "(Landroid/net/Uri;I)I", "GetCheckCallingUriPermission_Landroid_net_Uri_IHandler")]
		public override unsafe int CheckCallingUriPermission (global::Android.Net.Uri p0, int p1)
		{
			const string __id = "checkCallingUriPermission.(Landroid/net/Uri;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkPermission' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("checkPermission", "(Ljava/lang/String;II)I", "GetCheckPermission_Ljava_lang_String_IIHandler")]
		public override unsafe int CheckPermission (string p0, int p1, int p2)
		{
			const string __id = "checkPermission.(Ljava/lang/String;II)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkPermission' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='android.os.IBinder']]"
		[Register ("checkPermission", "(Ljava/lang/String;IILandroid/os/IBinder;)I", "GetCheckPermission_Ljava_lang_String_IILandroid_os_IBinder_Handler")]
		public override unsafe int CheckPermission (string p0, int p1, int p2, global::Android.OS.IBinder p3)
		{
			const string __id = "checkPermission.(Ljava/lang/String;IILandroid/os/IBinder;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkSelfPermission' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("checkSelfPermission", "(Ljava/lang/String;)I", "GetCheckSelfPermission_Ljava_lang_String_Handler")]
		public override unsafe int CheckSelfPermission (string p0)
		{
			const string __id = "checkSelfPermission.(Ljava/lang/String;)I";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkUriPermission' and count(parameter)=4 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;III)I", "GetCheckUriPermission_Landroid_net_Uri_IIIHandler")]
		public override unsafe int CheckUriPermission (global::Android.Net.Uri p0, int p1, int p2, int p3)
		{
			const string __id = "checkUriPermission.(Landroid/net/Uri;III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkUriPermission' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='android.os.IBinder']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;IIILandroid/os/IBinder;)I", "GetCheckUriPermission_Landroid_net_Uri_IIILandroid_os_IBinder_Handler")]
		public override unsafe int CheckUriPermission (global::Android.Net.Uri p0, int p1, int p2, int p3, global::Android.OS.IBinder p4)
		{
			const string __id = "checkUriPermission.(Landroid/net/Uri;IIILandroid/os/IBinder;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='checkUriPermission' and count(parameter)=6 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("checkUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I", "GetCheckUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIIHandler")]
		public override unsafe int CheckUriPermission (global::Android.Net.Uri p0, string p1, string p2, int p3, int p4, int p5)
		{
			const string __id = "checkUriPermission.(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;III)I";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='clearWallpaper' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("clearWallpaper", "()V", "GetClearWallpaperHandler")]
		public override unsafe void ClearWallpaper ()
		{
			const string __id = "clearWallpaper.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createApplicationContext' and count(parameter)=2 and parameter[1][@type='android.content.pm.ApplicationInfo'] and parameter[2][@type='int']]"
		[Register ("createApplicationContext", "(Landroid/content/pm/ApplicationInfo;I)Landroid/content/Context;", "GetCreateApplicationContext_Landroid_content_pm_ApplicationInfo_IHandler")]
		public override unsafe global::Android.Content.Context CreateApplicationContext (global::Android.Content.PM.ApplicationInfo p0, int p1)
		{
			const string __id = "createApplicationContext.(Landroid/content/pm/ApplicationInfo;I)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createConfigurationContext' and count(parameter)=1 and parameter[1][@type='android.content.res.Configuration']]"
		[Register ("createConfigurationContext", "(Landroid/content/res/Configuration;)Landroid/content/Context;", "GetCreateConfigurationContext_Landroid_content_res_Configuration_Handler")]
		public override unsafe global::Android.Content.Context CreateConfigurationContext (global::Android.Content.Res.Configuration p0)
		{
			const string __id = "createConfigurationContext.(Landroid/content/res/Configuration;)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createDisplayContext' and count(parameter)=1 and parameter[1][@type='android.view.Display']]"
		[Register ("createDisplayContext", "(Landroid/view/Display;)Landroid/content/Context;", "GetCreateDisplayContext_Landroid_view_Display_Handler")]
		public override unsafe global::Android.Content.Context CreateDisplayContext (global::Android.Views.Display p0)
		{
			const string __id = "createDisplayContext.(Landroid/view/Display;)Landroid/content/Context;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createPackageContext' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("createPackageContext", "(Ljava/lang/String;I)Landroid/content/Context;", "GetCreatePackageContext_Ljava_lang_String_IHandler")]
		public override unsafe global::Android.Content.Context CreatePackageContext (string p0, int p1)
		{
			const string __id = "createPackageContext.(Ljava/lang/String;I)Landroid/content/Context;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='createPackageContextAsUser' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.os.UserHandle']]"
		[Register ("createPackageContextAsUser", "(Ljava/lang/String;ILandroid/os/UserHandle;)Landroid/content/Context;", "GetCreatePackageContextAsUser_Ljava_lang_String_ILandroid_os_UserHandle_Handler")]
		public override unsafe global::Android.Content.Context CreatePackageContextAsUser (string p0, int p1, global::Android.OS.UserHandle p2)
		{
			const string __id = "createPackageContextAsUser.(Ljava/lang/String;ILandroid/os/UserHandle;)Landroid/content/Context;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='databaseList' and count(parameter)=0]"
		[Register ("databaseList", "()[Ljava/lang/String;", "GetDatabaseListHandler")]
		public override unsafe string[] DatabaseList ()
		{
			const string __id = "databaseList.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='deleteDatabase' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteDatabase", "(Ljava/lang/String;)Z", "GetDeleteDatabase_Ljava_lang_String_Handler")]
		public override unsafe bool DeleteDatabase (string p0)
		{
			const string __id = "deleteDatabase.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='deleteFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("deleteFile", "(Ljava/lang/String;)Z", "GetDeleteFile_Ljava_lang_String_Handler")]
		public override unsafe bool DeleteFile (string p0)
		{
			const string __id = "deleteFile.(Ljava/lang/String;)Z";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingOrSelfPermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("enforceCallingOrSelfPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingOrSelfPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void EnforceCallingOrSelfPermission (string p0, string p1)
		{
			const string __id = "enforceCallingOrSelfPermission.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingOrSelfUriPermission' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("enforceCallingOrSelfUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingOrSelfUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public override unsafe void EnforceCallingOrSelfUriPermission (global::Android.Net.Uri p0, int p1, string p2)
		{
			const string __id = "enforceCallingOrSelfUriPermission.(Landroid/net/Uri;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingPermission' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("enforceCallingPermission", "(Ljava/lang/String;Ljava/lang/String;)V", "GetEnforceCallingPermission_Ljava_lang_String_Ljava_lang_String_Handler")]
		public override unsafe void EnforceCallingPermission (string p0, string p1)
		{
			const string __id = "enforceCallingPermission.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceCallingUriPermission' and count(parameter)=3 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.String']]"
		[Register ("enforceCallingUriPermission", "(Landroid/net/Uri;ILjava/lang/String;)V", "GetEnforceCallingUriPermission_Landroid_net_Uri_ILjava_lang_String_Handler")]
		public override unsafe void EnforceCallingUriPermission (global::Android.Net.Uri p0, int p1, string p2)
		{
			const string __id = "enforceCallingUriPermission.(Landroid/net/Uri;ILjava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforcePermission' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='java.lang.String']]"
		[Register ("enforcePermission", "(Ljava/lang/String;IILjava/lang/String;)V", "GetEnforcePermission_Ljava_lang_String_IILjava_lang_String_Handler")]
		public override unsafe void EnforcePermission (string p0, int p1, int p2, string p3)
		{
			const string __id = "enforcePermission.(Ljava/lang/String;IILjava/lang/String;)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (native_p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceUriPermission' and count(parameter)=5 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String']]"
		[Register ("enforceUriPermission", "(Landroid/net/Uri;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_IIILjava_lang_String_Handler")]
		public override unsafe void EnforceUriPermission (global::Android.Net.Uri p0, int p1, int p2, int p3, string p4)
		{
			const string __id = "enforceUriPermission.(Landroid/net/Uri;IIILjava/lang/String;)V";
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='enforceUriPermission' and count(parameter)=7 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String']]"
		[Register ("enforceUriPermission", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V", "GetEnforceUriPermission_Landroid_net_Uri_Ljava_lang_String_Ljava_lang_String_IIILjava_lang_String_Handler")]
		public override unsafe void EnforceUriPermission (global::Android.Net.Uri p0, string p1, string p2, int p3, int p4, int p5, string p6)
		{
			const string __id = "enforceUriPermission.(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;IIILjava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='fileList' and count(parameter)=0]"
		[Register ("fileList", "()[Ljava/lang/String;", "GetFileListHandler")]
		public override unsafe string[] FileList ()
		{
			const string __id = "fileList.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDatabasePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDatabasePath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetDatabasePath_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetDatabasePath (string p0)
		{
			const string __id = "getDatabasePath.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDir' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getDir", "(Ljava/lang/String;I)Ljava/io/File;", "GetGetDir_Ljava_lang_String_IHandler")]
		public override unsafe global::Java.IO.File GetDir (string p0, int p1)
		{
			const string __id = "getDir.(Ljava/lang/String;I)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getDisplayAdjustments' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDisplayAdjustments", "(I)Landroid/view/DisplayAdjustments;", "GetGetDisplayAdjustments_IHandler")]
		public override unsafe global::Android.View.DisplayAdjustments GetDisplayAdjustments (int p0)
		{
			const string __id = "getDisplayAdjustments.(I)Landroid/view/DisplayAdjustments;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.View.DisplayAdjustments> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalCacheDirs' and count(parameter)=0]"
		[Register ("getExternalCacheDirs", "()[Ljava/io/File;", "GetGetExternalCacheDirsHandler")]
		public override unsafe global::Java.IO.File[] GetExternalCacheDirs ()
		{
			const string __id = "getExternalCacheDirs.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalFilesDir' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExternalFilesDir", "(Ljava/lang/String;)Ljava/io/File;", "GetGetExternalFilesDir_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetExternalFilesDir (string p0)
		{
			const string __id = "getExternalFilesDir.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalFilesDirs' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getExternalFilesDirs", "(Ljava/lang/String;)[Ljava/io/File;", "GetGetExternalFilesDirs_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File[] GetExternalFilesDirs (string p0)
		{
			const string __id = "getExternalFilesDirs.(Ljava/lang/String;)[Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getExternalMediaDirs' and count(parameter)=0]"
		[Register ("getExternalMediaDirs", "()[Ljava/io/File;", "GetGetExternalMediaDirsHandler")]
		public override unsafe global::Java.IO.File[] GetExternalMediaDirs ()
		{
			const string __id = "getExternalMediaDirs.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getFileStreamPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getFileStreamPath", "(Ljava/lang/String;)Ljava/io/File;", "GetGetFileStreamPath_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetFileStreamPath (string p0)
		{
			const string __id = "getFileStreamPath.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getObbDirs' and count(parameter)=0]"
		[Register ("getObbDirs", "()[Ljava/io/File;", "GetGetObbDirsHandler")]
		public override unsafe global::Java.IO.File[] GetObbDirs ()
		{
			const string __id = "getObbDirs.()[Ljava/io/File;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (global::Java.IO.File[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.IO.File));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSharedPreferences' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("getSharedPreferences", "(Ljava/lang/String;I)Landroid/content/SharedPreferences;", "GetGetSharedPreferences_Ljava_lang_String_IHandler")]
		public override unsafe global::Android.Content.ISharedPreferences GetSharedPreferences (string p0, int p1)
		{
			const string __id = "getSharedPreferences.(Ljava/lang/String;I)Landroid/content/SharedPreferences;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSharedPrefsFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSharedPrefsFile", "(Ljava/lang/String;)Ljava/io/File;", "GetGetSharedPrefsFile_Ljava_lang_String_Handler")]
		public override unsafe global::Java.IO.File GetSharedPrefsFile (string p0)
		{
			const string __id = "getSharedPrefsFile.(Ljava/lang/String;)Ljava/io/File;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.IO.File> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSystemService' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getSystemService", "(Ljava/lang/String;)Ljava/lang/Object;", "GetGetSystemService_Ljava_lang_String_Handler")]
		public override unsafe global::Java.Lang.Object GetSystemService (string p0)
		{
			const string __id = "getSystemService.(Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='getSystemServiceName' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;?&gt;']]"
		[Register ("getSystemServiceName", "(Ljava/lang/Class;)Ljava/lang/String;", "GetGetSystemServiceName_Ljava_lang_Class_Handler")]
		public override unsafe string GetSystemServiceName (global::Java.Lang.Class p0)
		{
			const string __id = "getSystemServiceName.(Ljava/lang/Class;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='grantUriPermission' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='android.net.Uri'] and parameter[3][@type='int']]"
		[Register ("grantUriPermission", "(Ljava/lang/String;Landroid/net/Uri;I)V", "GetGrantUriPermission_Ljava_lang_String_Landroid_net_Uri_IHandler")]
		public override unsafe void GrantUriPermission (string p0, global::Android.Net.Uri p1, int p2)
		{
			const string __id = "grantUriPermission.(Ljava/lang/String;Landroid/net/Uri;I)V";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openFileInput' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("openFileInput", "(Ljava/lang/String;)Ljava/io/FileInputStream;", "GetOpenFileInput_Ljava_lang_String_Handler")]
		public override unsafe global::System.IO.Stream OpenFileInput (string p0)
		{
			const string __id = "openFileInput.(Ljava/lang/String;)Ljava/io/FileInputStream;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openFileOutput' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("openFileOutput", "(Ljava/lang/String;I)Ljava/io/FileOutputStream;", "GetOpenFileOutput_Ljava_lang_String_IHandler")]
		public override unsafe global::System.IO.Stream OpenFileOutput (string p0, int p1)
		{
			const string __id = "openFileOutput.(Ljava/lang/String;I)Ljava/io/FileOutputStream;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openOrCreateDatabase' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory']]"
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Handler")]
		public override unsafe global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string p0, int p1, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2)
		{
			const string __id = "openOrCreateDatabase.(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='openOrCreateDatabase' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='android.database.sqlite.SQLiteDatabase.CursorFactory'] and parameter[4][@type='android.database.DatabaseErrorHandler']]"
		[Register ("openOrCreateDatabase", "(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;", "GetOpenOrCreateDatabase_Ljava_lang_String_ILandroid_database_sqlite_SQLiteDatabase_CursorFactory_Landroid_database_DatabaseErrorHandler_Handler")]
		public override unsafe global::Android.Database.Sqlite.SQLiteDatabase OpenOrCreateDatabase (string p0, int p1, global::Android.Database.Sqlite.SQLiteDatabase.ICursorFactory p2, global::Android.Database.IDatabaseErrorHandler p3)
		{
			const string __id = "openOrCreateDatabase.(Ljava/lang/String;ILandroid/database/sqlite/SQLiteDatabase$CursorFactory;Landroid/database/DatabaseErrorHandler;)Landroid/database/sqlite/SQLiteDatabase;";
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Database.Sqlite.SQLiteDatabase> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='peekWallpaper' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("peekWallpaper", "()Landroid/graphics/drawable/Drawable;", "GetPeekWallpaperHandler")]
		public override unsafe global::Android.Graphics.Drawables.Drawable PeekWallpaper ()
		{
			const string __id = "peekWallpaper.()Landroid/graphics/drawable/Drawable;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerReceiver' and count(parameter)=2 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Handler")]
		public override unsafe global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver p0, global::Android.Content.IntentFilter p1)
		{
			const string __id = "registerReceiver.(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;)Landroid/content/Intent;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerReceiver' and count(parameter)=4 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.content.IntentFilter'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.os.Handler']]"
		[Register ("registerReceiver", "(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiver_Landroid_content_BroadcastReceiver_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public override unsafe global::Android.Content.Intent RegisterReceiver (global::Android.Content.BroadcastReceiver p0, global::Android.Content.IntentFilter p1, string p2, global::Android.OS.Handler p3)
		{
			const string __id = "registerReceiver.(Landroid/content/BroadcastReceiver;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='registerReceiverAsUser' and count(parameter)=5 and parameter[1][@type='android.content.BroadcastReceiver'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='android.content.IntentFilter'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='android.os.Handler']]"
		[Register ("registerReceiverAsUser", "(Landroid/content/BroadcastReceiver;Landroid/os/UserHandle;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;", "GetRegisterReceiverAsUser_Landroid_content_BroadcastReceiver_Landroid_os_UserHandle_Landroid_content_IntentFilter_Ljava_lang_String_Landroid_os_Handler_Handler")]
		public override unsafe global::Android.Content.Intent RegisterReceiverAsUser (global::Android.Content.BroadcastReceiver p0, global::Android.OS.UserHandle p1, global::Android.Content.IntentFilter p2, string p3, global::Android.OS.Handler p4)
		{
			const string __id = "registerReceiverAsUser.(Landroid/content/BroadcastReceiver;Landroid/os/UserHandle;Landroid/content/IntentFilter;Ljava/lang/String;Landroid/os/Handler;)Landroid/content/Intent;";
			IntPtr native_p3 = JNIEnv.NewString (p3);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (native_p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_p3);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='removeStickyBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Obsolete (@"deprecated")]
		[Register ("removeStickyBroadcast", "(Landroid/content/Intent;)V", "GetRemoveStickyBroadcast_Landroid_content_Intent_Handler")]
		public override unsafe void RemoveStickyBroadcast (global::Android.Content.Intent p0)
		{
			const string __id = "removeStickyBroadcast.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='removeStickyBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Obsolete (@"deprecated")]
		[Register ("removeStickyBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetRemoveStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void RemoveStickyBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1)
		{
			const string __id = "removeStickyBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='revokeUriPermission' and count(parameter)=2 and parameter[1][@type='android.net.Uri'] and parameter[2][@type='int']]"
		[Register ("revokeUriPermission", "(Landroid/net/Uri;I)V", "GetRevokeUriPermission_Landroid_net_Uri_IHandler")]
		public override unsafe void RevokeUriPermission (global::Android.Net.Uri p0, int p1)
		{
			const string __id = "revokeUriPermission.(Landroid/net/Uri;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;)V", "GetSendBroadcast_Landroid_content_Intent_Handler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent p0)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent p0, string p1)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent p0, string p1, global::Android.OS.Bundle p2)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcast' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("sendBroadcast", "(Landroid/content/Intent;Ljava/lang/String;I)V", "GetSendBroadcast_Landroid_content_Intent_Ljava_lang_String_IHandler")]
		public override unsafe void SendBroadcast (global::Android.Content.Intent p0, string p1, int p2)
		{
			const string __id = "sendBroadcast.(Landroid/content/Intent;Ljava/lang/String;I)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void SendBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1)
		{
			const string __id = "sendBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastAsUser' and count(parameter)=3 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Handler")]
		public override unsafe void SendBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2)
		{
			const string __id = "sendBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastAsUser' and count(parameter)=4 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int']]"
		[Register ("sendBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;I)V", "GetSendBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_IHandler")]
		public override unsafe void SendBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, int p3)
		{
			const string __id = "sendBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;I)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendBroadcastMultiplePermissions' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("sendBroadcastMultiplePermissions", "(Landroid/content/Intent;[Ljava/lang/String;)V", "GetSendBroadcastMultiplePermissions_Landroid_content_Intent_arrayLjava_lang_String_Handler")]
		public override unsafe void SendBroadcastMultiplePermissions (global::Android.Content.Intent p0, string[] p1)
		{
			const string __id = "sendBroadcastMultiplePermissions.(Landroid/content/Intent;[Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=7 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.BroadcastReceiver'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1, global::Android.Content.BroadcastReceiver p2, global::Android.OS.Handler p3, int p4, string p5, global::Android.OS.Bundle p6)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_Landroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1, global::Android.OS.Bundle p2, global::Android.Content.BroadcastReceiver p3, global::Android.OS.Handler p4, int p5, string p6, global::Android.OS.Bundle p7)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;Landroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcast' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcast", "(Landroid/content/Intent;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcast_Landroid_content_Intent_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcast (global::Android.Content.Intent p0, string p1, int p2, global::Android.Content.BroadcastReceiver p3, global::Android.OS.Handler p4, int p5, string p6, global::Android.OS.Bundle p7)
		{
			const string __id = "sendOrderedBroadcast.(Landroid/content/Intent;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=8 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.content.BroadcastReceiver'] and parameter[5][@type='android.os.Handler'] and parameter[6][@type='int'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, global::Android.Content.BroadcastReceiver p3, global::Android.OS.Handler p4, int p5, string p6, global::Android.OS.Bundle p7)
		{
			const string __id = "sendOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p6 = JNIEnv.NewString (p6);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue (p5);
				__args [6] = new JniArgumentValue (native_p6);
				__args [7] = new JniArgumentValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p6);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=9 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='android.content.BroadcastReceiver'] and parameter[6][@type='android.os.Handler'] and parameter[7][@type='int'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, int p3, global::Android.Content.BroadcastReceiver p4, global::Android.OS.Handler p5, int p6, string p7, global::Android.OS.Bundle p8)
		{
			const string __id = "sendOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p7 = JNIEnv.NewString (p7);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue (p6);
				__args [7] = new JniArgumentValue (native_p7);
				__args [8] = new JniArgumentValue ((p8 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p8).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p7);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendOrderedBroadcastAsUser' and count(parameter)=10 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='int'] and parameter[5][@type='android.os.Bundle'] and parameter[6][@type='android.content.BroadcastReceiver'] and parameter[7][@type='android.os.Handler'] and parameter[8][@type='int'] and parameter[9][@type='java.lang.String'] and parameter[10][@type='android.os.Bundle']]"
		[Register ("sendOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Ljava_lang_String_ILandroid_os_Bundle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, string p2, int p3, global::Android.OS.Bundle p4, global::Android.Content.BroadcastReceiver p5, global::Android.OS.Handler p6, int p7, string p8, global::Android.OS.Bundle p9)
		{
			const string __id = "sendOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Ljava/lang/String;ILandroid/os/Bundle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p2 = JNIEnv.NewString (p2);
			IntPtr native_p8 = JNIEnv.NewString (p8);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (native_p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				__args [7] = new JniArgumentValue (p7);
				__args [8] = new JniArgumentValue (native_p8);
				__args [9] = new JniArgumentValue ((p9 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p9).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p2);
				JNIEnv.DeleteLocalRef (native_p8);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyBroadcast' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyBroadcast", "(Landroid/content/Intent;)V", "GetSendStickyBroadcast_Landroid_content_Intent_Handler")]
		public override unsafe void SendStickyBroadcast (global::Android.Content.Intent p0)
		{
			const string __id = "sendStickyBroadcast.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyBroadcastAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)V", "GetSendStickyBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe void SendStickyBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1)
		{
			const string __id = "sendStickyBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyOrderedBroadcast' and count(parameter)=6 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.content.BroadcastReceiver'] and parameter[3][@type='android.os.Handler'] and parameter[4][@type='int'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='android.os.Bundle']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyOrderedBroadcast", "(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcast_Landroid_content_Intent_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendStickyOrderedBroadcast (global::Android.Content.Intent p0, global::Android.Content.BroadcastReceiver p1, global::Android.OS.Handler p2, int p3, string p4, global::Android.OS.Bundle p5)
		{
			const string __id = "sendStickyOrderedBroadcast.(Landroid/content/Intent;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p4 = JNIEnv.NewString (p4);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (native_p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p4);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='sendStickyOrderedBroadcastAsUser' and count(parameter)=7 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle'] and parameter[3][@type='android.content.BroadcastReceiver'] and parameter[4][@type='android.os.Handler'] and parameter[5][@type='int'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='android.os.Bundle']]"
		[Obsolete (@"deprecated")]
		[Register ("sendStickyOrderedBroadcastAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V", "GetSendStickyOrderedBroadcastAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Landroid_content_BroadcastReceiver_Landroid_os_Handler_ILjava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe void SendStickyOrderedBroadcastAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1, global::Android.Content.BroadcastReceiver p2, global::Android.OS.Handler p3, int p4, string p5, global::Android.OS.Bundle p6)
		{
			const string __id = "sendStickyOrderedBroadcastAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;Landroid/content/BroadcastReceiver;Landroid/os/Handler;ILjava/lang/String;Landroid/os/Bundle;)V";
			IntPtr native_p5 = JNIEnv.NewString (p5);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue (native_p5);
				__args [6] = new JniArgumentValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p5);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='setTheme' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTheme", "(I)V", "GetSetTheme_IHandler")]
		public override unsafe void SetTheme (int p0)
		{
			const string __id = "setTheme.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='setWallpaper' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap']]"
		[Obsolete (@"deprecated")]
		[Register ("setWallpaper", "(Landroid/graphics/Bitmap;)V", "GetSetWallpaper_Landroid_graphics_Bitmap_Handler")]
		public override unsafe void SetWallpaper (global::Android.Graphics.Bitmap p0)
		{
			const string __id = "setWallpaper.(Landroid/graphics/Bitmap;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='setWallpaper' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Obsolete (@"deprecated")]
		[Register ("setWallpaper", "(Ljava/io/InputStream;)V", "GetSetWallpaper_Ljava_io_InputStream_Handler")]
		public override unsafe void SetWallpaper (global::System.IO.Stream p0)
		{
			const string __id = "setWallpaper.(Ljava/io/InputStream;)V";
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivities' and count(parameter)=1 and parameter[1][@type='android.content.Intent[]']]"
		[Register ("startActivities", "([Landroid/content/Intent;)V", "GetStartActivities_arrayLandroid_content_Intent_Handler")]
		public override unsafe void StartActivities (global::Android.Content.Intent[] p0)
		{
			const string __id = "startActivities.([Landroid/content/Intent;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivities' and count(parameter)=2 and parameter[1][@type='android.content.Intent[]'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("startActivities", "([Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivities_arrayLandroid_content_Intent_Landroid_os_Bundle_Handler")]
		public override unsafe void StartActivities (global::Android.Content.Intent[] p0, global::Android.OS.Bundle p1)
		{
			const string __id = "startActivities.([Landroid/content/Intent;Landroid/os/Bundle;)V";
			IntPtr native_p0 = JNIEnv.NewArray (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivity' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startActivity", "(Landroid/content/Intent;)V", "GetStartActivity_Landroid_content_Intent_Handler")]
		public override unsafe void StartActivity (global::Android.Content.Intent p0)
		{
			const string __id = "startActivity.(Landroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startActivity' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.Bundle']]"
		[Register ("startActivity", "(Landroid/content/Intent;Landroid/os/Bundle;)V", "GetStartActivity_Landroid_content_Intent_Landroid_os_Bundle_Handler")]
		public override unsafe void StartActivity (global::Android.Content.Intent p0, global::Android.OS.Bundle p1)
		{
			const string __id = "startActivity.(Landroid/content/Intent;Landroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startInstrumentation' and count(parameter)=3 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.os.Bundle']]"
		[Register ("startInstrumentation", "(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z", "GetStartInstrumentation_Landroid_content_ComponentName_Ljava_lang_String_Landroid_os_Bundle_Handler")]
		public override unsafe bool StartInstrumentation (global::Android.Content.ComponentName p0, string p1, global::Android.OS.Bundle p2)
		{
			const string __id = "startInstrumentation.(Landroid/content/ComponentName;Ljava/lang/String;Landroid/os/Bundle;)Z";
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startIntentSender' and count(parameter)=5 and parameter[1][@type='android.content.IntentSender'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;III)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIIHandler")]
		public override unsafe void StartIntentSender (global::Android.Content.IntentSender p0, global::Android.Content.Intent p1, int p2, int p3, int p4)
		{
			const string __id = "startIntentSender.(Landroid/content/IntentSender;Landroid/content/Intent;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startIntentSender' and count(parameter)=6 and parameter[1][@type='android.content.IntentSender'] and parameter[2][@type='android.content.Intent'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='android.os.Bundle']]"
		[Register ("startIntentSender", "(Landroid/content/IntentSender;Landroid/content/Intent;IIILandroid/os/Bundle;)V", "GetStartIntentSender_Landroid_content_IntentSender_Landroid_content_Intent_IIILandroid_os_Bundle_Handler")]
		public override unsafe void StartIntentSender (global::Android.Content.IntentSender p0, global::Android.Content.Intent p1, int p2, int p3, int p4, global::Android.OS.Bundle p5)
		{
			const string __id = "startIntentSender.(Landroid/content/IntentSender;Landroid/content/Intent;IIILandroid/os/Bundle;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				__args [5] = new JniArgumentValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startService' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("startService", "(Landroid/content/Intent;)Landroid/content/ComponentName;", "GetStartService_Landroid_content_Intent_Handler")]
		public override unsafe global::Android.Content.ComponentName StartService (global::Android.Content.Intent p0)
		{
			const string __id = "startService.(Landroid/content/Intent;)Landroid/content/ComponentName;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='startServiceAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("startServiceAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)Landroid/content/ComponentName;", "GetStartServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe global::Android.Content.ComponentName StartServiceAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1)
		{
			const string __id = "startServiceAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)Landroid/content/ComponentName;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='stopService' and count(parameter)=1 and parameter[1][@type='android.content.Intent']]"
		[Register ("stopService", "(Landroid/content/Intent;)Z", "GetStopService_Landroid_content_Intent_Handler")]
		public override unsafe bool StopService (global::Android.Content.Intent p0)
		{
			const string __id = "stopService.(Landroid/content/Intent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='stopServiceAsUser' and count(parameter)=2 and parameter[1][@type='android.content.Intent'] and parameter[2][@type='android.os.UserHandle']]"
		[Register ("stopServiceAsUser", "(Landroid/content/Intent;Landroid/os/UserHandle;)Z", "GetStopServiceAsUser_Landroid_content_Intent_Landroid_os_UserHandle_Handler")]
		public override unsafe bool StopServiceAsUser (global::Android.Content.Intent p0, global::Android.OS.UserHandle p1)
		{
			const string __id = "stopServiceAsUser.(Landroid/content/Intent;Landroid/os/UserHandle;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='unbindService' and count(parameter)=1 and parameter[1][@type='android.content.ServiceConnection']]"
		[Register ("unbindService", "(Landroid/content/ServiceConnection;)V", "GetUnbindService_Landroid_content_ServiceConnection_Handler")]
		public override unsafe void UnbindService (global::Android.Content.IServiceConnection p0)
		{
			const string __id = "unbindService.(Landroid/content/ServiceConnection;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.content']/class[@name='Context']/method[@name='unregisterReceiver' and count(parameter)=1 and parameter[1][@type='android.content.BroadcastReceiver']]"
		[Register ("unregisterReceiver", "(Landroid/content/BroadcastReceiver;)V", "GetUnregisterReceiver_Landroid_content_BroadcastReceiver_Handler")]
		public override unsafe void UnregisterReceiver (global::Android.Content.BroadcastReceiver p0)
		{
			const string __id = "unregisterReceiver.(Landroid/content/BroadcastReceiver;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
