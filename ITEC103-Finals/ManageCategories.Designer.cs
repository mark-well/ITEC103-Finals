namespace MicroPOS
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            input = new TextBox();
            addButton = new Button();
            label1 = new Label();
            categoriesContainer = new ListBox();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // input
            // 
            input.Location = new Point(55, 250);
            input.Name = "input";
            input.Size = new Size(160, 23);
            input.TabIndex = 0;
            input.TextAlign = HorizontalAlignment.Center;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(59, 140, 247);
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Font = new Font("Arial", 9.75F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(25, 279);
            addButton.Name = "addButton";
            addButton.Size = new Size(101, 26);
            addButton.TabIndex = 1;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 36);
            label1.Name = "label1";
            label1.Size = new Size(166, 18);
            label1.TabIndex = 2;
            label1.Text = "Manage Item Category";
            // 
            // categoriesContainer
            // 
            categoriesContainer.FormattingEnabled = true;
            categoriesContainer.ItemHeight = 15;
            categoriesContainer.Location = new Point(25, 77);
            categoriesContainer.Name = "categoriesContainer";
            categoriesContainer.Size = new Size(212, 154);
            categoriesContainer.TabIndex = 3;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(255, 128, 128);
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Font = new Font("Arial", 9.75F);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(132, 279);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(101, 26);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 330);
            Controls.Add(deleteButton);
            Controls.Add(categoriesContainer);
            Controls.Add(label1);
            Controls.Add(addButton);
            Controls.Add(input);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "ManageCategories";
            Text = "Manage Category";
            Load += AddCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input;
        private Button addButton;
        private Label label1;
        private ListBox categoriesContainer;
        private Button deleteButton;
    }
}