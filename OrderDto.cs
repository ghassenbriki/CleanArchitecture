using System;
using System.Collections.Generic;

public class OrderDto
{
	public int OrderId { get; set; }
	public DateTime orderDate { get; set; }
	public int CustomerID { get; set; }
	public string CustomerName { get; set; }
	public List<ProductDto> ProductList {get;set;}
	
}
