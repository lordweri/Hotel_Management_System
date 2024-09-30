using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    public class Booking
    {
        public string bookingID;
        public Guest guest;
        public Room room;
        public RoomType roomType;
        public DateRange range;
        public double totalPrice;
        public BookingStatus status;

        public Booking(string bookingID, Guest guest,RoomType roomType, Room room, DateTime start, DateTime end)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.room = room;
            this.roomType = roomType;
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
        }

        public void confirmBooking()
        {
            status=BookingStatus.Confirmed; 
        }
    }
}
 