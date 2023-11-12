using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_App
{
    internal class User
    {
        private string userNumber;
        private string userName;
        private string sex;
        private string nicNumber;
        private string address;
        private int borrowedBookCount;
        private bool isMember;

        public User()
        {
            this.userNumber = string.Empty;
            this.userName = string.Empty;
            this.sex = string.Empty;
            this.nicNumber = string.Empty;
            this.address = string.Empty;
            this.borrowedBookCount = 0;
            this.isMember = false;
        }

        public string UserNumber { get { return userNumber; } set { userNumber = value; } }
        public string UserName { get { return userName; } set { userName = value; } }
        public string Sex { get {  return sex; } set {  sex = value; } }
        public string NicNumber { get { return nicNumber; } set { nicNumber = value; } }
        public string Address { get { return address; } set { address = value; } }  
        public int BorrowedBookCount { get {  return borrowedBookCount; } set {  borrowedBookCount = value; } }
        public bool IsMember { get {  return isMember; } set {  isMember = value; } }
           
    }
}
