//using LumenWorks.Framework.IO.Csv;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library.Import_Machines
{
    internal class CSV
    {

        /// <summary>
        /// Reads data from a .csv file and puts it into a DataTable.
        /// </summary>
        /// <param name="csv_FilePath"></param>
        /// <returns></returns>
        //public static DataTable Read(string csv_FilePath)
        //{
        //    try
        //    {

        //        // Step 1 - collect the data
        //        var csvTable = new DataTable();
        //        using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(csv_FilePath)), true))
        //        {
        //            csvTable.Load(csvReader);
        //        }
        //        // step 2 - return collected data
        //        return csvTable;
        //    }
        //    catch (IOException err)
        //    {
        //        if (err.Message.Contains("is being used by another process"))
        //        {
        //            MessageBox.Show($"{err.Message} \n Please close the process using the file and try again.");
        //        }
        //        return null;
        //    }

        //}
        public static DataTable Read(string csv_FilePath)
        {
            List<string> RecordsList = new List<string>();
            try
            {

                //// Step 1 - collect the data
                //using (var reader = new StreamReader(csv_FilePath))
                //{

                //    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                //    {
                //        var records = csv.GetRecords<dynamic>().ToList();
                //        DataTable dataTable = new DataTable();

                //        if (records.Any())
                //        {
                //            foreach (var header in ((IDictionary<string, object>)records[0]).Keys)
                //            {
                //                dataTable.Columns.Add(header);
                //            }

                //            foreach (var record in records)
                //            {
                //                var row = dataTable.NewRow();
                //                foreach (var property in (IDictionary<string, object>)record)
                //                {
                //                    row[property.Key] = property.Value ?? DBNull.Value;
                //                }
                //                dataTable.Rows.Add(row);
                //            }
                //        }
                //        return dataTable;
                //    }
                //}




                //var fake = new DataTable();
                //// step 2 - return collected data
                //return fake;

                DataTable dataTable = CollectData(csv_FilePath);
                // Use the DataTable as needed
                return dataTable;

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

        public static DataTable CollectData(string csv_FilePath)
        {
            // Step 1 - Read the CSV file
            string csvContent;
            using (var reader = new StreamReader(csv_FilePath))
            {
                csvContent = reader.ReadToEnd();
            }

            // Step 2 - Fix double quotes issue
            csvContent = FixQuotes(csvContent);

            // Step 3 - Use CsvReader to read cleaned CSV content
            using (var reader = new StringReader(csvContent))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<dynamic>().ToList();
                    DataTable dataTable = new DataTable();
                    if (records.Any())
                    {
                        foreach (var header in ((IDictionary<string, object>)records[0]).Keys)
                        {
                            dataTable.Columns.Add(header);
                        }

                        foreach (var record in records)
                        {
                            var row = dataTable.NewRow();
                            foreach (var property in (IDictionary<string, object>)record)
                            {
                                row[property.Key] = property.Value ?? DBNull.Value;
                            }
                            dataTable.Rows.Add(row);
                        }
                    }
                    return dataTable;
                }
            }
        }

            public static string FixQuotes(string input)
        {
            return System.Text.RegularExpressions.Regex.Replace(input, @"(?<!\,)""(?!\,)", string.Empty);
        }

        public static List<string> TranslateData(DataTable csvTable)
        {
            List<string> ValidMachineNames = new List<string>();

            if (csvTable.Columns[0].ToString() == "Device/Description")
            {
                for (int i = 0; i < csvTable.Rows.Count; i++)
                {
                    ValidMachineNames.Add(csvTable.Rows[i][0].ToString());
                }
            }
            else
            {
                MessageBox.Show("Import file is not valid. The first column must contain the machine names and be labeled 'Device/Description'. The rest of the column labels and content don't matter.");
            }

            return ValidMachineNames;
        }

    }
}
