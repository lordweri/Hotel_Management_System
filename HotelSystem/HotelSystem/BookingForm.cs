using HotelSystem.HotelDatabaseDataSetTableAdapters;
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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }
        private void BookingForm_Load(object sender, EventArgs e)
        {
            // Load data into the combo boxes and data grid view
            this.roomTableAdapter.Fill(this.hotelDatabaseDataSet.Room);
            this.guestTableAdapter.Fill(this.hotelDatabaseDataSet.Guest);
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            // Save new booking information
            try
            {
                var newBooking = hotelDatabaseDataSet.Booking.NewBookingRow();
                newBooking.GuestID = (int)cmbGuest.SelectedValue;
                newBooking.RoomNumber = (int)cmbRoom.SelectedValue;
                newBooking.CheckInDate = dtpCheckIn.Value;
                newBooking.CheckOutDate = dtpCheckOut.Value;

                hotelDatabaseDataSet.Booking.AddBookingRow(newBooking);
                BookingTableAdapter.Update(hotelDatabaseDataSet.Booking);

                MessageBox.Show("Booking saved successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving booking: " + ex.Message);
            }
        }

        private void BookingForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.hotelDatabaseDataSet.Room);
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Guest' table. You can move, or remove it, as needed.
            this.guestTableAdapter.Fill(this.hotelDatabaseDataSet.Guest);

        }
    }
}

