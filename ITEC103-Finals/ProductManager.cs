using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroPOS
{
    public class ProductManager
    {
        public static List<Product> products = new List<Product>();
        public static List<EditableProduct> editableProducts = new List<EditableProduct>();

        public static void DisplayProductsOnMainPage()
        {
            foreach (Product product in products)
            {
                product.Display();
            }
        }

        public static void DisplayEditableProductsOnManageItemPage()
        {
            foreach (EditableProduct p in editableProducts)
            {
                p.Display();
            }
        }
    }
}
