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
    public partial class ucExpences : UserControl
    {
        Expences expences = new Expences();
        
        public ucExpences()
        {
            InitializeComponent();

            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddDays(-30);
        }

        void loadExpenses()
        {
            dgvExpences.DataSource = expences.viewexpences(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));

            txtSearch.ResetText();
            sumTotalofGridview();
        }

        void sumTotalofGridview()
        {
            DataTable dTable = (dgvExpences.DataSource as DataTable).DefaultView.ToTable();

            if (dTable.Rows.Count > 0)
            {
                chipTotal.Text = $"Rs. {dTable.Compute("SUM(amount)","True"):F2}";
            }
            else chipTotal.Text = "Rs. 0.00";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmExpences(dgvExpences));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmExpences(dgvExpences, false));
        }

        private void usExpences_Load(object sender, EventArgs e)
        {
            loadExpenses();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadExpenses();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvExpences.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("discription LIKE '{0}%'", txtSearch.Text);

            sumTotalofGridview();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            (dgvExpences.DataSource as DataTable).DefaultView.RowFilter = string.Empty;
            txtSearch.ResetText();
        }

        private void dgvExpences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {        
            if (dgvExpences.Columns[e.ColumnIndex].Name == "cellDesc")
            {            
                //int expID = int.Parse(dgvExpences.SelectedRows[0].Cells["cellID"].Value.ToString());
                frmExpences expense = new frmExpences(dgvExpences,false);
                Animation.showModal(expense);
            }
            else if (dgvExpences.Columns[e.ColumnIndex].Name == "cellRemove")
            {
                int expID = int.Parse(dgvExpences.SelectedRows[0].Cells["cellID"].Value.ToString());

                DialogResult result = MessageBox.Show("Do you really want to delete this bill?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && expences.deleteExpences(expID))
                {
                    dgvExpences.Rows.RemoveAt(dgvExpences.SelectedRows[0].Index);
                    sumTotalofGridview();
                }
            }
        }
    }
}


