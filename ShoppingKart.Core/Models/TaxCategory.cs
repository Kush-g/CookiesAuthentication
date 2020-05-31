using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class TaxCategory
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class TierPrice
	{
		public int Id { get; set; }
		public int CustomerRoleId { get; set; }
		public int ProductId { get; set; }
		public int StoreId { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
		public DateTime StartDateTimeUtc { get; set; }
		public DateTime EndDateTimeUtc { get; set; }
	}
	public class Topic
	{
		public int Id { get; set; }
		public string SystemName { get; set; }
		public bool IncludeInSitemap { get; set; }
		public bool IncludeInTopMenu { get; set; }
		public bool IncludeInFooterColumn1 { get; set; }
		public bool IncludeInFooterColumn2 { get; set; }
		public bool IncludeInFooterColumn3 { get; set; }
		public int DisplayOrder { get; set; }
		public bool AccessibleWhenStoreClosed { get; set; }
		public bool IsPasswordProtected { get; set; }
		public string Password { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public bool Published { get; set; }
		public int TopicTemplateId { get; set; }
		public string MetaKeywords { get; set; }
		public string MetaDescription { get; set; }
		public string MetaTitle { get; set; }
		public bool SubjectToAcl { get; set; }
		public bool LimitedToStores { get; set; }
	}
	public class TopicTemplate
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string ViewPath { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class UrlRecord
	{
		public int Id { get; set; }
		public string EntityName { get; set; }
		public string Slug { get; set; }
		public int EntityId { get; set; }
		public bool IsActive { get; set; }
		public int LanguageId { get; set; }
	}
}
