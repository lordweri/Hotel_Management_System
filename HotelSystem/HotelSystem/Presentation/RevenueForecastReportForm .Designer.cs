namespace HotelSystem.Presentation
{
    partial class RevenueForecastReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.chartRevenue = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerateRevenueReport = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.hotelDatabaseDataSet = new HotelSystem.HotelDatabaseDataSet();
            this.hotelDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue Report";
            // 
            // chartRevenue
            // 
            chartArea2.Name = "ChartArea1";
            this.chartRevenue.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartRevenue.Legends.Add(legend2);
            this.chartRevenue.Location = new System.Drawing.Point(45, 68);
            this.chartRevenue.Name = "chartRevenue";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartRevenue.Series.Add(series2);
            this.chartRevenue.Size = new System.Drawing.Size(300, 300);
            this.chartRevenue.TabIndex = 1;
            this.chartRevenue.Text = "chart1";
            // 
            // btnGenerateRevenueReport
            // 
            this.btnGenerateRevenueReport.Location = new System.Drawing.Point(512, 576);
            this.btnGenerateRevenueReport.Name = "btnGenerateRevenueReport";
            this.btnGenerateRevenueReport.Size = new System.Drawing.Size(260, 76);
            this.btnGenerateRevenueReport.TabIndex = 2;
            this.btnGenerateRevenueReport.Text = "Generate Revenue Report";
            this.btnGenerateRevenueReport.UseVisualStyleBackColor = true;
            this.btnGenerateRevenueReport.Click += new System.EventHandler(this.btnGenerateRevenueReport_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(894, 68);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 22);
            this.dtpStartDate.TabIndex = 3;
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.AutoGenerateColumns = false;
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.DataSource = this.hotelDatabaseDataSetBindingSource;
            this.dgvRevenue.Location = new System.Drawing.Point(475, 68);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.RowHeadersWidth = 51;
            this.dgvRevenue.RowTemplate.Height = 24;
            this.dgvRevenue.Size = new System.Drawing.Size(319, 300);
            this.dgvRevenue.TabIndex = 4;
            // 
            // cmbReportType
            // 
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Location = new System.Drawing.Point(894, 344);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(200, 24);
            this.cmbReportType.TabIndex = 5;
            // 
            // hotelDatabaseDataSet
            // 
            this.hotelDatabaseDataSet.DataSetName = "HotelDatabaseDataSet";
            this.hotelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hotelDatabaseDataSetBindingSource
            // 
            this.hotelDatabaseDataSetBindingSource.DataSource = this.hotelDatabaseDataSet;
            this.hotelDatabaseDataSetBindingSource.Position = 0;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(894, 199);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 22);
            this.dtpEndDate.TabIndex = 6;
            // 
            // SeasonalOccupancyTrendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 786);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.cmbReportType);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnGenerateRevenueReport);
            this.Controls.Add(this.chartRevenue);
            this.Controls.Add(this.label1);
            this.Name = "SeasonalOccupancyTrendReport";
            this.Text = "RevenueForecastReport";
            ((System.ComponentModel.ISupportInitialize)(this.chartRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatabaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRevenue;
        private System.Windows.Forms.Button btnGenerateRevenueReport;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.BindingSource hotelDatabaseDataSetBindingSource;
        private HotelDatabaseDataSet hotelDatabaseDataSet;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
    }
}