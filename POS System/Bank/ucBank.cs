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
    public partial class ucBank : UserControl
    {
        BankAccount bank = new BankAccount();
       
        public ucBank()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmBank(dgvBank));
            dgvBank.DataSource = bank.viewbank();
        }

        private void ucBank_Load(object sender, EventArgs e)
        {
            dgvBank.DataSource = bank.viewbank();
        }

        private void dgvBank_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBank.Columns[e.ColumnIndex].Name == "edit")
            {
                Animation.showModal(new frmBank(dgvBank,false));
                dgvBank.DataSource = bank.viewbank();
            }

            if (dgvBank.Columns[e.ColumnIndex].Name == "bank_transfer")
            {
                Animation.showModal(new frmBanktransfer(dgvBank,false));
               
            }


        }

        private void dgvBank_Click(object sender, EventArgs e)
        {
           

        }

        private void ucBank_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvBank.DataSource = bank.viewbank();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
