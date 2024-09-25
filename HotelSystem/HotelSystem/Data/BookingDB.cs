using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
                booking.RoomID = Convert.ToInt32(myRow["RoomID"]);
                booking.StartDate = Convert.ToDateTime(myRow["StartDate"]);
                booking.EndDate = Convert.ToDateTime(myRow["EndDate"]);
                booking.TotalPrice = Convert.ToDouble(myRow["TotalPrice"]);
                booking.Status = (BookingStatus)Enum.Parse(typeof(BookingStatus), myRow["Status"].ToString());
                bookings.Add(booking);
            }
        }

        private void FillRow(DataRow aRow, Booking booking, DB.DBOperation operation)
        {

        }

        private int FindRow(int BookingID)
        {

        }
        #endregion

        #region Database operations CRUD
        public void DataSetChange()
        { }

        #endregion

        #region Build Parameters, Create Commands & Update database
        
    }
}
