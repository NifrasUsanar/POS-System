using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Brand:Database
    {
        public int brand_id { get; set; }
        public string brand_code { get; set; }
        public string brand_name { get; set; }

        private string query="";
        private string viewQuery = "SELECT `brand_id`, `brand_code`, `brand_name` FROM `tbl_brand` WHERE 1";

        public DataTable viewBrand()
        {
            return GetData(viewQuery);
        }

        public bool removeBrand(string brandID)
        {
            return ExecuteData($"DELETE FROM tbl_brand WHERE brand_id={brandID}");
        }

        public DataTable brand_details()
        {
            query = "SELECT * FROM tbl_brand WHERE brand_id=" + brand_id;
            return GetData(query);
        }

        public bool insertBrand()
        {
            query = @"INSERT INTO `tbl_brand`( `brand_code`, `brand_name`) VALUES ('"+brand_code+ "','" + brand_name + "')";
            return ExecuteData(query);
        }

        public bool updateBrand()
        {
            query = @"UPDATE `tbl_brand` SET `brand_code`='" + brand_code + "',`brand_name`='" + brand_name + "' WHERE brand_id="+brand_id;
            return ExecuteData(query);
        }

        public DataTable fillCombo()
        {
            return GetData("SELECT *, concat(brand_code, ' ', brand_name) as brand FROM `tbl_brand` WHERE 1 ORDER BY brand_id DESC");
        }
    }
}
