using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class ReturnRequest
    {
        public int Id { get; set; }
        public string ReasonForReturn { get; set; }
        public string RequestedAction { get; set; }
        public int CustomerId { get; set; }
        public string CustomNumber { get; set; }
        public int StoreId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public string CustomerComments { get; set; }
        public int UploadedFileId { get; set; }
        public string StaffNotes { get; set; }
        public int ReturnRequestStatusId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
    public class ReturnRequestAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class ReturnRequestReason
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class ReviewType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool VisibleToAllCustomers { get; set; }
        public bool IsRequired { get; set; }
    }
    public class RewardPointsHistory
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
        public int Points { get; set; }
        public int PointsBalance { get; set; }
        public decimal UsedAmount { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime EndDateUtc { get; set; }
        public int ValidPoints { get; set; }
    }

    }
