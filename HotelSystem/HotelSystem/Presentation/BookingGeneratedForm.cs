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

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Instantiate the LoginForm
            LoginForm loginForm = new LoginForm();

            // Show the LoginForm
            loginForm.Show();

            // Close the current form (BookingGeneratedForm)
            this.Close();
        }

        private void BtnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Instantiate the MainForm
            MainForm mainForm = new MainForm();

            // Show the MainForm
            mainForm.Show();

            // Close the current BookingGeneratedForm
            this.Close();
        }

        private void LblBookingSuccess_Click(object sender, EventArgs e)
        {

        }
    }
}