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
    public partial class frmClientView : Form
    {
        //The control to set text and ID
        public Control ctrl { get; set; }
        bool is_supplier;

        public frmClientView(bool is_supplier=true)
        {
            InitializeComponent();
            this.is_supplier = is_supplier;
        }

        private void guna2CircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmClientView_Shown(object sender, EventArgs e)
        {
            dgvPeople.DataSource = new People().showPeopleName(is_supplier);
        }

        private void dgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ctrl.Tag = dgvPeople.SelectedRows[0].Cells[0].Value.ToString();
            ctrl.Text = dgvPeople.SelectedRows[0].Cells[1].Value.ToString();
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvPeople.DataSource as DataTable).DefaultView.RowFilter =
            string.Format("name LIKE '{0}%' OR name LIKE '% {0}%'", txtSearch.Text);
        }
    }
}
