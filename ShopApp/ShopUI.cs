using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopApp
{
    public partial class ShopUI : Form
    {
        public ShopUI()
        {
            InitializeComponent();
        }

        private Shop aShop;

        private void saveButton_Click(object sender, EventArgs e)
        {
            aShop = new Shop(shopNameTextBox.Text, shopAddressTextBox.Text);
            MessageBox.Show("Shop has been created");
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            Item anItem = new Item();
            anItem.Id = itemIdTextBox.Text;
            anItem.Quantity = Convert.ToInt16(quantityTextBox.Text);
            string msg = aShop.Add(anItem);
            MessageBox.Show(msg);
        }
    }
}
