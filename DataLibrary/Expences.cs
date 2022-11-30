using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Expences:Database
    {
        public int expences_id { get; set; }

        public decimal amont { get; set; }

        public string discription { get; set; }
        public string date { get; set; }

        public string query = "";

        private string viewquery = "SELECT expences_id,discription,amount,Date FROM `tbl_expences` WHERE 1";

        public DataTable viewexpences(string startDate, string endDate)
        {
            query = viewquery+ $" AND (CONVERT(tbl_expences.Date,DATE) BETWEEN '{startDate}' AND '{endDate}')";
            return GetData(query + " ORDER BY expences_id DESC");
        }

        public DataTable expences_details()
        {
            query = "SELECT * FROM `tbl_expences` WHERE expences_id=" + expences_id;
            return GetData(query);
        }

        public bool inserExpences()
        {
            query = $@"INSERT INTO `tbl_expences`(`amount`, `discription`,Date) VALUES ({amont}, '{discription}','{date}')";
            return ExecuteData(query);
        }

        public bool updateExpences()
        {
            query = $@"UPDATE `tbl_expences` SET `amount`={amont},`discription`='{discription}', Date='{date}' WHERE `expences_id`="+expences_id;
            return ExecuteData(query);
        }

        public bool deleteExpences(int expenID)
        {
            query = @"DELETE FROM `tbl_expences` WHERE `expences_id`=" + expenID;
            return ExecuteData(query);
        }
    }
}
