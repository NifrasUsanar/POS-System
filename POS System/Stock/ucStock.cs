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
    public partial class ucStock : UserControl
    {
        bool is_stockAlert, is_filter;
        int currentPage=1, totalPages = 1, offset=0;
        decimal pages,itemCount;
        public ucStock(bool is_stockAlert=false)
        {
            InitializeComponent();

            this.is_stockAlert = is_stockAlert;
        }

        //void dgvPagination()
        //{
        //    decimal itemCount = dtStock.Rows.Count;
        //    decimal pages = itemCount / 50;

        //    if ((pages % 1) != 0) pages += 1;
        //    totalPages = Convert.ToInt32(pages);
        //    lblPage.Text = $"{currentPage.ToString()} / {totalPages.ToString()}";
        //    lblCount.Text = itemCount.ToString();

        //    int skip = (currentPage-1) * 50;

        //    dgvStock.DataSource = dtStock.AsEnumerable().Skip(skip).Take(50).CopyToDataTable();
        //}

        void dgvPagination()
        {
            itemCount = new Item().totalResults(is_filter, is_stockAlert, txtSearch.Text, cmbBrand.Text, cmbCategory.Text);
            pages = itemCount / Convert.ToDecimal(cmbRecords.Text);

            if(pages<1) pages = 1;
            else if ((pages % 1) != 0) pages += 1;
            totalPages = Convert.ToInt32(pages);
            lblPage.Text = $"{currentPage.ToString()} / {totalPages.ToString()}";
            lblResults.Text = $"Found results {itemCount.ToString()}";

            offset = (currentPage - 1) * Convert.ToInt32(cmbRecords.Text);

            if (!is_filter)
            {
                dgvStock.DataSource = new Item().viewStock(Convert.ToInt32(cmbRecords.Text), offset,is_stockAlert);
            }
            else if(is_filter)
            {
                dgvStock.DataSource = new Item().filterStock(txtSearch.Text, cmbBrand.Text, cmbCategory.Text, Convert.ToInt32(cmbRecords.Text), offset);
            }

            //dgvStock.DataSource = dtStock.AsEnumerable().Skip(skip).Take(Convert.ToInt32(cmbRecords.Text)).CopyToDataTable();
        }

        private void ucStock_Load(object sender, EventArgs e)
        {
            //dgvStock.DataSource = Global.dtStock.AsEnumerable().Take(100).CopyToDataTable();

            DataTable dTableBrand = new Brand().viewBrand();
            DataRow brandRow = dTableBrand.NewRow();
            brandRow["brand_id"] = 0;
            brandRow["brand_name"] = "All Brand";
            dTableBrand.Rows.InsertAt(brandRow,0);

            cmbBrand.DataSource = dTableBrand;
            cmbBrand.DisplayMember = "brand_name";
            cmbBrand.ValueMember = "brand_id";

            DataTable dTableCat = new Category().viewCategory();
            DataRow catRow = dTableCat.NewRow();
            catRow["category_id"] = 0;
            catRow["category_name"] = "All Category";
            dTableCat.Rows.InsertAt(catRow,0);

            cmbCategory.DataSource = dTableCat;
            cmbCategory.DisplayMember = "category_name";
            cmbCategory.ValueMember = "category_id";

            cmbRecords.Text = "50";

            
            currentPage = 1;
            is_filter = false;
            dgvPagination();
            if (is_stockAlert) btnStockAlert.PerformClick();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Global.is_success = false;
            Animation.showModal(new frmStockForm());
            if (Global.is_success) dgvPagination();
        }


        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            is_filter = false;
            is_stockAlert = false;
            dgvPagination();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvStock.Columns[e.ColumnIndex].Name == "dgcItemName")
            {
                Global.dataGrid = dgvStock;

                int itemID = int.Parse(dgvStock.SelectedRows[0].Cells["cellID"].Value.ToString());
                Global.is_success = false;
                Animation.showModal(new frmStockForm(itemID));
                if (Global.is_success) dgvPagination();
            }
            else if (dgvStock.Columns[e.ColumnIndex].Name == "cellQuantity")
            {
                Stock stock = new Stock();
                stock.itemID = int.Parse(dgvStock.SelectedRows[0].Cells["cellID"].Value.ToString());
                Global.is_success = false;
                Animation.showModal(new frmStockAdjustment() {stock=stock});
                if (Global.is_success) dgvPagination(); // If record is successfully save then this function will be triggered
            }
        }

        void calculateSum()
        {
            DataTable dtSummary = new Item().stockSummary();

            lblTotalQty.Text = dtSummary.Rows[0]["quantity"].ToString();
            lblTotalVal.Text = dtSummary.Rows[0]["valuation"].ToString();
            lblTotalItems.Text = dtSummary.Rows[0]["items"].ToString();

            chipTotalProduct.Text = "0";
            lblOnHand.Text = "0";
            lblTotalValuation.Text = "Rs. 0";

            if (dgvStock.Rows.Count > 0)
            {
                DataTable dTable = (dgvStock.DataSource as DataTable).DefaultView.ToTable();
                lblTotalValuation.Text = $"Rs. {dTable.Compute("Sum(valuation)", "True"):N2}";
                chipTotalProduct.Text = $"{dTable.Compute("COUNT(itm_id)", "True"):N2}";
                lblOnHand.Text = $"{dTable.Compute("Sum(quantity)", "True"):N2}";
            }           
        }

        private void dgvStock_DataSourceChanged(object sender, EventArgs e)
        {
            calculateSum();
        }

        private void btnStockAlert_Click(object sender, EventArgs e)
        {
            if (Global.dTableStockAlert.Rows.Count>0)
            {
                currentPage = 1;
                is_stockAlert=true;
                dgvPagination();
                //string itemID = "";
                //foreach (DataRow dtRow in Global.dTableStockAlert.Rows)
                //{
                //    itemID += $",{dtRow["itm_id"]}";
                //}

                //itemID = itemID.Remove(0, 1);
                ////(dgvStock.DataSource as DataTable).DefaultView.RowFilter = $"itm_id IN({itemID})";
                //dtStock.DefaultView.RowFilter = $"itm_id IN({itemID})";
                //dtStock = dtStock.DefaultView.ToTable();
                //currentPage = 1;
                //dgvPagination();
                //calculateSum();
            }
            else MessageBox.Show("No records Found");
        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {
            DataTable dTable = (dgvStock.DataSource as DataTable).DefaultView.ToTable();
            new frmGlobalReport("Stock Report", "POS_System.rptStock.rdlc","dsStock",dTable).ShowDialog();
        }

        private void btnStockHistory_Click(object sender, EventArgs e)
        {
            new frmStockHistory().ShowDialog();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            is_filter = true;
            is_stockAlert = false;
            dgvPagination();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage -= 1;
                dgvPagination();
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            dgvPagination();
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage != totalPages)
            {
                currentPage += 1;
                dgvPagination();
            }
        }
    }
}
