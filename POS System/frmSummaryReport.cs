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
    public partial class frmSummaryReport : Form
    {
        public frmSummaryReport()
        {
            InitializeComponent();
        }

        Connection con = new Connection();

        private void frmSummaryReport_Load(object sender, EventArgs e)
        {
            dtProfitBindingSource.DataSource = con.GetData("SELECT (SELECT SUM(tbl_invoice.total) FROM tbl_invoice) AS sales, (SELECT SUM(tbl_purchase.total) FROM tbl_purchase) AS purchase, (SELECT SUM(tbl_expences.amount) FROM tbl_expences) AS expense");

            this.rptViewer.Refresh();
            this.rptViewer.RefreshReport();
        }
    }
}
