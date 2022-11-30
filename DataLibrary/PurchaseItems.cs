using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class PurchaseItems:Stock
    {
        public bool insertCart(int purchaseID)
        {
            //Cost is Price, Indirect Cost is Item Cost (with transport, wages)
            return ExecuteData($"INSERT INTO `tbl_purchase_items`(purchase_id,storage_id,`item_id`, `batch_no`, `mf_date`, `exp_date`, `cost`, indirect_cost,`sale_price`, `whole_sale_price`, `retail_price`, `discount`, `quantity`, `created_by`) VALUES ({purchaseID},1,{itemID},' ',NULLIF('{manufacture}',''),NULLIF('{expiry}',''),{cost},{indirect_cost},{sale_price},{whole_sale_price},{retail_price},{discount},{quantity},{UserAuth.userid})");
        }

        public bool updateCart(string cartID)
        {
             return ExecuteData($"UPDATE `tbl_purchase_items` SET `mf_date`=NULLIF('{manufacture}',''),`exp_date`=NULLIF('{expiry}',''),`cost`={cost},indirect_cost={indirect_cost},`sale_price`={sale_price},`whole_sale_price`={whole_sale_price},`retail_price`={retail_price},`discount`={discount},`quantity`={quantity} WHERE cart_id={cartID}");
        }

        public DataTable viewPurchaseCart(int purchaseID=0)
        {
            string viewQRY = "SELECT item_id,`cart_id`, tbl_item.itm_name,tbl_purchase_items.`cost`,tbl_purchase_items.indirect_cost,tbl_purchase_items.`quantity`,(`discount`*tbl_purchase_items.quantity) AS discount,(tbl_purchase_items.cost-discount)*tbl_purchase_items.quantity as total,(tbl_purchase_items.quantity*indirect_cost) as indirect_total,tbl_purchase_items.`sale_price`,tbl_purchase_items.`mf_date`,tbl_purchase_items.`exp_date`  FROM `tbl_purchase_items` INNER JOIN tbl_item on tbl_item.itm_id=tbl_purchase_items.item_id WHERE 1";

            if (purchaseID == 0) return GetData($"{viewQRY} AND is_complete=0");
            else return GetData($"{viewQRY} AND purchase_id={purchaseID}");
        }

        public bool deletePurchaseCart(string cartID)
        {
            return ExecuteData($"DELETE FROM tbl_purchase_items where cart_id={cartID}");
        }

        public DataTable findPurchaseItem(string cartID)
        {
            return GetData($"SELECT * FROM tbl_purchase_items WHERE cart_id={cartID}");
        }

        public DataTable viewPurchaseItems(string startDate, string endDate, string peopleID)
        {
            string query = $@"SELECT `item_id`,tbl_purchase.`refrence_no`,cart_id,tbl_people.name,tbl_item.itm_name,tbl_purchase_items.`cost`,tbl_purchase_items.`quantity`,(tbl_purchase_items.`discount`*tbl_purchase_items.quantity) AS tldiscount, 
            (tbl_purchase_items.quantity*tbl_purchase_items.cost) as line_amount FROM tbl_purchase INNER JOIN tbl_purchase_items ON tbl_purchase.id = tbl_purchase_items.purchase_id INNER JOIN tbl_item ON tbl_item.itm_id=tbl_purchase_items.item_id INNER JOIN tbl_people ON tbl_people.people_id = tbl_purchase.people_id WHERE (tbl_purchase.created_at BETWEEN '{startDate}' AND '{endDate}')";

            if (peopleID != "0") query += $" AND tbl_purchase.people_id={peopleID}";

            return GetData(query+ " ORDER BY tbl_purchase.created_at");
        }

        //public bool stockUpdate(bool is_stock, int purchaseID)
        //{
        //    if (is_stock)
        //    {
        //        return ExecuteData($"UPDATE tbl_item INNER JOIN tbl_purchase_items ON tbl_purchase_items.item_id=tbl_item.itm_id AND tbl_purchase_items.purchase_id={purchaseID} SET tbl_item.quantity=(tbl_item.quantity+tbl_purchase_items.quantity), tbl_item.cost=tbl_purchase_items.indirect_cost, tbl_item.sale_price=tbl_purchase_items.sale_price,tbl_item.mf_date=tbl_purchase_items.mf_date, tbl_item.exp_date=tbl_purchase_items.exp_date");
        //    }
        //    else
        //    {
        //        return ExecuteData($"UPDATE tbl_item INNER JOIN tbl_purchase_items ON tbl_purchase_items.item_id=tbl_item.itm_id AND tbl_purchase_items.purchase_id={purchaseID} SET tbl_item.quantity=(tbl_item.quantity-tbl_purchase_items.quantity);");
        //    }
        //}
    }
}
