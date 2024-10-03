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
    public partial class DateCheckForm : Form
    {
        public DateCheckForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value;
            DateTime endDate = dateTimePickerEndDate.Value;

            // Validate dates
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Your logic to check availability goes here
            MessageBox.Show($"Searching availability from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.", "Searching", MessageBoxButtons.OK);
        }

        private void DateCheckForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.hotelDatabaseDataSet.Booking);

        }

        // event handler to continue to the Bookings Changed form when the button is clicked-BRWCAL007
        private void btnContinue_Click(object sender, EventArgs e)
        {
            BookingChangedForm bookingChangedForm = new BookingChangedForm();
            bookingChangedForm.Show();
            this.Hide(); // Hide the current form

        }
        // event handler to go back to the Main Menu Form when the button is clicked-BRWCAL007
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the main menu form
            MainForm mainForm = new MainForm();

            // Show the main menu form
            mainForm.Show();

            // Close the current form (BookingChangedForm)
            this.Close();
        }
    }
}
