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
    public partial class frmViewCheque : Form
    {
        public frmViewCheque(int peopleID, bool is_supplier, bool selectCheque=false)
        {
            InitializeComponent();

            payment = new Payment(is_supplier);
            payment.peopleID = peopleID;

            DateTime now = DateTime.Now;
            dtpStart.Value = new DateTime(now.Year, now.Month, 1);
            dtpEnd.Value = dtpStart.Value.AddMonths(1).AddDays(-1);

            if (selectCheque) dgvCheque.Columns["btnSelect"].Visible = true;
        }

        Payment payment;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewCheque_Shown(object sender, EventArgs e)
        {
            //People people = (People)this.Tag;
            //MessageBox.Show(people.id.ToString());

            //Show All Pending and Return Cheque
            dgvCheque.DataSource=payment.viewCheque("","",payment.peopleID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvCheque.DataSource = payment.viewCheque(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd), payment.peopleID);
        }

        void filterCheque()
        {
            string status;

            if (cmbStatus.Text == "All") status = "";
            else status = cmbStatus.Text;

            (dgvCheque.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("(cheque_no LIKE '{0}%' OR bankname LIKE '{0}%') AND (cheque_status LIKE '{1}%')", txtSearch.Text, status);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterCheque();
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterCheque();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCheque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvCheque.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                frmCheque cheque = new frmCheque(payment.is_supplier);
                cheque.paymentID = dgvCheque.SelectedRows[0].Cells["id"].Value.ToString();
                cheque.dGrid = dgvCheque;

                Animation.showModal(cheque);
            }
            else if (dgvCheque.Columns[e.ColumnIndex].Name == "btnSelect")
            {
                string paymentID = dgvCheque.SelectedRows[0].Cells["id"].Value.ToString();

                bool partyCheque = bool.Parse(dgvCheque.SelectedRows[0].Cells["cellParty"].Value.ToString());
                string chequeStatus = dgvCheque.SelectedRows[0].Cells["cellStatus"].Value.ToString();

                if (!partyCheque && chequeStatus=="Pending")
                {
                    Control ctrlButton = (Control)this.Tag;
                    ctrlButton.Tag = ((DataRowView)dgvCheque.SelectedRows[0].DataBoundItem).Row;
                    ctrlButton.Text = dgvCheque.SelectedRows[0].Cells["cellPeople"].Value.ToString();
                    this.Close();
                }

                if(chequeStatus!="Pending")
                {
                    MessageBox.Show("Only Pending Cheque Can be selected");
                }
            }
        }
    }
}
