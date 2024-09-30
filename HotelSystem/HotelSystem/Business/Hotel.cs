using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem;
using HotelSystem.Data;

namespace HotelSystem.Business
{
    public class Hotel
    {
        private string hotelID;
        private string name;
        private string location;
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
        public Room getRoom(int id)
        {
            return rooms[id];
        }
        public List<Room> GetAvailableRooms(DateRange dateRange)
        {
            List<Room> availableRooms = new List<Room>();
            foreach (var room in rooms)
            {
                if (room.getAvailability())
                    availableRooms.Add(room);
            }
            return availableRooms;
        }


        
    }
}
