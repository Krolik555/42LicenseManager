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

        /// <summary>
        /// Takes data from a DataTable, verifies the data fits the supported format then converts it into the 'License' format.
        /// </summary>
        /// <param name="csvTable"></param>
        /// <param name="VerifiedLicenses"></param>
        /// <param name="FailedLicenses"></param>
        public static void TranslateData(DataTable csvTable, List<License> VerifiedLicenses, List<License> FailedLicenses)
        {
            // Verify file structure is what the program expects.
            List<string> FileFormat = new List<string>();
            foreach (System.Data.DataColumn column in csvTable.Columns)
            {
                FileFormat.Add(column.ColumnName);
            }
            if (SupportedFormat(FileFormat))
            {
                // If file structure is compatible, continue.

                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                    License NewLicense = new License();
                    // If Subscription IS for AntiVirus
                    if (csvTable.Rows[i][1].ToString().ToLower() == "antivirus")
                    {
                        // Get License Name Info
                        Import_License.CustomerNamingLogic.SortNames(NewLicense, csvTable.Rows[i][0].ToString());
                        // If License has expiration date
                        if (csvTable.Rows[i][3].ToString().Contains("Prepaid"))
                        {
                            NewLicense.ExpirationDate = Convert.ToDateTime(csvTable.Rows[i][4]);
                            VerifiedLicenses.Add(NewLicense);
                        }
                        else // NO EXPIRATION DATE
                        {
                            //At this point the NewLicense has a name.
                            NewLicense.Notes = "License rejected: Does not have an expiration date (Monthly subscription).";
                            FailedLicenses.Add(NewLicense);
                        }
                    }
                    // Subscription is NOT ANTIVIRUS
                    else
                    {
                        // Get license name for use with failed license list
                        Import_License.CustomerNamingLogic.SortNames(NewLicense, csvTable.Rows[i][0].ToString());
                        NewLicense.Notes = $"License rejected: Subscription is for {csvTable.Rows[i][1].ToString()}, not Antivirus.";
                        FailedLicenses.Add(NewLicense);
                    }
                }
            }
        }

        private static void RemoveBlankColumn(string csv_FilePath)
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
            //for (int i = 0; i< data.Length; i++)
            //{
                
            //    File.appe(csv_FilePath, data[i]);
            //}
            
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
