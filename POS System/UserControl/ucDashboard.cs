using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ucDashboard : UserControl
    {
        public ucDashboard()
        {
            InitializeComponent();

            dtpStart.Value = dtpEnd.Value = DateTime.Now;
        }
        Connection connection = new Connection();
        void loadProfit()
        {
            DataTable dTable = connection.GetData($"SELECT SUM(total) as total, SUM(profit-discount) as profit FROM tbl_invoice WHERE (CONVERT(tbl_invoice.created_at,DATE) BETWEEN '{Validation.convertDate(dtpStart)}' AND '{Validation.convertDate(dtpEnd)}')");

            decimal total=0, profit = 0,expense=0;

            expense = Convert.ToDecimal(validateResult(connection.getSingleValue($"SELECT SUM(amount) FROM tbl_expences WHERE (CONVERT(tbl_expences.Date,DATE) BETWEEN '{Validation.convertDate(dtpStart)}' AND '{Validation.convertDate(dtpEnd)}')")));

            if (dTable.Rows[0][0].ToString() !="")
            {
                total= Convert.ToDecimal(dTable.Rows[0]["total"].ToString());
                profit = Convert.ToDecimal(dTable.Rows[0]["profit"].ToString());
            }

            chipProfit.Text = "Rs."+profit.ToString("N2");
            chipSale.Text = "Rs." + total.ToString("N2");
            chipExpense.Text = "Rs." + expense.ToString("N2");
            chipNetProfit.Text = "Rs." + (profit - expense).ToString("N2");
        }

        private async void ucDashboard_Load(object sender, EventArgs e)
        {
            await Task.Delay(500);
              
            string now = DateTime.Now.ToString("yyyy-MM-dd");

            lblSales.Text = validateResult(connection.getSingleValue("SELECT COUNT(id) FROM tbl_invoice"));
            lblNewSales.Text = validateResult(connection.getSingleValue("SELECT COUNT(id) from tbl_invoice where (CONVERT(tbl_invoice.created_at,DATE)='" + now+"')")) + " New Sales";

            lblContact.Text = validateResult(connection.getSingleValue("SELECT COUNT(people_id) from tbl_people"));
            lblStock.Text = validateResult(connection.getSingleValue("SELECT COUNT(itm_id) from tbl_item"));
            lblUser.Text = validateResult(connection.getSingleValue("SELECT COUNT(user_id) from tbl_user"));

            DataTable dTableBalance = connection.GetData("SELECT IFNULL(SUM(balance),0) AS balance FROM tbl_people WHERE is_supplier=0 AND people_id != 1 UNION SELECT IFNULL(SUM(balance),0) AS balance FROM tbl_people WHERE is_supplier=1 AND people_id != 1");

            decimal vendorOuts = Convert.ToDecimal(dTableBalance.Rows[1][0]);
            decimal customerOuts = Convert.ToDecimal(dTableBalance.Rows[0][0]);

            if (customerOuts>=0) chipOutstanding.FillColor = Color.SeaGreen;
            else chipOutstanding.FillColor = Color.Crimson;

            if (vendorOuts >= 0) chipVendorOutstanding.FillColor = Color.SeaGreen;
            else chipVendorOutstanding.FillColor = Color.Crimson;

            chipOutstanding.Text = "Rs. "+customerOuts.ToString("N2");
            chipVendorOutstanding.Text= "Rs. " + vendorOuts.ToString("N2");

            chipPendingCheque.Text = validateResult(connection.getSingleValue("SELECT COUNT(payment_id) FROM tbl_sales_payment WHERE payment_type='Cheque' AND cheque_status='Pending'"));
            chipMyPending.Text = validateResult(connection.getSingleValue("SELECT COUNT(payment_id) FROM tbl_purchase_payment WHERE payment_type='Cheque' AND cheque_status='Pending'"));

            loadProfit();
        }

        string validateResult(string result)
        {
            if (result == "" || result == null) return "0";
            else return result;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProfit();
        }

        private void linkShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (pnlSummary.Visible)
            {
                linkShow.Text = "SHOW";
                pnlSummary.Visible = false;
            }
            else
            {
                linkShow.Text = "HIDE";
                pnlSummary.Visible = true;
            }
        }
    }
}
