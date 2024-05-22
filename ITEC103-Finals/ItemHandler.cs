using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITEC103_Finals
{
    public static class ItemHandler
    {

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
