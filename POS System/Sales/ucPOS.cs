using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using DataLibrary;

namespace POS_System
{
    public partial class ucPOS : UserControl
    {
        Validation validation = new Validation();
        Item items = new Item();
        Cart cart = new Cart();
        People people = new People();
        Category category = new Category();

        string cartID,discountInput;
        decimal netTotal, discount,subtotal,profit;
        DataTable dTablePos = new DataTable();

        public ucPOS()
        {
            InitializeComponent();
            Validation.numbersOnly(txtTotal);
        }

        //Finalize total amount
        void finalizeTotal()
        {
            if (dgvPOS.Rows.Count > 0)
            {
                if (txtDiscount.Text.Trim() == "") discountInput = "0";
                else discountInput = txtDiscount.Text.Trim();

                dTablePos = (DataTable)dgvPOS.DataSource;
                decimal sum = (decimal)(dTablePos.Compute("Sum(total)", "True"));
                profit = (decimal)(dTablePos.Compute("Sum(profit)", "True"));

                txtTotal.Text = sum.ToString("0.00");

                discount = decimal.Parse(discountInput);
                subtotal = decimal.Parse(txtTotal.Text);

                netTotal = subtotal - discount;

                lblTotal.Text = "Rs." + netTotal.ToString("0.00");
            }
            else
            {
                lblTotal.Text = "Rs.0";
                txtTotal.Text = "0";
                txtDiscount.Text = "0";
                netTotal = 0;
            }
        }

        //Show Pos Items
        void fillItemsinPOSView(DataTable dTable)
        {
            try {
                panelProductContainer.Controls.Clear();

                if (dTable.Rows.Count != 0)
                {
                    lblMessage.Visible = false;
                    foreach (DataRow row in dTable.Rows)
                    {
                        if (row["item_id"].ToString() != "")
                        {
                            panelProductContainer.Controls.Add(new ucPOSItem(row["item_id"].ToString(), row["itm_name"].ToString(), row["sale_price"].ToString(), row["brand_name"].ToString()));
                        }
                    }
                }
                else
                {
                    lblMessage.Dock = DockStyle.Top;
                    lblMessage.Width = panelProductContainer.Width - 10;
                    panelProductContainer.Controls.Add(lblMessage);
                    lblMessage.Visible = true;
                }
                txtProductSearch.SelectAll();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }     
        }

        //Load Side Menu (Categories and others)
        async void loadSideMenu()
        {
            DataTable dTable = new DataTable();
            await Task.Run(() =>
            {
                dTable = category.viewCategory();
            });

            for (int i = 0; i < dTable.Rows.Count; i++)
            {
                Guna2Button button = new Guna2Button();

                // btnMenu
                // 
                button.Animated = true;
                button.BorderRadius = 5;
                button.BackColor = btnMenu.BackColor;
                button.CheckedState.Parent = this.btnMenu;
                button.CustomImages.Parent = this.btnMenu;
                button.Font = btnMenu.Font;
                button.ButtonMode = btnMenu.ButtonMode;
                button.ForeColor = this.btnMenu.ForeColor;
                button.HoverState.Parent = this.btnMenu;
                button.Location = btnMenu.Location;
                button.ShadowDecoration.Parent = this.btnMenu;
                button.Size = this.btnMenu.Size;
                button.Tag = dTable.Rows[i]["category_id"].ToString();
                button.Text = dTable.Rows[i]["category_name"].ToString();
                button.Click += new EventHandler(btnMenu_Click);

                pnlSideBar.Controls.Add(button);
            }
        }

        void loadProductName()
        {
            DataTable dTable = new Item().fillItemWithBrand();
            Global.showSuggestion(dTable,txtProductSearch);
        }

        //User Control Load
        private async void ucPOS_Load(object sender, EventArgs e)
        {
            //Set dgvPOS Datagridview static for accessing from anywhere
            Global.dataGrid = dgvPOS;

            await Task.Delay(500);

            //Fill People list
            DataTable dtPeople = people.fillPeople(false);

            //View Cart Details
            dgvPOS.DataSource = cart.viewCart();

            fillItemsinPOSView(items.itemViewByFeatured());

            txtProductSearch.Focus();

            loadSideMenu();
            loadProductName();
        }

