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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnConfirmNoPayment = new System.Windows.Forms.Button();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureVisaLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.Location = new System.Drawing.Point(-1, 742);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(168, 36);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 114);
            this.panel1.TabIndex = 7;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFinish.Location = new System.Drawing.Point(1007, 742);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(168, 36);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(375, 277);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(414, 28);
            this.txtCardNumber.TabIndex = 9;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Location = new System.Drawing.Point(375, 442);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.Size = new System.Drawing.Size(414, 28);
            this.txtExpiryDate.TabIndex = 10;
            // 
            // txtCardHolderName
            // 
            this.txtCardHolderName.Location = new System.Drawing.Point(375, 360);
            this.txtCardHolderName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardHolderName.Name = "txtCardHolderName";
            this.txtCardHolderName.Size = new System.Drawing.Size(414, 28);
            this.txtCardHolderName.TabIndex = 11;
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(375, 512);
            this.txtCVV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(414, 28);
            this.txtCVV.TabIndex = 12;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(267, 280);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(116, 18);
            this.lblCardNumber.TabIndex = 13;
            this.lblCardNumber.Text = "Card Number:";
            // 
            // lblCardHolder
            // 
            this.lblCardHolder.AutoSize = true;
            this.lblCardHolder.Location = new System.Drawing.Point(267, 362);
            this.lblCardHolder.Name = "lblCardHolder";
            this.lblCardHolder.Size = new System.Drawing.Size(116, 18);
            this.lblCardHolder.TabIndex = 14;
            this.lblCardHolder.Text = "Card Holder:";
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(267, 446);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(116, 18);
            this.lblExpiryDate.TabIndex = 15;
            this.lblExpiryDate.Text = "Expiry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "CVV:";
            // 
            // pictureVisaLogo
            // 
            this.pictureVisaLogo.Image = global::HotelSystem.Properties.Resources.Visa_Logo;
            this.pictureVisaLogo.Location = new System.Drawing.Point(820, 264);
            this.pictureVisaLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureVisaLogo.Name = "pictureVisaLogo";
            this.pictureVisaLogo.Size = new System.Drawing.Size(112, 56);
            this.pictureVisaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureVisaLogo.TabIndex = 17;
            this.pictureVisaLogo.TabStop = false;
            this.pictureVisaLogo.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(256, 598);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(152, 18);
            this.lblAddress.TabIndex = 18;
            this.lblAddress.Text = "Billing Address:";
            // 
            // txtBillingAddress
            // 
            this.txtBillingAddress.Location = new System.Drawing.Point(375, 592);
            this.txtBillingAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBillingAddress.Name = "txtBillingAddress";
            this.txtBillingAddress.Size = new System.Drawing.Size(414, 28);
            this.txtBillingAddress.TabIndex = 19;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(47, 154);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(71, 18);
            this.lblAmount.TabIndex = 20;
            this.lblAmount.Text = "Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(157, 151);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 28);
            this.txtAmount.TabIndex = 21;
            // 
            // btnConfirmNoPayment
            // 
            this.btnConfirmNoPayment.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmNoPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmNoPayment.Location = new System.Drawing.Point(324, 714);
            this.btnConfirmNoPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmNoPayment.Name = "btnConfirmNoPayment";
            this.btnConfirmNoPayment.Size = new System.Drawing.Size(414, 44);
            this.btnConfirmNoPayment.TabIndex = 2;
            this.btnConfirmNoPayment.Text = "Confirm No Payment";
            this.btnConfirmNoPayment.UseVisualStyleBackColor = false;
            this.btnConfirmNoPayment.Click += new System.EventHandler(this.btnConfirmNoPayment_Click);
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.Location = new System.Drawing.Point(324, 647);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(414, 44);
            this.btnConfirmPayment.TabIndex = 22;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 782);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Confirmation";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureVisaLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnConfirmNoPayment;
        private System.Windows.Forms.Button btnConfirmPayment;
    }
}