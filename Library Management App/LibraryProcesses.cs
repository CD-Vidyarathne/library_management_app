using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_App
{
    internal class LibraryProcesses
    {
        public void LoanBook(User user, Book book)
        {
            user.BorrowedBookCount = user.BorrowedBookCount + 1;
            book.CopyCount = (Convert.ToInt32(book.CopyCount) - 1).ToString() ;

            try
            {
                new DbProcess().UpdateWhenLoanInitialized(user, book);
                MessageBox.Show("Loan Success");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public string GetInquiry(string title)
        {
            try
            {
                int count = new DbProcess().GetAvailableBookCount(title);
                if (count == 0)
                {                    
                    return ("Sorry. Book " + title + " is not available at the moment."); 
                }else if(count == 1)
                {                    
                    return (count + " copy of " + title + " is available.");
                }else if (count > 1)
                {                  
                    return (count + " copies of " + title + " are available.");
                }
                else
                {             
                    return ("Something went wrong.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ("");
            }
        }

        public void ReturnBook(User user, Book book)
        {
            user.BorrowedBookCount = user.BorrowedBookCount - 1;
            book.CopyCount = (Convert.ToInt32(book.CopyCount) + 1).ToString();

            try
            {
                Loan loan = new DbProcess().UpdateWhenBookReturned(user, book);
                if(loan.DueDate < DateTime.Now)
                {
                    MessageBox.Show("Book is over due date. A tax should be charged.");
                }
                else
                {
                    MessageBox.Show("Thanks for returnning the book.");
                }
                Reservation reservation = this.CheckForReservations(book.Classification + " " + book.Identifier);
                if (reservation.BookNumber == string.Empty)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Reservation is found. User Number " + reservation.UserNumber + " should be informed.");
                    new DbProcess().DeleteReservation(reservation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void MakeReservation(string bookNumber,int userNumber)
        {
            Reservation reservation = new Reservation(bookNumber,userNumber);
            try
            {
                new DbProcess().MakeReservation(reservation);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public Reservation CheckForReservations(string bookNumber)
        {
            try
            {
                Reservation reservation = new DbProcess().GetReservation(bookNumber);
                return reservation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            return new Reservation();
        }
    }
}
