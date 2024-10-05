using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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
        private void btnSignIn_Click(object sender, EventArgs e)
        {

        }



        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "BookingID")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "BookingID";
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void pnlUserId_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, pnlUserID.ClientRectangle, 20, Color.LightGray);
        }

        private void pnlPassword_Paint(object sender, PaintEventArgs e)
        {
            DrawRoundedRectangle(e.Graphics, pnlPassword.ClientRectangle, 20, Color.LightGray);
        }

        private void DrawRoundedRectangle(Graphics g, Rectangle r, int d, Color color)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(r.X, r.Y, d, d, 180, 90);
                path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(color, 1))
                {
                    g.SmoothingMode = SmoothingMode.AntiAlias;
                    g.DrawPath(pen, path);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
            
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
