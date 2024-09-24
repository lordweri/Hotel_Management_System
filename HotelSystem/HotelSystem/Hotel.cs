using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace HotelSystem
{
    public class Hotel
    {
        private string hotelID { get; set; }
        private string name{  get; set; }
        private string location {  get; set; }
        private List<Room> rooms;
        private double occupancyRate; 

        public Hotel(string hotelID, string name, string location, List<Room> rooms, double occupancyRate)
        {
            this.hotelID = hotelID;
            this.name = name;
            this.location = location;
            this.rooms = rooms;
            this.occupancyRate = occupancyRate;
        }

        public List<Room> getAvailableRooms(DateRange dateRange)
        {
            return rooms;
        }

        public Boolean bookRoom(Booking booking)
        {
            return true;
        }

        public void checkIn(Guest guest, Booking booking)
        {

        }

        public void checkOut(Guest guest, string bookingID)
        {

        }
        
    }
}
