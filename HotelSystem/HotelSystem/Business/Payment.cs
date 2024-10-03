using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Data;

namespace HotelSystem.Business
{
    public class Payment
    {
        public string PaymentID { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; }
        public string BookingID { get; set; }

        public Payment(string paymentID, string bookingID, decimal amount, DateTime date)
        {
            PaymentID = paymentID;
            BookingID = bookingID;
            Amount = amount;
            Date = date;
        }



    }
}
