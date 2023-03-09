using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static DataTable Read(string csv_FilePath)
        {
            try
            {

                // Step 1 - collect the data
                var csvTable = new DataTable();
                using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(csv_FilePath)), true))
                {
                    csvTable.Load(csvReader);
                }
                // step 2 - return collected data
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
