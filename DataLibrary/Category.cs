using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace DataLibrary
{
    public class Category : Database
    {
        public int cat_id { get; set; }
        public string cat_code { get; set; }
        public string cat_name { get; set; }

        private string query="";
        private string viewQuery = "SELECT  `category_id`, `category_code`, `category_name` FROM `tbl_category` WHERE 1";

        public DataTable viewCategory()
        {
            return GetData(viewQuery);
        }

        public DataTable cetagory_details()
        {
            query = "SELECT * FROM tbl_category WHERE category_id=" + cat_id;
            return GetData(query);
        }

        public bool insert_Category()
        {
            query = @"INSERT INTO `tbl_category`(`category_code`, `category_name`) VALUES ('"+ cat_code + "','" + cat_name + "')";
            return ExecuteData(query);
        }

        //Update Category
        public bool update_Category()
        {
            query = @"UPDATE `tbl_category` SET `category_code`='" + cat_code + "',`category_name`='" + cat_name + "' WHERE category_id="+cat_id;
            return ExecuteData(query);
        }

        public DataTable fillCombo()
        {
            return GetData("SELECT *, concat(category_code, ' ', category_name) as category FROM `tbl_category` WHERE 1 ORDER BY category_id DESC");
        }

        public bool removeCategory(string catID)
        {
            return ExecuteData($"DELETE FROM tbl_category WHERE category_id={catID}");
        }
    }
}
