using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class MeasureDimension
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SystemKeyword { get; set; }
		public decimal Ratio { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class MeasureWeight
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SystemKeyword { get; set; }
		public decimal Ratio { get; set; }
		public int DisplayOrder { get; set; }
	}
}
