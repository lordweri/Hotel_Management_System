namespace HotelSystem.Presentation
{
    partial class BookForm
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up resources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            this.lblBookingDetails = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.lblGuestID = new System.Windows.Forms.Label();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblCheckInDate = new System.Windows.Forms.Label();
            this.lblCheckOutDate = new System.Windows.Forms.Label();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.txtGuestID = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.txtCheckInDate = new System.Windows.Forms.TextBox();
            this.txtCheckOutDate = new System.Windows.Forms.TextBox();
            this.txtNumberOfDays = new System.Windows.Forms.TextBox();
            this.txtDeposit = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.lblGuestName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.rbtPayDeposit = new System.Windows.Forms.RadioButton();
            this.rbtPayFull = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmountToPay = new System.Windows.Forms.Label();
            this.txtAmountToPay = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingDetails.Location = new System.Drawing.Point(107, 146);
            this.lblBookingDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(194, 32);
            this.lblBookingDetails.TabIndex = 0;
            this.lblBookingDetails.Text = "Booking Details";
            this.lblBookingDetails.Click += new System.EventHandler(this.lblBookingDetails_Click);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.LightGreen;
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.Location = new System.Drawing.Point(910, 730);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(261, 48);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.BtnMakePayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(-3, 730);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 48);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 107);
            this.panel1.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightGreen;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(420, 730);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(261, 48);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Location = new System.Drawing.Point(150, 210);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(98, 18);
            this.lblBookingID.TabIndex = 8;
            this.lblBookingID.Text = "BookingID:";
            // 
            // lblGuestID
            // 
            this.lblGuestID.AutoSize = true;
            this.lblGuestID.Location = new System.Drawing.Point(522, 209);
            this.lblGuestID.Name = "lblGuestID";
            this.lblGuestID.Size = new System.Drawing.Size(80, 18);
            this.lblGuestID.TabIndex = 9;
            this.lblGuestID.Text = "GuestID:";
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Location = new System.Drawing.Point(150, 245);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(89, 18);
            this.lblRoomType.TabIndex = 10;
            this.lblRoomType.Text = "RoomType:";
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(150, 289);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(116, 18);
            this.lblRoomNumber.TabIndex = 11;
            this.lblRoomNumber.Text = "Room Number:";
            // 
            // lblCheckInDate
            // 
            this.lblCheckInDate.AutoSize = true;
            this.lblCheckInDate.Location = new System.Drawing.Point(150, 336);
            this.lblCheckInDate.Name = "lblCheckInDate";
            this.lblCheckInDate.Size = new System.Drawing.Size(134, 18);
            this.lblCheckInDate.TabIndex = 12;
            this.lblCheckInDate.Text = "Check In Date:";
            // 
            // lblCheckOutDate
            // 
            this.lblCheckOutDate.AutoSize = true;
            this.lblCheckOutDate.Location = new System.Drawing.Point(150, 381);
            this.lblCheckOutDate.Name = "lblCheckOutDate";
            this.lblCheckOutDate.Size = new System.Drawing.Size(143, 18);
            this.lblCheckOutDate.TabIndex = 13;
            this.lblCheckOutDate.Text = "Check Out Date:";
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(150, 425);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(143, 18);
            this.lblNumberOfDays.TabIndex = 14;
            this.lblNumberOfDays.Text = "Number of days:";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Location = new System.Drawing.Point(890, 436);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(80, 18);
            this.lblDeposit.TabIndex = 15;
            this.lblDeposit.Text = "Deposit:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(890, 475);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(116, 18);
            this.lblTotalPrice.TabIndex = 16;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Location = new System.Drawing.Point(286, 199);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(100, 28);
            this.txtBookingID.TabIndex = 17;
            // 
            // txtGuestID
            // 
            this.txtGuestID.Location = new System.Drawing.Point(672, 199);
            this.txtGuestID.Name = "txtGuestID";
            this.txtGuestID.Size = new System.Drawing.Size(100, 28);
            this.txtGuestID.TabIndex = 18;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Location = new System.Drawing.Point(286, 234);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(100, 28);
            this.txtRoomType.TabIndex = 19;
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(286, 278);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 28);
            this.txtRoomNumber.TabIndex = 20;
            // 
            // txtCheckInDate
            // 
            this.txtCheckInDate.Location = new System.Drawing.Point(291, 325);
            this.txtCheckInDate.Name = "txtCheckInDate";
            this.txtCheckInDate.Size = new System.Drawing.Size(100, 28);
            this.txtCheckInDate.TabIndex = 21;
            // 
            // txtCheckOutDate
            // 
            this.txtCheckOutDate.Location = new System.Drawing.Point(300, 370);
            this.txtCheckOutDate.Name = "txtCheckOutDate";
            this.txtCheckOutDate.Size = new System.Drawing.Size(100, 28);
            this.txtCheckOutDate.TabIndex = 22;
            // 
            // txtNumberOfDays
            // 
            this.txtNumberOfDays.Location = new System.Drawing.Point(300, 414);
            this.txtNumberOfDays.Name = "txtNumberOfDays";
            this.txtNumberOfDays.Size = new System.Drawing.Size(100, 28);
            this.txtNumberOfDays.TabIndex = 23;
            // 
            // txtDeposit
            // 
            this.txtDeposit.Location = new System.Drawing.Point(1040, 425);
            this.txtDeposit.Name = "txtDeposit";
            this.txtDeposit.Size = new System.Drawing.Size(100, 28);
            this.txtDeposit.TabIndex = 24;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(1040, 464);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(100, 28);
            this.txtTotalPrice.TabIndex = 25;
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Location = new System.Drawing.Point(522, 255);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(53, 18);
            this.lblGuestName.TabIndex = 26;
            this.lblGuestName.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contact Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 380);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Address:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Location = new System.Drawing.Point(672, 242);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(100, 28);
            this.txtGuestName.TabIndex = 30;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(672, 287);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 28);
            this.txtContact.TabIndex = 31;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(672, 336);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 28);
            this.txtEmail.TabIndex = 32;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(672, 377);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 28);
            this.txtAddress.TabIndex = 33;
            // 
            // rbtPayDeposit
            // 
            this.rbtPayDeposit.AutoSize = true;
            this.rbtPayDeposit.Location = new System.Drawing.Point(829, 600);
            this.rbtPayDeposit.Name = "rbtPayDeposit";
            this.rbtPayDeposit.Size = new System.Drawing.Size(96, 22);
            this.rbtPayDeposit.TabIndex = 34;
            this.rbtPayDeposit.TabStop = true;
            this.rbtPayDeposit.Text = "Deposit";
            this.rbtPayDeposit.UseVisualStyleBackColor = true;
            this.rbtPayDeposit.CheckedChanged += new System.EventHandler(this.rbtPayDeposit_CheckedChanged);
            // 
            // rbtPayFull
            // 
            this.rbtPayFull.AutoSize = true;
            this.rbtPayFull.Location = new System.Drawing.Point(1026, 600);
            this.rbtPayFull.Name = "rbtPayFull";
            this.rbtPayFull.Size = new System.Drawing.Size(132, 22);
            this.rbtPayFull.TabIndex = 35;
            this.rbtPayFull.TabStop = true;
            this.rbtPayFull.Text = "Full Amount";
            this.rbtPayFull.UseVisualStyleBackColor = true;
            this.rbtPayFull.CheckedChanged += new System.EventHandler(this.rbtPayFull_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(790, 563);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 18);
            this.label1.TabIndex = 36;
            this.label1.Text = "Choose to pay deposit or full amount";
            // 
            // lblAmountToPay
            // 
            this.lblAmountToPay.AutoSize = true;
            this.lblAmountToPay.Location = new System.Drawing.Point(814, 691);
            this.lblAmountToPay.Name = "lblAmountToPay";
            this.lblAmountToPay.Size = new System.Drawing.Size(143, 18);
            this.lblAmountToPay.TabIndex = 37;
            this.lblAmountToPay.Text = "Amount to pay: ";
            // 
            // txtAmountToPay
            // 
            this.txtAmountToPay.Location = new System.Drawing.Point(963, 688);
            this.txtAmountToPay.Name = "txtAmountToPay";
            this.txtAmountToPay.Size = new System.Drawing.Size(149, 28);
            this.txtAmountToPay.TabIndex = 38;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1176, 776);
            this.Controls.Add(this.txtAmountToPay);
            this.Controls.Add(this.lblAmountToPay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtPayFull);
            this.Controls.Add(this.rbtPayDeposit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGuestName);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.txtDeposit);
            this.Controls.Add(this.txtNumberOfDays);
            this.Controls.Add(this.txtCheckOutDate);
            this.Controls.Add(this.txtCheckInDate);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.txtRoomType);
            this.Controls.Add(this.txtGuestID);
            this.Controls.Add(this.txtBookingID);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblDeposit);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.lblCheckOutDate);
            this.Controls.Add(this.lblCheckInDate);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.lblGuestID);
            this.Controls.Add(this.lblBookingID);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.lblBookingDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Details";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label lblGuestID;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblCheckInDate;
        private System.Windows.Forms.Label lblCheckOutDate;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.TextBox txtGuestID;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtCheckInDate;
        private System.Windows.Forms.TextBox txtCheckOutDate;
        private System.Windows.Forms.TextBox txtNumberOfDays;
        private System.Windows.Forms.TextBox txtDeposit;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbtPayDeposit;
        private System.Windows.Forms.RadioButton rbtPayFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAmountToPay;
        private System.Windows.Forms.TextBox txtAmountToPay;
    }
}