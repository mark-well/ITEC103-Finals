namespace MicroPOS
{
    partial class ManageItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageItem));
            panel1 = new Panel();
            backButtonIcon = new PictureBox();
            label = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            addItemToInventoryButton = new Button();
            updateItemInfo = new Button();
            itemImage = new PictureBox();
            selectImageButton = new Button();
            itemNameInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            itemPriceInput = new TextBox();
            itemContainer = new FlowLayoutPanel();
            item1 = new Panel();
            deleteItemButton = new Button();
            editItemButton = new Button();
            line = new Label();
            item1Name = new Label();
            itemPrice = new Label();
            item1Image = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemImage).BeginInit();
            itemContainer.SuspendLayout();
            item1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)item1Image).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 107, 241);
            panel1.Controls.Add(backButtonIcon);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 2;
            // 
            // backButtonIcon
            // 
            backButtonIcon.Image = Properties.Resources.left_chevron;
            backButtonIcon.Location = new Point(22, 9);
            backButtonIcon.Name = "backButtonIcon";
            backButtonIcon.Size = new Size(30, 30);
            backButtonIcon.SizeMode = PictureBoxSizeMode.Zoom;
            backButtonIcon.TabIndex = 1;
            backButtonIcon.TabStop = false;
            backButtonIcon.Click += backButtonIcon_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(58, 12);
            label.Name = "label";
            label.Size = new Size(128, 22);
            label.TabIndex = 0;
            label.Text = "Manage Item";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 45);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(panel2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.White;
            splitContainer1.Panel2.Controls.Add(itemContainer);
            splitContainer1.Size = new Size(800, 405);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(addItemToInventoryButton);
            panel2.Controls.Add(updateItemInfo);
            panel2.Controls.Add(itemImage);
            panel2.Controls.Add(selectImageButton);
            panel2.Controls.Add(itemNameInput);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(itemPriceInput);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(266, 405);
            panel2.TabIndex = 0;
            // 
            // addItemToInventoryButton
            // 
            addItemToInventoryButton.BackColor = Color.FromArgb(59, 140, 247);
            addItemToInventoryButton.BackgroundImageLayout = ImageLayout.None;
            addItemToInventoryButton.FlatStyle = FlatStyle.Flat;
            addItemToInventoryButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemToInventoryButton.ForeColor = Color.Black;
            addItemToInventoryButton.Location = new Point(36, 354);
            addItemToInventoryButton.Name = "addItemToInventoryButton";
            addItemToInventoryButton.Size = new Size(202, 38);
            addItemToInventoryButton.TabIndex = 6;
            addItemToInventoryButton.Text = "ADD ITEM";
            addItemToInventoryButton.UseVisualStyleBackColor = false;
            addItemToInventoryButton.Click += addItemToInventoryButton_Click;
            // 
            // updateItemInfo
            // 
            updateItemInfo.BackColor = Color.FromArgb(3, 174, 210);
            updateItemInfo.BackgroundImageLayout = ImageLayout.None;
            updateItemInfo.FlatStyle = FlatStyle.Flat;
            updateItemInfo.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateItemInfo.ForeColor = Color.Black;
            updateItemInfo.Location = new Point(36, 354);
            updateItemInfo.Name = "updateItemInfo";
            updateItemInfo.Size = new Size(202, 38);
            updateItemInfo.TabIndex = 7;
            updateItemInfo.Text = "UPDATE";
            updateItemInfo.UseVisualStyleBackColor = false;
            updateItemInfo.Visible = false;
            updateItemInfo.Click += updateItemInfo_Click;
            // 
            // itemImage
            // 
            itemImage.BackgroundImageLayout = ImageLayout.None;
            itemImage.BorderStyle = BorderStyle.FixedSingle;
            itemImage.Location = new Point(58, 6);
            itemImage.Name = "itemImage";
            itemImage.Size = new Size(150, 150);
            itemImage.SizeMode = PictureBoxSizeMode.Zoom;
            itemImage.TabIndex = 0;
            itemImage.TabStop = false;
            // 
            // selectImageButton
            // 
            selectImageButton.BackColor = SystemColors.Control;
            selectImageButton.BackgroundImageLayout = ImageLayout.None;
            selectImageButton.FlatStyle = FlatStyle.Flat;
            selectImageButton.Font = new Font("Arial Narrow", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectImageButton.ForeColor = Color.Black;
            selectImageButton.Location = new Point(72, 252);
            selectImageButton.Name = "selectImageButton";
            selectImageButton.Size = new Size(121, 32);
            selectImageButton.TabIndex = 5;
            selectImageButton.Text = "Select Image";
            selectImageButton.UseVisualStyleBackColor = false;
            selectImageButton.Click += selectImageButton_Click;
            // 
            // itemNameInput
            // 
            itemNameInput.BorderStyle = BorderStyle.FixedSingle;
            itemNameInput.Location = new Point(58, 162);
            itemNameInput.Name = "itemNameInput";
            itemNameInput.Size = new Size(150, 23);
            itemNameInput.TabIndex = 1;
            itemNameInput.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 234);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 4;
            label2.Text = "Item Price";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 188);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 2;
            label1.Text = "Item Name";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemPriceInput
            // 
            itemPriceInput.BorderStyle = BorderStyle.FixedSingle;
            itemPriceInput.Location = new Point(58, 208);
            itemPriceInput.Name = "itemPriceInput";
            itemPriceInput.Size = new Size(150, 23);
            itemPriceInput.TabIndex = 3;
            itemPriceInput.TextAlign = HorizontalAlignment.Center;
            // 
            // itemContainer
            // 
            itemContainer.Controls.Add(item1);
            itemContainer.Dock = DockStyle.Fill;
            itemContainer.Location = new Point(0, 0);
            itemContainer.Name = "itemContainer";
            itemContainer.Size = new Size(530, 405);
            itemContainer.TabIndex = 0;
            // 
            // item1
            // 
            item1.BorderStyle = BorderStyle.FixedSingle;
            item1.Controls.Add(deleteItemButton);
            item1.Controls.Add(editItemButton);
            item1.Controls.Add(line);
            item1.Controls.Add(item1Name);
            item1.Controls.Add(itemPrice);
            item1.Controls.Add(item1Image);
            item1.Location = new Point(3, 3);
            item1.Name = "item1";
            item1.Size = new Size(100, 135);
            item1.TabIndex = 1;
            item1.Visible = false;
            // 
            // deleteItemButton
            // 
            deleteItemButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteItemButton.Font = new Font("Arial Narrow", 8.25F);
            deleteItemButton.Location = new Point(52, 105);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(43, 25);
            deleteItemButton.TabIndex = 5;
            deleteItemButton.Text = "Delete";
            deleteItemButton.UseVisualStyleBackColor = false;
            // 
            // editItemButton
            // 
            editItemButton.BackColor = Color.FromArgb(59, 140, 247);
            editItemButton.Font = new Font("Arial Narrow", 8.25F);
            editItemButton.Location = new Point(4, 105);
            editItemButton.Name = "editItemButton";
            editItemButton.Size = new Size(42, 25);
            editItemButton.TabIndex = 4;
            editItemButton.Text = "Edit";
            editItemButton.UseVisualStyleBackColor = false;
            // 
            // line
            // 
            line.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            line.BackColor = Color.Black;
            line.BorderStyle = BorderStyle.Fixed3D;
            line.Location = new Point(4, 98);
            line.Name = "line";
            line.Size = new Size(93, 2);
            line.TabIndex = 3;
            // 
            // item1Name
            // 
            item1Name.AutoSize = true;
            item1Name.BackColor = Color.Transparent;
            item1Name.ForeColor = Color.Black;
            item1Name.Location = new Point(0, 68);
            item1Name.MaximumSize = new Size(100, 0);
            item1Name.MinimumSize = new Size(100, 0);
            item1Name.Name = "item1Name";
            item1Name.Size = new Size(100, 30);
            item1Name.TabIndex = 1;
            item1Name.Text = "Caramel Machiato L";
            item1Name.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemPrice
            // 
            itemPrice.AutoSize = true;
            itemPrice.Dock = DockStyle.Top;
            itemPrice.Location = new Point(0, 0);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(26, 15);
            itemPrice.TabIndex = 2;
            itemPrice.Text = "P20";
            // 
            // item1Image
            // 
            item1Image.BackColor = Color.Transparent;
            item1Image.BackgroundImageLayout = ImageLayout.Center;
            item1Image.Image = (Image)resources.GetObject("item1Image.Image");
            item1Image.Location = new Point(2, 2);
            item1Image.Name = "item1Image";
            item1Image.Size = new Size(95, 80);
            item1Image.SizeMode = PictureBoxSizeMode.Zoom;
            item1Image.TabIndex = 0;
            item1Image.TabStop = false;
            // 
            // ManageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ManageItem";
            Text = "ManageItem";
            Load += ManageItem_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonIcon).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemImage).EndInit();
            itemContainer.ResumeLayout(false);
            item1.ResumeLayout(false);
            item1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)item1Image).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox backButtonIcon;
        private Label label;
        private SplitContainer splitContainer1;
        private PictureBox itemImage;
        private Button selectImageButton;
        private Label label2;
        private TextBox itemPriceInput;
        private Label label1;
        private TextBox itemNameInput;
        private Button addItemToInventoryButton;
        private Panel panel2;
        private FlowLayoutPanel itemContainer;
        private Panel item1;
        private Label item1Name;
        private Label itemPrice;
        private PictureBox item1Image;
        private Label line;
        private Button updateItemInfo;
        private Button button1;
        private Button deleteItemButton;
        private Button editItemButton;
    }
}