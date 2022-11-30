using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Text.RegularExpressions;

namespace POS_System
{
    class Validation
    {
        //---------------- Text Box Empty Validation ------------------
        public bool textBoxEmpty(Control control)
        {
            foreach (var ctrl in control.Controls)
            {
                var txtBox = ctrl as Guna2TextBox;
                if (txtBox != null)
                {
                    if (txtBox.Text.Trim() == "" && (txtBox.Tag!=null || txtBox.Tag.ToString().Trim().Length!=0))
                    {
                        Animation.showMessage(txtBox.Tag.ToString(),"error");
                        txtBox.Focus();
                        return false;
                    }
                }
            }
            return true;
        }

        //---------------- Text Box that accept only Numbers validation ------------------
        static Regex reg = new Regex(@"^-?\d+[.]?\d*$");
        public static void numbersOnly(Control txtBox)
        {
            var txtKeyPress = new KeyPressEventHandler(textKeyPress);
            txtBox.KeyPress += textKeyPress;
        }

        static void textChanged(Object sender, EventHandler e)
        {
            //if (!reg.IsMatch((sender as Guna2TextBox).Text.Insert((sender as Guna2TextBox).SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;
        }
           
        static void textKeyPress(Object sender, KeyPressEventArgs e)
        {
            //Char chr = e.KeyChar;
            //if (!Char.IsDigit(chr) && chr != 8 && chr != '.') e.Handled = true;
            //    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            //(e.KeyChar != '.'))
            //    {
            //        e.Handled = true;
            //    }

            //    // only allow one decimal point
            //    if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            //    {
            //        e.Handled = true;
            //    }

            if (char.IsControl(e.KeyChar)) return;
            if (!reg.IsMatch((sender as Guna2TextBox).Text.Insert((sender as Guna2TextBox).SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;
        }

        //Reset controls in a from
        public void resetControls(Control control)
        {
            foreach (var ctrl in control.Controls)
            {
                var txtBox = ctrl as TextBox;
                var combo = ctrl as ComboBox;
                var dattime = ctrl as DateTimePicker;

                if (txtBox != null)
                {
                    if (txtBox.Text.Trim() != "")
                    {
                        txtBox.Text = "";
                    }
                }
                else if (combo != null) combo.SelectedIndex = 0;
                else if (dattime != null) dattime.ResetText();
            }
        }

        public void showErrorLabel(TextBox textBox, string message)
        {
            Label labelError = new Label();
            labelError.AutoSize = true;
            labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelError.ForeColor = System.Drawing.Color.Crimson;
            labelError.Location = new System.Drawing.Point(textBox.Left, textBox.Top + textBox.Height + 2);
            labelError.TabIndex = 11;
            labelError.Text = message;

            textBox.Parent.Controls.Add(labelError);
        }

        public static string convertDate(Guna2DateTimePicker dateTimePicker)
        {
            return dateTimePicker.Value.ToString("yyyy-MM-dd");
        }
    }
}
