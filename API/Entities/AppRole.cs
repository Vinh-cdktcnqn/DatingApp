using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public string Description { get; set; }

        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}