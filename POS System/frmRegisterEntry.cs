using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class frmRegisterEntry : Form
    {
        public frmRegisterEntry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button btnSender = (Button)sender;
            ////Point ptLowerLeft = new Point(0, btnSender.Height);
            //Point ptLowerLeft = new Point(0, 0);
            //ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            //contextMenuStrip1.Show(ptLowerLeft);
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtDescription.Text.Trim()=="")
            {
                MessageBox.Show("Description Required");
            }
        }
    }
}
