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
    //Initialize this class, and use the AllBookings property to get all bookings from the database, and use DataMaintenance() and FinalizeChanges() to add, edit or delete a booking from the database
    //Similarly for the RoomController and GuestController
    public class BookingController
    {
        #region Data members
        BookingDB bookingDB;
        Collection<Booking> bookings;     //stores all bookings in a collection
        #endregion

        #region Properties
        public Collection<Booking> AllBookings      //Use BookingController.AllBookings to get all bookings from the database
        {                                           //Use DataMaintenance() and FinalizeChanges() to add, edit or delete a booking from the database
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
        
        //Use these method change the availability of a room to True or False
        #region Database communication
        //This method updates booking DataSet(won't affect the database until FinalizeChanges() is called)
        public void DataMaintenance(Booking aBooking, DB.DBOperation operation)
        {
            int index = 0;
            bookingDB.DataSetChange(aBooking, operation);   //add, edit or delete booking in the DataSet
            switch (operation)
            {
                case DB.DBOperation.Add:      //For the project we probably won't use the add function
                    bookings.Add(aBooking);         //add a booking to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aBooking);
                    aBooking = bookings[index];     //update a booking in the Collection, i.e. replace a old booking with a new booking
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aBooking);
                    bookings.RemoveAt(index);
                    break;
            }
        }

        //This method commit changes to the database
        public bool FinalizeChanges(Booking booking, DB.DBOperation operation)
        {
            return bookingDB.UpdateDataSource(booking, operation);
        }
        #endregion

        //Use these methods to search for a booking
        #region Search Methods
        public Booking FindBooking(string bookingID)
        {
            foreach (Booking booking in bookings)
            {
                if (booking.bookingID == bookingID)
                {
                    return booking;
                }
            }
            return null;
        }

        //This method returns the index of a booking in the collection
        public int FindIndex(Booking aBooking)
        {
            int index = 0;
            foreach (Booking booking in bookings)
            {
                if (booking.bookingID == aBooking.bookingID)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        #endregion

        //Use These methods to get data from the database for the Occupancy Level and Revenue Forecast Forms-BRWCAL007
        #region Report Methods

        // Occupancy Level Report-BRWCAL007
        public decimal GetOccupancyLevelReport(DateTime startDate, DateTime endDate)
        {
            // Get all bookings within the given date range-BRWCAL007
            var totalRoomsBooked = bookings.Count(b => b.range.Start < endDate && b.range.End > startDate);
            var totalRoomsAvailable = bookingDB.GetTotalRoomCount();  // Assuming bookingDB can return total rooms in the hotel

            if (totalRoomsAvailable == 0) return 0;

            return ((decimal)totalRoomsBooked / totalRoomsAvailable) * 100; // returns percentage occupancy level
        }

        // Revenue Forecast Report-BRWCAL007
        public decimal GetRevenueReport(DateTime startDate, DateTime endDate)
        {
            // Sum up the total price of all bookings within the given date range
            return (decimal)bookings
                .Where(b => b.range.Start >= startDate && b.range.End <= endDate)
                .Sum(b => b.totalPrice);           

        }
        #endregion

        // region to make payment methods-BRWCAL007
        #region Card Payment Methods
        public bool ProcessVisaPayment(string cardNumber, string expiryDate, string cvv)
        {
            // Logic to process Visa payment (e.g., integrate with a payment gateway)

            // Return true if successful, false if not
            return true; // For now, assume the payment is always successful
        }


        #endregion
    }
}

        