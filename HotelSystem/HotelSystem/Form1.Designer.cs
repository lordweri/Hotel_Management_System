﻿namespace HotelSystem
{
    partial class Form1
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
            this.btnBooking = new System.Windows.Forms.Button();
            this.btnEnquiry = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(88, 541);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(136, 49);
            this.btnBooking.TabIndex = 0;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.btnBooking_Click);
            // 
            // btnEnquiry
            // 
            this.btnEnquiry.Location = new System.Drawing.Point(379, 541);
            this.btnEnquiry.Name = "btnEnquiry";
            this.btnEnquiry.Size = new System.Drawing.Size(136, 49);
            this.btnEnquiry.TabIndex = 1;
            this.btnEnquiry.Text = "Enquiry";
            this.btnEnquiry.UseVisualStyleBackColor = true;
            this.btnEnquiry.Click += new System.EventHandler(this.btnEnquiry_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(695, 541);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(136, 49);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 702);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnEnquiry);
            this.Controls.Add(this.btnBooking);
            this.Name = "Form1";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.Button btnEnquiry;
        private System.Windows.Forms.Button btnReport;
    }
}

