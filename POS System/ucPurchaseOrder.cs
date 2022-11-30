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
using System.Text.RegularExpressions;

namespace POS_System
{
    public partial class ucPurchaseOrder : UserControl
    {
        public ucPurchaseOrder()
        {
            InitializeComponent();

            Global.changeTabControlStyle(tabControl);
            Validation.numbersOnly(txtQuantity);
        }

        PurchaseOrder purchaseOrder = new PurchaseOrder();

        void viewCart()
        {
            dgvCart.DataSource = purchaseOrder.viewPurchaseCart();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageOrder;
            dgvOrder.DataSource = purchaseOrder.viewPurchaseOrder();
        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = pageForm;
            dgvOrderProduct.DataSource = purchaseOrder.viewAlertProducts();
            purchaseOrder.orderID = "0";
            btnComplete.Text = "COMPLETE";
            viewCart();
            btnSupplier.Text = "SELECT YOUR SUPPLIER";
            btnSupplier.Tag = "0";        
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvOrderProduct.DataSource = purchaseOrder.viewProductByQuantity(txtQuantity.Text.Trim(),cmbUnit.Text);
        }

        private void dgvOrderProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvOrderProduct.Columns["cellAdd"].Index)
            {
                purchaseOrder.itemID = dgvOrderProduct.SelectedRows[0].Cells["cellItemID"].Value.ToString();
                purchaseOrder.quantity = Global.numberInput();
                
                if(purchaseOrder.insertPurchaseOrderCart())
                {
                    viewCart();
                }
            }
        }

        private void ucPurchaseOrder_Load(object sender, EventArgs e)
        {
            DataTable dTableUnit = new unit().viewunit();
            DataRow catRow = dTableUnit.NewRow();
            catRow["unit_id"] = 0;
            catRow["unit_type"] = "All Unit";
            dTableUnit.Rows.InsertAt(catRow, 0);

            cmbUnit.DataSource = dTableUnit;
            cmbUnit.ValueMember = "unit_id";
            cmbUnit.DisplayMember = "unit_type";

            cmbUnit.SelectedIndex = 0;

            viewCart();
            dgvOrderProduct.DataSource = purchaseOrder.viewAlertProducts();
        }

        private void dgvCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvCart.Columns["cellCartQty"].Index)
            {
                string cartID = dgvCart.SelectedRows[0].Cells["cellCartID"].Value.ToString();
                string qty = dgvCart.SelectedRows[0].Cells["cellCartQty"].Value.ToString();
                string numberOnly = Regex.Replace(qty, "[^0-9.]", "");
                purchaseOrder.quantity = Global.numberInput(numberOnly);         

                if (purchaseOrder.updatePurchaseOrderCart(cartID))
                {
                    viewCart();
                }
            }
            else if (e.ColumnIndex == dgvCart.Columns["cellCartRemove"].Index)
            {
                string cartID = dgvCart.SelectedRows[0].Cells["cellCartID"].Value.ToString();

                if (purchaseOrder.deletePurchaseOrderCart(cartID))
                {
                    dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
                }
            }
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (btnSupplier.Tag.ToString() == "0") MessageBox.Show("Please Select a Supplier");
            else
            {
                
                purchaseOrder.supplierID = btnSupplier.Tag.ToString();
               if( btnComplete.Text=="COMPLETE" && purchaseOrder.insertPurchaseOrder())
                {
                    MessageBox.Show("Order Saved");
                    viewCart();
                    btnSupplier.Text = "SELECT YOUR SUPPLIER";
                    btnSupplier.Tag = "0";
                }
               else if (btnComplete.Text == "UPDATE" && purchaseOrder.updatePurchaseOrder(purchaseOrder.orderID))
                {
                    MessageBox.Show("Supplier Changed");
                    btnOrderForm.PerformClick();
                }
            }
        }

        private void dgvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string orderID = dgvOrder.SelectedRows[0].Cells["cellOrderID"].Value.ToString();

            if (e.ColumnIndex == dgvOrder.Columns["cellEdit"].Index)
            {
                btnSupplier.Text = dgvOrder.SelectedRows[0].Cells["cellSupplier"].Value.ToString();
                btnSupplier.Tag = dgvOrder.SelectedRows[0].Cells["cellSupplierID"].Value.ToString();
                btnComplete.Text = "UPDATE";
                purchaseOrder.orderID = orderID;
                tabControl.SelectedTab = pageForm;
                viewCart();
            }
            else if (e.ColumnIndex == dgvOrder.Columns["cellStatus"].Index)
            {
                string status = dgvOrder.SelectedRows[0].Cells["cellStatus"].Value.ToString();

                if (status == "Pending") status = "Completed";
                else if (status == "Completed") status = "Pending";

                if(purchaseOrder.changeOrderStatus(status,orderID))
                {
                    dgvOrder.SelectedRows[0].Cells["cellStatus"].Value = status;
                }
            }
            else if (e.ColumnIndex == dgvOrder.Columns["cellOrderPrint"].Index)
            {
                new frmPurchaseOrderPrint() { orderID = orderID}.ShowDialog();
            }
        }

        void filterOrder()
        {
            if(cmbOrderStatus.Text !="All")
            (dgvOrder.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("name LIKE '{0}%' AND status LIKE '{1}'", txtSupplierSearch.Text,cmbOrderStatus.Text);
            else
            {
                (dgvOrder.DataSource as DataTable).DefaultView.RowFilter =
                string.Format("name LIKE '{0}%'",txtSupplierSearch.Text);
            }
        }

        private void txtSupplierSearch_TextChanged(object sender, EventArgs e)
        {
            filterOrder();
        }

        private void cmbOrderStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterOrder();
        }
    }
}
