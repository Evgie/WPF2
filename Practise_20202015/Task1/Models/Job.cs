using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask.Models
{
    public class Job
    {
        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<JobHistory> JobHistories { get; set; }
    }
}