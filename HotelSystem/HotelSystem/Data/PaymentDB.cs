using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Data
{
    public class PaymentDB : DB
    {
        #region Data members
        private string table = "Payment";
        private string sqlLocal = "SELECT * FROM Payment";
        private Collection<Room> payments;
        #endregion

        #region Properties
        public Collection<Room> AllPayments
        {
            get
            {
                return payments;
            }
        }
        #endregion

        #region Constructor
        public PaymentDB() : base()
        {
            payments = new Collection<Room>();
            FillDataSet(sqlLocal, table);
            //Add2Collection(table);
        }
        #endregion

        #region Utility methods
        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #endregion


    }
}
