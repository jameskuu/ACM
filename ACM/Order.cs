using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        /// <summary>
        /// Validates the order infomation
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        /// <summary>
        /// Retrieve one order
        /// </summary>
        /// <returns></returns>
        public Order Retrieve(int orderId)
        {
            return new Order();
        }


        /// <summary>
        /// Retrieve all orders
        /// </summary>
        /// <returns></returns>
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        /// <summary>
        /// Saves the current Order
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }

    }
}
