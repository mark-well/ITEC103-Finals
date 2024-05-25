using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITEC103_Finals
{
    public partial class Charge_Page : Form
    {
        int itemTotalPrice = 0;
        int customerCash = 0;
        int exchange = 0;

        public Charge_Page()
        {
            InitializeComponent();
        }

        //Page load
        private void Charge_Page_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.Bounds = Screen.PrimaryScreen.Bounds;

            LoadItemsToOrderDisplay();
        }

        private void LoadItemsToOrderDisplay()
        {
            if (Cart.items.Count == 0) return;
            foreach (CartItem item in Cart.items)
            {
                itemTotalPrice += item.itemPrice * item.quantity;
                AddItemToOrderDisplay(item.itemName, item.itemPrice, item.quantity);
            }

            subTotal.Text = $"P{itemTotalPrice.ToString()}";
        }

        private void AddItemToOrderDisplay(string name, int itemPrice, int itemQuantity)
        {
            Label price = new Label();
            price.AutoSize = true;
            price.BackColor = Color.Transparent;
            price.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price.ForeColor = Color.Black;
            price.Location = new Point(157, 11);
            price.MaximumSize = new Size(30, 100);
            price.MinimumSize = new Size(35, 30);
            price.Name = "price";
            price.RightToLeft = RightToLeft.No;
            price.Size = new Size(35, 30);
            price.TabIndex = 2;
            price.Text = $"P{itemPrice}";
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.UseMnemonic = false;

            Label quantity = new Label();
            quantity.AutoSize = true;
            quantity.BackColor = Color.Transparent;
            quantity.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantity.ForeColor = Color.Black;
            quantity.Location = new Point(101, 11);
            quantity.MaximumSize = new Size(30, 100);
            quantity.MinimumSize = new Size(20, 30);
            quantity.Name = "quantity";
            quantity.RightToLeft = RightToLeft.No;
            quantity.Size = new Size(20, 30);
            quantity.TabIndex = 1;
            quantity.Text = $"{itemQuantity}x";
            quantity.TextAlign = ContentAlignment.MiddleCenter;
            quantity.UseMnemonic = false;

            Label itemName = new Label();
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
            itemName.Text = name;
            itemName.TextAlign = ContentAlignment.MiddleLeft;

            Panel cartItem = new Panel();
            cartItem.Controls.Add(price);
            cartItem.Controls.Add(quantity);
            cartItem.Controls.Add(itemName);
            cartItem.ForeColor = Color.White;
            cartItem.Location = new Point(0, 0);
            cartItem.Margin = new Padding(0);
            cartItem.BackColor = Color.White;
            cartItem.Name = "cartItem";
            cartItem.Size = new Size(200, 50);
            cartItem.TabIndex = 0;

            orderDisplay.Controls.Add(cartItem);
        }

        private void backButtonIcon_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void preCash300_Click(object sender, EventArgs e)
        {
            customerCash = 300;
            cashInput.Text = customerCash.ToString();
        }

        private void preCash500_Click(object sender, EventArgs e)
        {
            customerCash = 500;
            cashInput.Text = customerCash.ToString();
        }

        private void preCash1000_Click(object sender, EventArgs e)
        {
            customerCash = 1000;
            cashInput.Text = customerCash.ToString();
        }

        private void cashInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                GetCashInput();
                exchange = CalculateInvoice(itemTotalPrice, customerCash);
            }
        }

        private void chargeButton_Click(object sender, EventArgs e)
        {
            customerCash = GetCashInput();
            if (customerCash < itemTotalPrice)
            {
                MessageBox.Show("Cash can't be lower than the total price");
                return;
            }

            exchange = CalculateInvoice(itemTotalPrice, customerCash);
            Receipt.PrintReceipt(receiptDocument, receiptPreviewDialog);
            Cart.items.Clear();
            orderDisplay.Controls.Clear();
            cashInput.Text = "";

        }

        private int CalculateInvoice(int total, int cash)
        {
            return (int)cash - total;
        }

        private int GetCashInput()
        {
            try
            {
                return int.Parse(cashInput.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Please enter only numbers");
                return 0;
            }
        }

        private void printReceiptButton_Click(object sender, EventArgs e)
        {
            if (customerCash == 0)
            {
                MessageBox.Show("Please enter your cash first");
            }
            else
            {
                Receipt.PrintReceipt(receiptDocument, receiptPreviewDialog);
            }
        }

        private void receiptDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Receipt.GenerateReceipt(Cart.items, itemTotalPrice, customerCash, exchange, receiptDocument, e);
        }

        private void newSaleButton_Click(object sender, EventArgs e)
        {
            if (Cart.items.Count != 0)
            {
                MessageBox.Show("Complete the transaction first");
            } else
            {
                Main mainForm = new Main();
                mainForm.Show();
                this.Hide();
            }
        }
    }
}
