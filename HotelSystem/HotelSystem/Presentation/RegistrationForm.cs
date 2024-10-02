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

namespace HotelSystem.Presentation
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

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