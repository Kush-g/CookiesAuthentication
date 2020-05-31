using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class GiftCard
	{
		public int Id { get; set; }
		public int PurchasedWithOrderItemId { get; set; }
		public int GiftCardTypeId { get; set; }
		public decimal Amount { get; set; }
		public bool IsGiftCardActivated { get; set; }
		public string GiftCardCouponCode { get; set; }
		public string RecipientName { get; set; }
		public string RecipientEmail { get; set; }
		public string SenderName { get; set; }
		public string SenderEmail { get; set; }
		public string Message { get; set; }
		public bool IsRecipientNotified { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class GiftCardUsageHistory
	{
		public int Id { get; set; }
		public int GiftCardId { get; set; }
		public int UsedWithOrderId { get; set; }
		public decimal UsedValue { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
}
