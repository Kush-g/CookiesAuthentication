using System;
using Microsoft.AspNetCore.Identity;
using ShoppingKart.Core.Roles;

namespace ShoppingKart.Core.Users
{
    public class UserRole : IdentityUserRole<Guid>
    {
        public virtual User User { get; set; }

        public virtual Role Role { get; set; }
    }
}
