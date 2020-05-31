using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingKart.Core.Models
{
    public class AclRecord
    {
        public int Id { get; set; }
        public string EntityName { get; set; }
        public int CustomerRoleId { get; set; }
        public int EntityId { get; set; }
    }
    public class ActivityLog
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public string IpAddress { get; set; }
        public string EntityName { get; set; }
        public int ActivityLogTypeId { get; set; }
        public int CustomerId { get; set; }
        public int EntityId { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
    public class ActivityLogType
    {
        public int Id { get; set; }
        public string SystemKeyword { get; set; }
        public string Name { get; set; }
        public bool Enabled { get; set; }
    }
    
}
