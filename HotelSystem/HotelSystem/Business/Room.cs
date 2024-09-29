using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Room
    {
        private string roomID;
        private double rate;
        private Boolean availability;

        public Room(string ID,double price)
        {
            roomID = ID;
            rate = price;
            availability = true;
        }
        
        public void changeAvailability(Boolean available)
        {
            availability = available;
        }

        
        public double getRate() { return rate; }
        public string getRoomID() { return roomID; }
        public Boolean getAvailability() { return availability; }
    }
}
