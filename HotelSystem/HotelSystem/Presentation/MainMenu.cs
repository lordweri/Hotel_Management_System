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

namespace HotelSystem.Presentation
{
    public partial class MainForm : Form
    {
        BookingController bookingController;

        public MainForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            DateCheckForm dateForm = new DateCheckForm(bookingController);
            dateForm.Show();
            this.Close();
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            ChangeReserveForm changeReserveForm = new ChangeReserveForm();
            changeReserveForm.Show();
            this.Close();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            ChangeReserveForm newChangeReserveForm = new ChangeReserveForm();
            newChangeReserveForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // access to the Occupancy Level Report Form from the main menu-BRWCAL007
        private void btnOccupancyReport_Click(object sender, EventArgs e)
        {
            try
            {
                OccupancyLevelReportForm reportForm = new OccupancyLevelReportForm();
                reportForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Occupancy Level Report Form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // access to the Revenue Forecast Report from the main menu-BRWCAL007
        private void btnRevenueForecast_Click(object sender, EventArgs e)
        {
            try
            {
                RevenueForecastReport reportForm = new RevenueForecastReport();
                reportForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the Revenue Forecast Report Form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}