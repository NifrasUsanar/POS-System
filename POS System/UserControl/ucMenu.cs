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

namespace POS_System
{
    public partial class ucMenu : UserControl
    {
        public ucMenu()
        {
            InitializeComponent();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Point of Sale";
            Animation.changeContent(new ucPOS());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Sales Log";
            Animation.changeContent(new ucSale());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Stock Details";
            Animation.changeContent(new ucStock());
        }

        private void Cheque_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Cheque Details";
            Animation.changeContent(new ucCheque());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Setting";
            Animation.changeContent(new ucSetting());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Purchasing";
            Animation.changeContent(new ucNewPurchaseForm());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //Animation.formTitle.Text = "Customer";
            //Animation.changeContent(new ucPeople(false));
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            //Animation.formTitle.Text = "Supplier";
            //Animation.changeContent(new ucPeople(true));
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Users";
            Animation.changeContent(new ucUser());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Etc.";
            Animation.changeContent(new ucEtc());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Return";
            Animation.changeContent(new ucReturn());
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Payment Log";
            Animation.changeContent(new ucPaymentLog());
        }

        private void btnPurchaseBill_Click_1(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Purchase Log";
            Animation.changeContent(new ucPurchase());
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Expenses";
            Animation.changeContent(new ucExpences());
        }

        private void ucMenu_Load(object sender, EventArgs e)
        {
            if (!Global.is_admin)
            {
                //Checking permission list one by one
                foreach(string permission in Global.permission)
                {
                    //Loop through Controls in Menu Panel
                    foreach(var ctrl in pnlMenu.Controls)
                    {
                        var btnMenu = ctrl as Guna2TileButton;
                        if (btnMenu != null)
                        {
                            //Check Permission Match with tag and Turn on Visible in Menu
                            if (btnMenu.Tag.ToString() == permission)
                            {
                                btnMenu.Visible = true;
                            }
                        }
                    }
                }
            }
            else
            {
                //If admin login in then every menu item should be visible
                foreach(var ctrl in pnlMenu.Controls)
                {
                    var btnMenu=ctrl as Control;
                    btnMenu.Visible = true;
                }
            }
        }

        private void btnQuotation_Click(object sender, EventArgs e)
        {
            Animation.showMessage("This feature will be added in near future...","info");
        }
    }
}
