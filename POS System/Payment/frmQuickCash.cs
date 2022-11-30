using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using DataLibrary;

namespace POS_System
{
    public partial class frmQuickCash : Form
    {
        public int invoiceID { get; set; }

        decimal billAmount;

        Payment payment = new Payment(false);
        Invoice invoice = new Invoice();
        public frmQuickCash(decimal billAmount, string peopleID, decimal directProfit, decimal indirectProfit, decimal discount,string reference)
        {
            InitializeComponent();

            Validation.numbersOnly(txtNumber);

            this.billAmount = billAmount;
            payment.amount = billAmount.ToString();
            payment.peopleID = Convert.ToInt32(peopleID);

            invoice.peopleID = int.Parse(peopleID);
            invoice.profit = directProfit;
            invoice.indirect_profit = indirectProfit;
            invoice.total = billAmount;
            invoice.paid_amount = billAmount.ToString();
            invoice.discount = discount;
            invoice.reference = reference;

            if (billAmount < 0) { chipReturnAmount.Text = billAmount.ToString("N2"); txtNumber.Enabled = false; txtNumber.Text = "0"; }
        }

        

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Control ctrlBtn = sender as Control;

            if (ctrlBtn.Text == "0" || ctrlBtn.Text == "00")
            {
                decimal input = decimal.Parse(ctrlBtn.Text);
                decimal number = decimal.Parse(txtNumber.Text);

                if (number + input == 0)
                {
                    txtNumber.Text = "0";
                }
                else
                {
                    txtNumber.Text += ctrlBtn.Text;
                }
            }
            else
            {
                if (txtNumber.Text == "0" && ctrlBtn.Text != ".") txtNumber.Text = ctrlBtn.Text;
                else if (ctrlBtn.Text == "." && txtNumber.Text.Contains(".")) txtNumber.Text = txtNumber.Text;
                else txtNumber.Text += ctrlBtn.Text;
            }
        }

        void cashRegister()
        {
            //if (payment.is_supplier && payment.paymentType == "Cash")
            //{
            //    new CashRegister().updateCashRegisterAmount(Global.registerID, (-1 * decimal.Parse(payment.amount)));
            //}
            //else if (payment.paymentType == "Cash")
            //{
            //    new CashRegister().updateCashRegisterAmount(Global.registerID, decimal.Parse(payment.amount));
            //}
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(billAmount > Convert.ToDecimal(txtNumber.Text))
            {
                MessageBox.Show("Amount is Not Sufficiant");
            }
            else
            {
                payment.paymentType = "Cash";
                payment.refrence_ID = int.Parse(invoice.insertSale());
                payment.note = "";

               if(payment.insertPayment())
                {
                    MessageBox.Show("Sales Completed");
                    cashRegister();
                    this.DialogResult = DialogResult.Yes;
                    this.invoiceID = payment.refrence_ID;
                    Global.stockAlertCount();
                    this.Close();
                } 

            }
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtNumber.Text = txtNumber.Text.Remove(txtNumber.Text.Length - 1);
        }

        private void btlClear_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }

        private void quickCash_Click(object sender, EventArgs e)
        {
            txtNumber.Text = (sender as Control).Text;
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEnter.PerformClick();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (billAmount < 0) { chipReturnAmount.Text = billAmount.ToString("N2"); txtNumber.Enabled = false; txtNumber.Text = "0"; }

            if (txtNumber.Text.Trim() == "") txtNumber.Text = "0";

            if (txtNumber.Text == "0" || txtNumber.Text == "00") txtNumber.SelectAll();

            if (txtNumber.Text.Trim() != "-")
            {
                decimal recieveAmount = Convert.ToDecimal(txtNumber.Text.Trim());

                chipReturnAmount.Text = (recieveAmount - billAmount).ToString("0.00");
            } 
        }

        private void frmQuickCash_Load(object sender, EventArgs e)
        {
            chipBillAmount.Text = billAmount.ToString("0.00");
            txtNumber.Focus();
            txtNumber.SelectAll();

            //if (Global.registerID == 0)
            //{
            //    MessageBox.Show("Register is not Opened yet");
            //    this.Close();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void focusToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            txtNumber.Focus();
            txtNumber.SelectAll();
        }
    }
}
