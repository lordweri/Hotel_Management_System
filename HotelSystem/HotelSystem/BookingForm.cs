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
            LoadData();
        }

        private void LoadData()
        {
            // Loading data from Room and Guest tables into the ComboBoxes
            this.roomTableAdapter.Fill(this.hotelDatabaseDataSet.Room);
            this.guestTableAdapter.Fill(this.hotelDatabaseDataSet.Guest);
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                int guestId = GetOrCreateGuest();
                if (guestId == -1)
                    return;

                int roomNumber = (int)cmbRoom.SelectedValue;
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                if (!IsRoomAvailable(roomNumber, checkIn, checkOut))
                {
                    ShowError("Selected room is not available for the chosen dates.");
                    return;
                }

                decimal totalRate = CalculateTotalRate(checkIn, checkOut);
                decimal deposit = CalculateDeposit(totalRate);

                string referenceNumber = GenerateReferenceNumber();

                SaveBooking(guestId, roomNumber, checkIn, checkOut, totalRate, deposit, referenceNumber);

                MessageBox.Show($"Booking saved successfully! Reference Number: {referenceNumber}");
            }
            catch (Exception ex)
            {
                ShowError("Error saving booking: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtGuestName.Text) || cmbRoom.SelectedValue == null ||
                dtpCheckIn.Value == DateTime.MinValue || dtpCheckOut.Value == DateTime.MinValue)
            {
                ShowError("Please fill in all required fields.");
                return false;
            }

            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                ShowError("Check-out date must be after check-in date.");
                return false;
            }

            if (nudAdults.Value + nudChildren.Value > 4)
            {
                ShowError("Maximum occupancy per room is 4 people.");
                return false;
            }

            return true;
        }

        private int GetOrCreateGuest()
        {
            var existingGuest = hotelDatabaseDataSet.Guest.FirstOrDefault(g => g.Name == txtGuestName.Text);
            if (existingGuest != null)
                return existingGuest.GuestID;

            try
            {
                var newGuest = hotelDatabaseDataSet.Guest.NewGuestRow();
                newGuest.Name = txtGuestName.Text;
                newGuest.Email = txtEmail.Text; // Use appropriate field for contact
                newGuest.ContactNumber = txtPhone.Text; // Map to ContactNumber field
                hotelDatabaseDataSet.Guest.AddGuestRow(newGuest);
                guestTableAdapter.Update(hotelDatabaseDataSet.Guest);
                return newGuest.GuestID;
            }
            catch (Exception ex)
            {
                ShowError("Error creating new guest: " + ex.Message);
                return -1;
            }
        }

        private bool IsRoomAvailable(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            var overlappingBookings = hotelDatabaseDataSet.Booking.Where(b =>
                b.RoomNumber == roomNumber &&
                !(b.CheckOutDate <= checkIn || b.CheckInDate >= checkOut));

            return !overlappingBookings.Any();
        }

        private decimal CalculateTotalRate(DateTime checkIn, DateTime checkOut)
        {
            decimal totalRate = 0;
            for (DateTime date = checkIn; date < checkOut; date = date.AddDays(1))
            {
                totalRate += GetRoomRateForDate(date); // Simplified, based on RoomRate
            }

            // Apply discounts for children
            int childrenCount = (int)nudChildren.Value;
            if (childrenCount > 0)
            {
                int freeChildren = Math.Min(childrenCount, 1); // One child under 5 stays free
                int halfPriceChildren = Math.Max(0, Math.Min(childrenCount - freeChildren, 2)); // Up to two children 5-16 pay half price

                totalRate -= (freeChildren * totalRate / (int)(nudAdults.Value + nudChildren.Value));
                totalRate -= (halfPriceChildren * totalRate / (int)(nudAdults.Value + nudChildren.Value) / 2);
            }

            return totalRate;
        }

        private decimal GetRoomRateForDate(DateTime date)
        {
            // Assuming room rate is stored in the Room table
            var selectedRoom = hotelDatabaseDataSet.Room.FirstOrDefault(r => r.RoomNumber == (int)cmbRoom.SelectedValue);
            return selectedRoom?.RoomRate ?? 0;
        }

        private decimal CalculateDeposit(decimal totalRate)
        {
            return totalRate * 0.1m; // 10% deposit
        }

        private string GenerateReferenceNumber()
        {
            return "BK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            
        }

        private void SaveBooking(int guestId, int roomNumber, DateTime checkIn, DateTime checkOut, decimal totalRate, decimal deposit, string referenceNumber)
        {
            var newBooking = hotelDatabaseDataSet.Booking.NewBookingRow();
            newBooking.GuestID = guestId;
            newBooking.RoomNumber = roomNumber;
            newBooking.CheckInDate = checkIn;
            newBooking.CheckOutDate = checkOut;
            newBooking.TotalRate = totalRate; // Map to TotalRate field
            hotelDatabaseDataSet.Booking.AddBookingRow(newBooking);
            bookingTableAdapter.Update(hotelDatabaseDataSet.Booking);
            

        }

        private void ShowError(string message)
        {
            errorLabel.Text = message;
        }
    }
}

