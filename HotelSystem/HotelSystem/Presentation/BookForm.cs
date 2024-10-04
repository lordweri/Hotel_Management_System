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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }

        // Event handler for Make Payment button
        private void BtnMakePayment_Click(object sender, EventArgs e)
        {
            // Create an instance of the PaymentForm
            PaymentForm paymentForm = new PaymentForm();

            // Show the PaymentForm
            paymentForm.Show();
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

        }
    }
}