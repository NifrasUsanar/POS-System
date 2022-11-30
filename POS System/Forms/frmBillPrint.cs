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
    public partial class frmBillPrint : Form
    {
        string invoiceID;
        public frmBillPrint(string invoiceID)
        {
            InitializeComponent();
            this.invoiceID = invoiceID;
        }

        private void frmBillPrint_Load(object sender, EventArgs e)
        {
            
        }

        private void frmBillPrint_Shown(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();

            dtSalesBindingSource.DataSource = invoice.findInvoice(invoiceID);
            dtSalesItemBindingSource.DataSource = invoice.findInvoiceItems(invoiceID);
            dtStoreDetailsBindingSource.DataSource = new Setting().setting_details();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);

            this.reportViewer1.RefreshReport();

            //LocalReport localReport = new LocalReport();
            //localReport.ReportPath = Application.StartupPath + "\\Report1.rdlc";
            //localReport.PrintToPrinter();

            //this.reportViewer1.LocalReport.PrintToPrinter();
        }
    }
}
