using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class unit:Database
    {
        public int unit_id { get; set; }

        public string unit_type { get; set; }

        private string query = "";

        private string viewquery = "SELECT * FROM `tbl_unit` WHERE 1";

        public DataTable viewunit()
        {
            return GetData(viewquery);
        }

        public DataTable unit_details()
        {
            query = "SELECT * FROM `tbl_unit` WHERE unit_id" + unit_id;
            return GetData(query);
        }

        public bool insertUnit()
        {
            query = @"INSERT INTO `tbl_unit`(`unit_type`) VALUES ('" + unit_type + "')";
            return ExecuteData(query);
        }

        public bool deleteUnit(string uid)
        {
            query = @"DELETE FROM `tbl_unit` WHERE `unit_id`=" + uid;
            return ExecuteData(query);
        }


    }
}
