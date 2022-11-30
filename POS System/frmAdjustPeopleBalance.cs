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
    public partial class frmAdjustPeopleBalance : Form
    {
        string peopleID;
        public frmAdjustPeopleBalance(string balance, string peopleID)
        {
            InitializeComponent();
            Validation.numbersOnly(txtAmount);
            this.peopleID = peopleID;
            txtAmount.Text = balance;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "") txtAmount.Text = "0";

            if (new People().adjustBalance(peopleID, txtAmount.Text.Trim()))
            {
                MessageBox.Show("Balance Changed");
                this.DialogResult = DialogResult.Yes;
            }
            else MessageBox.Show("Error! Process not Completed");

        }
    }
}
