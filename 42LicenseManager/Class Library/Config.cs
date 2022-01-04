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
        

        #region Edit/Update Config File
        public static void Update(ConfigClass In_ConfigData)
        {
            // if Config exists, update config
            if (File.Exists(Class_Library.Settings.SelectedDatabaseConfigFilePath))
            {
                // Create/Update config.txt file
                createConfig(In_ConfigData);
            }
            // If Config file is missing - Create new config file
            else
            {
                // Default Config settings 
                In_ConfigData.BackupTarget_PathOnly = "";
                In_ConfigData.AutoBackup = false;
                In_ConfigData.BackupSchedule = 24;
                In_ConfigData.BackupExpiration = 6;

                // Create Config.txt file
                createConfig(In_ConfigData);
                
            }

            // Private Method to Create or rewrite a config file.
            void createConfig(ConfigClass _ConfigData)
            {
                // VERIFY DATABASE EXISTS
                if (Utilities.VerifyDatabaseExists(_ConfigData))
                {
                    // OVERWRITE/CREATE CONFIG FILE USING TEXT FILE DATA
                    TextWriter tw = new StreamWriter($@"{Path.GetDirectoryName(In_ConfigData.DBDir_Name)}\Config.txt");
                    tw.WriteLine($"DBDIR={_ConfigData.DBDir_Name}");
                    tw.WriteLine($"TimeToRenew={_ConfigData.TimeToRenew}");
                    tw.WriteLine($"InstalledDirectory={_ConfigData.InstalledDirectory}");
                    tw.WriteLine($"AllowDuplicateClients={_ConfigData.AllowDuplicateClients}");
                    tw.WriteLine($"AllowDuplicateMachines={_ConfigData.AllowDuplicateMachines}");
                    tw.WriteLine($"BackupTarget={_ConfigData.BackupTarget_PathOnly}");
                    tw.WriteLine($"AutoBackup={_ConfigData.AutoBackup}");
                    tw.WriteLine($"BackupSchedule={_ConfigData.BackupSchedule}");
                    tw.WriteLine($"BackupExpiration={_ConfigData.BackupExpiration}");
                    tw.WriteLine($"LastBackup={_ConfigData.LastBackup}");
                    tw.WriteLine($"LastDataImport={_ConfigData.LastDataImport}");
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
        public static ConfigClass Get(string PathToConfigFile)
        {
            ConfigClass Config = new ConfigClass();
            string[] Conf;


            try
            {
                // IF CONFIG.TXT EXIST GET DATA
                if (File.Exists(PathToConfigFile))
                {

                    Conf = File.ReadAllLines(PathToConfigFile);
                    if (Conf != null && Conf.Length >= 0)
                    {
                        try
                        { // GET DATA IF VALID
                            Config.DBDir_Name = Conf[0].Contains("DBDIR=") && Conf[0] != "" ? Conf[0].Remove(0, 6) : ""; // Remove "DBDIR=" text
                            Config.TimeToRenew = Conf[1].Contains("TimeToRenew=") && Conf[1] != "" ? Conf[1].Remove(0, 12) : ""; // Remove "TimeToRenew=" text
                            Config.InstalledDirectory = Conf[2].Contains("InstalledDirectory=") && Conf[2] != "" ? Conf[2].Remove(0, 19) : ""; // Remove "InstallDir=" text
                            Config.AllowDuplicateClients = Conf[3].Contains("AllowDuplicateClients=") && Conf[3] != "" ? Convert.ToBoolean(Conf[3].Remove(0, 22)) : Convert.ToBoolean("");
                            Config.AllowDuplicateMachines = Conf[4].Contains("AllowDuplicateMachines=") && Conf[4] != "" ? Convert.ToBoolean(Conf[4].Remove(0, 23)) : Convert.ToBoolean("");
                            Config.BackupTarget_PathOnly = Conf[5].Contains("BackupTarget=") && Conf[5] != "" ? Conf[5].Remove(0, 13) : ""; // Remove "BackupTarget=" text
                            Config.AutoBackup = Conf[6].Contains("AutoBackup=") && Conf[6] != "" ? Convert.ToBoolean(Conf[6].Remove(0, 11)) : Convert.ToBoolean(""); // remove "AutoBackup=" text
                            Config.BackupSchedule = Conf[7].Contains("BackupSchedule=") && Conf[7] != "" ? Convert.ToInt32(Conf[7].Remove(0, 15)) : Convert.ToInt32("");
                            Config.BackupExpiration = Conf[8].Contains("BackupExpiration=") && Conf[8] != "" ? Convert.ToInt32(Conf[8].Remove(0, 17)) : Convert.ToInt32("");
                            Config.LastBackup = Conf[9].Contains("LastBackup=") && Conf[9] != "" ? Convert.ToDateTime(Conf[9].Remove(0, 11)) : Convert.ToDateTime("");
                            Config.LastDataImport = Conf[10].Contains("LastDataImport=") && Conf[10] != "" ? Convert.ToDateTime(Conf[10].Remove(0, 15)) : Convert.ToDateTime("");
                        }
                        catch (Exception error)
                        {
                            MessageBox.Show(error.ToString());
                        }
                        // IF DATA IS CORRUPT THEN DELETE CONFIG FILE AND RE-RUN Config.Get
                        if (Config.DBDir_Name == "" || Config.TimeToRenew.ToString() == "" || Config.InstalledDirectory == "")
                        {
                            File.Delete(PathToConfigFile);
                            Config = Class_Library.Config.Get(PathToConfigFile);
                        }
                    }
                }
                else
                { // NO CONFIG DATA FOUND. ASK CREATE NEW.
                    if (MessageBox.Show("Database settings are not configured or missing. Configure now?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ConfigForm CF = new ConfigForm(Config);

                        DialogResult _cf = CF.ShowDialog();
                        if (_cf == DialogResult.OK)
                        {
                            Config = CF.ConfigOutput;
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
