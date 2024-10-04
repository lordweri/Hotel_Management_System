using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.Presentation
{
    public partial class ChangeReserveForm : Form
    {
        public ChangeReserveForm()
        {
            InitializeComponent();
        }

        private void TxtUserId_Enter(object sender, EventArgs e)
        {
            if (txtUserId.Text == "BookingID")
            {
                txtUserId.Text = "";
                txtUserId.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TxtUserId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserId.Text))
            {
                txtUserId.Text = "BookingID";
                txtUserId.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "GuestID")
            {
                textBox1.Text = "";
                textBox1.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "GuestID";
                textBox1.ForeColor = System.Drawing.Color.Gray;
            }
        }

    }
}
