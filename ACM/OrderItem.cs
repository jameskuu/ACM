using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public OrderItem()
        {

        }

        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        
        /// <summary>
        /// Validate the order item data
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (PurchasePrice == null) isValid = false;
            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;

            return isValid; 
        }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int orderId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all orders
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current order item
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
