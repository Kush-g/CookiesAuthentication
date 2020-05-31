using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class BackInStockSubscription
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int ProductId { get; set; }
		public int StoreId { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class BlogComment
	{
		public int Id { get; set; }
		public int StoreId { get; set; }
		public int CustomerId { get; set; }
		public int BlogPostId { get; set; }
		public string CommentText { get; set; }
		public bool IsApproved { get; set; }
		public DateTime CreatedOnUtc { get; set; }

	}
	public class BlogPost
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public string MetaKeywords { get; set; }
		public string MetaTitle { get; set; }
		public int LanguageId { get; set; }
		public bool IncludeInSitemap { get; set; }
		public string BodyOverview { get; set; }
		public bool AllowComments { get; set; }
		public string Tags { get; set; }
		public DateTime StartDateUtc { get; set; }
		public DateTime EndDateUtc { get; set; }
		public string MetaDescription { get; set; }
		public bool LimitedToStores { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
}
