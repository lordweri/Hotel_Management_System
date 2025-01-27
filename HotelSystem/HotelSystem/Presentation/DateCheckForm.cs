﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
 * 5. Press "Continue" button to go to the next form(GuestTypeForm)
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
        DateTime startDate;
        DateTime endDate;
        #endregion

        #region Constructors
        public DateCheckForm(BookingController bookingController)
        {
            InitializeComponent();
            bookingController = new BookingController();
            roomController = new RoomController();
            bookings = bookingController.AllBookings; 
            label1.Visible = false;
        }
        #endregion

        //search button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            startDate = dateTimePickerStartDate.Value;        // Get the start date from the date picker
            endDate = dateTimePickerEndDate.Value;            // Get the end date from the date picker

            // Validate dates
            if (startDate > endDate)
            {
                MessageBox.Show("Start date cannot be after end date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Your logic to check availability goes here
            
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
            DateTime minDate = new DateTime(2024, 12, 1); 
            DateTime maxDate = new DateTime(2024, 12, 31); 

            dateTimePickerStartDate.MinDate = minDate;
            dateTimePickerStartDate.MaxDate = maxDate;
            dateTimePickerStartDate.Value = minDate; 

            dateTimePickerEndDate.MinDate = minDate;
            dateTimePickerEndDate.MaxDate = maxDate;
            dateTimePickerEndDate.Value = maxDate;
        }

        //"Continue" button, proceeds to the GuestTypeForm
        private void btnContinue_Click(object sender, EventArgs e)

        {
            if (selectedRoom != null) 
            { 
                Booking booking = new Booking();                             //Create a new booking object, the bookingID is auto-generated
                DateRange range = new DateRange(dateTimePickerStartDate.Value, dateTimePickerEndDate.Value);
                booking.setRoom(selectedRoom);
                booking.setRange(range);
                GuestTypeForm form = new GuestTypeForm(bookingController, booking);            //Proceed to GuestTypeForm
                form.Show();
                this.Close();
            }
            else
            {
                label1.Visible = true;
            }
        }
        // event handler to go back to the Main Menu Form when the button is clicked-BRWCAL007
        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                // Create an instance of the main menu form
                MainForm mainForm = new MainForm();

                // Show the main menu form
                mainForm.Show();

                // Close the current form (BookingChangedForm)
                this.Close();
            }
            catch (Exception ex)
            {
                // Log the error
                System.Diagnostics.EventLog.WriteEntry("Application", ex.ToString(), System.Diagnostics.EventLogEntryType.Error);

                // Display an error message to the user
                MessageBox.Show("An error occurred while attempting to go back to the main menu. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //After search, click on a room in the list box to choose the room to book
        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomNumber = roomsListBox.SelectedItem.ToString().Substring(13);
            MessageBox.Show("You selected room number: " + selectedRoomNumber);

            foreach (Room room in availableRooms)
            {
                if (selectedRoomNumber.Equals(room.RoomNumber))
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
                    if (booking.GetRoom().RoomNumber == room.RoomNumber)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
