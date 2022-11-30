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
    public partial class ucEtc : UserControl
    {
        Brand brand = new Brand();
        Category category = new Category();
        unit unit = new unit();

        public ucEtc()
        {
            InitializeComponent();

            Global.changeTabControlStyle(tabControl);
        }

        private void addbrand_Click(object sender, EventArgs e)
        {
            
            Animation.showModal(new frmBrand(dgvbrand));
        }

        private void addcategory_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmCategory(dgvcategory));
        }

        private void ucEtc_Load(object sender, EventArgs e)
        {
            dgvcategory.DataSource = new Category().viewCategory();
            dgvbrand.DataSource = new Brand().viewBrand();
            dgvunit.DataSource = new unit().viewunit();

            btnCategory.PerformClick();     
        }

        private void edit_brand_Click(object sender, EventArgs e)
        {
            new frmBrand(dgvbrand, false).ShowDialog();
        }

        private void dvgunite_type_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvunit.Columns[e.ColumnIndex].Name == "delete")
            {
                
            }
        }

        private void delete_unit_Click(object sender, EventArgs e)
        {
            string uid = dgvunit.SelectedRows[0].Cells["unit_id"].Value.ToString();
            unit.deleteUnit(uid);
            dgvunit.DataSource = new unit().viewunit();
        }

        private void edit_category_Click(object sender, EventArgs e)
        {
            new frmCategory(dgvcategory, false).ShowDialog();
        }

        private void add_unit_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmUnit(dgvunit));
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageStore;

            dgvItemStorage.DataSource = new StorageLocation().viewStorageLocation();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageCategory;
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageBrand;
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageUnit;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageMaster;
            dgvMaster.Columns["cellValue"].HeaderText = "Expense";

            dgvMaster.DataSource = new DataMaster().viewMaster("Expense");
            btnAddMaster.Tag = "Expense";
        }

        private void btnAddMaster_Click(object sender, EventArgs e)
        {
            DialogResult result=Animation.resultModal(new frmMasterData(btnAddMaster.Tag.ToString()));

            if(result==DialogResult.Yes)
            {
                dgvMaster.DataSource = new DataMaster().viewMaster(btnAddMaster.Tag.ToString());
            }
        }

        private void dgvMaster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvMaster.Columns[e.ColumnIndex].Name == "cellRemoveMaster")
            {
                int masterID = int.Parse(dgvMaster.SelectedRows[0].Cells["cellMasterID"].Value.ToString());

                if(new DataMaster().removeMasterData(masterID))
                {
                    dgvMaster.Rows.RemoveAt(dgvMaster.SelectedRows[0].Index);
                }
            }
        }

        private void add_storge_location_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmStore(dgvItemStorage));
            dgvItemStorage.DataSource = new StorageLocation().viewStorageLocation();
        }

        private void btnEditStorage_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmStore(dgvItemStorage, false));
            dgvItemStorage.DataSource = new StorageLocation().viewStorageLocation();
        }

        private void dgvbrand_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvbrand.Columns[e.ColumnIndex].Name == "cellBrandRemove")
            {
                string brandID = dgvbrand.SelectedRows[0].Cells["cellBrandID"].Value.ToString();

                if (brand.removeBrand(brandID))
                {
                    dgvbrand.Rows.RemoveAt(dgvbrand.SelectedRows[0].Index);
                }
            }
        }

        private void dgvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvcategory.Columns[e.ColumnIndex].Name == "cellCatRemove")
            {
                string catID = dgvcategory.SelectedRows[0].Cells["cellCatID"].Value.ToString();

                if (category.removeCategory(catID))
                {
                    dgvcategory.Rows.RemoveAt(dgvcategory.SelectedRows[0].Index);
                }
            }
        }
    }
}
