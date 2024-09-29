using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Data
{
    public class GuestDB : DB
    {
        #region Data members
        private string table = "Guest";
        private string sqlLocal = "SELECT * FROM Guest";
        private Collection<Room> guests; //stores all rooms in a collection(Similar our practical workshop, their have a collection in EmployeeDB.cs that stores all employees)
        #endregion

        #region Properties
        //Returns all rooms in a collection
        public Collection<Room> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        public GuestDB() : base()
        {
            guests = new Collection<Room>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        //TODO: Add2Collection method
        //Adds all rooms to the collection
        private void Add2Collection(string table) 
        {
            DataRow myRow = null;
            Guest guest;
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                string name = row["Name"].ToString();
                string guestID = row["GuestID"].ToString();
                string telephone = row["Telephone"].ToString();
                string email = row["Email"].ToString();
                guest = new Guest();   //TODO adjust according to Guest class
                guests.Add(guest);
            }

        }

        //TODO: Adjust variable names according to Guest class
        private void FillRow(DataRow row, Guest guest, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                row["Name"] = guest.Name;
                row["GuestID"] = guest.GuestID;
                row["Telephone"] = guest.Telephone;
                row["Email"] = guest.Email;
            }
        }

        private int FindRow(Guest aGuest)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string guestID = aGuest.guestID;      //TODO adjust according to Guest class
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (guestID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["GuestID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database operations CRUD
        public void DataSetChange(Guest aGuest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aGuest, DB.DBOperation.Add);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aGuest)];
                    FillRow(aRow, aGuest, DB.DBOperation.Edit);
                    break;
                case DB.DBOperation.Delete:
                    dsMain.Tables[table].Rows[FindRow(aGuest)].Delete();
                    break;
            }
        }

    }
