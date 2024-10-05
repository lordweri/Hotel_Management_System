using System.Drawing;
using System.Windows.Forms;

namespace HotelSystem.Presentation
{
    partial class ChangeReserveForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeReserveForm));
            this.txtBookingIDSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCheckOutDate = new System.Windows.Forms.TextBox();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBookingIDSearch
            // 
            this.txtBookingIDSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBookingIDSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBookingIDSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBookingIDSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtBookingIDSearch.Location = new System.Drawing.Point(118, 137);
            this.txtBookingIDSearch.Name = "txtBookingIDSearch";
            this.txtBookingIDSearch.Size = new System.Drawing.Size(322, 32);
            this.txtBookingIDSearch.TabIndex = 1;
            this.txtBookingIDSearch.Text = "BookingID";
            this.txtBookingIDSearch.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtBookingIDSearch.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtBookingIDSearch.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(2, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 114);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 64);
            this.label1.TabIndex = 7;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(314, 448);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 11;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(308, 381);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 12;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(2, 734);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(527, 131);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 44);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.Location = new System.Drawing.Point(292, 432);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(142, 28);
            this.txtCheckOutDate.TabIndex = 47;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Location = new System.Drawing.Point(292, 387);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.Size = new System.Drawing.Size(142, 28);
            this.txtCheckInDate.TabIndex = 46;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(292, 340);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(142, 28);
            this.txtRoomNumber.TabIndex = 45;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(678, 261);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(193, 28);
            this.txtGuestID.TabIndex = 43;
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(292, 261);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(142, 28);
            this.txtBookingID.TabIndex = 42;
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(156, 443);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(143, 18);
            this.lblCheckOutDate.TabIndex = 40;
            this.lblCheckOutDate.Text = "Check Out Date:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(156, 398);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(134, 18);
            this.lblCheckInDate.TabIndex = 39;
            this.lblCheckInDate.Text = "Check In Date:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(156, 351);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(116, 18);
            this.lblRoomNumber.TabIndex = 38;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(156, 307);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(89, 18);
            this.lblRoomType.TabIndex = 37;
            this.lblRoomType.Text = "RoomType:";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(528, 271);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(80, 18);
            this.lblGuestID.TabIndex = 36;
            this.lblGuestID.Text = "GuestID:";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(156, 272);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(98, 18);
            this.lblBookingID.TabIndex = 35;
            this.lblBookingID.Text = "BookingID:";
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingDetails.Location = new System.Drawing.Point(112, 207);
            this.lblBookingDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(194, 32);
            this.lblBookingDetails.TabIndex = 34;
            this.lblBookingDetails.Text = "Booking Details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.LightGreen;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(889, 627);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 44);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(292, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(142, 28);
            this.textBox2.TabIndex = 58;
            // 
            // ChangeReserveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1176, 777);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtCheckOutDate);
            this.Controls.Add(this.txtCheckInDate);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.lblBookingDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBookingIDSearch);
            this.Name = "ChangeReserveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBookingIDSearch;
        private Panel panel1;
        private Label label1;
        private System.Windows.Forms.Panel pnlUserID;
        private System.Windows.Forms.Label pnlPassword;
        private Label label2;
        private Label label3;
        private Button btnBack;
        private Button btnSearch;
        private TextBox txtCheckOutDate;
        private TextBox txtCheckInDate;
        private TextBox txtRoomNumber;
        private TextBox txtGuestID;
        private TextBox txtBookingID;
        private Label lblCheckOutDate;
        private Label lblCheckInDate;
        private Label lblRoomNumber;
        private Label lblRoomType;
        private Label lblGuestID;
        private Label lblBookingID;
        private Label lblBookingDetails;
        private Button btnUpdate;
        private TextBox textBox2;
    }
}