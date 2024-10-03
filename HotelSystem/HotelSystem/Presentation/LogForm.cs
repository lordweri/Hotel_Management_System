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
    public partial class LoginForm : Form
    {
        private const string EmpID = "HTL013";
        private const string password1 = "phumlaisthebest";
        public LoginForm()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
        }
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            string userId = txtUserId.Text;
            string password = txtPassword.Text;

            if (userId == EmpID && password == password1)
            {

                MainForm mainForm = new MainForm(); 
                mainForm.Show();
                this.Hide(); 

            }
            else if(userId == EmpID && password != password1)
            {
                  label2.Visible = true;
 
            }
            else
            {
                label3.Visible = true;

            }
        }

        private void txtUserId_Enter(object sender, EventArgs e)
        {
            if (txtUserId.Text == "ID")
            {
                txtUserId.Text = "";
                txtUserId.ForeColor = Color.Black;
            }
        }

        private void txtUserId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserId.Text))
            {
                txtUserId.Text = "ID";
                txtUserId.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
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
                txtPassword.Text = "Password";
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
    }
}
