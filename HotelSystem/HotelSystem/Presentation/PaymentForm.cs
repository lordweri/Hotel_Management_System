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

/* TODO:
 * 1. Complete "Confirm Payment" button
 *     1.1   Booking will be confirmed and added to the databse
 *     1.2   Payment will be processed and added to the database
 *     1.3   Guest will be added to the database if guest is not existing
 * 2. etc    
 */
namespace HotelSystem.Presentation
{
    public partial class PaymentForm : Form
    {
        #region Data Members
        //Controllers
        private PaymentController paymentController;      // Used to add a new payment to the database
        private GuestController guestController;          // Used to add a new guest to the database if guest is not existing
        private BookingController bookingController;      // Used to add a new booking to the database

        //Attributes
        private Booking booking;
        private bool guestIsExisting;                     // If this attribute is true, add the guest to the database if booking is successfully made
        private decimal amountToPay;                      // The amount to pay (either deposit or full payment) NOTE: This value is passed from the previous form(BookForm)
        #endregion

        #region Constructor
        public PaymentForm(Booking booking, bool guestIsExsting, decimal amountToPay)            
        {
            InitializeComponent();
            paymentController = new PaymentController();
            guestController = new GuestController();
            bookingController = new BookingController();

            this.booking = booking;
            this.guestIsExisting = guestIsExsting;
            this.amountToPay = amountToPay;

            // Hide the VISA logo initially
            pictureVisaLogo.Visible = false;

            // Attach TextChanged event handler to txtCardNumber
            txtCardNumber.TextChanged += txtCardNumber_TextChanged;
        }
        #endregion

        // TODO: "Confirm Payment" button
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {

        }


        // Event handler for Confirm No Payment Made Button 
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
            try
            {
                // Create an instance of the BookingGeneratedForm
                BookingGeneratedForm bookingGeneratedForm = new BookingGeneratedForm(booking);

                bookingGeneratedForm.Show(); // Show the BookingGeneratedForm

                MessageBox.Show("Process Finished");

                this.Close(); // Close this form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while opening the BookingGeneratedForm: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            // Card Holder Name (mandatory, alphanumeric)
            if (string.IsNullOrWhiteSpace(txtCardHolderName.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtCardHolderName.Text, @"^[a-zA-Z0-9\s]+$"))
            {
                MessageBox.Show("Please enter a valid Card Holder Name (alphanumeric characters only).");
                return false;
            }

            // Credit Card Number (mandatory, numeric, 16 digits)
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtCardNumber.Text, @"^\d{16}$"))
            {
                MessageBox.Show("Please enter a valid 16-digit Credit Card Number.");
                return false;
            }

            // Expiry Date (mandatory, month/year format)
            if (string.IsNullOrWhiteSpace(txtExpiryDate.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtExpiryDate.Text, @"^(0[1-9]|1[0-2])\/\d{2}$"))
            {
                MessageBox.Show("Please enter a valid Expiry Date in MM/YY format.");
                return false;
            }

            // CVV (mandatory, 3 digits)
            if (string.IsNullOrWhiteSpace(txtCVV.Text) || !System.Text.RegularExpressions.Regex.IsMatch(txtCVV.Text, @"^\d{3}$"))
            {
                MessageBox.Show("Please enter a valid 3-digit CVV.");
                return false;
            }

            // Billing Address (optional, alphanumeric) - Assuming you add a txtBillingAddress control
            if (!string.IsNullOrWhiteSpace(txtBillingAddress.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtBillingAddress.Text, @"^[a-zA-Z0-9\s,.-]+$"))
            {
                MessageBox.Show("Please enter a valid Billing Address (alphanumeric characters, spaces, commas, periods, and hyphens allowed).");
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

        // Event handler for PaymentForm load event
        private void PaymentForm_Load(object sender, EventArgs e)
        {
            txtAmount.Text = amountToPay.ToString();  // Display the amount to pay
        }
    }
}