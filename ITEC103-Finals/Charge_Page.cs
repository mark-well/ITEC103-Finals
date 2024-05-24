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
        public Charge_Page()
        {
            InitializeComponent();
        }

        private void backButtonIcon_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
        }

        private void preCash300_Click(object sender, EventArgs e)
        {
            cashInput.Text = "300";
        }

        private void preCash500_Click(object sender, EventArgs e)
        {
            cashInput.Text = "500";
        }

        private void preCash1000_Click(object sender, EventArgs e)
        {
            cashInput.Text = "1000";
        }
    }
}
