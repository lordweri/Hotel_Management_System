using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelSystem.Business;
using HotelSystem.Data;

/* IMPOERTANT TO READ:
 * 1. Select a start date and end date
 * 2. Press "Search" button to check the availability of rooms
 * 3. Available rooms will be displayed in the list box
 * 4. Select a room from the list box
 * 5. Press "Continue" button to go to the next form
 */
namespace HotelSystem.Presentation
{
    public partial class DateCheckForm : Form
    {
        #region Data Members
        BookingController bookingController;
        Collection<Booking> bookings;               //stores all bookings that is in database into a collection
        RoomController roomController;

        Collection<Room> availableRooms;            //available rooms of a given date range
        Room selectedRoom;                                  //The available room selected from the listBox
        #endregion

        #region Constructors
        public DateCheckForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
            roomController = new RoomController();
            bookings = bookingController.AllBookings;           
        }
        #endregion

        //search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerStartDate.Value;        // Get the start date from the date picker
            DateTime endDate = dateTimePickerEndDate.Value;            // Get the end date from the date picker

            // Validate dates
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Your logic to check availability goes here
            MessageBox.Show($"Searching availability from {startDate.ToShortDateString()} to {endDate.ToShortDateString()}.", "Searching", MessageBoxButtons.OK);

            //List all available rooms between the given dates in the list box    (This method relies on the Utility methods)
            roomsListBox.Items.Clear();
            availableRooms = SearchAvailableRooms(startDate, endDate);
            if (availableRooms.Count == 0)
            {
                MessageBox.Show("There are no available rooms in the selected dates!");
            }
            else 
            {
                foreach (Room room in availableRooms)
                {
                    roomsListBox.Items.Add("Room number: " + room.RoomNumber);              //Show available rooms(Room number) into the list box
                }
            }
        }

        private void DateCheckForm_Load(object sender, EventArgs e)
        {
            /*  COMMENTED OUT CODE BELOW BECAUSE I DONT KNOW WHAT IT DOES
            // TODO: This line of code loads data into the 'hotelDatabaseDataSet.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.hotelDatabaseDataSet.Booking);
            */
        }

        // event handler to continue to the Bookings Changed form when the button is clicked-BRWCAL007
        private void btnContinue_Click(object sender, EventArgs e)
        {
            BookingChangedForm bookingChangedForm = new BookingChangedForm();
            bookingChangedForm.Show();
            this.Hide(); // Hide the current form

        }
        // event handler to go back to the Main Menu Form when the button is clicked-BRWCAL007
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Create an instance of the main menu form
            MainForm mainForm = new MainForm();

            // Show the main menu form
            mainForm.Show();

            // Close the current form (BookingChangedForm)
            this.Close();
        }

        //After search, click on a room in the list box to choose the room to book
        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomNumber = roomsListBox.SelectedItem.ToString().Substring(13);
            MessageBox.Show("You selected room number: " + selectedRoomNumber);

            foreach (Room room in availableRooms)
            {
                if (selectedRoomNumber == room.RoomNumber)
                {
                    this.selectedRoom = room;
                }
            }
        }


        #region Utility Methods
        //TODO: Might need to check for logic errors
        //Method to search available rooms for the given date range
        private Collection<Room> SearchAvailableRooms(DateTime startDate, DateTime endDate)
        {
            Collection<Room> ALLrooms = roomController.AllRooms;          // Get all rooms from the database
            Collection<Room> availableRooms = new Collection<Room>();     // Create a collection to store available rooms

            foreach (Room room in ALLrooms)
            {
                bool isBooked = false;

                // check if the room is booked already by other guest in a given date range
                foreach (Booking booking in bookings)
                {
                    if (booking.room.RoomNumber == room.RoomNumber)
                    {
                        if (booking.CheckIn < endDate && booking.CheckOut > startDate)
                        {
                            isBooked = true;
                            break;    //Room is not available in the date range, so break the loop
                        }
                        if ((startDate >= booking.CheckIn && startDate <= booking.CheckOut) || (endDate > booking.CheckIn && endDate < booking.CheckOut))
                        {
                            isBooked = true;
                            break;    //Room is not available in the date range, so break the loop
                        }
                    }
                }

                if (!isBooked)
                {
                    availableRooms.Add(room);   //Room is available, so add it to the available rooms collection
                }
            }
            return availableRooms;
        }

        #endregion
    }
}
