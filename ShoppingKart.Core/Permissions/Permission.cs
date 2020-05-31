using System.Collections.Generic;
using ShoppingKart.Core.Base;
using ShoppingKart.Core.Roles;

namespace ShoppingKart.Core.Permissions
{
    public class Permission : BaseEntity
    {
        public string Name { get; set; }

        public string DisplayName { get; set; }

        public virtual ICollection<RolePermission> RolePermissions { get; set; } = new List<RolePermission>();
    }
}