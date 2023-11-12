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
    public partial class RegisterBook : Form
    {
        bool bookExisted = true;
        Book newBook = new Book();
        public RegisterBook()
        {
            InitializeComponent();
            btn_book_register.Visible = false;
            txt_class.Visible = false;
            txt_number.Visible = false;
        }

        private void btn_fill_data_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
           
            try
            {
                Book book = new DbProcess().GetBookByTitle(title);
                if (Convert.ToInt32(book.CopyCount) == 0)
                {
                    MessageBox.Show("This is a new book. Please provide Details.");
                    bookExisted = false;
                    txt_class.Visible = true;
                    txt_number.Visible = true;
                    lbl_number.Visible=false;
                    lbl_class.Visible=false;
                    lbl_copy.Text = "1";
                    lbl_code.Visible=false;
                }
                else
                {
                    bookExisted=true;
                    lbl_number.Text = book.Identifier;
                    lbl_class.Text = book.Classification;
                    lbl_copy.Text = book.CopyCount;
                    lbl_code.Text = book.BookCode;
                    newBook.Title = book.Title;
                    newBook.CopyCount = book.CopyCount;
                    newBook.Classification = book.Classification;
                    newBook.Identifier = book.Identifier;
                    newBook.BookCode = book.BookCode;
                }
                btn_book_register.Visible=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btn_book_register_Click(object sender, EventArgs e)
        {
            if (bookExisted)
            {
                if (newBook.CopyCount == "10")
                {
                    MessageBox.Show("Maximum Copies for the book " + newBook.BookCode + " reached. Cannot Proceed.");
                    return;
                }
                else
                {
                    try
                    {
                        new DbProcess().RegisterExistingBook(newBook);
                        MessageBox.Show("Registration Success.");

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
               
            }
            else
            {
                newBook.Title = txt_title.Text;
                newBook.Classification = txt_class.Text;
                newBook.Identifier = txt_number.Text;
                newBook.CopyCount = "1";
                newBook.BookCode = txt_class.Text + ' ' + txt_number.Text + '0';
                try
                {
                    new DbProcess().RegisterNewBook(newBook);
                    MessageBox.Show("Registration Success.");
                    this.Hide();
                    new MainMenu().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
