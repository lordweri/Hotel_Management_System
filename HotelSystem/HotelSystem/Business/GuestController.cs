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
        public Collection<Guest> AllGuests
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

        //TODO
        #region Database communication


    }
}
