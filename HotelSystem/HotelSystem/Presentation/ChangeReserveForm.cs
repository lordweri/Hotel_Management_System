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

            txtBookingIDSearch.ReadOnly = true;
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
                }
                else
                {
                    MessageBox.Show("Booking not found!");
                }
            }
        }

            //"txtBookingID" textbox
            private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtBookingIDSearch.Text == "BookingID")
            {
                txtBookingIDSearch.Text = "";
                txtBookingIDSearch.ForeColor = Color.Black;
                txtBookingIDSearch.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookingIDSearch.Text))
            {
                txtBookingIDSearch.UseSystemPasswordChar = false;
                txtBookingIDSearch.Text = "BookingID";
                txtBookingIDSearch.ForeColor = Color.Gray;
            }
        }

        /*
        private void pnlUserId_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, pnlUserID.ClientRectangle, 20, Color.LightGray);
        }

        private void pnlPassword_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, pnlPassword.ClientRectangle, 20, Color.LightGray);
        }

        private void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Color color)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(r.X, r.Y, d, d, 180, 90);
                path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(color, 1))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawPath(pen, path);
                }
            }
        }*/

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
    }
}
