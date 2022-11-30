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
    public partial class frmBrand : Form
    {
        Brand brand = new Brand();
        DataGridView dgvbrand;
        Guna2ComboBox comboBox;

        Validation validation = new Validation();
        bool is_newbrand;

        public frmBrand(DataGridView dgv, bool is_newbrand = true,Guna2ComboBox combox = null)
        {
            InitializeComponent();
            this.dgvbrand = dgv;
            this.is_newbrand = is_newbrand;
            this.comboBox = combox;
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
          try {
                brand.brand_code = brand_code.Text;
                brand.brand_name = brand_name.Text;

                if (is_newbrand)
                {
                    brand.insertBrand();
                }
                else
                {
                    brand.updateBrand();
                }
                if (dgvbrand != null) dgvbrand.DataSource = brand.viewBrand();
                else
                {
                    comboBox.DataSource = brand.fillCombo();
                    comboBox.ValueMember = "brand_id";
                    comboBox.DisplayMember = "brand";
                    comboBox.SelectedIndex = 0;
                }
                Animation.showMessage("Successfully Saved", "success");
                this.Close();
            }
            catch(Exception exc)
            {
                Animation.showMessage(exc.Message, "error");
            }

        }

        private void frmBrand_Shown(object sender, EventArgs e)
        {
            if (!is_newbrand)
            {
                brand.brand_id = int.Parse(dgvbrand.SelectedRows[0].Cells["cellBrandID"].Value.ToString());
               
                DataTable dTable = brand.brand_details();

                //Get Data from Database and set them to the form controls
                brand_code.Text = dTable.Rows[0]["brand_code"].ToString();
                brand_name.Text = dTable.Rows[0]["brand_name"].ToString();
            }
        }
    }
}
