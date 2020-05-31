using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Warehouse
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string AdminComment { get; set; }
		public int AddressId { get; set; }
	}
}
