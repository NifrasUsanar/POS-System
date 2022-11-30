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
    public partial class ucPeople : UserControl
    {
        People people = new People();

        public ucPeople()
        {
            InitializeComponent();
        }

        void sumTotal()
        {
                DataTable dTable = (dgvPeople.DataSource as DataTable).DefaultView.ToTable();

                if (dTable.Rows.Count > 0)
                {
                    decimal outstanding = Convert.ToDecimal(dTable.Compute("SUM(balance)", "True").ToString());
                    if (outstanding > 0) chipOutstanding.FillColor = Color.SeaGreen;
                    else if (outstanding < 0) chipOutstanding.FillColor = Color.Crimson;

                    chipOutstanding.Text = "Rs. "+outstanding.ToString("N2");
                    
                    chipCount.Text = $"{dTable.Compute("COUNT(people_id)", "True")}";
                }
                else
                {
                    chipOutstanding.Text = "Rs. 0.00";
                    chipCount.Text = "0";
                }
        }

        void filterPeople()
        {
            string filterQRY="";

            if (cmbStatus.Text == "Name") filterQRY = $"(name LIKE '%{txtSearch.Text.Trim()}%')";
            else if (cmbStatus.Text == "City") filterQRY = $"(city LIKE '%{txtSearch.Text.Trim()}%')";
            else if (cmbStatus.Text == "Contact") filterQRY = $"(contact_no LIKE '%{txtSearch.Text.Trim()}%')";

            if ((dgvPeople.DataSource as DataTable) != null)
            {
                (dgvPeople.DataSource as DataTable).DefaultView.RowFilter = filterQRY;
            }

            sumTotal();
        }

        private void ucPeople_Load(object sender, EventArgs e)
        {
            dgvPeople.DataSource=people.viewPeople();
            //if (is_supplier) dgvPeople.Columns["cellBalance"].HeaderText = "";
            sumTotal();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Animation.showModal(new frmPeople(dgvStock,true,is_supplier));
            new frmPeople("0",people.is_supplier).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string peopleID = dgvPeople.SelectedRows[0].Cells["people_id"].Value.ToString();
            Animation.showModal(new frmPeople(peopleID, people.is_supplier));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //dgvPeople.DataSource = people.filterPeople(txtSearch.Text, cmbStatus.Text, people.is_supplier);
            filterPeople();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string peopleID = dgvPeople.SelectedRows[0].Cells["people_id"].Value.ToString();

            if (e.ColumnIndex == dgvPeople.Columns["cellAccount"].Index)
            {
                string name = dgvPeople.SelectedRows[0].Cells["cellName"].Value.ToString();
                Animation.showSideModal(new frmPeopleDetail(peopleID, name, people.is_supplier));
            }
            
            else if(e.ColumnIndex == dgvPeople.Columns["cellPayment"].Index)
            {
                var result = Animation.resultModal(new frmPayment(0,0,Convert.ToInt32(peopleID),0, people.is_supplier, true));

                if (result != DialogResult.Cancel)
                {
                    //dgvPeople.DataSource = new Purchase().viewPurchaseHistory();
                }
            }
            else if (e.ColumnIndex == dgvPeople.Columns["cellName"].Index)
            {
                Animation.showModal(new frmPeople(peopleID, people.is_supplier));
            }
            else if (e.ColumnIndex == dgvPeople.Columns["cellBalance"].Index)
            {
                string balance = dgvPeople.SelectedRows[0].Cells["cellBalance"].Value.ToString();
                Animation.showModal(new frmAdjustPeopleBalance(balance, peopleID));
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPeople.DataSource = people.viewPeople();
            sumTotal();
        }

        private void dgvPeople_DataSourceChanged(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow Myrow in dgvPeople.Rows)
            //{            //Here 2 cell is target value and 1 cell is Volume
            //    if (Convert.ToInt32(Myrow.Cells["cellBalance"].Value) < 0)// Or your condition 
            //    {
            //        Myrow.DefaultCellStyle.BackColor = Color.Crimson;
            //    }
            //    else
            //    {
            //        //Myrow.DefaultCellStyle.BackColor = Color.Green;
            //    }
            //}
        }

        private void dgvPeople_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (Convert.ToInt32(dgvPeople.Rows[e.RowIndex].Cells["cellBalance"].Value) < 0)// Or your condition 
            {
                dgvPeople.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Crimson;
                dgvPeople.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.IndianRed;

                //dgvPeople.Rows[e.RowIndex].Cells["cellBalance"].Style.BackColor= dgvPeople.Rows[e.RowIndex].Cells["cellBalance"].Style.SelectionBackColor = Color.Crimson;

                dgvPeople.Rows[e.RowIndex].Cells["cellBalance"].Style.ForeColor= dgvPeople.Rows[e.RowIndex].Cells["cellBalance"].Style.SelectionForeColor = Color.White;
                //dgvPeople.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                //dgvPeople.Rows[e.RowIndex]. = Color.White;
            }
        }

        private void cmbPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPeople.SelectedIndex == 0) people.is_supplier = false;
            else people.is_supplier = true;

            dgvPeople.DataSource = people.viewPeople();
            sumTotal();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterPeople();
        }
    }
}
