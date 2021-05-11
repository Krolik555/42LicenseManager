using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace _42LicenseManager.Class_Library
{
    class ErrorLogs
    {

        /// <summary>
        /// Write error logs to a .txt file.
        /// <para>'DefaultLogStoreDirectory' requires the full Directory, excluding the file name.</para>
        /// <para>Default store directory located is in Logs.DefaultLogStoreDirectory</para>
        /// <para>'ErrorMessage' will be automatically followed by the directory of the file in question. Example: "ErrorMessage (C:\File.txt)"</para>
        /// </summary>
        /// <param name="Destination"></param>
        public static void Create(string ErrorMessage)
        {            
            ConfigClass _config = Config.Get(Class_Library.Settings.SelectedDatabaseConfigFilePath);
            string LogFileDirectory = _config.BackupTarget;
            string LogFileName = "ErrorLog.txt";

            // Determine what the log file will be named.
            string filepath = $@"{LogFileDirectory}\{LogFileName}";

            // Create directory if it does not exist
            if (!Directory.Exists(LogFileDirectory))
            {
                Directory.CreateDirectory(LogFileDirectory);
            }
            // Create error
            using (StreamWriter writer = new StreamWriter(filepath, true))
            {

                writer.WriteLine($"-----------------------------------------------------------------------");
                writer.WriteLine($@"Date: {DateTime.Now}{Environment.NewLine}Message: {ErrorMessage}");
            }
            return;
        }
    }
}
