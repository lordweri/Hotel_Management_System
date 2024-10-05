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
using System.IO;

namespace HotelSystem.Presentation
{
    // This class contains the logic for generating the occupancy level report for the selected date range-BRWCAL007
    public partial class OccupancyLevelReportForm : Form
    {
        // Controller for handling booking-related operations
        // This is declared as readonly to ensure it's not accidentally reassigned
        private readonly BookingController bookingController;

        public OccupancyLevelReportForm()
        {
            // Initialize the form's components (e.g., buttons, labels) defined in the designer
            InitializeComponent();

            // Create a new instance of BookingController to handle business logic
            // This separation of concerns keeps the UI code clean and maintainable
            bookingController = new BookingController();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            // When the form loads, set the DataGridView's data source
            // This populates the grid with initial booking data
            dgvOccupancy.DataSource = hotelDatabaseDataSet.Booking;
        }
        // This method generates the occupancy level report for the selected date range-BRWCAL007
        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // First, validate the date range selected by the user
            if (!ValidateDateRange())
            {
                // If validation fails, exit the method early
                return;
            }

            // If validation passes, generate the report asynchronously
            // This ensures the UI remains responsive during the operation
            await GenerateReportAsync();
        }
        // This method validates the date range selected by the user-BRWCAL007
        private bool ValidateDateRange()
        {
            // Get the start and end dates from the date time pickers
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Check if the start date is after the end date
            if (startDate > endDate)
            {
                // If so, show an error message to the user
                MessageBox.Show("Start date must be before end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Return false to indicate validation failure
                return false;
            }

            // If we reach here, the date range is valid
            return true;
        }
        // This method generates the occupancy level report for the selected date range-BRWCAL007
        private async Task GenerateReportAsync()
        {
            try
            {
                // Disable UI elements to prevent multiple requests
                SetFormState(false);

                // Get the selected date range
                DateTime startDate = dtpStartDate.Value;
                DateTime endDate = dtpEndDate.Value;

                // Use Task.Run to run the synchronous method asynchronously
                // This prevents UI freezing for long-running operations
                var occupancyData = await Task.Run(() => bookingController.GetOccupancyLevelReport(startDate, endDate));

                // Check if we received valid data
                if (occupancyData != null && occupancyData.Any())
                {
                    // Update the DataGridView with the new data
                    dgvOccupancy.DataSource = occupancyData;
                    // Update the chart with the new data
                    UpdateChart(occupancyData);
                }
                else
                {
                    // If no data is available, inform the user
                    MessageBox.Show("No occupancy data available for the selected date range.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // If an error occurs, log it and inform the user
                LogError(ex);
                MessageBox.Show($"An error occurred while generating the report. Please check the log for details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Re-enable UI elements, regardless of success or failure
                SetFormState(true);
            }
        }
        // This method updates the chart with the new data-BRWCAL007
        private void UpdateChart(IEnumerable<OccupancyData> occupancyDataList)
        {
            // Clear any existing series in the chart to prepare for new data
            chartOccupancyLevel.Series.Clear();

            // Add a new series to the chart for the occupancy data
            Series series = chartOccupancyLevel.Series.Add("Occupancy");

            // Set the chart type to a line graph for trend visualization
            series.ChartType = SeriesChartType.Line;

            // Iterate through the occupancy data and add each point to the chart
            foreach (OccupancyData data in occupancyDataList)
            {
                series.Points.AddXY(data.Date, data.OccupancyPercentage);
            }

            // Customize chart appearance for better readability
            // Set the X-axis title to "Date"
            chartOccupancyLevel.ChartAreas[0].AxisX.Title = "Date";

            // Set the Y-axis title to "Occupancy %"
            chartOccupancyLevel.ChartAreas[0].AxisY.Title = "Occupancy %";

            // Set the minimum value of the Y-axis to 0 for consistency
            chartOccupancyLevel.ChartAreas[0].AxisY.Minimum = 0;

            // Set the maximum value of the Y-axis to 100 (percentage)
            chartOccupancyLevel.ChartAreas[0].AxisY.Maximum = 100;

            // Clear any existing titles and add a new title to the chart
            chartOccupancyLevel.Titles.Clear();
            chartOccupancyLevel.Titles.Add("Hotel Occupancy Level");
        }
        // method to return to the MainForm when the back button is clicked-BRWCAL007
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create a new instance of the main menu form
            MainForm mainForm = new MainForm();

            // Close the current form to return to the main menu
            this.Close();

            // Show the main menu form
            mainForm.Show();
        }
        // This method sets the form state and enables or disables UI elements based on the 'enabled' parameter-BRWCAL007
        private void SetFormState(bool enabled)
        {
            // Enable or disable UI elements based on the 'enabled' parameter
            // This prevents user interaction during report generation
            btnGenerateReport.Enabled = enabled;
            dtpStartDate.Enabled = enabled;
            dtpEndDate.Enabled = enabled;
            // Set the wait cursor to indicate processing (inverse of 'enabled')
            UseWaitCursor = !enabled;
        }
        // This method logs an error to a log file and displays an error message to the user-BRWCAL007
        private void LogError(Exception ex)
        {
            // Determine the path for the error log file
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");

            // Append the error details to the log file
            using (StreamWriter writer = File.AppendText(logPath))
            {
                // Write the current date and time along with the error message
                writer.WriteLine($"[{DateTime.Now}] Error: {ex.Message}");
                // Write the full stack trace for debugging purposes
                writer.WriteLine($"StackTrace: {ex.StackTrace}");
                // Add a separator line for readability between log entries
                writer.WriteLine(new string('-', 50));
            }
        }
    }
}
