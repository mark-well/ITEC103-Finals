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

            DataTable allItems = DatabaseHandler.LoadItemsFromDatabase();
            foreach (DataRow row in allItems.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string itemName = Convert.ToString(row["itemName"]);
                int itemPrice = Convert.ToInt32(row["itemPrice"]);
                byte[] itemImageByteData = (byte[])row["itemImage"];
                Image itemImage = ImageProccessor.ConvertByteArrayToImage(itemImageByteData);
                AddNewItem(id, itemName, itemPrice, itemImage);

                //Add existing id to the list
                ids.Add(id);
            }
        }

        private void AddNewItem(int _id, string name, int price, Image itemImage)
        {
            Button deleteItemButton = new Button();
            deleteItemButton.Font = new Font("Arial Narrow", 8.25F);
            deleteItemButton.Location = new Point(52, 105);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(43, 25);
            deleteItemButton.TabIndex = 5;
            deleteItemButton.Text = "Delete";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteItemButton.Click += DeleteItem;

            Button editItemButton = new Button();
            editItemButton.Font = new Font("Arial Narrow", 8.25F);
            editItemButton.Location = new Point(4, 105);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(42, 25);
            editItemButton.TabIndex = 4;
            editItemButton.Text = "Edit";
            editItemButton.UseVisualStyleBackColor = true;
            editItemButton.BackColor = Color.FromArgb(59, 140, 247);
            editItemButton.Click += EditItem;

            Label line = new Label();
            line.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            line.BackColor = Color.Black;
            line.BorderStyle = BorderStyle.Fixed3D;
            line.Location = new Point(4, 98);
            line.Name = "line";
            line.Size = new Size(93, 2);
            line.TabIndex = 3;

            Label itemName = new Label();
            itemName.AutoSize = true;
            itemName.BackColor = Color.Transparent;
            itemName.ForeColor = Color.Black;
            itemName.Location = new Point(0, 68);
            itemName.MaximumSize = new Size(100, 0);
            itemName.MinimumSize = new Size(100, 0);
            itemName.Name = "itemName";
            itemName.Size = new Size(100, 30);
            itemName.TabIndex = 1;
            itemName.Text = name;
            itemName.TextAlign = ContentAlignment.MiddleCenter;

            Label itemPrice = new Label();
            itemPrice.AutoSize = true;
            itemPrice.Dock = DockStyle.Top;
            itemPrice.Location = new Point(0, 0);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(26, 15);
            itemPrice.TabIndex = 2;
            itemPrice.Text = "P" + price.ToString();

            PictureBox image = new PictureBox();
            image.BackColor = Color.Transparent;
            image.BackgroundImageLayout = ImageLayout.Center;
            image.Image = itemImage;
            image.Location = new Point(2, 2);
            image.Name = "itemImage";
            image.Size = new Size(95, 80);
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;

            Panel item = new Panel();
            item.BorderStyle = BorderStyle.FixedSingle;
            item.BackColor = Color.White;
            item.Controls.Add(deleteItemButton);
            item.Controls.Add(editItemButton);
            item.Controls.Add(itemName);
            item.Controls.Add(itemPrice);
            item.Controls.Add(image);
            item.Location = new Point(3, 3);
            item.Name = "item";
            item.Size = new Size(100, 135);
            item.TabIndex = 1;
            item.Tag = new ItemEmbeddedData { id = _id };
            item.Controls.Add(line);
            itemContainer.Controls.Add(item);
        }

        //This adds the item to the database
        private void addItemToInventoryButton_Click(object sender, EventArgs e)
        {
            if (itemNameInput.Text == null) return;
            if (itemPriceInput.Text == null) return;
            if (itemImage.Image == null) return;

            int id = GenerateNewId();
            string itemName = itemNameInput.Text;
            int itemPrice = 0;
            try
            {
                itemPrice = int.Parse(itemPriceInput.Text);
            }catch (Exception ex)
            {
                MessageBox.Show("Enter a valid number");
                return;
            }
            Image itemImageIn = itemImage.Image;
            byte[] compressedImage = ImageProccessor.ConvertImageToByteArray(itemImageIn);

            //Add new item to database
            DatabaseHandler.AddNewItemToInventory(id, itemName, itemPrice, compressedImage);
            AddNewItem(id, itemName, itemPrice, itemImageIn);
            itemNameInput.Text = "";
            itemPriceInput.Text = "";
            itemImage.Image = null;
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
            itemToUpdate = item;

            itemImage.Image = image.Image;
            itemNameInput.Text = name.Text;
            itemPriceInput.Text = price.Text.Substring(1, price.Text.Length - 1);
            updateItemInfo.Visible = true;
            addItemToInventoryButton.Visible = false;
        }

        //Push an item update
        private void updateItemInfo_Click(object sender, EventArgs e)
        {
            ItemEmbeddedData tag = itemToUpdate.Tag as ItemEmbeddedData;
            int itemId = tag.id;
            string name = itemNameInput.Text;
            int price = Convert.ToInt32(itemPriceInput.Text);
            Image image = itemImage.Image;
            byte[] imageByte = ImageProccessor.ConvertImageToByteArray(image);
            bool updateSuccesful = DatabaseHandler.UpdateItemFromInventory(itemId, name, price, imageByte);
            if (!updateSuccesful) MessageBox.Show("An error occured while updating item");

            itemContainer.Controls.Remove(itemToUpdate);
            itemToUpdate.Dispose();

            AddNewItem(itemId, name, price, image);
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

        private void backButtonIcon_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }
    }
}
