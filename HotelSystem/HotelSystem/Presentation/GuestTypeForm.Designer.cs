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
            this.backButton = new System.Windows.Forms.Button();
            this.guestIDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewGuest
            // 
            this.btnNewGuest.BackColor = System.Drawing.Color.LightGreen;
            this.btnNewGuest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnNewGuest.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGuest.Image")));
            this.btnNewGuest.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNewGuest.Location = new System.Drawing.Point(417, 217);
            this.btnNewGuest.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGuest.Name = "btnNewGuest";
            this.btnNewGuest.Padding = new System.Windows.Forms.Padding(0, 14, 0, 28);
            this.btnNewGuest.Size = new System.Drawing.Size(300, 127);
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
            this.btnExistingGuest.Location = new System.Drawing.Point(417, 410);
            this.btnExistingGuest.Margin = new System.Windows.Forms.Padding(4);
            this.btnExistingGuest.Name = "btnExistingGuest";
            this.btnExistingGuest.Size = new System.Drawing.Size(300, 127);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 122);
            this.panel1.TabIndex = 6;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.LightGreen;
            this.backButton.Location = new System.Drawing.Point(0, 728);
            this.backButton.Margin = new System.Windows.Forms.Padding(4);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(112, 48);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // guestIDtextBox
            // 
            this.guestIDtextBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.guestIDtextBox.Location = new System.Drawing.Point(417, 622);
            this.guestIDtextBox.Margin = new System.Windows.Forms.Padding(4);
            this.guestIDtextBox.Name = "guestIDtextBox";
            this.guestIDtextBox.Size = new System.Drawing.Size(298, 28);
            this.guestIDtextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 627);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "GuestID:";
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.LightGreen;
            this.continueButton.Location = new System.Drawing.Point(1060, 728);
            this.continueButton.Margin = new System.Windows.Forms.Padding(4);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(112, 48);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // GuestTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1176, 777);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guestIDtextBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExistingGuest);
            this.Controls.Add(this.btnNewGuest);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestTypeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Guest Type";
            this.Load += new System.EventHandler(this.GuestTypeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGuest;
        private System.Windows.Forms.Button btnExistingGuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox guestIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button continueButton;
    }
}
