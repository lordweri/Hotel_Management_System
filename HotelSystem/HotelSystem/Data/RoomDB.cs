using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.Data
{
    //This class allows to read the Room table from the database
    //No Update, Insert or Delete operations are allowed on the Room table, only read
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
        public RoomDB() : base()
        {
            rooms = new Collection<Room>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        //Adds all rooms to the collection
        private void Add2Collection(string table)
        {
            DataRow myRow;
            Room room;
            rooms.Clear();

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    room = new Room();
                    room.RoomID = Convert.ToString(myRow["RoomID"]).Trim();
                    room.Rate = Convert.ToDouble(myRow["Rate"]);
                    room.Availability = Convert.ToBoolean(myRow["Status"]);
                    rooms.Add(room);
                }
            }
        }

        //Fill a row in the dataset
        private void FillRow(DataRow aRow, Room aRoom, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["RoomNumber"] = aRoom.RoomID;
                aRow["Rate"] = aRoom.Rate;
                aRow["Status"] = aRoom.Availability;
            }
        }

        //Find a row in the dataset
        private int FindRow(Room aRoom)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string roomNumber = aRoom.RoomID;     //TODO check later of variable name matchs with Room class
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (roomNumber == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["RoomNumber"]))
                    {
                        returnValue = rowIndex;
                    }

                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database operations CRUD
        public void DataSetChange(Room aRoom, DB.DBOperation operation)
        {
            DataRow aRow = null;
            switch (operation)
            {
                case DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aRoom, DBOperation.Add);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aRoom)];
                    FillRow(aRow, aRoom, DBOperation.Edit);
                    break;
                case DBOperation.Delete:
                    dsMain.Tables[table].Rows[FindRow(aRoom)].Delete();
                    break;
            }
        }
        #endregion
    }

}
