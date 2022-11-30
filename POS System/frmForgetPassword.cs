using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        UserAuthentication authentication = new UserAuthentication();

        private void frmForgetPassword_Load(object sender, EventArgs e)
        {
            //tabResetWizard.Appearance = TabAppearance.FlatButtons; tabResetWizard.ItemSize = new Size(0, 1); tabResetWizard.SizeMode = TabSizeMode.Fixed;

            guna2ShadowForm1.SetShadowForm(this);
            tabResetWizard.Appearance = TabAppearance.FlatButtons;
            tabResetWizard.ItemSize = new Size(0, 1);
            tabResetWizard.SizeMode = TabSizeMode.Fixed;


        }

        private void btnCheckUserName_Click(object sender, EventArgs e)
        {
            Global.dTable = authentication.checkUserName(txtUserName.Text.Trim());
            if (Global.dTable.Rows.Count > 0)
            {
                trsnWizard.HideSync(tabResetWizard);
                tabResetWizard.SelectedTab = tabAnswer;
                trsnWizard.ShowSync(tabResetWizard);
                txtAnswer.Focus();
            }
            else
            {
                Animation.showMessage("User is not found", "error");
                txtUserName.Focus();
                txtUserName.SelectAll();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            string answer = Global.dTable.Rows[0]["user_answer"].ToString();

            if (txtAnswer.Text.Trim().ToLower() == answer.ToLower())
            {
                trsnWizard.HideSync(tabResetWizard);
                tabResetWizard.SelectedTab = tabReset;
                trsnWizard.ShowSync(tabResetWizard);
                txtNewPassword.Focus();
            }
            else Animation.showMessage("Incorrect Answer!... Try Again","error");
        }

        private void tabResetWizard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Global.dTable.Rows.Count < 0) tabResetWizard.SelectedTab = tabCheckUserName;
            else if (tabResetWizard.SelectedTab == tabAnswer)
            {
                txtQuestion.Text = Global.dTable.Rows[0]["user_question"].ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Trim() == "" || txtConfirmPassword.Text.Trim() == "") Animation.showMessage("Please Fill Required Fields","error");

            else if (txtNewPassword.Text.Trim() == txtConfirmPassword.Text.Trim())
            {
                if (!authentication.resetPassword(txtConfirmPassword.Text.Trim(), txtUserName.Text.Trim()))
                {
                    Animation.showMessage("Failed to Reset", "error");
                }
                else
                {
                    Animation.showMessage("Your Password Reset Successfully", "success");
                    this.Close();
                }
            }
            else Animation.showMessage("Password Mismatch", "error");
        }

        private void btnConfirmPasssword_Click(object sender, EventArgs e)
        {
            if (btnConfirmPasssword.Checked) txtConfirmPassword.UseSystemPasswordChar = false;
            else txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnCheckUserName.PerformClick();
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnAnswer.PerformClick();
        }

        private void txtNewPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtConfirmPassword.Focus();
        }

        private void txtConfirmPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnReset.PerformClick();
        }
    }
}
