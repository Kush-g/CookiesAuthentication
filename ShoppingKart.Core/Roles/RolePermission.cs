﻿using System;
using ShoppingKart.Core.Permissions;

namespace ShoppingKart.Core.Roles
{
    public class RolePermission
    {
        public Guid RoleId { get; set; }

        public virtual Role Role { get; set; }

        public Guid PermissionId { get; set; }

        public virtual Permission Permission { get; set; }
    }
}