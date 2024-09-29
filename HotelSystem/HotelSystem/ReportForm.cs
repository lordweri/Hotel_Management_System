using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Booking' table. You can move, or remove it, as needed.
            this.bookingTableAdapter.Fill(this.hotelDatabaseDataSet.Booking);

            this.guestTableAdapter.Fill(this.hotelDatabaseDataSet.Guest);

            // Set data sources for report viewer
            // Assuming you're using a DataGridView to show report data
            dataGridViewBookings.DataSource = hotelDatabaseDataSet.Booking;
            
        }
    }
}
