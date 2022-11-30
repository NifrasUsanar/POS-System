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
    public partial class frmSaleView : Form
    {
        public int invoiceID { get; set; }
        public string peopleID { get; set; }

        Invoice invoice = new Invoice();
        Payment payment = new Payment(is_supplier: false);
        Item item = new Item();

        public frmSaleView()
        {
            InitializeComponent();

            Global.changeTabControlStyle(tabControl);
            Validation.numbersOnly(txtDiscount);
        }

        DataTable dTableProducts = new DataTable();
        decimal billTotal,discount,profit;
        void findInvoice()
        {
            DataTable dTable = invoice.findInvoice(invoiceID.ToString());
            if (dTable.Rows.Count > 0)
            {
                txtDiscount.Text = dTable.Rows[0]["discount"].ToString();
                txtReference.Text = dTable.Rows[0]["reference"].ToString();
                dtpDate.Text = dTable.Rows[0]["created_at"].ToString();
                btnCustomer.Tag = dTable.Rows[0]["people_id"].ToString();
                btnCustomer.Text = dTable.Rows[0]["name"].ToString();
                cmbStatus.Text = dTable.Rows[0]["status"].ToString();

                if (cmbStatus.Text == "Open") pnlSaleCustomize.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invalid Invoice or Sale Invoice Might Be Removed");
                this.Close();
            }
        }

        void findTotal()
        {
            if (txtDiscount.Text.Trim() == "") txtDiscount.Text = "0";
            discount = Convert.ToDecimal(txtDiscount.Text.Trim());

            DataTable dTable = (dgvItems.DataSource as DataTable).DefaultView.ToTable();

            if(dTable.Rows.Count>0)
            {
                chipItems.Text = $"{dTable.Compute("COUNT(id)", "True")}";               

                profit = Convert.ToDecimal(dTable.Compute("SUM(profit)", "True").ToString());
                billTotal =Convert.ToDecimal(dTable.Compute("SUM(item_total)", "True").ToString());
                chiptTotal.Text = $"Rs. {(billTotal-discount).ToString("N2")}";
                chipProfit.Text = $"Rs. {profit.ToString("N2")}";
            }
            else
            {
                profit = 0;
                billTotal = 0;
                chipProfit.Text = "Rs.0.00";
                chipItems.Text = "0";
                chiptTotal.Text = $"{(billTotal-discount).ToString("N2")}";
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabViewItems;
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabViewPayment;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(cmbStatus.Text=="Open")
            {
                DialogResult result = MessageBox.Show("The Bill is Open... Do you really want keep open this bill?", "Confirmation", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else this.Close();
        }

        private void frmSaleView_Shown(object sender, EventArgs e)
        {
            findInvoice();
            dgvItems.DataSource = invoice.findInvoiceItems(invoiceID.ToString());
            dgvCustomerPayment.DataSource = payment.viewPaymentLogByRefrenceID(invoiceID);
            findTotal();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbStatus.Text == "Closed")
            {
                MessageBox.Show("Closed Bill Cannot Be Edited");
            }
            else
            {
                string itemID = dgvItems.SelectedRows[0].Cells["cellItemID"].Value.ToString();
                string cartID = dgvItems.SelectedRows[0].Cells["cellCartID"].Value.ToString();

                if (dgvItems.Columns[e.ColumnIndex].Name == "cellPrice")
                {
                    string qty = dgvItems.SelectedRows[0].Cells["cellQty"].Value.ToString();
                    string discount = dgvItems.SelectedRows[0].Cells["cellDiscount"].Value.ToString();
                    string price = dgvItems.SelectedRows[0].Cells["cellPrice"].Value.ToString();

                    DialogResult result = new frmCartEdit(cartID, price, discount, qty) { TopMost = true, itemID = itemID }.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        dgvItems.DataSource = invoice.findInvoiceItems(invoiceID.ToString());
                        findTotal();
                        Global.stockAlertCount();
                    }
                }
                else if (dgvItems.Columns[e.ColumnIndex].Name == "cellQty")
                {
                    decimal qty = Convert.ToDecimal(dgvItems.SelectedRows[0].Cells["cellQty"].Value.ToString());

                    DialogResult result = new frmAdjustSoldQuantity() { qty = qty, StartPosition = FormStartPosition.CenterScreen, TopMost = true, invoiceID = invoiceID, itemID = itemID, cartID= cartID }.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        dgvItems.DataSource = invoice.findInvoiceItems(invoiceID.ToString());
                        findTotal();
                        Global.stockAlertCount();
                    }
                }
                else if (dgvItems.Columns[e.ColumnIndex].Name == "cellItem")
                {
                    Animation.showModal(new frmStockForm(Convert.ToInt32(itemID)) { is_from_stock=false});
                }
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            findTotal();
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                findTotal();
            }
        }

        private void cmbStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if(cmbStatus.Text=="Open" && pnlSaleCustomize.Enabled==false)
            {
                DialogResult result = MessageBox.Show("Do you really want to re-open this bill?... It will reverse customer balance...","Confirmation",MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    invoice.updateInvoice(invoiceID, btnCustomer.Tag.ToString(), "Open", "+");
                    pnlSaleCustomize.Enabled = true;
                }
                else cmbStatus.SelectedIndex = 0;
            }
            else if (cmbStatus.Text=="Closed" && pnlSaleCustomize.Enabled == true)
            {
                DialogResult result = MessageBox.Show("Are you sure to close this Bill?...", "Confirmation", MessageBoxButtons.YesNo);
                
                if(result==DialogResult.Yes)
                {
                    btnSave.PerformClick();
                    invoice.updateInvoice(invoiceID, btnCustomer.Tag.ToString(), "Closed", "-");
                    pnlSaleCustomize.Enabled = false;
                }
                else cmbStatus.SelectedIndex = 1;
            }
        }

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

        void addToSoldItems(DataTable dTable)
        {
            DataTable dTableItems = (DataTable)dgvItems.DataSource;
            int numberOfRecord = dTableItems.Select($"item_id = {dTable.Rows[0]["item_id"].ToString()}").Length;

            if(numberOfRecord>0)
            {
                DialogResult result = MessageBox.Show("The Item is already added... Do you want to add this item again?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result==DialogResult.Yes)
                {
                    if (invoice.insertNewSoldItem(invoiceID, dTable.Rows[0]["item_id"].ToString(), Global.numberInput()))
                    {
                        dgvItems.DataSource = invoice.findInvoiceItems(invoiceID.ToString());
                        findTotal();
                    }
                }
            }
            else
            {
                if(invoice.insertNewSoldItem(invoiceID, dTable.Rows[0]["item_id"].ToString(),Global.numberInput()))
                {
                    dgvItems.DataSource = invoice.findInvoiceItems(invoiceID.ToString());
                    findTotal();
                }
            }
        }

        private void txtProductSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dTable = item.itemSearchinPOS(txtProductSearch.Text, cmbSearchMethod.SelectedIndex);

                if (dTable.Rows.Count == 1)
                {
                    if (dTable.Rows[0][0].ToString() != "")
                    {
                        addToSoldItems(dTable);
                        //dgvPOS.DataSource = new Cart().insertCart(dTable.Rows[0][0].ToString(), Global.numberInput());
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

        private void dgvCustomerPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmbStatus.Text == "Closed")
            {
                string peopleID = dgvCustomerPayment.SelectedRows[0].Cells["cellPeopleID"].Value.ToString();

                if (dgvCustomerPayment.Columns[e.ColumnIndex].Name == "cellRemove")
                {
                    string paymentID = dgvCustomerPayment.SelectedRows[0].Cells["cellPaymentID"].Value.ToString();
                    string amount = dgvCustomerPayment.SelectedRows[0].Cells["cellAmount"].Value.ToString();
                    string paymentType = dgvCustomerPayment.SelectedRows[0].Cells["cellDescription"].Value.ToString();

                    if (paymentType == "Cheque")
                    {
                        MessageBox.Show("Cheque Cannot Removed from Here... Please choose Cheque Section", "error");
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Do you really want to delete this payment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes && new Payment(false).removePayment(paymentID, amount, peopleID))
                        {
                            dgvCustomerPayment.Rows.RemoveAt(dgvCustomerPayment.SelectedRows[0].Index);

                        }
                    }
                }
            }
            else MessageBox.Show("Please Close the Bill First");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDiscount.Text.Trim() == "") txtDiscount.Text = "0";

            invoice.discount = discount;
            invoice.total = (billTotal - discount);
            invoice.profit = profit;
            invoice.reference = txtReference.Text.Trim();
            invoice.peopleID = Convert.ToInt32(btnCustomer.Tag.ToString());
            invoice.created_at = Validation.convertDate(dtpDate);

            if(invoice.updateInvoiceDetails(invoiceID))
            {
                MessageBox.Show("Invoice Details Updated");
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbStatus.Text=="Open")
            {
                if(dTableProducts.Rows.Count<=0)
                {
                    dTableProducts =item.fillItemWithBrand();
                    Global.showSuggestion(dTableProducts,txtProductSearch);

                }
            }
        }
    }
}
