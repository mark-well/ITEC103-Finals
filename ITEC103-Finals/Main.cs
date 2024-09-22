using System.Data;
using System.Xml.Linq;

namespace MicroPOS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
            DataTable categories = DatabaseHandler.LoadCategories();
            foreach (DataRow row in categories.Rows)
            {
                string category = Convert.ToString(row["category"]);
                categorySearchBar.Items.Add(category);
            }

            DataTable allItems = DatabaseHandler.LoadItemsFromDatabase();
            foreach (DataRow row in allItems.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string itemName = Convert.ToString(row["itemName"]);
                int itemPrice = Convert.ToInt32(row["itemPrice"]);
                string category = Convert.ToString(row["category"]);
                byte[] itemImageByteData = (byte[])row["itemImage"];
                Image itemImage = ImageProccessor.ConvertByteArrayToImage(itemImageByteData);

                ProductManager.products.Add(new Product(this.itemContainer, id, itemName, itemPrice, category, itemImage));
            }

            ProductManager.DisplayProductsOnMainPage();
            LoadProductControls(ProductManager.products);
            Cart.LoadCartItemToDisplay(this);
        }

        public void LoadProductControls(List<Product> products)
        {
            foreach (Product p in products)
            {
                p.UIimage.Click += AddItemToCart_Click;
            }
        }

        //Add item to the cart
        private void AddItemToCart_Click(object sender, EventArgs e)
        {
            Control item = sender as Control;
            Control parent = item.Parent;
            Control itemName = parent.Controls["itemName"];
            Control itemPrice = parent.Controls["itemPrice"];
            int id = ItemHandler.GetItemId(sender);

            Cart.AddNewItemToCart(id, itemName.Text, Convert.ToInt32(Utility.RemoveFirstLetterOfAString(itemPrice.Text)), cartDisplay, this);
        }

        public void NewCartItemDisplay(int id, string name, int _quantity)
        {

            PictureBox dicreaseQuantity = new PictureBox();
            dicreaseQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dicreaseQuantity.Image = Properties.Resources.minus;
            dicreaseQuantity.Location = new Point(98, 16);
            dicreaseQuantity.Name = "dicreaseQuantity";
            dicreaseQuantity.Size = new Size(20, 20);
            dicreaseQuantity.SizeMode = PictureBoxSizeMode.Zoom;
            dicreaseQuantity.TabIndex = 3;
            dicreaseQuantity.TabStop = false;
            dicreaseQuantity.Click += decreaseItemQuantity;

            PictureBox increaseQuantity = new PictureBox();
            increaseQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            increaseQuantity.Image = Properties.Resources.plus;
            increaseQuantity.Location = new Point(144, 16);
            increaseQuantity.Name = "increaseQuantity";
            increaseQuantity.Size = new Size(20, 20);
            increaseQuantity.SizeMode = PictureBoxSizeMode.Zoom;
            increaseQuantity.TabIndex = 2;
            increaseQuantity.TabStop = false;
            increaseQuantity.Click += increaseItemQuantity;

            Label quantity = new Label();
            quantity.AutoSize = true;
            quantity.BackColor = Color.Transparent;
            quantity.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.ForeColor = Color.Black;
            quantity.Location = new Point(121, 10);
            quantity.MaximumSize = new Size(30, 100);
            quantity.MinimumSize = new Size(20, 30);
            quantity.Name = "quantity";
            quantity.RightToLeft = RightToLeft.No;
            quantity.Size = new Size(20, 30);
            quantity.TabIndex = 1;
            quantity.Text = _quantity.ToString();
            quantity.TextAlign = ContentAlignment.MiddleCenter;
            quantity.UseMnemonic = false;

            //Item name
            Label itemName = new Label();
            itemName.AutoSize = true;
            itemName.AutoSize = true;
            itemName.BackColor = Color.Transparent;
            itemName.Font = new Font("Arial", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            itemName.ForeColor = Color.Black;
            itemName.Location = new Point(5, 0);
            itemName.MaximumSize = new Size(100, 100);
            itemName.MinimumSize = new Size(90, 50);
            itemName.Name = "itemName";
            itemName.RightToLeft = RightToLeft.No;
            itemName.Size = new Size(90, 50);
            itemName.TabIndex = 0;
            itemName.Text = name;
            itemName.TextAlign = ContentAlignment.MiddleLeft;

            PictureBox removeItemfromCart = new PictureBox();
            removeItemfromCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeItemfromCart.Image = Properties.Resources.delete;
            removeItemfromCart.Location = new Point(177, 16);
            removeItemfromCart.Name = "removeCartFromItemButton";
            removeItemfromCart.Size = new Size(20, 20);
            removeItemfromCart.SizeMode = PictureBoxSizeMode.Zoom;
            removeItemfromCart.TabIndex = 4;
            removeItemfromCart.TabStop = false;
            removeItemfromCart.Click += removeItem;

            Panel cartItem = new Panel();
            cartItem.Tag = new ItemEmbeddedData { id = id };
            cartItem.BackColor = Color.White;
            cartItem.Controls.Add(dicreaseQuantity);
            cartItem.Controls.Add(increaseQuantity);
            cartItem.Controls.Add(quantity);
            cartItem.Controls.Add(itemName);
            cartItem.Controls.Add(removeItemfromCart);
            cartItem.ForeColor = Color.White;
            cartItem.Location = new Point(0, 0);
            cartItem.Margin = new Padding(0);
            cartItem.Name = id.ToString();
            cartItem.Size = new Size(200, 50);
            cartItem.TabIndex = 0;

            this.cartDisplay.Controls.Add(cartItem);
        }

        public void increaseItemQuantity(object sender, EventArgs e)
        {
            int id = ItemHandler.GetItemId(sender);
            Cart.IncreaseItemQuantity(id, cartDisplay);
        }

        public void decreaseItemQuantity(object sender, EventArgs e)
        {
            int id = ItemHandler.GetItemId(sender);
            Cart.DecreaseItemQuantity(id, cartDisplay);
        }

        public void removeItem(object sender, EventArgs e)
        {
            int id = ItemHandler.GetItemId(sender);
            Cart.RemoveItem(id, cartDisplay);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ManageItem manageItemForm = new ManageItem();
            manageItemForm.StartPosition = FormStartPosition.Manual;
            manageItemForm.Location = this.Location;
            manageItemForm.Show();
            this.Hide();
        }

        private void chargeButton_Click(object sender, EventArgs e)
        {
            if (Cart.items.Count == 0)
            {
                MessageBox.Show("Add a product first");
            }
            else
            {
                Charge_Page chargePage = new Charge_Page();
                chargePage.Show();
                this.Hide();
            }
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {
            //itemContainer.Controls.Clear();
            foreach (Control child in itemContainer.Controls)
            {
                child.Visible = false;
            }

            DataTable allItems = DatabaseHandler.SearchItemByName(searchBar.Text);
            foreach (DataRow row in allItems.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                /*string itemName = Convert.ToString(row["itemName"]);
                int itemPrice = Convert.ToInt32(row["itemPrice"]);
                byte[] itemImageByteData = (byte[])row["itemImage"];
                Image itemImage = ImageProccessor.ConvertByteArrayToImage(itemImageByteData);
                */
                foreach (Control child in itemContainer.Controls)
                {
                    try
                    {
                        if (Convert.ToInt32(child.Name) == id)
                        {
                            child.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }

                //Add the item to the display
                //AddNewItem(id, itemName, itemPrice, itemImage);
            }
        }

        private void categorySearchBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control child in itemContainer.Controls)
            {
                child.Visible = false;
            }

            DataTable allItems = DatabaseHandler.FilterByCategory(categorySearchBar.Text);
            foreach (DataRow row in allItems.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                foreach (Control child in itemContainer.Controls)
                {
                    try
                    {
                        if (Convert.ToInt32(child.Name) == id)
                        {
                            child.Visible = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
            }
        }
    }
}
