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
        private readonly BookingController bookingController;

        public RevenueForecastReport()
        {
            InitializeComponent();
            bookingController = new BookingController();
        }
        // Method to generate revenue report based on start and end date-BRWCAL007
        private void btnGenerateRevenueReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value.Date; // Ensure we use Date
            DateTime endDate = dtpEndDate.Value.Date; // Ensure we use Date

            try
            {
                // Get revenue report data between the specified start and end dates
                var revenueData = bookingController.GetRevenueReport(startDate, endDate);

                // Handle case where no revenue data is returned
                if (revenueData == null || revenueData.Count == 0)
                {
                    MessageBox.Show("No revenue data found for the selected date range.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Exit if no data
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

        private void PlotRevenueDataOnChart(List<RevenueData> revenueData)
        {
            // Clear any existing series on the chart
            chartRevenue.Series.Clear();

            // Create a new series for the revenue data
            Series series = chartRevenue.Series.Add("Revenue");
            series.ChartType = SeriesChartType.Line;

            // Iterate through each data point and add it to the chart
            foreach (var data in revenueData)
            {
                series.Points.AddXY(data.Date.ToShortDateString(), data.TotalRevenue); // Display date as short string
            }

            // Set the axis titles and minimum value for the chart
            chartRevenue.ChartAreas[0].AxisX.Title = "Date";
            chartRevenue.ChartAreas[0].AxisY.Title = "Total Revenue";
            chartRevenue.ChartAreas[0].AxisY.Minimum = 0;

            // Add a title to the chart
            chartRevenue.Titles.Clear(); // Clear previous titles
            chartRevenue.Titles.Add("Revenue Forecast Report");
        }

        // Method to close the form and navigate back to the MainForm-BRWCAL007
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