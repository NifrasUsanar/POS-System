using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace POS_System
{
    public partial class ucPOSItem : UserControl
    {
        string id, price;
        Cart cart = new Cart();
        public ucPOSItem(string id,string name, string price, string brand)
        {
            InitializeComponent();
            lblName.Text = name;
            lblPrice.Text = "Rs. "+price;
            lblBrand.Text = brand;
            this.price = price;
            this.id = id;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Global.dataGrid.DataSource=cart.insertCart(id,Global.numberInput());
            //MessageBox.Show(Common.numberInput().ToString());
        }

        private void ucPOSItem_Click(object sender, EventArgs e)
        {
            
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            //Common.dataGrid.DataSource = cart.insertCart(id);
            Global.dataGrid.DataSource = cart.insertCart(id, Global.numberInput());
        }
    }
}
