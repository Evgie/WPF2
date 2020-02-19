using System;
using System.Collections.Generic;

namespace Task2.Models
{
    public partial class JobHistory
    {
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string JobId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Jobs Job { get; set; }
    }
}
