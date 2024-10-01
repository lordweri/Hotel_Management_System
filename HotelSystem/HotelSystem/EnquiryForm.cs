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
            this.guestTableAdapter.Fill(this.hotelDatabaseDataSet.Guest);
            this.roomTableAdapter.Fill(this.hotelDatabaseDataSet.Room);

            // Set up comboboxes
            cmbGuest.DataSource = hotelDatabaseDataSet.Guest;
            cmbRoom.DataSource = hotelDatabaseDataSet.Room;
            cmbGuest.ValueMember = "GuestID";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Query bookings based on guest or room
            var guestID = (int)cmbGuest.SelectedValue;
            var roomNumber = (int)cmbRoom.SelectedValue;

            var bookings = from b in hotelDatabaseDataSet.Booking
                           where b.GuestID == guestID || b.RoomNumber == roomNumber
                           select b;

            // Display results in DataGridView
            dataGridViewResults.DataSource = bookings.CopyToDataTable();

            // Clear results if no bookings found

        }

        private void EnquiryForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelDatabaseDataSet.Room);
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.hotelDatabaseDataSet.Guest);

        }
    }
}
