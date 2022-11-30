using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace POS_System
{
    public partial class frmLicensing : Form
    {
        public frmLicensing()
        {
            InitializeComponent();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            int total = 0;
            string newString = Regex.Replace(txtLicense.Text, "[^.0-9]", "");
            char[] charArr = newString.ToCharArray();

            foreach (char ch in charArr) total += int.Parse(ch.ToString());

            if (total != 100) MessageBox.Show("Activation code error");
            else MessageBox.Show("Success");

        }
    }
}
