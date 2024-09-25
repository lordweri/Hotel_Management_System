using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Data
{
    public class GuestDB
    {
        #region Data members
        private string table = "Guest";
        private string sqlLocal = "SELECT * FROM Guest";
        private Collection<Room> rooms; //stores all rooms in a collection(Similar our practical workshop, their have a collection in EmployeeDB.cs that stores all employees)
        #endregion
    }
}
