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
    public partial class frmCategory : Form
    {
        Category category = new Category();
        DataGridView dgvcategory;
        Guna2ComboBox comboBox;
      
        Validation validation = new Validation();
        bool is_newcategory;

        public frmCategory(DataGridView dgvcategory, bool is_newcategory = true,Guna2ComboBox comboBox = null)
        {
            InitializeComponent();
            this.dgvcategory = dgvcategory;
            this.is_newcategory = is_newcategory;
            this.comboBox = comboBox;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                category.cat_code = categary_code.Text;
                category.cat_name = categoty_name.Text;


                if (is_newcategory)
                {
                    category.insert_Category();
                }
                else
                {
                    category.update_Category();
                }
                if (dgvcategory != null) dgvcategory.DataSource = category.viewCategory();
                else
                {
                    comboBox.DataSource = category.fillCombo();
                    comboBox.ValueMember = "category_id";
                    comboBox.DisplayMember = "category";
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

        private void frmCategory_Shown(object sender, EventArgs e)
        {
            if (!is_newcategory)
            {
                category.cat_id = int.Parse(dgvcategory.SelectedRows[0].Cells["cellCatID"].Value.ToString());

                DataTable dTable = category.cetagory_details();

                categary_code.Text = dTable.Rows[0]["category_code"].ToString();
                categoty_name.Text = dTable.Rows[0]["category_name"].ToString();
            }
        }
    }
}
