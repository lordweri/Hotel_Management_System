namespace HotelSystem.Presentation
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.btnConfirmDeposit = new System.Windows.Forms.Button();
            this.btnConfirmFullPayment = new System.Windows.Forms.Button();
            this.btnConfirmNoPayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtCardHolderName = new System.Windows.Forms.TextBox();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.lblCardHolder = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureVisaLogo = new System.Windows.Forms.PictureBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtBillingAddress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVisaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmDeposit
            // 
            this.btnConfirmDeposit.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmDeposit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmDeposit.Location = new System.Drawing.Point(333, 160);
            this.btnConfirmDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmDeposit.Name = "btnConfirmDeposit";
            this.btnConfirmDeposit.Size = new System.Drawing.Size(368, 39);
            this.btnConfirmDeposit.TabIndex = 0;
            this.btnConfirmDeposit.Text = "Confirm Deposit";
            this.btnConfirmDeposit.UseVisualStyleBackColor = false;
            this.btnConfirmDeposit.Click += new System.EventHandler(this.btnConfirmDeposit_Click);
            // 
            // btnConfirmFullPayment
            // 
            this.btnConfirmFullPayment.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmFullPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmFullPayment.Location = new System.Drawing.Point(333, 590);
            this.btnConfirmFullPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmFullPayment.Name = "btnConfirmFullPayment";
            this.btnConfirmFullPayment.Size = new System.Drawing.Size(368, 39);
            this.btnConfirmFullPayment.TabIndex = 1;
            this.btnConfirmFullPayment.Text = "Confirm Full Payment";
            this.btnConfirmFullPayment.UseVisualStyleBackColor = false;
            this.btnConfirmFullPayment.Click += new System.EventHandler(this.btnConfirmFullPayment_Click);
            // 
            // btnConfirmNoPayment
            // 
            this.btnConfirmNoPayment.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmNoPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmNoPayment.Location = new System.Drawing.Point(333, 633);
            this.btnConfirmNoPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmNoPayment.Name = "btnConfirmNoPayment";
            this.btnConfirmNoPayment.Size = new System.Drawing.Size(368, 39);
            this.btnConfirmNoPayment.TabIndex = 2;
            this.btnConfirmNoPayment.Text = "Confirm No Payment";
            this.btnConfirmNoPayment.UseVisualStyleBackColor = false;
            this.btnConfirmNoPayment.Click += new System.EventHandler(this.btnConfirmNoPayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.Location = new System.Drawing.Point(-1, 660);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 32);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(-1, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 101);
            this.panel1.TabIndex = 7;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFinish.Location = new System.Drawing.Point(895, 660);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(149, 32);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(333, 246);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(368, 22);
            this.txtCardNumber.TabIndex = 9;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(333, 393);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(368, 22);
            this.txtExpiryDate.TabIndex = 10;
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Location = new System.Drawing.Point(333, 320);
            this.txtCardHolderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(368, 22);
            this.txtCardHolderName.TabIndex = 11;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(333, 455);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(368, 22);
            this.txtCVV.TabIndex = 12;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(237, 249);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(90, 16);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(237, 322);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(83, 16);
            this.lblCardHolder.TabIndex = 14;
            this.lblCardHolder.Text = "Card Holder:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(237, 396);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(79, 16);
            this.lblExpiryDate.TabIndex = 15;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(259, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "CVV:";
            // 
            // pictureVisaLogo
            // 
            this.pictureVisaLogo.Image = global::HotelSystem.Properties.Resources.Visa_Logo;
            this.pictureVisaLogo.Location = new System.Drawing.Point(729, 235);
            this.pictureVisaLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureVisaLogo.Name = "pictureVisaLogo";
            this.pictureVisaLogo.Size = new System.Drawing.Size(100, 50);
            this.pictureVisaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVisaLogo.TabIndex = 17;
            this.pictureVisaLogo.TabStop = false;
            this.pictureVisaLogo.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(228, 532);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 16);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Billing Address:";
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.Location = new System.Drawing.Point(333, 526);
            this.txtBillingAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.Size = new System.Drawing.Size(368, 22);
            this.txtBillingAddress.TabIndex = 19;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 695);
            this.Controls.Add(this.txtBillingAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.pictureVisaLogo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblCardHolder);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.txtCardHolderName);
            this.Controls.Add(this.txtExpiryDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirmNoPayment);
            this.Controls.Add(this.btnConfirmFullPayment);
            this.Controls.Add(this.btnConfirmDeposit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Confirmation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureVisaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmDeposit;
        private System.Windows.Forms.Button btnConfirmFullPayment;
        private System.Windows.Forms.Button btnConfirmNoPayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtCardHolderName;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.Label lblCardHolder;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureVisaLogo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtBillingAddress;
    }
}