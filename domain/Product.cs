using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.domain

{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public  string ProductCategory { get; set; }
        public decimal? Price { get; set; }
        public int? CategoryID { get; set; }

        public Category? Category { get; set; }
        public string? CategoryName { get; set; }
    }
}
