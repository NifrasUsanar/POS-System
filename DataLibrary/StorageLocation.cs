using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
   public class StorageLocation:Database
    {
        public string store_name { get; set; }
        public int id { get; set; }
        public string store_location { get; set; }

        private string query = "";

        public DataTable viewStorageLocation()
        {
            return GetData("SELECT * FROM `tbl_item_location`");
        }

        public DataTable findStorage()
        {
            query = "SELECT * FROM tbl_item_location WHERE id=" + id;
            return GetData(query);
        }

        public bool insert_store()
        {
            query = @"INSERT INTO `tbl_item_location`(`name`, `location`) VALUES ('" + store_name + "','" + store_location + "')";
            return ExecuteData(query);
        }

        public bool update_store()
        {
            query = @"UPDATE `tbl_item_location` SET `name`='" + store_name + "',`location`='" + store_location + "' WHERE id=" + id;
            return ExecuteData(query);
        }
    }
}
