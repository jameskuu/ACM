using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double CurrentPrice { get; set; }
        public int MyProperty { get; set; }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (string.IsNullOrWhiteSpace(Description)) isValid = false;
            if (double.IsNaN(CurrentPrice)) isValid = false;
           
            return isValid;
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }
    }
}
