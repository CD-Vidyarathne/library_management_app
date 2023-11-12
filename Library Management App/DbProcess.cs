using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_App
{
    internal class DbProcess
    {
        private readonly MySqlConnection connection = new DatabaseConnection().ConnectDb();


        //******************Registration of book and users******************************
        public void RegisterUser(User user,bool isMember)
        {
            string query = "INSERT INTO users VALUES('"+user.UserNumber+"','"+user.UserName+"','"+user.Sex+"','"+user.NicNumber+"','"+user.Address+"',"+isMember+","+0+")";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void RegisterExistingBook(Book book)
        {
            int availableCopies = GetAvailableBookCount(book.Title);
            int newCopyCount = Convert.ToInt32(book.CopyCount);
            string query = "UPDATE books SET numberOfCopies = " + newCopyCount + ",availableCopies=" + (availableCopies + 1);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public void RegisterNewBook(Book book)
        {

            string query = "INSERT INTO books values('" + book.Title + "','" + book.Classification + "','" + book.Identifier + "'," + 1 + "," + 1 + ")";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //*****************User Methods****************************
        public User GetUser(string userNumber)
        {
            int un = Convert.ToInt32(userNumber);
            string query = "SELECT * from users WHERE userNumber=" + un;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            User resUser = new User();
            while (reader.Read())
            {
                resUser.UserNumber = reader.GetString("userNumber");
                resUser.UserName = reader.GetString("userName");
                resUser.Address = reader.GetString("address");
                resUser.NicNumber = reader.GetString("nic");
                resUser.IsMember = reader.GetBoolean("isMember");
                resUser.BorrowedBookCount = reader.GetInt32("borrowedBooks");
            }

            return resUser;
        }

        //*****************Book Methods****************************
        public Book GetBookByTitle(string title)
        {
            string query = "SELECT * FROM books where title='" + title + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            string bookTitle = string.Empty;
            string classification = string.Empty;
            string identifier = string.Empty;
            int numberOfCopies = 0;
            int availableCopies = 0;
            while (reader.Read())
            {
                bookTitle = reader.GetString("title");
                classification = reader.GetString("classification");
                identifier = reader.GetString("identifier");
                numberOfCopies = reader.GetInt32("numberOfCopies");
                availableCopies = reader.GetInt32("availableCopies");

            }
            connection.Close();
            if (bookTitle != null && bookTitle != string.Empty)
            {
                Book book = new Book(bookTitle, classification, identifier, availableCopies.ToString(),numberOfCopies.ToString());
                return book;

            }
            else
            {
                Book book = new Book(title, "", "", 0.ToString(),0.ToString());
                return book;
            }

        }

        public Book GetBookByNumbers(string classification, string identifier)
        {
            string query = "SELECT * FROM books WHERE classification = '" + classification + "' AND identifier = '" + identifier + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            Book resBook = new Book();
            while (reader.Read())
            {
                resBook.Title = reader.GetString("title");
                resBook.Identifier = reader.GetString("identifier");
                resBook.Classification = reader.GetString("classification");
                resBook.CopyCount = reader.GetString("availableCopies");
                resBook.TotalCount = reader.GetString("numberOfCopies");
            }
            return resBook;
        }

        public int GetAvailableBookCount(string title)
        {
            string queryForAvailable = "SELECT * FROM books WHERE title = '" + title + "'";
            MySqlCommand cmd = new MySqlCommand(queryForAvailable, connection);
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            int availableCopies = 0;
            while (reader.Read())
            {
                availableCopies = reader.GetInt32("availableCopies");
            }
            connection.Close();
            return availableCopies;
        }


        //******************Reservation Methods*******************
        public void MakeReservation(Reservation reservation)
        {
            string query = "INSERT INTO reservations VALUES(" + reservation.UserNumber + ",'" + reservation.BookNumber + "')";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        public Reservation GetReservation(string bookNumber)
        {
            string query = "SELECT * FROM reservations WHERE bookNumber='" + bookNumber + "' LIMIT 1";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            Reservation reservation = new Reservation();
            connection.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                reservation.UserNumber = reader.GetInt32("userNumber");
                reservation.BookNumber = reader.GetString("bookNumber");
            }
            connection.Close();
            return reservation;
        }

        public void DeleteReservation(Reservation reservation)
        {
            string query = "DELETE FROM reservations WHERE bookNumber='" + reservation.BookNumber + "' AND userNumber=" + reservation.UserNumber;
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        //******************Library Processes*************
        public void UpdateWhenLoanInitialized(User user,Book book)
        {
        
            string queryForBook = "UPDATE books SET availableCopies=" + (Convert.ToInt32(book.CopyCount)) + " WHERE title='"+book.Title+"'";
            string queryForUser = "UPDATE users SET borrowedBooks=" + user.BorrowedBookCount + " WHERE userNumber=" + user.UserNumber;
            string queryForLoan = "INSERT INTO loans(bookNumber,userNumber,dueDate) values('"+book.Classification+" "+book.Identifier+"',"+ Convert.ToInt32(user.UserNumber) + ",'"+ DateTime.Now.AddDays(14).ToString("yyyy-MM-dd")+"')";
            MySqlCommand cmd1 = new MySqlCommand( queryForBook, connection);
            MySqlCommand cmd2 = new MySqlCommand( queryForUser, connection);
            MySqlCommand cmd3 = new MySqlCommand(queryForLoan, connection);
            connection.Open();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            connection.Close();
        }

        public Loan UpdateWhenBookReturned(User user, Book book)
        {
           
            string queryForBook = "UPDATE books SET availableCopies=" + (Convert.ToInt32(book.CopyCount)) + " WHERE title='" + book.Title + "'";
            string queryForUser = "UPDATE users SET borrowedBooks=" + user.BorrowedBookCount + " WHERE userNumber=" + user.UserNumber;
            string queryForLoan = "UPDATE loans SET isReturned="+true+ " WHERE bookNumber='" + book.Classification + " " + book.Identifier + "' AND userNumber=" + user.UserNumber;
            string selectLoan = "SELECT * FROM loans WHERE bookNumber='" + book.Classification + " " + book.Identifier + "' AND userNumber=" + user.UserNumber;
            MySqlCommand cmd0 = new MySqlCommand(queryForLoan,connection);
            MySqlCommand cmd1 = new MySqlCommand(queryForBook, connection);
            MySqlCommand cmd2 = new MySqlCommand(queryForUser, connection);
            MySqlCommand cmd3 = new MySqlCommand(selectLoan, connection);
            connection.Open();
            cmd0.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            Loan loan = new Loan();
            MySqlDataReader reader = cmd3.ExecuteReader();
            while (reader.Read())
            {
                loan.LoanNumber = reader.GetInt32("loanId");
                loan.BookNumber = reader.GetString("bookNumber");
                loan.UserNumber = reader.GetInt32("userNumber");
                loan.DueDate = reader.GetDateTime("dueDate");
            }
            connection.Close();
            return loan;
        }
        

    }
}
