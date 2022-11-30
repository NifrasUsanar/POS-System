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
    public partial class ucUser : UserControl
    {
        User user = new User();
        public ucUser()
        {
            InitializeComponent();

            Global.changeTabControlStyle(tabControl);
            dtpEnd.Value = dtpStart.Value = DateTime.Now;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmUser(dgvUser));
        }

      

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUser.Columns[e.ColumnIndex].Name == "Edit")
            {
                Animation.showModal(new frmUser(dgvUser,false));
            }

            if (dgvUser.Columns[e.ColumnIndex].Name == "Delete")
            {
                MessageBox.Show("Under Developing...");
            }
        }

     
        private void ucUser_Load(object sender, EventArgs e)
        {
            dgvUser.DataSource = new User().viewUser();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmUser(dgvUser, false));
        }

        private void btnUserRole_Click(object sender, EventArgs e)
        {
            Animation.changeContentOnly(new ucUserRoles());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageUser;
        }

        private void btnUserLog_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageLog;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvUserLog.DataSource=new UserAuthentication().viewUserLog(Validation.convertDate(dtpStart),Validation.convertDate(dtpEnd));
        }
    }
}
