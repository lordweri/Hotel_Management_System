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
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            // Logic to proceed with payment can be added here
            MessageBox.Show("Proceed to Payment");           
        }

        // Event handler for back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the MainForm
            MainForm mainMenu = new MainForm();

            // Show the MainForm
            mainMenu.Show();

            // Close the current form
            this.Close();
        }


        // Event handler for Cancel button
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}