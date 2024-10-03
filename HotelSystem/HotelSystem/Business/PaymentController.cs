using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Data;

namespace HotelSystem.Business
{
    public class PaymentController
    {
        #region Dara members
        PaymentDB paymentDB;
        Collection<Payment> payments;     //stores all payments in a collection
        #endregion

        #region Properties
        public Collection<Payment> AllPayments            //Use PaymentController.AllPayments to get all payments from the database
        {
            get
            {
                return payments;
            }
        }
        #endregion

        #region Constructor
        public PaymentController()
        {
            paymentDB = new PaymentDB();
            payments = paymentDB.AllPayments;    //paymentDB.AllPayments uses the get method of PaymentDB class to get ALL payments from the database
        }
        #endregion

        #region Database communication
        //This method updates payment DataSet(won't affect the database until FinalizeChanges() is called)
        public void DataMaintenance(Payment aPayment, DB.DBOperation operation)
        {
            int index = 0;
            paymentDB.DataSetChange(aPayment, operation);   //add, edit or delete payment in the DataSet
            switch (operation)
            {
                case DB.DBOperation.Add:      //add a payment to the dataset
                    payments.Add(aPayment);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aPayment);
                    aPayment = payments[index];     //update a payment in the Collection, i.e. replace a old payment object with a new object (NOTE: paymentID should remain the same)
                    break;
                case DB.DBOperation.Delete:      //delete a payment from the dataset
                    index = FindIndex(aPayment);
                    payments.RemoveAt(index);
                    break;
            }
        }

        //Finalize changes to the database
        public void FinalizeChanges(Payment payment, DB.DBOperation operation)
        {
            paymentDB.UpdateDataSource(payment, operation);
        }
        #endregion
    }
}
