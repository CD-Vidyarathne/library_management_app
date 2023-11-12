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
    public partial class ReservationProcess : Form
    {
        public ReservationProcess()
        {
            InitializeComponent();
        }

        private void btn_make_reservation_Click(object sender, EventArgs e)
        {
            if (txt_book_class.Text == "" || txt_book_identifier.Text == "" || txt_userNumber.Text == "")
            {
                MessageBox.Show("Please provide all the details.");
                return;
            }
            string bookClassification = txt_book_class.Text;
            string bookIdentifier = txt_book_identifier.Text;
            string userNumber = txt_userNumber.Text;

            new LibraryProcesses().MakeReservation((bookClassification + " " + bookIdentifier), (Convert.ToInt32(userNumber)));
            MessageBox.Show("Reservation taken.");
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
