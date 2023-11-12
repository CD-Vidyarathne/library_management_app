using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Library_Management_App
{
    internal class DatabaseConnection
    {
        public MySqlConnection ConnectDb()
        {
            string connectionStr = "server=localhost;uid=root;pwd=;database=libraryDB";
            MySqlConnection connection = new MySqlConnection(connectionStr);
            return connection;
        }
    }
}
