using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class TimesheetProject
    {
        public long TimesheetId { get; set; }

        public long ProjectId { get; set; }

        public Timesheet Timesheet { get; set; }

        public Project Project { get; set; }
    }
}
