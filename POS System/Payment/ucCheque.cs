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
    public partial class ucCheque : UserControl
    {
        public ucCheque()
        {
            InitializeComponent();

            dtpEnd.Value =  DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddDays(-60);
        }

        Payment customerCheque = new Payment(false);
        Payment myCheque = new Payment(true);

        void sumTotal()
        {
            DataTable dTable = (dgvCheque.DataSource as DataTable).DefaultView.ToTable();

            if (dTable.Rows.Count > 0) chipTotal.Text = $"Rs. {dTable.Compute("SUM(amount)", "True"):N2}";
            else chipTotal.Text = "Rs. 0.00";
        }

        void filterByDate()
        {
            if (cmbChequeMode.SelectedIndex == 0)
            {
                dgvCheque.Columns["cellPeople"].HeaderText = "Customer";
                dgvCheque.DataSource = customerCheque.viewCheque(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
            }
            else
            {
                dgvCheque.Columns["cellPeople"].HeaderText = "Vendor";
                dgvCheque.DataSource = myCheque.viewCheque(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
            }

            sumTotal();
        }

        void loadCheque()
        {
            if (cmbChequeMode.SelectedIndex == 0)
            {
                dgvCheque.Columns["cellPeople"].HeaderText = "Customer";
                txtSearch.PlaceholderText = "Cheque No or Owner name";
                dgvCheque.DataSource = customerCheque.viewCheque("", "");
            }
            else
            {
                dgvCheque.Columns["cellPeople"].HeaderText = "Vendor";
                dgvCheque.DataSource = myCheque.viewCheque("", "");
                txtSearch.PlaceholderText = "Cheque No or Vendor name";
            }

            txtSearch.ResetText();
            cmbStatus.SelectedIndex = 0;
            sumTotal();
        }

        void filterCheque()
        {
            string status;

            if (cmbStatus.Text == "All") status = "";
            else status = cmbStatus.Text;

            (dgvCheque.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(cheque_no LIKE '{0}%' OR bankname LIKE '{0}%' OR name LIKE '{0}%') AND (cheque_status LIKE '{1}%')", txtSearch.Text, status);

            sumTotal();
        }

        private void ucCheque_Load(object sender, EventArgs e)
        {
            loadCheque();
        }

        private void dgvCheque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCheque.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                frmCheque cheque;
                if (cmbChequeMode.SelectedIndex==0) cheque = new frmCheque();
                else cheque = new frmCheque(true);

                cheque.paymentID = dgvCheque.SelectedRows[0].Cells["id"].Value.ToString();
                cheque.dGrid = dgvCheque;

                Animation.showModal(cheque);
            }
            else if (dgvCheque.Columns[e.ColumnIndex].Name == "cellPeople")
            {
                string peopleID = dgvCheque.SelectedRows[0].Cells["cellPeopleID"].Value.ToString();
                string peopleName = dgvCheque.SelectedRows[0].Cells["cellPeople"].Value.ToString();

                bool is_supplier = false;

                if (cmbChequeMode.SelectedIndex == 1) is_supplier = true;
                Animation.showSideModal(new frmPeopleDetail(peopleID, peopleName, is_supplier));
            }
            else if (dgvCheque.Columns[e.ColumnIndex].Name == "cellRemove")
            {
                string peopleID = dgvCheque.SelectedRows[0].Cells["cellPeopleID"].Value.ToString();
                string paymentID=dgvCheque.SelectedRows[0].Cells["id"].Value.ToString();
                string amount = dgvCheque.SelectedRows[0].Cells["cellAmount"].Value.ToString();
                string is_partyCheque = dgvCheque.SelectedRows[0].Cells["cellIsParty"].Value.ToString();
                string status = dgvCheque.SelectedRows[0].Cells["cellStatus"].Value.ToString();

                if (status.Trim() != "Cancelled" && status.Trim()!="Pending")
                {
                    Animation.showMessage("Only Pending or Cancelled Cheque Can be removed", "error");
                }
                else if (Convert.ToBoolean(is_partyCheque) == true)
                {
                    Animation.showMessage("Please Remove Party Cheque First!...", "error");
                }
                else
                {
                    bool is_supplier = false;
                    if (cmbChequeMode.SelectedIndex == 1) is_supplier = true;

                    DialogResult result = MessageBox.Show("Do you really want to delete this payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes && new Payment(is_supplier).removePayment(paymentID, amount, peopleID))
                    {
                        dgvCheque.Rows.RemoveAt(dgvCheque.SelectedRows[0].Index);

                    }
                }

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterCheque();
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterCheque();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterByDate();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCheque();
        }

        private void cmbChequeMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            loadCheque();
        }
    }
}
