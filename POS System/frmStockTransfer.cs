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
    public partial class frmStockTransfer : Form
    {
        public frmStockTransfer()
        {
            InitializeComponent();

            Validation.numbersOnly(txtQuantity);

            dtpExpiry.Value = DateTime.Now;

            Global.changeTabControlStyle(tabControl1);
        }

        StockTransfer stockTransfer = new StockTransfer();
        decimal availableQuantity;

        void calculateTotalonHand()
        {
            if(dgvStock.Rows.Count>0)
            {
                DataTable dtable = (DataTable)dgvStock.DataSource;
                chipQtyOnHand.Text = dtable.Compute("Sum(available)","True").ToString();
            }
            else
            {
                MessageBox.Show("No Item Found");
                chipQtyOnHand.Text = "0";
            }
        }

        void viewStockTransferHistory()
        {
            dgvStock.DataSource = stockTransfer.findStockForTransfer(txtBarcode.Text.Trim());

            dgvTransferHistory.DataSource = stockTransfer.viewTransferRecord(stockTransfer.itemID);
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                viewStockTransferHistory();
            }
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvStock.SelectedRows.Count!=0)
            {
                availableQuantity = decimal.Parse(dgvStock.SelectedRows[0].Cells["cellQuantity"].Value.ToString());

                txtFrom.Text = dgvStock.SelectedRows[0].Cells["cellLocation"].Value.ToString();
                txtFrom.Tag = dgvStock.SelectedRows[0].Cells["cellStorageID"].Value.ToString();
                txtQuantity.Text = availableQuantity.ToString();

                stockTransfer.itemID = int.Parse(dgvStock.SelectedRows[0].Cells["cellItemID"].Value.ToString());
                stockTransfer.batchNo = dgvStock.SelectedRows[0].Cells["cellItemID"].Value.ToString();
            }
            else
            {
                txtQuantity.Text = "0";
            }
        }

        private void dgvStock_DataSourceChanged(object sender, EventArgs e)
        {
            calculateTotalonHand();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockTransfer_Shown(object sender, EventArgs e)
        {
            cmbTo.DataSource = new StorageLocation().viewStorageLocation();
            cmbTo.DisplayMember = "name";
            cmbTo.ValueMember = "id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                if (txtQuantity.Text.Trim() == "") stockTransfer.quantity = 0;
                else stockTransfer.quantity = decimal.Parse(txtQuantity.Text);

                stockTransfer.transfer_from = int.Parse(txtFrom.Tag.ToString());
                stockTransfer.transfer_to = int.Parse(cmbTo.SelectedValue.ToString());
                stockTransfer.note = txtNote.Text.Trim();
                stockTransfer.tranfer_at = Validation.convertDate(dtpExpiry);

                stockTransfer.batchNo = dgvStock.SelectedRows[0].Cells["cellBatch"].Value.ToString();

                if (stockTransfer.transfer_to == stockTransfer.transfer_from)
                {
                    MessageBox.Show("Select different Location");
                }
                else if (stockTransfer.quantity > availableQuantity)
                {
                    MessageBox.Show("Cannot be exceeded the available Quantity");
                }
                else if (stockTransfer.quantity == 0)
                {
                    MessageBox.Show("Please Enter Quantity");
                    txtQuantity.Focus();
                    txtQuantity.SelectAll();
                }
                else if (stockTransfer.quantity<=0)
                {
                    MessageBox.Show("The Quantity Cannot Be Transfered");
                }
                else
                {

                    int stockID = int.Parse(dgvStock.SelectedRows[0].Cells["cellStockID"].Value.ToString());

                    DataRow[] result = ((DataTable)dgvStock.DataSource).Select($"storage_id={stockTransfer.transfer_to} AND item_id = {stockTransfer.itemID} AND batch_no='{stockTransfer.batchNo}'");

                    if (result.Length == 0)
                    {
                        if (stockTransfer.insertStockTransfer(true))
                        {
                            MessageBox.Show("Stock Transfered");
                            viewStockTransferHistory();
                        }
                    }
                    else
                    {
                        if (stockTransfer.insertStockTransfer(false))
                        {
                            MessageBox.Show("Stock Transfered");
                            viewStockTransferHistory();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Item to Continue this process");
            }
        }

        private void cmbMode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = cmbMode.SelectedIndex;
        }
    }
}
