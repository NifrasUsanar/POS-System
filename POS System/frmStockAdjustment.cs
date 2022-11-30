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


//Git commmit
namespace POS_System
{
    public partial class frmStockAdjustment : Form
    {
        public Stock stock { get; set; }

        public frmStockAdjustment()
        {
            InitializeComponent();
            Validation.numbersOnly(txtQuantity);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "0";

            decimal quantity = Convert.ToDecimal(txtQuantity.Text.Trim());
            if (quantity == 0) MessageBox.Show("Quantity Cannot be Zero");
            else
            {
                stock.quantity = Convert.ToDecimal(txtQuantity.Text.Trim());
                stock.item_desc = txtDescription.Text.Trim();

                if (stock.adjustStock())
                {
                    Global.is_success = true;
                    Global.stockAlertCount();
                    MessageBox.Show("Record Added");
                    this.DialogResult = DialogResult.Yes;
                }
            }
        }
    }
}
