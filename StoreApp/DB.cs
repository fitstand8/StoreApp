using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace StoreApp
{
    class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=murray1997;database=Storedb");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) connection.Close();
        }

        public MySqlConnection Connection
        {
            get { return connection; }
        }
    }
}
