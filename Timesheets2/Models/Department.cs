using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class Department
    {
        public long DepartmentId { get; set; }

        public CustomUser DepartmentHead { get; set; }

        public List<DepartmentsProject> Projects { get; set; }

        public List<CustomUser> Users { get; set; }

       

    }
}
