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
 * 
 * 
 */
namespace HotelSystem.Presentation
{
    public partial class BookForm : Form
    {
        /* 1. TODO: booking object still has the following attributes been null:
         *  1. status
         *  Zhentao: All other attributes are set in the previous forms, exceps referenceNumeber and value,
         *  Im not sure what those attributes does, so I will leave them been null.
         * 2. TODO: pass amountToPay to the next form(PaymentForm)
         */
        #region Data member
        Booking booking;              // Booking object passed from the RegistrationForm
        bool guestIsExisting;         // If this attribute is true, added the guest to the database if booking is successful in payment form
        decimal amountToPay;          // The amount to pay (either deposit or full payment) NOTE: This value should be passed to the next form(PaymentForm)
        #endregion

        #region Constructor
        public BookForm(Booking booking, bool guestIsExisting)
        {
            InitializeComponent();
            this.booking = booking;
            this.guestIsExisting = guestIsExisting;

            //Calculate the totalRate and deposit
            booking.totalPrice = booking.calculateTotalPrice();
            booking.calculateDeposit();
        }
        #endregion

        // "Make Payment" button, proceed to the PaymentForm
        private void BtnMakePayment_Click(object sender, EventArgs e)
        {
            // Create an instance of the PaymentForm
            PaymentForm paymentForm = new PaymentForm(booking, guestIsExisting, amountToPay);

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

        // Event handler for form load
        private void BookForm_Load(object sender, EventArgs e)
        {
            // Make the text boxes read only
            txtBookingID.ReadOnly = true;
            txtRoomType.ReadOnly = true;
            txtRoomNumber.ReadOnly = true;
            txtCheckInDate.ReadOnly = true;
            txtCheckOutDate.ReadOnly = true;
            txtTotalPrice.ReadOnly = true;
            txtDeposit.ReadOnly = true;
            txtGuestID.ReadOnly = true;
            txtGuestName.ReadOnly = true;
            txtContact.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtAmountToPay.ReadOnly = true;


            // Display the booking details in the form
            txtBookingID.Text = booking.bookingID;
            txtRoomType.Text = booking.roomType.ToString();
            txtRoomNumber.Text = booking.room.getRoomNo();
            txtCheckInDate.Text = booking.getCheckIn().ToString("yyyy/MM/dd");
            txtCheckOutDate.Text = booking.getCheckOut().ToString("yyyy/MM/dd");
            txtTotalPrice.Text = booking.totalPrice.ToString();
            txtDeposit.Text = booking.getDeposit().ToString();
            txtNumberOfDays.Text = booking.range.GetNumberOfDays()+"";

            txtGuestID.Text = booking.guest.getGuestID();
            txtGuestName.Text = booking.guest.getName();
            txtContact.Text = booking.guest.getPhone();
            txtEmail.Text = booking.guest.getEmail();
            txtAddress.Text = booking.guest.getAddress();
        }

        // Event handler for Pay Deposit radio button
        private void rbtPayDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtAmountToPay.Text = booking.getDeposit().ToString();
            amountToPay = booking.getDeposit();
        }

        // Event handler for Pay Full radio button
        private void rbtPayFull_CheckedChanged(object sender, EventArgs e)
        {
            txtAmountToPay.Text = booking.totalPrice.ToString();
            amountToPay = booking.calculateTotalPrice();
        }
    }
}