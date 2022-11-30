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
    public partial class frmProfile : Form
    {
        User user = new User();
        Validation validation = new Validation();
        //bool is_new = true;

        public frmProfile()
        {
            InitializeComponent();
        }

        private void profile_Shown(object sender, EventArgs e)
        {
            DataTable dTable = user.findUser(Global.userid);
            cmbQuestion.SelectedIndex = 1;

            //Get Data from Database and set them to the form controls
            txtName.Text = dTable.Rows[0]["user_name"].ToString();
            cmbQuestion.Text = dTable.Rows[0]["user_question"].ToString();
            txtAnswer.Text = dTable.Rows[0]["user_answer"].ToString();
            txtEmail.Text = dTable.Rows[0]["email"].ToString();
            txtContact.Text = dTable.Rows[0]["contact"].ToString();
            txtNIC.Text = dTable.Rows[0]["nic"].ToString();

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;

            foreach (TabPage tab in tabControl1.TabPages)
            {
                tab.Text = "";
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.user_name = txtName.Text;
            user.user_question = cmbQuestion.Text;
            user.user_answer = txtAnswer.Text;
            user.user_email = txtEmail.Text;
            user.user_contact = txtContact.Text;
            user.user_nic = txtNIC.Text;

            if (user.updateProfile(Global.userid))
            {
                MessageBox.Show("Successfully Updated");
                Global.welcomeMessage = Global.lblWelcome.Text = ("Welcome to POS! " + Global.loggedUserName).ToUpper();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            //Check new password and current password is correct
            if(txtPassword.Text.Trim() != txtConfirm.Text.Trim())
            {
                Animation.showMessage("Your Confirm password is not matching","error");
            }
            else
            {
                if(user.checkPassword(Global.userid,txtCurrentPassword.Text))
                {
                    if (user.updatePassword(txtConfirm.Text,Global.userid)) Animation.showMessage("Password Updated", "success");
                    else Animation.showMessage("Failed to Update","error");
                }
                else Animation.showMessage("Your Current Password is Incorrect","error");  
            }
        }

        private void btnCurrentPasswordShow_Click(object sender, EventArgs e)
        {
            if (btnCurrentPasswordShow.Checked) txtCurrentPassword.UseSystemPasswordChar = false;
            else txtCurrentPassword.UseSystemPasswordChar = true;
        }

        private void btnConfirmPasssword_Click(object sender, EventArgs e)
        {
            if (btnConfirmPasssword.Checked) txtConfirm.UseSystemPasswordChar = false;
            else txtConfirm.UseSystemPasswordChar = true;
        }
    }
}
