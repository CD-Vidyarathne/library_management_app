using Library_Management_App;
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
    public partial class InquiryProcess : Form
    {
        public InquiryProcess()
        {
            InitializeComponent();
        }

        private void btn_get_inquiry_Click(object sender, EventArgs e)
        {
            if (txt_book_class.Text == "" || txt_book_identifier.Text == "")
            {
                MessageBox.Show("Please provide all the details.");
                return;
            }
            string bookClassification = txt_book_class.Text;
            string bookIdentifier = txt_book_identifier.Text;

            Book book = new DbProcess().GetBookByNumbers(bookClassification, bookIdentifier);

            if (book.Title == "")
            {
                MessageBox.Show("No book found with this credentials.");
                return;
            }

            string resInquiry = new LibraryProcesses().GetInquiry(book.Title);

            lbl_result.Text = resInquiry;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
