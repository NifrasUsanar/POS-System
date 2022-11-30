using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class PurchaseOrder:Database
    {
        public string itemID { get; set; }
        public decimal quantity { get; set; }
        public string supplierID { get; set; } 
        public string orderID { get; set; } = "0";

        public DataTable viewPurchaseOrder()
        {
            return GetData($"SELECT `id`,`supplier_id`,tbl_people.name,tbl_purchase_order.status, tbl_purchase_order.created_at FROM tbl_purchase_order LEFT JOIN tbl_people ON tbl_people.people_id = tbl_purchase_order.supplier_id ORDER BY tbl_purchase_order.created_at");
        }

        public bool changeOrderStatus(string status, string orderID)
        {
            return ExecuteData($"UPDATE tbl_purchase_order SET status='{status}' WHERE id={orderID}");
        }

        public DataTable viewAlertProducts()
        {
           
            return GetData($"SELECT tbl_item_stock_location.item_id,tbl_item.itm_name,tbl_item.itm_alert AS alert,CONCAT(SUM(tbl_item_stock_location.quantity), ' ' ,tbl_item.`itm_unite_type`) AS quantity FROM tbl_item LEFT JOIN tbl_item_stock_location ON tbl_item.itm_id=tbl_item_stock_location.item_id GROUP BY itm_id HAVING alert>SUM(tbl_item_stock_location.quantity)");
        }

        public DataTable viewProductByQuantity(string quantity, string unitType = "")
        {
            string whereQuery = "";
            if (unitType != "All Unit") whereQuery = $" WHERE `tbl_item`.`itm_unite_type` LIKE '{unitType}' ";

            return GetData($"SELECT tbl_item_stock_location.item_id,tbl_item.itm_name,tbl_item.itm_alert AS alert,CONCAT(SUM(tbl_item_stock_location.quantity), ' ' ,tbl_item.`itm_unite_type`) AS quantity FROM tbl_item LEFT JOIN tbl_item_stock_location ON tbl_item.itm_id=tbl_item_stock_location.item_id {whereQuery} GROUP BY itm_id HAVING {quantity}>SUM(tbl_item_stock_location.quantity)");
        }

        public bool insertPurchaseOrderCart()
        {
            return ExecuteData($"INSERT INTO `tbl_purchase_order_cart`(order_id, `item_id`, `qty`) VALUES ({orderID},{itemID},{quantity})");
        }

        public bool updatePurchaseOrderCart(string cartID)
        {
            return ExecuteData($"UPDATE tbl_purchase_order_cart SET qty={quantity} WHERE id={cartID}");
        }

        public bool deletePurchaseOrderCart(string cartID)
        {
            return ExecuteData($"DELETE FROM tbl_purchase_order_cart WHERE id={cartID}");
        }

        public DataTable viewPurchaseCart()
        {
            return GetData($"SELECT `id`, `item_id`, tbl_item.itm_name, CONCAT(qty, ' ' ,tbl_item.`itm_unite_type`) as qty FROM `tbl_purchase_order_cart` LEFT JOIN tbl_item ON tbl_item.itm_id=item_id WHERE order_id={orderID}");
        }

        public bool insertPurchaseOrder()
        {
            DataTable dTable =  GetData($"INSERT INTO `tbl_purchase_order`(`supplier_id`, `note`, `created_by`) VALUES ({supplierID},'...',{UserAuth.userid}); SELECT MAX(id) FROM tbl_purchase_order;");

            return ExecuteData($"UPDATE tbl_purchase_order_cart SET order_id={dTable.Rows[0][0].ToString()} WHERE order_id=0");
        }

        public bool updatePurchaseOrder(string orderID)
        {
            return ExecuteData($"UPDATE tbl_purchase_order SET supplier_id={supplierID} WHERE id={orderID}");
        }

        public DataTable viewPurchasePrint(string orderID)
        {
            return GetData($"SELECT tbl_item.itm_name, qty, name FROM tbl_purchase_order_cart LEFT JOIN tbl_item ON tbl_item.itm_id = tbl_purchase_order_cart.item_id LEFT JOIN tbl_purchase_order ON tbl_purchase_order.id = tbl_purchase_order_cart.order_id LEFT JOIN tbl_people ON tbl_people.people_id = tbl_purchase_order.supplier_id WHERE tbl_purchase_order_cart.order_id = {orderID}");
        }
    }
}
