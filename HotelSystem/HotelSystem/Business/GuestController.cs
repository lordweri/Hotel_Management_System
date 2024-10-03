using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem.Data;

namespace HotelSystem.Business
{
    //Make use of this class to CRUD operation on the Guest table from the database
    public class GuestController
    {
        #region Data members
        GuestDB guestDB;
        Collection<Guest> guests;     //stores all guests in a collection
        #endregion

        #region Properties
        public Collection<Guest> AllGuests            //Use GuestController.AllGuests to get all guests from the database
        {
            get
            {
                return guests;
            }
        }

        #endregion

        #region Constructor
        public GuestController()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;    //guestDB.AllGuests uses the get method of GuestDB class to get ALL guests from the database
        }

        #endregion

        #region Database communication
        //This method updates guest DataSet(won't affect the database until FinalizeChanges() is called)
        public void DataMaintenance(Guest aGuest, DB.DBOperation operation)
        {
            int index = 0;
            guestDB.DataSetChange(aGuest, operation);   //add, edit or delete guest in the DataSet
            switch (operation)
            {
                case DB.DBOperation.Add:      //add a guest to the dataset
                    guests.Add(aGuest);         
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aGuest);
                    aGuest = guests[index];     //update a guest in the Collection, i.e. replace a old guest object with a new object (NOTE: guestID should remain the same)
                    break;
                case DB.DBOperation.Delete:      //delete a guest from the dataset
                    index = FindIndex(aGuest);
                    guests.RemoveAt(index);
                    break;
            }
        }

        //Finalize changes to the database
        public bool FinalizeChanges(Guest guest, DB.DBOperation operation)
        {
            return guestDB.UpdateDataSource(guest, operation);
        }
        #endregion

        //Use these method to search for a guest in the database/Collection
        #region Search methods
        //This method searches for a guest in the database by guestID
        public Guest FindGuest(string guestID)
        {
            foreach (Guest guest in guests)
            {
                if (guest.getGuestID() == guestID)
                {
                    return guest;
                }
            }
            return null;
        }

        //This method finds the index of a guest in the collection
        private int FindIndex(Guest aGuest)
        {
            int index = 0;
            foreach (Guest guest in guests)
            {
                if (guest.getGuestID() == aGuest.getGuestID())
                {
                    return index;
                }
                index++;
            }
            return -1;
        }

        internal Guest GetGuestByDetails(string text1, string text2)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
