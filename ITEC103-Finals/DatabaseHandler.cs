﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
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
            catch (Exception err)
            {
                MessageBox.Show("An error occured while connecting to the database" + err);

            }

            return data;
        }

        //Adds an item to the database
        public static void AddNewItemToInventory(int id, string name, int price, byte[] image)
        {
            //Opens the connection to the database
            if (ConnectionState.Closed == connection.State) connection.Open();

            try
            {
                string insertQuery = "INSERT INTO item (id, itemName, itemPrice, itemImage) VALUES (@id, @itemName, @itemPrice, @itemImage)";
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@itemName", name);
                command.Parameters.AddWithValue("@itemprice", price);
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
            if (ConnectionState.Closed == connection.State) connection.Open();

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

        public static bool UpdateItemFromInventory(int id, string itemName, int itemPrice, byte[] imageByte)
        {
            //Opens the connection to the database
            if (ConnectionState.Closed == connection.State) connection.Open();

            try
            {
                string deleteQuery = $"UPDATE item SET itemName = @newItemName, itemPrice = @newItemPrice, itemImage = @newItemImage WHERE id = {id};";
                MySqlCommand command = new MySqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@newItemName", itemName);
                command.Parameters.AddWithValue("@newItemPrice", itemPrice);
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
    }
}
