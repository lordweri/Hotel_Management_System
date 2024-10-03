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

namespace HotelSystem.Presentation
{
    public partial class RevenueForecastReport : Form
    {
        private BookingController bookingController;

        public RevenueReportForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
        }

        private void btnGenerateRevenueReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            // Fetch revenue data from the BookingController
            var revenueData = bookingController.GetRevenueReport(startDate, endDate);

            // Display the data in DataGridView
            dgvRevenue.DataSource = revenueData;

            // Plot the data on the chart
            chartRevenue.Series.Clear();
            Series series = chartRevenue.Series.Add("Revenue");
            foreach (var data in revenueData)
            {
                series.Points.AddXY(data.Date, data.TotalRevenue);
            }
        }
    }
}
