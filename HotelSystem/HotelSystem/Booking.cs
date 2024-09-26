﻿using System;
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
        public Room rooms { get; set; }
        public DateTime start;
        public DateTime end;
        public double totalPrice;
        public BookingStatus status;

        public Booking(string bookingID, Guest guest, Room rooms, DateTime start, DateTime end)
        {
            this.bookingID = bookingID;
            this.guest = guest;
            this.rooms = rooms;
            this.start = start;
            this.end = end;
            this.status = BookingStatus.Pending;
        }
    }
}
 