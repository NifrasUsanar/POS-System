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
    public partial class frmPeopleDetail : Form
    {
        People people = new People();
        public frmPeopleDetail(string peopleID, string peopleName, bool is_supplier)
        {
            InitializeComponent();

            lblPeopleName.Text = peopleName;
            people.id = peopleID;
            people.is_supplier = is_supplier;

            if(!is_supplier)
            {
                grpPurchase.Visible = false;
                btnBills.Text = "VIEW INVOICE";
                btnItems.Text = "SOLD ITEMS";
            }
        }

        void findPeople()
        {
            DataTable dTable = people.findPeople(people.id);

            if (dTable.Rows.Count > 0)
            {
                chipBalance.Text = "Rs. " + (decimal.Parse(dTable.Rows[0]["balance"].ToString()) + -1 * decimal.Parse(dTable.Rows[0]["opening_balance"].ToString())).ToString("N2");
                lblPeopleName.Text = dTable.Rows[0]["name"].ToString();
            }
            else
            {
                MessageBox.Show("The People ID is Incorrect");
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnClose.PerformClick();
        }

        private void frmPeopleDetail_Shown(object sender, EventArgs e)
        {
            findPeople();

           if (people.is_supplier)
            {
                DataTable dtPurchase = new Purchase().findPurchaseRefrenceBySupplier(int.Parse(Global.supplierTag));

                Global.showSuggestion(dtPurchase, txtRefrenceNo);
            }
        }

        private void btnEditpeople_Click(object sender, EventArgs e)
        {
            new frmPeople(people.id,true).ShowDialog();
        }

        private void btnViewPurchase_Click(object sender, EventArgs e)
        {

        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            findPeople();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            var result = Animation.resultModal(new frmPayment(0, 0, Convert.ToInt32(people.id), 0, people.is_supplier, true));

            if (result != DialogResult.Cancel)
            {
                //dgvPeople.DataSource = new Purchase().viewPurchaseHistory();
            }
        }

        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            ucPaymentLog paymentLog = new ucPaymentLog(Convert.ToInt32(people.id),people.is_supplier,lblPeopleName.Text);
            frmViewModal paymentForm = new frmViewModal("Payment History");
            paymentForm.Tag = paymentLog;
            Animation.resultModal(paymentForm);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            if(people.is_supplier)
            {
                ucPurchase purchase = new ucPurchase(people.id, lblPeopleName.Text, true);
                frmViewModal purchaseForm = new frmViewModal("Purchase History");
                purchaseForm.Tag = purchase;
                Animation.showModal(purchaseForm);
            }
            else
            {
                ucSale sale = new ucSale(lblPeopleName.Text, people.id, true);
                frmViewModal salesForm = new frmViewModal("Sales History");
                salesForm.Tag = sale;
                Animation.showModal(salesForm);
            }
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            if (people.is_supplier)
            {
                ucPurchase purchase = new ucPurchase(people.id, lblPeopleName.Text, false);
                frmViewModal purchaseForm = new frmViewModal("Purchase History");
                purchaseForm.Tag = purchase;
                Animation.showModal(purchaseForm);
            }
            else
            {
                ucSale sale = new ucSale(lblPeopleName.Text, people.id, false);
                frmViewModal salesForm = new frmViewModal("Sales History");
                salesForm.Tag = sale;
                Animation.showModal(salesForm);
            }
        }

        private void btnViewCheque_Click(object sender, EventArgs e)
        {
            frmViewCheque viewCheque = new frmViewCheque(Convert.ToInt32(people.id), people.is_supplier);
            //viewCheque.Tag = new Payment(true);
            Animation.showModal(viewCheque);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
           new frmPeopleSummary() { peopleID = people.id, StartPosition = FormStartPosition.CenterScreen, TopMost = true, is_supplier=people.is_supplier }.ShowDialog();
        }
    }
}
