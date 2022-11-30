using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataLibrary;

namespace DataLibrary
{
    public class Invoice : Database
    {
        public string invoice_id { get; set; }
        public decimal total { get; set; }
        public decimal discount { get; set; }
        public decimal profit { get; set; }
        public string paid_amount { get; set; }
        public int peopleID { get; set; }
        public decimal indirect_profit { get; set; }
        public string reference { get; set; }
        public string created_at { get; set; }

        string query;
        string viewQuery = "SELECT RIGHT(CONCAT('00000', `id`),5) as id,tbl_invoice.people_id,tbl_people.name,reference,`total`,`discount`,(profit-discount) as profit,`paid_amount`,tbl_invoice.`created_at`,tbl_invoice.status FROM `tbl_invoice` INNER JOIN tbl_people on tbl_people.people_id = tbl_invoice.people_id WHERE 1";

        DataTable dTable = new DataTable();

        //Insert Sales record and return added sales ID
        public string insertSale()
        {
            //Insert Sale
            query = $@"INSERT INTO `tbl_invoice`(reference,`total`, `discount`, `paid_amount`,profit,indirect_profit,`people_id`,status,created_by) VALUES ('{reference}',{ total},{discount},{paid_amount},{profit},{indirect_profit},{ peopleID},'Closed',{ UserAuth.userid})";
            ExecuteData(query);

            //Getting Invoice ID
            dTable = GetData("SELECT MAX(id) FROM `tbl_invoice` WHERE 1");

            ExecuteData($"UPDATE tbl_item INNER JOIN tbl_cart ON tbl_cart.item_id=tbl_item.itm_id AND tbl_cart.created_by={UserAuth.userid} SET tbl_item.quantity=(tbl_item.quantity-tbl_cart.item_quantity)");

            //Set Invoice ID after Insert the Invoice
            invoice_id = dTable.Rows[0][0].ToString();

            //Insert Items related to Invoice
            insertStockTransaction();
            return invoice_id;
        }

        private void insertStockTransaction()
        {
            query = @"INSERT INTO `tbl_sold_items`(`invoice_id`,`item_id`, batch_no,retail_price,`item_cost`, indirect_cost,`item_price`, `item_discount`, `item_quantity`,note) 
            SELECT " + invoice_id+ ",`item_id`, tbl_cart.batch_no,tbl_cart.retail_price,`item_cost`,tbl_cart.indirect_cost,`item_price`, `item_discount`, `item_quantity`,'' FROM `tbl_cart` WHERE 1";

            if (ExecuteData(query))
            {
                //Clear the Cart after Invoice Inserted
                new Cart().clearCart();
            }
        }

        public DataTable viewInvoice(string startDate, string endDate,string peopleID)
        {
            string query = viewQuery + $" AND (CONVERT(tbl_invoice.created_at,DATE) BETWEEN '{startDate}' AND '{endDate}')";

            if (peopleID != "0") query += $" AND (tbl_invoice.people_id={peopleID})";

            return GetData(query+ " ORDER BY `tbl_invoice`.`id` DESC");
        }

        public DataTable findInvoiceByID(string invoiceNo)
        {
            string query = viewQuery + $" AND tbl_invoice.id LIKE '{invoiceNo}%'";

            return GetData(query);
        }

        public DataTable viewSoldItems(string startDate, string endDate, string peopleID)
        {
            string query = $"SELECT `item_id`,tbl_invoice.people_id,RIGHT(CONCAT('00000', `invoice_id`),5) as invoice,tbl_people.name, batch_no,tbl_item.itm_name,`item_cost`,`item_quantity`,note,`item_price`,(`item_discount` * item_quantity) as item_discount,((item_price-item_discount)*item_quantity) AS line_amount,((item_price-item_discount)-item_cost)*item_quantity AS profit,tbl_invoice.created_at FROM tbl_sold_items LEFT JOIN tbl_invoice ON tbl_invoice.id=tbl_sold_items.invoice_id LEFT JOIN tbl_people ON tbl_people.people_id=tbl_invoice.people_id LEFT JOIN tbl_item ON tbl_item.itm_id=tbl_sold_items.item_id WHERE (CONVERT(tbl_invoice.created_at,DATE) BETWEEN '{startDate}' AND '{endDate}')";

            if (peopleID != "0") query += $" AND (tbl_invoice.people_id={peopleID})";
            return GetData(query + " ORDER BY `tbl_invoice`.`id` DESC");
        }

        public bool updateInvoicePayment(int invoiceno)
        {
            query = "UPDATE `tbl_invoice` SET paid_amount=(paid_amount+"+paid_amount+") where id="+invoiceno;
            return ExecuteData(query);
        }

        //Find Invoice details by ID
        public DataTable findInvoice(string invoiceID)
        {
            query = @"SELECT RIGHT(CONCAT('0000', `id`),4) as id,tbl_invoice.people_id,tbl_people.name,reference,`total`,`discount`,`paid_amount` as paid,tbl_invoice.status,tbl_invoice.refund_amount,tbl_invoice.`created_at`, tbl_user.user_name as created_by FROM `tbl_invoice` INNER JOIN tbl_people on tbl_people.people_id = tbl_invoice.people_id LEFT JOIN tbl_user ON tbl_user.user_id = tbl_invoice.created_by WHERE tbl_invoice.id=" + invoiceID;
            return GetData(query);
        }

