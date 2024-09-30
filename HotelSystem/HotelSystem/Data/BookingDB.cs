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
    //This class allows CRUD operations on the Booking table
    public class BookingDB:DB
    {
        #region Data members
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";

        private string guestTable = "Guest";
        private string guestSqlLocal = "SELECT * FROM Booking";

        private string roomTable = "Room";
        private string roomSqlLocal = "SELECT * FROM Booking";

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
            DataRow bookingRow = null;
            foreach (DataRow bookingRow_loopVariable in dsMain.Tables[table].Rows)
            {
                bookingRow = bookingRow_loopVariable;
                if (!(bookingRow.RowState == DataRowState.Deleted))
                {
                    //attributes of Booking table
                    string bookingID = Convert.ToString(bookingRow["BookingID"]);
                    string guestID = Convert.ToString(bookingRow["GuestID"]);
                    string roomNumber = Convert.ToString(bookingRow["RoomNumber"]);
                    DateTime start = Convert.ToDateTime(bookingRow["CheckInDate"]);
                    DateTime end = Convert.ToDateTime(bookingRow["CheckOutDate"]);
                    double totalPrice = Convert.ToDouble(bookingRow["TotalPrice"]);
                    BookingStatus status = (BookingStatus)Enum.Parse(typeof(BookingStatus), bookingRow["Status"].ToString());

                    Guest guest = FindGuestByID(guestID);
                    Room room = FindRoomByNumber(roomNumber);

                    Booking booking = new Booking(bookingID, guest, room, start, end);
                    bookings.Add(booking);
                }
            }
        }
        
        //Find a guest in the database by ID and return a Guest object
        private Guest FindGuestByID(string guestID)
        {
            DataRow[] guestRows = dsMain.Tables["Guest"].Select($"GuestID = '{guestID}'");
            if (guestRows.Length > 0)
            {
                string name = Convert.ToString(guestRows[0]["Name"]);
                string email = Convert.ToString(guestRows[0]["Email"]);
                string telephone = Convert.ToString(guestRows[0]["Telephone"]);
                return new Guest(guestID, name, email, telephone); //return guest object if found
            }
            return null; //return null if not found
        }

        //Find a room in the database by room number and return a Room object
        private Room FindRoomByNumber(string roomNumber)
        {
            DataRow[] roomRows = dsMain.Tables["Room"].Select($"RoomNumber = '{roomNumber}'");
            if (roomRows.Length > 0)
            {
                double rate = Convert.ToDouble(roomRows[0]["Rate"]);
                Boolean availability = Convert.ToBoolean(roomRows[0]["Availability"]);  
                return new Room(roomNumber, rate, availability); //return room object if found
            }
            return null; //return null if not found
        }

        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["BookingID"] = booking.bookingID;
                aRow["GuestID"] = booking.guest.GuestID;
                aRow["RoomNumber"] = booking.room.RoomNo;
                aRow["CheckInDate"] = booking.range.Start;
                aRow["CheckOutDate"] = booking.range.End;
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

        //Commit changes to the database
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
