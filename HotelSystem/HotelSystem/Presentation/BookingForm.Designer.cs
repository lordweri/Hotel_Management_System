﻿namespace HotelSystem.Presentation
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDatabaseDataSet = new HotelSystem.HotelDatabaseDataSet();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.btnSaveBooking = new System.Windows.Forms.Button();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblCheckIn = new System.Windows.Forms.Label();
            this.lblCheckOut = new System.Windows.Forms.Label();
            this.guestTableAdapter = new HotelSystem.HotelDatabaseDataSetTableAdapters.GuestTableAdapter();
            this.roomTableAdapter = new HotelSystem.HotelDatabaseDataSetTableAdapters.RoomTableAdapter();
            this.hotelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblAdults = new System.Windows.Forms.Label();
            this.lblChildren = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.nudAdults = new System.Windows.Forms.NumericUpDown();
            this.nudChildren = new System.Windows.Forms.NumericUpDown();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.hotelDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.hotelDatabaseDataSet;
            // 
            // hotelDatabaseDataSet
            // 
            this.hotelDatabaseDataSet.DataSetName = "HotelDatabaseDataSet";
            this.hotelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbRoom
            // 
            this.cmbRoom.DataSource = this.roomBindingSource;
            this.cmbRoom.DisplayMember = "RoomNumber";
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(118, 258);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(200, 24);
            this.cmbRoom.TabIndex = 1;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataMember = "Room";
            this.roomBindingSource.DataSource = this.hotelDatabaseDataSet;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Location = new System.Drawing.Point(118, 333);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckIn.TabIndex = 2;
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Location = new System.Drawing.Point(118, 401);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(200, 22);
            this.dtpCheckOut.TabIndex = 3;
            // 
            // btnSaveBooking
            // 
            this.btnSaveBooking.Location = new System.Drawing.Point(378, 618);
            this.btnSaveBooking.Name = "btnSaveBooking";
            this.btnSaveBooking.Size = new System.Drawing.Size(202, 51);
            this.btnSaveBooking.TabIndex = 4;
            this.btnSaveBooking.Text = "Save Booking";
            this.btnSaveBooking.UseVisualStyleBackColor = true;
            this.btnSaveBooking.Click += new System.EventHandler(this.btnSaveBooking_Click);
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(24, 48);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(45, 16);
            this.lblGuestName.TabIndex = 5;
            this.lblGuestName.Text = "Guest:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(22, 266);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(47, 16);
            this.lblRoom.TabIndex = 6;
            this.lblRoom.Text = "Room:";
            // 
            // lblCheckIn
            // 
            this.lblCheckIn.AutoSize = true;
            this.lblCheckIn.Location = new System.Drawing.Point(14, 333);
            this.lblCheckIn.Name = "lblCheckIn";
            this.lblCheckIn.Size = new System.Drawing.Size(93, 16);
            this.lblCheckIn.TabIndex = 7;
            this.lblCheckIn.Text = "Check In Date:";
            // 
            // lblCheckOut
            // 
            this.lblCheckOut.AutoSize = true;
            this.lblCheckOut.Location = new System.Drawing.Point(14, 406);
            this.lblCheckOut.Name = "lblCheckOut";
            this.lblCheckOut.Size = new System.Drawing.Size(103, 16);
            this.lblCheckOut.TabIndex = 8;
            this.lblCheckOut.Text = "Check Out Date:";
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // roomTableAdapter
            // 
            this.roomTableAdapter.ClearBeforeFill = true;
            // 
            // hotelDatabaseDataSetBindingSource
            // 
            this.hotelDatabaseDataSetBindingSource.DataSource = this.hotelDatabaseDataSet;
            this.hotelDatabaseDataSetBindingSource.Position = 0;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(118, 48);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(200, 22);
            this.txtGuestName.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 10;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(24, 653);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 16);
            this.errorLabel.TabIndex = 11;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 187);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(49, 16);
            this.lblPhone.TabIndex = 12;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(24, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(61, 16);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address:";
            // 
            // lblAdults
            // 
            this.lblAdults.AutoSize = true;
            this.lblAdults.Location = new System.Drawing.Point(24, 489);
            this.lblAdults.Name = "lblAdults";
            this.lblAdults.Size = new System.Drawing.Size(47, 16);
            this.lblAdults.TabIndex = 14;
            this.lblAdults.Text = "Adults:";
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Location = new System.Drawing.Point(22, 558);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(56, 16);
            this.lblChildren.TabIndex = 15;
            this.lblChildren.Text = "Children";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(118, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 22);
            this.txtPhone.TabIndex = 16;
            // 
            // nudAdults
            // 
            this.nudAdults.Location = new System.Drawing.Point(118, 482);
            this.nudAdults.Name = "nudAdults";
            this.nudAdults.Size = new System.Drawing.Size(200, 22);
            this.nudAdults.TabIndex = 17;
            // 
            // nudChildren
            // 
            this.nudChildren.Location = new System.Drawing.Point(118, 558);
            this.nudChildren.Name = "nudChildren";
            this.nudChildren.Size = new System.Drawing.Size(200, 22);
            this.nudChildren.TabIndex = 18;
            // 
            // dgvBookings
            // 
            this.dgvBookings.AutoGenerateColumns = false;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.DataSource = this.hotelDatabaseDataSetBindingSource1;
            this.dgvBookings.Location = new System.Drawing.Point(617, 145);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.RowHeadersWidth = 51;
            this.dgvBookings.RowTemplate.Height = 24;
            this.dgvBookings.Size = new System.Drawing.Size(399, 390);
            this.dgvBookings.TabIndex = 19;
            // 
            // hotelDatabaseDataSetBindingSource1
            // 
            this.hotelDatabaseDataSetBindingSource1.DataSource = this.hotelDatabaseDataSet;
            this.hotelDatabaseDataSetBindingSource1.Position = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(378, 53);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 16);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(428, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 725);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dgvBookings);
            this.Controls.Add(this.nudChildren);
            this.Controls.Add(this.nudAdults);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.lblAdults);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblCheckOut);
            this.Controls.Add(this.lblCheckIn);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.btnSaveBooking);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.cmbRoom);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.Click += new System.EventHandler(this.BookingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChildren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.Button btnSaveBooking;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblCheckIn;
        private System.Windows.Forms.Label lblCheckOut;
        private HotelDatabaseDataSet hotelDatabaseDataSet;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private HotelDatabaseDataSetTableAdapters.GuestTableAdapter guestTableAdapter;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private HotelDatabaseDataSetTableAdapters.RoomTableAdapter roomTableAdapter;
        private System.Windows.Forms.BindingSource hotelDatabaseDataSetBindingSource;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblAdults;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.NumericUpDown nudAdults;
        private System.Windows.Forms.NumericUpDown nudChildren;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.BindingSource hotelDatabaseDataSetBindingSource1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
    }
}