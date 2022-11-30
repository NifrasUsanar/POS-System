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
    public partial class frmOpenRegister : Form
    {
        public frmOpenRegister()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOpenCash.Text.Trim() == "") txtOpenCash.Text = "0";
            else if (txtOpenCheque.Text.Trim() == "") txtOpenCheque.Text = "0";

            CashRegister register = new CashRegister();
            register.open_cheque = txtOpenCheque.Text.Trim();
            register.open_cash = txtOpenCash.Text.Trim();

            if(register.openCashRegister("1"))
            {
                MessageBox.Show("Register Opened");
                Global.registerID = 1;
                this.Close();
            }
        }
    }
}
