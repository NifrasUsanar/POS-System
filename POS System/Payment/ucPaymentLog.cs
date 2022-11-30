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
    public partial class ucPaymentLog : UserControl
    {
        People people = new People();
        public ucPaymentLog(int peopleID=0, bool is_supplier=false, string peopleName="")
        {
            InitializeComponent();

            dtpStart.Value = dtpEnd.Value = DateTime.Now;

            people.id = peopleID.ToString();
            people.is_supplier = is_supplier;
            txtSearch.Text = peopleName;
        }

        void viewPaymentLog()
        {
            if (cmbPeople.SelectedIndex == 0) dgvPayment.DataSource = new Payment(is_supplier: false).viewPaymentLog(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd),people.id);

            else dgvPayment.DataSource = new Payment(is_supplier: true).viewPaymentLog(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd),people.id);

            sumTotal();
        }

        void sumTotal()
        {
            DataTable dTable = (dgvPayment.DataSource as DataTable).DefaultView.ToTable();

            if (dTable.Rows.Count > 0) chipTotal.Text = $"Rs. {dTable.Compute("SUM(amount)", "True"):N2}";
            else chipTotal.Text = "Rs. 0.00";
        }

        void filterPayment()
        {
            string status;

            if (cmbPaymentType.Text == "All") status = "";
            else status = cmbPaymentType.Text;

            if ((dgvPayment.DataSource as DataTable) != null)
            {
                (dgvPayment.DataSource as DataTable).DefaultView.RowFilter =
                    string.Format("(name LIKE '{0}%') AND (payment_type LIKE '{1}%')", txtSearch.Text, status);
            }
            sumTotal();
        }

        private void ucPaymentLog_Load(object sender, EventArgs e)
        {
            if (!Global.is_admin) cellDelete.Visible = false;

            //Show User Control as Form and Check whether is he Customer or Vendor
            if (people.id!="0")
            {
                txtSearch.ReadOnly = true;

                if (people.is_supplier) cmbPeople.Text = "Vendor";
                else cmbPeople.Text = "Customer";

                dgvPayment.Columns["cellPeople"].HeaderText = cmbPeople.Text;
                cmbPeople.Enabled = false;
            }

            viewPaymentLog();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewPaymentLog();
        }

        private void cmbPeople_SelectionChangeCommitted(object sender, EventArgs e)
        {
            viewPaymentLog();
            dgvPayment.Columns["cellPeople"].HeaderText = cmbPeople.Text;
        }

        private void cmbPaymentType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterPayment();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (people.id == "0") filterPayment();
        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool is_supplier;
            if (cmbPeople.SelectedIndex == 0) is_supplier=false;
            else is_supplier=true;

            string peopleID = dgvPayment.SelectedRows[0].Cells["cellPeopleID"].Value.ToString();

            if (dgvPayment.Columns[e.ColumnIndex].Name == "cellDelete")
            {
                string paymentID = dgvPayment.SelectedRows[0].Cells["cellPaymentID"].Value.ToString();
                string amount = dgvPayment.SelectedRows[0].Cells["cellAmount"].Value.ToString();
                string paymentType = dgvPayment.SelectedRows[0].Cells["cellPaymentType"].Value.ToString();

                if (paymentType == "Cheque")
                {
                    Animation.showMessage("Cheque Cannot Removed from Here... Please choose Cheque Section", "error");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you really want to delete this payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes && new Payment(is_supplier).removePayment(paymentID, amount, peopleID))
                    {
                        dgvPayment.Rows.RemoveAt(dgvPayment.SelectedRows[0].Index);

                    }
                }
            }
            else if (dgvPayment.Columns[e.ColumnIndex].Name == "cellPeople")
            {
                string name = dgvPayment.SelectedRows[0].Cells["cellPeople"].Value.ToString();

                Animation.showSideModal(new frmPeopleDetail(peopleID, name, is_supplier));
            }
        }
    }
}
