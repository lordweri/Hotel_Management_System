using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Data
{
    public class RoomDB : DB
    {
        #region Data members
        private string table = "Room";
        private string sqlLocal = "SELECT * FROM Room";
        private Collection<Room> rooms; //stores all rooms in a collection(Similar our practical workshop, their have a collection in EmployeeDB.cs that stores all employees)
        #endregion

        #region Properties
        //Returns all rooms in a collection
        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomDB(): base()
        {
        }
        #endregion

        #region Utility methods
        #endregion

        #region Database operations CRUD
        #endregion
    }
}
