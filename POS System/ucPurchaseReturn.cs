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
    public partial class ucPurchaseReturn : UserControl
    {
        public ucPurchaseReturn()
        {
            InitializeComponent();

            Global.changeTabControlStyle(tabControl);

            dtpStart.Value = dtpEnd.Value = DateTime.Now;
        }
        Purchase purchase = new Purchase();
        decimal due = 0;

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

        private void btnSupplier_TextChanged(object sender, EventArgs e)
        {
            if (btnSupplier.Text.ToUpper() != "select your supplier".ToUpper())
            {
                DataTable dTable = purchase.findPurchaseRefrenceBySupplier(int.Parse(btnSupplier.Tag.ToString()));

                Global.showSuggestion(dTable, txtInvoiceSearch);
            }
        }

        void viewPurchaseItems(string refrenceNo)
        {
            decimal paid, total,refund;

            dgvItems.DataSource = purchase.findPurchaseItemsByRefrenceNo(refrenceNo,btnSupplier.Tag.ToString());

            DataTable dTable = (DataTable)dgvItems.DataSource;

            if (dTable.Rows.Count > 0)
            {
                txtDate.Text = ((DateTime)dTable.Rows[0]["created_at"]).ToString("yyyy-MM-dd");

                paid = Convert.ToDecimal(dTable.Rows[0]["paid_amount"]);
                total = Convert.ToDecimal(dTable.Rows[0]["total"]);
                refund = Convert.ToDecimal(dTable.Rows[0]["refund_amount"]);

                due = total - (paid+(refund*-1));

                txtDue.Text = due.ToString();
                txtTotal.Text = total.ToString();
                txtPaid.Text = paid.ToString();
                txtRefrenceNo.Text = dTable.Rows[0]["refrence_no"].ToString();
                txtRefund.Text = refund.ToString();
            }
            else
            {
                txtDue.Text = txtTotal.Text = txtPaid.Text = txtRefrenceNo.Text = "0";
                txtDate.Text = "NOT FOUND";
                due = 0;
            }

        }

        private void txtInvoiceSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                viewPurchaseItems(txtInvoiceSearch.Text.ToString());
            }
        }

        private void btnReturnHistory_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pagePurchaseReturnHistory;
            dgvReturn.DataSource = new PurchaseReturn().viewReturnHistory(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==dgvItems.Columns["cellBtnReturn"].Index)
            {
                PurchaseReturn purchReturn = new PurchaseReturn();
                string itemName = dgvItems.SelectedRows[0].Cells["cellItemName"].Value.ToString();
                purchReturn.costPrice = Convert.ToDecimal(dgvItems.SelectedRows[0].Cells["cellCost"].Value);
                purchReturn.quantity = Convert.ToDecimal(dgvItems.SelectedRows[0].Cells["cellQuantity"].Value);
                purchReturn.itemID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["cellItemID"].Value);
                purchReturn.batch_no = dgvItems.SelectedRows[0].Cells["cellBatchNo"].Value.ToString();
                purchReturn.purchaseID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["cellPurchaseID"].Value);
                purchReturn.cartID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["cellCartID"].Value);

                frmPurchaseReturn purch = new frmPurchaseReturn(itemName);
                purch.Tag = purchReturn;
                DialogResult result=Animation.resultModal(purch);

                if (DialogResult.Yes == result) viewPurchaseItems(txtRefrenceNo.Text);
            }
            else if (e.ColumnIndex == dgvItems.Columns["cellItemName"].Index)
            {
                int itemID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["cellItemID"].Value);
                Animation.showModal(new frmStockForm(itemID));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSupplierSearch.Text = "SELECT YOUR SUPPLIER";
            txtRefrenceSearch.ResetText();
            dgvReturn.DataSource = new PurchaseReturn().viewReturnHistory(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd));
        }

        private void btnPurchaseReturn_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pagePurchaseReturn;
        }

        private void btnSupplierSearch_Click(object sender, EventArgs e)
        {
            frmClientView people = new frmClientView();
            people.ctrl = btnSupplierSearch;
            people.StartPosition = FormStartPosition.Manual;

            Point location = ((Control)sender).PointToScreen(Point.Empty);

            people.Left = (location.X - people.Width) + ((Control)sender).Width;
            people.Top = (location.Y) + ((Control)sender).Height + 3;

            Animation.showListModal(people);
        }

        void filterReturn()
        {
            string filterQRY = $"(CONVERT(refrence_no,System.String) LIKE '{txtRefrenceSearch.Text.Trim()}%')";
            if(btnSupplierSearch.Text.ToUpper()!="SELECT YOUR SUPPLIER")
            {
                filterQRY += $" AND (name LIKE '{btnSupplierSearch.Text}')";
            }

            (dgvReturn.DataSource as DataTable).DefaultView.RowFilter = filterQRY;
        }

        private void txtRefrenceSearch_TextChanged(object sender, EventArgs e)
        {
            filterReturn();
        }

        private void btnSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            filterReturn();
        }

        private void dgvItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if(e.ColumnIndex==dgvItems.Columns["cellItemName"].Index)
            //{
            //    cell
            //}
            //cellItemName.DefaultCellStyle.SelectionBackColor = Color.White;
            dgvItems.Rows[e.RowIndex].Cells[cellItemName.Index].Style.SelectionBackColor = Color.White;
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            if (due >= 0) MessageBox.Show("Refund Amount is not sufficiant to continue this process");
            else
            {
                int purchaseID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["cellPurchaseID"].Value);
                int peopleID = Convert.ToInt32(dgvItems.SelectedRows[0].Cells["cellPeopleID"].Value);
                DialogResult result = Animation.resultModal(new frmPurchaseRefund(purchaseID,peopleID,due*-1));

                if (result == DialogResult.Yes) viewPurchaseItems(txtRefrenceNo.Text);
            }
        }

        private void linkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnSupplier.Tag.ToString() != "0")
            {
                Animation.showSideModal(new frmPeopleDetail(btnSupplier.Tag.ToString(), btnSupplier.Text, true));
            }
        }
    }
}
