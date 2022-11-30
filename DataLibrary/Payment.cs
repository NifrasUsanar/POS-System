using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Payment:Database
    {
        public string paymentID { get; set; }
        public int refrence_ID { get; set; }
        public string paymentType { get; set; }
        public string chequeNo { get; set; }
        public string bankName { get; set; }
        public string chequeStatus { get; set; }
        public string chequeType { get; set; }
        public string chequeDate { get; set; }
        public string amount { get; set; }
        public int peopleID { get; set; }
        public string note { get; set; }
        public bool is_supplier { get; set; }
        public bool is_deposit { get; set; }
        public int account_id { get; set; } = 0;
        public bool is_party { get; set; } = false;
        public string cheque_reference { get; set; } = "0";
        public string cheque_from { get; set; } = "0";
        public int cheque_to { get; set; } = 0;

        string query,table_name,chequeQuery;

        public Payment(bool is_supplier)
        {
            this.is_supplier = is_supplier;

            if (is_supplier) table_name = "tbl_purchase_payment";
            else table_name = "tbl_sales_payment";

            chequeQuery = $"SELECT payment_id, {table_name}.people_id,is_party,CONCAT(tbl_people.name,if(is_party,' (Party Cheque)','')) AS name, `cheque_no`,`bankname`,`amount`,`cheque_type`,`cheque_date`,`cheque_status` FROM {table_name} INNER JOIN tbl_people on tbl_people.people_id = {table_name}.people_id WHERE payment_type = 'Cheque'";
        }

        public bool insertPayment()
        {
            if (paymentType != "Account") // Dont need to Insert Account Payment
            {
                if (note.Trim() == "" || note == null) note = "";

                query = $@"INSERT INTO {table_name}(`refrence_id`, `payment_type`, `cheque_no`, `bankname`, `cheque_status`, `cheque_type`, `cheque_date`, `amount`, people_id,note, created_by,account_id,is_party,cheque_reference,cheque_people) 
            VALUES (" + refrence_ID + ",'" + paymentType + "',NULLIF('" + chequeNo + "',''),NULLIF('" + bankName + "',''),NULLIF('" + chequeStatus + "',''),NULLIF('" + chequeType + "',''),NULLIF('" + chequeDate + "','')," + amount + "," + peopleID + ",'" + note + "'," + UserAuth.userid + "," + account_id + "," + is_party + "," + cheque_reference + "," + cheque_from + ")";

                //Cheque Reference is ID of Sales Payment Table
                if (is_party) updateToPartyCheque(cheque_reference);

                return ExecuteData(query);
            }
            else
            {
                return true;
            }
        }

        //The Payment ID is Cheque Reference of tbl_purchase_payment table
        //Update Customer Cheque Payment as Party Cheque
        public bool updateToPartyCheque(string paymentID)
        {
            return ExecuteData($"UPDATE tbl_sales_payment SET is_party={is_party}, cheque_people={cheque_to} WHERE payment_id={paymentID}");
        }

        //If it is supplier then update sales payment Table If not then update purchase payment table
        public bool updatePartyCheque(bool is_supplier, string paymentID)
        {
            string updateTable = "";

            if (is_supplier) updateTable = "tbl_sales_payment";
            else updateTable = "tbl_purchase_payment";

            query = $"UPDATE {updateTable} SET `cheque_no`='{chequeNo}',`bankname`='{bankName}',`cheque_status`='{chequeStatus}',`cheque_type`='{chequeType}',`cheque_date`='{chequeDate}' WHERE";

            if (is_supplier) query += $"`{updateTable}`.`payment_id` = " + paymentID;
            else query += $"`{updateTable}`.`cheque_reference` = " + paymentID;

            return ExecuteData(query);
        }

        //RemoveParty Cheque and Update Sales Payment Cheque
        public bool removePartyCheque(string paymentID)
        {
            ExecuteData($"DELETE FROM tbl_purchase_payment WHERE cheque_reference={paymentID}");
            return ExecuteData("UPDATE tbl_sales_payment SET is_party=0, cheque_reference=0, cheque_people=0 WHERE payment_id="+paymentID);
        }

        //Load Cheque Details
        public DataTable viewCheque(string startDate, string endDate, int peopleID=0)
        {
            if (peopleID != 0) chequeQuery += $" AND {table_name}.people_id={peopleID}";

            if(startDate=="") return GetData(chequeQuery + " AND cheque_status IN ('Pending','Return','Cancelled') ORDER BY cheque_date ASC");
            else return GetData(chequeQuery + $" AND (cheque_date BETWEEN '{startDate}' AND '{endDate}') ORDER BY cheque_date ASC");
        }

        //Update Cheque Details
        public bool updateCheque()
        {
            query = $"UPDATE {table_name} SET `cheque_no`='{chequeNo}',`bankname`='{bankName}',`cheque_status`='{chequeStatus}',`cheque_type`='{chequeType}',`cheque_date`='{chequeDate}' WHERE `{table_name}`.`payment_id` = " + paymentID;
            return ExecuteData(query);
        }

        //Find Cheque by ID
        public DataTable findCheque(string paymentID)
        {
            query = $"SELECT payment_id,{table_name}.people_id,{table_name}.refrence_id,tbl_people.name, `cheque_no`,`bankname`,`amount`,`cheque_type`,`cheque_date`,`cheque_status`, account_id, is_party, cheque_reference, cheque_people FROM `{table_name}` INNER JOIN tbl_people on tbl_people.people_id={table_name}.people_id WHERE payment_type='Cheque' and payment_id=" + paymentID;
            return GetData(query);
        }

        public DataTable viewPaymentLog(string startDate, string endDate,string peopleID="0")
        {
            string query = $"SELECT `payment_id`,{table_name}.`people_id`,`refrence_id`,CONVERT({table_name}.`created_at`,DATE) AS created_at,tbl_people.name,`payment_type`,`amount`,`note` FROM {table_name} INNER JOIN tbl_people on tbl_people.people_id = {table_name}.people_id WHERE (CONVERT({table_name}.created_at,DATE) BETWEEN '{startDate}' AND '{endDate}')";

            if (peopleID != "0") query += $" AND {table_name}.people_id={peopleID}";

            return GetData(query+$" ORDER BY {table_name}.created_at DESC");
        }

        public DataTable viewPaymentLogByRefrenceID(int refrenceID)
        {
            return GetData($"SELECT `payment_id`,people_id,`payment_type`,`amount`,CONVERT({table_name}.`created_at`,DATE) AS created_at,`note` FROM {table_name} where refrence_id=" + refrenceID);
        }

        public bool setTotalPaidofBill(int refrenceID)
        {
            DataTable dTable = GetData($"SELECT SUM({table_name}.amount) FROM `{table_name}` WHERE refrence_id =" + refrenceID);
            string totalPaid = dTable.Rows[0][0].ToString();

            if (totalPaid.Trim() == "" || totalPaid == null) totalPaid = "0";

            if(!is_supplier)
            {
                return ExecuteData($"UPDATE tbl_invoice SET paid_amount={totalPaid} where id={refrenceID}");
            }
            else
            {
                return ExecuteData($"UPDATE tbl_purchase SET paid_amount={totalPaid} where id={refrenceID}");
            }
            
        }

        public DataTable filterCheque(string search, string status, string startDate = "", string endDate = "", bool is_date = false)
        {
            query = chequeQuery;

            query += $" and ((tbl_people.name like '%{search}%') or (cheque_no like '%{search}%'))";
            if (status != "All") query += $" and cheque_status='{status}'";

            if (is_date) query += $" and ({table_name}.cheque_date between '{startDate}' and '{endDate}')";

            return GetData(query);
        }

        public bool removePayment(string paymentID, string amount, string peopleID)
        {
            if (peopleID == "1")
            {
                return ExecuteData($"DELETE FROM {table_name} where payment_id={paymentID};");
            }
            else
            {
                return ExecuteData($"DELETE FROM {table_name} where payment_id={paymentID}; UPDATE tbl_people SET balance=balance-{amount} WHERE people_id={peopleID}");
            }
        }

        public DataTable chequeAlert(int days)
        {
            return GetData($"SELECT `payment_id`,payment_type FROM tbl_sales_payment WHERE payment_type='Cheque' AND cheque_status='Pending' AND DATEDIFF(cheque_date,CURDATE())<{days} UNION SELECT tbl_purchase_payment.payment_id,payment_type FROM tbl_purchase_payment WHERE payment_type='Cheque' AND cheque_status='Pending' AND DATEDIFF(cheque_date,CURDATE())<{days}");
        }
    }
}
