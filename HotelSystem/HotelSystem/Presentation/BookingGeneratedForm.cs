using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelSystem.Presentation
{
    public partial class BookingGeneratedForm : Form
    {
        private SqlConnection connection;
        private DataSet dataSet = new DataSet();
        private Business.Booking booking;  // Store the booking object

        public BookingGeneratedForm(Business.Booking booking)
        {
            InitializeComponent();
            this.booking = booking;
            LoadData();  // Load additional tables like Payments and Guests
            this.Shown += new EventHandler(BookingGeneratedForm_Shown); // Attach the Shown event
        }

        // Load data for multiple tables (Booking, Payment, Guest)
        private void LoadData()
        {
            // Use |DataDirectory| to make the connection string generic
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\HotelDatabase.mdf;Integrated Security=True;";

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();

                // Load Booking table
                SqlDataAdapter bookingAdapter = new SqlDataAdapter("SELECT * FROM Booking WHERE BookingID = @BookingID", connection);
                bookingAdapter.SelectCommand.Parameters.AddWithValue("@BookingID", booking.GetBookingID());
                bookingAdapter.Fill(dataSet, "Booking");

                // Load Payment table
                SqlDataAdapter paymentAdapter = new SqlDataAdapter("SELECT * FROM Payment WHERE BookingID = @BookingID", connection);
                paymentAdapter.SelectCommand.Parameters.AddWithValue("@BookingID", booking.GetBookingID());
                paymentAdapter.Fill(dataSet, "Payment");

                // Load Guest table
                SqlDataAdapter guestAdapter = new SqlDataAdapter("SELECT * FROM Guest WHERE GuestID = @GuestID", connection);
                guestAdapter.SelectCommand.Parameters.AddWithValue("@GuestID", booking.GetGuest().getGuestID());
                guestAdapter.Fill(dataSet, "Guest");

                // Verify the data is loaded
                if (dataSet.Tables["Booking"].Rows.Count > 0 && dataSet.Tables["Payment"].Rows.Count > 0 && dataSet.Tables["Guest"].Rows.Count > 0)
                {
                    MessageBox.Show("Booking, Payment, and Guest details loaded successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        // Event handler for Form.Shown
        private void BookingGeneratedForm_Shown(object sender, EventArgs e)
        {
            // Show the table names in the dataset using a MessageBox
            string tablesInDataset = "Tables in the dataset: \n";
            foreach (DataTable table in dataSet.Tables)
            {
                tablesInDataset += $"{table.TableName}\n";
            }
            MessageBox.Show(tablesInDataset, "Dataset Tables");
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            // Instantiate and show the LoginForm
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();  // Close current form
        }

        private void BtnBackToMainMenu_Click(object sender, EventArgs e)
        {
            // Instantiate and show the MainForm
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();  // Close current form
        }

        private void LblBookingSuccess_Click(object sender, EventArgs e)
        {
            // Custom logic for handling success click event (if any)
        }
    }
}
