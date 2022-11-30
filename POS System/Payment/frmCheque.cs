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
    public partial class frmCheque : Form
    {
        Validation validation = new Validation();

        public string paymentID { get; set; }
        public DataGridView dGrid { get; set; }

        public frmCheque(bool is_supplier=false)
        {
            InitializeComponent();
            Validation.numbersOnly(txtAmount);
            payment = new Payment(is_supplier);
        }

        Payment payment;
        string oldStatus = "", peopleID, chequePeople;
        bool is_party_cheque=false;
        decimal chequeAmount;
        private void frmCheque_Load(object sender, EventArgs e)
        {

        }

        private void frmCheque_Shown(object sender, EventArgs e)
        {
            try
            {
                DataTable dTable = payment.findCheque(paymentID);

                txtAmount.Text = dTable.Rows[0]["amount"].ToString();
                txtBank.Text = dTable.Rows[0]["bankname"].ToString();
                dtpChequeDate.Text = dTable.Rows[0]["cheque_date"].ToString();
                txtChequeNo.Text = dTable.Rows[0]["cheque_no"].ToString();
                cmbType.Text = dTable.Rows[0]["cheque_type"].ToString();
                cmbStatus.Text = dTable.Rows[0]["cheque_status"].ToString();
                oldStatus = dTable.Rows[0]["cheque_status"].ToString();
                peopleID = dTable.Rows[0]["people_id"].ToString();
                is_party_cheque = bool.Parse(dTable.Rows[0]["is_party"].ToString());
                string cheque_people = dTable.Rows[0]["cheque_people"].ToString();
                payment.cheque_reference = dTable.Rows[0]["cheque_reference"].ToString();
                chequePeople = dTable.Rows[0]["cheque_people"].ToString();
                chequeAmount=decimal.Parse(dTable.Rows[0]["amount"].ToString());

                if (payment.is_supplier)
                {
                    cmbAccount.Enabled = false;

                    cmbAccount.DataSource = new BankAccount().showBankAccount();
                    cmbAccount.ValueMember = "id";
                    cmbAccount.DisplayMember = "account";

                    cmbAccount.SelectedValue = dTable.Rows[0]["account_id"].ToString();
                }

                //Show Party Cheque Details
                if(is_party_cheque && payment.is_supplier)
                {
                    lblChequeFrom.Text = new People().findPeople(cheque_people).Rows[0]["name"].ToString();

                    lblChequeTO.Text = new People().findPeople(peopleID).Rows[0]["name"].ToString();

                    payment.cheque_to = int.Parse(peopleID);
                    payment.cheque_from = cheque_people;
                }
                else if(is_party_cheque && !payment.is_supplier)
                {
                    lblChequeFrom.Text = new People().findPeople(peopleID).Rows[0]["name"].ToString();

                    lblChequeTO.Text = new People().findPeople(cheque_people).Rows[0]["name"].ToString();

                    payment.cheque_to = int.Parse(cheque_people);
                    payment.cheque_from = peopleID;
                }

                if (!is_party_cheque)
                {
                    grpPartyCheque.Visible = false;
                    btnPartyChequeReturn.Enabled = false;
                }

                if (oldStatus == "Deposited") { btnSave.Enabled = false; MessageBox.Show("Deposited cheque cannot be edited"); }
                else btnSave.Enabled = true;
            }
            catch (Exception exc)
            {
                Animation.showMessage(exc.Message,"error");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set bank Name on Account changed
            DataRowView rowView = cmbAccount.SelectedItem as DataRowView;
            if (rowView != null)
            {
                txtBank.Text = rowView["bank_name"].ToString();
            }
        }

        private void btnPartyChequeReturn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to continue this process?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                if(is_party_cheque && payment.is_supplier)
                {
                    payment.removePartyCheque(payment.cheque_reference);

                    if (oldStatus == "Pending" || oldStatus == "Paid")
                    {
                        new People().updatePeopleBalance(int.Parse(peopleID), chequeAmount);
                    }
                }
                else if(is_party_cheque && !payment.is_supplier)
                {
                    payment.removePartyCheque(paymentID);

                    if (oldStatus == "Pending" || oldStatus == "Paid")
                    {
                        new People().updatePeopleBalance(int.Parse(chequePeople), chequeAmount);
                    }
                }

                MessageBox.Show("Party Cheque Returned Successfully");
                this.Close();
            }
        }

        void updatePartyCheque()
        {
            if (is_party_cheque && payment.is_supplier) payment.updatePartyCheque(true,payment.cheque_reference);
            else if(is_party_cheque && !payment.is_supplier) payment.updatePartyCheque(false, payment.paymentID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                payment.paymentID = paymentID;
                payment.chequeDate = Validation.convertDate(dtpChequeDate);
                payment.chequeNo = txtChequeNo.Text;
                payment.chequeStatus = cmbStatus.Text;
                payment.chequeType = cmbType.Text;
                payment.amount = txtAmount.Text;
                payment.bankName = txtBank.Text;
                payment.peopleID = int.Parse(peopleID);

                if (payment.updateCheque())
                {
                    updatePartyCheque();

                    decimal chequeAmount = decimal.Parse(payment.amount);

                    //Increase Customer / Vendor Balance
                    if ((oldStatus == "Pending" || oldStatus == "Paid" || oldStatus == "Deposited") && (cmbStatus.Text=="Cancelled" || cmbStatus.Text == "Return"))
                    {    
                        //if (!payment.is_supplier) chequeAmount = (-1 * chequeAmount);

                        People people=new People();
                        people.updatePeopleBalance(payment.peopleID, (-1 * chequeAmount));

                        if (is_party_cheque)
                        {
                            people.updatePeopleBalance(int.Parse(chequePeople),(-1*chequeAmount));
                        }

                        MessageBox.Show("The Cheque Amount Updated to the Account");
                    }

                    //Decrease Customer / Vendor Balance
                    else if((cmbStatus.Text == "Pending" || cmbStatus.Text == "Paid" || cmbStatus.Text == "Deposited") && (oldStatus == "Cancelled" || oldStatus == "Return"))
                    {
                        //if (payment.is_supplier) chequeAmount = (-1 * chequeAmount);

                        People people=new People();
                        people.updatePeopleBalance(payment.peopleID, chequeAmount);

                        if (is_party_cheque)
                        {
                            people.updatePeopleBalance(int.Parse(chequePeople), chequeAmount);
                        }

                        MessageBox.Show("The Cheque Amount Updated to the Account");
                    }

                    //Bank Acccount Deduction
                    if (payment.is_supplier && !is_party_cheque)
                    {
                        decimal amount = decimal.Parse(payment.amount);
                        int accountID = (int)cmbAccount.SelectedValue;

                        //Deduct from Bank Account
                        if ((oldStatus == "Pending" || oldStatus == "Return" || oldStatus == "Cancelled") && cmbStatus.Text == "Paid")
                        {
                            if(new BankAccount().updateBankBalanceOnVendorCheque(accountID, (-1 * amount),payment.paymentID,payment.chequeDate))
                            {
                                MessageBox.Show($"The Amount Rs. {amount} Deducted from your Account {cmbAccount.Text}");
                            }
                        }

                        //Increase bank Account Balance
                        else if((oldStatus=="Paid") && (cmbStatus.Text=="Pending" || cmbStatus.Text == "Return" || cmbStatus.Text == "Cancelled"))
                        {
                            if(new BankAccount().updateBankBalanceOnVendorCheque(accountID, amount, payment.paymentID, payment.chequeDate))
                            {
                                MessageBox.Show($"The Amount Rs. {amount} Added to your Account {cmbAccount.Text}");
                            }
                        }
                    }

                    dGrid.DataSource = payment.viewCheque("","");
                    Animation.showMessage("Successfully Updated", "success");
                    this.Close();
                }
            }
            catch (Exception exc)
            {
                Animation.showMessage(exc.Message, "error");
            }
        }
    }
}
