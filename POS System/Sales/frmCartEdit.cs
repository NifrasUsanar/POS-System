using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace POS_System
{
    public partial class frmCartEdit : Form
    {

        public bool is_purchase=true;
        string cartID;
        public string itemID { get; set; }

        public frmCartEdit(string cartID, string price,string discount, string quantity)
        {
            InitializeComponent();

            txtPrice.Text = price;
            this.cartID = cartID;
            txtDiscount.Text = discount;
            txtQuantity.Text = quantity;
        }

        Invoice cart = new Invoice();

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCartEdit_Shown(object sender, EventArgs e)
        { 
            txtQuantity.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (decimal.Parse(txtQuantity.Text) > 0)
            //{
            //    Cart cart = new Cart();
            //    if (cart.updateCart(cartID, txtQuantity.Text, txtDiscount.Text, txtPrice.Text))
            //    {
            //        Animation.showMessage("Item Updated", "success");
            //        this.DialogResult = DialogResult.Yes;
            //        this.Close();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("0 Quantity is not allowed");
            //}

            if (txtDiscount.Text.Trim() == "") txtDiscount.Text = "0";
            if (txtPrice.Text.Trim() == "") txtPrice.Text = "0";

            if (decimal.Parse(txtQuantity.Text) > 0)
            {
                
                if (cart.updateSoldItem(cartID, txtQuantity.Text, txtDiscount.Text, txtPrice.Text, txtNote.Text.Trim()))
                {
                    Animation.showMessage("Item Updated", "success");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("0 Quantity is not allowed");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cart.removeSoldItem(cartID,itemID, txtQuantity.Text))
            {
                Animation.showMessage("Item Removed", "success");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(txtPrice.Text);
            decimal discount = decimal.Parse(txtDiscount.Text);
            decimal findDiscount = (price * discount) / 100;
            txtDiscount.Text = findDiscount.ToString();
        }
    }
}
