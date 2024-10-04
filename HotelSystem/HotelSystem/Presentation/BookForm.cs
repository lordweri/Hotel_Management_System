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

namespace HotelSystem.Presentation
{
    public partial class BookForm : Form
    {
        #region Data member
        Booking booking;              // Booking object passed from the RegistrationForm
        bool guestIsExisting;
        #endregion

        #region Constructor
        public BookForm(Booking booking, bool guestIsExisting)
        {
            InitializeComponent();
            this.booking = booking;
            this.guestIsExisting = guestIsExisting;
        }
        #endregion

        // Event handler for Make Payment button
        private void BtnMakePayment_Click(object sender, EventArgs e)
        {
            // Create an instance of the PaymentForm
            PaymentForm paymentForm = new PaymentForm();

            // Show the PaymentForm
            paymentForm.Show();
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