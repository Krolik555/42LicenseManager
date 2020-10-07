using _42Transfer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library
{
    class Updates
    {
        /// <summary>
        /// "42Transfer.exe" (unless it was renamed)
        /// </summary>
        static string OriginalFileName = Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName); // 42Transfer.exe
        
        /// <summary>
        /// "42Transfer.exe_Update"
        /// </summary>
        static string DownloadedFile = $"{OriginalFileName}_Update";
        static string DownloadDirectory = "";
        static string UpdateLink = "https://github.com/Krolik555/ProgramUpdates/raw/master/42Transfer.exe";

        static string newVersion = "";

        public static void Check()
        {


            //bool HasInternet = Updates.CheckforInternet();
            if (Updates.CheckforInternet())
            {
                Updates.CheckForUpdates();
            }

        }

        private static bool CheckforInternet()
        {
            bool HasInternet;
            try
            {
                using (WebClient client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        HasInternet = true;
                    }
                }
            }
            catch
            {
                HasInternet = false;
            }
            if (HasInternet)
            {
                return true;
            }
            else
            {
                MessageBox.Show("No Internet Connection!", "Error!");
                return false;

            }
        }

        private static Version currentVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Checks for updates > Asks if its okay to update > Updates.
        /// </summary>
        private static void CheckForUpdates()
        {
            Updates.GetCurrentVersion();
            Updates.GetLatestVersion();
            Updates.Cleanup();
        }

        private static void GetCurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo _versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version tempVer = new Version(_versionInfo.ProductVersion);
            Updates.currentVersion = tempVer;
        }

        private static void GetLatestVersion()
        {
            try
            {
                string _TempDownloadLocation = $@"C:\ProgramData";
                using (WebClient client = new WebClient())
                {
                    if (Directory.Exists(_TempDownloadLocation))
                    {
                        client.DownloadFile($"{UpdateLink}", $@"{_TempDownloadLocation}\{DownloadedFile}");// download to programdata
                        DownloadDirectory = _TempDownloadLocation;
                    }
                    else
                    {
                        client.DownloadFile($"{UpdateLink}", $"{DownloadedFile}"); // download to current dir
                        // Get saved directory
                        DownloadDirectory = $"{Directory.GetCurrentDirectory()}";
                    }

                }
            }
            catch (System.Net.WebException err)
            {
                ErrorForm errFrm = new ErrorForm("Resource not found. Please notify the developer.", err.ToString() + Environment.NewLine + Environment.NewLine + err.Message, "Error!");
                DialogResult dResult = errFrm.ShowDialog();
                return;
            }
            catch (Exception err)
            {
                
                ErrorForm ErrFrm = new ErrorForm("Update Failed: There was an error while downloading the update. Please notify the developer.", err.ToString(), "Error!");
                DialogResult dResult = ErrFrm.ShowDialog();
                return;
            }
            FileVersionInfo NewfileVersioninfo = FileVersionInfo.GetVersionInfo($@"{DownloadDirectory}\{DownloadedFile}");
            Version _newVersion = new Version(NewfileVersioninfo.ProductVersion);
            newVersion = _newVersion.ToString(); //used later when updating
            if (_newVersion > Updates.currentVersion)
            {
                DialogResult Result = MessageBox.Show(string.Format("An Update is available, Update now?\nCurrent Version: {0}\nLatest Version: {1}", Updates.currentVersion, newVersion), "Update Available!", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    Updates.Update();
                }
                else
                {
                    Updates.Cleanup();
                }
            }
            else
            {
                MessageBox.Show("You already have the latest version!");
                //Updates.Cleanup();
            }
        }

        private static void Update()
        {


            string CurrentDir = Directory.GetCurrentDirectory(); // Current Directory
            string Currentdir_FileName = Process.GetCurrentProcess().MainModule.FileName; // Current Directory and original file name

            File.Move($@"{DownloadDirectory}\{DownloadedFile}", CurrentDir + $@"\42Transfer v{newVersion}.exe"); // move download to cur location and rename
            Thread.Sleep(1000);
            Process.Start(CurrentDir + $@"\42Transfer v{newVersion}.exe");

            Application.Exit();
        }

        public static void Cleanup()
        {
            try
            {

                if (File.Exists(Directory.GetCurrentDirectory() + $@"\{DownloadedFile}"))
                {
                    File.Delete(Directory.GetCurrentDirectory() + $@"\{DownloadedFile}");
                }
                if (File.Exists($@"C:\ProgramData\{DownloadedFile}"))
                {
                    File.Delete($@"C:\ProgramData\{DownloadedFile}");
                }
            }
            catch
            {

            }
        }
    }
}
