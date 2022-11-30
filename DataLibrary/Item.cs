using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Item:Database
    {
        public int itemID { get; set; }
        public string item_code { get; set; }
        public string item_brcode { get; set; }
        public string item_name { get; set; }
        public string item_image { get; set; }
        public string item_unit { get; set; }
        public int item_category { get; set; }
        public int item_brand { get; set; }
        public double item_alert { get; set; }
        public int created_by { get; set; }
        public string item_desc { get; set; }
        public bool is_featured { get; set; }
        public decimal sale_price { get; set; }
        public decimal quantity { get; set; }
        public string manufacture { get; set; }
        public string expiry { get; set; }
        public decimal cost { get; set; }

        private string query;
        private string view_query = $@"SELECT itm_id,itm_code,itm_name,quantity,cost,(quantity*cost) as valuation,sale_price,itm_alert,tbl_category.category_name,tbl_brand.brand_name FROM tbl_item LEFT JOIN tbl_category ON tbl_category.category_id=tbl_item.itm_categary_id LEFT JOIN tbl_brand ON tbl_brand.brand_id=tbl_item.itm_brand_id WHERE 1";

        private string posQuery = $@"SELECT itm_id as item_id,CONCAT(itm_name,IF(tbl_brand.brand_name IS NULL,'',CONCAT(' - ',tbl_brand.brand_name))) AS item_name,tbl_brand.brand_name, quantity as available,CONCAT(itm_name,' (',quantity,' ',itm_unite_type,') ') as itm_name,cost,sale_price FROM tbl_item LEFT JOIN tbl_brand ON tbl_brand.brand_id=tbl_item.itm_brand_id WHERE 1";

        private string resultQuery = "SELECT count(*) FROM tbl_item LEFT JOIN tbl_category ON tbl_category.category_id=tbl_item.itm_categary_id LEFT JOIN tbl_brand ON tbl_brand.brand_id=tbl_item.itm_brand_id WHERE 1";

        public DataTable viewStock(int limit, int offset, bool is_stock = false)
        {
            string alertQry = "";
            if (is_stock) alertQry = " AND itm_alert>quantity";

            return GetData(view_query + $"{alertQry} LIMIT {limit} OFFSET {offset}");

            //return GetData(view_query + " GROUP BY tbl_item_stock_location.item_id ORDER BY tbl_item_stock_location.quantity DESC");
        }

        public DataTable findItem(int itemID)
        {
            if (itemID != 0)
            {
                return GetData(view_query + " AND itm_id=" + itemID);
            }
            else return GetData(view_query + " ORDER BY itm_id desc LIMIT 1");
        }

        //Get total results details before retrieve records from database
        public decimal totalResults(bool is_filter,bool is_alert,string search="", string brand="", string category="")
        {
            string query = resultQuery;

            if (is_filter)
            {
                query += $" AND ((tbl_item.itm_barcode like ('%{search}%')) or (tbl_item.itm_name like ('%{search}%')) or (tbl_item.itm_code like ('%{search}%')))";

                if (brand == "All Brand" && category != "All Category")
                {
                    query += $" and (tbl_category.category_name='{category}')";
                }
                else if (brand != "All Brand" && category == "All Category")
                {
                    query += $" and (tbl_brand.brand_name='{brand}')";
                }
                else if (brand != "All Brand" && category != "All Category")
                {
                    query += $" and ((tbl_brand.brand_name='{brand}') and (tbl_category.category_name='{category}'))";
                }
            }
            else if (is_alert) query += " AND itm_alert>quantity";

            return Convert.ToDecimal(getSingleValue(query));
        }

        public DataTable stockSummary()
        {
            return GetData("SELECT SUM(quantity*cost) AS valuation, SUM(quantity) AS quantity, COUNT(*) AS items FROM tbl_item");
        }

        //Get StockItem Information By ID
        public DataTable item_details(string barcode="")
        {
            if (barcode == "") query = "select * from tbl_item where itm_id=" + itemID;
            else query = $"select * from tbl_item where itm_barcode='{barcode}'";
            return GetData(query);
        }

        //Insert New Stock Item
        public bool insert_item()
        {
            DateTime now = DateTime.Now;
            query = $@"INSERT INTO `tbl_item`(`itm_code`, `itm_name`, `itm_categary_id`, `itm_brand_id`, `itm_alert`, `itm_desc`, `itm_unite_type`,cost,sale_price,quantity,`is_featured`, `is_active`, `created_by`,mf_date, exp_date) VALUES ('{item_code}','{item_name}',{item_category},{item_brand},{item_alert},'{item_desc}','{item_unit}',{cost},{sale_price},{quantity},{is_featured},1,{UserAuth.userid},NULLIF('{manufacture}',''),NULLIF('{expiry}',''))";

            return ExecuteData(query);
        }

        //Update Stock Item
        public bool update_item(int itemID)
        {
            query = $@"UPDATE `tbl_item` SET `itm_barcode`='{item_brcode}',`itm_code`='{item_code}',`itm_name`='{item_name}',`itm_categary_id`={item_category},`itm_brand_id`={item_brand},`itm_alert`={item_alert},`itm_desc`='{item_desc}',`itm_unite_type`='{item_unit}',`is_featured`={is_featured},cost={cost}, sale_price={sale_price},quantity={quantity}, mf_date=NULLIF('{manufacture}',''), exp_date=NULLIF('{expiry}','') WHERE itm_id={itemID}";
            return ExecuteData(query);
        }


        public DataTable itemSearchinPOS(string search, int method)
        {
            string query = "";
            switch(method)
            {
                //case 2: query = posQuery + $" and tbl_item.itm_barcode like '{search}'"; break;
                case 1: query = posQuery + $" and tbl_item.itm_code like '{search}'"; break;
                case 0: query = posQuery + $" HAVING item_name like ('" + search + "%')"; break;
            }
            return GetData(query);
        }

        public DataTable itemViewbyCategory(string catid)
        {
            return GetData(posQuery + " and tbl_item.is_active=1 and itm_categary_id=" + catid);
        }

        public DataTable itemViewByFeatured()
        {
            return GetData(posQuery + " and is_featured=1 and tbl_item.is_active=1");
        }

        public DataTable alertQuantity()
        {
            DataTable dTable = GetData("SELECT itm_id FROM tbl_item WHERE itm_alert>quantity");
            return dTable;
        }

        public DataTable filterStock(string search, string brand, string category,int limit, int offset)
        {
            string query = view_query;
            query += $" and ((tbl_item.itm_barcode like ('%{search}%')) or (tbl_item.itm_name like ('%{search}%')) or (tbl_item.itm_code like ('%{search}%')))";

            if (brand == "All Brand" && category != "All Category")
            {
                query += $" and (tbl_category.category_name='{category}')";
            }
            else if (brand != "All Brand" && category == "All Category")
            {
                query += $" and (tbl_brand.brand_name='{brand}')";
            }
            else if (brand != "All Brand" && category != "All Category")
            {
                query += $" and ((tbl_brand.brand_name='{brand}') and (tbl_category.category_name='{category}'))";
            }

            return GetData(query+ $" LIMIT {limit} OFFSET {offset}");
        }

        public int lastAddedItemIDusingBarcode(string barcode)
        {
            DataTable dTable = GetData($"select max(itm_id) from tbl_item where itm_barcode='{barcode}'");

            return int.Parse(dTable.Rows[0][0].ToString());
        }

        public DataTable fillItemWithBrand()
        {
            return GetData("SELECT CONCAT(itm_name,IF(tbl_brand.brand_name IS NULL,'',CONCAT(' - ',tbl_brand.brand_name))) AS item_name FROM tbl_item LEFT JOIN tbl_brand ON tbl_brand.brand_id=tbl_item.itm_brand_id WHERE is_active=1");
        }

        public bool updateStockByQuantity(string itemID,decimal quantity)
        {
            return ExecuteData($"UPDATE tbl_item SET quantity=quantity+{quantity} WHERE itm_id={itemID}");
        }
    }
}
