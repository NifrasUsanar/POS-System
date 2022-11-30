using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class DataMaster:Database
    {
        public string type { get; set; }
        public string value { get; set; }

        public bool insertData()
        {
            return ExecuteData($"INSERT INTO `tbl_master_data`(`value`, `type`) VALUES ('{value}','{type}')");
        }

        public DataTable viewMaster(string type)
        {
            return GetData($"SELECT `id`, `value`, `type` FROM `tbl_master_data` WHERE type LIKE '{type}'");
        }

        public bool removeMasterData(int id)
        {
            return ExecuteData("DELETE FROM `tbl_master_data` WHERE id="+id);
        }
    }
}
