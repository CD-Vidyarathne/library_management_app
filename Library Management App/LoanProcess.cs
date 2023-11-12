using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_App
{
    public partial class LoanProcess : Form
    {
        public LoanProcess()
        {
            InitializeComponent();
        }

        private void btn_book_loan_Click(object sender, EventArgs e)
        {
            if (txt_book_class.Text == "" || txt_book_identifier.Text == "" || txt_userNumber.Text == "")
            {
                MessageBox.Show("Please provide all the details.");
                return;
            }
            string bookClassification = txt_book_class.Text;
            string bookIdentifier = txt_book_identifier.Text;
            string userNumber = txt_userNumber.Text;

            User user = new DbProcess().GetUser(userNumber);
            Book book = new DbProcess().GetBookByNumbers(bookClassification, bookIdentifier);
        
            if (user.UserName == "")
            {
                MessageBox.Show("No user with this user number.");
                return;
            }
            if (user.IsMember == false)
            {
                MessageBox.Show("This user is not allowed to burrow books.");
                return;
            }
            if (user.BorrowedBookCount >= 5)
            {
                MessageBox.Show("Maximum burrowing limit reached.");
                return;
            }
            if (book.Title == "")
            {
                MessageBox.Show("No book found with this credentials.");
                return;
            }
            if (book.CopyCount == "0")
            {
                MessageBox.Show("No books are available.");
                return;
            }
            new LibraryProcesses().LoanBook(user,book);
            this.Hide();
            new MainMenu().Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
