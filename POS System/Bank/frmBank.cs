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
    public partial class frmBank : Form
    {
        BankAccount bank = new BankAccount();
        bool is_new;
        DataGridView dgvBank;
        Validation validation = new Validation();

        public frmBank(DataGridView dgvBank,bool is_new = true)
        {
            InitializeComponent();
            this.is_new = is_new;
            this.dgvBank = dgvBank;
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bank.acc_name = acc_name.Text;
            bank.account_no = acc_number.Text;
            bank.bank_name = bank_name.Text;

            if (is_new)
            {
                bank.inser_query();
            }
            else
            {
                bank.update_query();  
            }
            Animation.showMessage("Successfully Saved", "success");
            this.Close();

        }

        private void Frm_bank_Shown(object sender, EventArgs e)
        {
            if (!is_new)
            {
                bank.bank_id = int.Parse(dgvBank.SelectedRows[0].Cells["bank_id"].Value.ToString());

                DataTable dTable = bank.bank_details();

                acc_number.Text = dTable.Rows[0]["account_no"].ToString();
                acc_name.Text = dTable.Rows[0]["account_name"].ToString();
                bank_name.Text = dTable.Rows[0]["bank_name"].ToString();
            }
        }
    }
}
