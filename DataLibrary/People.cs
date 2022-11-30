using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class People:Database
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public bool is_supplier { get; set; } = false;
        public string contact { get; set; }
        public decimal opening_balance { get; set; }
        public string customID { get; set; }
        public string city { get; set; }
        public bool isActive { get; set; }
        public string description { get; set; }

        private string query;

        public DataTable fillPeople(bool is_supplier)
        {
            //if (is_supplier) this.is_supplier = 1;
            //else this.is_supplier = 0;
            return GetData("SELECT tbl_people.people_id,tbl_people.name,tbl_people.address,tbl_people.contact_no FROM `tbl_people` WHERE status = 1 and is_supplier=" + is_supplier);
        }

        public DataTable findPeople(string peopleID)
        {
            return GetData("select * from tbl_people where people_id=" + peopleID);
        }

        public DataTable viewPeople()
        {
            return GetData("SELECT tbl_people.people_id,custom_id,tbl_people.name,tbl_people.city,tbl_people.contact_no, IF(status=1,'Active','Inactive') as status,(balance+(-1*opening_balance)) as balance FROM `tbl_people` WHERE people_id != 1 and is_supplier=" + is_supplier);
        }

        //Insert New People Item
        public bool insert_people()
        {
            query = $"INSERT INTO `tbl_people`(custom_id,`name`, `is_supplier`, `address`, `contact_no`,opening_balance, city,status, description) VALUES ('{customID}','{name}',{is_supplier},'{address}', '{contact}',0,'{city}',1,'{description}')";

            return ExecuteData(query);
        }

        //Update People Item
        public bool update_people()
        {
            query = $"UPDATE `tbl_people` SET custom_id='{customID}', `name`='{name}',`address`='{address}',`contact_no`='{contact}', status={isActive},opening_balance={opening_balance}, city='{city}', description='{description}' where people_id={id}";
            return ExecuteData(query);
        }

        //Delete a People
        public bool delete_people()
        {
            query = "DELETE tbl_user where people_id=" + id;
            return ExecuteData(query);
        }

        //Show People name in seperated datagridview like dropdown menu
        public DataTable showPeopleName(bool is_supplier)
        {
            return GetData("select people_id,name,concat('Rs. ',opening_balance+balance) as balance from tbl_people where is_supplier=" + is_supplier + " ORDER BY people_id DESC");
        }

        //Search and Filter People
        public DataTable filterPeople(string search, string type, bool is_supplier)
        {
            string query = "SELECT tbl_people.people_id,tbl_people.name,tbl_people.address,tbl_people.contact_no FROM `tbl_people` WHERE people_id!=1 and is_supplier=" + is_supplier;

            if (type == "Name") query += $" and name like ('%{search}%')";
            else if (type == "Address") query += $" and address like ('%{search}%')";
            else if (type == "Contact") query += $" and contact_no like ('%{search}%')";

            return GetData(query);
        }

        public bool updatePeopleBalance(int peopleID, decimal balance)
        {
            query = $"UPDATE tbl_people set balance=balance+{balance} where people_id={peopleID}";
            return ExecuteData(query);
        }

        public string getCustomID(bool is_supplier)
        {
            return getSingleValue($"SELECT COUNT(*)+1 from tbl_people where is_supplier={is_supplier}");
        }

        public bool adjustBalance(string peopleID, string balance)
        {
            return ExecuteData($"UPDATE tbl_people set balance={balance} WHERE people_id={peopleID}");
        }
    }
}
