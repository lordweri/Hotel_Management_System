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

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be before end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Show loading indicator
                UseWaitCursor = true;

                // Fetch occupancy data from the BookingController asynchronously
                var occupancyData = await Task.Run(() => bookingController.GetOccupancyLevelReport(startDate, endDate));

                if (occupancyData is IEnumerable<OccupancyData> occupancyDataList && occupancyDataList.Any())
                {
                    // Display the data in DataGridView
                    dgvOccupancy.DataSource = occupancyDataList;

                    // Plot the data on the chart
                    UpdateChart(occupancyDataList);
                }
                else
                {
                    MessageBox.Show("No occupancy data available for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Hide loading indicator
                UseWaitCursor = false;
            }
        }

        private void UpdateChart(IEnumerable<OccupancyData> occupancyDataList)
        {
            chartOccupancyLevel.Series.Clear();
            Series series = chartOccupancyLevel.Series.Add("Occupancy");
            series.ChartType = SeriesChartType.Line;

            foreach (OccupancyData data in occupancyDataList)
            {
                series.Points.AddXY(data.Date, data.OccupancyPercentage);
            }

            // Customize chart appearance
            chartOccupancyLevel.ChartAreas[0].AxisX.Title = "Date";
            chartOccupancyLevel.ChartAreas[0].AxisY.Title = "Occupancy %";
            chartOccupancyLevel.ChartAreas[0].AxisY.Minimum = 0;
            chartOccupancyLevel.ChartAreas[0].AxisY.Maximum = 100;
            chartOccupancyLevel.Titles.Add("Hotel Occupancy Level");
        }
    }
}
