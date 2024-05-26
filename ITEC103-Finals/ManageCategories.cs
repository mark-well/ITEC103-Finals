using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicroPOS
{
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            DataTable categories = DatabaseHandler.LoadCategories();
            foreach (DataRow row in categories.Rows)
            {
                string category = Convert.ToString(row["category"]);
                categoriesContainer.Items.Add(category);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string newCategory = input.Text.ToLower();
            categoriesContainer.Items.Add(newCategory);
            DatabaseHandler.AddNewItemCategory(newCategory);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Object selectedItem = categoriesContainer.SelectedItem;
            string selectedItemText = categoriesContainer.GetItemText(selectedItem);
            if (categoriesContainer.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this category?, WARNING!!: This will also delete all products associated with this category", "WARNING! WARNING! WARNING! WARNING!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    categoriesContainer.Items.Remove(categoriesContainer.SelectedItem);
                    DatabaseHandler.DeleteItemCategory(selectedItemText);
                    DatabaseHandler.DeleteItemFromInventoryByCategory(selectedItemText);
                }
            }
            else
            {
                MessageBox.Show("Please select a category to delete!");
            }
        }
    }
}
