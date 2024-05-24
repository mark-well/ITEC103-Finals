namespace ITEC103_Finals
{
    partial class Charge_Page
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
            panel1 = new Panel();
            backButtonIcon = new PictureBox();
            label = new Label();
            panel2 = new Panel();
            label1 = new Label();
            orderDisplay = new FlowLayoutPanel();
            cartItem = new Panel();
            price = new Label();
            quantity = new Label();
            itemName = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            subTotal = new Label();
            label6 = new Label();
            cashInput = new TextBox();
            preCash500 = new Button();
            preCash300 = new Button();
            preCash1000 = new Button();
            chargeButton = new Button();
            newSaleButton = new Button();
            printReceiptButton = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonIcon).BeginInit();
            panel2.SuspendLayout();
            orderDisplay.SuspendLayout();
            cartItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)printReceiptButton).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(3, 174, 210);
            panel1.Controls.Add(backButtonIcon);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 1;
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
            label.Size = new Size(77, 22);
            label.TabIndex = 0;
            label.Text = "Charge";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(2, 139, 168);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(orderDisplay);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 405);
            panel2.TabIndex = 2;
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
            label1.TabIndex = 6;
            label1.Text = "ORDER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderDisplay
            // 
            orderDisplay.AutoScroll = true;
            orderDisplay.Controls.Add(cartItem);
            orderDisplay.FlowDirection = FlowDirection.TopDown;
            orderDisplay.Location = new Point(0, 64);
            orderDisplay.Name = "orderDisplay";
            orderDisplay.Size = new Size(200, 329);
            orderDisplay.TabIndex = 5;
            orderDisplay.WrapContents = false;
            // 
            // cartItem
            // 
            cartItem.BackColor = Color.FromArgb(3, 174, 210);
            cartItem.Controls.Add(price);
            cartItem.Controls.Add(quantity);
            cartItem.Controls.Add(itemName);
            cartItem.ForeColor = Color.White;
            cartItem.Location = new Point(0, 0);
            cartItem.Margin = new Padding(0);
            cartItem.Name = "cartItem";
            cartItem.Size = new Size(200, 50);
            cartItem.TabIndex = 0;
            // 
            // price
            // 
            price.AutoSize = true;
            price.BackColor = Color.Transparent;
            price.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.ForeColor = Color.White;
            price.Location = new Point(157, 11);
            price.MaximumSize = new Size(30, 100);
            price.MinimumSize = new Size(35, 30);
            price.Name = "price";
            price.RightToLeft = RightToLeft.No;
            price.Size = new Size(35, 30);
            price.TabIndex = 2;
            price.Text = "P20";
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.UseMnemonic = false;
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.BackColor = Color.Transparent;
            quantity.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.ForeColor = Color.White;
            quantity.Location = new Point(101, 11);
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(157, 45);
            label4.Name = "label4";
            label4.Size = new Size(40, 16);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(98, 45);
            label3.Name = "label3";
            label3.Size = new Size(31, 16);
            label3.TabIndex = 2;
            label3.Text = "Qty.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(406, 141);
            label5.Name = "label5";
            label5.Size = new Size(79, 18);
            label5.TabIndex = 3;
            label5.Text = "Sub Total:";
            // 
            // subTotal
            // 
            subTotal.AutoSize = true;
            subTotal.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotal.ForeColor = Color.Black;
            subTotal.Location = new Point(504, 142);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(55, 16);
            subTotal.TabIndex = 4;
            subTotal.Text = "P759.00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(406, 173);
            label6.Name = "label6";
            label6.Size = new Size(48, 18);
            label6.TabIndex = 5;
            label6.Text = "Cash:";
            // 
            // cashInput
            // 
            cashInput.BackColor = Color.White;
            cashInput.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cashInput.ForeColor = Color.Black;
            cashInput.Location = new Point(460, 168);
            cashInput.Name = "cashInput";
            cashInput.Size = new Size(180, 22);
            cashInput.TabIndex = 6;
            cashInput.TextAlign = HorizontalAlignment.Center;
            // 
            // preCash500
            // 
            preCash500.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            preCash500.BackColor = Color.FromArgb(2, 139, 168);
            preCash500.BackgroundImageLayout = ImageLayout.None;
            preCash500.FlatAppearance.BorderSize = 0;
            preCash500.FlatStyle = FlatStyle.Flat;
            preCash500.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preCash500.ForeColor = Color.White;
            preCash500.Location = new Point(504, 208);
            preCash500.Name = "preCash500";
            preCash500.Size = new Size(81, 24);
            preCash500.TabIndex = 7;
            preCash500.Text = "P500";
            preCash500.UseVisualStyleBackColor = false;
            preCash500.Click += preCash500_Click;
            // 
            // preCash300
            // 
            preCash300.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            preCash300.BackColor = Color.FromArgb(2, 139, 168);
            preCash300.BackgroundImageLayout = ImageLayout.None;
            preCash300.FlatAppearance.BorderSize = 0;
            preCash300.FlatStyle = FlatStyle.Flat;
            preCash300.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preCash300.ForeColor = Color.White;
            preCash300.Location = new Point(404, 208);
            preCash300.Name = "preCash300";
            preCash300.Size = new Size(81, 24);
            preCash300.TabIndex = 8;
            preCash300.Text = "P300";
            preCash300.UseVisualStyleBackColor = false;
            preCash300.Click += preCash300_Click;
            // 
            // preCash1000
            // 
            preCash1000.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            preCash1000.BackColor = Color.FromArgb(2, 139, 168);
            preCash1000.BackgroundImageLayout = ImageLayout.None;
            preCash1000.FlatAppearance.BorderSize = 0;
            preCash1000.FlatStyle = FlatStyle.Flat;
            preCash1000.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preCash1000.ForeColor = Color.White;
            preCash1000.Location = new Point(604, 208);
            preCash1000.Name = "preCash1000";
            preCash1000.Size = new Size(81, 24);
            preCash1000.TabIndex = 9;
            preCash1000.Text = "P1000";
            preCash1000.UseVisualStyleBackColor = false;
            preCash1000.Click += preCash1000_Click;
            // 
            // chargeButton
            // 
            chargeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chargeButton.BackColor = Color.FromArgb(3, 174, 210);
            chargeButton.BackgroundImageLayout = ImageLayout.None;
            chargeButton.FlatAppearance.BorderSize = 0;
            chargeButton.FlatStyle = FlatStyle.Flat;
            chargeButton.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chargeButton.ForeColor = Color.White;
            chargeButton.Location = new Point(482, 256);
            chargeButton.Name = "chargeButton";
            chargeButton.Size = new Size(117, 32);
            chargeButton.TabIndex = 10;
            chargeButton.Text = "CHARGE";
            chargeButton.UseVisualStyleBackColor = false;
            // 
            // newSaleButton
            // 
            newSaleButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            newSaleButton.BackColor = Color.FromArgb(3, 174, 210);
            newSaleButton.BackgroundImageLayout = ImageLayout.None;
            newSaleButton.FlatAppearance.BorderSize = 0;
            newSaleButton.FlatStyle = FlatStyle.Flat;
            newSaleButton.Font = new Font("Arial Narrow", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newSaleButton.ForeColor = Color.White;
            newSaleButton.Location = new Point(394, 406);
            newSaleButton.Name = "newSaleButton";
            newSaleButton.Size = new Size(246, 32);
            newSaleButton.TabIndex = 11;
            newSaleButton.Text = "New Sale";
            newSaleButton.UseVisualStyleBackColor = false;
            // 
            // printReceiptButton
            // 
            printReceiptButton.Image = Properties.Resources.printer_black;
            printReceiptButton.Location = new Point(758, 51);
            printReceiptButton.Name = "printReceiptButton";
            printReceiptButton.Size = new Size(30, 30);
            printReceiptButton.SizeMode = PictureBoxSizeMode.Zoom;
            printReceiptButton.TabIndex = 12;
            printReceiptButton.TabStop = false;
            // 
            // Charge_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(printReceiptButton);
            Controls.Add(newSaleButton);
            Controls.Add(chargeButton);
            Controls.Add(preCash1000);
            Controls.Add(preCash300);
            Controls.Add(preCash500);
            Controls.Add(cashInput);
            Controls.Add(label6);
            Controls.Add(subTotal);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Charge_Page";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonIcon).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            orderDisplay.ResumeLayout(false);
            cartItem.ResumeLayout(false);
            cartItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)printReceiptButton).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label;
        private Panel panel2;
        private PictureBox backButtonIcon;
        private Label label4;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel orderDisplay;
        private Panel cartItem;
        private Label quantity;
        private Label itemName;
        private Label price;
        private Label label5;
        private Label subTotal;
        private Label label6;
        private TextBox cashInput;
        private Button preCash500;
        private Button preCash300;
        private Button preCash1000;
        private Button chargeButton;
        private Button newSaleButton;
        private Label label1;
        private PictureBox printReceiptButton;
    }
}