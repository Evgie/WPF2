using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public string JobId { get; set; }
        public Job Job { get; set; }
        public decimal Salary { get; set; }
        public decimal ComissionPct { get; set; }
        public int  ManagerId { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
