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
    public partial class frmRefund : Form
    {
        public string invoiceid { get; set; }
        public decimal refundAmount { get; set; }

        public frmRefund()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();

            DataTable dtable=invoice.findInvoice(invoiceid);
            string peopleid = dtable.Rows[0]["people_id"].ToString();

            if (peopleid == "1" && cmbType.Text == "Refund to Account")
            {
                MessageBox.Show("The Customer Does not have account in the system");
            }
            else
            {
                Payment payment = new Payment(is_supplier: false);
                payment.peopleID = int.Parse(peopleid);
                payment.paymentType = cmbType.Text;
                payment.note = txtNote.Text;
                payment.amount = refundAmount.ToString();
                payment.refrence_ID = int.Parse(invoiceid);
                payment.chequeStatus = "Paid";

                if (payment.insertPayment())
                {
                    if (invoice.updateRefundAmount(invoiceid, refundAmount))
                    {
                        if (cmbType.SelectedIndex == 1)
                        {
                            //Refund Amount to Customer Credit Account
                            new Payment(is_supplier: false).ExecuteData($"UPDATE tbl_people set balance=balance+{(refundAmount * -1)} where people_id={peopleid}");
                        }
                        Animation.showMessage("Amount Refunded", "success");
                        this.DialogResult = DialogResult.Yes;
                    }
                }
            }
        }

        private void frmRefund_Shown(object sender, EventArgs e)
        {
            txtRefund.Text = (refundAmount * -1).ToString();
            cmbType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
