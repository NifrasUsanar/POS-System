using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class ucUserRoles : UserControl
    {
        public ucUserRoles()
        {
            InitializeComponent();
        }

        private void ucUserRoles_Load(object sender, EventArgs e)
        {
            dgvUserRole.DataSource = new UserRole().viewUserRole();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmUserRole(dgvUserRole));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUserRole.SelectedRows[0].Cells[0].Value.ToString() != "1")
            {
                if (dgvUserRole.SelectedRows.Count > 0) Animation.showModal(new frmUserRole(dgvUserRole, false));
            }
            else
            {
                Animation.showMessage("The Admin Role Cannot be modified","info");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Animation.changeContentOnly(new ucUser());
        }
    }
}
