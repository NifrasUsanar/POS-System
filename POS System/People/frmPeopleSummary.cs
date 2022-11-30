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
using Microsoft.Reporting.WinForms;

namespace POS_System
{
    public partial class frmPeopleSummary : Form
    {
        public string peopleID { get; set; }
        public bool is_supplier { get; set; }
        public frmPeopleSummary()
        {
            InitializeComponent();
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddMonths(-1);
        }

        void loadReport()
        {
            Connection con = new Connection();

            if (!is_supplier)
            {
                dtSaleSummaryBindingSource.DataSource = con.GetData($"SELECT tbl_invoice.created_at AS dt,CONCAT('Bill No - ',RIGHT(CONCAT('00000', `id`),5),IF(reference IS NULL OR reference='','',CONCAT(' - ',reference))) AS description,total AS billamount, 0 AS paid FROM tbl_invoice WHERE tbl_invoice.people_id={peopleID} AND (CONVERT(tbl_invoice.created_at,DATE) BETWEEN '{Validation.convertDate(dtpStart)}' AND '{Validation.convertDate(dtpEnd)}') UNION SELECT tbl_sales_payment.created_at AS dt, CONCAT(payment_type, IF(note IS NULL OR note='','',CONCAT(' (',note,')'))) AS description, CASE WHEN amount<0 THEN ABS(amount) ELSE 0 END AS billamount, CASE WHEN amount>0 THEN amount ELSE 0 END AS paid FROM tbl_sales_payment WHERE tbl_sales_payment.people_id = {peopleID} AND payment_type != 'Account' AND (CONVERT(tbl_sales_payment.created_at,DATE) BETWEEN '{Validation.convertDate(dtpStart)}' AND '{Validation.convertDate(dtpEnd)}') ORDER BY dt");
            }
            else if(is_supplier)
            {
                dtSaleSummaryBindingSource.DataSource = con.GetData($"SELECT tbl_purchase.created_at AS dt,CONCAT('Purchase - ',RIGHT(CONCAT('00000', `id`),5),' (','Ref. ',tbl_purchase.refrence_no,')') AS description,0 AS billamount,total AS paid FROM tbl_purchase WHERE tbl_purchase.people_id={peopleID} AND (CONVERT(tbl_purchase.created_at,DATE) BETWEEN '{Validation.convertDate(dtpStart)}' AND '{Validation.convertDate(dtpEnd)}') UNION SELECT tbl_purchase_payment.created_at AS dt, CONCAT(payment_type, IF(note IS NULL OR note='','',CONCAT(' (',note,')'))) AS description, CASE WHEN amount>0 THEN amount ELSE 0 END AS billamount, CASE WHEN amount<0 THEN ABS(amount) ELSE 0 END AS paid FROM tbl_purchase_payment WHERE payment_type != 'Account' AND tbl_purchase_payment.people_id = {peopleID} AND (CONVERT(tbl_purchase_payment.created_at,DATE) BETWEEN '{Validation.convertDate(dtpStart)}' AND '{Validation.convertDate(dtpEnd)}') ORDER BY dt");
            }

            dtPeopleBindingSource.DataSource = con.GetData($"SELECT * FROM tbl_people WHERE people_id={peopleID}");

            dtStoreDetailsBindingSource.DataSource = new Setting().setting_details();

            ReportParameter[] param = new ReportParameter[1];
            param[0] = new ReportParameter("paraDate", " From " + Validation.convertDate(dtpStart) + " to " + Validation.convertDate(dtpEnd), false);
            this.rptViewer.LocalReport.SetParameters(param);
            this.rptViewer.LocalReport.Refresh();

            this.rptViewer.Refresh();
            this.rptViewer.RefreshReport();
        }
        
        private void frmPeopleSummary_Shown(object sender, EventArgs e)
        {
            loadReport();
        }

        private void frmPeopleSummary_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadReport();
        }
    }
}
