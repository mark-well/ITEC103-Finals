using ITEC103_Finals.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC103_Finals
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
            int panelSize = 100;
            int imageWidth = 95;
            int imageHeight = 80;

            PictureBox deleteItemButton = new PictureBox();
            deleteItemButton.Image = Properties.Resources.delete;
            deleteItemButton.Location = new Point(63, 109);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(20, 20);
            deleteItemButton.SizeMode = PictureBoxSizeMode.Zoom;
            deleteItemButton.TabIndex = 5;
            deleteItemButton.Click += DeleteItem;

            PictureBox editItemButton = new PictureBox();
            editItemButton.Image = Properties.Resources.pen;
            editItemButton.Location = new Point(15, 109);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(20, 20);
            editItemButton.SizeMode = PictureBoxSizeMode.Zoom;
            editItemButton.TabIndex = 4;
            editItemButton.TabStop = false;
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
            itemPrice.Name = price.ToString();
            itemPrice.Size = new Size(26, 15);
            itemPrice.TabIndex = 2;
            itemPrice.Text = price.ToString();

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
            int itemPrice = Convert.ToInt32(itemPriceInput.Text);
            Image itemImageIn = itemImage.Image;
            byte[] compressedImage = ImageProccessor.ConvertImageToByteArray(itemImageIn);

            //Add new item to database
            DatabaseHandler.AddNewItemToInventory(id, itemName, itemPrice, compressedImage);
            AddNewItem(id, itemName, itemPrice,itemImageIn);
            itemNameInput.Text = "";
            itemPriceInput.Text = "";
            itemImage.Image = null;
            MessageBox.Show("Succesfully Added New Item");
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
            int itemId = ItemHandler.GetItemId(sender);
            bool isDeletionSuccessful = DatabaseHandler.DeleteItemFromInventory(itemId);
            if (isDeletionSuccessful)
            {
                Control deleteButton = sender as Control;
                Control item = deleteButton.Parent;
                itemContainer.Controls.Remove(item);
                MessageBox.Show("Item Seccesfully Deleted");
            } else
            {
                MessageBox.Show("Item failed to delete!");
            }
        }

        //Edit the item's information
        public void EditItem(object sender, EventArgs e)
        {

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
