using Microsoft.Reporting.WinForms;
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
    public partial class frmGlobalReport : Form
    {
        public frmGlobalReport(string title, string reportPath, string dataSourceName, DataTable dataSource)
        {
            InitializeComponent();

            lblReportTitle.Text = title;
            this.rptViewer.LocalReport.DataSources.Clear();

            ReportDataSource rptDataSoruce = new ReportDataSource();

            rptDataSoruce.Value = dataSource;
            rptDataSoruce.Name = dataSourceName;
            rptViewer.LocalReport.DataSources.Add(rptDataSoruce);

            rptViewer.LocalReport.ReportEmbeddedResource = reportPath;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGlobalReport_Shown(object sender, EventArgs e)
        {
            this.rptViewer.SetDisplayMode(DisplayMode.PrintLayout);
            this.rptViewer.RefreshReport();
        }
    }
}
