using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class PurchaseReturn:Database
    {
        public int peopleID { get; set; }
        public int purchaseID { get; set; }
        public int refrenceNo { get; set; }
        public int itemID { get; set; }
        public string batch_no { get; set; }
        public string reason { get; set; }
        public decimal quantity { get; set; }
        public decimal costPrice { get; set; }
        public int cartID { get; set; }

        public bool insertPurchaseReturn()
        {
            
            string insertReturnQRY= $"INSERT INTO `tbl_purchase_return`(`purchase_id`, `item_id`,batch_no, `cost`, `quantity`, `reason`,`created_by`, created_at) VALUES ({purchaseID},{itemID},'{batch_no}',{costPrice},{quantity},'{reason}',{UserAuth.userid},'{DateTime.Now.ToString("yyyy-MM-dd")}')";

            if(ExecuteData(insertReturnQRY))
            {
                //Update Purchase Items Table
                ExecuteData($"UPDATE tbl_purchase_items SET quantity=quantity-{quantity}, return_quantity=return_quantity+{quantity} WHERE cart_id={cartID}");

                //Update Purchase table
                decimal total = costPrice * quantity;
                ExecuteData($"UPDATE tbl_purchase SET total=total-{total} WHERE id={purchaseID}");

                //Update Stock
                return ExecuteData($"UPDATE tbl_item_stock_location SET quantity=quantity-{quantity} WHERE batch_no LIKE '{batch_no}' AND item_id={itemID} AND storage_id=1");
            }

            return false;
        }

        public DataTable viewReturnHistory(string startDate, string endDate)
        {
            return GetData($"SELECT tbl_purchase_return.id,`purchase_id`,tbl_purchase.refrence_no,tbl_people.name,tbl_item.itm_name,`reason`,`cost`,`quantity`,(cost * quantity)-(tbl_purchase_return.discount*quantity) as total,tbl_purchase_return.`created_at` FROM tbl_purchase_return INNER JOIN tbl_item on tbl_purchase_return.`item_id` = tbl_item.itm_id INNER JOIN tbl_purchase ON tbl_purchase.id = tbl_purchase_return.purchase_id INNER JOIN tbl_people ON tbl_people.people_id=tbl_purchase.people_id WHERE 1 and (tbl_purchase_return.created_at between '{startDate}' and '{endDate}')");
        }

    }
}
