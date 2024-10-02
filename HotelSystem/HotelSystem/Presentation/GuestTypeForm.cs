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
    public partial class GuestTypeForm : Form
    {
        public GuestTypeForm()
        {
            InitializeComponent();
        }

        private void btnNewGuest_Click(object sender, EventArgs e)
        {
            // Logic to handle new guest reservation
            MessageBox.Show("New Guest selected.");
            // You can call the form for a new guest reservation here
        }

        private void btnExistingGuest_Click(object sender, EventArgs e)
        {
            // Logic to handle existing guest reservation
            MessageBox.Show("Existing Guest selected.");
            // You can call the form for an existing guest reservation here
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}