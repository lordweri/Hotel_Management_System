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
using HotelSystem.Business;
using HotelSystem.Data;

namespace HotelSystem.Presentation
{
    public partial class BookingForm : Form
    {
        private BookingController bookingController;
        private RoomController roomController;
        private GuestController guestController;

        public BookingForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
            roomController = new RoomController();
            guestController = new GuestController();

            LoadComboBoxData();
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadComboBoxData()
        {
            foreach (var room in roomController.AllRooms)
            {
               cmbRoom.Items.Add(room.getRoomNo());  // Assuming Room has a property RoomNumber
            }
        }

        private void LoadData()
        {
            // Assuming dgvBookings is bound to a booking list, populate it
            dgvBookings.DataSource = bookingController.AllBookings;
        }

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                // Get or create the guest
                Guest guest = GetOrCreateGuest();
                if (guest == null)
                    return;

                int roomNumber = int.Parse(cmbRoom.SelectedItem.ToString());
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;

                // Check room availability
                if (!IsRoomAvailable(roomNumber, checkIn, checkOut))
                {
                    ShowError("Selected room is not available for the chosen dates.");
                    return;
                }

                decimal totalRate = CalculateTotalRate(roomNumber, checkIn, checkOut);
                decimal deposit = CalculateDeposit(totalRate);
                string referenceNumber = GenerateReferenceNumber();

                // Create the booking
                Booking newBooking = new Booking(
                    referenceNumber,
                    guest,
                    roomController.GetRoomType(roomNumber),
                    roomController.GetRoomByNumber(roomNumber),
                    checkIn,
                    checkOut,
                    totalRate,
                    deposit
                );

                // Save the booking using controller
                bookingController.DataMaintenance(newBooking, DB.DBOperation.Add);
                bool result = bookingController.FinalizeChanges(newBooking, DB.DBOperation.Add);

                if (result)
                {
                    MessageBox.Show($"Booking saved successfully! Reference Number: {referenceNumber}");
                    LoadData(); // Refresh the booking grid
                }
                else
                {
                    ShowError("Failed to save booking.");
                }
            }
            catch (Exception ex)
            {
                ShowError("Error saving booking: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrEmpty(txtGuestName.Text) || cmbRoom.SelectedItem == null ||
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

        private Guest GetOrCreateGuest()
        {
            // Assuming GetGuestByDetails() is used to get a guest based on details like name and email
            var existingGuest = guestController.GetGuestByDetails(txtGuestName.Text, txtEmail.Text);
            if (existingGuest != null)

                return existingGuest;

            try
            {
                // Create a new guest
                Guest newGuest = new Guest(
                    txtGuestName.Text,
                    txtEmail.Text,
                    txtPhone.Text,
                    txtAddress.Text
                );

                guestController.DataMaintenance(newGuest, DB.DBOperation.Add);
                bool result = guestController.FinalizeChanges(newGuest, DB.DBOperation.Add);

                if (!result)
                    throw new Exception("Failed to save new guest.");

                return newGuest;
            }
            catch (Exception ex)
            {
                ShowError("Error creating new guest: " + ex.Message);
                return null;
            }
        }

        private bool IsRoomAvailable(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            var overlappingBookings = bookingController.AllBookings
                .Where(b => b.room.RoomNumber == roomNumber &&
                            !(b.CheckOut <= checkIn || b.CheckIn >= checkOut));

            return !overlappingBookings.Any();
        }

        private decimal CalculateTotalRate(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            decimal totalRate = 0;
            for (DateTime date = checkIn; date < checkOut; date = date.AddDays(1))
            {
                totalRate += roomController.GetRoomRate(roomNumber);
            }

            // Apply discounts for children
            int childrenCount = (int)nudChildren.Value;
            if (childrenCount > 0)
            {
                int freeChildren = Math.Min(childrenCount, 1);
                int halfPriceChildren = Math.Max(0, Math.Min(childrenCount - freeChildren, 2));

                totalRate -= (freeChildren * totalRate / (int)(nudAdults.Value + nudChildren.Value));
                totalRate -= (halfPriceChildren * totalRate / (int)(nudAdults.Value + nudChildren.Value) / 2);
            }

            return totalRate;
        }

        private decimal CalculateDeposit(decimal totalRate)
        {
            return totalRate * 0.1m;
        }

        private string GenerateReferenceNumber()
        {
            return "BK" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void ShowError(string message)
        {
            errorLabel.Text = message;
        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Event handler if you want to allow row selection in the grid
        }
    }
}
