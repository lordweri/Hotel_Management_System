using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Business;

namespace HotelSystem.Data
{
    public class PaymentDB : DB
    {
        #region Data members
        private string table = "Payment";
        private string sqlLocal = "SELECT * FROM Payment";
        private Collection<Payment> payments; //stores all payments in a collection
        #endregion

        #region Properties
        //Returns all payments in a collection
        public Collection<Payment> AllPayments
        {
            get
            {
                return payments;
            }
        }
        #endregion

        #region Constructor
        //Constructor to be used in Controller classes
        public PaymentDB() : base()
        {
            payments = new Collection<Payment>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility methods

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        //Adds all payments from the dataset to payments collection
        private void Add2Collection(string table)
        {
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    string paymentID = row["PaymentID"].ToString();
                    string bookingID = row["BookingID"].ToString();
                    decimal amount = Convert.ToDecimal(row["Amount"]);
                    DateTime date = Convert.ToDateTime(row["Date"]);
                    Payment payment = new Payment(paymentID, bookingID, amount, date);
                    payments.Add(payment);
                }
            }
        }

        private void FillRow(DataRow row, Payment payment, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                row["PaymentID"] = payment.PaymentID;
                row["BookingID"] = payment.BookingID;
                row["Amount"] = payment.Amount;
                row["Date"] = payment.Date;
            }
        }

        private int FindRow(Payment aPayment)
        {
            int rowIndex = 0;
            DataRow myRow = null;
            int returnValue = -1;
            string paymentID = aPayment.PaymentID;
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                myRow = row;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (paymentID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["PaymentID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        #endregion

        #region Database operations
        public void DataSetChange(Payment aPayment, DB.DBOperation operation)
        {
            DataRow row = null;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    row = dsMain.Tables[table].NewRow();
                    FillRow(row, aPayment, operation);
                    dsMain.Tables[table].Rows.Add(row);
                    break;
                case DB.DBOperation.Edit:
                    row = dsMain.Tables[table].Rows[FindRow(aPayment)];
                    FillRow(row, aPayment, operation);
                    break;
                case DB.DBOperation.Delete:
                    dsMain.Tables[table].Rows[FindRow(aPayment)].Delete();
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Payment aPayment)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 50, "PaymentID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 50, "BookingID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Amount", SqlDbType.Decimal, 8, "Amount");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Date", SqlDbType.DateTime, 8, "Date");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Build_UPDATE_Parameters(Payment aPayment)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 50, "PaymentID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 50, "BookingID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Amount", SqlDbType.Decimal, 8, "Amount");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Date", SqlDbType.DateTime, 8, "Date");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 50, "PaymentID");
            daMain.DeleteCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Payment aPayment)
        {
            daMain.InsertCommand = new SqlCommand("INSERT into Payment (PaymentID, BookingID, Amount, Date) VALUES (@PaymentID, @BookingID, @Amount, @Date)", cnMain);
            Build_INSERT_Parameters(aPayment);
        }

        private void Create_UPDATE_Command(Payment aPayment)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Payment SET PaymentID = @PaymentID, BookingID = @BookingID, Amount = @Amount, Date = @Date WHERE PaymentID = @PaymentID", cnMain);
            Build_UPDATE_Parameters(aPayment);
        }

        private void Create_DELETE_Command()
        {
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Payment WHERE PaymentID = @PaymentID", cnMain);
            Build_DELETE_Parameters();
        }

        private bool UpdateDataSource(PaymentDB payment, DB.DBOperation operation)
        {
            bool success = true;
            switch (operation)
            {
                case DB.DBOperation.Add:
                    Create_INSERT_Command(payment);
                    break;
                case DBOperation.Edit:
                    Create_UPDATE_Command(payment);
                    break;
                case DBOperation.Delete:
                    Create_DELETE_Command();
                    break;
            }
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion
    }
}
