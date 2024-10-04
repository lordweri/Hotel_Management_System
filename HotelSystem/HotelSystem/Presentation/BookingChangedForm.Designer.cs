namespace HotelSystem.Presentation
{
    partial class BookingChangedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingChangedForm));
            this.lblBookingSuccess = new System.Windows.Forms.Label();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblBookingSuccess
            // 
            this.lblBookingSuccess.AutoSize = true;
            this.lblBookingSuccess.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingSuccess.Location = new System.Drawing.Point(178, 318);
            this.lblBookingSuccess.Name = "lblBookingSuccess";
            this.lblBookingSuccess.Size = new System.Drawing.Size(709, 62);
            this.lblBookingSuccess.TabIndex = 1;
            this.lblBookingSuccess.Text = "Booking Changed Successfully!";
            this.lblBookingSuccess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.LightGreen;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBackToMainMenu.Location = new System.Drawing.Point(897, 652);
            this.btnBackToMainMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(149, 39);
            this.btnBackToMainMenu.TabIndex = 3;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.BtnBackToMainMenu_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.Location = new System.Drawing.Point(-3, 652);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(149, 39);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 95);
            this.panel1.TabIndex = 8;
            // 
            // BookingChangedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.lblBookingSuccess);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BookingChangedForm";
            this.Text = "BookingChangedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookingSuccess;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panel1;
    }
}