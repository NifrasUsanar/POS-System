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
    public partial class frmExpences : Form
    {
        Expences expences = new Expences();
        DataGridView dgvexpences;
        Validation validation = new Validation();
        bool is_new;

        public frmExpences(DataGridView dgvexpences, bool is_new=true)
        {
            InitializeComponent();
            this.dgvexpences = dgvexpences;
            this.is_new = is_new;

            Validation.numbersOnly(txtAmount);
            dtpDate.Value = DateTime.Now;
        }

        private void frmExpences_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "") MessageBox.Show("Amount Cannot Be Empty");
            else if (txtDescription.Text.Trim() == "") MessageBox.Show("Description cannot be Empty");
            else
            {
                expences.amont = decimal.Parse(txtAmount.Text);
                expences.discription = txtDescription.Text;
                expences.date = Validation.convertDate(dtpDate);

                if (is_new)
                {
                    expences.inserExpences();
                    dgvexpences.DataSource = expences.viewexpences(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                    Animation.showMessage("Successfully Saved", "success");
                    this.Close();
                }
                else
                {
                    expences.updateExpences();
                    dgvexpences.DataSource = expences.viewexpences(DateTime.Now.ToString("yyyy-MM-dd"), DateTime.Now.ToString("yyyy-MM-dd"));
                    Animation.showMessage("Successfully Updated", "success");
                    this.Close();
                }

                
            }
        }

        private void frmExpences_Shown(object sender, EventArgs e)
        {
            //DataTable dTableExpenseList = new DataMaster().viewMaster("Expense");
            //Global.showSuggestion(dTableExpenseList,txtDescription);

            if (!is_new)
            {
                expences.expences_id = int.Parse(dgvexpences.SelectedRows[0].Cells["cellID"].Value.ToString());

                DataTable dTable = expences.expences_details();

                txtAmount.Text = dTable.Rows[0]["amount"].ToString();
                txtDescription.Text = dTable.Rows[0]["discription"].ToString();
                dtpDate.Text = dTable.Rows[0]["Date"].ToString();
            }
        }
    }
}
