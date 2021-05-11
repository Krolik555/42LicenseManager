using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager.Class_Library
{
    public static class DatabaseLibrary
    {
        public static string dbLibPath = ($@"{System.Environment.CurrentDirectory}");
        public static string dbLibName = "Databases.txt";
        public static string dbLibFilePath = $@"{dbLibPath}\{dbLibName}";

        #region Get Database Library
        public static List<string> Get()
        {
            // Read contents of databases.txt in programs install folder

            if (!File.Exists($@"{Environment.CurrentDirectory}\Databases.txt"))
            {
                // Create empty file.
                // Note: I chose to do it this way because file.create will keep the file open until the program restarts 
                // thus making it unusable until program restarts.
                List<string> emptyList = new List<string>();
                File.WriteAllLines($@"{Environment.CurrentDirectory}\Databases.txt", emptyList);

                //File.Create($@"{Environment.CurrentDirectory}\Databases.txt");

                
                //return emptyList;
            }

            // Get database library
            IEnumerable<string> dbLibrary = File.ReadLines($@"{Environment.CurrentDirectory}\Databases.txt");
            List<string> dbLibraryList = dbLibrary.ToList();

            return dbLibraryList;

        }
        #endregion

        #region Add Database
        public static void Add(string NewDBLibraryEntry)
        {
            // Get current database library
            List<string> dbLibrary = DatabaseLibrary.Get();
            
            // if new entry isn't a duplicate
            if (!dbLibrary.Contains(NewDBLibraryEntry))
            {
                // Add new database entry to dbLibrary
                dbLibrary.Add(NewDBLibraryEntry);
            }
            else
            {
                //DialogResult result = MessageBox.Show("This database already exists!", "Duplicate found", MessageBoxButtons.OK);
                //if (result == DialogResult.OK)
                //{
                //    return;
                //}
            }

            // Save new database library to Databases.txt
            File.WriteAllLines(dbLibFilePath, dbLibrary);
            //foreach (string line in dbLibrary)
            //{
                
            //}
        }
        #endregion

        #region Remove database from library
        public static void Remove(string UnwantedDBLibraryEntry)
        {
            // Get current database library
            List<string> dbLibrary = DatabaseLibrary.Get();

            // Remove entry
            if (dbLibrary.Contains(UnwantedDBLibraryEntry))
            {
                dbLibrary.Remove(UnwantedDBLibraryEntry);
                
            }
            string DatabaseLibraryFile = $@"{System.Environment.CurrentDirectory}\Databases.txt";
            File.WriteAllLines(DatabaseLibraryFile, File.ReadLines(DatabaseLibraryFile).Where(s => s != UnwantedDBLibraryEntry).ToList());

            // Save new database library to Databases.txt
            //foreach (string line in dbLibrary)
            //{
            //    File.WriteAllText(dbLibFilePath, line);
            //}

        }
        #endregion

    }
}
