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
            this.btnConfirmDeposit = new System.Windows.Forms.Button();
            this.btnConfirmFullPayment = new System.Windows.Forms.Button();
            this.btnConfirmNoPayment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConfirmDeposit
            // 
            this.btnConfirmDeposit.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmDeposit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmDeposit.Location = new System.Drawing.Point(363, 256);
            this.btnConfirmDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmDeposit.Name = "btnConfirmDeposit";
            this.btnConfirmDeposit.Size = new System.Drawing.Size(300, 39);
            this.btnConfirmDeposit.TabIndex = 0;
            this.btnConfirmDeposit.Text = "Confirm Deposit";
            this.btnConfirmDeposit.UseVisualStyleBackColor = false;
            this.btnConfirmDeposit.Click += new System.EventHandler(this.btnConfirmDeposit_Click);
            // 
            // btnConfirmFullPayment
            // 
            this.btnConfirmFullPayment.BackColor = System.Drawing.Color.LightGreen;
            this.btnConfirmFullPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmFullPayment.Location = new System.Drawing.Point(363, 334);
            this.btnConfirmFullPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmFullPayment.Name = "btnConfirmFullPayment";
            this.btnConfirmFullPayment.Size = new System.Drawing.Size(300, 39);
            this.btnConfirmFullPayment.TabIndex = 1;
            this.btnConfirmFullPayment.Text = "Confirm Full Payment";
            this.btnConfirmFullPayment.UseVisualStyleBackColor = false;
            this.btnConfirmFullPayment.Click += new System.EventHandler(this.btnConfirmFullPayment_Click);
            // 
            // btnConfirmNoPayment
            // 
            this.btnConfirmNoPayment.BackColor = System.Drawing.Color.LightGray;
            this.btnConfirmNoPayment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmNoPayment.Location = new System.Drawing.Point(363, 406);
            this.btnConfirmNoPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirmNoPayment.Name = "btnConfirmNoPayment";
            this.btnConfirmNoPayment.Size = new System.Drawing.Size(300, 39);
            this.btnConfirmNoPayment.TabIndex = 2;
            this.btnConfirmNoPayment.Text = "Confirm No Payment";
            this.btnConfirmNoPayment.UseVisualStyleBackColor = false;
            this.btnConfirmNoPayment.Click += new System.EventHandler(this.btnConfirmNoPayment_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBack.Location = new System.Drawing.Point(-1, 660);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 32);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 101);
            this.panel1.TabIndex = 7;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.Control;
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnFinish.Location = new System.Drawing.Point(895, 660);
            this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(149, 32);
            this.btnFinish.TabIndex = 8;
            this.btnFinish.Text = "Finish";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnConfirmNoPayment);
            this.Controls.Add(this.btnConfirmFullPayment);
            this.Controls.Add(this.btnConfirmDeposit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PaymentForm";
            this.Text = "Payment Confirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmDeposit;
        private System.Windows.Forms.Button btnConfirmFullPayment;
        private System.Windows.Forms.Button btnConfirmNoPayment;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFinish;
    }
}