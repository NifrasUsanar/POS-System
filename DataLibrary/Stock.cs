using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Stock:Item
    {
        public string batchNo { get; set; }      
        public decimal indirect_cost { get; set; }      
        public decimal whole_sale_price { get; set; }
        public decimal retail_price { get; set; }
        public decimal discount { get; set; }

        public DataTable findStockForTransfer(string barCode)
        {
            return GetData($"SELECT tbl_item_stock_location.id as stockid,tbl_item_stock_location.`item_id`,`storage_id`,itm_name,tbl_item_stock_location.batch_no,quantity as available,tbl_item_location.name,tbl_item_stock.sale_price,tbl_item_stock.cost,mf_date,exp_date FROM tbl_item_stock_location LEFT JOIN tbl_item on tbl_item.itm_id=tbl_item_stock_location.item_id INNER JOIN tbl_item_stock ON tbl_item_stock.item_id=tbl_item_stock_location.item_id AND tbl_item_stock.batch_no=tbl_item_stock_location.batch_no LEFT JOIN tbl_item_location on tbl_item_location.id=tbl_item_stock_location.storage_id WHERE tbl_item.itm_barcode='{barCode}' GROUP BY tbl_item_stock_location.batch_no,tbl_item_stock_location.storage_id");
        }

        public string returnLastItemCode()
        {
            DataTable dTable = GetData("SELECT MAX(itm_code)+1 FROM tbl_item");

            if (dTable.Rows[0][0].ToString().Trim() == "") return "1";
            else return dTable.Rows[0][0].ToString();
        }

        public bool adjustStock()
        {
            return ExecuteData($"INSERT INTO `tbl_stock_adjustment`(`item_id`, `quantity`, `description`, `created_by`) VALUES ({itemID},{quantity},'{item_desc}',{UserAuth.userid}); UPDATE tbl_item SET quantity=quantity+{quantity} WHERE itm_id={itemID}");
        }

        public DataTable viewStockHistory(string startDate, string endDate)
        {
            return GetData($"SELECT tbl_item.itm_code, tbl_item.itm_name,tbl_stock_adjustment.quantity,tbl_stock_adjustment.description,tbl_stock_adjustment.created_at,tbl_user.user_username FROM tbl_stock_adjustment LEFT JOIN tbl_item ON tbl_item.itm_id=tbl_stock_adjustment.item_id LEFT JOIN tbl_user ON tbl_user.user_id=tbl_stock_adjustment.created_by WHERE 1 AND (CONVERT(tbl_stock_adjustment.created_at,DATE) BETWEEN '{startDate}' AND '{endDate}')");
        }
    }
}
