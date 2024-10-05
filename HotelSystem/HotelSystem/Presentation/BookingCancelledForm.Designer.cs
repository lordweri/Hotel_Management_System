namespace HotelSystem.Presentation
{
    partial class BookingCancelledForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingCancelledForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBookingSuccess = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 77);
            this.panel1.TabIndex = 9;
            // 
            // lblBookingSuccess
            // 
            this.lblBookingSuccess.AutoSize = true;
            this.lblBookingSuccess.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingSuccess.Location = new System.Drawing.Point(202, 273);
            this.lblBookingSuccess.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBookingSuccess.Name = "lblBookingSuccess";
            this.lblBookingSuccess.Size = new System.Drawing.Size(359, 50);
            this.lblBookingSuccess.TabIndex = 10;
            this.lblBookingSuccess.Text = "Booking Cancelled!";
            this.lblBookingSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.LightGray;
            this.BtnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnLogout.Location = new System.Drawing.Point(2, 529);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(112, 32);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnBackToMainMenu
            // 
            this.BtnBackToMainMenu.BackColor = System.Drawing.Color.LightGreen;
            this.BtnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.BtnBackToMainMenu.Location = new System.Drawing.Point(675, 529);
            this.BtnBackToMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackToMainMenu.Name = "BtnBackToMainMenu";
            this.BtnBackToMainMenu.Size = new System.Drawing.Size(112, 32);
            this.BtnBackToMainMenu.TabIndex = 12;
            this.BtnBackToMainMenu.Text = "Back to Main Menu";
            this.BtnBackToMainMenu.UseVisualStyleBackColor = false;
            this.BtnBackToMainMenu.Click += new System.EventHandler(this.BtnBackToMainMenu_Click);
            // 
            // BookingCancelledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.BtnBackToMainMenu);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.lblBookingSuccess);
            this.Controls.Add(this.panel1);
            this.Name = "BookingCancelledForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookingCancelledForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBookingSuccess;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnBackToMainMenu;
    }
}