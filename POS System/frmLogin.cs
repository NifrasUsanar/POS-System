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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this); 
            guna2ShadowForm1.SetShadowForm(this);
            txtUserName.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.Trim())) Animation.showMessage("Password Required","error");
            else if(string.IsNullOrEmpty(txtUserName.Text.Trim())) Animation.showMessage("User Name Required", "error");
            else
            {
                UserAuthentication login = new UserAuthentication();
                login.username = txtUserName.Text.Replace("'", "''").Trim(); ;
                login.passsword = txtPassword.Text;

                if(login.login())
                {
                    this.Hide();
                    new frmApplication().Show();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) txtPassword.Focus();
        }

        private void linkForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmForgetPassword().ShowDialog();
        }

        private void picSetting_Click(object sender, EventArgs e)
        {
            new frmBackup() { TopMost = true, StartPosition=FormStartPosition.CenterScreen}.ShowDialog();
        }
    }
}
