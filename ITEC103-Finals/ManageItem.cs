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

            Panel item = new Panel();
            item.Size = new Size(panelSize, panelSize);
            item.BorderStyle = BorderStyle.FixedSingle;
            item.Name = "item";
            item.BackColor = Color.White;
            item.Tag = new ItemEmbeddedData { id = _id };

            PictureBox image = new PictureBox();
            image.Location = new Point(2, 2);
            image.Width = imageWidth;
            image.Height = imageHeight;
            image.Name = "itemImage";
            image.Image = itemImage;
            image.SizeMode = PictureBoxSizeMode.Zoom;
            image.TabIndex = 0;
            image.TabStop = false;
            image.BackColor = Color.White;

            Label itemName = new Label();
            itemName.AutoSize = true;
            itemName.BackColor = Color.Transparent;
            itemName.Dock = DockStyle.Bottom;
            itemName.ForeColor = Color.Black;
            itemName.Location = new Point(0, 0);
            itemName.MaximumSize = new Size(100, 0);
            itemName.MinimumSize = new Size(100, 0);
            itemName.Name = "item1Name";
            itemName.Size = new Size(100, 15);
            itemName.TabIndex = 1;
            itemName.Text = name;
            itemName.TextAlign = ContentAlignment.MiddleCenter;

            Label itemPrice = new Label();
            itemPrice.AutoSize = true;
            itemPrice.Location = new Point(0, 0);
            itemPrice.Size = new Size(26, 15);
            itemPrice.Text = "P" + Convert.ToString(price);
            itemPrice.Name = "itemPrice";
            itemPrice.Dock = DockStyle.Top;

            item.Controls.Add(itemPrice);
            item.Controls.Add(itemName);
            item.Controls.Add(image);
            itemContainer.Controls.Add(item);
            //image.Click += AddItemToCart_Click;
        }

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
