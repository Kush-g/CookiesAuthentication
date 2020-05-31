using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Store
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Url { get; set; }
		public string Hosts { get; set; }
		public string CompanyName { get; set; }
		public string CompanyAddress { get; set; }
		public string CompanyPhoneNumber { get; set; }
		public string CompanyVat { get; set; }
		public bool SslEnabled { get; set; }
		public int DefaultLanguageId { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class StoreMapping
	{
		public int Id { get; set; }
		public string EntityName { get; set; }
		public int StoreId { get; set; }
		public int EntityId { get; set; }
	}
}
