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
using Guna.UI2.WinForms;

namespace POS_System
{
    public partial class ucNewPurchaseForm : UserControl
    {
        public ucNewPurchaseForm()
        {
            InitializeComponent();

            dtpPurchseDate.Value = DateTime.Now;
            Validation.numbersOnly(txtRefrenceNo);
            Validation.numbersOnly(txtDiscount);
        }

        Item item = new Item();
        PurchaseItems cartPurchase = new PurchaseItems();
        Purchase purchase = new Purchase();
        People people = new People();

        DataTable dTableRefrenceNo = new DataTable();

        decimal totalPurchase,netTotal=0,discount;

        void viewPurchaseCart()
        {
            dgvGrid.DataSource=cartPurchase.viewPurchaseCart();
            updateDatagridviewOnChanges();
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

        private async void ucNewPurchaseForm_Load(object sender, EventArgs e)
        {
           try
            {
                btnSupplier.Tag = Global.supplierTag;
                btnSupplier.Text = Global.supplierName;
                await Task.Delay(300);
                viewPurchaseCart();

                DataTable dTableProducts = item.fillItemWithBrand();
                Global.showSuggestion(dTableProducts, txtBarcode);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dTable = item.itemSearchinPOS(txtBarcode.Text, cmbSearchMethod.SelectedIndex);

                if (dTable.Rows.Count == 1 && dTable.Rows[0][0].ToString() != "")
                {
                    DialogResult resultCart = Animation.resultModal(new frmPurchaseCart(dTable.Rows[0]["item_id"].ToString(), "0"));

                    if (resultCart == DialogResult.Yes) viewPurchaseCart();
                }
                else if (dTable.Rows.Count==0)
                {
                    DialogResult result = MessageBox.Show("The Item is Not Found... D you want to create new One?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //Animation.resultModal(new frmPurchaseCart("0", "0"));

                        DialogResult resultCart=Animation.resultModal(new frmStockForm(0, 0) { is_from_stock=false});
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Name or Code");
                }

                txtBarcode.Focus();
                txtBarcode.SelectAll();
            }
        }

        private void fileSaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        //Add To Purchase Cart
        

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmPeople("0",true));
        }

        void updateDatagridviewOnChanges()
        {
            if (dgvGrid.Rows.Count > 0)
            {
                DataTable dTable = (DataTable)dgvGrid.DataSource;

                if (txtDiscount.Text.Trim() == "") discount = 0;
                else discount = Convert.ToDecimal(txtDiscount.Text.Trim());

                totalPurchase = (decimal)dTable.Compute("Sum(total)", "True");
                //indirectPurchaseAmount = (decimal)dTable.Compute("Sum(indirect_total)","True");
                netTotal = (totalPurchase - discount);
                txtTotal.Text = "Rs. " + totalPurchase.ToString("N2");
                lblPurchasTotalAmount.Text = "Rs. " + netTotal.ToString("N2");
            }
            else
            {
                lblPurchasTotalAmount.Text = "Rs. 0";
            }
        }

        private void txtRefrenceNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSupplier_TextChanged(object sender, EventArgs e)
        {
            Global.supplierName = btnSupplier.Text;
            Global.supplierTag = btnSupplier.Tag.ToString();
            people.id = btnSupplier.Tag.ToString();

            if (btnSupplier.Text.ToUpper() != "select your supplier".ToUpper())
            {
                DataTable dTable = purchase.findPurchaseRefrenceBySupplier(int.Parse(Global.supplierTag));

                Global.showSuggestion(dTable, txtRefrenceNo);

                btnViewCheque.Enabled = btnMakePayment.Enabled = btnPaymentHistory.Enabled = btnPurchase.Enabled = btnPurchaseItems.Enabled = true;
            }
            else
            {
                btnViewCheque.Enabled = btnMakePayment.Enabled = btnPaymentHistory.Enabled = btnPurchase.Enabled = btnPurchaseItems.Enabled = false;
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            try
            {
                bool is_stock = false;
                DialogResult result = MessageBox.Show("Do you want to update stock from this purchase order?", "Confirmation", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == result) is_stock = true;

                if (btnSupplier.Tag.ToString() == "0")
                {
                    MessageBox.Show("Please Select a Supplier");
                    btnSupplier.PerformClick();
                }
                else if (dgvGrid.Rows.Count <= 0)
                {
                    MessageBox.Show("Please add purchase Items");
                }
                else
                {
                    if (txtRefrenceNo.Text.Trim() == "") txtRefrenceNo.Text = "0";

                    purchase.peopleID = int.Parse(btnSupplier.Tag.ToString());
                    purchase.paid_amount = 0;
                    purchase.total = netTotal;
                    purchase.purchaseDate = dtpPurchseDate.Text;
                    purchase.note = "";
                    purchase.refrenceNo = txtRefrenceNo.Text;
                    purchase.discount = discount;

                    if (purchase.insertPurchase(is_stock))
                    {
                        viewPurchaseCart();

                        //Update Vendor Balance
                        new People().updatePeopleBalance(purchase.peopleID, -1 * purchase.total);

                        //Update Stock Alert
                        Global.stockAlertCount();

                        Animation.showMessage("Successfully Added", "success");
                    }
                }
            }
            catch (Exception exc) { Animation.showMessage(exc.Message, "error"); }
            
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            txtBarcode.SelectAll();
        }

        private void txtRefrenceNo_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode==Keys.Enter && btnSupplier.Text!= "select your supplier")
            //{
            //    int purchaseID=purchase.findPurchaseIDbyRefrenceNo(txtRefrenceNo.Text.Trim(),btnSupplier.Tag.ToString());

