using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary

{
    public class User : Database
    {
        public int user_id { get; set; }
        public string user_username { get; set; }
        public string user_pw { get; set; }
        public string user_role { get; set; }
        public string user_question { get; set; }
        public string user_answer { get; set; }
        public string user_email { get; set; }
        public string user_contact { get; set; }
        public string user_nic { get; set; }
        public bool is_active { get; set; }
        public string user_name { get; set; }

        private string query;
        private string view_query = "SELECT `user_id`, user_name,`user_username`, tbl_user_role.role, `email`, `contact`, CASE WHEN is_active=true THEN 'Active' ELSE 'In Active' END as `is_active`, `created_at` FROM `tbl_user` INNER JOIN tbl_user_role on tbl_user.user_role=tbl_user_role.id ";
      
        public DataTable viewUser()
        {
            return GetData(view_query + "WHERE user_id!=1");
        }

        public DataTable findUser(int userID)
        {
            return GetData("SELECT * FROM `tbl_user` INNER JOIN tbl_user_role on tbl_user.user_role=tbl_user_role.id WHERE user_id=" + userID);
        }

        //Insert New Stock Item
        public bool insert_user()
        {
            DateTime now = DateTime.Now;
            query = @"INSERT INTO `tbl_user`(`user_username`, user_name,`user_password`, `user_role`, `user_question`, `user_answer`, `email`, `contact`, `nic`,is_active)
            VALUES ('" + user_username + "','"+user_name+"','" + user_pw + "'," + user_role + ", '" + user_question + "','" + user_answer + "','" + user_email + "','" + user_contact + "','" + user_nic + "',"+is_active+")";
            return ExecuteData(query);
        }

        //Update Stock Item
        public bool update_user()
        {
            query = @"UPDATE `tbl_user` SET user_name='"+user_name+"', `user_username`='" + user_username + "',`user_password`='" + user_pw + "',`user_role`=" + user_role + ",`user_question`='" + user_question + "',`user_answer`='" + user_answer + "',`email`='" + user_email + "',`contact`='" + user_contact + "',`nic`='" + user_nic + "', is_active="+is_active+" WHERE `tbl_user` . `user_id`=" + user_id;
            return ExecuteData(query);
        }

        //Delete a Stock Item
        public bool delete_user()
        {
            query = "DELETE tbl_user where user_id=" + user_id;
            return ExecuteData(query);
        }

        public bool updateProfile(int userID)
        {
            return ExecuteData("UPDATE `tbl_user` SET user_name = '"+user_name+"',`user_question`= '" + user_question + "',`user_answer`= '" + user_answer + "',`email`= '" + user_email + "',`contact`= '" + user_contact + "',`nic`= '" + user_nic + "' WHERE `tbl_user` . `user_id`= " + userID);
        }

        public bool checkPassword(int userID, string userPassword)
        {
            DataTable dTable = GetData("select user_password from tbl_user where user_password='"+ userPassword + "' and user_id="+userID);
            if (dTable.Rows.Count > 0) return true;
            else return false;
        }

        public bool updatePassword(string userPassword, int userID)
        {
            return ExecuteData("UPDATE tbl_user set user_password='"+userPassword+"' where user_id="+userID);
        }
    }
}
