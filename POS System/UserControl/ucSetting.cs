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
using System.IO;

namespace POS_System
{
    public partial class ucSetting : UserControl
    {
        Setting setting = new Setting();
        Validation validation = new Validation();
        public ucSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                setting.store_name = company_name.Text;
                setting.telephone = compant_number.Text;
                setting.email = company_email.Text;
                setting.address = company_address.Text;
                setting.billNote = txtBillNote.Text.Trim();


                //Image codeImage = writer.Write(barcode); // Convert barcode to image

                //MemoryStream ms = new MemoryStream();
                //codeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                //byte[] image = ms.ToArray();

                Image logo = picLogo.Image;
                MemoryStream ms = new MemoryStream();
                logo.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                setting.image = ms.ToArray();

                if (setting.update_setting())
                {
                    MessageBox.Show("Successfully Saved");
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
                        
        }

        private void ucSetting_Load(object sender, EventArgs e)
        {
            lblBilFormat.Text = txtFormat.Text + txtDigits.Value.ToString().PadLeft(int.Parse(txtDigits.Value.ToString()),'0');

            Global.dTable = setting.setting_details();

            //If Setting Data not available
            if(Global.dTable.Rows.Count<=0)
            {
                setting.store_name = "Store";
                setting.telephone = "0651234567";
                setting.email = "store@email.com";
                setting.address = "store address";

                setting.insertSetting();
            }

            DataTable dTable = setting.setting_details();

            company_name.Text = dTable.Rows[0]["store_name"].ToString();
            compant_number.Text = dTable.Rows[0]["telephone"].ToString();
            company_email.Text = dTable.Rows[0]["email"].ToString();
            company_address.Text = dTable.Rows[0]["address"].ToString();
            byte[] img = (byte[])dTable.Rows[0]["logo"];
            txtBillNote.Text = dTable.Rows[0]["bill_note"].ToString();

            MemoryStream ms = new MemoryStream(img);
            picLogo.Image = Image.FromStream(ms);
        }

        private void txtFormat_TextChanged(object sender, EventArgs e)
        {
            lblBilFormat.Text = txtFormat.Text + txtDigits.Value.ToString().PadLeft(int.Parse(txtDigits.Value.ToString()), '0');
        }

        private void txtDigits_ValueChanged(object sender, EventArgs e)
        {
            lblBilFormat.Text = txtFormat.Text + txtDigits.Value.ToString().PadLeft(int.Parse(txtDigits.Value.ToString()), '0');
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.png) | *.jpg; *.jpeg; *.jpe; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileInfo info = new FileInfo(openFileDialog1.FileName);
                if (info.Length > 350000)
                {
                    MessageBox.Show("File is too large");
                }
                else
                {
                    picLogo.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
