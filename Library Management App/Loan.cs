using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_App
{
    internal class Loan
    {
        private int loanNumber;
        private string bookNumber;
        private int userNumber;
        private DateTime dueDate;

        public Loan()
        {
            this.loanNumber = 0;
            this.bookNumber = string.Empty;
            this.userNumber = 0;
            this.dueDate = DateTime.MinValue;
        }

        public int LoanNumber { get { return loanNumber; } set { this.loanNumber = value; } }
        public string BookNumber { get { return bookNumber; } set { this.bookNumber = value; } }
        public int UserNumber { get { return userNumber; } set { this.userNumber = value; } }
        public DateTime DueDate { get { return dueDate; } set { this.dueDate = value; } }
    }
}
