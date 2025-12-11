using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.DTO
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public DateTime orderDate { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public List<ProductDto> ProductList { get; set; }
    }
}
