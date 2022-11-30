using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class RegisterTransaction:Database
    {
        public string description { get; set; }
        public decimal amount { get; set; }
        public int registerID { get; set; }

        public DataTable viewRegisterTransaction(int registerID, string startDate, string endDate)
        {
            return GetData($"SELECT `description`,`amount`,CONCAT(tbl_user.user_name,' @ ', tbl_register_transaction.created_at) as detail FROM tbl_register_transaction LEFT JOIN tbl_user ON tbl_user.user_id=tbl_register_transaction.created_by WHERE register_id={registerID} AND (tbl_register_transaction.created_at BETWEEN '{startDate}' AND '{endDate}')");
        }

        public bool insertTransaction()
        {
            new CashRegister().updateCashRegisterAmount(registerID,amount);

            return ExecuteData($"INSERT INTO `tbl_register_transaction`(`register_id`, `description`, `amount`, `created_by`) VALUES ({registerID},'{description}',{amount},{UserAuth.userid})");
        }
    }
}
