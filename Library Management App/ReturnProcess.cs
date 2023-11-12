﻿using System;
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
    public partial class ReturnProcess : Form
    {
        public ReturnProcess()
        {
            InitializeComponent();
        }

        private void btn_book_return_Click(object sender, EventArgs e)
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
            if (book.Title == "")
            {
                MessageBox.Show("No book found with this credentials.");
                return;
            }

            try
            {
                new LibraryProcesses().ReturnBook(user, book);
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
