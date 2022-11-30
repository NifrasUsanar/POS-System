using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
   public class Banktransfer : Database
    {
        public int bank_id { get; set; }
        public decimal amount { get; set; }
        public string transactionDate{ get;set;}
        public string description { get; set; }
        public string transactionType { get; set; }
        public string refrenceID { get; set; }

        private string query = "";

        public DataTable viewBanktransfer()
        {
            query = @"SELECT refrence_id,tbl_bank_transaction.id,date,description,amount,transaction_type,tbl_user.user_name FROM `tbl_bank_transaction`INNER JOIN tbl_user ON tbl_user.user_id = tbl_bank_transaction.created_by WHERE bank_account_id=" + bank_id;
            return GetData(query);
        }

        public DataTable Banktransfer_details()
        {
            query = @"SELECT bank_name,account_no FROM `tbl_bank_account` WHERE id=" + bank_id;
            return GetData(query);
        }

        public bool insertBankTransaction()
        {
            query = $"INSERT INTO `tbl_bank_transaction`(`bank_account_id`, `amount`,`description`, `transaction_type`, `date`, `created_by`, refrence_id) VALUES ({bank_id}, {amount},'{description}','{transactionType}','{transactionDate}',{UserAuth.userid},{refrenceID})";

            if (refrenceID != "0") ExecuteData($"UPDATE tbl_sales_payment SET cheque_status='Deposited' WHERE payment_id={refrenceID}");

            return ExecuteData(query+ $"; UPDATE `tbl_bank_account` SET `balance`=`balance`+{amount} WHERE id={bank_id}");

            //return updatebankBalance(bank_id, amount);          
        }

        public bool updatebankBalance(int bankID, decimal amount)
        {
            return ExecuteData($"UPDATE `tbl_bank_account` SET `balance`=`balance`+{amount} WHERE id={bank_id}");
        }

        public bool deleteTransaction(int bankID, decimal amount, int transactionID, string referenceID)
        {
            query = $"DELETE FROM tbl_bank_transaction WHERE id={transactionID}";
            ExecuteData(query);

            if (referenceID != "0") ExecuteData($"UPDATE tbl_sales_payment SET cheque_status='Pending' WHERE payment_id={referenceID}");

            return updatebankBalance(bankID,-1*amount);
        }
    }
}
