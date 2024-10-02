using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
        private List<Booking> bookings;
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
        public void setOccupancyRate()
        {
            if (rooms.Count == 0)
            {
                occupancyRate = 0;
                return;
            }

            int occupiedRooms = rooms.Count(r => r.IsOccupied());
            occupancyRate = (double)occupiedRooms / rooms.Count * 100;
        }


        public double GetOccupancyRate()
        {
            return occupancyRate;
        }

        public void addBooking(Booking booking)
        {
            bookings.Add(booking);
        }

        public List<Booking> getBookingList()
        {
            return bookings;
        }
    }
}
