using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42LicenseManager
{
    class DataAccess_ChangeLogTable
    {
        // 
        // Stored Procedures
        //
        public List<LogClass> GetLogs_ByLicenseId(int LicenseId, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<LogClass>("dbo.ChangeLog_GetByID @LicenseID", new { LicenseID = LicenseId }).ToList();
            }
        }

        public List<LogClass> GetLogs_GetAllLogs(string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                return connection.Query<LogClass>("dbo.ChangeLog_GetAll").ToList();
            }
        }

        //
        // Manual Procedures
        // 

        public static void CreateNewLog(LogClass Log, string DBDIR_Name)
        {
            int attempts = 0;
            string Error = "Unknown Error";
            while (attempts <= 3)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    Log.Log = Utilities.CorrectApostropheForSQL(Log.Log);

                    // Create command for SQL server
                    SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
                    SqlDataReader reader;
                    SqlCommand command = new SqlCommand();
                    command.CommandText = $"INSERT INTO ChangeLogTable (Date, LicenseId, Log) VALUES (@date, @licenseid, @log)";
                    command.Parameters.AddWithValue("@date", $"{Log.Date}");
                    command.Parameters.AddWithValue("@licenseid", $"{Log.LicenseId}");
                    command.Parameters.AddWithValue("@log", $"{Log.Log}");


                    command.CommandType = CommandType.Text;
                    command.Connection = sqlConnection1;

                    // open connection, run command, close connection.
                    sqlConnection1.Open();
                    reader = command.ExecuteReader();
                    sqlConnection1.Close();
                    attempts = 10; // Success!
                }
                catch (SqlException error) // Typically means the DB service hasn't finished closing yet or isn't started. Or the string is too long.
                {
                    if (error.Message.Contains("String or binary data would be truncated"))
                    {
                        Error = "Client name is too long.";
                    }
                    else
                    {
                        Thread.Sleep(500);
                        Error = error.Message.ToString();
                    }
                }
                catch (Exception error)
                {
                    Error = error.ToString();
                }
            }
            if (attempts == 4)
            {
                MessageBox.Show($"Unable to Create log. \nFailed after {attempts} attempts. \nError: {Error}", "Error!");
            }
        }

        public void DeleteLog(int id, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"DELETE FROM ChangeLogTable WHERE Id = '{id}'";

            command.CommandType = CommandType.Text;
            command.Connection = sqlConnection1;

            // open connection, run command, close connection.
            sqlConnection1.Open();
            reader = command.ExecuteReader();
            sqlConnection1.Close();
        }

        public static void DeleteLogByLicenseID(int LicenseId, string DBDIR_Name)
        {
            Cursor.Current = Cursors.WaitCursor;
            // Create command for SQL server
            SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(DBDIR_Name)));
            SqlDataReader reader;
            SqlCommand command = new SqlCommand();
            command.CommandText = $"DELETE FROM ChangeLogTable WHERE LicenseId = '{LicenseId}'";

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
        public static void CloneLogsTable(string OldDB, string NewDB)
        {
            Cursor.Current = Cursors.WaitCursor;
            // GET OLD DATA
            List<LogClass> OldData;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(OldDB)))
            {
                OldData = connection.Query<LogClass>("dbo.GDataDB_GetAllLogs").ToList();
            }

            foreach(LogClass _log in OldData)
            {
                // CREATE NEW LOG IN DB
                SqlConnection sqlConnection1 = new SqlConnection((Helper.CnnValCustom(NewDB)));
                SqlDataReader reader;
                SqlCommand command = new SqlCommand();
                command.CommandText = $"INSERT INTO ChangeLogTable (Date, LicenseId, Log) VALUES (@date, @licenseid, @log)";
                command.Parameters.AddWithValue("@date", $"{_log.Date}");
                command.Parameters.AddWithValue("@licenseid", $"{_log.LicenseId}");
                command.Parameters.AddWithValue("@log", $"{_log.Log}");


                command.CommandType = CommandType.Text;
                command.Connection = sqlConnection1;

                // open connection, run command, close connection.
                sqlConnection1.Open();
                reader = command.ExecuteReader();
                sqlConnection1.Close();
            }
            
        }

        public static List<LogClass> GetByDate(string DBDIR_Name, string SearchWord)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                try
                {
                    var searchdate = DateTime.Parse(SearchWord);

                    {
                        return connection.Query<LogClass>($"SELECT * FROM dbo.ChangeLogTable WHERE Date LIKE '%{searchdate}%'").ToList();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    return null;
                }
            }
        }

        public static List<LogClass> GetByName(string DBDIR_Name, string SearchWord)
        {
            Cursor.Current = Cursors.WaitCursor;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnValCustom(DBDIR_Name)))
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    {
                        return connection.Query<LogClass>($"SELECT * FROM dbo.ChangeLogTable WHERE log LIKE '%{SearchWord}%'").ToList();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                    return null;
                }
            }
        }
    }
}
