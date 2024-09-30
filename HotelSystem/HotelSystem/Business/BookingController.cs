using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Data;

namespace HotelSystem.Business
{
    //Make use of this class to CRUD operation on the Booking table from the database
    public class BookingController
    {
        #region Data members
        BookingDB bookingDB;
        Collection<Booking> bookings;     //stores all bookings in a collection
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return bookings;
            }
        }

        #endregion

        #region Constructor
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;    //bookingDB.AllBookings uses the get method of Booking class to get the bookings
        }
        #endregion

        //TODO
        #region Database communication
    }
}
