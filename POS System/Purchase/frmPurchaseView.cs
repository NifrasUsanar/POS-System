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
    public partial class frmPurchaseView : Form
    {
        public int purchaseid;
        public frmPurchaseView()
        {
            InitializeComponent();
        }

        Purchase purchase = new Purchase();
        PurchaseItems purchaseItem = new PurchaseItems();
        DataTable dTableProducts = new DataTable();

        decimal totalPurchase, netTotal = 0, purchaseDiscount;

        void updateDatagridviewOnChanges()
        {
            if (txtDiscount.Text.Trim() == "") purchaseDiscount = 0;
            else purchaseDiscount = Convert.ToDecimal(txtDiscount.Text.Trim());

            if (dgvGrid.Rows.Count > 0)
            {
                DataTable dTable = (DataTable)dgvGrid.DataSource;
                totalPurchase = (decimal)dTable.Compute("Sum(total)", "True");
                //indirectPurchaseAmount = (decimal)dTable.Compute("Sum(indirect_total)","True");
                netTotal = (totalPurchase - purchaseDiscount);
                lblPurchasTotalAmount.Text = "Rs. " + totalPurchase.ToString("N2");
                chiptTotal.Text = "Rs. " + netTotal.ToString("N2");
            }
            else
            {
                netTotal = (0-purchaseDiscount);
                lblPurchasTotalAmount.Text = "Rs. 0";
                chiptTotal.Text = $"Rs. {netTotal.ToString("N2")}";
            }
        }

        void viewPurchaseCart()
        {
            dgvGrid.DataSource = purchaseItem.viewPurchaseCart(purchaseid);
            updateDatagridviewOnChanges();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            tabPurchase.SelectedTab = tabViewItems;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            tabPurchase.SelectedTab = tabViewPayment;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPurchaseView_Load(object sender, EventArgs e)
        {
            tabPurchase.Appearance = TabAppearance.FlatButtons;
            tabPurchase.ItemSize = new Size(0, 1);
            tabPurchase.SizeMode = TabSizeMode.Fixed;
        }


        private void frmPurchaseView_Shown(object sender, EventArgs e)
        {
            DataTable dTable = purchase.findPurchase(purchaseid);

            chiptTotal.Text = dTable.Rows[0]["total"].ToString();
            txtDiscount.Text = dTable.Rows[0]["discount"].ToString();
            txtReference.Text = dTable.Rows[0]["refrence_no"].ToString();
            txtNote.Text = dTable.Rows[0]["note"].ToString();
            dtpDate.Text = dTable.Rows[0]["created_at"].ToString();
            btnVendor.Tag = dTable.Rows[0]["people_id"].ToString();
            btnVendor.Text = dTable.Rows[0]["name"].ToString();
            cmbStatus.SelectedIndex = Convert.ToInt32(dTable.Rows[0]["purchase_status"]);
            cmbStock.SelectedIndex = Convert.ToInt32(dTable.Rows[0]["is_stock"]);

            if(cmbStatus.SelectedIndex==0) btnVendor.Enabled = pnlPurchase.Enabled = true;
            else btnVendor.Enabled = pnlPurchase.Enabled = false;

            viewPurchaseCart();
            cmbStatus.Enabled = true;



            //dgvPurchasePayment.DataSource = new Payment(true).viewPaymentLogByRefrenceID(purchaseid);
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "OPEN")
            {
                if (dTableProducts.Rows.Count <= 0)
                {
                    dTableProducts = purchaseItem.fillItemWithBrand();
                    Global.showSuggestion(dTableProducts, txtProductSearch);
                }
            }
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            frmClientView people = new frmClientView();
            people.ctrl = btnVendor;
            people.StartPosition = FormStartPosition.Manual;

            Point location = ((Control)sender).PointToScreen(Point.Empty);

            people.Left = (location.X - people.Width) + ((Control)sender).Width;
            people.Top = (location.Y) + ((Control)sender).Height + 3;

            Animation.showListModal(people);
        }

        private void dgvGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbStatus.Text == "CLOSED")
            {
                MessageBox.Show("Closed Purchase Cannot Be Edited");
            }
            else
            {
                string cartID = dgvGrid.SelectedRows[0].Cells["cellCartID"].Value.ToString();
                string itemID = dgvGrid.SelectedRows[0].Cells["cellItemID"].Value.ToString();
                decimal quantity = Convert.ToDecimal(dgvGrid.SelectedRows[0].Cells["cellQuantity"].Value);
                if (dgvGrid.Columns[e.ColumnIndex].Name == "cellRemove")
                {
                    if (purchaseItem.deletePurchaseCart(cartID))
                    {
                        DialogResult result = MessageBox.Show("Do you want to update stock?", "Information", MessageBoxButtons.YesNo);

                        if (result == DialogResult.Yes) purchaseItem.updateStockByQuantity(itemID,(-1*quantity));

                        dgvGrid.Rows.RemoveAt(dgvGrid.SelectedRows[0].Index);
                        updateDatagridviewOnChanges();
                    }
                }
                else if (dgvGrid.Columns[e.ColumnIndex].Name == "cellItem")
                {
                    Animation.showModal(new frmStockForm(Convert.ToInt32(itemID)) { is_from_stock = false });
                }
                else if (dgvGrid.Columns[e.ColumnIndex].Name == "cellPrice")
                {
                    DialogResult resultCart = Animation.resultModal(new frmPurchaseCart(itemID, cartID, purchaseid));
                    if (resultCart == DialogResult.Yes) viewPurchaseCart();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDiscount.Text.Trim() == "") txtDiscount.Text = "0";
                if (txtReference.Text.Trim() == "") txtReference.Text = "0";

                purchase.peopleID = int.Parse(btnVendor.Tag.ToString());
                purchase.paid_amount = 0;
                purchase.total = netTotal;
                purchase.purchaseDate = Validation.convertDate(dtpDate);
                purchase.note = "";
                purchase.refrenceNo = txtReference.Text.Trim();
                purchase.discount = purchaseDiscount;

                if(purchase.updatePurchase(purchaseid,Convert.ToBoolean(cmbStock.SelectedIndex), Convert.ToBoolean(cmbStatus.SelectedIndex)))
                {
                    //new People().updatePeopleBalance(purchase.peopleID, -1 * purchase.total);
                    MessageBox.Show("Purchase Updated");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateDatagridviewOnChanges();
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            updateDatagridviewOnChanges();
        }

        private void cmbStock_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //bool is_stock = true;
            //if (cmbStock.SelectedIndex == 0) is_stock = false;

            //if (new PurchaseItems().stockUpdate(is_stock, purchaseid))
            //{
            //    MessageBox.Show("Process Completed");
            //}
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStatus.Text == "OPEN" && pnlPurchase.Enabled==false)
            {
                DialogResult result = MessageBox.Show("Do you really want to re-open this purchase?... It will reverse vendor balance...", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //invoice.updateInvoice(invoiceID, btnVendor.Tag.ToString(), "Open", "+");
                    purchase.updatePurchaseStatus(purchaseid, false, btnVendor.Tag.ToString(), "+", netTotal);
                    btnVendor.Enabled = pnlPurchase.Enabled = true;
                }
                else
                {
                    btnVendor.Enabled = pnlPurchase.Enabled = false;
                    cmbStatus.SelectedIndex = 1;
                }
            }
            else if (cmbStatus.Text=="CLOSED" && pnlPurchase.Enabled == true)
            {
                DialogResult result = MessageBox.Show("Are you sure to close this Purchase","Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    btnSave.PerformClick();
                    purchase.updatePurchaseStatus(purchaseid, true, btnVendor.Tag.ToString(), "-", netTotal);
                    btnVendor.Enabled = pnlPurchase.Enabled = false;
                }
                else
                {
                    btnVendor.Enabled = pnlPurchase.Enabled = true;
                    cmbStatus.SelectedIndex = 0;
                }
            }
        }

        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dTable = purchaseItem.itemSearchinPOS(txtProductSearch.Text, cmbSearchMethod.SelectedIndex);

                if (dTable.Rows.Count == 1 && dTable.Rows[0][0].ToString() != "")
                {
                    DialogResult resultCart = Animation.resultModal(new frmPurchaseCart(dTable.Rows[0]["item_id"].ToString(), "0",purchaseid));

                    if (resultCart == DialogResult.Yes) viewPurchaseCart();
                }
                else if (dTable.Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show("The Item is Not Found... D you want to create new One?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Animation.resultModal(new frmPurchaseCart("0", "0"));

                        DialogResult resultCart = Animation.resultModal(new frmStockForm(0, 0) { is_from_stock = false });
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Name or Code");
                }

                txtProductSearch.Focus();
                txtProductSearch.SelectAll();
            }
        }
    }
}
