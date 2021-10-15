using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library
{
    class Backup //run me as async
    {
        public static void Now(string SourceDir_FileName, string DestFileName, string DestFolderName)
        {

            Cursor.Current = Cursors.AppStarting;

            int BackupAttempts = 0;

            // First backup attempt. Will return true if successful.
            bool BackupSuccessful = fileCopy(SourceDir_FileName, DateTime.Now.ToString("yyyyMMdd-HHmm ") + DestFileName, DestFolderName);

            // If first attempt failed, try again 2 more times.
            while (BackupSuccessful == false && BackupAttempts < 2)
            {
                System.Threading.Thread.Sleep(10000);
                BackupSuccessful = fileCopy(SourceDir_FileName, DateTime.Now.ToString("yyyyMMdd-HHmm ") + DestFileName, DestFolderName);
                BackupAttempts++;
            }
            if (BackupSuccessful == false && BackupAttempts >= 3)
            {
                ErrorLogs.Create($"Backup failed after 3 attempts. \nDatabase: {SourceDir_FileName}");
            }

            if (BackupSuccessful)
            {
                // Get Config
                ConfigClass config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
                // Set successful backup date
                config.LastBackup = DateTime.Now;
                // Update config file with new data
                Class_Library.Config.Update(config);

                //Thread.Sleep(2000);
                MessageBox.Show(new Form { TopMost = true }, "Backup Complete!");
            }
            else
            {
                MessageBox.Show("Backup Failed after 3 attempts.");
            }

            // Reset cursor
            Cursor.Current = Cursors.Default;
        }

        public static bool TimeToBackup (DateTime LastBackupCheck)
        {
            ConfigClass config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
            if (LastBackupCheck < DateTime.Now.AddHours(-config.BackupSchedule) || config.LastBackup < DateTime.Now.AddHours(-config.BackupSchedule))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks when the last backup was. If the last backup is older than the user-specified backup time, it will backup.
        // AutoBackup does not prompt user for anything.
        public static void AutoBackup(string SourceDir_FileName, string DestFileName, string DestFolderName)
        {
            int BackupAttempts = 0;

            // First backup attempt. Will return true if successful.
            bool BackupSuccessful = fileCopy(SourceDir_FileName, DateTime.Now.ToString("yyyyMMdd-HHmm ") + DestFileName, DestFolderName);

            // If first attempt failed, try again 2 more times.
            while (BackupSuccessful == false && BackupAttempts < 2)
            {
                System.Threading.Thread.Sleep(10000);
                BackupSuccessful = fileCopy(SourceDir_FileName, DateTime.Now.ToString("yyyyMMdd-HHmm ") + DestFileName, DestFolderName);
                BackupAttempts++;
            }
            if (BackupSuccessful == false && BackupAttempts >= 3)
            {
                ErrorLogs.Create($"Backup failed after 3 attempts. \nDatabase: {SourceDir_FileName}");
            }

            if (BackupSuccessful)
            {
                // Get Config
                ConfigClass config = Class_Library.Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
                // Set successful backup date
                config.LastBackup = DateTime.Now;
                // Update config file with new data
                Class_Library.Config.Update(config);
            }

        }

        /// <summary>
        /// Returns false if backup failed and needs to be tried again.
        /// </summary>
        /// <param name="SourceDir_FileName"></param>
        /// <param name="DestFileName"></param>
        /// <param name="DestFolderName"></param>
        /// <returns></returns>
        private static bool fileCopy(string SourceDir_FileName, string DestFileName, string DestFolderName)
        {
            try
            {
                // If the destination directory does not exist, create it.
                if (!Directory.Exists(DestFolderName) && DestFolderName != null)
                {
                    Directory.CreateDirectory(DestFolderName);
                }

                // Create the path to the new copy of the file.
                string temppath = Path.Combine(DestFolderName, DestFileName);

                // Copy the file.
                File.Copy(SourceDir_FileName, temppath);
                //temppath = temppath.Remove(temppath.Length - 4) + "_log.ldf";
                //File.Copy(SourceDir_FileName, temppath);

                return true; // no need to re-run the backup

            }
            catch (System.IO.IOException)
            {
                return false; // backup failed. Try again.
            }
            catch (Exception e)
            {
                string errorMessage = "While working on this file: ";
                ErrorLogs.Create(($"Error in the 'FileCopy' stage: {e.Message}{ Environment.NewLine}{ errorMessage} \n\n {e}"));
                return true; // Backup failed but don't keep trying.
            }
        }

        public static void ClearOldBackups(string DirectoryContainingBackups)
        {
            // Get the names of all current backups
            string[] currentBackups = Directory.GetFiles(DirectoryContainingBackups);
            // Get config data
            ConfigClass _config = Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
            // Will be used to delete old backups
            List<string> oldBackups = new List<string>();


            foreach(string _backup in currentBackups)
            {
                // remove directory
                string filename = Path.GetFileName(_backup);
                // remove database name to keep only the date
                filename = filename.Substring(0, 8);
                // Add dashes into date
                filename = $"{filename.Substring(0,4)}-{filename.Substring(4,2)}-{filename.Substring(6,2)}";

                try
                {
                    // Convert to DateTime
                    DateTime backupDate = DateTime.Parse(filename);

                    // If backup is older than user specified time, delete it.
                    if (backupDate < DateTime.Now.AddMonths(-_config.BackupExpiration))
                    {
                        // add full database path and name to list
                        //oldBackups.Add(_backup);

                        // Delete old database
                        File.Delete(_backup);
                    }
                }
                catch
                {
                    
                }
                
            }


        }
    }
}
