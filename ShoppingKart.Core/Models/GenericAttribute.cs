using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class GenericAttribute
	{
		public int Id { get; set; }
		public string KeyGroup { get; set; }
		public string Key { get; set; }
		public string Value { get; set; }
		public int EntityId { get; set; }
		public int StoreId { get; set; }
		public DateTime CreatedOrUpdatedDateUTC { get; set; }
	}
}
