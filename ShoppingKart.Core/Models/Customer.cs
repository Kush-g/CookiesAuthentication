using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Customer
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
		public string EmailToRevalidate { get; set; }
		public string SystemName { get; set; }
		public int BillingAddress_Id { get; set; }
		public int ShippingAddress_Id { get; set; }
		public Guid CustomerGuid { get; set; }
		public string AdminComment { get; set; }
		public bool IsTaxExempt { get; set; }
		public int AffiliateId { get; set; }
		public int VendorId { get; set; }
		public bool HasShoppingCartItems { get; set; }
		public bool RequireReLogin { get; set; }
		public int FailedLoginAttempts { get; set; }
		public DateTime CannotLoginUntilDateUtc { get; set; }
		public bool Active { get; set; }
		public bool Deleted { get; set; }
		public bool IsSystemAccount { get; set; }
		public string LastIpAddress { get; set; }
		public DateTime CreatedOnUtc { get; set; }
		public DateTime LastLoginDateUtc { get; set; }
		public DateTime LastActivityDateUtc { get; set; }
		public int RegisteredInStoreId { get; set; }
	}
	public class CustomerAttribute
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public bool IsRequired { get; set; }
		public int AttributeControlTypeId { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class CustomerAttributeValue
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int CustomerAttributeId { get; set; }
		public bool IsPreSelected { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class CustomerPassword
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public string Password { get; set; }
		public int PasswordFormatId { get; set; }
		public string PasswordSalt { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class CustomerRole
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SystemName { get; set; }
		public bool FreeShipping { get; set; }
		public bool TaxExempt { get; set; }
		public bool Active { get; set; }
		public bool IsSystemRole { get; set; }
		public bool EnablePasswordLifetime { get; set; }
		public bool OverrideTaxDisplayType { get; set; }
		public int DefaultTaxDisplayTypeId { get; set; }
		public int PurchasedWithProductId { get; set; }
	}
}
