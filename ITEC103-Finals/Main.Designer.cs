namespace MicroPOS
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            categorySearchBar = new ComboBox();
            searchIcon = new PictureBox();
            searchBar = new TextBox();
            menuButton = new PictureBox();
            appName = new Label();
            itemContainer = new FlowLayoutPanel();
            item1 = new Panel();
            item1Name = new Label();
            itemPrice = new Label();
            item1Image = new PictureBox();
            panel2 = new Panel();
            cartDisplay = new FlowLayoutPanel();
            cartItem = new Panel();
            removeCartFromItemButton = new PictureBox();
            dicreaseQuantity = new PictureBox();
            increaseQuantity = new PictureBox();
            quantity = new Label();
            itemName = new Label();
            chargeButton = new Button();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            itemContainer.SuspendLayout();
            item1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)item1Image).BeginInit();
            panel2.SuspendLayout();
            cartDisplay.SuspendLayout();
            cartItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)removeCartFromItemButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dicreaseQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)increaseQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 107, 241);
            panel1.Controls.Add(categorySearchBar);
            panel1.Controls.Add(searchIcon);
            panel1.Controls.Add(searchBar);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(appName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 45);
            panel1.TabIndex = 0;
            // 
            // categorySearchBar
            // 
            categorySearchBar.BackColor = Color.White;
            categorySearchBar.DropDownStyle = ComboBoxStyle.DropDownList;
            categorySearchBar.ForeColor = Color.Black;
            categorySearchBar.FormattingEnabled = true;
            categorySearchBar.Items.AddRange(new object[] { "all" });
            categorySearchBar.Location = new Point(579, 12);
            categorySearchBar.Name = "categorySearchBar";
            categorySearchBar.Size = new Size(115, 23);
            categorySearchBar.TabIndex = 5;
            categorySearchBar.SelectedIndexChanged += categorySearchBar_SelectedIndexChanged;
            // 
            // searchIcon
            // 
            searchIcon.Image = Properties.Resources.search_icon;
            searchIcon.Location = new Point(367, 12);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(20, 20);
            searchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            searchIcon.TabIndex = 4;
            searchIcon.TabStop = false;
            // 
            // searchBar
            // 
            searchBar.BackColor = Color.SkyBlue;
            searchBar.BorderStyle = BorderStyle.None;
            searchBar.CausesValidation = false;
            searchBar.Cursor = Cursors.IBeam;
            searchBar.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBar.ForeColor = Color.Black;
            searchBar.Location = new Point(393, 13);
            searchBar.MaximumSize = new Size(180, 20);
            searchBar.MinimumSize = new Size(180, 20);
            searchBar.Name = "searchBar";
            searchBar.PlaceholderText = "SEARCH";
            searchBar.Size = new Size(180, 20);
            searchBar.TabIndex = 3;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // menuButton
            // 
            menuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuButton.Cursor = Cursors.Hand;
            menuButton.Image = Properties.Resources.hamburger_menu;
            menuButton.Location = new Point(725, 0);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(45, 45);
            menuButton.SizeMode = PictureBoxSizeMode.Zoom;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            menuButton.Click += menuButton_Click;
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.Font = new Font("Arial Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(12, 9);
            appName.Name = "appName";
            appName.Size = new Size(114, 27);
            appName.TabIndex = 0;
            appName.Text = "MicroPOS";
            // 
            // itemContainer
            // 
            itemContainer.AutoScroll = true;
            itemContainer.BackColor = Color.White;
            itemContainer.Controls.Add(item1);
            itemContainer.Dock = DockStyle.Fill;
            itemContainer.Location = new Point(0, 45);
            itemContainer.Name = "itemContainer";
            itemContainer.Size = new Size(570, 396);
            itemContainer.TabIndex = 2;
            // 
            // item1
            // 
            item1.BackColor = Color.WhiteSmoke;
            item1.BorderStyle = BorderStyle.FixedSingle;
            item1.Controls.Add(item1Name);
            item1.Controls.Add(itemPrice);
            item1.Controls.Add(item1Image);
            item1.Location = new Point(3, 3);
            item1.Name = "item1";
            item1.Size = new Size(100, 100);
            item1.TabIndex = 0;
            item1.Visible = false;
            // 
            // item1Name
            // 
            item1Name.AutoSize = true;
            item1Name.BackColor = Color.Transparent;
            item1Name.Dock = DockStyle.Bottom;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(4, 89, 201);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(cartDisplay);
            panel2.Controls.Add(chargeButton);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(570, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 396);
            panel2.TabIndex = 3;
            // 
            // cartDisplay
            // 
            cartDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cartDisplay.AutoScroll = true;
            cartDisplay.BackColor = Color.White;
            cartDisplay.Controls.Add(cartItem);
            cartDisplay.FlowDirection = FlowDirection.TopDown;
            cartDisplay.Location = new Point(-2, 36);
            cartDisplay.Name = "cartDisplay";
            cartDisplay.Size = new Size(200, 312);
            cartDisplay.TabIndex = 4;
            cartDisplay.WrapContents = false;
            // 
            // cartItem
            // 
            cartItem.BackColor = Color.White;
            cartItem.Controls.Add(removeCartFromItemButton);
            cartItem.Controls.Add(dicreaseQuantity);
            cartItem.Controls.Add(increaseQuantity);
            cartItem.Controls.Add(quantity);
            cartItem.Controls.Add(itemName);
            cartItem.ForeColor = Color.White;
            cartItem.Location = new Point(0, 0);
            cartItem.Margin = new Padding(0);
            cartItem.Name = "cartItem";
            cartItem.Size = new Size(200, 50);
            cartItem.TabIndex = 0;
            cartItem.Visible = false;
            // 
            // removeCartFromItemButton
            // 
            removeCartFromItemButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeCartFromItemButton.Image = Properties.Resources.delete;
            removeCartFromItemButton.Location = new Point(177, 16);
            removeCartFromItemButton.Name = "removeCartFromItemButton";
            removeCartFromItemButton.Size = new Size(20, 20);
            removeCartFromItemButton.SizeMode = PictureBoxSizeMode.Zoom;
            removeCartFromItemButton.TabIndex = 4;
            removeCartFromItemButton.TabStop = false;
            // 
            // dicreaseQuantity
            // 
            dicreaseQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dicreaseQuantity.Image = Properties.Resources.minus;
            dicreaseQuantity.Location = new Point(98, 16);
            dicreaseQuantity.Name = "dicreaseQuantity";
            dicreaseQuantity.Size = new Size(20, 20);
            dicreaseQuantity.SizeMode = PictureBoxSizeMode.Zoom;
            dicreaseQuantity.TabIndex = 3;
            dicreaseQuantity.TabStop = false;
            // 
            // increaseQuantity
            // 
            increaseQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            increaseQuantity.Image = Properties.Resources.plus;
            increaseQuantity.Location = new Point(144, 16);
            increaseQuantity.Name = "increaseQuantity";
            increaseQuantity.Size = new Size(20, 20);
            increaseQuantity.SizeMode = PictureBoxSizeMode.Zoom;
            increaseQuantity.TabIndex = 2;
            increaseQuantity.TabStop = false;
            // 
            // quantity
            // 
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
            quantity.Text = "1";
            quantity.TextAlign = ContentAlignment.MiddleCenter;
            quantity.UseMnemonic = false;
            // 
            // itemName
            // 
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
            itemName.Text = "Coca Cola";
            itemName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chargeButton
            // 
            chargeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chargeButton.BackColor = Color.FromArgb(59, 140, 247);
            chargeButton.BackgroundImageLayout = ImageLayout.None;
            chargeButton.FlatAppearance.BorderSize = 0;
            chargeButton.FlatStyle = FlatStyle.Flat;
            chargeButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chargeButton.ForeColor = Color.White;
            chargeButton.Location = new Point(6, 352);
            chargeButton.Name = "chargeButton";
            chargeButton.Size = new Size(188, 30);
            chargeButton.TabIndex = 2;
            chargeButton.Text = "CHARGE";
            chargeButton.UseVisualStyleBackColor = false;
            chargeButton.Click += chargeButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(4, 89, 201);
            label1.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 7);
            label1.MaximumSize = new Size(200, 0);
            label1.MinimumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 24);
            label1.TabIndex = 0;
            label1.Text = "ORDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Main
            // 
            BackColor = Color.White;
            ClientSize = new Size(770, 441);
            Controls.Add(itemContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)menuButton).EndInit();
            itemContainer.ResumeLayout(false);
            item1.ResumeLayout(false);
            item1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)item1Image).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            cartDisplay.ResumeLayout(false);
            cartItem.ResumeLayout(false);
            cartItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)removeCartFromItemButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)dicreaseQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)increaseQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label appName;
        public FlowLayoutPanel itemContainer;
        private Panel item1;
        private Label item1Name;
        private PictureBox item1Image;
        private Label itemPrice;
        private Panel panel2;
        private Label label1;
        private Button chargeButton;
        private FlowLayoutPanel cartDisplay;
        private Panel cartItem;
        private Label itemName;
        private Label quantity;
        private PictureBox increaseQuantity;
        private PictureBox dicreaseQuantity;
        private PictureBox menuButton;
        private PictureBox removeCartFromItemButton;
        private TextBox searchBar;
        private ContextMenuStrip contextMenuStrip1;
        private PictureBox searchIcon;
        private ComboBox categorySearchBar;
    }
}
