using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace MicroPOS
{
    public static class DatabaseHandler
    {
        public static string connectionString = "Server=localhost;Database=pos_inventory;Uid=root;";
        public static MySqlConnection connection = new MySqlConnection(connectionString);

        private static bool OpenConnection()
        {
            try
            {
                if (ConnectionState.Closed == connection.State) connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot establish a connection to the database");
                return false;
            }
        }

        public static DataTable LoadCategories()
        {
            //Opens the connection to the database
            if (!OpenConnection()) return new DataTable();

            DataTable data = new DataTable();
            try
            {
                string queryString = "SELECT DISTINCT * FROM categories ORDER BY category";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                {
                    sda.Fill(data);
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);

            }

            return data;
        }

        //Load all the items from the database
        public static DataTable LoadItemsFromDatabase()
        {
            //Opens the connection to the database
            if (!OpenConnection()) return new DataTable();

            DataTable data = new DataTable();
            try
            {
                string queryString = "SELECT DISTINCT id, itemName, ItemPrice, category, itemImage FROM item ORDER BY itemName";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                {
                    sda.Fill(data);
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);

            }

            return data;
        }

        //Adds an item to the database
        public static void AddNewItemToInventory(int id, string name, int price, string category, byte[] image)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return;

            try
            {
                string insertQuery = "INSERT INTO item (id, itemName, itemPrice, category, itemImage) VALUES (@id, @itemName, @itemPrice, @category, @itemImage)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@itemName", name);
                command.Parameters.AddWithValue("@itemprice", price);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@itemImage", image);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);
            }
        }

        //Deletes an item from the database
        public static bool DeleteItemFromInventory(int id)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return false;

            try
            {
                string deleteQuery = $"DELETE FROM `item` WHERE id = {id};";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception err)
            {
                return false;
                MessageBox.Show("An error occured while connecting to the database" + err);
            }
        }

        public static void DeleteItemFromInventoryByCategory(string category)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return;

            try
            {
                string deleteQuery = $"DELETE FROM `item` WHERE category = @category";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@category", category);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);
            }
        }

        public static bool UpdateItemFromInventory(int id, string itemName, int itemPrice, string category, byte[] imageByte)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return false;

            try
            {
                string deleteQuery = $"UPDATE item SET itemName = @newItemName, itemPrice = @newItemPrice, category = @newCategory, itemImage = @newItemImage WHERE id = {id};";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@newItemName", itemName);
                command.Parameters.AddWithValue("@newItemPrice", itemPrice);
                command.Parameters.AddWithValue("@newCategory", itemPrice);
                command.Parameters.AddWithValue("@newItemImage", imageByte);
                command.ExecuteNonQuery();;
                connection.Close();

                return true;
            }
            catch (Exception err)
            {
                return false;
                MessageBox.Show("An error occured while connecting to the database" + err);
            }
        }

        public static DataTable SearchItemByName(string searchTerm)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return new DataTable();

            DataTable data = new DataTable();
            try
            {
                string queryString = "SELECT id FROM item WHERE itemName LIKE @searchTerm";
                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                {
                    sda.Fill(data);
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);
            }

            return data;
        }
        
        public static DataTable FilterByCategory(string category)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return new DataTable();

            DataTable data = new DataTable();
            try
            {
                string queryString;
                if (category == "all")
                {
                   queryString = "SELECT DISTINCT id, itemName, ItemPrice, category, itemImage FROM item ORDER BY itemName";
                }
                else
                {
                   queryString = "SELECT id FROM item WHERE category = @categorySearch";
                }
                
                MySqlCommand command = new MySqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@categorySearch", category);
                using (MySqlDataAdapter sda = new MySqlDataAdapter(command))
                {
                    sda.Fill(data);
                }
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);
            }

            return data;
        }

        public static void AddNewItemCategory(string category)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return;

            try
            {
                string insertQuery = "INSERT INTO categories (category) VALUES (@category)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@category", category);
                command.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);
            }
        }

        public static void DeleteItemCategory(string category)
        {
            //Opens the connection to the database
            if (!OpenConnection()) return;

            try
            {
                string deleteQuery = $"DELETE FROM `categories` WHERE category = @category";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@category", category);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);
            }
        }
    }
}