        //Assign cart total 
        private void dgvPOS_DataSourceChanged(object sender, EventArgs e)
        {      
            finalizeTotal();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            finalizeTotal();
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Trim() == "")
            {
                txtDiscount.Text = "0";
            }
            finalizeTotal();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                finalizeTotal();
            }
        }

        private void dgvPOS_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        //Go to Payment Process
        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (dgvPOS.Rows.Count > 0)
            {
                int peopleID = int.Parse(btnCustomer.Tag.ToString());

                frmPayment paymentform = new frmPayment(netTotal, discount, peopleID, 0,false,false,profit,0,txtReference.Text.Trim());

                var result = Animation.resultModal(paymentform);

                //Only Save Invoice / Purchase
                if (result == DialogResult.No)
                {
                    dgvPOS.DataSource = cart.viewCart();
                    txtReference.ResetText();
                    Global.todaySalesCount();
                }

                //Save Invoice and Print
                else if (result == DialogResult.Yes)
                {
                    dgvPOS.DataSource = cart.viewCart();
                    txtReference.ResetText();
                    Global.todaySalesCount();
                    new frmBillPrint(paymentform.invoiceID).ShowDialog();
                }
            }
            else MessageBox.Show("Empty Bills");
        }

        private void txtProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataTable dTable = items.itemSearchinPOS(txtProductSearch.Text,cmbSearchMethod.SelectedIndex);

                if (dTable.Rows.Count == 1)
                {
                    if (dTable.Rows[0][0].ToString() != "")
                    {
                        dgvPOS.DataSource = cart.insertCart(dTable.Rows[0][0].ToString(), Global.numberInput());
                    }

                    fillItemsinPOSView(dTable);
                }
                else //If search result is more than an item that will be displayed in pos view
                {
                    fillItemsinPOSView(dTable);
                }

                txtProductSearch.Focus();
                txtProductSearch.SelectAll();
            }
        }

        private void txtProduct_Enter(object sender, EventArgs e)
        {
            txtProductSearch.SelectAll();
        }

        //Select customer from a dropdown form
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            frmClientView people = new frmClientView(false);
            people.ctrl = btnCustomer;
            people.StartPosition = FormStartPosition.Manual;

            Point location = ((Control)sender).PointToScreen(Point.Empty);

            people.Left = (location.X - people.Width) + ((Control)sender).Width;
            people.Top = (location.Y) + ((Control)sender).Height + 3;

            Animation.showListModal(people);
        }

        private void dgvPOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cartID = dgvPOS.SelectedRows[0].Cells["cellCartID"].Value.ToString();

            if (e.ColumnIndex==dgvPOS.Columns["cellQuantity"].Index)
            {
                string oldQty = dgvPOS.SelectedRows[0].Cells["cellQuantity"].Value.ToString();
                decimal quantity =Global.numberInput(oldQty);

                if(quantity==0)
                {
                    cart.deleteFromCart(cartID);
                    dgvPOS.DataSource = cart.viewCart();
                }
                else
                {
                    cart.updateQty(cartID,quantity);
                    dgvPOS.DataSource = cart.viewCart();
                }
            }
            else if (e.ColumnIndex == dgvPOS.Columns["cellPrice"].Index)
            {
                string price = dgvPOS.SelectedRows[0].Cells["cellPrice"].Value.ToString();
                string quantity = dgvPOS.SelectedRows[0].Cells["cellQuantity"].Value.ToString();
                string discount = dgvPOS.SelectedRows[0].Cells["cellDiscount"].Value.ToString();

                bool result = cart.updateCart(cartID,Convert.ToDecimal(quantity), Convert.ToDecimal(discount),Global.numberInput(price));

                if(result) dgvPOS.DataSource = cart.viewCart();
                //frmCartEdit frm = new frmCartEdit(cartID, price, discount, quantity, batchNo);

                //var result = Animation.resultModal(frm);

                //if (result == DialogResult.Yes) { dgvPOS.DataSource = cart.viewCart(); }
            }
            else if (e.ColumnIndex == dgvPOS.Columns["cellDiscount"].Index)
            {
                string price = dgvPOS.SelectedRows[0].Cells["cellPrice"].Value.ToString();
                string quantity = dgvPOS.SelectedRows[0].Cells["cellQuantity"].Value.ToString();
                string discount = dgvPOS.SelectedRows[0].Cells["cellDiscount"].Value.ToString();

                bool result = cart.updateCart(cartID, Convert.ToDecimal(quantity), Global.numberInput(discount), Convert.ToDecimal(price));

                if (result) dgvPOS.DataSource = cart.viewCart();
            }
            else if (e.ColumnIndex == dgvPOS.Columns["cellProductName"].Index)
            {
                string itemID = dgvPOS.SelectedRows[0].Cells["cellProductID"].Value.ToString();
                Animation.showModal(new frmStockForm(Convert.ToInt32(itemID)) { is_from_stock = false });
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmPeople());
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (((Control)sender).Tag.ToString() == "Featured") fillItemsinPOSView(items.itemViewByFeatured());
            else fillItemsinPOSView(items.itemViewbyCategory(((Control)sender).Tag.ToString()));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cart.clearCart())
            {
                dgvPOS.DataSource = cart.viewCart();
            }

        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(btnCustomer.Tag.ToString());

            if (btnCustomer.Tag.ToString() != "1")
            {
                //Animation.showModal(new frmAccountDetails(customerID, btnCustomer.Text));
                Animation.showSideModal(new frmPeopleDetail(btnCustomer.Tag.ToString(), btnCustomer.Text, false));
            }
        }

        private void btnCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void focusOnBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtProductSearch.Focus();
            txtProductSearch.SelectAll();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            frmQuickCash cashForm = new frmQuickCash(netTotal, btnCustomer.Tag.ToString(), profit, 0, discount,txtReference.Text.Trim());

            DialogResult result = Animation.resultModal(cashForm);

            if(result == DialogResult.Yes)
            {
                dgvPOS.DataSource = cart.viewCart();
                txtReference.ResetText();
                Global.todaySalesCount();
                int invoice = cashForm.invoiceID;
                new frmBillPrint(invoice.ToString()).ShowDialog();
            }
        }

        private void btnViewBill_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmBillProfit((DataTable)dgvPOS.DataSource));
        }

        private void dgvPOS_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            finalizeTotal();
        }

        private void linkDiscount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txtDiscount.Text=Global.numberInput(txtDiscount.Text).ToString();
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            decimal discount = decimal.Parse(txtDiscount.Text);
            decimal findDiscount = (subtotal * discount) / 100;
            txtDiscount.Text = findDiscount.ToString();
            finalizeTotal();
        }
    }
}
