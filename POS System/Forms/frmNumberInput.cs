using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace POS_System
{
    public partial class frmNumberInput : Form
    {
        public decimal numberInput { get; set; }

        Validation validation = new Validation();
        public frmNumberInput(string defaultInput="1")
        {
            InitializeComponent();
            Validation.numbersOnly(txtNumber);
            txtNumber.Focus();
            txtNumber.Text = defaultInput;
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Control ctrlBtn =  sender as Control;

                if (ctrlBtn.Text == "0" || ctrlBtn.Text == "00")
                {
                decimal input = decimal.Parse(ctrlBtn.Text);
                decimal number = decimal.Parse(txtNumber.Text);

                    if (number + input == 0)
                    {
                        txtNumber.Text = "0";
                    }
                    else
                    {
                        txtNumber.Text += ctrlBtn.Text;
                    }
                }
                else
                {
                if (txtNumber.Text == "0" && ctrlBtn.Text != ".") txtNumber.Text = ctrlBtn.Text;
                else if (ctrlBtn.Text == "." && txtNumber.Text.Contains(".")) txtNumber.Text = txtNumber.Text;
                else txtNumber.Text += ctrlBtn.Text;
                }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            txtNumber.Text = "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text.Trim() == "") txtNumber.Text = "0";
            this.numberInput = decimal.Parse(txtNumber.Text);
            this.Close();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtNumber.Text.Trim() == "") txtNumber.Text = "0";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            txtNumber.Text = txtNumber.Text.Remove(txtNumber.Text.Length - 1);
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnEnter.PerformClick();
        }

        private void frmNumberInput_Load(object sender, EventArgs e)
        {
            txtNumber.SelectAll();
            txtNumber.Focus();
        }

        private void frmNumberInput_Shown(object sender, EventArgs e)
        {
            txtNumber.Focus();
            txtNumber.SelectAll();
        }
    }
}
