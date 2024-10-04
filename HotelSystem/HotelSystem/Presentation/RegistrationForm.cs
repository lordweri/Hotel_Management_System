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
* 1. If the guest is existing in database, the text box will be auto-filled and will not be editable.
* 2. If the guest is not existing in database, the text box will be editable and the guest will be added to the database.
* 3. If the room type is family room, the child options will be shown.
* 4. A Guest object will be created with the details from the text boxes 
* 5. A booking object will be created and passed to the next form(BookForm)
* 6. Press "Generate Booking" add Guest to the Booking object and proceeds to the next form(BookForm)
* NOTE:
*  If the guest is not exist in database, the guest will be added to the database if booking is successful in payment form
*  
*/
namespace HotelSystem.Presentation
{   
    public partial class RegistrationForm : Form
    {
        #region Data Members
        private bool exitstingGuest = false;             //flag to check if the guest is existing
        private Guest guest;                             //guest object to store the guest details

        private GuestController guestController;         //controller to handle guest operations
        private Booking booking;                         //booking object to store the booking details, however it will only be added to database after booking is confirmed

        RoomType roomType;                              //room type selected by the user
        #endregion

        #region Constructors
        //Constructor to use when the guest is NOT A EXISTING GUEST
        public RegistrationForm(GuestController guestController,Booking Booking)
        {
            InitializeComponent();
            this.guestController = guestController;
            this.booking = Booking;
        }

        //Constructor to use when the guest is a EXISTING GUEST
        public RegistrationForm(GuestController guestController, Guest guest,Booking booking)
        {
            InitializeComponent();
            exitstingGuest = true;
            this.guestController = guestController;
            this.guest = guest;                               //existing guest object
            this.booking = booking;                           //booking object passed from the GuestTypeForm

            // Fill the form with the existing guest details
            txtGuestName.Text = guest.getName();
            txtPhoneNumber.Text = guest.getPhone();
            txtEmail.Text = guest.getEmail();
            txtAddress.Text = guest.getAddress();
            ReadOnlyTextBox(true);                            //Make the first four text boxes read only, because the customer is existing
        }
        #endregion

        //"Generate Booking" button, add Guest object to the Booking object and proceed to the BookForm after pressed
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle the form submission logic here.
            string guestName = txtGuestName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string email = txtEmail.Text;
            int numberOfChildren = (int)numChildren.Value;
            string child1Age = txtChild1Age.Text;
            string child2Age = txtChild2Age.Text;

            if (exitstingGuest)
            {
                booking.guest = guest;
            }
            else
            {
                // Create a new guest object, GuestID will be generated automatically
                guest = new Guest(guestName, email, phoneNumber, address);
                booking.guest = guest;
            }
            booking.roomType = roomType;

            //Proceed to the next form
            BookForm bookForm = new BookForm(booking, exitstingGuest);    //exitstingGuest flag is passed to the next form, if existingGuest is false, the guest will be added to the database if booking is successful
            bookForm.Show();
            this.Hide();

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
            txtEmail.ReadOnly = b;
        }

        //Show or hide child options based on the room type selected
        private void showChildOptions(bool b)
        {
            lblChildren.Visible = b;
            numChildren.Visible = b;
            lblChild1Age.Visible = b;
            txtChild1Age.Visible = b;
            lblChild2Age.Visible = b;
            txtChild2Age.Visible = b;
        }
        #endregion

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            showChildOptions(false);
        }

        //Select type of room, show child options if family room is selected
        private void cbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRoomType.SelectedItem.ToString() == "FamilyRoom")
            {
                showChildOptions(true);
            }
            else
            {
                showChildOptions(false);
            }

            //set roomType
            if(cbRoomType.SelectedItem.ToString() == "FamilyRoom")
            {
                roomType = RoomType.FamilyRoom;
            }
            else if(cbRoomType.SelectedItem.ToString() == "Single")
            {
                roomType = RoomType.Single;
            }
            else if(cbRoomType.SelectedItem.ToString() == "CoupleSharingOneBed")
            {
                roomType = RoomType.CoupleSharingOneBed;
            }
            else if(cbRoomType.SelectedItem.ToString() == "TwoPeopleSeparateBeds")
            {
                roomType = RoomType.TwoPeopleSeparateBeds;
            }
            else if(cbRoomType.SelectedItem.ToString() == "Standard")
            {
                roomType = RoomType.Standard;
            }
        }
    }
}