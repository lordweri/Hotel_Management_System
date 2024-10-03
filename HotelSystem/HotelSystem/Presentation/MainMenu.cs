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
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }

        private void btnChangeReservation_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            // Add your logic here
        }
     
        private void button1_Click(object sender, EventArgs e)
        {

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
            OccupancyLevelReportForm reportForm = new OccupancyLevelReportForm();
            reportForm.Show();
        }
        // access to the Revenue Forecast Form from the main menu-BRWCAL007
        private void btnRevenueForecast_Click(object sender, EventArgs e)
        {

        }
    }
}