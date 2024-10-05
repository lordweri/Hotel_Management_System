using HotelSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.Presentation
{
    public partial class GuestTypeForm : Form
    {
        #region Data Members
        BookingController bookingController;
        GuestController guestController;
        Collection<Guest> guests;
        private Booking booking;

        Room selectedRoom = null;              // The room selected in DateCheckForm
        #endregion

        #region Constructor
        public GuestTypeForm(BookingController bookingController, Booking book)
        {
            booking = book;                  //Booking object passed from the DateCheckForm
            InitializeComponent();
            guestController = new GuestController();
            guests = new Collection<Guest>();
            label1.Visible = false;
            guestIDtextBox.Visible = false;
            continueButton.Visible = false;
        }
        #endregion

        //When this button is clicked, the user is taken to the form(Registration Form) to register a new guest
        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            // Logic to handle new guest reservation
            RegistrationForm registrationForm = new RegistrationForm(bookingController, guestController,booking);
            registrationForm.Show();          // Show the registration form
            this.Close();                     // Close the current form
        }

        //Check if the guest is existing, if existing, proceed to the registration form, if not, display an error message and do nothing
        private void btnExistingGuest_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            guestIDtextBox.Visible = true;
            continueButton.Visible=true;

        }

        //Back button
        private void button1_Click(object sender, EventArgs e)
        {
             DateCheckForm dateCheckForm = new DateCheckForm(bookingController);
             dateCheckForm.Show();
             this.Close();
        }

        private void GuestTypeForm_Load(object sender, EventArgs e)
        {

        }

        //Continue button, proceeds to the Registration form
        private void continueButton_Click(object sender, EventArgs e)
        {
            string guestIdEntered = guestIDtextBox.Text;
            foreach (Guest guest in guests)
            {
                if (guest.getGuestID() == guestIdEntered)
                {
                    // Guest found
                    MessageBox.Show("Guest found!");
                    // You can call the form for an existing guest reservation here
                    RegistrationForm registrationForm = new RegistrationForm(bookingController, guestController, guest,booking);        // We found the guest, proceed to registration form
                    registrationForm.Show();                           // Show the reservation form
                    this.Close();                              // Close the current form (Alternative approach: Hide the current form by making visible = false)
                    continue;
                }
                else
                {
                    // Guest not found, display an error message and do nothing
                    // Reenter the guest ID or register as a new guest
                    MessageBox.Show("Guest not found!");
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}