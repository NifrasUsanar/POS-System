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
    public partial class frmReturn : Form
    {
        public DataGridView dgvGrid { get; set; }
        Return returnItem = new Return();

        decimal quantity;

        public string invoiceno { get; set; }
        public frmReturn()
        {
            InitializeComponent();
        }

        private void frmReturn_Shown(object sender, EventArgs e)
        {
            txtName.Text = dgvGrid.SelectedRows[0].Cells["cellItemName"].Value.ToString();
            txtPrice.Text = dgvGrid.SelectedRows[0].Cells["cellPrice"].Value.ToString();
            txtDiscount.Text= dgvGrid.SelectedRows[0].Cells["cellDiscount"].Value.ToString();
            txtQuantity.Text= dgvGrid.SelectedRows[0].Cells["cellQuantity"].Value.ToString();


            quantity = decimal.Parse(dgvGrid.SelectedRows[0].Cells["cellQuantity"].Value.ToString());

            txtQuantity.Maximum = decimal.Parse(dgvGrid.SelectedRows[0].Cells["cellQuantity"].Value.ToString());

            cmbStatus.SelectedIndex = 0;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                returnItem.invoiceid = invoiceno;
                returnItem.itemid = dgvGrid.SelectedRows[0].Cells["cellItemID"].Value.ToString();
                returnItem.reason = txtReaason.Text;
                returnItem.price = decimal.Parse(txtPrice.Text);
                returnItem.quantity = decimal.Parse(txtQuantity.Text);
                returnItem.discount = decimal.Parse(txtDiscount.Text);
                returnItem.batch = dgvGrid.SelectedRows[0].Cells["cellBatchNo"].Value.ToString();
                returnItem.cost = decimal.Parse(dgvGrid.SelectedRows[0].Cells["cellCost"].Value.ToString());
                returnItem.indirect_cost = decimal.Parse(dgvGrid.SelectedRows[0].Cells["cellIndirectCost"].Value.ToString());

                if (cmbStatus.SelectedIndex == 0) returnItem.isStock = true;
                else returnItem.isStock = false;

                if (txtReaason.Text.Trim() != "")
                {
                    if (returnItem.insertReturn())
                    {
                        //Delete the sold item from transaction if the return quantity is equal to sold item quantity

                        returnItem.id = dgvGrid.SelectedRows[0].Cells[0].Value.ToString();
                        returnItem.updateSoldItems();
                        returnItem.updateInvoice();
                        Animation.showMessage("Process Successfully Completed","success");
                        this.Close();
                    }
                }
                else
                {
                    txtReaason.Focus();
                    Animation.showMessage("Please Enter Reason", "error");
                }
            }
            catch (Exception exc)
            {
                Animation.showMessage(exc.Message, "error");
            }
        }
    }
}
