using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Affiliate
	{
		public int Id { get; set; }
		public int AddressId { get; set; }
		public string AdminComment { get; set; }
		public string FriendlyUrlName { get; set; }
		public bool Deleted { get; set; }
		public bool Active { get; set; }
	}
}
