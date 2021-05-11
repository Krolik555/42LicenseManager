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
            DialogResult DRBackupPrompt = MessageBox.Show("Backup now?", "Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DRBackupPrompt == DialogResult.Yes)
            {
                Cursor.Current = Cursors.WaitCursor;

                AutoBackup(SourceDir_FileName, DestFileName, DestFolderName);

            }
            
            
        }

        // Checks when the last backup was. If the last backup is older than the user-specified backup time, it will backup.
        public static void AutoBackup(string SourceDir_FileName, string DestFileName, string DestFolderName)
        {
            
            int BackupAttempts = 0;
            bool tryAgain = fileCopy(SourceDir_FileName, DateTime.Now.ToString("yyyyMMdd-HHmm ") + DestFileName, DestFolderName);


            while (tryAgain == false && BackupAttempts < 3)
            {
                System.Threading.Thread.Sleep(10000);
                tryAgain = fileCopy(SourceDir_FileName, DateTime.Now.ToString("yyyyMMdd-HHmm ") + DestFileName, DestFolderName);
                BackupAttempts++;
            }
            if (tryAgain == false && BackupAttempts >= 3)
            {
                ErrorLogs.Create($"Backup failed after 3 attempts.");
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

                //FileInfo file = new FileInfo(SourceDir_FileName);
                // Create the path to the new copy of the file.
                string temppath = Path.Combine(DestFolderName, DestFileName);

                // Copy the file.
                //file.CopyTo(temppath, true);
                File.Copy(SourceDir_FileName, temppath);
                temppath = temppath.Remove(temppath.Length - 4) + "_log.ldf";
                File.Copy(SourceDir_FileName, temppath);

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
    }
}
