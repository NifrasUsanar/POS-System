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
    public partial class ucPurchase : UserControl
    {
        public ucPurchase(string peopleID="0", string peopleName= "select your vendor", bool is_purchase=true)
        {
            InitializeComponent();

            Global.changeTabControlStyle(tabControl);

            btnSupplier.Text = peopleName;
            btnSupplier.Tag = peopleID;

            if (is_purchase) cmbMode.SelectedIndex = 0;
            else cmbMode.SelectedIndex = 1;
        }

        Purchase purchase = new Purchase();

        void sumTotalOfPurchase()
        {
            DataTable dTable = (dgvPurchase.DataSource as DataTable).DefaultView.ToTable();

            if (dTable.Rows.Count > 0) chipPurchaseTotal.Text = $"Rs. {dTable.Compute("SUM(total)", "True"):N2}";
            else chipPurchaseTotal.Text = "Rs. 0.00";
        }

        //Purchase Only
        void viewPurchaseHistory()
        {
            if (cmbMode.SelectedIndex == 0)
            {
                dgvPurchase.DataSource = purchase.filterPurchase(btnSupplier.Tag.ToString(), Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));

                sumTotalOfPurchase();
            }
            else
            {
                dgvStock.DataSource = new PurchaseItems().viewPurchaseItems(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd), btnSupplier.Tag.ToString());
            }
        }

        //Filter Purchase Only
        void filterPurchase()
        {
            string filterQry = "";

            if (cmbPurchaseSearchType.SelectedIndex == 1) filterQry = $"(CONVERT(refrence_no,System.String) LIKE '{txtPurchaseSearch.Text.Trim()}%')";
            else if (cmbPurchaseSearchType.SelectedIndex == 0) filterQry = $"(name LIKE '{txtPurchaseSearch.Text.Trim()}%')";

            //if (cmbPurchaseStatus.SelectedIndex != 0) filterQry += $" AND (payment_status LIKE '{cmbPurchaseStatus.Text}')";

            if ((dgvPurchase.DataSource as DataTable) != null)
            {
                (dgvPurchase.DataSource as DataTable).DefaultView.RowFilter = filterQry;
            }

            sumTotalOfPurchase();
        }

        //Filter Purchase Items
        void filterPurchaseItems()
        {
            string filterQry = "";
            string search = txtItemsSearch.Text.Trim();

            if (cmbSearchModItems.SelectedIndex == 0) filterQry = $"(name LIKE '{search}%')";
            else if (cmbSearchModItems.SelectedIndex == 1) filterQry = $"(CONVERT(refrence_no,System.String) LIKE '{search}%')";
            else if (cmbSearchModItems.SelectedIndex == 2) filterQry = $"(itm_name LIKE '{search}%')";

            if ((dgvStock.DataSource as DataTable) != null)
            {
                (dgvStock.DataSource as DataTable).DefaultView.RowFilter = filterQry;
            }
        }

        private void ucPurchase_Load(object sender, EventArgs e)
        {
            if (!Global.is_admin) cellRemove.Visible = false;

            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = DateTime.Now;

            viewPurchaseHistory();
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int purchaseID = int.Parse(dgvPurchase.SelectedRows[0].Cells["purchaseid"].Value.ToString());

            if (dgvPurchase.Columns[e.ColumnIndex].Name=="purchaseid")
            {
                frmPurchaseView purchaseview = new frmPurchaseView();
                purchaseview.purchaseid = purchaseID;
                purchaseview.ShowDialog();
            }
            else if (dgvPurchase.Columns[e.ColumnIndex].Name == "btnAddPayment")
            {
                int peopleid = int.Parse(dgvPurchase.SelectedRows[0].Cells["peopleid"].Value.ToString());
                decimal total = decimal.Parse(dgvPurchase.SelectedRows[0].Cells["total"].Value.ToString());
                decimal paidamount = decimal.Parse(dgvPurchase.SelectedRows[0].Cells["paidamount"].Value.ToString());
                decimal discount = decimal.Parse(dgvPurchase.SelectedRows[0].Cells["discount"].Value.ToString());

                if (paidamount >= total)
                {
                    Animation.showMessage("Payment Fully Completed","info");
                }
                else
                {
                    var result = Animation.resultModal(new frmPayment(total - paidamount, discount, peopleid, purchaseID, true));

                    if (result != DialogResult.Cancel) viewPurchaseHistory();
                }
            }
            else if (dgvPurchase.Columns[e.ColumnIndex].Name == "cellRemove")
            {
                DialogResult result = MessageBox.Show("This deletion will not affect any records.. Do you really want to delete this?", "Confirmation", MessageBoxButtons.YesNo);

                if(result==DialogResult.Yes && purchase.deletePurchase(purchaseID))
                {
                    dgvPurchase.Rows.RemoveAt(dgvPurchase.SelectedRows[0].Index);
                    //updateDatagridviewOnChanges();
                    sumTotalOfPurchase();
                }
            }
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterPurchase();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewPurchaseHistory();
        }

        private void btnReportPrint_Click(object sender, EventArgs e)
        {

        }

        private void linkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnSupplier.Text = "SELECT YOUR VENDOR";
            btnSupplier.Tag = 0;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmClientView people = new frmClientView();
            people.ctrl = btnSupplier;
            people.StartPosition = FormStartPosition.Manual;

            Point location = ((Control)sender).PointToScreen(Point.Empty);

            people.Left = (location.X - people.Width) + ((Control)sender).Width;
            people.Top = (location.Y) + ((Control)sender).Height + 3;

            Animation.showListModal(people);
        }

        private void cmbMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewPurchaseHistory();
        }

        private void txtPurchaseSearch_TextChanged(object sender, EventArgs e)
        {
            filterPurchase();
        }

        private void cmbPurchaseSearchType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterPurchase();
        }

        private void cmbSearchModItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterPurchaseItems();
        }

        private void txtItemsSearch_TextChanged(object sender, EventArgs e)
        {
            filterPurchaseItems();
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = cmbMode.SelectedIndex;
        }
    }
}
