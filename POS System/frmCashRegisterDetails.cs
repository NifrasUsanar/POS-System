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
    public partial class frmCashRegisterDetails : Form
    {
        public frmCashRegisterDetails()
        {
            InitializeComponent();

            //Validation.numbersOnly(txtOpenCash);
            Validation.numbersOnly(txtOpening);
        }


        DateTime registerOpenedAt;
        string cashInHand, openCash;
        DataTable dTableCashRegister = new DataTable();
        CashRegister register = new CashRegister();
        RegisterTransaction registerTransaction = new RegisterTransaction();

        void drawerTransaction(bool is_cashin)
        {
            if (txtAmount.Text.Trim() == "") txtAmount.Text = "0";

            decimal amount = decimal.Parse(txtAmount.Text.Trim());

            if (amount == 0)
            {
                MessageBox.Show("Amount Cannot be Zero");
                txtAmount.Focus();
            }
            else if (txtDescription.Text.Trim() == "")
            {
                MessageBox.Show("Please Fill Description");
                txtDescription.Focus();
            }
            else
            {
                if (!is_cashin) registerTransaction.amount = -1 * amount;
                else registerTransaction.amount = amount;

                registerTransaction.description = txtDescription.Text.Trim();
                registerTransaction.registerID = Global.registerID;

                if (registerTransaction.insertTransaction())
                {
                    if (is_cashin) MessageBox.Show("Cash in");
                    else MessageBox.Show("Cash out");

                    loadCashRegister();
                }
            }
        }

        void loadCashRegister()
        {
            DataTable dTableRegister = register.cashRegisterDetails(Global.registerID);

            registerOpenedAt = DateTime.Parse(dTableRegister.Rows[0]["created_at"].ToString());
            string createdBy = dTableRegister.Rows[0]["user_name"].ToString();

            lblRegisterDetails.Text = $"Register Opened at: ({registerOpenedAt.ToString("ddd, dd MMM yyy")} @ {registerOpenedAt.ToString("hh:mm tt")} by {createdBy})";

            cashInHand = dTableRegister.Rows[0]["cash_in_hand"].ToString();
            openCash = dTableRegister.Rows[0]["open_cash"].ToString();

            txtOpening.Text = openCash;
            txtCashinHand.Text = cashInHand;

            btnRegisterClose.Enabled = true;

            if (Global.is_admin) cmbCashRegister.Enabled = true;

            dgvRegister.DataSource = registerTransaction.viewRegisterTransaction(Global.registerID,registerOpenedAt.ToString("yyyy-MM-dd HH:mm:ss"), DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
        }

        private void btnCashIn_Click(object sender, EventArgs e)
        {
            drawerTransaction(true);
        }

        private void btnCashOut_Click(object sender, EventArgs e)
        {
            drawerTransaction(false);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCashRegisterDetails_Shown(object sender, EventArgs e)
        {
            loadCashRegister();
        }

        private void btnRegisterClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close the register", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                register.openedAt = registerOpenedAt.ToString("yyyy-MM-dd hh:mm");
                register.open_cash = openCash;
                register.cash_in_hand = cashInHand;
                register.open_cheque = "0";
                register.cheque_in_hand = "0";
                register.note = txtNote.Text.Trim();

                if (register.closeRegister(Global.registerID))
                {
                    Global.registerID = 0;
                    this.Close();
                }
            }

        }
    }
}
