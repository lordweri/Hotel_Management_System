using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Data
{
    public class BookingDB:DB
    {
        #region Data members
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";
        private Collection<Booking> bookings; //stores all bookings in a collection(Similar our practical workshop, their have a collection in EmployeeDB.cs that stores all employees)
        #endregion

        #region Properties
        //Returns all bookings in a collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);

        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        //Get all bookings from the dataset and add them to the collection
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Booking booking;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                booking = new Booking();
                booking.BookingID = Convert.ToInt32(myRow["BookingID"]);
                booking.GuestID = Convert.ToInt32(myRow["GuestID"]);
                booking.roomNumber = Convert.ToInt32(myRow["RoomNumber"]);
                booking.start = Convert.ToDateTime(myRow["CheckInDate"]);
                booking.end = Convert.ToDateTime(myRow["CheckOutDate"]);
                booking.totalPrice = Convert.ToDouble(myRow["TotalPrice"]);
                booking.status = (BookingStatus)Enum.Parse(typeof(BookingStatus), myRow["Status"].ToString());
                bookings.Add(booking);
            }
        }

        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["BookingID"] = booking.bookingID;
                aRow["GuestID"] = booking.guest.guestID;
                aRow["RoomNumber"] = booking.roomNumber;
                aRow["CheckInDate"] = booking.start;
                aRow["CheckOutDate"] = booking.end;
                aRow["TotalPrice"] = booking.totalPrice;
                aRow["Status"] = booking.status;
            }
        }

        private int FindRow(Booking booking)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string bookingID = booking.bookingID;     //TODO: check later of variable name matchs with Booking class
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (bookingID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["BookingID"]))
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
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, booking, DB.DBOperation.Add);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(booking)];
                    FillRow(aRow, booking, DB.DBOperation.Edit);
                    break;
                case DB.DBOperation.Delete:
                    dsMain.Tables[table].Rows[FindRow(booking)].Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 50, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.Date);
            param.SourceColumn = "CheckInDate";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date);
            param.SourceColumn = "CheckOutDate";
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 50, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalPrice", SqlDbType.Money, 8, "TotalPrice");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("BookingID", SqlDbType.NVarChar, 50, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("CheckInDate", SqlDbType.Date);
            param.SourceColumn = "CheckInDate";
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("CheckOutDate", SqlDbType.Date);
            param.SourceColumn = "CheckOutDate";
            param.SourceVersion = DataRowVersion.Current;

            param = new SqlParameter("GuestID", SqlDbType.NVarChar, 50, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("RoomNumber", SqlDbType.NVarChar, 50, "RoomNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("TotalPrice", SqlDbType.Money, 8, "TotalPrice");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 50, "BookingID");
            daMain.DeleteCommand.Parameters.Add(param);
        }

        //Command that used to insert a booking in the database
        private void Create_INSERT_Command(Booking booking)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, CheckInDate, CheckOutDate, GuestID, RoomNumber, TotalPrice) VALUES (@BookingID, @CheckInDate, @CheckOutDate, @GuestID, @RoomNumber, @TotalPrice)", cnMain);
            Build_INSERT_Parameters(booking);
        }

        private void Create_UPDATE_Command(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, GuestID = @GuestID, RoomNumber = @RoomNumber, TotalPrice = @TotalPrice WHERE BookingID = @BookingID", cnMain);
            Build_UPDATE_Parameters(booking);
        }

        private void Create_DELETE_Command(Booking booking)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);
            Build_DELETE_Parameters(booking);
        }

        private bool UpdateDataSource(Booking booking, DB.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    Create_INSERT_Command(booking);
                    break;
                case DB.DBOperation.Edit:
                    Create_UPDATE_Command(booking);
                    break;
                case DB.DBOperation.Delete:
                    Create_DELETE_Command(booking);
                    break;
            }
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion
    }
}
