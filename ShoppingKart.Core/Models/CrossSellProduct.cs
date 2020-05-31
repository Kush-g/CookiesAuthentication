using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class CrossSellProduct
	{
		public int Id { get; set; }
		public int ProductId1 { get; set; }
		public int ProductId2 { get; set; }
	}
}
