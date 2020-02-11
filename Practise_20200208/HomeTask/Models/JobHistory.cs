using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeTask.Models
{
    public class JobHistory
    {
        public int EmployeeId { get; set; }
        [Key]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobId { get; set; }
        public Job Job { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
