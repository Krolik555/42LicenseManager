﻿using System;
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
        public string DBDir_Name { get; set; }
        public string TimeToRenew { get; set; }
        public string InstalledDirectory { get; set; }
        public bool AllowDuplicateMachines { get; set; }
    }

}
