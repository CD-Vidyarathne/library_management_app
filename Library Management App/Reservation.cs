using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_App
{
    internal class Reservation
    {
        private string bookNumber;
        private int userNumber;

        public Reservation()
        {
            bookNumber = string.Empty;
            userNumber = 0;
        }

        public Reservation(string bookNumber, int userNumber)
        {
            this.bookNumber = bookNumber;
            this.userNumber = userNumber;
        }

        public string BookNumber {  get { return bookNumber; } set {  bookNumber = value; } }
        public int UserNumber { get { return userNumber; } set {  userNumber = value; } }
    }
}
