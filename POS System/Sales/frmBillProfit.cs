using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmBillProfit : Form
    {
        public frmBillProfit(DataTable dTable)
        {
            InitializeComponent();

            dgvPOS.DataSource = dTable;
            this.dTable = dTable;
        }

        DataTable dTable = new DataTable();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBillProfit_Shown(object sender, EventArgs e)
        {
            lblBillTotal.Text = $"Rs.{ dTable.Compute("Sum(total)", "True"):N2}";
            lblTotalCost.Text = $"Rs. {dTable.Compute("Sum(line_cost)", "True"):N2}";
            lblTotalProfit.Text = $"Rs. {dTable.Compute("Sum(profit)", "True"):N2}";
        }
    }
}
