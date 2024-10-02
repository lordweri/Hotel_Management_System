namespace HotelSystem.Presentation
{
    partial class BookingGeneratedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingGeneratedForm));
            this.lblBookingSuccess = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblBookingSuccess
            // 
            this.lblBookingSuccess.AutoSize = true;
            this.lblBookingSuccess.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingSuccess.Location = new System.Drawing.Point(100, 248);
            this.lblBookingSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingSuccess.Name = "lblBookingSuccess";
            this.lblBookingSuccess.Size = new System.Drawing.Size(590, 50);
            this.lblBookingSuccess.TabIndex = 0;
            this.lblBookingSuccess.Text = "Booking Generated Successfully!";
            this.lblBookingSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBookingSuccess.Click += new System.EventHandler(this.lblBookingSuccess_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.Location = new System.Drawing.Point(0, 531);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 32);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.LightGreen;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBackToMainMenu.Location = new System.Drawing.Point(672, 531);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(112, 32);
            this.btnBackToMainMenu.TabIndex = 2;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 77);
            this.panel1.TabIndex = 7;
            // 
            // BookingGeneratedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblBookingSuccess);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BookingGeneratedForm";
            this.Text = "Booking Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingSuccess;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Panel panel1;
    }
}