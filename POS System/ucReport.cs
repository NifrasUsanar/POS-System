using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using DataLibrary;

namespace POS_System
{
    public partial class ucReport : UserControl
    {
        public ucReport()
        {
            InitializeComponent();

            dtpStart.Value = dtpEnd.Value = DateTime.Now;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cmbMode.SelectedIndex == 0)
            {
                rptViewer.Reset();
                this.rptViewer.LocalReport.DataSources.Clear();

                ReportDataSource rptDataSoruce = new ReportDataSource();

                rptDataSoruce.Value = new ReportGen().paymentReport(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
                rptDataSoruce.Name = "dsPayment";
                rptViewer.LocalReport.DataSources.Add(rptDataSoruce);

                rptViewer.LocalReport.ReportEmbeddedResource = "POS_System.rptPaymentSummary.rdlc";
                this.rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
                this.rptViewer.Refresh();
                this.rptViewer.RefreshReport();
            }
        }
    }
}
