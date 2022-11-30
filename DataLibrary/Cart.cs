using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataLibrary
{
    public class Cart:Database
    {
        public DataTable viewCart(string sale_id="0")
        {
            return GetData($"SELECT cart_id,item_id,tbl_item.itm_name,item_price, item_quantity, item_discount,(item_quantity * item_price)-(item_quantity*item_discount) as total,item_cost as unit_cost,(item_quantity * item_cost) as line_cost, (item_price-item_discount-item_cost)*item_quantity as profit FROM tbl_cart INNER JOIN tbl_item on tbl_cart.item_id = tbl_item.itm_id where tbl_cart.created_by={UserAuth.userid} AND sale_id={sale_id}");
        }

        //Insert Cart Items
        public DataTable insertCart(string itemID, decimal quantity = 1)
        {
            if (quantity != 0)
            {
                DataTable dTable;
                dTable = GetData($"select cart_id from tbl_cart where item_id={itemID} and created_by={UserAuth.userid}");
                if (dTable.Rows.Count == 0)
                {
                    ExecuteData($"INSERT INTO `tbl_cart`(`item_id`,`item_cost`,`item_price`, `item_discount`, `item_quantity`,created_by) select {itemID},cost,sale_price,0,{quantity},{UserAuth.userid} from tbl_item where itm_id ={itemID}");
                }
                else
                {
                    ExecuteData($"UPDATE `tbl_cart` SET `item_quantity`={quantity} WHERE item_id={itemID} and created_by={UserAuth.userid}");
                }
            }
            return viewCart();
        }

        //Update Cart Details
        public bool updateCart(string cartID, decimal quantity, decimal discount, decimal price)
        {
           return  ExecuteData("UPDATE `tbl_cart` SET `item_price`=" + price + ",`item_discount`=" + discount + ",`item_quantity`=" + quantity + " WHERE cart_id=" + cartID);
        }

        public bool updateQty(string cartID, decimal quantity)
        {
            return ExecuteData($"UPDATE tbl_cart SET item_quantity={quantity} WHERE cart_id={cartID}");
        }

        //Delete a cart Item
        public bool deleteFromCart(string cartID)
        {
            return ExecuteData("DELETE FROM `tbl_cart` WHERE cart_id=" + cartID);
        }

        public bool clearCart()
        {
            return ExecuteData($"DELETE FROM tbl_cart where created_by={UserAuth.userid}");
        }
    }
}
