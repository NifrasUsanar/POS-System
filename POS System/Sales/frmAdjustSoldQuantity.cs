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
    public partial class frmAdjustSoldQuantity : Form
    {
        public decimal qty { get; set; }
        public int invoiceID { get; set; }
        public string itemID { get; set; }
        public string cartID { get; set; }
        public frmAdjustSoldQuantity()
        {
            InitializeComponent();
            Validation.numbersOnly(txtQuantity);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "0";
            decimal quantity = Convert.ToDecimal(txtQuantity.Text);

            if (quantity == 0) MessageBox.Show("Invalid Quantity");
            else if ((quantity + qty) < 0) MessageBox.Show("Quantity Cannot Be Exceeded");
            else
            {
                if(new Invoice().editSoldItemQuantity(invoiceID,itemID,txtQuantity.Text.Trim(),cartID))
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }
        }

        private void frmAdjustSoldQuantity_Load(object sender, EventArgs e)
        {
            txtQuantity.Text =""+qty;
        }
    }
}
