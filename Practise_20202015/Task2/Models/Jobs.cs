using System;
using System.Collections.Generic;

namespace Task2.Models
{
    public partial class Jobs
    {
        public Jobs()
        {
            Employees = new HashSet<Employees>();
            JobHistory = new HashSet<JobHistory>();
        }

        public string JobId { get; set; }
        public string JobTitle { get; set; }
        public decimal MinSalary { get; set; }
        public decimal? MaxSalary { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
        public virtual ICollection<JobHistory> JobHistory { get; set; }
    }
}
