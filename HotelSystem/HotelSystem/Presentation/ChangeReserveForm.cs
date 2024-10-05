using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Business;

namespace HotelSystem.Presentation
{
    public partial class ChangeReserveForm : Form
    {
        BookingController bookingController;
        Collection<Booking> bookings;
        Booking booking;

        public ChangeReserveForm(BookingController bookingController)
        {
            InitializeComponent();
            this.bookingController = bookingController;
            bookings = bookingController.AllBookings;

            txtBookingID.ReadOnly = true;
            txtGuestID.ReadOnly = true;
            txtRoomNumber.ReadOnly = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            foreach (Booking booking in bookings)
            {
                if (booking.GetBookingID() == txtBookingIDSearch.Text)
                {
                    this.booking = booking;
                    MessageBox.Show("Booking found!");
                    txtBookingID.Text = booking.GetBookingID();
                    txtCheckInDate.Text = booking.CheckIn.ToString();
                    txtCheckOutDate.Text = booking.CheckOut.ToString();
                    txtRoomNumber.Text = booking.GetRoom().getRoomNo();
                    txtGuestID.Text = booking.GetGuest().getGuestID();
                    break;
                }
                else
                {
                    MessageBox.Show("Booking not found!");
                    break;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bookingController.DataMaintenance(booking, Data.DB.DBOperation.Edit);
            bookingController.FinalizeChanges(booking, Data.DB.DBOperation.Edit);
            MessageBox.Show("Booking updated!");
        }

        private void ChangeReserveForm_Load(object sender, EventArgs e)
        {

        }
    }
}
