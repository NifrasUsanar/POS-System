using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class StockTransfer:Stock
    {
        public string note { get; set; }
        public string tranfer_at { get; set; }
        public int transfer_from { get; set; }
        public int transfer_to { get; set; }

        public bool insertStockTransfer(bool is_new=true)
        {
            //Insert and Update Quantity to destination
            if(is_new)
            {
                ExecuteData($"INSERT INTO `tbl_item_stock_location`(`storage_id`, `item_id`, `batch_no`, `quantity`) VALUES ({transfer_to},{itemID},'{batchNo}',{quantity})");

                ExecuteData($"UPDATE `tbl_item_stock_location` SET quantity=quantity-{quantity} WHERE `batch_no`='{batchNo}' AND item_id={itemID} AND storage_id={transfer_from}");
            }
            else
            {
                ExecuteData($"UPDATE `tbl_item_stock_location` SET quantity=quantity-{quantity} WHERE `batch_no`='{batchNo}' AND item_id={itemID} AND storage_id={transfer_from}");

                ExecuteData($"UPDATE `tbl_item_stock_location` SET quantity=quantity+{quantity} WHERE `batch_no`='{batchNo}' AND item_id={itemID} AND storage_id={transfer_to}");
            }

            return ExecuteData($"INSERT INTO `tbl_item_transfer`(`transfered_from`, `transfered_to`, `item_id`, `batch_no`, `quantity`, `transfer_at`, `remark`, `created_by`) VALUES ({transfer_from},{transfer_to},{itemID},'{batchNo}',{quantity},'{tranfer_at}','{note}',{UserAuth.userid})");
        }

        public bool alreadyAdded()
        {
            return true;
        }

        public DataTable viewTransferRecord(int itemID)
        {
            return GetData($"SELECT tbl_item.itm_name,`batch_no`,`quantity`,transfrom.name as transfered_from,transto.name as transfered_to,`transfer_at`,`remark` FROM `tbl_item_transfer` LEFT JOIN tbl_item on tbl_item.itm_id=item_id LEFT JOIN tbl_item_location as transfrom on transfrom.id=tbl_item_transfer.`transfered_from` LEFT JOIN tbl_item_location as transto ON transto.id=tbl_item_transfer.`transfered_to` WHERE 1 AND `item_id`={itemID}");
        }
    }
}
