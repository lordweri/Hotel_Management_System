using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Business;

namespace HotelSystem.Data
{
    public class GuestDB : DB
    {
        #region Data members
        private string table = "Guest";
        private string sqlLocal = "SELECT * FROM Guest";
        private Collection<Guest> guests; //stores all rooms in a collection(Similar to our practical workshop, their have a collection in EmployeeDB.cs that stores all employees)
        #endregion

        #region Properties
        //Returns all rooms in a collection
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        //Constructor to be used in Controller classes
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        //Adds all guests from the database to guests collection
        private void Add2Collection(string table)
        {
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    string name = row["Name"].ToString().Trim();
                    string guestID = row["GuestID"].ToString().Trim();
                    string ContactNumber = row["ContactNumber"].ToString().Trim();
                    string email = row["Email"].ToString().Trim();
                    string address = row["Address"].ToString().Trim();
                    Guest guest = new Guest(guestID, name, email, ContactNumber, address); 
                    guests.Add(guest);
                }
            }

        }

        //Adjust variable names according to Guest class and final database
        private void FillRow(DataRow row, Guest guest, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                row["Name"] = guest.getName();
                row["GuestID"] = guest.getGuestID();
                row["ContactNumber"] = guest.getPhone();
                row["Email"] = guest.getEmail();
                row["Address"] = guest.getAddress();
            }
        }

        //Find a guest in the dataset
        private int FindRow(Guest aGuest)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string guestID = aGuest.getGuestID();
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
        // with added error handling-BRWCAL007
        public void DataSetChange(Guest aGuest, DB.DBOperation operation)
        {
            if (aGuest == null)
            {
                throw new ArgumentNullException(nameof(aGuest), "Guest cannot be null.");
            }

            try
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
                        int rowIndex = FindRow(aGuest);
                        if (rowIndex == -1)
                        {
                            throw new InvalidOperationException($"Guest with ID {aGuest.getGuestID()} not found for editing.");
                        }
                        aRow = dsMain.Tables[table].Rows[rowIndex];
                        FillRow(aRow, aGuest, DB.DBOperation.Edit);
                        break;
                    case DB.DBOperation.Delete:
                        int deleteRowIndex = FindRow(aGuest);
                        if (deleteRowIndex == -1)
                        {
                            throw new InvalidOperationException($"Guest with ID {aGuest.getGuestID()} not found for deletion.");
                        }
                        dsMain.Tables[table].Rows[deleteRowIndex].Delete();
                        break;
                    default:
                        throw new ArgumentException($"Unsupported operation: {operation}", nameof(operation));
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"Error in DataSetChange: {ex.Message}");
                // Optionally, rethrow the exception if you want it to propagate
                throw new Exception("An error occurred while modifying the guest data.", ex);
            }
        }
        #endregion

        //Contains the UpdateDataSource() method to be used in the Controller classes
        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 50, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 50, "ContactNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
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

            param = new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 50, "ContactNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
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
            daMain.InsertCommand = new SqlCommand("INSERT into Guest (GuestID, Name, ContactNumber, Email, Address) VALUES (@GuestID, @Name, @ContactNumber, @Email, @Address)", cnMain);
            Build_INSERT_Parameters(aGuest);
        }

        private void Create_UPDATE_Command(Guest aGuest)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Guest SET Name = @Name, ContactNumber = @ContactNumber, Email = @Email, Address = @Address WHERE GuestID = @GuestID", cnMain);
            Build_UPDATE_Parameters(aGuest);
        }

        private void Create_DELETE_Command(Guest aGuest)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Guest WHERE GuestID = @GuestID", cnMain);
            Build_DELETE_Parameters(aGuest);
        }

        //Commit the changes to the database
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
