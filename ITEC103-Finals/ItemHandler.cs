using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC103_Finals
{
    public static class ItemHandler
    {
        //Get the id of the item that is embedded to the tag property
        public static int GetItemId(object sender)
        {
            Control triger = sender as Control;
            Control item = triger.Parent;
            ItemEmbeddedData itemTag = item.Tag as ItemEmbeddedData;
            int id = itemTag.id;

            return id;
        }
    }

    public class CartItem
    {
        public int id;
        public string itemName;
        public int itemPrice;
        public int quantity;

        public CartItem(int _id, string name, int price)
        {
            itemName = name;
            itemPrice = price;
            id = _id;
            quantity = 1;
        }
    }

    public class ItemEmbeddedData
    {
        public int id { get; set; }
    }
}
