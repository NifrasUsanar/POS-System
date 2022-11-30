using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace POS_System
{
    class UserRole : Connection
    {
        public string role { get; set; }
        public string permission { get; set; }

        public bool insertRole()
        {
            return ExecuteData($"insert into tbl_user_role (role,permission) values('{role}','{permission}')");
        }

        public DataTable findUserRole(int roleID)
        {
            return GetData("select * from tbl_user_role where id="+roleID);
        }

        public DataTable viewUserRole()
        {
            return GetData("SELECT * FROM `tbl_user_role`");
        }

        public bool updateUserRole(int roleID)
        {
            return ExecuteData($"UPDATE `tbl_user_role` SET `role`='{role}',`permission`='{permission}' WHERE id={roleID}");
        }

        public string[] returnUserPermission(string id)
        {
            return GetData("select permission from tbl_user_role where id="+id).Rows[0]["permission"].ToString().Split(',');
        }
    }
}
