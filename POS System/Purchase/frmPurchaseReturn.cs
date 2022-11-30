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
    public partial class frmPurchaseReturn : Form
    {
        PurchaseReturn purchReturn = new PurchaseReturn();

        public frmPurchaseReturn(string itemName)
        {
            InitializeComponent();

            txtName.Text = itemName;
            Validation.numbersOnly(txtPrice);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            purchReturn.quantity = txtQuantity.Value;
            purchReturn.costPrice = Convert.ToDecimal(txtPrice.Text);
            purchReturn.reason = txtReaason.Text.Trim();

            if(txtReaason.Text.Trim()=="")
            {
                MessageBox.Show("Reason Required");
                txtReaason.Focus();
            }
            else if (purchReturn.insertPurchaseReturn())
            {
                MessageBox.Show("The Item Return Successfully");
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void frmPurchaseReturn_Load(object sender, EventArgs e)
        {
            purchReturn = (PurchaseReturn)this.Tag;
            txtPrice.Text = purchReturn.costPrice.ToString();
            txtQuantity.Value = purchReturn.quantity;
        }
    }
}
