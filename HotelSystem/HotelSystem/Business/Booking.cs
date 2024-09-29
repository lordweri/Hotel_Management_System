using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Booking
    {
        public string bookingID {  get; set; }
        public Guest guest { get; set; }
        public Room room { get; set; }
        public DateRange range { get; set; }
        public double totalPrice;
        public BookingStatus status;

        public Booking(string bookingID, Guest guest, Room rooms, DateTime start, DateTime end)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.room = rooms;
            this.range=new DateRange(start, end);
            this.status = BookingStatus.Pending;
        }

        public double calculateTotalPrice()
        {

            return rooms.getRate() * range.GetNumberOfDays();
        }

        public void cancelBooking()
        {
            status = BookingStatus.Canceled;
            rooms.changeAvailability(true);
        }

        public void confirmBooking()
        {
            status=BookingStatus.Confirmed; 
            rooms.changeAvailability(false);
        }
    }
}
 