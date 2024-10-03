using HotelSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * IMPORTANT TO READ:
* If the guest is existing in database, the text box will be auto-filled and will not be editable
* If the guest is not existing in database, the text box will be editable and the guest will be added to the database
*/
namespace HotelSystem.Presentation
{   
    public partial class RegistrationForm : Form
    {
        #region Data Members
        private bool exitstingGuest = false;             //flag to check if the guest is existing
        private GuestController guestController;         //controller to handle guest operations
        #endregion

        #region Constructors
        //Constructor to use when the guest is not a existing guest
        public RegistrationForm(GuestController guestController)
        {
            InitializeComponent();
            this.guestController = guestController;
        }

        //Constructor to use when the guest is a existing guest
        public RegistrationForm(GuestController guestController, Guest guest)
        {
            InitializeComponent();
            exitstingGuest = true;
            this.guestController = guestController;

            // Fill the form with the existing guest details
            txtGuestName.Text = guest.getName();
            txtPhoneNumber.Text = guest.getPhone();
            txtEmail.Text = guest.getEmail();
            txtAddress.Text = guest.getAddress();
            ReadOnlyTextBox(true);                            //Make the first four text boxes read only, because the customer is exiting
        }
        #endregion

        //"Generate Booking" button click event
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle the form submission logic here.
            string guestName = txtGuestName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            string roomType = cbRoomType.SelectedItem.ToString();
            int numberOfChildren = (int)numChildren.Value;
            string child1Age = txtChild1Age.Text;
            string child2Age = txtChild2Age.Text;


            // Create a new guest object, GuestID will be generated automatically
            Guest guest = new Guest(guestName, email, phoneNumber, address);

            /*
            // Example of how to display the collected data
            MessageBox.Show($"Guest: {guestName}\nPhone: {phoneNumber}\nAddress: {address}\nRoom Type: {roomType}\nChildren: {numberOfChildren}\nChild 1 Age: {child1Age}\nChild 2 Age: {child2Age}");
            */
        }

        private void numChildren_ValueChanged(object sender, EventArgs e)
        {
            // Enable or disable child age inputs based on the number of children selected.
            txtChild1Age.Enabled = numChildren.Value >= 1;
            txtChild2Age.Enabled = numChildren.Value == 2;
        }

        #region Utility methods
        //Make the text boxes read only if the guest is existing
        private void ReadOnlyTextBox(bool b)
        {
            txtGuestName.ReadOnly = b;
            txtPhoneNumber.ReadOnly = b;
            txtAddress.ReadOnly = b;
            cbRoomType.Enabled = b;
        }
        #endregion
    }
}