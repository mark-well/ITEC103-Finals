namespace ITEC103_Finals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            panel1 = new Panel();
            menuButton = new PictureBox();
            appName = new Label();
            itemContainer = new FlowLayoutPanel();
            item1 = new Panel();
            item1Name = new Label();
            itemPrice = new Label();
            item1Image = new PictureBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            panel2 = new Panel();
            cartDisplay = new FlowLayoutPanel();
            cartItem = new Panel();
            dicreaseQuantity = new PictureBox();
            increaseQuantity = new PictureBox();
            quantity = new Label();
            itemName = new Label();
            chargeButton = new Button();
            line = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)menuButton).BeginInit();
            itemContainer.SuspendLayout();
            item1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)item1Image).BeginInit();
            panel2.SuspendLayout();
            cartDisplay.SuspendLayout();
            cartItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dicreaseQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)increaseQuantity).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 174, 210);
            panel1.Controls.Add(menuButton);
            panel1.Controls.Add(appName);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 45);
            panel1.TabIndex = 0;
            // 
            // menuButton
            // 
            menuButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            menuButton.Image = Properties.Resources.hamburger_menu;
            menuButton.Location = new Point(725, 0);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(45, 45);
            menuButton.SizeMode = PictureBoxSizeMode.Zoom;
            menuButton.TabIndex = 1;
            menuButton.TabStop = false;
            // 
            // appName
            // 
            appName.AutoSize = true;
            appName.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            appName.ForeColor = Color.White;
            appName.Location = new Point(27, 12);
            appName.Name = "appName";
            appName.Size = new Size(124, 22);
            appName.TabIndex = 0;
            appName.Text = "Point of Sale";
            // 
            // itemContainer
            // 
            itemContainer.AutoScroll = true;
            itemContainer.BackColor = Color.FromArgb(223, 223, 223);
            itemContainer.BorderStyle = BorderStyle.FixedSingle;
            itemContainer.Controls.Add(item1);
            itemContainer.Dock = DockStyle.Fill;
            itemContainer.Location = new Point(0, 45);
            itemContainer.Name = "itemContainer";
            itemContainer.Size = new Size(570, 396);
            itemContainer.TabIndex = 2;
            // 
            // item1
            // 
            item1.BorderStyle = BorderStyle.FixedSingle;
            item1.Controls.Add(item1Name);
            item1.Controls.Add(itemPrice);
            item1.Controls.Add(item1Image);
            item1.Location = new Point(3, 3);
            item1.Name = "item1";
            item1.Size = new Size(100, 100);
            item1.TabIndex = 0;
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
            item1Image.BackgroundImageLayout = ImageLayout.Center;
            item1Image.Image = (Image)resources.GetObject("item1Image.Image");
            item1Image.Location = new Point(2, 2);
            item1Image.Name = "item1Image";
            item1Image.Size = new Size(95, 80);
            item1Image.SizeMode = PictureBoxSizeMode.StretchImage;
            item1Image.TabIndex = 0;
            item1Image.TabStop = false;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 139, 168);
            panel2.Controls.Add(cartDisplay);
            panel2.Controls.Add(chargeButton);
            panel2.Controls.Add(line);
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
            cartDisplay.Controls.Add(cartItem);
            cartDisplay.FlowDirection = FlowDirection.TopDown;
            cartDisplay.Location = new Point(0, 24);
            cartDisplay.Name = "cartDisplay";
            cartDisplay.Size = new Size(200, 311);
            cartDisplay.TabIndex = 4;
            cartDisplay.WrapContents = false;
            // 
            // cartItem
            // 
            cartItem.BackColor = Color.FromArgb(3, 174, 210);
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
            increaseQuantity.Location = new Point(162, 16);
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
            quantity.ForeColor = Color.White;
            quantity.Location = new Point(130, 10);
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
            itemName.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemName.ForeColor = Color.White;
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
            chargeButton.BackColor = Color.FromArgb(3, 174, 210);
            chargeButton.BackgroundImageLayout = ImageLayout.None;
            chargeButton.FlatAppearance.BorderSize = 0;
            chargeButton.FlatStyle = FlatStyle.Flat;
            chargeButton.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chargeButton.ForeColor = Color.White;
            chargeButton.Location = new Point(6, 354);
            chargeButton.Name = "chargeButton";
            chargeButton.Size = new Size(190, 30);
            chargeButton.TabIndex = 2;
            chargeButton.Text = "CHARGE";
            chargeButton.UseVisualStyleBackColor = false;
            // 
            // line
            // 
            line.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            line.BorderStyle = BorderStyle.Fixed3D;
            line.Location = new Point(0, 338);
            line.Name = "line";
            line.Size = new Size(200, 2);
            line.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.MaximumSize = new Size(200, 0);
            label1.MinimumSize = new Size(200, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 24);
            label1.TabIndex = 0;
            label1.Text = "ORDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(770, 441);
            Controls.Add(itemContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Main";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel2;
        private Label label1;
        private Label line;
        private Button chargeButton;
        private FlowLayoutPanel cartDisplay;
        private Panel cartItem;
        private Label itemName;
        private Label quantity;
        private PictureBox increaseQuantity;
        private PictureBox dicreaseQuantity;
        private PictureBox menuButton;
    }
}
