using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library
{
    class Config
    {
        

        #region Edit Config File
        public static void Update(ConfigClass In_ConfigData)
        {
            if (File.Exists($@"{Environment.CurrentDirectory}\Config.txt"))
            {
                createConfig(In_ConfigData);
            }
            // If Config file is missing
            else
            {
                // Allow duplicate machine names
                var result = MessageBox.Show("The config file is missing. I can create a new one I just need to know, does this database allow duplicate machine names?", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    In_ConfigData.AllowDuplicateMachines = true;
                }
                else if (result == DialogResult.No)
                {
                    In_ConfigData.AllowDuplicateMachines = false;
                }
                createConfig(In_ConfigData);
                Application.Restart();
            }
            // Private Method to Create a config file.
            void createConfig(ConfigClass _ConfigData)
            {
                // VERIFY DATABASE EXISTS BEFORE CLOSING
                if (Utilities.VerifyDatabaseExists(_ConfigData))
                {
                    // OVERWRITE/CREATE CONFIG FILE USING TEXT BOX DATA
                    TextWriter tw = new StreamWriter($@"{Environment.CurrentDirectory}\Config.txt");
                    tw.WriteLine($"DBDIR={_ConfigData.DBDir_Name}");
                    tw.WriteLine($"TimeToRenew={_ConfigData.TimeToRenew}");
                    tw.WriteLine($"InstalledDirectory={_ConfigData.InstalledDirectory}");
                    tw.WriteLine($"AllowDuplicateMachines={_ConfigData.AllowDuplicateMachines}");
                    tw.Close();
                }
                else
                {
                    MessageBox.Show("The selected Database does not exist.");
                }
            }
        }
        #endregion Edit Config File

        #region Get/Create Config Data
        /// <summary>
        /// Gets or creates program settings. If a Config file exists it will retrieve data from it otherwise it will create a new config file.
        /// </summary>
        /// <returns></returns>
        public static ConfigClass Get()
        {
            ConfigClass Config = new ConfigClass();
            string[] Conf = null;
            string ConfigDirectory = $@"{Environment.CurrentDirectory}\Config.txt";

            try
            {
                // IF CONFIG.TXT EXIST GET DATA
                if (File.Exists(ConfigDirectory))
                {

                    Conf = File.ReadAllLines(ConfigDirectory);
                    if (Conf != null && Conf.Length >= 0)
                    {
                        try
                        { // GET DATA IF VALID ELSE ERASE DATA
                            Config.DBDir_Name = Conf[0].Contains("DBDIR=") && Conf[0] != "" ? Conf[0].Remove(0, 6) : ""; // Remove "DBDIR=" text
                            Config.TimeToRenew = Conf[1].Contains("TimeToRenew=") && Conf[1] != "" ? Conf[1].Remove(0, 12) : ""; // Remove "TimeToRenew=" text
                            Config.InstalledDirectory = Conf[2].Contains("InstalledDirectory=") && Conf[2] != "" ? Conf[2].Remove(0, 19) : ""; // Remove "InstallDir=" text
                            Config.AllowDuplicateMachines = Conf[3].Contains("AllowDuplicateMachines=") && Conf[3] != "" ? Convert.ToBoolean(Conf[3].Remove(0, 23)) : Convert.ToBoolean("");
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.ToString());
                        }
                        // IF DATA IS ERASED THEN DELETE CONFIG FILE AND RE-RUN THIS
                        if (Config.DBDir_Name == "" || Config.TimeToRenew.ToString() == "" || Config.InstalledDirectory == "")
                        {
                            File.Delete($@"{Environment.CurrentDirectory}\Config.txt");
                            Config = Class_Library.Config.Get();
                        }
                    }
                }
                else
                { // NO CONFIG DATA FOUND. ASK CREATE NEW.
                    if (MessageBox.Show("Database settings are not configured or missing. Configure now?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ConfigForm CF = new ConfigForm();
                        DialogResult _cf = CF.ShowDialog();
                        if (_cf == DialogResult.OK)
                        {
                            Config = CF.OutputConfig();
                        }
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }

            return Config;
        }
        #endregion Get/Create Config Data
    }
}
