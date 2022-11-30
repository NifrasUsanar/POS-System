using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class CashRegister:Database
    {
        public string cash_in_hand { get; set; }
        public string open_cash { get; set; }
        public string cheque_in_hand { get; set; }
        public string open_cheque { get; set; }
        public string note { get; set; }
        public string openedAt { get; set; }

        private LocalDatabase localRegister=new LocalDatabase();

        public int checkRegisterOpen()
        {
            DataTable dTable= localRegister.GetData("SELECT * FROM tbl_cash_register");

            if(dTable.Rows[0]["register_id"].ToString()!="0")
            {
                DataTable dTableCheck = GetData($"SELECT id FROM tbl_register WHERE is_open=1 AND id={dTable.Rows[0]["register_id"].ToString()}");

                if(dTableCheck.Rows.Count>0) return int.Parse(dTableCheck.Rows[0]["id"].ToString());
                else return 0;
            }
            if (dTable.Rows.Count > 0) return int.Parse(dTable.Rows[0]["register_id"].ToString());
            else return 0;
            //return GetData($"SELECT id from tbl_register where created_by={UserAuth.userid}");
        }

        public bool openCashRegister(string registerID)
        {
            //Update Current Cash Register in Local Database
            localRegister.ExecuteData($"UPDATE tbl_cash_register SET register_id={registerID}");

            return ExecuteData($"UPDATE `tbl_register` SET `open_cash`={open_cash},`open_cheque`={open_cheque},`cash_in_hand`={open_cash},`is_open`=1,`created_by`={UserAuth.userid}, created_at=CURRENT_TIMESTAMP() WHERE id={registerID}");
        }

        public bool closeRegister(int registerID)
        {
            ExecuteData($"UPDATE `tbl_register` SET `is_open`=0,`open_cash`=0,`cash_in_hand`=0,`open_cheque`=0 WHERE id='{registerID}'; INSERT INTO `tbl_register_end`(`register_id`, `open_cash`, `closing_cash`, `open_cheque`, `close_cheque`, `note`, `opened_at`, `created_by`) VALUES ({registerID},{open_cash},{cash_in_hand},{open_cheque},{cheque_in_hand},'{note}','{openedAt}',{UserAuth.userid});");

            return localRegister.ExecuteData("UPDATE tbl_cash_register SET register_id=0");
        }

        public DataTable cashRegisterDetails(int registerID)
        {
            return GetData($"SELECT `open_cash`,`open_cheque`,`cash_in_hand`,tbl_user.user_name,tbl_register.created_at FROM `tbl_register` LEFT JOIN tbl_user ON tbl_user.user_id = tbl_register.created_by WHERE tbl_register.id={registerID}");
        }

        public bool updateCashRegisterAmount(int registerID, decimal amount)
        {
            return ExecuteData($"UPDATE tbl_register SET cash_in_hand=cash_in_hand+{amount} WHERE id={registerID}");
        }
    }
}
