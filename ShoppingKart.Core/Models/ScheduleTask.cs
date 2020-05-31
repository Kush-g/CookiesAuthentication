using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class ScheduleTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Seconds { get; set; }
        public bool Enabled { get; set; }
        public bool StopOnError { get; set; }
        public DateTime LastStartUtc { get; set; }
        public DateTime LastEndUtc { get; set; }
        public DateTime LastSuccessUtc { get; set; }
    }
    public class SearchTerm
    {
        public int Id { get; set; }
        public string Keyword { get; set; }
        public int StoreId { get; set; }
        public int Count { get; set; }
    }
    public class Setting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int StoreId { get; set; }
    }
    public class Shipment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string TrackingNumber { get; set; }
        public decimal TotalWeight { get; set; }
        public DateTime ShippedDateUtc { get; set; }
        public DateTime DeliveryDateUtc { get; set; }
        public string AdminComment { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
    public class ShipmentItem
    {
        public int Id { get; set; }
        public int ShipmentId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public int WarehouseId { get; set; }
    }
    public class ShippingMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class ShippingMethodRestrictions
    {
        public int ShippingMethod_Id { get; set; }
        public int Country_Id { get; set; }
    }
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int StoreId { get; set; }
        public int ShoppingCartTypeId { get; set; }
        public string AttributesXml { get; set; }
        public decimal CustomerEnteredPrice { get; set; }
        public int Quantity { get; set; }
        public DateTime RentalStartDateUtc { get; set; }
        public DateTime RentalEndDateUtc { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }
    }
  
}

