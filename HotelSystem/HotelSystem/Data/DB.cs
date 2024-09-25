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
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "  " + e.StackTrace);
            }
        }
        #endregion

        #region Update the data source
        //Updates the database with the changes made to the dataset
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try
            {
                cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "  " + e.StackTrace);
                success = false;
            }
            finally
            { }
            return success;
        }
        #endregion
    }
}