using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    public class ConfigClass
    {
        /// <summary>
        /// Should end in YourDatabaseName.mdf
        /// </summary>
        public string DBDir_Name { get; set; }
        public string TimeToRenew { get; set; }
        /// <summary>
        /// Program Install Directory
        /// </summary>
        public string InstalledDirectory { get; set; }
        public bool AllowDuplicateClients { get; set; }
        public bool AllowDuplicateMachines { get; set; }

        //Backup Info
        public string BackupTarget_PathOnly { get; set; }
        public bool AutoBackup { get; set; }
        public int BackupSchedule { get; set; }
        public int BackupExpiration { get; set; }
        public DateTime LastBackup { get; set; }

    }

}
