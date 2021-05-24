using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderRepository
    {
        /// <summary>
        ///  Retrieve one order
        /// </summary>
        public Order Retrieve(int orderId)
        {
            // Create the instance of the Order class
            // Pass in the requested Id
            var order = new Order(orderId);

            // Code that retrievers the defined order

            // Templorary hard-code  values to return
            // a populated order

            if (orderId == 10)
            {
                // Use current year in hard-coded date
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                 new TimeSpan(7, 0, 0));
            }

            return order;
        }
        /// <summary>
        /// Saves the current order
        /// </summary>
        /// <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }

    }
}
