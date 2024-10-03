using HotelSystem.Business;
using HotelSystem.Data;
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

            // Hide the VISA logo initially
            pictureVisaLogo.Visible = false;

            // Attach TextChanged event handler to txtCardNumber
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
        }

        // Event handler for Confirm Deposit button-BRWCAL007
        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {
            decimal depositAmount = GetDepositAmount(); // Implement a method to get the deposit amount
            ProcessPayment(depositAmount, "Deposit");
        }

        // Event handler for Confirm Full Payment button-BRWCAL007
        private void btnConfirmFullPayment_Click(object sender, EventArgs e)
        {
            decimal fullAmount = GetFullAmount(); // Implement a method to get the full payment amount
            if (ValidateCardDetails())
            {
                ProcessPayment(fullAmount, "Visa");
            }
            else
            {
                MessageBox.Show("Please enter valid card details.");
            }
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

        // Method to process payment-BRWCAL007
        private void ProcessPayment(decimal amount, string paymentMethod)
        {
            try
            {
                string paymentID = Guid.NewGuid().ToString(); // Generate unique payment ID
                string bookingID = GetBookingID(); // Implement a method to get the booking ID
                DateTime paymentDate = DateTime.Now;

                Payment payment = new Payment(paymentID, bookingID, amount, paymentDate)
                {
                    PaymentMethod = paymentMethod
                };

                paymentController.DataMaintenance(payment, DB.DBOperation.Add); // Add payment to the dataset
                paymentController.FinalizeChanges(payment, DB.DBOperation.Add); // Update the database
                MessageBox.Show($"{paymentMethod} Payment of {amount:C} Confirmed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment failed: {ex.Message}");
            }
        }

        // Method to validate card details-BRWCAL007
        private bool ValidateCardDetails()
        {
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCardHolderName.Text) ||
                string.IsNullOrWhiteSpace(txtExpiryDate.Text) ||
                string.IsNullOrWhiteSpace(txtCVV.Text))
            {
                return false;
            }
            return true;
        }

        // Example methods for getting deposit amount, full amount, and booking ID-BRWCAL007
        private decimal GetDepositAmount()
        {
            // Implement logic to retrieve the deposit amount
            return 100.00m; // Example value
        }

        private decimal GetFullAmount()
        {
            // Implement logic to retrieve the full payment amount
            return 500.00m; // Example value
        }

        private string GetBookingID()
        {
            // Implement logic to retrieve the booking ID associated with the payment
            return "BKG123456";
        }

        // Event handler for text change in Card Number field-BRWCAL007
        private void txtCardNumber_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCardNumber.Text) && txtCardNumber.Text.StartsWith("4"))
            {
                // Show VISA image when card number starts with 4
                pictureVisaLogo.Visible = true;
            }
            else
            {
                // Hide VISA image if card number does not start with 4
                pictureVisaLogo.Visible = false;
            }
        }
    }
}