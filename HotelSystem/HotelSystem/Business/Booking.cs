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
        private string referenceNumber;
        private object value;
        private DateTime checkIn;
        private DateTime checkOut;
        private decimal totalRate;
        private decimal deposit;

        //Using this constructor in the data layer
        public Booking(string bookingID, Guest guest,RoomType roomType, Room room, DateTime start, DateTime end, decimal totalRate, decimal deposit, BookingStatus status)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.room = room;
            this.roomType = roomType;
            this.range=new DateRange(start, end);
            this.status = BookingStatus.Pending;
            this.totalRate = totalRate;
            this.deposit = deposit;
            this.status = status;
        }

        public Booking(string referenceNumber, Guest guest, RoomType roomType, object value, DateTime checkIn, DateTime checkOut, decimal totalRate, decimal deposit)
        {
            this.referenceNumber = referenceNumber;
            this.guest = guest;
            this.roomType = roomType;
            this.value = value;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.totalRate = totalRate;
            this.deposit = deposit;
        }

        public DateTime CheckOut { get; internal set; }
        public DateTime CheckIn { get; internal set; }

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

        public decimal getDeposit()
        {
            return deposit;
        }
    }
}
 