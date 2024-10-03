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
        private bool exitstingGuest = false;
        private GuestController guestController;
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
        }
        #endregion

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Handle the form submission logic here.
            string guestName = txtGuestName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string address = txtAddress.Text;
            string roomType = cbRoomType.SelectedItem.ToString();
            int numberOfChildren = (int)numChildren.Value;
            string child1Age = txtChild1Age.Text;
            string child2Age = txtChild2Age.Text;

            // Example of how to display the collected data
            MessageBox.Show($"Guest: {guestName}\nPhone: {phoneNumber}\nAddress: {address}\nRoom Type: {roomType}\nChildren: {numberOfChildren}\nChild 1 Age: {child1Age}\nChild 2 Age: {child2Age}");
        }

        private void numChildren_ValueChanged(object sender, EventArgs e)
        {
            // Enable or disable child age inputs based on the number of children selected.
            txtChild1Age.Enabled = numChildren.Value >= 1;
            txtChild2Age.Enabled = numChildren.Value == 2;
        }
    }
}