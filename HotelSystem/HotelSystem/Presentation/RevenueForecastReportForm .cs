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
        private BookingController bookingController;

        public RevenueForecastReport()
        {
            InitializeComponent();
            bookingController = new BookingController();
        }
        // method to generate revenue report based on start and end dates-BRWCAL007
        private void btnGenerateRevenueReport_Click(object sender, EventArgs e)
        {
            // Get the start and end dates from the date pickers
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            try
            {
                // Fetch revenue data from the BookingController
                var revenueData = bookingController.GetRevenueReport(startDate, endDate);

                // Display the data in DataGridView
                dgvRevenue.DataSource = revenueData;

                // Plot the data on the chart
                PlotRevenueDataOnChart(revenueData);
            }
            catch (Exception ex)
            {
                // Handle any exceptions that occur during the process
                MessageBox.Show(ex.Message);
            }
        }

        private void PlotRevenueDataOnChart(List<RevenueData> revenueData)
        {
            // Clear any existing series on the chart
            chartRevenue.Series.Clear();

            // Create a new series for the revenue data
            Series series = chartRevenue.Series.Add("Revenue");

            // Iterate through each data point and add it to the chart
            foreach (var data in revenueData)
            {
                series.Points.AddXY(data.Date, data.TotalRevenue);
            }
        }
    }
}
