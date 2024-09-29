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
            bookings.Clear();
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

        private int FindRow(string bookingID)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
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

    }
        #endregion

        #region Database operations CRUD
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            int aRowID = 0;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, booking, DB.DBOperation.Add);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRowID = FindRow(booking.bookingID);
                    aRow = dsMain.Tables[table].Rows[aRowID];
                    FillRow(aRow, booking, DB.DBOperation.Edit);
                    break;
                case DB.DBOperation.Delete:
                    aRowID = FindRow(booking.bookingID);
                    aRow = dsMain.Tables[table].Rows[aRowID];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("BookingID", SqlDbType.NVarChar, 50);
    }

        private void Build_UPDATE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter(

        }

        private void Build_DELETE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter(

        }

        private void Create_INSERT_Command()
        {

        }

        private void Create_UPDATE_Command()
        {

        }

        private void Create_DELETE_Command()
        {

        }

        private void UpdateDataSource(string sqlLocal, string table)
        {

        }
    }
}
