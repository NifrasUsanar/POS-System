using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary;

namespace POS_System
{
    public partial class ucReturn : UserControl
    {
        
        public ucReturn()
        {
            InitializeComponent();

           Validation.numbersOnly(txtInvoiceSearch);

            dtpStart.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;

            Global.changeTabControlStyle(tabControl);
        }

        Invoice invoice = new Invoice();
        Return returnItems = new Return();

        DataTable dTable = new DataTable();
        string invoiceNo;
        decimal due = 0;

        void findInvoice(string invoiceno)
        {
            try
            {     
                dTable = invoice.findInvoice(invoiceno);
                if (dTable.Rows.Count > 0)
                {
                    decimal total = decimal.Parse(dTable.Rows[0]["total"].ToString());
                    decimal paid = decimal.Parse(dTable.Rows[0]["paid"].ToString());
                    decimal refund = decimal.Parse(dTable.Rows[0]["refund_amount"].ToString());

                    due = total - (paid+refund);

                    invoiceNo = dTable.Rows[0]["id"].ToString();
                    txtCustomer.Text = dTable.Rows[0]["name"].ToString();
                    txtDiscount.Text = dTable.Rows[0]["discount"].ToString();
                    txtPaid.Text = paid.ToString();
                    txtTotal.Text = total.ToString();
                    txtDue.Text = due.ToString();
                    txtInvoiceNo.Text = invoiceNo;

                    DateTime dTime = Convert.ToDateTime(dTable.Rows[0]["created_at"].ToString());
                    txtDate.Text = dTime.ToString("yyyy-MM-dd");

                    dgvItems.DataSource = invoice.findInvoiceItemsForReturn(invoiceNo);
                }
                else
                {
                    Animation.showMessage("The Invoice No is Incorrect", "error");
                }
            }
            catch (Exception exc)
            {
                Animation.showMessage(exc.Message, "error");
            }

            
        }

        private void txtInvoiceSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findInvoice(txtInvoiceSearch.Text);
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvItems.SelectedRows[0].Cells["cellQuantity"].Value.ToString() != "0")
            {
                frmReturn formreturn = new frmReturn();
                formreturn.dgvGrid = dgvItems;
                formreturn.invoiceno = invoiceNo;

                Animation.showModal(formreturn);

                findInvoice(invoiceNo);
            }
        }

        private void ucReturn_Load(object sender, EventArgs e)
        {
            dgvReturn.DataSource = returnItems.viewReturn(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (due < 0)
            {
                frmRefund refund = new frmRefund();
                refund.invoiceid = invoiceNo;
                refund.refundAmount = due;

                var result=Animation.resultModal(refund);

                if(result == DialogResult.Yes)
                {
                    findInvoice(invoiceNo);
                }
            }
            else
            {
                Animation.showMessage("Refund amount is not sufficient to continue this process","error");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvReturn.DataSource = returnItems.viewReturn(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
        }

        private void btnReturnHistory_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pagesSalesReturnHistory;
        }
    }
}
