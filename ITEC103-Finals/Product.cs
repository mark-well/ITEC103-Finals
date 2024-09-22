using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MicroPOS
{
    public class Product
    {
        public int id;
        public string name;
        public float price;
        public string category;
        public Image itemImage;
        public FlowLayoutPanel itemContainer;

        // UI
        public Panel UIitem = new Panel();
        public PictureBox UIimage = new PictureBox();
        public Label UIitemName = new Label();
        public Label UIitemPrice = new Label();

        public Product(FlowLayoutPanel itemContainer, int id, string name, float price, string category, Image image) { 
            this.itemContainer = itemContainer;
            this.id = id;
            this.name = name;
            this.price = price;
            this.category = category;
            this.itemImage = image;
        }

        public virtual void Display()
        {
            int panelSize = 100;
            int imageWidth = 95;
            int imageHeight = 80;

            UIitem.Size = new Size(panelSize, panelSize);
            UIitem.BorderStyle = BorderStyle.FixedSingle;
            UIitem.Name = id.ToString();
            UIitem.BackColor = Color.WhiteSmoke;
            UIitem.Tag = new ItemEmbeddedData { id = this.id };

            UIimage.Location = new Point(2, 2);
            UIimage.Width = imageWidth;
            UIimage.Height = imageHeight;
            UIimage.Name = "itemImage";
            UIimage.Image = itemImage;
            UIimage.SizeMode = PictureBoxSizeMode.Zoom;
            UIimage.TabIndex = 0;
            UIimage.TabStop = false;
            UIimage.BackColor = Color.Transparent;

            UIitemName.AutoSize = true;
            UIitemName.BackColor = Color.Transparent;
            UIitemName.Dock = DockStyle.Bottom;
            UIitemName.ForeColor = Color.Black;
            UIitemName.Location = new Point(0, 0);
            UIitemName.MaximumSize = new Size(100, 0);
            UIitemName.MinimumSize = new Size(100, 0);
            UIitemName.Name = "itemName";
            UIitemName.Size = new Size(100, 15);
            UIitemName.TabIndex = 1;
            UIitemName.Text = name;
            UIitemName.TextAlign = ContentAlignment.MiddleCenter;

            UIitemPrice.AutoSize = true;
            UIitemPrice.Location = new Point(0, 0);
            UIitemPrice.Size = new Size(26, 15);
            UIitemPrice.Text = "P" + Convert.ToString(price);
            UIitemPrice.Name = "itemPrice";
            UIitemPrice.Dock = DockStyle.Top;

            UIitem.Controls.Add(UIitemPrice);
            UIitem.Controls.Add(UIitemName);
            UIitem.Controls.Add(UIimage);
            itemContainer.Controls.Add(UIitem);
        }
    }
}
