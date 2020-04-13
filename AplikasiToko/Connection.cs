using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplikasiToko
{
    class Connection
    {
        private String connectionString;
        public MySqlConnection connection;

        public MySqlCommand cmd = new MySqlCommand();
        public MySqlDataAdapter da;
        public MySqlDataReader dr;
        public DataSet ds;

        public Connection()
        {
            connectionString = "Server=localhost;port=3306;database=dbtoko;uid=root;pwd=";

            connection = new MySqlConnection(connectionString);
        }

        public bool openConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error : {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool closeConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException e)
            {
                MessageBox.Show($"Error : {e.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}