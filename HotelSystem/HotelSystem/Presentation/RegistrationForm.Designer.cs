namespace HotelSystem.Presentation
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.lblGuestName = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblRoomType = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lblChildren = new System.Windows.Forms.Label();
            this.numChildren = new System.Windows.Forms.NumericUpDown();
            this.lblChild1Age = new System.Windows.Forms.Label();
            this.txtChild1Age = new System.Windows.Forms.TextBox();
            this.lblChild2Age = new System.Windows.Forms.Label();
            this.txtChild2Age = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuestName
            // 
            this.lblGuestName.AutoSize = true;
            this.lblGuestName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblGuestName.Location = new System.Drawing.Point(208, 212);
            this.lblGuestName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuestName.Name = "lblGuestName";
            this.lblGuestName.Size = new System.Drawing.Size(123, 28);
            this.lblGuestName.TabIndex = 0;
            this.lblGuestName.Text = "Guest Name:";
            // 
            // txtGuestName
            // 
            this.txtGuestName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtGuestName.Location = new System.Drawing.Point(387, 212);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(392, 28);
            this.txtGuestName.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPhoneNumber.Location = new System.Drawing.Point(208, 273);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(148, 28);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPhoneNumber.Location = new System.Drawing.Point(387, 271);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(392, 28);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAddress.Location = new System.Drawing.Point(208, 392);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 28);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAddress.Location = new System.Drawing.Point(387, 390);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(392, 28);
            this.txtAddress.TabIndex = 5;
            // 
            // lblRoomType
            // 
            this.lblRoomType.AutoSize = true;
            this.lblRoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRoomType.Location = new System.Drawing.Point(208, 449);
            this.lblRoomType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(114, 28);
            this.lblRoomType.TabIndex = 6;
            this.lblRoomType.Text = "Room Type:";
            // 
            // cbRoomType
            // 
            this.cbRoomType.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Single",
            "CoupleSharingOneBed",
            "TwoPeopleSeparateBeds",
            "FamilyRoom"});
            this.cbRoomType.Location = new System.Drawing.Point(387, 446);
            this.cbRoomType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(392, 26);
            this.cbRoomType.TabIndex = 7;
            // 
            // lblChildren
            // 
            this.lblChildren.AutoSize = true;
            this.lblChildren.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChildren.Location = new System.Drawing.Point(208, 493);
            this.lblChildren.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChildren.Name = "lblChildren";
            this.lblChildren.Size = new System.Drawing.Size(153, 28);
            this.lblChildren.TabIndex = 8;
            this.lblChildren.Text = "Number of Kids:";
            // 
            // numChildren
            // 
            this.numChildren.Location = new System.Drawing.Point(387, 492);
            this.numChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numChildren.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numChildren.Name = "numChildren";
            this.numChildren.Size = new System.Drawing.Size(64, 28);
            this.numChildren.TabIndex = 9;
            this.numChildren.ValueChanged += new System.EventHandler(this.numChildren_ValueChanged);
            // 
            // lblChild1Age
            // 
            this.lblChild1Age.AutoSize = true;
            this.lblChild1Age.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChild1Age.Location = new System.Drawing.Point(208, 539);
            this.lblChild1Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChild1Age.Name = "lblChild1Age";
            this.lblChild1Age.Size = new System.Drawing.Size(117, 28);
            this.lblChild1Age.TabIndex = 10;
            this.lblChild1Age.Text = "Child 1 Age:";
            // 
            // txtChild1Age
            // 
            this.txtChild1Age.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChild1Age.Enabled = false;
            this.txtChild1Age.Location = new System.Drawing.Point(387, 537);
            this.txtChild1Age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChild1Age.Name = "txtChild1Age";
            this.txtChild1Age.Size = new System.Drawing.Size(62, 28);
            this.txtChild1Age.TabIndex = 11;
            // 
            // lblChild2Age
            // 
            this.lblChild2Age.AutoSize = true;
            this.lblChild2Age.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblChild2Age.Location = new System.Drawing.Point(204, 598);
            this.lblChild2Age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChild2Age.Name = "lblChild2Age";
            this.lblChild2Age.Size = new System.Drawing.Size(117, 28);
            this.lblChild2Age.TabIndex = 12;
            this.lblChild2Age.Text = "Child 2 Age:";
            // 
            // txtChild2Age
            // 
            this.txtChild2Age.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtChild2Age.Enabled = false;
            this.txtChild2Age.Location = new System.Drawing.Point(387, 598);
            this.txtChild2Age.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtChild2Age.Name = "txtChild2Age";
            this.txtChild2Age.Size = new System.Drawing.Size(62, 28);
            this.txtChild2Age.TabIndex = 13;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LightGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(939, 726);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(236, 48);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Generate Booking";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 119);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(0, 726);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 48);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(208, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtEmail.Location = new System.Drawing.Point(387, 328);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(392, 28);
            this.txtEmail.TabIndex = 18;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1176, 777);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtChild2Age);
            this.Controls.Add(this.lblChild2Age);
            this.Controls.Add(this.txtChild1Age);
            this.Controls.Add(this.lblChild1Age);
            this.Controls.Add(this.numChildren);
            this.Controls.Add(this.lblChildren);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.lblRoomType);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.lblGuestName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegistrationForm";
            this.Text = "Guest Registration";
            ((System.ComponentModel.ISupportInitialize)(this.numChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuestName;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblRoomType;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lblChildren;
        private System.Windows.Forms.NumericUpDown numChildren;
        private System.Windows.Forms.Label lblChild1Age;
        private System.Windows.Forms.TextBox txtChild1Age;
        private System.Windows.Forms.Label lblChild2Age;
        private System.Windows.Forms.TextBox txtChild2Age;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
    }
}