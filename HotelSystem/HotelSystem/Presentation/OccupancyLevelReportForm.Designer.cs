﻿namespace HotelSystem.Presentation
{
    partial class OccupancyLevelReportForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvOccupancy = new System.Windows.Forms.DataGridView();
            this.hotelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDatabaseDataSet = new HotelSystem.HotelDatabaseDataSet();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new HotelSystem.HotelDatabaseDataSetTableAdapters.BookingTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chartOccupancyLevel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupancyLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOccupancy
            // 
            this.dgvOccupancy.AutoGenerateColumns = false;
            this.dgvOccupancy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOccupancy.DataSource = this.hotelDatabaseDataSetBindingSource;
            this.dgvOccupancy.Location = new System.Drawing.Point(59, 87);
            this.dgvOccupancy.Name = "dgvOccupancy";
            this.dgvOccupancy.RowHeadersWidth = 51;
            this.dgvOccupancy.RowTemplate.Height = 24;
            this.dgvOccupancy.Size = new System.Drawing.Size(603, 256);
            this.dgvOccupancy.TabIndex = 0;
            // 
            // hotelDatabaseDataSetBindingSource
            // 
            this.hotelDatabaseDataSetBindingSource.DataSource = this.hotelDatabaseDataSet;
            this.hotelDatabaseDataSetBindingSource.Position = 0;
            // 
            // hotelDatabaseDataSet
            // 
            this.hotelDatabaseDataSet.DataSetName = "HotelDatabaseDataSet";
            this.hotelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "Booking";
            this.bookingBindingSource.DataSource = this.hotelDatabaseDataSet;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.hotelDatabaseDataSet;
            // 
            // chartOccupancyLevel
            // 
            chartArea2.Name = "ChartArea1";
            this.chartOccupancyLevel.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartOccupancyLevel.Legends.Add(legend2);
            this.chartOccupancyLevel.Location = new System.Drawing.Point(714, 87);
            this.chartOccupancyLevel.Name = "chartOccupancyLevel";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartOccupancyLevel.Series.Add(series2);
            this.chartOccupancyLevel.Size = new System.Drawing.Size(626, 256);
            this.chartOccupancyLevel.TabIndex = 1;
            this.chartOccupancyLevel.Text = "chart1";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(589, 536);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(211, 92);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(589, 399);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(589, 465);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(504, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Occupancy Level Report";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(617, 642);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(159, 55);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // OccupancyLevelReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 709);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.chartOccupancyLevel);
            this.Controls.Add(this.dgvOccupancy);
            this.Name = "OccupancyLevelReportForm";
            this.Text = "Occupancy Level Report";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOccupancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartOccupancyLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOccupancy;
        private HotelDatabaseDataSet hotelDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private HotelDatabaseDataSetTableAdapters.BookingTableAdapter bookingTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private System.Windows.Forms.BindingSource hotelDatabaseDataSetBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOccupancyLevel;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}