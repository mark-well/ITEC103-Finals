using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ITEC103_Finals
{
    public static class DatabaseHandler
    {
        public static string connectionString = "Server=localhost;Database=pos_inventory;Uid=root;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        //Load all the items from the database
        public static DataTable LoadItemsFromDatabase()
        {
            //Opens the connection to the database
            if (ConnectionState.Closed == connection.State) connection.Open();

            DataTable data = new DataTable();
            try
            {
                string queryString = "SELECT DISTINCT id, itemName, ItemPrice, itemImage FROM item";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                {
                    sda.Fill(data);
                }
                connection.Close();
            }
            catch (Exception)
            {

            }

            return data;
        }
    }
}
