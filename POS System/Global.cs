using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using DataLibrary;
using Guna.UI2.WinForms;

namespace POS_System
{
    class Global
    {
        public static DataGridView dataGrid;
        public static DataTable dTable, dTableStockAlert;
        public static int userid=1, registerID = 0;
        public static string[] permission;
        public static bool is_admin=true,is_success=false;
        public static Control lblStockALert, lblTodaySales;
        public static string customerID = "CUS/", supplierID = "SUP/", purchaseRefrence = "0", supplierTag = "0", supplierName = "Select your Supplier";
        public static Guna2Button btnCashRegister;
        public static Form frmViewModal;
        public static Label lblWelcome;
        //public static Guna2Button btnEditSale;

        public static string database,user,port,password,server, loggedUserName,welcomeMessage;
      

        public static decimal numberInput(string defaultinput="1")
        {
            using (frmNumberInput frmNumber = new frmNumberInput(defaultinput))
            {
                Animation.showModal(frmNumber);
                return frmNumber.numberInput;
            }
        }

        public static void changeTabControlStyle(TabControl tabControl)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        public static void stockAlertCount()
        {
            dTableStockAlert = new Item().alertQuantity();
            lblStockALert.Text = dTableStockAlert.Rows.Count.ToString();
        }

        public static void todaySalesCount()
        {
            lblTodaySales.Text = $"[F2] Today Sales ( {new Invoice().countTodaySales()} )";
        }

        public static void showSuggestion(DataTable dtRecord, Guna2TextBox txtBox)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            foreach (DataRow row in dtRecord.Rows)
            {
                collection.Add(row[0].ToString());
            }

            txtBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtBox.AutoCompleteCustomSource = collection;
        }
    }
}
