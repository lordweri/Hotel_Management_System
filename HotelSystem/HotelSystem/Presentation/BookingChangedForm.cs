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
    public partial class BookingChangedForm : Form
    {
        public BookingChangedForm()
        {
            InitializeComponent();
        }
        // method to go back to the Mainform when the back button is clicked-BRWCAL007
        private void BtnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Create an instance of the main menu form
            MainForm mainForm = new MainForm();

            // Show the main menu form
            mainForm.Show();

            // Close the current form (BookingChangedForm)
            this.Close();
        }
        // mehtod to logout from the application when the logout button is clicked-BRWCAL007
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Display a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Create an instance of the login form
                LoginForm loginForm = new LoginForm();

                // Show the login form
                loginForm.Show();

                // Close the current form (BookingChangedForm) and all other forms
                Application.OpenForms.Cast<Form>().ToList().ForEach(f => f.Close());

            }
        }
    }
}
