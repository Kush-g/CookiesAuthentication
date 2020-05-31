using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaTitle { get; set; }
        public string PageSizeOptions { get; set; }
        public string Description { get; set; }
        public int PictureId { get; set; }
        public int AddressId { get; set; }
        public string AdminComment { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public int DisplayOrder { get; set; }
        public string MetaDescription { get; set; }
        public int PageSize { get; set; }
        public bool AllowCustomersToSelectPageSize { get; set; }
    }
    public class VendorAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int DisplayOrder { get; set; }
        public int AttributeControlTypeId { get; set; }
    }
    public class VendorAttributeValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("VendorAttributeId")]
        public int VendorAttributeId { get; set; }
        public VendorAttribute VendorAttribute { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class VendorNote
    {
        public int Id { get; set; }
        public string Note { get; set; }
        [ForeignKey("VendorId")]
        public int VendorId { get; set; }
        public Vendor vendor { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }

}
