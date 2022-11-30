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
using DataLibrary;

namespace POS_System
{
    public partial class frmUnit : Form
    {
        unit unit = new unit();
        DataGridView dgvunit;
        Guna2ComboBox comboBox;

        Validation validation = new Validation();
        bool is_newunit;

        public frmUnit(DataGridView dgvunit=null, bool is_newunit = true,Guna2ComboBox comboBox=null )
        {
            InitializeComponent();
            this.dgvunit = dgvunit;
            this.is_newunit = is_newunit;
            this.comboBox = comboBox;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                unit.unit_type = unit_type.Text;

                if (is_newunit)
                {
                    unit.insertUnit();
                }

                if (dgvunit != null) dgvunit.DataSource = unit.viewunit();
                else
                {
                    comboBox.DataSource = unit.viewunit();
                    comboBox.ValueMember = "unit_id";
                    comboBox.DisplayMember = "unit_type";
                    comboBox.SelectedIndex = 0;
                }
                Animation.showMessage("Successfully Saved", "success");
                this.Close();
            }
            catch (Exception exc)
            {
                Animation.showMessage(exc.Message, "error");
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
