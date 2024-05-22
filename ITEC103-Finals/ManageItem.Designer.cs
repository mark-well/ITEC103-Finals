﻿namespace ITEC103_Finals
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
            panel1 = new Panel();
            backButtonIcon = new PictureBox();
            label = new Label();
            splitContainer1 = new SplitContainer();
            panel2 = new Panel();
            addItemToInventoryButton = new Button();
            itemImage = new PictureBox();
            selectImageButton = new Button();
            itemNameInput = new TextBox();
            label2 = new Label();
            label1 = new Label();
            itemPriceInput = new TextBox();
            itemContainer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)backButtonIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemImage).BeginInit();
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
            addItemToInventoryButton.BackColor = Color.FromArgb(3, 174, 210);
            addItemToInventoryButton.BackgroundImageLayout = ImageLayout.None;
            addItemToInventoryButton.FlatStyle = FlatStyle.Flat;
            addItemToInventoryButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemToInventoryButton.ForeColor = Color.Black;
            addItemToInventoryButton.Location = new Point(36, 355);
            addItemToInventoryButton.Name = "addItemToInventoryButton";
            addItemToInventoryButton.Size = new Size(202, 38);
            addItemToInventoryButton.TabIndex = 6;
            addItemToInventoryButton.Text = "ADD ITEM";
            addItemToInventoryButton.UseVisualStyleBackColor = false;
            addItemToInventoryButton.Click += addItemToInventoryButton_Click;
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
            itemContainer.Dock = DockStyle.Fill;
            itemContainer.Location = new Point(0, 0);
            itemContainer.Name = "itemContainer";
            itemContainer.Size = new Size(530, 405);
            itemContainer.TabIndex = 0;
            // 
            // ManageItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
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
    }
}