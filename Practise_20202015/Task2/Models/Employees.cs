using System;
using System.Collections.Generic;

namespace Task2.Models
{
    public partial class Employees
    {
        public Employees()
        {
            JobHistory = new HashSet<JobHistory>();
        }

        public int EmplyeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string JobId { get; set; }
        public decimal Salary { get; set; }
        public int? CommissionPct { get; set; }
        public int? ManagerId { get; set; }
        public int DepartmentId { get; set; }

        public virtual Departments Department { get; set; }
        public virtual Jobs Job { get; set; }
        public virtual ICollection<JobHistory> JobHistory { get; set; }
    }
}
