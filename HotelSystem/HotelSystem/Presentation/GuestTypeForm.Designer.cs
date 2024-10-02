namespace HotelSystem.Presentation
{
    partial class GuestTypeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestTypeForm));
            this.btnNewGuest = new System.Windows.Forms.Button();
            this.btnExistingGuest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewGuest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNewGuest.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGuest.Image")));
            this.btnNewGuest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewGuest.Location = new System.Drawing.Point(278, 157);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Padding = new System.Windows.Forms.Padding(0, 10, 0, 20);
            this.btnNewGuest.Size = new System.Drawing.Size(200, 92);
            this.btnNewGuest.TabIndex = 0;
            this.btnNewGuest.Text = "New Guest";
            this.btnNewGuest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNewGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewGuest.UseVisualStyleBackColor = false;
            this.btnNewGuest.Click += new System.EventHandler(this.btnNewGuest_Click);
            // 
            // btnExistingGuest
            // 
            this.btnExistingGuest.BackColor = System.Drawing.Color.LightGray;
            this.btnExistingGuest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExistingGuest.Location = new System.Drawing.Point(278, 296);
            this.btnExistingGuest.Name = "btnExistingGuest";
            this.btnExistingGuest.Size = new System.Drawing.Size(200, 92);
            this.btnExistingGuest.TabIndex = 1;
            this.btnExistingGuest.Text = "Existing Guest";
            this.btnExistingGuest.UseVisualStyleBackColor = false;
            this.btnExistingGuest.Click += new System.EventHandler(this.btnExistingGuest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 88);
            this.panel1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(0, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(278, 449);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "GuestID:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(707, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 35);
            this.button2.TabIndex = 10;
            this.button2.Text = "Continue";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // GuestTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExistingGuest);
            this.Controls.Add(this.btnNewGuest);
            this.Name = "GuestTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Guest Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGuest;
        private System.Windows.Forms.Button btnExistingGuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}