            //    if(purchaseID!=0)
            //    {
            //        MessageBox.Show("Purchase Items Will be Shown here");
                    
            //    }
            //}
        }

        private void linkSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnSupplier.Tag.ToString() != "0")
            {
                Animation.showSideModal(new frmPeopleDetail(btnSupplier.Tag.ToString(), btnSupplier.Text,true));
            }
        }

        private void btnViewCheque_Click(object sender, EventArgs e)
        {
            frmViewCheque viewCheque = new frmViewCheque(Convert.ToInt32(people.id), true);
            //viewCheque.Tag = new Payment(true);
            Animation.showModal(viewCheque);
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            ucPaymentLog paymentLog = new ucPaymentLog(Convert.ToInt32(people.id), true, btnSupplier.Text);
            frmViewModal paymentForm = new frmViewModal("Payment History");
            paymentForm.Tag = paymentLog;
            Animation.resultModal(paymentForm);
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            var result = Animation.resultModal(new frmPayment(0, 0, Convert.ToInt32(people.id), 0, true, true));
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ucPurchase purchase = new ucPurchase(people.id,btnSupplier.Text,true);
            frmViewModal purchaseForm = new frmViewModal("Purchase History");
            purchaseForm.Tag = purchase;
            Animation.showModal(purchaseForm);
        }

        private void btnPurchaseItems_Click(object sender, EventArgs e)
        {
            ucPurchase purchase = new ucPurchase(people.id, btnSupplier.Text, false);
            frmViewModal purchaseForm = new frmViewModal("Purchase History");
            purchaseForm.Tag = purchase;
            Animation.showModal(purchaseForm);
        }

        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cartID = dgvGrid.SelectedRows[0].Cells["cellCartID"].Value.ToString();
            if (dgvGrid.Columns[e.ColumnIndex].Name == "cellRemove")
            {       
                if(cartPurchase.deletePurchaseCart(cartID))
                {
                    dgvGrid.Rows.RemoveAt(dgvGrid.SelectedRows[0].Index);
                    updateDatagridviewOnChanges();
                }

            }
            else if (dgvGrid.Columns[e.ColumnIndex].Name == "cellItem")
            {
                string itemID = dgvGrid.SelectedRows[0].Cells["cellItemID"].Value.ToString();
                Animation.showModal(new frmStockForm(Convert.ToInt32(itemID)) { is_from_stock = false });
            }
            else if (dgvGrid.Columns[e.ColumnIndex].Name == "cellPrice")
            {
                DialogResult resultCart = Animation.resultModal(new frmPurchaseCart("0", cartID));
                if (resultCart == DialogResult.Yes)viewPurchaseCart();
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Trim() == "") discount = 0;
            else discount=Convert.ToDecimal(txtDiscount.Text.Trim());

            netTotal = (totalPurchase - discount);
            lblPurchasTotalAmount.Text = "Rs. " + netTotal.ToString("N2");
        }

        private void focusOnBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBarcode.Focus();
            txtBarcode.SelectAll();
        }
    }
}
