using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets2.Models
{
    public class Timesheet
    {
        public long TimesheetId { get; set; }
        public DateTime Date { get; set; }
        public CustomUser User { get; set; }

        [ForeignKey("Project")]
        public Project RelatedProject { get; set; }

        public int HoursWorked { get; set; }
    }
}
