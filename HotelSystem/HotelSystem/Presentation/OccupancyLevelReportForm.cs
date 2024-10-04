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
        // Controller for handling booking-related operations
        private BookingController bookingController;

        public OccupancyLevelReportForm()
        {
            InitializeComponent();
            // Initialize the booking controller
            bookingController = new BookingController();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // Set the data source for the DataGridView when the form loads
            dgvOccupancy.DataSource = hotelDatabaseDataSet.Booking;
        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // Get the start and end dates from the date time pickers
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Validate that the start date is before the end date
            if (startDate > endDate)
            {
                MessageBox.Show("Start date must be before end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Show loading indicator to inform the user that data is being processed
                UseWaitCursor = true;

                // Fetch occupancy data from the BookingController asynchronously to prevent UI freezing
                var occupancyData = await Task.Run(() => bookingController.GetOccupancyLevelReport(startDate, endDate));

                // Check if the returned data is valid and not empty
                if (occupancyData is IEnumerable<OccupancyData> occupancyDataList && occupancyDataList.Any())
                {
                    // Display the data in DataGridView
                    dgvOccupancy.DataSource = occupancyDataList;

                    // Plot the data on the chart
                    UpdateChart(occupancyDataList);
                }
                else
                {
                    // Inform the user if no data is available for the selected date range
                    MessageBox.Show("No occupancy data available for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process and inform the user
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Hide loading indicator after processing is complete
                UseWaitCursor = false;
            }
        }

        private void UpdateChart(IEnumerable<OccupancyData> occupancyDataList)
        {
            // Clear any existing series in the chart
            chartOccupancyLevel.Series.Clear();

            // Add a new series to the chart
            Series series = chartOccupancyLevel.Series.Add("Occupancy");

            // Set the chart type to a line graph
            series.ChartType = SeriesChartType.Line;

            // Iterate through the occupancy data and add each point to the chart
            foreach (OccupancyData data in occupancyDataList)
            {
                series.Points.AddXY(data.Date, data.OccupancyPercentage);
            }

            // Customize chart appearance for better readability
            // Set the X-axis title
            chartOccupancyLevel.ChartAreas[0].AxisX.Title = "Date";

            // Set the Y-axis title
            chartOccupancyLevel.ChartAreas[0].AxisY.Title = "Occupancy %";

            // Set the minimum value of the Y-axis to 0
            chartOccupancyLevel.ChartAreas[0].AxisY.Minimum = 0;

            // Set the maximum value of the Y-axis to 100 (percentage)
            chartOccupancyLevel.ChartAreas[0].AxisY.Maximum = 100;

            // Add a title to the chart
            chartOccupancyLevel.Titles.Add("Hotel Occupancy Level");
        }
    }
}
