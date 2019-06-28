using System;
using System.Threading;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Morpho.Android.Usb;
using Com.Morpho.Morphosmart.Sdk;
using Java.IO;
using Xamarin.Essentials;
using AlertDialog = Android.App.AlertDialog;

namespace FingerprintScanner
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnFpOn;
        private Button btnFpOff;
        private Button btnGrantPermission;
        private Button btnStartScan;
        private Button btnStopScan;
        private Button btnSaveFp;
        private TextView txtSerialNo;
        private PipeService pipeService;
        private ScannerService scannerService;
        public static String TAG = "FP Scanner";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            pipeService = new PipeService(this);
            pipeService.InitializeService();
            pipeService.StartPipeServer();
            scannerService = new ScannerService(this);
            scannerService.InitializeScanner();

            btnFpOn = FindViewById<Button>(Resource.Id.btnFpOn);
            btnFpOff = FindViewById<Button>(Resource.Id.btnFpOff);
            btnGrantPermission = FindViewById<Button>(Resource.Id.btnGrantPermission);
            btnStartScan = FindViewById<Button>(Resource.Id.btnStartScan);
            btnStopScan = FindViewById<Button>(Resource.Id.btnStopScan);
            btnSaveFp = FindViewById<Button>(Resource.Id.btnSaveFp);
            txtSerialNo = FindViewById<TextView>(Resource.Id.txtSerialNumber);
            //btnStopScan.Enabled = false;

            // Assign The Event To Buttons
            btnFpOn.Click += delegate {
                int ret = 0;// setPowerFP(1);
                if (ret == 0)
                {
                    //pipeService = new PipeService(this);
                    //scannerLib.InitializeScanner();
                }
            };

            btnFpOff.Click += delegate {
                //setPowerFP(0);
                txtSerialNo.Text = "";
            };

            btnGrantPermission.Click += delegate {
                scannerService.GrantPermission();
            };

            btnStartScan.Click += delegate {
                try
                {
                    //btnStartScan.Enabled = false;
                    scanFingerPrint();
                } catch (Exception e)
                {
                    showAlert("Error", e.Message);
                }
                
            };

            btnStopScan.Click += delegate {
                //scannerLib.StopScan();
            };

            btnSaveFp.Click += delegate {
                saveFingerPrint();
            };        
            
            if (scannerService.HasUsbPermission() == 0)
            {
                btnGrantPermission.Enabled = false;
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnStart()
        {
            base.OnStart();
            txtSerialNo.Text = "";
            //setPowerFP(1);
        }

        protected override void OnStop()
        {
            base.OnStop();
            //setPowerFP(0);
            //serviceLib.StopPipeServer();
        }

        private void scanFingerPrint()
        {
            Log.Info(TAG, "Scan FP button clicked...");
            String sensorName = scannerService.EnumerateDevices();
            if (sensorName != null)
            {
                btnGrantPermission.Enabled = false;
                TextView txtSerialNo = FindViewById<TextView>(Resource.Id.txtSerialNumber);
                txtSerialNo.Text = sensorName;
                scannerService.Connection();
            }
            else
            {
                btnGrantPermission.Enabled = true;
                showAlert("Fingerprint Scanner",
                    "The device is not detected, or you have not asked USB persmissions, " +
                    "please click the button 'Grant Permission'");
            }
        }

        private void captureFingerPrint()
        {
            Log.Info(TAG, "Start capturing fingerprint...");
            //Button scanFpBtn = FindViewById<Button>(Resource.Id.scanFp);
            ProgressBar circularProgressbar = FindViewById<ProgressBar>(Resource.Id.circularProgressbar);
            ImageView fingerprintImg = FindViewById<ImageView>(Resource.Id.fingerprintImg);
            //scanFpBtn.Enabled = false;
            circularProgressbar.Visibility = ViewStates.Visible;
            fingerprintImg.Visibility = ViewStates.Gone;
            int progressStatus = 0;
            new System.Threading.Thread(new ThreadStart(delegate {
                while (progressStatus < 100)
                {
                    progressStatus += 10;
                    circularProgressbar.Progress = progressStatus;
                    System.Threading.Thread.Sleep(100);
                }
                RunOnUiThread(() => {
                    //scanFpBtn.Enabled = true;
                    circularProgressbar.Visibility = ViewStates.Gone;
                    fingerprintImg.Visibility = ViewStates.Visible;
                });
            })).Start();
        }

        private void saveFingerPrint()
        {    
            Log.Info(TAG, "Save FP button clicked...");
            //setPowerFP(0);
            //String filePath = Android.OS.Environment.ExternalStorageDirectory.Path;
            File file = Application.Context.GetExternalFilesDir(null);
            //showAlert("File path", file.AbsolutePath);
            var imgPath = Android.Net.Uri.Parse("android.resource://" + Application.Context.PackageName + "/" + Resource.Drawable.fingerprint).Path;
            //showAlert("Image path---", imgPath);
            GetBytesFromImage("Resources/drawable/fingerprint.png");
        }

        //morpho power on/off
        /*private int setPowerFP(int onOff)
        {
            int ret = -1;
            SledManager sledMgr = (SledManager)this.GetSystemService("sled");
            if (null != sledMgr)
            {
                try
                {
                    if (onOff == 1)
                    {
                        ret = sledMgr.BBSetFngrPower(1);
                        Log.Info(TAG, "Switching ON the FP scanner := " + ret);
                    }
                    else if (onOff == 0)
                    {
                        ret = sledMgr.BBSetFngrPower(0);
                        Log.Info(TAG, "Switching OFF the FP scanner := " + ret);
                    }
                } catch (Exception e)
                {
                    Log.Error(TAG, "An error occured in powering the FP scanner := " + e.Message);
                }
            } else
            {
                Log.Error(TAG, "An error occured in initializing the Sled Manager");
                //showAlert("Error", "An error occured in initializing the Sled Manager");
            }

            return ret;
        }*/

        private void UpdateUi()
        {
            RunOnUiThread(() => {
                btnStartScan.Enabled = true;
                btnStopScan.Enabled = false;
            });
        }

        private void showAlert(String title, String message)
        {
            Android.App.AlertDialog.Builder dialog = new AlertDialog.Builder(this);
            AlertDialog alert = dialog.Create();
            alert.SetTitle(title);
            alert.SetMessage(message);
            alert.SetIcon(Resource.Drawable.error);
            alert.SetButton("OK", (c, ev) =>
            {
                alert.Dismiss();
                // Ok button click task  
            });
            alert.Show();
        }

        private byte[] GetBytesFromImage(string imagePath)
        {
            try
            {
                var imgFile = new File(imagePath);
                var stream = new FileInputStream(imgFile);
                var bytes = new byte[imgFile.Length()];
                stream.Read(bytes);
                Log.Info(TAG, "Byte[] := " + bytes);
                return bytes;
            } catch(Exception e)
            {
                //showAlert("Exception", e.Message);
            }
            return null;
        }
    }
}

