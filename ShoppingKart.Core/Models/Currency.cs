﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Currency
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string CurrencyCode { get; set; }
		public string DisplayLocale { get; set; }
		public string CustomFormatting { get; set; }
		public decimal Rate { get; set; }
		public bool LimitedToStores { get; set; }
		public bool Published { get; set; }
		public int DisplayOrder { get; set; }
		public DateTime CreatedOnUtc { get; set; }
		public DateTime UpdatedOnUtc { get; set; }
		public int RoundingTypeId { get; set; }
	}
}
