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
    public partial class frmPurchaseCart : Form
    {
        string itemID, cartID;
        int purchaseID;
        public frmPurchaseCart(string itemID, string cartID="0", int purchaseID=0)
        {
            InitializeComponent();

            Validation.numbersOnly(txtPurchasePrice);
            Validation.numbersOnly(txtSalePrice);
            Validation.numbersOnly(txtQuantity);
            Validation.numbersOnly(txtItemCost);
            Validation.numbersOnly(txtDiscount);

            dtpExpiry.Value=dtpManufacture.Value = DateTime.Now;
            checkDate.Checked = false;

            this.itemID = itemID;
            this.cartID = cartID;
            this.purchaseID = purchaseID;
        }

        Item item = new Item();
        PurchaseItems cartPurchase = new PurchaseItems();
        decimal oldQuantity = 0;
        void findLineAmountofPurchase()
        {
            decimal quantity, cost, lineAmount,profit,itemCost,discount,salePrice;

            if (txtQuantity.Text.Trim() == "" || txtQuantity.Text.Trim() == "-") quantity = 0;
            else quantity = decimal.Parse(txtQuantity.Text.Trim());

            if (txtPurchasePrice.Text.Trim() == "" || txtPurchasePrice.Text.Trim() == "-") cost = 0;
            else cost = decimal.Parse(txtPurchasePrice.Text.Trim());

            if (txtItemCost.Text.Trim() == "" || txtItemCost.Text.Trim() == "-") itemCost = 0;
            else itemCost = decimal.Parse(txtItemCost.Text.Trim());

            if (txtSalePrice.Text.Trim() == "" || txtSalePrice.Text.Trim() == "-") salePrice = 0;
            else salePrice = decimal.Parse(txtSalePrice.Text.Trim());

            if (txtDiscount.Text.Trim() == "" || txtDiscount.Text.Trim() == "-") discount = 0;
            else discount = decimal.Parse(txtDiscount.Text.Trim());

            profit = (salePrice-itemCost) * quantity;
            lineAmount = (cost -discount) * quantity;

            chipProfit.Text = "Rs. " + profit.ToString("N2");
            chipLineAmount.Text = "Rs." + lineAmount.ToString("N2");
        }

        void addToPurchaseCart()
        {
            if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "0";
            if (txtPurchasePrice.Text.Trim() == "") txtPurchasePrice.Text = "0";
            if (txtItemCost.Text.Trim() == "") txtItemCost.Text = "0";
            if(txtSalePrice.Text.Trim()=="") txtSalePrice.Text = "0";
            if (txtDiscount.Text.Trim() == "") txtDiscount.Text = "0";

            cartPurchase.itemID = Convert.ToInt32(itemID);
            cartPurchase.cost = decimal.Parse(txtPurchasePrice.Text.Trim());
            cartPurchase.sale_price = decimal.Parse(txtSalePrice.Text.Trim());
            cartPurchase.discount = decimal.Parse(txtDiscount.Text.Trim());
            cartPurchase.quantity = decimal.Parse(txtQuantity.Text.Trim());
            cartPurchase.indirect_cost = decimal.Parse(txtItemCost.Text.Trim());

            if (checkDate.Checked)
            {
                cartPurchase.expiry = Validation.convertDate(dtpExpiry);
                cartPurchase.manufacture = Validation.convertDate(dtpManufacture);
            }
            else cartPurchase.expiry = cartPurchase.manufacture = null;

            if (cartID!="0")
            {
                DialogResult result = MessageBox.Show("The Item is Already Exist in the purchase.. Do you want to update the quantity and other details?", "Information", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes && cartPurchase.updateCart(cartID))
                {
                    updateStock();
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else if(cartPurchase.insertCart(purchaseID))
            {
                updateStock();
                this.DialogResult = DialogResult.Yes;
            }
        }

        void updateStock()
        {
            if (purchaseID != 0)
            {
                DialogResult result = MessageBox.Show("Do you want to update stock?", "Information", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (cartID != "0") cartPurchase.updateStockByQuantity(itemID,((-1*oldQuantity)+cartPurchase.quantity));
                    else cartPurchase.updateStockByQuantity(itemID, cartPurchase.quantity);
                }
            }
        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked)
            {
                dtpExpiry.Enabled = true;
                dtpManufacture.Enabled = true;
            }
            else
            {
                dtpExpiry.Enabled = false;
                dtpManufacture.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                addToPurchaseCart();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtPurchasePrice_TextChanged(object sender, EventArgs e)
        {
            findLineAmountofPurchase();
        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {
            findLineAmountofPurchase();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseCart_Shown(object sender, EventArgs e)
        {
            DataTable dTableCart;
            if(cartID!="0")
            {
                dTableCart = cartPurchase.findPurchaseItem(cartID);
                oldQuantity = Convert.ToDecimal(dTableCart.Rows[0]["quantity"]);
                txtQuantity.Text = dTableCart.Rows[0]["quantity"].ToString();
                txtItemCost.Text = dTableCart.Rows[0]["indirect_cost"].ToString();
                txtPurchasePrice.Text = dTableCart.Rows[0]["cost"].ToString();
                txtDiscount.Text = dTableCart.Rows[0]["discount"].ToString();

                string exp = dTableCart.Rows[0]["exp_date"].ToString().Trim();
                if (exp.Trim().Length != 0)
                {
                    checkDate.Checked = true;
                    dtpExpiry.Text = dTableCart.Rows[0]["exp_date"].ToString();
                    dtpManufacture.Text = dTableCart.Rows[0]["mf_date"].ToString();
                }
                else checkDate.Checked = false;
            }
            else
            {
                dTableCart = new Item() { itemID=Convert.ToInt32(itemID)}.item_details();
                txtItemCost.Text = dTableCart.Rows[0]["cost"].ToString();
            }      
            txtSalePrice.Text = dTableCart.Rows[0]["sale_price"].ToString();
            
        }
    }
}
