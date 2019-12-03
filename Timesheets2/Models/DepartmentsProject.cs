using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class DepartmentsProject
    {
        public long ProjectId { get; set; }

        public long  DepartmentId { get; set; }
        public Project Project { get; set; }

        public Department Department { get; set; }
    }
}
