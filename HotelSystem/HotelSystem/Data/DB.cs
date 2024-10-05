using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HotelSystem.Properties;
using System.Windows.Forms;

namespace HotelSystem.Data
{
    public class DB
    {
        #region Variable declaretion
        private string strConn = Settings.Default.HotelDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
        public enum DBOperation
        {
            Add,
            Edit,
            Delete
        }
        #endregion

        #region Constructor
        //Open the connection to the database and create the dataset
        public DB()
        {
            try
            {
                cnMain = new SqlConnection(strConn);
                dsMain = new DataSet();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message, "Error");
                return;
            }
        }
        #endregion

        #region Update the DataSet
        //Fills the dataset with the data from the database for the given SQL string and table name
        // added error handling-BRWCAL007
        public void FillDataSet(string aSQLstring, string aTable)
        {
            if (string.IsNullOrEmpty(aSQLstring) || string.IsNullOrEmpty(aTable))
            {
                throw new ArgumentException("SQL string and table name must not be null or empty.");
            }

            try
            {
                using (daMain = new SqlDataAdapter(aSQLstring, cnMain))
                {
                    cnMain.Open();
                    //dsMain.Clear();
                    daMain.Fill(dsMain, aTable);
                }
            }
            catch (SqlException sqlEx)
            {
                LogError("SQL error occurred in FillDataSet", sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                LogError("Unexpected error occurred in FillDataSet", ex);
                throw;
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                {
                    cnMain.Close();
                }
            }
        }
        #endregion

        #region Update the data source
        //Updates the database with the changes made to the dataset
        // added error handling-BRWCAL007
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            if (string.IsNullOrEmpty(sqlLocal) || string.IsNullOrEmpty(table))
            {
                throw new ArgumentException("SQL string and table name must not be null or empty.");
            }

            bool success = false;
            try
            {
                cnMain.Open();
                daMain.Update(dsMain, table);
                success = true;
            }
            catch (SqlException sqlEx)
            {
                LogError($"SQL error occurred in UpdateDataSource for table {table}", sqlEx);
                throw;
            }
            catch (Exception ex)
            {
                LogError($"Unexpected error occurred in UpdateDataSource for table {table}", ex);
                throw;
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                {
                    cnMain.Close();
                }

                if (success)
                {
                    try
                    {
                        FillDataSet(sqlLocal, table);
                    }
                    catch (Exception fillEx)
                    {
                        LogError($"Error occurred while refreshing dataset for table {table}", fillEx);
                        success = false;
                    }
                }
            }
            return success;
        }
        #endregion

        private void LogError(string message, Exception ex)
        {
            // Log the error to a file or database
            string errorMessage = $"{DateTime.Now}: {message}. Error: {ex.Message}";
            // TODO: Implement actual logging mechanism
            Console.WriteLine(errorMessage); // Placeholder for actual logging

            // Display a user-friendly message
            MessageBox.Show("An error occurred. Please contact support if the problem persists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}