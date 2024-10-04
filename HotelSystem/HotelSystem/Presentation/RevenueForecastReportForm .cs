using HotelSystem.Business;
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
using static HotelSystem.Business.BookingController;

namespace HotelSystem.Presentation
{
    public partial class RevenueForecastReport : Form
    {
        // Instance of the BookingController class to access its methods and properties.

        private readonly BookingController bookingController;
        // Constructor to initialize the form and the BookingController instance to access its methods and properties.
        public RevenueForecastReport()
        {
            InitializeComponent();
            bookingController = new BookingController();
        }
        // Method to generate revenue report based on start and end dates-BRWCAL007
        private void btnGenerateRevenueReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date; // Get the start date from the date picker and ensure it's only the date (no time)
            DateTime endDate = dtpEndDate.Value.Date; // Get the end date from the date picker and ensure it's only the date (no time)

            try
            {
                // Get revenue report data between the specified start and end dates
                var revenueData = bookingController.GetRevenueReport(startDate, endDate);

                // Handle case where no revenue data is returned
                if (revenueData == null || revenueData.Count == 0)
                {
                    MessageBox.Show("No revenue data found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit if no data is found
                }

                // Display the revenue data in the data grid view
                dgvRevenue.DataSource = revenueData;

                // Plot the revenue data on the chart
                PlotRevenueDataOnChart(revenueData);
            }
            catch (Exception ex)
            {
                // Display an error message if an exception occurs
                MessageBox.Show($"An error occurred while generating the report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Method to plot the revenue data on the chart
        private void PlotRevenueDataOnChart(List<RevenueData> revenueData)
        {
            // Clear any existing series on the chart
            chartRevenue.Series.Clear();

            // Create a new series for the revenue data
            Series series = chartRevenue.Series.Add("Revenue");
            series.ChartType = SeriesChartType.Line; // Set the chart type to line

            // Iterate through each data point and add it to the chart
            foreach (var data in revenueData)
            {
                series.Points.AddXY(data.Date.ToShortDateString(), data.TotalRevenue); // Display date as short string
            }

            // Set the axis titles and minimum value for the chart
            chartRevenue.ChartAreas[0].AxisX.Title = "Date"; // Set the X-axis title to "Date"
            chartRevenue.ChartAreas[0].AxisY.Title = "Total Revenue"; // Set the Y-axis title to "Total Revenue"
            chartRevenue.ChartAreas[0].AxisY.Minimum = 0; // Set the minimum value of the Y-axis to 0

            // Add a title to the chart
            chartRevenue.Titles.Clear(); // Clear previous titles
            chartRevenue.Titles.Add("Revenue Forecast Report"); // Add a title to the chart
        }

        // Method to close the form and navigate back to the MainForm
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the main form
            MainForm mainForm = new MainForm();

            // Show the main form
            mainForm.Show();

            // Close the form or navigate back to the main form
            this.Close();
        }
    }
}