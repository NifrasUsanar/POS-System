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
    public partial class frmStockHistory : Form
    {
        public frmStockHistory()
        {
            InitializeComponent();
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now.AddMonths(-1);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = new Stock().viewStockHistory(Validation.convertDate(dtpStart),Validation.convertDate(dtpEnd));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            switch(cmbSearchMode.Text)
            {
                case "Item Name": query = $"itm_name LIKE '{txtSearch.Text.Trim()}%'"; break;
                case "Code No": query = $"Convert(itm_code, 'System.String') LIKE '{txtSearch.Text.Trim()}%'"; break;
                case "Description": query = $"description LIKE '{txtSearch.Text.Trim()}%'"; break;
            }
            (dgvStock.DataSource as DataTable).DefaultView.RowFilter = query;
        }
    }
}
