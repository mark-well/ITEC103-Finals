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

    public struct Item
    {
        public int id;
        public string itemName;
        public int itemPrice;

        public Item(string name, int price)
        {
            Random rand = new Random();
            itemName = name;
            itemPrice = price;
            id = rand.Next(1000, 10000);
        }
    }

    public class ItemEmbeddedData
    {
        public int id { get; set; }
    }
}
