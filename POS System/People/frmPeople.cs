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
    public partial class frmPeople : Form
    {

        People people = new People();
        Validation validation = new Validation();

        public frmPeople(string peopleID="0", bool is_supplier=false)
        {
            InitializeComponent();

            people.is_supplier = is_supplier;
            people.id = peopleID;

            Validation.numbersOnly(txtContactNo);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtDescription.Text.Trim() == "") txtDescription.Text = "...";
            if (validation.textBoxEmpty(grpForm))
            {
                people.name = txtCustomer.Text.Replace("'", "''").Trim();
                people.address = txtAddress.Text.Replace("'", "''").Trim();
                people.contact = txtContactNo.Text;
                people.isActive = btnIsActive.Checked;
                people.opening_balance = 0;
                people.city = txtCity.Text.Trim();
                people.customID = txtCustomID.Text;
                people.description = txtDescription.Text.Trim().Replace("'", "''").Trim();

                //New PeopleAccount
                if (people.id=="0")
                {
                    //Show Error Message if insert operation failed
                    if (!people.insert_people()) Animation.showMessage("Failed to Create", "error");
                    else
                    {
                        //Animation.showMessage("Account Created", "success");
                        MessageBox.Show("Account Created");
                        this.Close();
                    }
                }
                else if (people.update_people())
                {
                    //Animation.showMessage("Account Updated", "success");
                    MessageBox.Show("Account Updated");
                    this.Close();
                }
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPeople_Shown(object sender, EventArgs e)
        {
            if (people.is_supplier)
            {
                lblTitle.Text = "Supplier / Vendor";
                lblName.Text = "Supplier Name";
                txtCustomer.PlaceholderText = "Supplier / Vendor / Company";
            }
            else
            {
                lblTitle.Text = "Customer";
                lblName.Text = "Customer Name";
            }

            if (people.id != "0")
            {
                Global.dTable = people.findPeople(people.id);

                txtCustomer.Text = Global.dTable.Rows[0]["name"].ToString();
                txtAddress.Text = Global.dTable.Rows[0]["address"].ToString();
                txtContactNo.Text = Global.dTable.Rows[0]["contact_no"].ToString();
                txtCustomID.Text = Global.dTable.Rows[0]["custom_id"].ToString();
                btnIsActive.Checked = bool.Parse(Global.dTable.Rows[0]["status"].ToString());
                txtDescription.Text = Global.dTable.Rows[0]["description"].ToString();
                txtCity.Text = Global.dTable.Rows[0]["city"].ToString();
            }
            else
            {
                string customID = people.getCustomID(people.is_supplier);

                if (people.is_supplier) txtCustomID.Text = Global.supplierID + customID.PadLeft(4, '0');
                else txtCustomID.Text = Global.customerID + customID.PadLeft(4, '0');
            }
        }
    }
}
