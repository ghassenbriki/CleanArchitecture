using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime orderDate { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public Customer Customer { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
