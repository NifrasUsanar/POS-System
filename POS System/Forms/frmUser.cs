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
    public partial class frmUser : Form
    {

        User user = new User();
        Validation validation = new Validation();
        DataGridView dataGrid;
        bool is_new = true;

        public frmUser(DataGridView dataGrid, bool is_new = true)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
            this.is_new = is_new;
        }
     
        private void btnsave_Click(object sender, EventArgs e)
        {
            user.user_username = txtUserName.Text;
            user.user_pw = txtPassword.Text;
            user.user_role = cmbRole.SelectedValue.ToString();
            user.user_question = cmbQuestion.Text;
            user.user_answer = txtAnswer.Text;
            user.user_email = txtEmail.Text;
            user.user_contact = txtContact.Text;
            user.user_nic = txtNIC.Text;
            user.is_active = toggleActive.Checked;
            user.user_name = txtName.Text;

            if (is_new && user.insert_user())
            {
                MessageBox.Show("User Added");
                this.Close();
            }
            else if (user.update_user())
            {
                MessageBox.Show("User Updated");
                this.Close();
            }
            dataGrid.DataSource = user.viewUser();
        }
     
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUser_Shown(object sender, EventArgs e)
        {
            cmbRole.DataSource = new UserRole().viewUserRole();
            cmbRole.ValueMember = "id";
            cmbRole.DisplayMember = "role";

            cmbRole.SelectedIndex = 1;
            cmbQuestion.SelectedIndex = 0;

            if (!is_new)
            {
                user.user_id = int.Parse(dataGrid.SelectedRows[0].Cells["userid"].Value.ToString());
                Global.dTable = user.findUser(user.user_id);

                //Get Data from Database and set them to the form controls
                txtUserName.Text = Global.dTable.Rows[0]["user_username"].ToString();
                cmbQuestion.Text = Global.dTable.Rows[0]["user_question"].ToString();
                txtAnswer.Text = Global.dTable.Rows[0]["user_answer"].ToString();
                txtEmail.Text = Global.dTable.Rows[0]["email"].ToString();
                txtContact.Text = Global.dTable.Rows[0]["contact"].ToString();
                txtNIC.Text = Global.dTable.Rows[0]["nic"].ToString();
                txtPassword.Text = Global.dTable.Rows[0]["user_password"].ToString();
                txtName.Text = Global.dTable.Rows[0]["user_name"].ToString();

                toggleActive.Checked = bool.Parse(Global.dTable.Rows[0]["is_active"].ToString());
            }
        }
    }
}
