using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZstdSharp.Unsafe;

namespace MicroPOS
{
    public class EditableProduct : Product
    {
        
        // UI
        public Button UIdeleteItemButton = new Button();
        public Button UIeditItemButton = new Button();
        public Label UIline = new Label();

        public EditableProduct(FlowLayoutPanel itemContainer, int id, string name, float price, string category, Image image) : base(itemContainer, id, name, price, category, image)
        {
            this.itemContainer = itemContainer;
            this.id = id;
            this.name = name;
            this.price = price;
            this.itemImage = image;
        }

        public override void Display()
        {
            UIdeleteItemButton.Font = new Font("Arial Narrow", 8.25F);
            UIdeleteItemButton.Location = new Point(52, 105);
            UIdeleteItemButton.Name = "deleteItemButton";
            UIdeleteItemButton.Size = new Size(43, 25);
            UIdeleteItemButton.TabIndex = 5;
            UIdeleteItemButton.Text = "Delete";
            UIdeleteItemButton.UseVisualStyleBackColor = true;
            UIdeleteItemButton.BackColor = Color.FromArgb(255, 128, 128);
            
            UIeditItemButton.Font = new Font("Arial Narrow", 8.25F);
            UIeditItemButton.Location = new Point(4, 105);
            UIeditItemButton.Name = "editItemButton";
            UIeditItemButton.Size = new Size(42, 25);
            UIeditItemButton.TabIndex = 4;
            UIeditItemButton.Text = "Edit";
            UIeditItemButton.UseVisualStyleBackColor = true;
            UIeditItemButton.BackColor = Color.FromArgb(59, 140, 247);
            
            UIline.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UIline.BackColor = Color.Black;
            UIline.BorderStyle = BorderStyle.Fixed3D;
            UIline.Location = new Point(4, 98);
            UIline.Name = "line";
            UIline.Size = new Size(93, 2);
            UIline.TabIndex = 3;

            UIitemName.AutoSize = true;
            UIitemName.BackColor = Color.Transparent;
            UIitemName.ForeColor = Color.Black;
            UIitemName.Location = new Point(0, 68);
            UIitemName.MaximumSize = new Size(100, 0);
            UIitemName.MinimumSize = new Size(100, 0);
            UIitemName.Name = "itemName";
            UIitemName.Size = new Size(100, 30);
            UIitemName.TabIndex = 1;
            UIitemName.Text = name;
            UIitemName.TextAlign = ContentAlignment.MiddleCenter;
            
            UIitemPrice.AutoSize = true;
            UIitemPrice.Dock = DockStyle.Top;
            UIitemPrice.Location = new Point(0, 0);
            UIitemPrice.Name = "itemPrice";
            UIitemPrice.Size = new Size(26, 15);
            UIitemPrice.TabIndex = 2;
            UIitemPrice.Text = "P" + price.ToString();
            
            UIimage.BackColor = Color.Transparent;
            UIimage.BackgroundImageLayout = ImageLayout.Center;
            UIimage.Image = itemImage;
            UIimage.Location = new Point(2, 2);
            UIimage.Name = "itemImage";
            UIimage.Size = new Size(95, 80);
            UIimage.SizeMode = PictureBoxSizeMode.Zoom;
            UIimage.TabIndex = 0;
            UIimage.TabStop = false;
            
            UIitem.BorderStyle = BorderStyle.FixedSingle;
            UIitem.BackColor = Color.White;
            UIitem.Controls.Add(UIdeleteItemButton);
            UIitem.Controls.Add(UIeditItemButton);
            UIitem.Controls.Add(UIitemName);
            UIitem.Controls.Add(UIitemPrice);
            UIitem.Controls.Add(UIimage);
            UIitem.Location = new Point(3, 3);
            UIitem.Name = "item";
            UIitem.Size = new Size(100, 135);
            UIitem.TabIndex = 1;
            UIitem.Tag = new ItemEmbeddedData { id = id, category = this.category };
            UIitem.Controls.Add(UIline);
            itemContainer.Controls.Add(UIitem);
        }
    }
}
