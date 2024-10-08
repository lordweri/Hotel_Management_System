using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    public class Booking
    {
        private string bookingID;
        private Guest guest;
        private Room room;
        private RoomType roomType;
        private DateRange range;
        private BookingStatus status;
        public DateTime checkIn;
        public DateTime checkOut;
        public decimal totalPrice;


        //Using this constructor in the data layer
        public Booking(string bookingID, Guest guest,RoomType roomType, Room room, DateTime start, DateTime end, decimal totalRate, decimal deposit, BookingStatus status)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.room = room;
            this.roomType = roomType;
            this.range=new DateRange(start, end);
            this.status = BookingStatus.Pending;
            this.totalPrice = totalRate;
            this.status = status;
        }

        public Booking(string referenceNumber, Guest guest, RoomType roomType, DateTime checkIn, DateTime checkOut, decimal totalRate, decimal deposit)
        {
            this.bookingID = referenceNumber;
            this.guest = guest;
            this.roomType = roomType;
            this.checkIn = checkIn;
            this.checkOut = checkOut;
            this.totalPrice = totalRate;

        }

        public Booking()
        {
            this.bookingID=GenerateBookingID();
        }


        public DateTime CheckOut { get; internal set; }
        public DateTime CheckIn { get; internal set; }

        // method to calculate total price for a booking
        public decimal calculateTotalPrice()
        {
            this.totalPrice = (decimal)room.getRate() * range.GetNumberOfDays();
            return (decimal)room.getRate() * range.GetNumberOfDays();
        }

        public void cancelBooking()
        {
            status = BookingStatus.Refunded;
        }

        public void confirmBooking()
        {
            status=BookingStatus.Confirmed; 
        }


        public decimal calculateDeposit()
        {
           decimal deposit = totalPrice * 0.1m;
            return deposit;
        }

        public void setRoom(Room r)
        {
            this.room = r;
        }

        private string GenerateBookingID()
        {
            Random random = new Random();

            char letter1 = (char)random.Next('A', 'Z' + 1); 
            char letter2 = (char)random.Next('A', 'Z' + 1); 


            int number1 = random.Next(0, 10);
            int number2 = random.Next(0, 10); 
            int number3 = random.Next(0, 10); 

            return $"BH{letter1}{letter2}{number1}{number2}{number3}"; 
        }

        public void setRange(DateRange range)
        {
            this.range = range;
            this.checkIn = range.GetStart();
            this.checkOut = range.getEnd();
        }

        public DateTime getCheckIn()
        {
            return this.range.GetStart();
        }
        
        public DateTime getCheckOut()
        {
            return this.range.getEnd();
        }

        public DateRange GetRange()
        {
            return this.range;
        }

        public string GetBookingID()
        {
            return this.bookingID;
        }

        public string GetStatus()
        {
            return status.ToString();
        }

        public Room GetRoom()
        {
            return room;
        }

        public Guest GetGuest()
        {
            return guest;
        }

        public void setGuest(Guest guest)
        {
            this.guest = guest;
        }

        public void setRoomType(RoomType roomType)
        {
            this.roomType = roomType;
            this.room.setType(roomType);
        }

    }
}
 