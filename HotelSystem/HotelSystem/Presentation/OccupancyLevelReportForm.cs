using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using HotelSystem.Business; 

namespace HotelSystem.Presentation
{
    public partial class OccupancyLevelReportForm : Form
    {
        private BookingController bookingController;

        public OccupancyLevelReportForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dgvOccupancy.DataSource = hotelDatabaseDataSet.Booking;
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Fetch occupancy data from the BookingController
            var occupancyData = bookingController.GetOccupancyLevelReport(startDate, endDate);

            if (occupancyData is IEnumerable<OccupancyData> occupancyDataList)
            {
                // Display the data in DataGridView
                dgvOccupancy.DataSource = occupancyDataList;

                // Plot the data on the chart
                chartOccupancyLevel.Series.Clear();
                Series series = chartOccupancyLevel.Series.Add("Occupancy");

                // Iterate over the occupancyDataList
                foreach (OccupancyData data in occupancyDataList)
                {
                    series.Points.AddXY(data.Date, data.OccupancyPercentage);
                }
            }
            else
            {
                // Handle the case when occupancyData is not a collectionh
                // You can display an error message or take other appropriate actions
                MessageBox.Show("Invalid occupancy data");
            }
        }
    }
}
