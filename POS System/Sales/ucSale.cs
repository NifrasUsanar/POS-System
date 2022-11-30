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
    public partial class ucSale : UserControl
    {
        Invoice invoice = new Invoice();
        public ucSale(string peopleName= "select your customer", string peopleID="0", bool is_sale=true, bool is_edit=false)
        {
            InitializeComponent();

            dtpStart.Value = dtpEnd.Value= DateTime.Now;

            Global.changeTabControlStyle(tabControl);

            btnCustomer.Text = peopleName;
            btnCustomer.Tag = peopleID;

            if (is_sale) cmbMode.SelectedIndex = 0;
            else cmbMode.SelectedIndex = 1;
        }

        void countOpenSale()
        {
            string openSale = invoice.countOpenSale();
            if (openSale != "0" && openSale.Trim() != "")
            {
                linkMessage.Visible = true;
                linkMessage.Text = openSale + " Sale(s) are open... Click here to view them";
            }
            else linkMessage.Visible = false;
        }

        string saleProfit;
        bool is_sale_profit = false;
        void sumTotalOfSale()
        {
            DataTable dTable = (dgvStock.DataSource as DataTable).DefaultView.ToTable();

            if (dTable.Rows.Count > 0)
            {
                chipTotal.Text = $"Rs. {dTable.Compute("SUM(total)", "True"):N2}";
                saleProfit = $"Rs. {dTable.Compute("SUM(profit)", "True"):N2}";
            }
            else
            {
                chipTotal.Text = "Rs. 0.00";
                chipSaleProfit.Text = "Rs. 0.00";
            }

            if (is_sale_profit) chipSaleProfit.Text = saleProfit;
            else chipSaleProfit.Text = "0";
        }

        void viewSale()
        {
            if (cmbMode.SelectedIndex == 0)
            {
                dgvStock.DataSource = invoice.viewInvoice(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd), btnCustomer.Tag.ToString());

                sumTotalOfSale();
            }
            else
            {
                dgvSoldItems.DataSource = invoice.viewSoldItems(Validation.convertDate(dtpStart), Validation.convertDate(dtpEnd), btnCustomer.Tag.ToString());
            }

            sumOfSoldProfit();
        }

        void filterSale()
        {
            string filterQry = "";
            string search = txtSalesSearch.Text.Trim();

            if (cmbSalesSearchMod.SelectedIndex == 1) filterQry = $"(CONVERT(id,System.String) LIKE '{search}%')";
            else if (cmbSalesSearchMod.SelectedIndex == 0) filterQry = $"(name LIKE '{search}%')";

            //if (cmbSalesStatus.SelectedIndex != 0) filterQry += $" AND (status LIKE '{cmbSalesStatus.Text}')";

            if ((dgvStock.DataSource as DataTable) != null)
            {
                (dgvStock.DataSource as DataTable).DefaultView.RowFilter = filterQry+$" AND (reference LIKE '{txtReference.Text.Trim()}%')";
            }

            sumTotalOfSale();
        }

        void filterSoldItems()
        {
            string filterQRY = "";
            string search = txtItemsSearch.Text.Trim();

            if (cmbSearchModItems.SelectedIndex == 0) filterQRY = $"(name LIKE '{search}%')";
            else if (cmbSearchModItems.SelectedIndex == 1) filterQRY = $"(invoice LIKE '{search}%')";
            else if (cmbSearchModItems.SelectedIndex == 2) filterQRY = $"(itm_name LIKE '{search}%')";
            else if (cmbSearchModItems.SelectedIndex == 3) filterQRY = $"(note LIKE '%{search}%')";

            if ((dgvSoldItems.DataSource as DataTable) !=null)
            {
                (dgvSoldItems.DataSource as DataTable).DefaultView.RowFilter = filterQRY;
            }

            sumOfSoldProfit();
        }

        string soldProfit = "";
        void sumOfSoldProfit()
        {
            if (cmbMode.SelectedIndex==1)
            {
                if (dgvSoldItems.Rows.Count > 0)
                {
                    DataTable dTable = (dgvSoldItems.DataSource as DataTable).DefaultView.ToTable();
                    soldProfit = $"Rs.{ dTable.Compute("Sum(profit)", "True"):N2}";
                    chipLineTotal.Text = $"Rs. { dTable.Compute("Sum(line_amount)", "True"):N2}";
                    chipQuantity.Text = $"{ dTable.Compute("Sum(item_quantity)", "True"):N2}";
                }
                else
                {
                    chipSoldItemsProfit.Text = "Rs. 0.00";
                    chipLineTotal.Text = "Rs. 0.00";
                    chipQuantity.Text = "0.00";
                }
            }

            if (lblProfit.Text == "HIDE PROFIT") chipSoldItemsProfit.Text = soldProfit;
            else chipSoldItemsProfit.Text = "0";
        }

        private void ucSale_Load(object sender, EventArgs e)
        {
            if(!Global.is_admin) btnDelete.Visible = false;

            //viewSale();
            countOpenSale();
        }

        //Cell Button Click
        private void dgvStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (dgvStock.Columns[e.ColumnIndex].Name == "btnPrint")
            {
                frmBillPrint billPrint=new frmBillPrint(dgvStock.SelectedRows[0].Cells["saleid"].Value.ToString());

                billPrint.Show();
            }
            else if(dgvStock.Columns[e.ColumnIndex].Name == "btnAddPayment")
            {
                int invoiceno = int.Parse(dgvStock.SelectedRows[0].Cells["saleid"].Value.ToString());
                int peopleid = int.Parse(dgvStock.SelectedRows[0].Cells["peopleid"].Value.ToString());

                decimal total = decimal.Parse(dgvStock.SelectedRows[0].Cells["total"].Value.ToString());

                decimal paidamount = decimal.Parse(dgvStock.SelectedRows[0].Cells["paidamount"].Value.ToString());
                decimal discount = decimal.Parse(dgvStock.SelectedRows[0].Cells["discount"].Value.ToString());

                if (paidamount >= total) MessageBox.Show("Payment Fully Completed");
                else
                {
                    new frmPayment(total-paidamount, discount, peopleid, invoiceno).ShowDialog();
                    viewSale();
                }
            }
            else if (dgvStock.Columns[e.ColumnIndex].Name == "saleid")
            {
                string peopleid = dgvStock.SelectedRows[0].Cells["peopleid"].Value.ToString();
                using (frmSaleView salesview = new frmSaleView() {peopleID=peopleid })
                {
                    salesview.invoiceID = int.Parse(dgvStock.SelectedRows[0].Cells["saleid"].Value.ToString());
                    //Animation.showModal(salesview);
                    salesview.ShowDialog();
                }
            }
             else if (dgvStock.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int invoiceno = int.Parse(dgvStock.SelectedRows[0].Cells["saleid"].Value.ToString());
                DialogResult result = MessageBox.Show("This will not change any record... Do you really want to delete this sale?","Confirmation", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if(result==DialogResult.Yes && invoice.removeInvoice(invoiceno))
                {
                    dgvStock.Rows.RemoveAt(dgvStock.SelectedRows[0].Index);
                    sumTotalOfSale();
                }
            }
            //else if (dgvStock.Columns[e.ColumnIndex].Name == "cellSelect")
            //{
            //    string saleID = dgvStock.SelectedRows[0].Cells["saleid"].Value.ToString();

            //    if(new Cart().insertSaleForEdit(saleID))
            //    {
            //        Global.btnEditSale.Text = saleID;
            //        Global.btnEditSale.Tag = saleID;
            //        Global.frmViewModal.Close();
            //    }
            //}
        }

        private void cmbMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = cmbMode.SelectedIndex;
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

        private void linkCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            btnCustomer.Text = "select your customer";
            btnCustomer.Tag = "0";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewSale();
            countOpenSale();
        }

        private void txtSalesSearch_TextChanged(object sender, EventArgs e)
        {
            filterSale();
        }

        private void cmbSalesStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterSale();
        }

        private void cmbSalesSearchMod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterSale();
        }

        private void txtItemsSearch_TextChanged(object sender, EventArgs e)
        {
            filterSoldItems();
        }

        private void cmbSearchModItems_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterSoldItems();
        }

        private void btnSearchReciept_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = invoice.findInvoiceByID(txtRecieptNo.Text.Trim());
        }

        private void txtReference_TextChanged(object sender, EventArgs e)
        {
            filterSale();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            viewSale();
            countOpenSale();
        }

        private void linkMessage_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = invoice.filterOpenSale();
            sumTotalOfSale();
        }

        private void lblProfit_Click(object sender, EventArgs e)
        {
            if (lblProfit.Text == "SHOW PROFIT")
            {
                chipSoldItemsProfit.Text = soldProfit;
                
                lblProfit.Text = "HIDE PROFIT";
            }
            else
            {
                chipSoldItemsProfit.Text = "0";
                lblProfit.Text = "SHOW PROFIT";
            }
        }

        private void chipSaleProfit_Click(object sender, EventArgs e)
        {
            if(is_sale_profit)
            {
                is_sale_profit = false;
                chipSaleProfit.Text = saleProfit;
            }
            else
            {
                is_sale_profit = true;
                chipSaleProfit.Text = "0";
            }
        }
    }
}
