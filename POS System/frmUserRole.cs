using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace POS_System
{
    public partial class frmUserRole : Form
    {
        UserRole userrole = new UserRole();
        bool is_new;
        DataGridView dataGrid;
        int id;

        public frmUserRole(DataGridView dataGrid=null,bool is_new=true)
        {
            InitializeComponent();
            this.is_new = is_new;
            this.dataGrid = dataGrid; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> permissions = new List<string>();

                foreach (var ctrl in gbPermission.Controls)
                {
                    var toggle = ctrl as Guna2ToggleSwitch;
                    if (toggle != null)
                    {
                        if (toggle.Tag.ToString().Trim() != "")
                        {
                            if (toggle.Checked)
                            {
                                permissions.Add(toggle.Tag.ToString());
                            }
                        }
                    }
                }

                userrole.role = txtUserRole.Text;
                userrole.permission = string.Join(",", permissions);

                if (is_new) userrole.insertRole();
                else userrole.updateUserRole(id);

                dataGrid.DataSource = userrole.viewUserRole();
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void frmUserRole_Shown(object sender, EventArgs e)
        {

            if (!is_new)
            {
                id = int.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());

                Global.dTable = userrole.findUserRole(id);

                string permissions = Global.dTable.Rows[0]["permission"].ToString();
                txtUserRole.Text = Global.dTable.Rows[0]["role"].ToString();

                string[] permissionList = permissions.Split(',');

                foreach (string permission in permissionList)
                {
                    foreach (var ctrl in gbPermission.Controls)
                    {
                        var toggle = ctrl as Guna2ToggleSwitch;
                        if (toggle != null)
                        {
                            if (toggle.Tag.ToString().Trim() == permission)
                            {
                                toggle.Checked = true;
                            }
                        }
                    }
                }
            } 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
