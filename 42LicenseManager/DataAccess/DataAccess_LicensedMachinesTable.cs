using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    class DataAccess_LicensedMachinesTable
    {
        #region Stored Procedures

        public static List<LicensedMachines> FindDuplicate(string MachineName, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<LicensedMachines>("dbo.LicensedMachines_FindDuplicate @Name", new { Name = MachineName }).ToList();
            }
        }


        /// <summary>
        /// Get the machine/s by the License ID provided.
        /// </summary>
        /// <param name="LicenseId"></param>
        /// <param name="DBDIR_Name"></param>
        /// <returns></returns>
        public static List<LicensedMachines> GetByLicenseID(int LicenseId, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<LicensedMachines>("dbo.LicensedMachines_GetByLicenseID @ID", new { ID = LicenseId }).ToList();

            }
        }


        /// <summary>
        /// Get a machine by the Machine ID provided.
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="DBDIR_Name"></param>
        /// <returns></returns>
        public static LicensedMachines GetByID(int Id, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                List<LicensedMachines> MachinesFound = connection.Query<LicensedMachines>("dbo.LicensedMachines_GetByID @ID", new { ID = Id }).ToList();
                return MachinesFound[0];
            }
        }

        public static List<LicensedMachines> GetByMachineName(string MachineName, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                string searchTerm = string.Format("%{0}%", MachineName);
                return connection.Query<LicensedMachines>("dbo.LicensedMachines_GetByMachineName @NAME", new { NAME = searchTerm }).ToList();
            }
        }
        #endregion



        #region Manual Procedures

        
        public static void UpdateLicensedMachineData(LicensedMachines License, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            string _InstallDate = License.InstallDate;

            string _MachineName = Utilities.CorrectApostropheForSQL(License.MachineName);
            string _MachineNotes = Utilities.CorrectApostropheForSQL(License.MachineNotes);
            // CorrectAprostopheForSQL will take ' and change it to '' so that it imports into the DB correctly.
            // Example: "Nathan's" is changed to "Nathan''s" so that it imports like "Nathan's".

            int _ID = License.Id;
            
            // Update SQL Table
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE LicensedMachinesTable SET InstallDate = '{_InstallDate}', MachineName = '{_MachineName}', MachineNotes = '{_MachineNotes}' WHERE Id = '{_ID}'";
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            sqlConnection1.Open();
            reader = command.ExecuteReader();

            sqlConnection1.Close();
        }

        public static void UpdateLicenseId(LicensedMachines License, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;

            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"UPDATE LicensedMachinesTable SET LicenseId = '{License.LicenseId}' WHERE Id = '{License.Id}'";
            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            sqlConnection1.Open();
            reader = command.ExecuteReader();

            sqlConnection1.Close();
        }

        public static void AddLicensedMachines(LicensedMachines MachineAdded, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            MachineAdded.MachineName = Utilities.CorrectApostropheForSQL(MachineAdded.MachineName);
            MachineAdded.MachineNotes = Utilities.CorrectApostropheForSQL(MachineAdded.MachineNotes);

            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"INSERT INTO LicensedMachinesTable (InstallDate, MachineName, MachineNotes, LicenseId) VALUES ('{MachineAdded.InstallDate}', '{MachineAdded.MachineName}', '{MachineAdded.MachineNotes}', '{MachineAdded.LicenseId}')";

            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            // open connection, run command, close connection.
            sqlConnection1.Open();
            reader = command.ExecuteReader();
            sqlConnection1.Close();
        }

        

        /// <summary>
        /// Delete a single machine
        /// </summary>
        /// <param name="id"></param>
        /// <param name="DBDIR_Name"></param>
        public static void DeleteLicensedMachine(int id, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"DELETE FROM LicensedMachinesTable WHERE Id = '{id}'";

            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            // open connection, run command, close connection.
            sqlConnection1.Open();
            reader = command.ExecuteReader();
            sqlConnection1.Close();
        }


        /// <summary>
        /// Delete a List of machines
        /// </summary>
        /// <param name="ListOfIDs"></param>
        /// <param name="DBDIR_Name"></param>
        public static void DeleteLicensedMachine(List<int> ListOfIDs, string DBDIR_Name)
        {
            // Set Cursor
            Cursor.Current = Cursors.WaitCursor;
            // Instantiate connections
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            // Setup/Run commands for each machine.
            foreach (int _ID in ListOfIDs)
            {
                command.CommandText = $"DELETE FROM LicensedMachinesTable WHERE Id = '{_ID}'";
                command.CommandType = CommandType.Text;
                command.Connection = sqlConnection1;

                sqlConnection1.Open();
                reader = command.ExecuteReader();
                sqlConnection1.Close();
            }
            
        }

        public static void DeleteLicensedMachineBYLicenseId(int Licenseid, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"DELETE FROM LicensedMachinesTable WHERE LicenseId = '{Licenseid}'";

            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            // open connection, run command, close connection.
            sqlConnection1.Open();
            reader = command.ExecuteReader();
            sqlConnection1.Close();
        }


        /// <summary>
        /// This is only used when the DB structure has changed.
        /// </summary>
        /// <param name="OldDBDir"></param>
        /// <param name="NewDBDir"></param>
        public static void CloneLicensedMachinesTable(string OldDB, string NewDB)
        {
            Cursor.Current = Cursors.WaitCursor;
            List<LicensedMachines> OldData = new List<LicensedMachines>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(OldDB)))
            {
                for (int i = 0; i < 57; i++)
                {
                    OldData = connection.Query<LicensedMachines>("dbo.LicensedMachines_GetByLicenseID @ID", new { ID = i }).ToList();
                }

            }

            foreach (LicensedMachines _LMachines in OldData)
            {
                _LMachines.MachineName = Utilities.CorrectApostropheForSQL(_LMachines.MachineName);
                _LMachines.MachineNotes = Utilities.CorrectApostropheForSQL(_LMachines.MachineNotes);

                // Create command for SQL server
                SqlConnection sqlConnection1 = new SqlConnection(Helper.CnnValCustom(NewDB));
                SqlDataReader reader;
                SqlCommand command = new SqlCommand();
                command.CommandText = $"INSERT INTO LicensedMachinesTable (InstallDate, MachineName, MachineNotes, LicenseId) VALUES ('{_LMachines.InstallDate}', '{_LMachines.MachineName}', '{_LMachines.MachineNotes}', '{_LMachines.LicenseId}')";

                command.CommandType = CommandType.Text;
                command.Connection = sqlConnection1;

                // open connection, run command, close connection.
                sqlConnection1.Open();
                reader = command.ExecuteReader();
                sqlConnection1.Close();
            }

        }


        /// <summary>
        /// Do not access this directly! Use Utilities.CheckDatabaseForUpdates
        /// </summary>
        /// <param name="Config"></param>
        /// <returns></returns>
        public static Version CheckForUpdates(ConfigClass Config)
        {
            Version CurrentVersion; // Declare Return Variable
            // Get the version of the program. The Database should reflect this version if up to date.
            Version SoftwareVersion = new Version(System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString());

            #region Check for v1.3 (Renamed 'DateAdded' Column to 'InstallDate')
            if (!DataAccess_LicensedMachinesTable.ColumnExists(Config.DBDir_Name, "InstallDate")
                && DataAccess_LicensedMachinesTable.ColumnExists(Config.DBDir_Name, "DateAdded"))
            {
                CurrentVersion = new Version("1.2.0.0");
                return CurrentVersion;
            }
            #endregion
            // Add more If's for newer version changes here.

            //
            else // Database Should be up to date
            {
                return SoftwareVersion;
            }
        }


        /// <summary>
        /// Do not access this directly! Use Utilities.CheckDatabaseForUpdates
        /// </summary>
        /// <param name="DBDIR_Name"></param>
        /// <param name="DBVer"></param>
        public static void Update(string DBDIR_Name, string DBVer)
        {
            switch (DBVer)
            {
                case "1.2.0.0": // Update to v1.3.0 from 1.2.0 (Changed Column "DateAdded" to "InstallDate")
                    Cursor.Current = Cursors.WaitCursor;
                    // Create command for SQL server
                    SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
                    SqlDataReader reader;
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"EXEC sp_RENAME 'LicensedMachinesTable.DateAdded', 'InstallDate', 'COLUMN'";
                    command.CommandType = CommandType.Text;
                    command.Connection = sqlConnection1;
                    // open connection, run command, close connection.
                    sqlConnection1.Open();
                    reader = command.ExecuteReader();
                    sqlConnection1.Close();
                    break;
            }
        }


        /// <summary>
        /// Checks if the given column name exists
        /// </summary>
        /// <param name="DBDIR_Name"></param>
        /// <param name="Column_Name"></param>
        /// <returns></returns>
        public static bool ColumnExists(string DBDIR_Name, string Column_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                try
                {
                    List<LicensedMachines> MachinesFound = connection.Query<LicensedMachines>($"SELECT TOP 1 {Column_Name} FROM LicensedMachinesTable").ToList();
                    return true;
                }
                catch(SqlException)
                {
                    return false;
                }
            }
            
        }

        #endregion
    }
}
