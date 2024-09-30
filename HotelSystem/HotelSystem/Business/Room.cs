using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    
    public class Room
    {
        private string RoomNo;
        private double rate;
        private Boolean check;
        public RoomType roomType;  

        #region Constructors
        public Room(string number)
        {
            RoomNo = number;
            check = false;
        }

        //This constructor will be used in data layer for reading operation
        //When performing reading operation, we need to create a room object from the database
        //and added to the collection


        public Room(string number, double price, Boolean availability)
        {
            RoomNo = number;
            rate = price;
            this.check = availability;
        }
        #endregion

        public void checkin() { check= true; }
        public void checkout() { check = false; }
        public double getRate() { return rate; }
        public string getRoomNo() { return RoomNo; }
        public void setRate(double rate) {  this.rate = rate; }
        public string getType() { return roomType.ToString(); }


    }
}
