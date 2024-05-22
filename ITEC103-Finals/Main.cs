using System.Data;

namespace ITEC103_Finals
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            DataTable allItems = DatabaseHandler.LoadItemsFromDatabase();
            foreach (DataRow row in allItems.Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string itemName = Convert.ToString(row["itemName"]);
                int itemPrice = Convert.ToInt32(row["itemPrice"]);
                byte[] itemImageByteData = (byte[])row["itemImage"];
                Image itemImage = ImageProccessor.ConvertByteArrayToImage(itemImageByteData);

                //Add the item to the display
                AddNewItem(id, itemName, itemPrice, itemImage);
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
            image.Click += AddItemToCart_Click;
        }

        private void AddItemToCart_Click(object sender, EventArgs e)
        {
            Control item = sender as Control;
            Control parent = item.Parent;
            Control itemName = parent.Controls["itemName"];
            Control itemPrice = parent.Controls["itemPrice"];
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            ManageItem manageItemForm = new ManageItem();
            manageItemForm.Show();
            this.Hide();
        }
    }
}
