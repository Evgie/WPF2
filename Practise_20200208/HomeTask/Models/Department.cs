using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int ManagerId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public ICollection<JobHistory> JobHistories { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
