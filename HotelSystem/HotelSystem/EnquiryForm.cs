using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class EnquiryForm : Form
    {
        public EnquiryForm()
        {
            InitializeComponent();
        }
        private void EnquiryForm_Load(object sender, EventArgs e)
        {
            this.guestTableAdapter.Fill(this.HotelDatabaseDataset.Guest);
            this.roomTableAdapter.Fill(this.HotelDatabaseDataSet.Room);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Query bookings based on guest or room
            var guestID = (int)cmbGuest.SelectedValue;
            var roomNumber = (int)cmbRoom.SelectedValue;

            var bookings = from b in HotelDatabaseDataSet.Booking
                           where b.GuestID == guestID || b.RoomNumber == roomNumber
                           select b;

            // Display results in DataGridView
            dataGridViewResults.DataSource = bookings.CopyToDataTable();
        }
    }
}
