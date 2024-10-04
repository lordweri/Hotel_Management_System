namespace HotelSystem.Presentation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnChangeReservation = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.btnOccupancyReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRevenueForecast = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMakeReservation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMakeReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnMakeReservation.Image")));
            this.btnMakeReservation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMakeReservation.Location = new System.Drawing.Point(11, 274);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.btnMakeReservation.Size = new System.Drawing.Size(175, 97);
            this.btnMakeReservation.TabIndex = 0;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMakeReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMakeReservation.UseVisualStyleBackColor = false;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // btnChangeReservation
            // 
            this.btnChangeReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnChangeReservation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChangeReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeReservation.Image")));
            this.btnChangeReservation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnChangeReservation.Location = new System.Drawing.Point(208, 274);
            this.btnChangeReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeReservation.Name = "btnChangeReservation";
            this.btnChangeReservation.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.btnChangeReservation.Size = new System.Drawing.Size(169, 97);
            this.btnChangeReservation.TabIndex = 1;
            this.btnChangeReservation.Text = "Change Reservation";
            this.btnChangeReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeReservation.UseVisualStyleBackColor = false;
            this.btnChangeReservation.Click += new System.EventHandler(this.btnChangeReservation_Click);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelReservation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancelReservation.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelReservation.Image")));
            this.btnCancelReservation.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelReservation.Location = new System.Drawing.Point(406, 274);
            this.btnCancelReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.btnCancelReservation.Size = new System.Drawing.Size(177, 97);
            this.btnCancelReservation.TabIndex = 2;
            this.btnCancelReservation.Text = "Cancel Reservation";
            this.btnCancelReservation.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelReservation.UseVisualStyleBackColor = false;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // btnOccupancyReport
            // 
            this.btnOccupancyReport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOccupancyReport.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOccupancyReport.Image = ((System.Drawing.Image)(resources.GetObject("btnOccupancyReport.Image")));
            this.btnOccupancyReport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOccupancyReport.Location = new System.Drawing.Point(597, 274);
            this.btnOccupancyReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOccupancyReport.Name = "btnOccupancyReport";
            this.btnOccupancyReport.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.btnOccupancyReport.Size = new System.Drawing.Size(176, 97);
            this.btnOccupancyReport.TabIndex = 3;
            this.btnOccupancyReport.Text = "Occupancy Report";
            this.btnOccupancyReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOccupancyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOccupancyReport.UseVisualStyleBackColor = false;
            this.btnOccupancyReport.Click += new System.EventHandler(this.btnOccupancyReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Log Out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 77);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnRevenueForecast
            // 
            this.btnRevenueForecast.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRevenueForecast.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRevenueForecast.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenueForecast.Image")));
            this.btnRevenueForecast.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRevenueForecast.Location = new System.Drawing.Point(299, 402);
            this.btnRevenueForecast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRevenueForecast.Name = "btnRevenueForecast";
            this.btnRevenueForecast.Padding = new System.Windows.Forms.Padding(0, 20, 0, 10);
            this.btnRevenueForecast.Size = new System.Drawing.Size(176, 97);
            this.btnRevenueForecast.TabIndex = 6;
            this.btnRevenueForecast.Text = "Revenue Forecast Report";
            this.btnRevenueForecast.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevenueForecast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRevenueForecast.UseVisualStyleBackColor = false;
            this.btnRevenueForecast.Click += new System.EventHandler(this.btnRevenueForecast_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRevenueForecast);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOccupancyReport);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.btnChangeReservation);
            this.Controls.Add(this.btnMakeReservation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phumla Kamnandi Hotel System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnChangeReservation;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.Button btnOccupancyReport;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRevenueForecast;
    }
}

