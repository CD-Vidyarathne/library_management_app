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
    public partial class GetDetails : Form
    {
        public GetDetails()
        {
            InitializeComponent();
        }

        private void btn_run_user_Click(object sender, EventArgs e)
        {
            if (txt_userNumber.Text == "")
            {
                MessageBox.Show("Please provide all the details.");
                return;
            }
            try
            {
                User user = new DbProcess().GetUser(txt_userNumber.Text);
                if (user.UserName=="")
                {
                    MessageBox.Show("No user found.");
                    return;
                }
                lbl_name.Text = user.UserName;
                lbl_address.Text = user.Address;
                lbl_nic.Text = user.NicNumber;
                lbl_bbc.Text = user.BorrowedBookCount.ToString();
                lbl_permission.Text = user.IsMember ? "Member" : "Visitor";
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }

        private void btn_run_book_Click(object sender, EventArgs e)
        {
            if (txt_book_class.Text == "" || txt_book_identifier.Text=="")
            {
                MessageBox.Show("Please provide all the details.");
                return;
            }
            try
            {
                Book book = new DbProcess().GetBookByNumbers(txt_book_class.Text, txt_book_identifier.Text);
                if (book.Title == "")
                {
                    MessageBox.Show("No Book found.");
                    return;
                }
                lbl_title.Text = book.Title;
                lbl_availableCount.Text = book.CopyCount;
                lbl_totalCount.Text = book.TotalCount;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
