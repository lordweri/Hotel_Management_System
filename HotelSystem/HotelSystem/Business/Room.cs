using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Room
    {
        private string roomNo;
        private double rate;
        private Boolean availability;
        public 

        public Room(string number,double price)
        {
            roomNo = number;
            rate = price;
            availability = true;
        }
        
        public void changeAvailability(Boolean available)
        {
            availability = available;
        }

        
        public double getRate() { return rate; }
        public string getRoomNo() { return roomNo; }
        public Boolean getAvailability() { return availability; }
        public void setRate(double rate) {  this.rate = rate; }
    }
}
