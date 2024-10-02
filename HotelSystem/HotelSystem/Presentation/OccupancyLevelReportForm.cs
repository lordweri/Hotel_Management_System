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
    public partial class OccupancyLevelReportForm : Form
    {
        public OccupancyLevelReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            dgvOccupancy.DataSource = hotelDatabaseDataSet.Booking;
            
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {

        }
    }
}
