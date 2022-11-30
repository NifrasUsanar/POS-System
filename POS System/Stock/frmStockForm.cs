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
    public partial class frmStockForm : Form
    {
        Validation validation = new Validation();
        Stock stock = new Stock();
        unit newUnit = new unit();
        public bool is_from_stock { get; set; } = true;

        public frmStockForm(int itemID=0, int codeNo=0)
        {
            InitializeComponent();

            Validation.numbersOnly(txtAlertQuantity);
            Validation.numbersOnly(txtUnitSalePrice);
            Validation.numbersOnly(txtQuantity);

            stock.itemID = itemID;

            dtpExpiry.Value = dtpManufacture.Value = DateTime.Now;
        }

        //Find Item Details Only
        void findItemDetails(string barcode="")
        {
            if (stock.itemID != 0 || barcode!="")
            {
                DataTable dTable = stock.item_details(barcode);

                if (dTable.Rows.Count > 0)
                {
                    txtQuantity.ReadOnly = true;

                    //Get Data from Database and set them to the form controls
                    txtItemName.Text = dTable.Rows[0]["itm_name"].ToString();
                    cmbUnit.Text = dTable.Rows[0]["itm_unite_type"].ToString();
                    //txtBarcode.Text = dTable.Rows[0]["itm_barcode"].ToString();
                    txtItemCode.Text = dTable.Rows[0]["itm_code"].ToString();
                    txtDescription.Text = dTable.Rows[0]["itm_desc"].ToString();
                    txtAlertQuantity.Text = dTable.Rows[0]["itm_alert"].ToString();
                    cmbBrand.SelectedValue = int.Parse(dTable.Rows[0]["itm_brand_id"].ToString());
                    cmbCategory.SelectedValue = int.Parse(dTable.Rows[0]["itm_categary_id"].ToString());
                    toggleIsFeatured.Checked = bool.Parse(dTable.Rows[0]["is_featured"].ToString());
                    stock.itemID = int.Parse(dTable.Rows[0]["itm_id"].ToString());
                    txtQuantity.Text=chipQuantity.Text = dTable.Rows[0]["quantity"].ToString();
                    txtCost.Text = dTable.Rows[0]["cost"].ToString();
                    txtUnitSalePrice.Text= dTable.Rows[0]["sale_price"].ToString();

                    string exp = dTable.Rows[0]["exp_date"].ToString().Trim();
                    if (exp.Trim().Length!=0)
                    {
                        checkDate.Checked = true;
                        dtpExpiry.Text = dTable.Rows[0]["exp_date"].ToString();
                        dtpManufacture.Text = dTable.Rows[0]["mf_date"].ToString();
                    }
                    else checkDate.Checked = false;
                    
                    if (cmbBrand.Text == "") cmbBrand.SelectedIndex = 0;
                    else if (cmbCategory.Text == "") cmbCategory.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("The Item is Not Found.. Create a new Item");
                    stock.itemID = 0;
                    resetControlsAfterPurchase();          
                }
            }
        }


        //Combo Box validation

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDescription.Text.Trim() == "") txtDescription.Text = "...";
            if (validation.textBoxEmpty(grpForm) && validation.textBoxEmpty(grpMoreDetails))
            {
                stock.item_alert = double.Parse(txtAlertQuantity.Text);
                stock.item_code = txtItemCode.Text;
                //stock.item_brcode = txtBarcode.Text;
                stock.item_brand = int.Parse(cmbBrand.SelectedValue.ToString());
                stock.item_category = int.Parse(cmbCategory.SelectedValue.ToString());
                stock.item_unit = cmbUnit.Text;
                stock.item_name = txtItemName.Text;
                stock.item_desc = txtDescription.Text;
                stock.is_featured = toggleIsFeatured.Checked;
                stock.sale_price = decimal.Parse(txtUnitSalePrice.Text);
                stock.cost = decimal.Parse(txtCost.Text);
                stock.quantity = decimal.Parse(txtQuantity.Text);

                if (checkDate.Checked)
                {
                    stock.expiry = Validation.convertDate(dtpExpiry);
                    stock.manufacture = Validation.convertDate(dtpManufacture);
                }
                else stock.expiry = stock.manufacture = null;

                if (stock.itemID == 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to create this new Item?", "Information", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Insert New Item Information
                        if (stock.insert_item())
                        {
                            Animation.showMessage("Successfully Saved", "success");
                            Global.is_success = true;

                            Global.stockAlertCount();
                            this.Close();
                        }
                    }

                }

                //Update Item Information Only
                else if (stock.itemID != 0)
                {
                    if (stock.update_item(stock.itemID))
                    {
                        Animation.showMessage("Successfully Updated", "success");
                        Global.is_success = true;
                        Global.stockAlertCount();
                        this.Close();
                    }
                }
            }
            }
            catch (Exception exc)
            {
                Animation.showMessage(exc.Message, "error");
            }
        }

        private void frmStockForm_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockForm_Shown(object sender, EventArgs e)
        {

            DataTable dTableBrand = new Brand().viewBrand();
            DataRow brandRow = dTableBrand.NewRow();
            brandRow["brand_id"] = 0;
            brandRow["brand_name"] = "Select a Brand";
            dTableBrand.Rows.InsertAt(brandRow, 0);

            cmbBrand.DataSource = dTableBrand;
            cmbBrand.DisplayMember = "brand_name";
            cmbBrand.ValueMember = "brand_id";

            DataTable dTableCat = new Category().viewCategory();
            DataRow catRow = dTableCat.NewRow();
            catRow["category_id"] = 0;
            catRow["category_name"] = "Select a Category";
            dTableCat.Rows.InsertAt(catRow, 0);

            cmbCategory.DataSource = dTableCat;
            cmbCategory.DisplayMember = "category_name";
            cmbCategory.ValueMember = "category_id";

            if (newUnit.viewunit().Rows.Count<=0)
            {
                newUnit.unit_type = "PCS";
                newUnit.insertUnit();
            }

            cmbUnit.DataSource = newUnit.viewunit();
            cmbUnit.ValueMember = "unit_id";
            cmbUnit.DisplayMember = "unit_type";
            cmbUnit.SelectedIndex = 0;

            findItemDetails();

            if(stock.itemID==0)
            {
                txtItemCode.Text = stock.returnLastItemCode();
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            new frmCategory(null,true,cmbCategory).ShowDialog();
        }

        private void btnAddBrand_Click(object sender, EventArgs e)
        {
            new frmBrand(null, true, cmbBrand).ShowDialog();
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            new frmUnit(null, true, cmbUnit).ShowDialog();
        }

        void resetControlsAfterPurchase()
        {
            foreach(Control ctrl in grpForm.Controls)
            {
                if(ctrl is Guna2TextBox)
                {
                    ctrl.ResetText();
                }
            }

            cmbBrand.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbUnit.SelectedIndex = 0;
        }

        private void frmStockForm_LocationChanged(object sender, EventArgs e)
        {

        }

        private void grpMoreDetails_Enter(object sender, EventArgs e)
        {

        }

        private void checkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDate.Checked) dtpManufacture.Enabled = dtpExpiry.Enabled = true;
            else dtpManufacture.Enabled = dtpExpiry.Enabled = false;
        }
    }
}
