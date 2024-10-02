using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Data;

namespace HotelSystem.Business
{
    //Make use of this class to CRUD operation on the Room table from the database
    public class RoomController
    {
        #region Data members
        RoomDB roomDB;
        Collection<Room> rooms;     //stores all rooms in a collection
        #endregion

        #region Properties
        public Collection<Room> AllRooms      //Use RoomController.AllRooms to get all rooms from the database
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomController()
        {
            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;    //roomDB.AllRooms uses the get method of RoomDB class to get ALL rooms from the database
        }
        #endregion

        //Use these method change the availability of a room to True or False
        #region Database communication
        //This method updates room DataSet
        public void DataMaintenance(Room aRoom, DB.DBOperation operation)
        {
            int index = 0;
            roomDB.DataSetChange(aRoom, operation);   //add, edit or delete room in the DataSet
            switch (operation)
            {
                case DB.DBOperation.Add:      //For the project we probably won't use the add function
                    rooms.Add(aRoom);         //add a room to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aRoom);
                    aRoom = rooms[index];     //update a room in the Collection, i.e. replace a old room with a new room
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aRoom);
                    rooms.RemoveAt(index);
                    break;
            }
        }

        //This method commit changes to the database
        public bool FinalizeChanges(Room room, DB.DBOperation operation)
        {
            return roomDB.UpdateDataSource(room, operation);
        }
        #endregion

        //Use these methods to search for a room
        #region Search Method
        //searches for a room in the collection/database by room number
        public Room FindRoom(string roomNumber)
        {
            foreach (Room room in rooms)
            {
                if (room.getRoomNo() == roomNumber)
                {
                    return room;
                }
            }
            return null;
        }

        //This method finds the index of a room in the collection, returns -1 if not found
        public int FindIndex(Room room)
        {
            int index = 0;
            bool found = false;
            found = (room.getRoomNo() == rooms[index].getRoomNo());
            while (!(found) & index < rooms.Count - 1)
            {
                index++;
                found = (room.getRoomNo() == rooms[index].getRoomNo());
            }
            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        internal RoomType GetRoomType(int roomNumber)
        {
            throw new NotImplementedException();
        }

        internal object GetRoomByNumber(int roomNumber)
        {
            throw new NotImplementedException();
        }

        internal decimal GetRoomRate(int roomNumber)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

