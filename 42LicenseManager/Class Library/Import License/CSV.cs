using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library.Import_License
{
    public static class CSV
    {
        /// <summary>
        /// Reads data from a .csv file and puts it into a DataTable.
        /// </summary>
        /// <param name="csv_FilePath"></param>
        /// <returns></returns>
        public static DataTable Read(string csv_FilePath)
        {
            try
            {
                // Step 1 - remove blank column
                RemoveBlankColumn(csv_FilePath);

                // Step 2 - collect the data
                var csvTable = new DataTable();
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(csv_FilePath)), true))
                {
                    csvTable.Load(csvReader);
                }
                // step 3 - return collected data
                return csvTable;
            }
            catch (IOException err)
            {
                if (err.Message.Contains("is being used by another process"))
                {
                    MessageBox.Show($"{err.Message} \n Please close the process using the file and try again.");
                }
                return null;
            }
            
        }

        /// <summary>
        /// Takes data from a DataTable, verifies the data fits the supported format then converts it into the 'License' format.
        /// </summary>
        /// <param name="csvTable"></param>
        /// <param name="VerifiedLicenses"></param>
        /// <param name="FailedLicenses"></param>
        public static void TranslateData(DataTable csvTable, List<License> VerifiedLicenses, List<License> FailedLicenses, string Format)
        {
            if (Format == "Avast Business Cloud Care")
            {
                // Verify file structure is what the program expects.
                List<string> VerifiedImportData = new List<string>();
                foreach (System.Data.DataColumn column in csvTable.Columns)
                {
                    VerifiedImportData.Add(column.ColumnName);
                }
                #region File Structure
                // If file structure is compatible, continue.
                if (SupportedFormat(VerifiedImportData))
                {
                    // for each row
                    for (int i = 0; i < csvTable.Rows.Count; i++)
                    {
                        License NewLicense = new License();

                        #region License Count
                        // If subscription contains more than 0 it is considered active.
                        if (Convert.ToInt32(csvTable.Rows[i][2]) > 0)
                        {
                            #region Service
                            // If Subscription IS for AntiVirus
                            if (csvTable.Rows[i][1].ToString().ToLower() == "antivirus")
                            {
                                // Get License Name Info - figure out what is a company name, first name and last name.
                                Import_License.CustomerNamingLogic.SortNames(NewLicense, csvTable.Rows[i][0].ToString());

                                #region Subscription and Expireation/Renewal Date
                                // If License has expiration date
                                if (csvTable.Rows[i][3].ToString().Contains("Prepaid"))
                                {
                                    // Get expiration date
                                    NewLicense.ExpirationDate = Convert.ToDateTime(csvTable.Rows[i][4]);
                                    VerifiedLicenses.Add(NewLicense);

                                    #region Auto-Renew
                                    string _autorenew = csvTable.Rows[i][5].ToString();
                                    // if value is yes, no, true or false
                                    if (_autorenew == "Yes" || _autorenew == "No" || _autorenew == "True" || _autorenew == "False") 
                                    { // convert to true or false
                                        _autorenew = _autorenew == "Yes" ? "True" : "False";
                                        // Write Auto-Renew result to new license
                                        NewLicense.ChkBxAutoRenew = bool.Parse(_autorenew);
                                    }
                                    // If value is not yes or no, it is likely a "Monthly" subscription and if so, will be rejected.
                                    #endregion Auto-Renew
                                }
                                else // NO EXPIRATION DATE
                                {
                                    //note: At this point the NewLicense has only a name.
                                    NewLicense.Notes = "License rejected: Does not have an expiration date (Monthly subscription).";
                                    FailedLicenses.Add(NewLicense);
                                }
                                #endregion Subscription and Expireation/Renewal Date
                            }
                            // Subscription is NOT ANTIVIRUS
                            else
                            {
                                // Get license name for use with failed license list
                                Import_License.CustomerNamingLogic.SortNames(NewLicense, csvTable.Rows[i][0].ToString());
                                NewLicense.Notes = $"License rejected: Subscription is for {csvTable.Rows[i][1].ToString()}, not Antivirus.";
                                FailedLicenses.Add(NewLicense);
                            }
                            #endregion Service
                        }
                        else // Subscription contains no paid licenses. Do nothing with it.
                        {

                        }
                        #endregion License Count
                    }
                }
                #endregion File Structure
            }
        }

        private static void RemoveBlankColumn(string csv_FilePath)
        {
            try
            {
                // Clear blank columns
                string[] data = File.ReadAllLines(csv_FilePath);
                if (data[0].Contains(",\"\""))
                {
                    data[0] = (data[0].Remove((data[0].Length - 4), 3));

                }
                // clear the contents of the old file.
                File.WriteAllText(csv_FilePath, "");
                // save the new contents to the old file.
                File.AppendAllLines(csv_FilePath, data);
            }
            catch (IOException err)
            {
                if (err.Message.Contains("is being used by another process"))
                {
                    throw new IOException(err.Message);
                }
            }
            
        }

        /// <summary>
        /// Compares the file structure of a given CSV file with the file structure that is supported by this program.
        /// </summary>
        /// <param name="FileFormat"></param>
        /// <returns></returns>
        private static bool SupportedFormat(List<string> FileFormat)
        {
            // The current CSV format supported by this program.
            List<string> SupportedFormat = new List<string>();
            SupportedFormat.Add("Customer Name");
            SupportedFormat.Add("Service");
            SupportedFormat.Add("License Count");
            SupportedFormat.Add("Subscription");
            SupportedFormat.Add("Expiration / Renewal Date");
            SupportedFormat.Add("Auto-renew");

            if (FileFormat.SequenceEqual(SupportedFormat))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
