using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Business;

namespace HotelSystem.Data
{
    public class RoomDB : DB
    {
        #region Data members
        private string table = "Room";
        private string sqlLocal = "SELECT * FROM Room";
        private Collection<Room> rooms; //stores all rooms in a collection(Similar our practical workshop, their have a Collection in EmployeeDB.cs that stores all employees)
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
        //Constructor to be used in Controller classes
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

        //Adds all rooms from the dataset to the collection
        private void Add2Collection(string table)
        {
            DataRow myRow;
            Room room;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string roomID = Convert.ToString(myRow["RoomNumber"]).Trim();
                    double rate = Convert.ToDouble(myRow["RoomRate"]);
                    Boolean availability = Convert.ToBoolean(myRow["IsAvailable"]);
                    room = new Room(roomID, rate, availability);  
                    rooms.Add(room);
                }
            }
        }

        //Fill a row in the Room dataset
        private void FillRow(DataRow aRow, Room aRoom, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["RoomNumber"] = aRoom.getRoomNo();
                aRow["RoomRate"] = aRoom.getRate();
                aRow["IsAvailable"] = aRoom.IsOccupied();
            }
        }

        //Find a room row in the dataset, using Room object as parameter but searching by room number
        private int FindRow(Room aRoom)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string roomNumber = aRoom.getRoomNo();     
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

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Room aRoom)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 50, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomRate", SqlDbType.Money, 8, "RoomRate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@IsAvailable", SqlDbType.Int, 10, "IsAvailable");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Room aRoom)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 50, "RoomNumber");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomRate", SqlDbType.Money, 8, "RoomRate");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@IsAvailable", SqlDbType.Int, 10, "IsAvailable");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters(Room aRoom)
        {
            SqlParameter param;
            param = new SqlParameter("@RoomNumber", SqlDbType.NVarChar, 50, "RoomNumber");
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Room aRoom)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Room (RoomNumber, RoomRate, IsAvailable) VALUES (@RoomNumber, @RoomRate, @IsAvailable)", cnMain);
            Build_INSERT_Parameters(aRoom);
        }

        private void Create_UPDATE_Command(Room aRoom)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Room SET RoomNumber = @RoomNumber, RoomRate = @RoomRate, IsAvailable = @IsAvailable WHERE RoomNumber = @RoomNumber", cnMain);
            Build_UPDATE_Parameters(aRoom);
        }

        private void Create_DELETE_Command(Room aRoom)
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Room WHERE RoomNumber = @RoomNumber", cnMain);
            Build_DELETE_Parameters(aRoom);
        }

        public bool UpdateDataSource(Room aRoom, DB.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    Create_INSERT_Command(aRoom);
                    break;
                case DBOperation.Edit:
                    Create_UPDATE_Command(aRoom);
                    break;
                case DB.DBOperation.Delete:
                    Create_DELETE_Command(aRoom);
                    break;
            }
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion
    }

}
