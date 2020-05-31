using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class LocalizedProperty
	{
		public int Id { get; set; }
		public string LocaleKeyGroup { get; set; }
		public string LocaleKey { get; set; }
		public string LocaleValue { get; set; }
		public int LanguageId { get; set; }
		public int EntityId { get; set; }
	}
	public class Log
	{
		public int Id { get; set; }
		public string ShortMessage { get; set; }
		public string IpAddress { get; set; }
		public int CustomerId { get; set; }
		public int LogLevelId { get; set; }
		public string FullMessage { get; set; }
		public string PageUrl { get; set; }
		public string ReferrerUrl { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
}
