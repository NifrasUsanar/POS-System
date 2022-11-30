using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class BankAccount:Database
    {
        public int bank_id { get; set; }
        public string account_no { get; set; }
        public string acc_name { get; set; }
        public string bank_name { get; set; }
        public double balance { get; set; }

        private string query = "";
        private string viewquery = $"SELECT `id`, `account_no`, `account_name`, `bank_name`, `balance` FROM `tbl_bank_account` WHERE 1";

        public DataTable showBankAccount()
        {
            return GetData("SELECT CONCAT(`bank_name`,' - ',`account_name`) AS account, balance,id, bank_name FROM `tbl_bank_account` WHERE 1");
        }

        public bool updateBankBalanceOnVendorCheque(int accountID, decimal amount, string paymentID,string date)
        {
            if (amount < 0)
            {
                ExecuteData($"INSERT INTO `tbl_bank_transaction`(`bank_account_id`, `amount`, `transaction_type`, `description`, `date`, `refrence_id`, `created_by`) VALUES ({accountID},{amount},'Withdrawal','Cheque Payment','{date}',{paymentID},{UserAuth.userid})");
            }
            else
            {
                ExecuteData($"DELETE FROM `tbl_bank_transaction` WHERE refrence_id={paymentID} AND bank_account_id={accountID} AND amount<0");
            }

            return ExecuteData($"UPDATE tbl_bank_account SET balance=balance+{amount} WHERE id={accountID}");
        }

        public DataTable viewbank()
        {
            return GetData(viewquery);
        }

        public DataTable bank_details()
        {
            query = @"SELECT `account_no`, `account_name`, `bank_name`, `balance` FROM `tbl_bank_account` WHERE id=" + bank_id;
            return GetData(query);
        }

        public bool inser_query()
        {
            query = $"INSERT INTO `tbl_bank_account`(`account_no`, `account_name`, `bank_name`, `balance`, `created_by`) VALUES ({account_no},'{acc_name}','{bank_name}',{balance},{UserAuth.userid})";
            return ExecuteData(query);
        }

        public bool update_query()
        {
            query = $"UPDATE `tbl_bank_account` SET `account_no`={account_no},`account_name`='{acc_name}',`bank_name`='{bank_name}' WHERE id={bank_id}";
            return ExecuteData(query);
        }
    }
}
