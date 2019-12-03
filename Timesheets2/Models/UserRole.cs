using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class UserRole
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public CustomUser User { get; set; }
        public CustomRole Role { get; set; }

    }
}
