using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using DataLibrary;
using Guna.UI2.WinForms;

namespace POS_System
{
    public partial class frmApplication : Form
    {
        public frmApplication()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();

        ucDashboard dashboard = new ucDashboard();
        ucMenu menu = new ucMenu();

        void userControlAndMenu()
        {
            if (!Global.is_admin)
            {
                //Checking permission list one by one
                foreach (string permission in Global.permission)
                {
                    if(permission == "Sales Log")
                    {
                        btnTodaySales.Enabled = true;
                    }

                    //Loop through Controls in Menu Panel
                    foreach (var ctrl in pnlSideMenu.Controls)
                    {
                        var btnMenu = ctrl as Guna2Button;
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
                foreach (var ctrl in pnlSideMenu.Controls)
                {
                    var btnMenu = ctrl as Control;
                    btnMenu.Visible = true;
                }

                btnTodaySales.Enabled = true;
            }

            btnPurchaseOrder.Visible= false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {        
            Animation.menuTransition();
        }

        private void frmApplication_Load(object sender, EventArgs e)
        {
            userControlAndMenu();
            //MessageBox.Show(new LocalDatabase().getSingleValue("SELECT * FROM tbl_activation"));

            //new LocalDatabase().ExecuteData("INSERT INTO tbl_activation (expiry_date,activation_key) VALUES ('date','Activation KEy'); INSERT INTO tbl_local_printer (name) VALUES ('PDF Printer');");

            //Process.Start(@"c:\Windows\Sysnative\cmd.exe", "/c osk.exe");
            Animation.formTitle = formTitle;
            Animation.parentForm = this;
            Global.lblStockALert = lblAlert;
            Global.lblTodaySales = btnTodaySales;
            Global.btnCashRegister = btnCashRegister;

            //connection.checkConnection();

            pnlNotification.Visible = false;
            pnlMenu.BringToFront();

            menu.Dock = DockStyle.Fill;

            pnlContent.Width = pnlContainer.Width;
            pnlContent.Height = pnlContainer.Height;
            pnlMenu.Width = pnlContainer.Width;
            pnlMenu.Height = pnlContainer.Height;

            pnlMenu.Top = pnlContent.Height;
            pnlMenu.Left = 0;

            pnlContent.Top = 0;
            pnlContent.Left = 0;

            Animation.pnlContent = pnlContent;
            Animation.pnlMenu = pnlMenu;
            Animation.pnlContainer = pnlContainer;

            pnlMenu.Controls.Add(menu);

            Global.lblWelcome = lblWelcome;
            Global.welcomeMessage= lblWelcome.Text = ("Welcome to POS! " + Global.loggedUserName).ToUpper();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit the application?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if(result==DialogResult.Yes) Application.Exit();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Animation.showModal(new frmProfile());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void frmApplication_Shown(object sender, EventArgs e)
        {
            //Checking People table empty and add walkin client
            //Global.dTable=connection.GetData("select people_id from tbl_people LIMIT 1");
            //if (Global.dTable.Rows.Count <= 0)
            //{
            //    connection.ExecuteData("TRUNCATE TABLE tbl_people");
            //    connection.ExecuteData("INSERT INTO tbl_people(name,is_supplier,address,contact_no,balance,status) values('WALK IN CLIENT',false,null,'0',0,true)");
            //}

            Animation.formTitle.Text = "Dashboard";
            Animation.changeContentOnly(new ucDashboard());

            Global.stockAlertCount();
            Global.todaySalesCount();

            //Check Register ID Open Or Not and Set
            //Global.registerID = new CashRegister().checkRegisterOpen();

            timer1.Start();
        }

        //Stock ALert Button CLick
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Stock";
            Animation.changeContentOnly(new ucStock(true));
        }     

        private void frmApplication_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1: btnPOS.PerformClick(); break;
                //case Keys.F2: btnStock.PerformClick(); break;
                //case Keys.F3: btnReturn.PerformClick(); break;
                case Keys.F2: btnTodaySales.PerformClick(); break;
            }
        }

        private void formTitle_Click(object sender, EventArgs e)
        {
            //var cancelToken = new CancellationTokenSource();
            //Task.Factory.StartNew(async () =>
            //{
            //    await Task.Delay(3000);
            //    MessageBox.Show("Task Completed");
            //    // call web API
            //}, cancelToken.Token);
        }

        #region Menu Click
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Dashboard";
            Animation.changeContentOnly(new ucDashboard());
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Point of Sale";
            Animation.changeContentOnly(new ucPOS());
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Return";
            Animation.changeContentOnly(new ucReturn());
        }

        private void btnTodaySales_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Sales Log";
            Animation.changeContentOnly(new ucSale());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Stock";
            Animation.changeContentOnly(new ucStock());
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Dashboard";
            Animation.changeContentOnly(new ucDashboard());
        }

        private void btnPOSmenu_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Point of Sale";
            Animation.changeContentOnly(new ucPOS());
        }

        private void btnStockmenu_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Stock Details";
            Animation.changeContentOnly(new ucStock());
        }

        private void btnPaymentLog_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Payment Log";
            Animation.changeContentOnly(new ucPaymentLog());
        }

        private void btnDataMaster_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Data Master";
            Animation.changeContentOnly(new ucEtc());
        }

        private void btnSettingmenu_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Setting";
            Animation.changeContentOnly(new ucSetting());
        }

        private void btnSalesLog_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Sales Log";
            Animation.changeContentOnly(new ucSale());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Contact";
            Animation.changeContentOnly(new ucPeople());
        }

        private void btnCheque_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Cheque Details";
            Animation.changeContentOnly(new ucCheque());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Purchasing";
            Animation.changeContentOnly(new ucNewPurchaseForm());
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Users";
            Animation.changeContentOnly(new ucUser());
        }

        private void btnShowHideMenu_Click(object sender, EventArgs e)
        {
            if (btnShowHideMenu.Checked) pnlSideMenu.Width = 211;
            else pnlSideMenu.Width = 0;

            pnlContent.Width = pnlContainer.Width;
            pnlContent.Height = pnlContainer.Height;
        }

        private void btnPurchaseLog_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Purchase Log";
            Animation.changeContentOnly(new ucPurchase());
        }

        private void btnStockTransfer_Click(object sender, EventArgs e)
        {
            new frmStockTransfer().ShowDialog();
        }

        private void btnCashRegister_Click(object sender, EventArgs e)
        {
            if (Global.registerID == 0) Animation.showModal(new frmOpenRegister());
            else Animation.showModal(new frmCashRegisterDetails());
        }

        #endregion Menu Click
        private void btnExpense_Click(object sender, EventArgs e)
        {
            Animation.changeContentOnly(new ucExpences());
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBank_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Bank Account";
            Animation.changeContentOnly(new ucBank());
        }

        private void btnPurchaseOrder_Click(object sender, EventArgs e)
        {
            Animation.formTitle.Text = "Purchase Order";
            Animation.changeContentOnly(new ucPurchaseOrder());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmLogin().Show();
            timer1.Stop();
        }

        bool flag = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag == true) flag = false;
            else flag = true;
            Animation.animateBottomText(flag);
        }
    }
}
