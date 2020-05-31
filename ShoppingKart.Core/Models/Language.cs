using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Language
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string LanguageCulture { get; set; }
		public string UniqueSeoCode { get; set; }
		public string FlagImageFileName { get; set; }
		public bool Rtl { get; set; }
		public bool LimitedToStores { get; set; }
		public int DefaultCurrencyId { get; set; }
		public bool Published { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class LocaleStringResource
	{
		public int Id { get; set; }
		public string ResourceName { get; set; }
		public string ResourceValue { get; set; }
		public int LanguageId { get; set; }
	}
}
