using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLibrary;

namespace POS_System
{
    class UserAuthentication:Connection
    {
        public string username { get; set; }
        public string passsword { get; set; }

        public bool login()
        {
            Global.dTable = GetData($"SELECT * FROM `tbl_user` where user_username='{username}'");

            if (Global.dTable.Rows.Count > 0)
            {
                if (Global.dTable.Rows[0]["user_password"].ToString() == passsword)
                {
                    if (!bool.Parse(Global.dTable.Rows[0]["is_active"].ToString()))
                    {
                        insertUserLogDetails(Global.dTable.Rows[0]["user_id"].ToString(), 3);

                        Animation.showMessage("You are not authorized to login", "error");
                    }
                    else
                    {
                        Global.userid = int.Parse(Global.dTable.Rows[0]["user_id"].ToString());
                        Global.loggedUserName = Global.dTable.Rows[0]["user_name"].ToString();
                        UserAuth.userid = Global.userid;

                        string roleID = Global.dTable.Rows[0]["user_role"].ToString();

                        if (roleID == "1") Global.is_admin = true;
                        else Global.is_admin = false;

                        if (!Global.is_admin) Global.permission = new UserRole().returnUserPermission(roleID);

                        insertUserLogDetails(Global.dTable.Rows[0]["user_id"].ToString(), 1);

                        return true;
                    }
                }
                else
                {
                    insertUserLogDetails(Global.dTable.Rows[0]["user_id"].ToString(), 2);
                    Animation.showMessage("Incorrect Password", "error");
                }
            }
            else
            {
                insertUserLogDetails("0",0);
                Animation.showMessage("The User Doesn't Exist", "error");
            }

            return false;
        }

        public DataTable checkUserName(string username)
        {
            return GetData($"SELECT * FROM `tbl_user` where user_username='{username}'");
        }

        public bool resetPassword(string password, string userName)
        {
            return ExecuteData($"UPDATE `tbl_user` SET user_password='{password}' where user_username='{userName}'");
        }

        /* 1 = Login Success
           0 = Attempt Failed (Anonymus)
           2 = Incorrect Password
           3 = Login Blocked
        */
        public bool insertUserLogDetails(string userID, int logType)
        {
            return ExecuteData($"INSERT INTO `tbl_user_log`(`user_id`, `log_type`) VALUES ({userID},{logType})");
        }

        public DataTable viewUserLog(string startDate, string endDate)
        {
           return GetData($"SELECT tbl_user.user_username,tbl_user.user_name,CASE WHEN log_type = 0 THEN 'Anonymous Attempt' WHEN log_type = 1 THEN 'Login Success' WHEN log_type = 2 THEN 'Incorrect Password' WHEN log_type = 3 THEN 'Login Blocked' END AS log_type, log_time FROM `tbl_user_log` LEFT JOIN tbl_user ON tbl_user.user_id = tbl_user_log.user_id WHERE 1 AND (CONVERT(tbl_user_log.log_time,DATE) BETWEEN '{startDate}' AND '{endDate}')");
        }
    }
}
