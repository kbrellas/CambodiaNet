using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class Project
    {
        public long ProjectId { get; set; }

        public string ProjectName { get; set; }
        public List<DepartmentsProject> RelatedDepartments { get; set; }

        public Department ProjectOwner { get; set; }

        public List<Timesheet> Timesheets { get; set; }

        
    }
}
