﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int StateProvinceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string ZipPostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string CustomAttributes { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }

    public class AddressAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int AttributeControlTypeId { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class AddressAttributeValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AddressAttributeId { get; set; }
        public bool IsPreSelected { get; set; }
        public int DisplayOrder { get; set; }
    }
    public class CustomerAddresses
    {
        public int Address_Id { get; set; }
        public int Customer_Id { get; set; }
    }

}
