using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Return:Database
    {
        public string id { get; set; }
        public string invoiceid { get; set; }
        public string itemid { get; set; }
        public decimal price { get; set; }
        public decimal quantity { get; set; }
        public string reason { get; set; }
        public string batch { get; set; }
        public bool isStock { get; set; }
        public decimal discount { get; set; }
        public decimal cost { get; set; }
        public decimal indirect_cost { get; set; }

        string query;

        public DataTable viewReturn(string startDate, string endDate)
        {
            query = $"SELECT `invoiceid`,tbl_item.itm_name,`reason`,`price`,`quantity`,(price * quantity)-(discount*quantity) as total,discount,tbl_return.`created_at` FROM `tbl_return` INNER JOIN tbl_item on tbl_return.itemid = tbl_item.itm_id WHERE 1 and (tbl_return.created_at between '{startDate}' and '{endDate}')";
            return GetData(query);
        }

        public bool insertReturn()
        {
            //Return Items to Stock
            if (isStock) ExecuteData($"UPDATE `tbl_item_stock_location` SET `quantity`=quantity+{quantity} WHERE item_id={itemid} AND batch_no='{batch}' AND storage_id=1");

            query = $"INSERT INTO `tbl_return`(`invoiceid`, `itemid`, `price`,discount, `quantity`, `reason`,created_by) VALUES ({invoiceid},{itemid},{price},{discount},{quantity},'{reason}',{UserAuth.userid})";
            return ExecuteData(query);
        }

        public bool updateSoldItems()
        {
            return ExecuteData($"UPDATE tbl_sold_items set return_quantity={quantity}, item_quantity=item_quantity-{quantity} where id=" + id);
        }

        public bool updateInvoice()
        {
            decimal saleTotal = (quantity * price) - (quantity*discount);
            decimal profit = saleTotal-(quantity * cost);
            decimal indirect_profit = saleTotal-(quantity * indirect_cost);
      
            return ExecuteData($"UPDATE tbl_invoice set total=total-{saleTotal}, profit=profit-{profit}, indirect_profit=indirect_profit-{indirect_profit} where id=" + invoiceid);
        }
    }
}
