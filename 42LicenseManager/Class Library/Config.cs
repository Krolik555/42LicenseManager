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
        public static void Update(ConfigClass ConfigData)
        {
            if (File.Exists($@"{Environment.CurrentDirectory}\Config.txt"))
            {
                //// SAVE DATA TO CONFIG OBJECT
                //ConfigClass Newconfig = new ConfigClass();
                //Newconfig.DBDir_Name = aTextBoxDir.Text;
                //Newconfig.TimeToRenew = aTextBoxTimeToRenew.Text;
                //Newconfig.InstalledDirectory = Environment.CurrentDirectory;

                // VERIFY DATABASE EXISTS BEFORE CLOSING
                if (Utilities.VerifyDatabaseExists(ConfigData))
                {
                    // OVERWRITE/CREATE CONFIG FILE USING TEXT BOX DATA
                    TextWriter tw = new StreamWriter($@"{Environment.CurrentDirectory}\Config.txt");
                    tw.WriteLine($"DBDIR={ConfigData.DBDir_Name}");
                    tw.WriteLine($"TimeToRenew={ConfigData.TimeToRenew}");
                    tw.WriteLine($"InstalledDirectory={ConfigData.InstalledDirectory}");
                    tw.WriteLine($"AllowDuplicateMachines={ConfigData.AllowDuplicateMachines}");
                    tw.Close();

                }
                else
                {
                    MessageBox.Show("The selected Database does not exist.");
                }
            }
            else
            {
                MessageBox.Show("The config file is missing.");
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
