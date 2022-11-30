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
    public partial class frmPayment : Form
    {
        public string invoiceID { get; set; }

        People people = new People();

        Validation validation = new Validation();
        Invoice invoice = new Invoice();
        decimal totalAmount, balance, discount;

        public frmPayment(decimal totalAmount, decimal discount, int people_id, int refrence_id=0, bool is_supplier=false,bool is_deposit=false, decimal profit =0, decimal indirect_profit =0,string reference="")
        {
            InitializeComponent();

            Validation.numbersOnly(txtAmount);

            payment = new Payment(is_supplier:is_supplier);

            this.totalAmount = totalAmount;
            this.discount = discount;
            payment.refrence_ID = refrence_id;
            payment.peopleID = people_id;
            payment.is_deposit = is_deposit;

            invoice.profit=profit;
            invoice.indirect_profit = indirect_profit;
            invoice.reference = reference;

            if (is_deposit) btnAccount.Visible = false;
            dtpCheque.Value = DateTime.Now;
        }

        Payment payment;

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

        void onLoad()
        {
            if (payment.peopleID == 1)
            {
                btnAccount.Visible = false;
                btnCheque.Visible = false;
            }
            txtAmount.Text = totalAmount.ToString();

            if (payment.is_deposit)
            {
                btnPrint.Visible = false;
                btnPayment.Left = btnPrint.Left;
            }

            if (payment.is_supplier)
            {
                cmbAccount.Enabled = true;
                grpChequeSupplier.Visible = true;
                cmbAccount.DataSource = new BankAccount().showBankAccount();
                cmbAccount.ValueMember = "id";
                cmbAccount.DisplayMember = "account";
            }
        }

        //Payment Type ComboBox Changed
        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //Save and Print Invoice
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (validatePayment())
            {
                updatePayment();
                invoiceID = payment.refrence_ID.ToString();
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            onLoad();
            //if (Global.registerID == 0)
            //{
            //    MessageBox.Show("Register is not Opened yet");
            //    this.Close();
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //Only Save the invoice
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (validatePayment())
            {
                updatePayment();
                this.DialogResult = DialogResult.No;
                this.Close();
            }
        }

        //Payment Validation
        bool validatePayment()
        {
            decimal number = 0;
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("The Payment cannot be empty");
                return false;
            }
            else if (!decimal.TryParse(txtAmount.Text,out number))
            {
                MessageBox.Show("Invalid Number");
                return false;
            }
            //else if (decimal.Parse(txtAmount.Text) > totalAmount && !payment.is_deposit)
            //{
            //    MessageBox.Show("The Paying Amount Cannot be exceeded the total amount");
            //    return false;
            //}
            else if (double.Parse(txtAmount.Text) == 0)
            {
                MessageBox.Show("The paying amount cannot be zero");
                return false;
            }
            else if (chipPayment.Text == "Cheque" && txtChequeNo.Text.Trim() == "")
            {
                MessageBox.Show("The Cheque Number Cannot be Empty");
                txtChequeNo.Focus();
                return false;
            }
            else if (chipPayment.Text == "Cheque" && txtBank.Text.Trim() == "")
            {
                MessageBox.Show("The Bank Name cannot be empty");
                txtChequeNo.Focus();
                return false;
            }
            else if (chipPayment.Text == "Cheque" && payment.peopleID == 1)
            {
                MessageBox.Show("Only Registered Customer able to give cheque payment");
                return false;
            }
            else if(chipPayment.Text=="Other" && txtOtherPayment.Text.Trim()=="")
            {
                MessageBox.Show("Other Payment Method Required");
                txtOtherPayment.Focus();
                return false;
            }
            else return true;
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set bank Name on Account changed
            DataRowView rowView = cmbAccount.SelectedItem as DataRowView;
            if(rowView !=null)
            {
                txtBank.Text = rowView["bank_name"].ToString();
                chipAccountBalance.Text ="Rs. "+((decimal)rowView["balance"]).ToString("N2");
            }
            else
            {
                chipAccountBalance.Text = "Rs. 0.00";
            }
        }

        private void chipPayment_TextChanged(object sender, EventArgs e)
        {
            if (chipPayment.Text != "Cheque") grbCheque.Enabled = false;
            else grbCheque.Enabled = true;

            if (chipPayment.Text == "Other") txtOtherPayment.Enabled = true;
            else txtOtherPayment.Enabled = false;
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            chipPayment.Text = (sender as Control).Text;
        }

        private void togglePartyCheque_CheckedChanged(object sender, EventArgs e)
        {
            if(togglePartyCheque.Checked)
            {
                btnPartyCheque.Enabled = true;
                pnlChequeInfo.Enabled = false;
                txtAmount.ReadOnly = true;
                cmbAccount.Enabled = false;
                txtAmount.Text = "0";
            }
            else
            {
                btnPartyCheque.Enabled = false;
                pnlChequeInfo.Enabled = true;
                txtChequeNo.ResetText();
                txtBank.ResetText();
                dtpCheque.Value = DateTime.Now;
                cmbChequeType.SelectedIndex = 0;
                txtAmount.Text = "0";
                txtAmount.ReadOnly = false;
                cmbAccount.Enabled = true;
            }
        }

        private void btnPartyCheque_Click(object sender, EventArgs e)
        {
            //btnParty cheque send as tag
            //Bind Data to PartyCheque on Cheque select
            //Binded data will be set to other controls on btnPartyCheque Text Changed
            new frmViewCheque(0, false, true) { TopMost = true,Tag=btnPartyCheque }.ShowDialog();
        }

        private void btnPartyCheque_TextChanged(object sender, EventArgs e)
        {
            DataRow row = btnPartyCheque.Tag as DataRow;
            if(row!=null)
            {
                txtAmount.Text = row["amount"].ToString();
                txtChequeNo.Text = row["cheque_no"].ToString();
                txtBank.Text = row["bankname"].ToString();
                cmbChequeType.Text = row["cheque_type"].ToString();
                dtpCheque.Text = row["cheque_date"].ToString();
            }
        }

        //Cheque Party Cheque and Set Values
        void isPartyCheque()
        {
            if(togglePartyCheque.Checked && payment.is_supplier)
            {
                DataRow row = btnPartyCheque.Tag as DataRow;
                if (row != null)
                {
                    payment.is_party = true;
                    payment.cheque_reference = row["payment_id"].ToString();
                    payment.account_id = 0;
                    payment.cheque_from = row["people_id"].ToString();
                    payment.cheque_to = payment.peopleID;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtOtherPayment_Leave(object sender, EventArgs e)
        {
            //Dont allow user to enter account
            if (txtOtherPayment.Text.Trim().ToUpper() == "ACCOUNT" && btnAccount.Visible == true)
            {
                btnAccount.PerformClick();
            }
            else if (txtOtherPayment.Text.Trim().ToUpper() == "ACCOUNT" && btnAccount.Visible == false)
            {
                MessageBox.Show("Account is Not allowed");
                txtOtherPayment.Text = "";
            }
            else if (txtOtherPayment.Text.Trim().ToUpper() == "CHEQUE")
            {
                btnCheque.PerformClick();
            }
            else if (txtOtherPayment.Text.Trim().ToUpper() == "CASH")
            {
                btnCash.PerformClick();
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        void updatePayment()
        {
            balance = totalAmount - decimal.Parse(txtAmount.Text);

            //Guest customer checking and validation
            if(balance!=0 && payment.peopleID == 1)
            {
                Animation.showMessage("Only registered customer able to get credit","error");
            }
            else
            {
                    payment.amount = txtAmount.Text;
                    payment.paymentType = "Cash";
                    payment.note = txtNote.Text;

                    invoice.peopleID = payment.peopleID;
                    invoice.paid_amount = txtAmount.Text;
                    invoice.total = totalAmount;
                    invoice.discount = discount;  

                    payment.chequeStatus = "Paid";

                    if (chipPayment.Text == "Cheque")
                    {
                        payment.paymentType = "Cheque";
                        payment.chequeNo = txtChequeNo.Text;
                        payment.bankName = txtBank.Text;
                        payment.chequeDate = Validation.convertDate(dtpCheque);
                        payment.chequeStatus = "Pending";
                        payment.chequeType = cmbChequeType.Text;

                        //Only Vendor Required Account ID
                        if (payment.is_supplier) payment.account_id = (int)cmbAccount.SelectedValue;
                        
                        //Cheque Party Cheque or Not and Update
                        isPartyCheque();
                    }

                    //IF INVOICE no is equal to 0 then process to add new invoice no
                    if (payment.refrence_ID == 0 && !payment.is_supplier && !payment.is_deposit)
                    {
                        //Insert sale and get Sale id  
                        payment.refrence_ID = int.Parse(invoice.insertSale());

                    //Update People Balance on every sale insert
                    if (payment.peopleID != 1) people.updatePeopleBalance(payment.peopleID,(-1*totalAmount));

                        //Update Stock Alert
                        Global.stockAlertCount();
                    }

                    //Save Payment into Invoice
                    else if(!payment.is_supplier && !payment.is_deposit)
                    {
                        invoice.updateInvoicePayment(payment.refrence_ID);
                    }


                //Set Other Payment Method
                if (chipPayment.Text == "Other") payment.paymentType = txtOtherPayment.Text;
                else payment.paymentType = chipPayment.Text;

                    //Finally Insert Payment
                    if (payment.insertPayment())
                    {
                        updatePeopleBalance();
                        MessageBox.Show("Payment Successfully Added");

                        //cashRegister();

                        if (!payment.is_deposit)
                        {
                            payment.setTotalPaidofBill(payment.refrence_ID);
                        }
                    }  
            }
       }

        void updatePeopleBalance()
        {
            if (payment.peopleID != 1 && payment.paymentType!="Account")
            {
                people.updatePeopleBalance(payment.peopleID, decimal.Parse(payment.amount));
            }
        }
    }
}
