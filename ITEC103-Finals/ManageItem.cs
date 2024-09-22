using MicroPOS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroPOS
{
    public partial class ManageItem : Form
    {
        List<int> ids = new List<int>();

        public ManageItem()
        {
            InitializeComponent();
        }

        private void ManageItem_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;

            DataTable categories = DatabaseHandler.LoadCategories();
            foreach (DataRow row in categories.Rows)
            {
                string category = Convert.ToString(row["category"]);
                categoryInput.Items.Add(category);
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

                ProductManager.editableProducts.Add(new EditableProduct(this.itemContainer, id, itemName, itemPrice, category, itemImage));
                ids.Add(id);
            }

            ProductManager.DisplayEditableProductsOnManageItemPage();
            LoadEditableProductControls(ProductManager.editableProducts);
        }

        public void LoadEditableProductControls(List<EditableProduct> editableProducts)
        {
            foreach (EditableProduct p in editableProducts)
            {
                p.UIdeleteItemButton.Click += DeleteItem;
                p.UIeditItemButton.Click += EditItem;
            }
        }

        //This adds the item to the database
        private void addItemToInventoryButton_Click(object sender, EventArgs e)
        {
            /*if (itemNameInput.Text == null) return;
            if (itemPriceInput.Text == null) return;
            if (itemImage.Image == null) return;*/
            if (!CheckIfInputsAreValid()) return;

            int id = GenerateNewId();
            string itemName = itemNameInput.Text;
            int itemPrice = 0;
            try
            {
                itemPrice = int.Parse(itemPriceInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number");
                return;
            }
            string category = categoryInput.Text.ToLower();
            Image itemImageIn = itemImage.Image;
            byte[] compressedImage = ImageProccessor.ConvertImageToByteArray(itemImageIn);

            //Add new item to database
            DatabaseHandler.AddNewItemToInventory(id, itemName, itemPrice, category, compressedImage);
            ProductManager.editableProducts.Add(new EditableProduct(this.itemContainer, id, itemName, itemPrice, category, itemImageIn));
            ProductManager.DisplayEditableProductsOnManageItemPage();
            itemNameInput.Text = "";
            itemPriceInput.Text = "";
            itemImage.Image = null;
            categoryInput.Text = "";
        }

        //Allow user to select an image for their item
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    itemImage.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occured");
            }
        }

        //Delete the item from the database
        public void DeleteItem(object sender, EventArgs e)
        {
            var confirmationDialog = MessageBox.Show("Are you sure you want to delete the item?", "Confirm Deletion!", MessageBoxButtons.YesNo);
            if (confirmationDialog == DialogResult.No) return;

            //Remove from the database
            int itemId = ItemHandler.GetItemId(sender);
            bool isDeletionSuccessful = DatabaseHandler.DeleteItemFromInventory(itemId);
            if (isDeletionSuccessful)
            {
                //Remove from the display
                Control deleteButton = sender as Control;
                Control item = deleteButton.Parent;
                itemContainer.Controls.Remove(item);
                item.Dispose();
                itemImage.Image = null;
                itemNameInput.Text = "";
                itemPriceInput.Text = "";
                updateItemInfo.Visible = false;
                addItemToInventoryButton.Visible = true;
            }
            else
            {
                MessageBox.Show("Item failed to delete!");
            }
        }

        Control itemToUpdate;
        //Edit the item's information
        public void EditItem(object sender, EventArgs e)
        {
            Control editButton = sender as Control;
            Control item = editButton.Parent;
            PictureBox image = item.Controls["itemImage"] as PictureBox;
            Control name = item.Controls["itemName"];
            Control price = item.Controls["itemPrice"];
            ItemEmbeddedData tag = item.Tag as ItemEmbeddedData;
            string category = tag.category;
            itemToUpdate = item;

            itemImage.Image = image.Image;
            itemNameInput.Text = name.Text;
            itemPriceInput.Text = price.Text.Substring(1, price.Text.Length - 1);
            categoryInput.Text = category;
            updateItemInfo.Visible = true;
            addItemToInventoryButton.Visible = false;
        }

        //Push an item update
        private void updateItemInfo_Click(object sender, EventArgs e)
        {
            if (!CheckIfInputsAreValid()) return;

            ItemEmbeddedData tag = itemToUpdate.Tag as ItemEmbeddedData;
            int itemId = tag.id;
            string name = itemNameInput.Text;
            int price = 0;
            try
            {
                price = int.Parse(itemPriceInput.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number");
                return;
            }
            string category = categoryInput.Text.ToLower();
            Image image = itemImage.Image;
            byte[] imageByte = ImageProccessor.ConvertImageToByteArray(image);
            bool updateSuccesful = DatabaseHandler.UpdateItemFromInventory(itemId, name, price, category, imageByte);
            if (!updateSuccesful) MessageBox.Show("An error occured while updating item");

            itemContainer.Controls.Remove(itemToUpdate);
            itemToUpdate.Dispose();

            for (int i = 0; i < ProductManager.editableProducts.Count; i++)
            {
                EditableProduct p = ProductManager.editableProducts[i];
                if (p.id == itemId)
                {
                    ProductManager.editableProducts[i].id = itemId;
                    ProductManager.editableProducts[i].name = name;
                    ProductManager.editableProducts[i].price = price;
                    ProductManager.editableProducts[i].category = category;
                    ProductManager.editableProducts[i].itemImage = image;
                }
            }

            ProductManager.DisplayEditableProductsOnManageItemPage();

            itemImage.Image = null;
            itemNameInput.Text = "";
            itemPriceInput.Text = "";
            updateItemInfo.Visible = false;
            addItemToInventoryButton.Visible = true;
        }

        //Generate new id
        private int GenerateNewId()
        {
            Random rand = new Random();
            bool generating = true;
            int id = 0;
            int minRange = 1000;
            int maxRange = 10000;
            while (generating)
            {
                id = rand.Next(minRange, maxRange);
                if (ids.Contains(id)) continue;

                generating = false;
            }

            return id;
        }

        public bool CheckIfInputsAreValid()
        {
            if (categoryInput.Text == "all")
            {
                MessageBox.Show("Item category can't be set to \"ALL\"");
                return false;
            }

            if (itemNameInput.Text == "" || itemPriceInput.Text == "" || categoryInput.Text == "" || itemImage.Image == null)
            {
                MessageBox.Show("You're missing something please fill in the input properly");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void backButtonIcon_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;
            mainForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageCategories frm = new ManageCategories();
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = this.Location;
            frm.Show();
        }
    }
}
