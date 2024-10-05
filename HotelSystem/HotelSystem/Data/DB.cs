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
        //added error handling-BRWCAL007
        public void FillDataSet(string aSQLstring, string aTable)
        {
            if (string.IsNullOrWhiteSpace(aSQLstring) || string.IsNullOrWhiteSpace(aTable))
            {
                throw new ArgumentException("SQL string and table name must not be empty.");
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
                MessageBox.Show($"SQL Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the error or perform additional error handling as needed
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show($"Invalid Operation: {ioEx.Message}", "Operation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        //added error handling-BRWCAL007
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            if (string.IsNullOrWhiteSpace(sqlLocal) || string.IsNullOrWhiteSpace(table))
            {
                throw new ArgumentException("SQL string and table name must not be empty.");
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
                MessageBox.Show($"SQL Error: {sqlEx.Message}\nError Code: {sqlEx.Number}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the error or perform additional error handling as needed
            }
            catch (DBConcurrencyException concurrencyEx)
            {
                MessageBox.Show($"Concurrency Error: {concurrencyEx.Message}", "Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Handle concurrency issues, possibly by refreshing data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show($"Error refreshing data: {fillEx.Message}", "Refresh Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        success = false;
                    }
                }
            }
            return success;
        }
        #endregion
    }
}