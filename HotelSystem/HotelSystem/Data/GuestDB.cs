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
    //This class allows CRUD operations on the Guest table in the database
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

        //TODO: Adjust variable names according to Guest class and final database
        private void FillRow(DataRow row, Guest guest, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                row["Name"] = guest.Name;
                row["Surname"] = guest.Surname;
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
        #endregion

        //TODO might need to adjust attribute names according to the final database and Guest class
        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 50, "Surname");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Telephone", SqlDbType.NVarChar, 50, "Telephone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 50, "Surname");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Telephone", SqlDbType.NVarChar, 50, "Telephone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 50, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Guest aGuest)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Guest (GuestID, Name, Telephone, Email) VALUES (@GuestID, @Name, @Telephone, @Email)", cnMain);
            Build_INSERT_Parameters(aGuest);
        }

        private void Create_UPDATE_Command(Guest aGuest)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Guest SET Name = @Name, Surname = @Surname, Telephone = @Telephone, Email = @Email WHERE GuestID = @GuestID", cnMain);
            Build_UPDATE_Parameters(aGuest);
        }

        private void Create_DELETE_Command(Guest aGuest)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guest WHERE GuestID = @GuestID", cnMain);
            Build_DELETE_Parameters(aGuest);
        }

        public bool UpdateDataSource(Guest guest, DB.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case DBOperation.Add:
                    Create_INSERT_Command(guest);
                    break;
                case DBOperation.Edit:
                    Create_UPDATE_Command(guest);
                    break;
                case DBOperation.Delete:
                    Create_DELETE_Command(guest);
                    break;
            }
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion
    }
}
