using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    class DataAccess_GDataTable
    {
        public static List<License> GetByLastName(string lastName, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<License>("dbo.GDataDB_GetByLastName @LastName", new { LastName = lastName }).ToList();
            }
        }
        /// <summary>
        /// This works for Company Name, First, Last or even part of them.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="DBDIR_Name"></param>
        /// <returns></returns>
        public static List<License> GetByName(string name, string DBDIR_Name) // This works for first and/or last name and/or Company Name
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                string searchTerm = string.Format("%{0}%", name);
                return connection.Query<License>("dbo.GDataDB_GetByName @Name", new {Name = searchTerm}).ToList();
            }
        }
        public static License GetByID(int Id, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                List<License> licenses = connection.Query<License>("dbo.GDataDB_GetById @MyID", new { MyID = Id }).ToList();
                //return connection.Query<License>("dbo.GDataDB_GetById @MyID", new { MyID = Id }).ToList();
                return licenses[0];
            }
        }
        public static List<License> GetAllData(string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<License>("dbo.GDataDB_GetAllData").ToList();
            }
        }

        public static List<License> GetByReviewStatus(string _status, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<License>("dbo.GDataDB_GetByReviewStatus @Status", new { Status = _status }).ToList();
            }
        }
        public static List<License> GetLatestEntry(string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<License>("dbo.GDataDB_GetLatestEntry").ToList();
            }
        }

        //
        // Manual Procedures
        // 

        /// <summary>
        /// Will update an item in the SQL DB using the 'SelectedLicense' passed in based on the 'SelectedLicense' ID. 
        /// This will surely break things if there is no ID or the ID is incorrect.
        /// The ID must be in SelectedLicense.Id
        /// </summary>
        /// <param name="SelectedLicense"></param>
        /// <param name="DBDIR_Name"></param>
        public static void UpdateLicenseData(License SelectedLicense, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                // CorrectAprostopheForSQL will take ' and change it to '' so that it imports into the DB correctly.
                // Example: "Nathan's" is changed to "Nathan''s" so that it imports like "Nathan's".
                string _CompanyName = Utilities.CorrectApostropheForSQL(SelectedLicense.CompanyName);
                string _FirstName = Utilities.CorrectApostropheForSQL(SelectedLicense.FirstName);
                string _LastName = Utilities.CorrectApostropheForSQL(SelectedLicense.LastName);
                string _ReviewStatus = SelectedLicense.ReviewStatus;
                DateTime ExpDate = SelectedLicense.ExpirationDate;
                int _PCCount = SelectedLicense.PCCount;
                string _RenewalStatus = SelectedLicense.RenewalStatus;
                bool _Active = SelectedLicense.Active;
                string _Notes = Utilities.CorrectApostropheForSQL(SelectedLicense.Notes);
                int _ID = SelectedLicense.Id;
                bool _ChkBxWillCancel = SelectedLicense.ChkBxWillCancel;
                bool _ChkBxUninstalled = SelectedLicense.ChkBxUninstalled;
                bool _ChkBxDeleted = SelectedLicense.ChkBxDeleted;
                // Create command for SQL server
                SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
                SqlDataReader reader;
                SqlCommand command = new SqlCommand();
                command.CommandText = $"UPDATE GDataTable SET ReviewStatus = '{_ReviewStatus}', CompanyName = '{_CompanyName}', FirstName = '{_FirstName}', LastName = '{_LastName}', ExpirationDate = '{ExpDate}', PCCount = '{_PCCount}', RenewalStatus = '{_RenewalStatus}', Active = '{_Active}', Notes = '{_Notes}', ChkBxWillCancel = '{_ChkBxWillCancel}', ChkBxUninstalled = '{_ChkBxUninstalled}', ChkBxDeleted = '{_ChkBxDeleted}' WHERE Id = '{_ID}'";
                command.CommandType = CommandType.Text;
                command.Connection = sqlConnection1;

                sqlConnection1.Open();
                reader = command.ExecuteReader();

                sqlConnection1.Close();
            }
            catch(SqlException e)
            {
                if (e.Message.Contains("Invalid column name 'PCCount'."))
                {
                    //System.Windows.Forms.MessageBox.Show("Database has been altered and the PCLiensed table no longer exists");

                }
            }
        }

        public static void CreateNewLicense(License NewLicense, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            License CorrectedLicense = new License();
            // SET DATA INTO TEMP LICENSE and verify data is in correct format.
            CorrectedLicense.CompanyName = Utilities.CorrectApostropheForSQL(NewLicense.CompanyName);
            CorrectedLicense.FirstName = Utilities.CorrectApostropheForSQL(NewLicense.FirstName);
            CorrectedLicense.LastName = Utilities.CorrectApostropheForSQL(NewLicense.LastName);
            CorrectedLicense.ReviewStatus = NewLicense.ReviewStatus;
            CorrectedLicense.ExpirationDate = NewLicense.ExpirationDate;
            CorrectedLicense.PCCount = NewLicense.PCCount;
            CorrectedLicense.RenewalStatus = NewLicense.RenewalStatus;
            CorrectedLicense.Active = NewLicense.Active;
            CorrectedLicense.Notes = Utilities.CorrectApostropheForSQL(NewLicense.Notes);
            CorrectedLicense.Id = NewLicense.Id;
            CorrectedLicense.ChkBxWillCancel = NewLicense.ChkBxWillCancel;
            CorrectedLicense.ChkBxUninstalled = NewLicense.ChkBxUninstalled;
            CorrectedLicense.ChkBxDeleted = NewLicense.ChkBxDeleted;
            // Create INSERT command for SQL server (This saves data to the SQL DB)
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"INSERT INTO GDataTable (ReviewStatus, CompanyName, FirstName, LastName, ExpirationDate, PCCount, RenewalStatus, Active, Notes, ChkBxWillCancel, ChkBxUninstalled, ChkBxDeleted) VALUES ('{CorrectedLicense.ReviewStatus}', '{CorrectedLicense.CompanyName}', '{CorrectedLicense.FirstName}', '{CorrectedLicense.LastName}', '{CorrectedLicense.ExpirationDate}', '{CorrectedLicense.PCCount}', '{CorrectedLicense.RenewalStatus}', '{CorrectedLicense.Active}', '{CorrectedLicense.Notes}','{CorrectedLicense.ChkBxWillCancel}','{CorrectedLicense.ChkBxUninstalled}','{CorrectedLicense.ChkBxDeleted}')";

            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            // open connection, run command, close connection.
            sqlConnection1.Open();
            try
            {
                reader = command.ExecuteReader();
            }
            catch (System.Data.SqlClient.SqlException err)
            {
                if (err.Message.Contains("String or binary data would be truncated"))
                {
                    MessageBox.Show("Client name is too long.");
                }
                return;
            }
            
            sqlConnection1.Close();
        }

        public static void DeleteLicense(int id, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"DELETE FROM GDataTable WHERE Id = '{id}'";

            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            // open connection, run command, close connection.
            sqlConnection1.Open();
            reader = command.ExecuteReader();
            sqlConnection1.Close();
        }

        public static void ResetIDCount(string DBDIR_Name, string TableNameToReset)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"DBCC CHECKIDENT ({TableNameToReset}, RESEED, 0)";

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
        public static void MoveDBtoNewDB(string OldDBDir, string NewDBDir)
        {
            List<License> OldLicenseData = DataAccess_GDataTable.GetAllData(OldDBDir);


            for (int i = 0; i < OldLicenseData.Count; i++)
            {
                foreach(License _Lic in OldLicenseData)
                {
                    if (_Lic.Id == i)
                    {
                        string _CompanyName = Utilities.CorrectApostropheForSQL(_Lic.CompanyName);
                        string _FirstName = Utilities.CorrectApostropheForSQL(_Lic.FirstName);
                        string _LastName = Utilities.CorrectApostropheForSQL(_Lic.LastName);
                        string _ReviewStatus = _Lic.ReviewStatus;
                        DateTime ExpDate = _Lic.ExpirationDate;
                        int _PCCount = _Lic.PCCount;
                        string _RenewalStatus = _Lic.RenewalStatus;
                        bool _Active = _Lic.Active;
                        string _Notes = Utilities.CorrectApostropheForSQL(_Lic.Notes);
                        int _ID = _Lic.Id;
                        bool _ChkBxWillCancel = _Lic.ChkBxWillCancel;
                        bool _ChkBxUninstalled = _Lic.ChkBxUninstalled;
                        bool _ChkBxDeleted = _Lic.ChkBxDeleted;

                        // Create command for SQL server
                        SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(NewDBDir)));
                        SqlDataReader reader;
                        SqlCommand command = new SqlCommand();
                        command.CommandText = $"INSERT INTO GDataTable (ReviewStatus, CompanyName, FirstName, LastName, ExpirationDate, PCCount, RenewalStatus, Active, Notes) VALUES ('{_ReviewStatus}', '{_CompanyName}', '{_FirstName}', '{_LastName}', '{ExpDate}', '{_PCCount}', '{_RenewalStatus}', '{_Active}', '{_Notes}','{_ChkBxWillCancel}','{_ChkBxUninstalled}','{_ChkBxDeleted}')";
                        command.CommandType = CommandType.Text;
                        command.Connection = sqlConnection1;

                        sqlConnection1.Open();
                        reader = command.ExecuteReader();

                        sqlConnection1.Close();
                    }
                }
            }

        }
    }
}
