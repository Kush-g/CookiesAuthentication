using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class SpecificationAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class SpecificationAttributeOption
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ColorSquaresRgb { get; set; }
        public int SpecificationAttributeId { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class StateProvince
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public int CountryId { get; set; }
        public bool Published { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class StockQuantityHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int QuantityAdjustment { get; set; }
        public int StockQuantity { get; set; }
        public string Message { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int CombinationId { get; set; }
        public int WarehouseId { get; set; }
    }
}
