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
            this.txtBookingDetails = new System.Windows.Forms.TextBox();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingDetails.Location = new System.Drawing.Point(95, 130);
            this.lblBookingDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(162, 28);
            this.lblBookingDetails.TabIndex = 0;
            this.lblBookingDetails.Text = "Booking Details";
            this.lblBookingDetails.Click += new System.EventHandler(this.lblBookingDetails_Click);
            // 
            // txtBookingDetails
            // 
            this.txtBookingDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBookingDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBookingDetails.Location = new System.Drawing.Point(204, 187);
            this.txtBookingDetails.Margin = new System.Windows.Forms.Padding(4);
            this.txtBookingDetails.Multiline = true;
            this.txtBookingDetails.Name = "txtBookingDetails";
            this.txtBookingDetails.ReadOnly = true;
            this.txtBookingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBookingDetails.Size = new System.Drawing.Size(587, 398);
            this.txtBookingDetails.TabIndex = 1;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.LightGreen;
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.Location = new System.Drawing.Point(809, 649);
            this.btnMakePayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(232, 43);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.BtnMakePayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(-3, 649);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(137, 43);
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
            this.panel1.Size = new System.Drawing.Size(1044, 95);
            this.panel1.TabIndex = 6;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.LightGreen;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.CancelButton.Location = new System.Drawing.Point(373, 649);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(232, 43);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.txtBookingDetails);
            this.Controls.Add(this.lblBookingDetails);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingDetails;
        private System.Windows.Forms.TextBox txtBookingDetails;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CancelButton;
    }
}