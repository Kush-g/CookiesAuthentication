using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Order
	{
		public int Id { get; set; }
		public string CustomOrderNumber { get; set; }
		public int BillingAddressId { get; set; }
		public int CustomerId { get; set; }
		public int PickupAddressId { get; set; }
		public int ShippingAddressId { get; set; }
		public Guid OrderGuid { get; set; }
		public int StoreId { get; set; }
		public bool PickupInStore { get; set; }
		public int OrderStatusId { get; set; }
		public int ShippingStatusId { get; set; }
		public int PaymentStatusId { get; set; }
		public string PaymentMethodSystemName { get; set; }
		public string CustomerCurrencyCode { get; set; }
		public decimal CurrencyRate { get; set; }
		public int CustomerTaxDisplayTypeId { get; set; }
		public string VatNumber { get; set; }
		public decimal OrderSubtotalInclTax { get; set; }
		public decimal OrderSubtotalExclTax { get; set; }
		public decimal OrderSubTotalDiscountInclTax { get; set; }
		public decimal OrderSubTotalDiscountExclTax { get; set; }
		public decimal OrderShippingInclTax { get; set; }
		public decimal OrderShippingExclTax { get; set; }
		public decimal PaymentMethodAdditionalFeeInclTax { get; set; }
		public decimal PaymentMethodAdditionalFeeExclTax { get; set; }
		public string TaxRates { get; set; }
		public decimal OrderTax { get; set; }
		public decimal OrderDiscount { get; set; }
		public decimal OrderTotal { get; set; }
		public decimal RefundedAmount { get; set; }
		public int RewardPointsHistoryEntryId { get; set; }
		public string CheckoutAttributeDescription { get; set; }
		public string CheckoutAttributesXml { get; set; }
		public int CustomerLanguageId { get; set; }
		public int AffiliateId { get; set; }
		public string CustomerIp { get; set; }
		public bool AllowStoringCreditCardNumber { get; set; }
		public string CardType { get; set; }
		public string CardName { get; set; }
		public string CardNumber { get; set; }
		public string MaskedCreditCardNumber { get; set; }
		public string CardCvv2 { get; set; }
		public string CardExpirationMonth { get; set; }
		public string CardExpirationYear { get; set; }
		public string AuthorizationTransactionId { get; set; }
		public string AuthorizationTransactionCode { get; set; }
		public string AuthorizationTransactionResult { get; set; }
		public string CaptureTransactionId { get; set; }
		public string CaptureTransactionResult { get; set; }
		public string SubscriptionTransactionId { get; set; }
		public DateTime PaidDateUtc { get; set; }
		public string ShippingMethod { get; set; }
		public string ShippingRateComputationMethodSystemName { get; set; }
		public string CustomValuesXml { get; set; }
		public bool Deleted { get; set; }
		public DateTime CreatedOnUtc { get; set; }
		public int RedeemedRewardPointsEntryId { get; set; }
	}
	public class OrderItem
	{
		public int Id { get; set; }
		public int OrderId { get; set; }
		public int ProductId { get; set; }
		public Guid OrderItemGuid { get; set; }
		public int Quantity { get; set; }
		public decimal UnitPriceInclTax { get; set; }
		public decimal UnitPriceExclTax { get; set; }
		public decimal PriceInclTax { get; set; }
		public decimal PriceExclTax { get; set; }
		public decimal DiscountAmountInclTax { get; set; }
		public decimal DiscountAmountExclTax { get; set; }
		public decimal OriginalProductCost { get; set; }
		public string AttributeDescription { get; set; }
		public string AttributesXml { get; set; }
		public int DownloadCount { get; set; }
		public bool IsDownloadActivated { get; set; }
		public int LicenseDownloadId { get; set; }
		public decimal ItemWeight { get; set; }
		public DateTime RentalStartDateUtc { get; set; }
		public DateTime RentalEndDateUtc { get; set; }
	}
	public class OrderNote
	{
		public int Id { get; set; }
		public string Note { get; set; }
		public int OrderId { get; set; }
		public int DownloadId { get; set; }
		public bool DisplayToCustomer { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class PermissionRecord
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string SystemName { get; set; }
		public string Category { get; set; }
	}

}
