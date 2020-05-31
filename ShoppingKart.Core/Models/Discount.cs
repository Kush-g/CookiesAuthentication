using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Discount
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string CouponCode { get; set; }
		public string AdminComment { get; set; }
		public int DiscountTypeId { get; set; }
		public bool UsePercentage { get; set; }
		public decimal DiscountPercentage { get; set; }
		public decimal DiscountAmount { get; set; }
		public decimal MaximumDiscountAmount { get; set; }
		public DateTime StartDateUtc { get; set; }
		public DateTime EndDateUtc { get; set; }
		public bool RequiresCouponCode { get; set; }
		public bool IsCumulative { get; set; }
		public int DiscountLimitationId { get; set; }
		public int LimitationTimes { get; set; }
		public int MaximumDiscountedQuantity { get; set; }
		public bool AppliedToSubCategories { get; set; }
	}
	public class Discount_AppliedToCategories
	{
		public int Discount_Id { get; set; }
		public int Category_Id { get; set; }
	}
	public class Discount_AppliedToManufacturers
	{
		public int Discount_Id { get; set; }
		public int Manufacturer_Id { get; set; }
	}
	public class Discount_AppliedToProducts
	{
		public int Discount_Id { get; set; }
		public int Product_Id { get; set; }
	}
	public class DiscountRequirement
	{
		public int Id { get; set; }
		public int DiscountId { get; set; }
		public int ParentId { get; set; }
		public string DiscountRequirementRuleSystemName { get; set; }
		public int InteractionTypeId { get; set; }
		public bool IsGroup { get; set; }
	}
	public class DiscountUsageHistory
	{
		public int Id { get; set; }
		public int DiscountId { get; set; }
		public int OrderId { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}

}
