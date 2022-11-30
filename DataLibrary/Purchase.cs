using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Purchase:Database
    {
        public string purchaseid { get; set; }
        public string itemid { get; set; }
        public decimal total { get; set; }
        public decimal discount { get; set; }
        public decimal quantity { get; set; }
        public decimal paid_amount { get; set; }
        public int peopleID { get; set; }
        public string note { get; set; }
        public decimal itemcost { get; set; }
        public string refrenceNo { get; set; }
        public decimal indirect_total { get; set; } = 0;
        public string purchaseDate { get; set; }

        //Insert Purchase
        public bool insertPurchase(bool addToStock=false)
        {
            //Insert Purchase Details 
            if (ExecuteData($"INSERT INTO `tbl_purchase`(`people_id`, `total`,indirect_total, `discount`, `paid_amount`,`note`, created_at,`created_by`,refrence_no,is_stock) VALUES ({peopleID},{total},{indirect_total},{discount},0,'{note}','{purchaseDate}',{UserAuth.userid},{refrenceNo},{addToStock})"))
            {
                //Get Purchase id which is last added
                DataTable dTable = GetData("select max(id) from tbl_purchase");

                purchaseid = dTable.Rows[0][0].ToString();

                if (!addToStock)
                {
                    //Finally Update With Purchase ID
                    return ExecuteData($"UPDATE `tbl_purchase_items` SET is_complete=1, purchase_id={purchaseid} WHERE is_complete <> 1 and created_by={UserAuth.userid}");
                }
                else
                {
                    return ExecuteData($"UPDATE tbl_item INNER JOIN tbl_purchase_items ON tbl_purchase_items.item_id=tbl_item.itm_id AND tbl_purchase_items.is_complete=0 SET tbl_item.quantity=(tbl_item.quantity+tbl_purchase_items.quantity), tbl_item.cost=tbl_purchase_items.indirect_cost, tbl_item.sale_price=tbl_purchase_items.sale_price,tbl_item.mf_date=tbl_purchase_items.mf_date, tbl_item.exp_date=tbl_purchase_items.exp_date; UPDATE `tbl_purchase_items` SET is_complete=1, purchase_id={purchaseid} WHERE is_complete <> 1 and created_by={UserAuth.userid};");
                }
            }
            return false;
        }

        public DataTable findPurchase(int purchaseID)
        {
            return GetData("select tbl_people.name,tbl_purchase.* from tbl_purchase INNER JOIN tbl_people on tbl_people.people_id = tbl_purchase.people_id where `id`=" + purchaseID);
        }

        public DataTable filterPurchase(string peopleID, string startDate, string endDate)
        {
            string viewQuery = $"SELECT RIGHT(CONCAT('0000', `id`),4) as id,tbl_purchase.people_id,refrence_no,tbl_people.name,`discount`,`total`,`paid_amount`,tbl_purchase.`created_at`,IF(purchase_status=0,'OPEN','CLOSED') as status FROM `tbl_purchase` INNER JOIN tbl_people on tbl_people.people_id=tbl_purchase.people_id WHERE 1 and(tbl_purchase.created_at between '{startDate}' and '{endDate}')";

            if (peopleID != "0") viewQuery += $" AND tbl_purchase.people_id={peopleID}";

            return GetData(viewQuery + " ORDER BY `tbl_purchase`.`created_at` DESC");
        }

        public DataTable findPurchaseRefrenceBySupplier(int supplierID)
        {
            return GetData($"SELECT refrence_no FROM tbl_purchase where people_id={supplierID}");
        }

        public DataTable findPurchaseItemsByRefrenceNo(string refrenceNo, string peopleID)
        {
            return GetData($@"SELECT cart_id,tbl_purchase.`id`,refund_amount,`people_id`,`refrence_no`,`total`,`paid_amount`,`storage_id`,`item_id`,tbl_purchase_items.created_at,`batch_no`,tbl_item.itm_name,`cost`,tbl_purchase_items.`quantity`,tbl_purchase_items.return_quantity, 
(tbl_purchase_items.quantity*tbl_purchase_items.cost) as line_amount FROM tbl_purchase INNER JOIN tbl_purchase_items ON tbl_purchase.id = tbl_purchase_items.purchase_id INNER JOIN tbl_item ON tbl_item.itm_id=tbl_purchase_items.item_id WHERE tbl_purchase.refrence_no={refrenceNo} AND tbl_purchase.people_id={peopleID}");
        }

        public bool updatePurchaseRefund(int purchaseID, decimal refundAmount)
        {
            return ExecuteData($"UPDATE tbl_purchase SET refund_amount=refund_amount+{refundAmount} WHERE id={purchaseID}");
        }

        public bool updatePurchase(int purchaseID, bool is_stock, bool purchase_status)
        {
            return ExecuteData($"UPDATE tbl_purchase SET people_id={peopleID}, refrence_no={refrenceNo}, total={total},discount={discount},created_at='{purchaseDate}',is_stock={is_stock},purchase_status={purchase_status} WHERE id={purchaseID}");
        }

        public bool updatePurchaseStatus(int purchaseID,bool purchaseStatus, string peopleID, string sign, decimal balance)
        {
            return ExecuteData($"UPDATE tbl_purchase SET purchase_status={purchaseStatus} WHERE id={purchaseID}; UPDATE tbl_people SET balance=balance{sign}{balance} WHERE people_id={peopleID}");
        }

        public bool deletePurchase(int purchaseID)
        {
            return ExecuteData($"DELETE FROM tbl_purchase WHERE id={purchaseID}; DELETE FROM tbl_purchase_items WHERE purchase_id={purchaseID}");
        }
    }
}
