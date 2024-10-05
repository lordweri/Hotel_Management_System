using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem.Business
{
    public class Guest
    {
        private string name;
        private string guestID;
        private string email;
        private string telephone;
        private string address;



        #region Constructors
        public Guest(string name, string Email, string phone, string address)
        {
            this.name = name;
            this.email = Email;
            this.telephone = phone;
            this.address = address;
            this.guestID = GenerateGuestID(name);
        }

        //This constructor will be used in BookingDB class to create a guest object from the database
        //when performming reading operation. It will also be used in GuestDB class to create a guest object
        //for each row in the database and added to the collection
        public Guest(string guestID, string name, string Email, string phone, string address)
        {
            this.name = name;
            this.email = Email;
            this.telephone = phone;
            this.guestID = guestID;
            this.address = address;
        }

        #endregion

        #region utility methods
        private static string GenerateGuestID(string firstName)
        {

            string firstPart = firstName.Length >= 3 ? firstName.Substring(0, 3).ToUpper() : firstName.PadRight(3, 'X').ToUpper();
            string randomLetters = GenerateRandomLetters(3);
            string randomNumbers = GenerateRandomNumbers(3);
            return firstPart + randomLetters + randomNumbers;
        }

        private static string GenerateRandomLetters(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private static string GenerateRandomNumbers(int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat("0123456789", length)
                                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        #endregion

        public string getGuestID()
        {
            return this.guestID;
        }

        public string getName()
        {
            return name;
        }

        public string getPhone()
        {
            return telephone;
        }
        public string getEmail()
        {
            return email;
        }

        public string getAddress()
        {
            return address;
        }
    }

}
