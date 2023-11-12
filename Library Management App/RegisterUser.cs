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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string userNumber = txt_userNumber.Text;
            string userName = txt_userName.Text;
            string nicNumber = txt_nic.Text;
            string address = txt_address.Text;
            bool isMale = rdb_male.Checked;
            bool isMember = rdb_member.Checked;
            if(userNumber==""||userName==""||nicNumber==""||address==""||(!rdb_male.Checked && !rdb_female.Checked)||(!rdb_member.Checked && !rdb_visitor.Checked)){
                MessageBox.Show("Please Provide All the Details.");
                return;
            }
           
       
            User user = new User();
            user.UserNumber = userNumber;
            user.UserName = userName;
            user.Address = address;
            user.NicNumber = nicNumber;
            user.Sex = isMale ? "Male" : "Female";
            try
            {
                new DbProcess().RegisterUser(user, isMember);
                MessageBox.Show("Registration Success");
                this.Hide();
                new MainMenu().Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainMenu().Show();
        }
    }
}
