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
using Guna.UI2.WinForms;

namespace POS_System
{
    public partial class frmBanktransfer : Form
    {
        Banktransfer banktransfer = new Banktransfer();
        BankAccount bank = new BankAccount();
        DataGridView dgvBank;
        bool is_new;

        public frmBanktransfer(DataGridView dgvBank, bool is_new = true)
        {
            InitializeComponent();
            Global.changeTabControlStyle(tabControl1);
            this.dgvBank = dgvBank;
            this.is_new = is_new;
            Global.changeTabControlStyle(tabControl1);
            Validation.numbersOnly(txtAmount);

            dtpDate.Value = DateTime.Now;
        }

        bool validationCheck()
        {
            if (txtAmount.Text.Trim() == "") txtAmount.Text = "0";

            if (Convert.ToDecimal(txtAmount.Text.Trim()) <= 0)
            {
                MessageBox.Show("Amount cannot be 0 or Incorrect");
                return false;
            }
            else return true;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmBanktransfer_Shown(object sender, EventArgs e)
        {
            
            if (!is_new)
            {
                banktransfer.bank_id = int.Parse(dgvBank.SelectedRows[0].Cells["bank_id"].Value.ToString());

                DataTable dTable = banktransfer.Banktransfer_details();

                //Get Data from Database and set them to the form controls
                lblBankName.Text = dTable.Rows[0]["bank_name"].ToString();
                lblAccountNo.Text = dTable.Rows[0]["account_no"].ToString();
            }

            dgvBankTransfer.DataSource = banktransfer.viewBanktransfer();
            
        }

        private void frmBanktransfer_Load(object sender, EventArgs e)
        {
            dgvBankTransfer.DataSource = banktransfer.viewBanktransfer();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (validationCheck())
            {
                banktransfer.amount = decimal.Parse(txtAmount.Text);
                banktransfer.description = txtDescription.Text;
                banktransfer.transactionDate = Validation.convertDate(dtpDate);
                banktransfer.transactionType = "Deposit";

                if (toggleCheque.Checked == false) banktransfer.refrenceID = "0";

                if (banktransfer.insertBankTransaction())
                {
                    Animation.showMessage("Saved Successfully", "success");
                    dgvBankTransfer.DataSource = banktransfer.viewBanktransfer();
                    dgvBank.DataSource = bank.viewbank();

                    toggleCheque.Checked = false;
                }
            } 
        }

        private void btnWihtdrawal_Click(object sender, EventArgs e)
        {
            if (validationCheck())
            {
                banktransfer.amount = -1 * decimal.Parse(txtAmount.Text);
                banktransfer.description = txtDescription.Text;
                banktransfer.transactionDate = Validation.convertDate(dtpDate);
                banktransfer.transactionType = "Withdrawal";

                if (toggleCheque.Checked == false) banktransfer.refrenceID = "0";

                if (banktransfer.insertBankTransaction())
                {
                    Animation.showMessage("Saved Successfully", "success");
                    dgvBankTransfer.DataSource = banktransfer.viewBanktransfer();
                    dgvBank.DataSource = bank.viewbank();

                    toggleCheque.Checked = false;
                }
            }
        }

        private void dgvBankTransfer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == dgvBankTransfer.Columns["cellDelete"].Index)
            {
                DialogResult result = MessageBox.Show("Do you really want to remove the record", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                decimal amount = decimal.Parse(dgvBankTransfer.SelectedRows[0].Cells["cellAmount"].Value.ToString());
                int trasactionID = int.Parse(dgvBankTransfer.SelectedRows[0].Cells["cellTransactionID"].Value.ToString());
                string referenceID = dgvBankTransfer.SelectedRows[0].Cells["cellReference"].Value.ToString();

                if(referenceID!="0" && amount<0)
                {
                    MessageBox.Show("Cheque Transaction cannot be removed");
                }
                else if (result == DialogResult.Yes)
                {
                    if (banktransfer.deleteTransaction(banktransfer.bank_id, amount,trasactionID,referenceID))
                    {
                        dgvBankTransfer.Rows.RemoveAt(dgvBankTransfer.SelectedRows[0].Index);
                    }
                }
            }
        }

        private void btnCheque_Click(object sender, EventArgs e)
        {
            new frmViewCheque(0, false, true) { TopMost = true, Tag = btnCheque }.ShowDialog();
        }

        private void btnCheque_TextChanged(object sender, EventArgs e)
        {
            DataRow row = btnCheque.Tag as DataRow;
            if (row != null)
            {
                txtAmount.Text = row["amount"].ToString();
                banktransfer.refrenceID = row["payment_id"].ToString();
            }
        }

        private void toggleCheque_CheckedChanged(object sender, EventArgs e)
        {
            btnCheque.Text = "select your cheque";
            btnCheque.Tag = "0";
            txtAmount.Text = "0";

            if(toggleCheque.Checked)
            {
                btnCheque.Enabled = true;
                btnWihtdrawal.Enabled = false;
                txtAmount.ReadOnly = true;
                txtDescription.Text = "Cheque Deposit";
            }
            else
            {
                btnCheque.Enabled = false;
                btnWihtdrawal.Enabled = true;
                txtAmount.ReadOnly = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
