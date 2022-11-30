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
    public partial class frmViewModal : Form
    {
        public frmViewModal(string formTitle)
        {
            InitializeComponent();

            guna2Chip1.Text = formTitle;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmViewPayment_Shown(object sender, EventArgs e)
        {
            Global.frmViewModal = this;
            UserControl userControl = (UserControl)this.Tag;
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(userControl);
        }
    }
}
