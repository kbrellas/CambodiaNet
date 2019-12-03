using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class CustomUser: IdentityUser
    {
        public CustomUser() : base() { }

        public string Name { get; set; }
        public string Surname { get; set; }

        public List<UserRole> Roles { get; set; }

        public Department Department;

        public float CostPerManHour { get; set; }
        public CustomUser Manager { get; set; }


    }
}
