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
    public partial class frmPurchaseRefund : Form
    {
        decimal refundAmount;
        int purchaseID,peopleID;
        public frmPurchaseRefund(int purchaseID,int peopleID, decimal refundAmount)
        {
            InitializeComponent();

            this.refundAmount = refundAmount;
            this.purchaseID = purchaseID;
            this.peopleID = peopleID;

            txtRefund.Text = refundAmount.ToString();

            Validation.numbersOnly(txtRefund);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Payment payment = new Payment(true);
            payment.amount = txtRefund.Text;
            payment.note = txtNote.Text.Trim();
            payment.paymentType = cmbType.Text;
            payment.peopleID = peopleID;
            payment.refrence_ID = purchaseID;

            decimal currentRefund = Convert.ToDecimal(txtRefund.Text);
            payment.amount = (currentRefund * -1).ToString();

            if (currentRefund>refundAmount)
            {
                MessageBox.Show("Refund Amount cannot be exceeded the original refund");
            }
            else
            {
                if(payment.insertPayment() && new Purchase().updatePurchaseRefund(purchaseID,currentRefund))
                {
                    if(payment.paymentType== "Refund to Account")
                    {
                        payment.ExecuteData(($"UPDATE tbl_people set balance=balance+{(currentRefund * -1)} where people_id={peopleID}"));
                    }
                    MessageBox.Show("Amount Refunded");
                    this.DialogResult = DialogResult.Yes;
                    this.Close();

                }
            }
        }
    }
}
