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
    public partial class BookingGeneratedForm : Form
    {
        public BookingGeneratedForm()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Logic for Logout - Close this form and go to login screen or exit application
            Application.Exit();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Logic to go back to the main menu
            this.Close(); // Close the current form
        }

        private void lblBookingSuccess_Click(object sender, EventArgs e)
        {

        }
    }
}