        //Get all invoice items by Invoice ID
        public DataTable findInvoiceItems(string invoiceID)
        {
            query = "SELECT tbl_sold_items.id, tbl_item.itm_name,tbl_sold_items.item_price,(tbl_sold_items.item_discount*tbl_sold_items.item_quantity) as item_discount,tbl_sold_items.item_quantity,tbl_sold_items.note,return_quantity,item_id, (tbl_sold_items.item_price-tbl_sold_items.item_discount)*tbl_sold_items.item_quantity as item_total, ((item_price-item_discount)-item_cost)*item_quantity AS profit FROM `tbl_sold_items` INNER JOIN tbl_item on tbl_item.itm_id = tbl_sold_items.item_id WHERE invoice_id=" + invoiceID;
            return GetData(query);
        }

        public DataTable findInvoiceItemsForReturn(string invoiceID)
        {
            string query = $"SELECT tbl_sold_items.id, concat(tbl_sold_items.item_quantity,'x ',tbl_item.itm_name) as itm_name,tbl_sold_items.item_price,tbl_sold_items.item_discount,item_cost,indirect_cost,tbl_sold_items.item_quantity,return_quantity,item_id, (tbl_sold_items.item_quantity*tbl_sold_items.item_price) - (tbl_sold_items.item_quantity*tbl_sold_items.item_discount) as item_total, batch_no FROM `tbl_sold_items` INNER JOIN tbl_item on tbl_item.itm_id = tbl_sold_items.item_id WHERE invoice_id={invoiceID}";
            return GetData(query);
        }

       
        public string countTodaySales()
        {
            string dtNow = DateTime.Now.ToString("yyyy-MM-dd");
            DataTable dTable = GetData($"select count(id) from tbl_invoice where CONVERT(tbl_invoice.created_at,DATE)='{dtNow}'");

            if (dTable.Rows.Count <= 0) return "0";
            else return dTable.Rows[0][0].ToString();
        }

        public bool updateRefundAmount(string invoiceID, decimal refund_amount)
        {
            return ExecuteData($"UPDATE tbl_invoice set refund_amount=refund_amount+{refund_amount} where id=" + invoiceID);
        }

        public bool removeInvoice(int invoiceNo)
        {
            return ExecuteData($"DELETE FROM tbl_sold_items WHERE invoice_id={invoiceNo}; DELETE FROM tbl_invoice WHERE id={invoiceNo};");
        }

        public string countOpenSale()
        {
            return GetData("SELECT COUNT(id) FROM tbl_invoice WHERE status LIKE 'Open'").Rows[0][0].ToString();
        }

        public DataTable filterOpenSale()
        {
            return GetData($"{viewQuery} AND tbl_invoice.status LIKE 'Open'");
        }


        //Invoice Edit -------------------------------------------------------------------------
        public bool editSoldItemQuantity(int invoiceID,string itemID, string quantity, string cartID)
        {
            return ExecuteData($"UPDATE tbl_sold_items SET item_quantity=item_quantity+{quantity} WHERE invoice_id={invoiceID} AND tbl_sold_items.id={cartID}; UPDATE tbl_item SET quantity=quantity-{quantity} WHERE itm_id={itemID};");
        }

        public bool updateInvoiceDetails(int invoiceID)
        {
            return ExecuteData($"UPDATE tbl_invoice SET discount={discount}, profit={profit},people_id={peopleID},reference='{reference}',total={total},created_at=CONVERT('{created_at}', DATETIME) WHERE id={invoiceID}");
        }

        //On Reverse (status="Open", stockSign="+", balanceSign="-")
        //On Close (status="Closed", stockSign="-", balanceSign="+")
        public bool updateInvoice(int invoiceID, string peopleID, string status, string balanceSign)
        {
            if (peopleID != "1")
            {
                return ExecuteData($"UPDATE tbl_people SET balance=balance{balanceSign}(SELECT tbl_invoice.total FROM tbl_invoice WHERE tbl_invoice.id={invoiceID}) WHERE tbl_people.people_id={peopleID}; UPDATE tbl_invoice SET status='{status}' WHERE id={invoiceID};");
            }
            else
            {
                return ExecuteData($"UPDATE tbl_invoice SET status='{status}' WHERE id={invoiceID};");
            }
        }

        public bool insertNewSoldItem(int invoiceID,string itemID,decimal quantity=1)
        {
            return ExecuteData($"INSERT INTO tbl_sold_items (`invoice_id`,`item_id`, batch_no,retail_price,`item_cost`, indirect_cost,`item_price`, `item_discount`, `item_quantity`) select {invoiceID},{itemID},'',0,cost,0,sale_price,0,{quantity} from tbl_item where itm_id ={itemID}; UPDATE tbl_item SET quantity=quantity-{quantity} WHERE itm_id={itemID};");
        }

        public bool updateSoldItem(string cartID, string quantity,string discount, string price, string note)
        {
            return ExecuteData($"UPDATE tbl_sold_items SET item_quantity={quantity}, item_discount={discount}, item_price={price}, note='{note}' WHERE id={cartID}");
        }

        public bool removeSoldItem(string cartID, string itemID, string quantity)
        {
            return ExecuteData($"UPDATE tbl_item SET quantity=quantity+{quantity} WHERE itm_id={itemID}; DELETE FROM tbl_sold_items WHERE id={cartID};");
        }
    }
}
