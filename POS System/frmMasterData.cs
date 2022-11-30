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
    public partial class frmMasterData : Form
    {
        public frmMasterData(string type)
        {
            InitializeComponent();

            chipTitle.Text = type;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtValue.Text.Trim()=="")
            {
                MessageBox.Show("Value Cannot be Empty");
            }
            else
            {
                DataMaster data = new DataMaster();

                data.type = chipTitle.Text;
                data.value = txtValue.Text.Trim();
                if (data.insertData())
                {
                    this.DialogResult = DialogResult.Yes;
                    MessageBox.Show("Record Added");
                    this.Close();
                }
            }
                
        }
    }
}
