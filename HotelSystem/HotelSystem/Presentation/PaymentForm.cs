using HotelSystem.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelSystem.Presentation
{
    public partial class PaymentForm : Form
    {
        private PaymentController paymentController;
        public PaymentForm()
            
        {
            InitializeComponent();
            paymentController = new PaymentController();
        }

        // Event handler for Confirm Deposit button
        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deposit Confirmed");
        }

        // Event handler for Confirm Full Payment button
        private void btnConfirmFullPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Full Payment Confirmed");
        }

        // Event handler for Confirm No Payment Made button
        private void btnConfirmNoPayment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Payment Made");
        }

        // Event handler for Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form and go back
        }

        // Event handler for Finish button
        private void btnFinish_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Process Finished");
            this.Close();
        }
    }
}