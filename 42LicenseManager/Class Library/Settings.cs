using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42LicenseManager.Class_Library
{
    public static class Settings
    {
        public static Version CurrentSoftwareVersion { get; set; }

        /// <summary>
        /// Should NOT contain database name
        /// </summary>
        public static string SelectedDatabaseDirectory_Only { get; set; }
        /// <summary>
        /// Should end with "\Config.txt"
        /// </summary>
        public static string SelectedDatabaseConfigFilePath { get; set; }
        /// <summary>
        /// Should end with the database name .mdf
        /// </summary>
        public static string SelectedDatabaseFilePath { get; set; }



    }

}
