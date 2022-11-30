using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Setting:Database
    {
        public int setting_id { get; set; }
        public string store_name { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public byte[] image { get; set; }
        public string billNote { get; set; }

        private string query;

        public DataTable setting_details()
        {
            query = "select * from tbl_setting";
            return GetData(query);
        }

        public bool update_setting()
        {
            query = $"UPDATE `tbl_setting` SET `store_name`='{store_name}',`telephone`='{telephone}',`email`='{email}',`address`='{address}',bill_note='{billNote}', logo=@imageLink";
            return executeImageQuery(query,"imageLink",image);

        }

        public bool insertSetting()
        {
            return ExecuteData($"INSERT INTO `tbl_setting`(`store_name`, `telephone`, `email`, `address`) VALUES ('{store_name}','{telephone}','{email}','{address}')");
        }
    }
}
