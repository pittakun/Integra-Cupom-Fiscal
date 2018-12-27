using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GelocarEntregas
{
    class connection
    {
        string server = "127.0.0.1";
        string database = "bdonlineservice";
        string root = "root";
        string key = "";

        public MySqlConnection connect;

        public void init()
        {

            string way = "SERVER=" + server + ";Database=" + database + ";UID=" + root + ";PASSWORD=" + key + ";SSL MODE = NONE";

            try
            {
                connect = new MySqlConnection(way);
                connect.Open();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void disconnect()
        {
            connect.Close();
        }

    }
}
