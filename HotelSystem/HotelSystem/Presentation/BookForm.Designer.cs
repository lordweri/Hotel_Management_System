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
            this.SuspendLayout();
            // 
            // lblBookingDetails
            // 
            this.lblBookingDetails.AutoSize = true;
            this.lblBookingDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingDetails.Location = new System.Drawing.Point(71, 106);
            this.lblBookingDetails.Name = "lblBookingDetails";
            this.lblBookingDetails.Size = new System.Drawing.Size(131, 21);
            this.lblBookingDetails.TabIndex = 0;
            this.lblBookingDetails.Text = "Booking Details";
            // 
            // txtBookingDetails
            // 
            this.txtBookingDetails.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBookingDetails.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBookingDetails.Location = new System.Drawing.Point(153, 152);
            this.txtBookingDetails.Multiline = true;
            this.txtBookingDetails.Name = "txtBookingDetails";
            this.txtBookingDetails.ReadOnly = true;
            this.txtBookingDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBookingDetails.Size = new System.Drawing.Size(441, 324);
            this.txtBookingDetails.TabIndex = 1;
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.LightGreen;
            this.btnMakePayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.Location = new System.Drawing.Point(607, 527);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(174, 35);
            this.btnMakePayment.TabIndex = 2;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightGray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Location = new System.Drawing.Point(-2, 527);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 35);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 77);
            this.panel1.TabIndex = 6;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.txtBookingDetails);
            this.Controls.Add(this.lblBookingDetails);
            this.Name = "BookForm";
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
    }
}