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
    public partial class BookingCancelledForm : Form
    {
        public BookingCancelledForm()
        {
            InitializeComponent();
        }

        // Event handler for Logout button
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Instantiate the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the LoginForm
            loginForm.Show();

            // Close the current form (BookingCancelledForm)
            this.Close();
        }

        // Event handler for Back to Main Menu button
        private void BtnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Instantiate the MainForm
            MainForm mainForm = new MainForm();

            // Show the MainForm
            mainForm.Show();

            // Close the current BookingCancelledForm
            this.Close();
        }
    }
}
