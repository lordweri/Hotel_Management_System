﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace HotelSystem.Business
{
    
    public class Room
    {
        private double rate;
        private Boolean check;
        public RoomType roomType;

        public string RoomNumber { get; internal set; }

        #region Constructors
        public Room(string number)
        {
            RoomNumber = number;
            check = false;
        }

        //This constructor will be used in data layer for reading operation
        //When performing reading operation, we need to create a room object from the database
        //and added to the collection


        public Room(string number, double price, Boolean availability)
        {
            RoomNumber = number;
            rate = price;
            this.check = availability;
        }
        #endregion

        public void checkin() { check= true; }
        public void checkout() { check = false; }
        public double getRate() { return rate; }
        public string getRoomNo() { return RoomNumber; }
        public void setRate(double rate) {  this.rate = rate; }
        public string getType() { return roomType.ToString(); }
        public bool IsOccupied() { return check; }
        public void setType(RoomType roomType) { this.roomType = roomType;}


    }
}
