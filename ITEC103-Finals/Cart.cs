using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace ITEC103_Finals
{
    public class Cart
    {
        //This contains all the items in the cart
        public static List<CartItem> items = new List<CartItem>();
        
        public static void LoadCartItemToDisplay(Main mainForm)
        {
            if (items.Count == 0) return; 
            foreach (CartItem item in items)
            {
                mainForm.NewCartItemDisplay(item.id, item.itemName, item.quantity);
            }
            
        }

        public static void AddNewItemToCart(int id, string name, int price, Control cartDisplay, Main mainForm)
        {

            //Check if an item is already in the cart, if yes increase it's quantity
            //if no add a new one
            if (items.Any(obj => obj.id == id))
            {
                IncreaseItemQuantity(id, cartDisplay);
            }
            else
            {
                items.Add(new CartItem(id, name, price));
                mainForm.NewCartItemDisplay(id, name, 1);
            }
        }

        public static void IncreaseItemQuantity(int id, Control  cartDisplay)
        {
            CartItem item = IdentifyItemBasedonId(id);
            int index = items.IndexOf(item);
            items[index].quantity += 1;
            UpdateitemQuantityDisplay(id, index, cartDisplay);
        }
        
        public static void DecreaseItemQuantity(int id, Control  cartDisplay)
        {
            CartItem item = IdentifyItemBasedonId(id);
            int index = items.IndexOf(item);
            items[index].quantity -= 1;
            UpdateitemQuantityDisplay(id, index, cartDisplay);
        }

        //Removes item both in the list and cart display
        public static void RemoveItem(int id, Control cartDisplay)
        {
            CartItem item = IdentifyItemBasedonId(id);
            int index = items.IndexOf(item);
            items.RemoveAt(index);
            cartDisplay.Controls.Remove(cartDisplay.Controls[id.ToString()]);
        }

        public static void UpdateitemQuantityDisplay(int id, int index,Control cartDisplay)
        {
            Control itemDisplay = cartDisplay.Controls[id.ToString()];
            Control itemQuantityDisplay = itemDisplay.Controls["quantity"];
            itemQuantityDisplay.Text = items[index].quantity.ToString();
        }


        private static CartItem IdentifyItemBasedonId(int id)
        {
            var r = from item in items where item.id == id select item;
            CartItem identifiedItem = r.First();
            return identifiedItem;
        }
    }
}