using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeTask.Models
{
    public class Job
    {
        [StringLength(10)]
        public string JobId { get; set; }
        [StringLength(35)]
        public string JobTitle { get; set; }
        public decimal  MinSalary { get; set; }
        public decimal MaxSalary { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public ICollection<JobHistory> JobHistories { get; set; }
    }
}
