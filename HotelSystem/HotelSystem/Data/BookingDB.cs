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
    public class BookingDB:DB
    {
        #region Data members
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";

        private Collection<Booking> bookings; //stores all bookings in a collection(Similar to our practical workshop, their have a collection in EmployeeDB.cs that stores all employees)
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
        //Constructor to be used in Controller classes
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
                    decimal totalPrice = Convert.ToDecimal(bookingRow["TotalPrice"]);
                    decimal deposit = totalPrice * 0.1m;
                    //BookingStatus status = (BookingStatus)Enum.Parse(typeof(BookingStatus), bookingRow["Status"].ToString());
                    BookingStatus status = BookingStatus.Confirmed;    //hard coded for now
                    //RoomType roomType = (RoomType)Enum.Parse(typeof(RoomType), bookingRow["RoomType"].ToString());
                    RoomType roomType = RoomType.Single;               //hard coded for now

                    Guest guest = FindGuestByID(guestID);
                    Room room = FindRoomByNumber(roomNumber);

                    Booking booking = new Booking(bookingID, guest, roomType, room, start, end, totalPrice, deposit, status);
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
                string telephone = Convert.ToString(guestRows[0]["ContactNumber"]);
                string address = Convert.ToString(guestRows[0]["Address"]);
                return new Guest(guestID, name, email, telephone, address); //return guest object if found
            }
            return null; //return null if not found
        }

        //Find a room in the database by room number and return a Room object
        private Room FindRoomByNumber(string roomNumber)
        {
            DataRow[] roomRows = dsMain.Tables["Room"].Select($"RoomNumber = '{roomNumber}'");
            if (roomRows.Length > 0)
            {
                double rate = Convert.ToDouble(roomRows[0]["RoomRate"]);
                Boolean availability = Convert.ToBoolean(roomRows[0]["IsAvailable"]);  
                return new Room(roomNumber, rate, availability); //return room object if found
            }
            return null; //return null if not found
        }

        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["BookingID"] = booking.GetBookingID();
                aRow["GuestID"] = booking.GetGuest().getGuestID();
                aRow["RoomNumber"] = booking.GetRoom().getRoomNo();
                aRow["CheckInDate"] = booking.GetRange().GetStart();
                aRow["CheckOutDate"] = booking.GetRange().GetStart();
                aRow["TotalPrice"] = booking.totalPrice;
                aRow["Status"] = booking.GetType().ToString();
                aRow["RoomType"] = booking.GetRoom().getType();
            }
        }

        private int FindRow(Booking booking)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string bookingID = booking.GetBookingID();     //TODO: check later of variable name matchs with Booking class
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
        // method to get all rooms from the database table-BRWCAL007
        public DataRow[] GetRoomRows()
        {
            try
            {
                DataTable roomTable = dsMain.Tables["Room"];
                if (roomTable == null)
                {
                    throw new Exception("Table 'Room' not found in the DataSet.");
                }

                DataRow[] roomRows = roomTable.Select();
                if (roomRows == null || roomRows.Length == 0)
                {
                    throw new Exception("No rows found in table 'Room'.");
                }

                return roomRows;
            }
            catch (Exception ex)
            {
                // Handle the exception or log the error
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }


        // Method to get the total number of rooms from the database-BRWCAL007
        public int GetTotalRoomCount(DataRow[] roomRows)
        {
            if (roomRows == null)
            {
                // Handle the case when roomRows is null
                // You can return a default value or throw an exception, depending on your requirements
                return 0;
            }

            return roomRows.Length;
        }
        public int GetTotalRoomCount()
        {
            DataRow[] roomRows = dsMain.Tables["Room"].Select();
            if (roomRows == null)
            {
                // Handle the case when roomRows is null
                // You can return a default value or throw an exception, depending on your requirements
                return 0;
            }

            return roomRows.Length;
        }



        #endregion

        #region Database operations CRUD
        //Add, Edit or Delete a booking in the Booking DataSet
        // with added error handling-BRWCAL007
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            if (booking == null)
            {
                throw new ArgumentNullException(nameof(booking), "Booking object cannot be null.");
            }

            try
            {
                DataRow aRow = null;
                switch (operation)
                {
                    case DB.DBOperation.Add:
                        if (dsMain.Tables[table] == null)
                        {
                            throw new InvalidOperationException($"Table '{table}' not found in the DataSet.");
                        }
                        aRow = dsMain.Tables[table].NewRow();
                        FillRow(aRow, booking, DB.DBOperation.Add);
                        dsMain.Tables[table].Rows.Add(aRow);
                        break;

                    case DB.DBOperation.Edit:
                        int rowIndex = FindRow(booking);
                        if (rowIndex == -1)
                        {
                            throw new InvalidOperationException($"Booking with ID {booking.GetBookingID()} not found in the DataSet.");
                        }
                        aRow = dsMain.Tables[table].Rows[rowIndex];
                        FillRow(aRow, booking, DB.DBOperation.Edit);
                        break;

                    case DB.DBOperation.Delete:
                        int deleteRowIndex = FindRow(booking);
                        if (deleteRowIndex == -1)
                        {
                            throw new InvalidOperationException($"Booking with ID {booking.GetBookingID()} not found in the DataSet.");
                        }
                        dsMain.Tables[table].Rows[deleteRowIndex].Delete();
                        break;

                    default:
                        throw new ArgumentException($"Unsupported database operation: {operation}", nameof(operation));
                }
            }
            catch (Exception ex)
            {
                // Log the exception
                Console.WriteLine($"An error occurred in DataSetChange: {ex.Message}");
                // Optionally, rethrow the exception if you want it to propagate
                throw new Exception("An error occurred while modifying the booking data.", ex);
            }
        }
        #endregion

        //Contains the UpdateDataSource() method to be used in the Controller classes
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

            param = new SqlParameter("@Deposit", SqlDbType.Money, 8, "Deposit");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NVarChar, 50, "Status");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 50, "Status");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Booking booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 50, "BookingID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.Date);
            param.SourceColumn = "CheckInDate";
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.Date);
            param.SourceColumn = "CheckOutDate";
            param.SourceVersion = DataRowVersion.Current;

            param = new SqlParameter("@GuestID", SqlDbType.NVarChar, 50, "GuestID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 50, "RoomNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalPrice", SqlDbType.Money, 8, "TotalPrice");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.NVarChar, 50, "Status");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomType", SqlDbType.NVarChar, 50, "RoomType");
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
            daMain.InsertCommand = new SqlCommand("INSERT into Booking (BookingID, CheckInDate, CheckOutDate, GuestID, RoomNumber, TotalPrice, Deposit, Status, RoomType) VALUES (@BookingID, @CheckInDate, @CheckOutDate, @GuestID, @RoomNumber, @TotalPrice, @Deposit, @Status, @RoomType)", cnMain);
            Build_INSERT_Parameters(booking);
        }

        private void Create_UPDATE_Command(Booking booking)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, GuestID = @GuestID, RoomNumber = @RoomNumber, TotalPrice = @TotalPrice, Deposit = @Deposit, Status = @Status, RoomType = @RoomType WHERE BookingID = @BookingID", cnMain);
            Build_UPDATE_Parameters(booking);
        }

        private void Create_DELETE_Command(Booking booking)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Booking WHERE BookingID = @BookingID", cnMain);
            Build_DELETE_Parameters(booking);
        }

        //Commit changes to the database
        public bool UpdateDataSource(Booking booking, DB.DBOperation operation)
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
