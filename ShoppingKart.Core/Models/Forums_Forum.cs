using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
	public class Forums_Forum
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int ForumGroupId { get; set; }
		public string Description { get; set; }
		public int NumTopics { get; set; }
		public int NumPosts { get; set; }
		public int LastTopicId { get; set; }
		public int LastPostId { get; set; }
		public int LastPostCustomerId { get; set; }
		public DateTime LastPostTime { get; set; }
		public int DisplayOrder { get; set; }
		public DateTime CreatedOnUtc { get; set; }
		public DateTime UpdatedOnUtc { get; set; }
	}
	public class Forums_Group
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DisplayOrder { get; set; }
		public DateTime CreatedOnUtc { get; set; }
		public DateTime UpdatedOnUtc { get; set; }
	}
	public class Forums_PostVote
	{
		public int Id { get; set; }
		public int ForumPostId { get; set; }
		public int CustomerId { get; set; }
		public bool IsUp { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class Forums_PrivateMessage
	{
		public int Id { get; set; }
		public string Subject { get; set; }
		public string Text { get; set; }
		public int FromCustomerId { get; set; }
		public int ToCustomerId { get; set; }
		public int StoreId { get; set; }
		public bool IsRead { get; set; }
		public bool IsDeletedByAuthor { get; set; }
		public bool IsDeletedByRecipient { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class Forums_Subscription
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public Guid SubscriptionGuid { get; set; }
		public int ForumId { get; set; }
		public int TopicId { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
	public class Forums_Topic
	{
		public int Id { get; set; }
		public string Subject { get; set; }
		public int CustomerId { get; set; }
		public int ForumId { get; set; }
		public int TopicTypeId { get; set; }
		public int NumPosts { get; set; }
		public int Views { get; set; }
		public int LastPostId { get; set; }
		public int LastPostCustomerId { get; set; }
		public DateTime LastPostTime { get; set; }
		public DateTime CreatedOnUtc { get; set; }
		public DateTime UpdatedOnUtc { get; set; }
	}
	public class GdprConsent
	{
		public int Id { get; set; }
		public string Message { get; set; }
		public bool IsRequired { get; set; }
		public string RequiredMessage { get; set; }
		public bool DisplayDuringRegistration { get; set; }
		public bool DisplayOnCustomerInfoPage { get; set; }
		public int DisplayOrder { get; set; }
	}
	public class GdprLog
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public int ConsentId { get; set; }
		public string CustomerInfo { get; set; }
		public int RequestTypeId { get; set; }
		public string RequestDetails { get; set; }
		public DateTime CreatedOnUtc { get; set; }
	}
}
