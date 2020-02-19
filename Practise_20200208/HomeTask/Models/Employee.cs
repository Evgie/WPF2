using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HomeTask.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(25)]
        public string LastName { get; set; }
        [StringLength(25)]
        public string EMail { get; set; }
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        [StringLength(10)]
        public string JobId { get; set; }
        public Job Job { get; set; }
        public decimal Salary { get; set; }
        public decimal ComissionPct { get; set; }
        public int  ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public IReadOnlyCollection<JobHistory> JobHistories { get; set; }
    }
}
