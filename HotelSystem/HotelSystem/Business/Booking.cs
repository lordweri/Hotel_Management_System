using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    public class Booking
    {
        public string bookingID {  get; set; }
        public Guest guest { get; set; }
        public Room room { get; set; }
        public DateRange range { get; set; }
        public double totalPrice;
        public BookingStatus status;

        public Booking(string bookingID, Guest guest, Room room, DateTime start, DateTime end)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.room = room;
            this.range=new DateRange(start, end);
            this.status = BookingStatus.Pending;
        }

        public double calculateTotalPrice()
        {

            return room.getRate() * range.GetNumberOfDays();
        }

        public void cancelBooking()
        {
            status = BookingStatus.Canceled;
            room.changeAvailability(true);
        }

        public void confirmBooking()
        {
            status=BookingStatus.Confirmed; 
            room.changeAvailability(false);
        }
    }
}
 