using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    public class Room
    {
        private string roomNo;
        private double rate;
        private Boolean availability;
        public RoomType roomType;   //Zhentao: Since we assume single room type, I suggest to remove this attribute(Delete this line)

        #region Property methods
        public string RoomNo
        {
            get { return roomNo; }
            set { roomNo = value; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public Boolean Availability
        {
            get { return availability; }
            set { availability = value; }
        }
        #endregion

        #region Constructors
        public Room(string number,double price)
        {
            roomNo = number;
            rate = price;
            availability = true;
        }

        //This constructor will be used in data layer for reading operation
        //When performing reading operation, we need to create a room object from the database
        //and added to the collection
        public Room(string number, double price, Boolean availability)
        {
            roomNo = number;
            rate = price;
            this.availability = availability;
        }
        #endregion

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
