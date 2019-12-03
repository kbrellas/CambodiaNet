using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Timesheets2.Models
{
    public class CustomRole: IdentityRole
    {
        public CustomRole() : base() { }

        public List<UserRole> Users { get; set; }
    }
}