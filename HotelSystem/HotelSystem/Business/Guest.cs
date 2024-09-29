using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSystem
{
    public class Guest
    {
        private string Name;
        private string guestID;
        private string email;
        private string telephone;
        private Boolean check;


        public Guest(string name, string Email, string phone)
        {
            this.Name = name;
            this.email = Email;
            this.telephone = phone;
            this.guestID = GenerateGuestID(name);
        }
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
    }

}
