using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using DataLibrary;

namespace POS_System
{
    public partial class frmStore : Form
    {
        StorageLocation store = new StorageLocation();
        DataGridView dgv_item_storage;
        Validation validation = new Validation();
        bool is_new_store;

        public frmStore(DataGridView dgv_item_storage, bool is_new_store = true)
        {
            InitializeComponent();
            this.dgv_item_storage = dgv_item_storage;
            this.is_new_store = is_new_store;
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            store.store_name = store_name.Text;
            store.store_location = store_location.Text;

            if (is_new_store)
            {
                store.insert_store();
            }
            else
            {
                store.update_store();
            }

            Animation.showMessage("Successfully Saved", "success");
            this.Close();
        }

        private void frm_addStore_Shown(object sender, EventArgs e)
        {
            if (!is_new_store)
            {
                store.id = int.Parse(dgv_item_storage.SelectedRows[0].Cells[0].Value.ToString());

                DataTable dTable = store.findStorage();

                store_name.Text = dTable.Rows[0]["name"].ToString();
                store_location.Text = dTable.Rows[0]["location"].ToString();
            }
        }
    }
}
