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
    public partial class frmPurchaseOrderPrint : Form
    {
        public string orderID { get; set; }
        public frmPurchaseOrderPrint()
        {
            InitializeComponent();
        }

        private void frmPurchaseOrderPrint_Load(object sender, EventArgs e)
        {

        }

        private void frmPurchaseOrderPrint_Shown(object sender, EventArgs e)
        {
            dtStoreDetailsBindingSource.DataSource = new Setting().setting_details();
            dtPurchaseOrderBindingSource.DataSource = new PurchaseOrder().viewPurchasePrint(orderID);
            this.rptViewer.RefreshReport();
        }
    }
}
