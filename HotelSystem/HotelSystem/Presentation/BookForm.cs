using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Business;
/*
 * This class is responsible for displaying the booking details of the guest
 * and allows the guest to make payment for the booking
 */
namespace HotelSystem.Presentation
{
    public partial class BookForm : Form
    {
        /* TODO: booking object still has the following attributes been null:
         *  1. totalRate
         *  2. deposit
         *  3. status
         *  Zhentao: All other attributes are set in the previous forms, exceps range, referenceNumeber and value,
         *  Im not sure what those attributes does, so I will leave them been null.
         */
        #region Data member
        Booking booking;              // Booking object passed from the RegistrationForm
        bool guestIsExisting;         // If this attribute is true, added the guest to the database if booking is successful in payment form
        #endregion

        #region Constructor
        public BookForm(Booking booking, bool guestIsExisting)
        {
            InitializeComponent();
            this.booking = booking;
            this.guestIsExisting = guestIsExisting;
        }
        #endregion

        // "Make Payment" button, proceed to the PaymentForm
        private void BtnMakePayment_Click(object sender, EventArgs e)
        {
            // Create an instance of the PaymentForm
            PaymentForm paymentForm = new PaymentForm(booking, guestIsExisting);

            // Show the PaymentForm
            paymentForm.Show();

            // Hide the current form
            this.Hide();
        }

        // Event handler for back button
        private void BtnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the MainForm
            MainForm mainMenu = new MainForm();

            // Show the MainForm
            mainMenu.Show();

            // Close the current form
            this.Close();
        }


        // Event handler for Cancel button
        private void Button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the BookingCancelledForm
            BookingCancelledForm cancelForm = new BookingCancelledForm();

            // Show the BookingCancelledForm
            cancelForm.Show();

            // Close the current form
            this.Close();
        }



        private void lblBookingDetails_Click(object sender, EventArgs e)
        {

        }
    }
}