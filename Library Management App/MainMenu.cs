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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_main_reg_user_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterUser().Show();
        }

        private void btn_main_reg_book_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RegisterBook().Show();
        }

        private void btn_main_loan_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoanProcess().Show();
        }

        private void btn_main_return_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReturnProcess().Show();
        }

        private void btn_main_get_inquiry_Click(object sender, EventArgs e)
        {
            this.Hide();
            new InquiryProcess().Show();
        }

        private void btn_main_make_reservation_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReservationProcess().Show();
        }

        private void btn_main_get_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            new GetDetails().Show();
        }

        private void btn_main_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
