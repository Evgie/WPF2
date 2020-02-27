using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeTask.Models
{
    public class JobHistory
    {
        public int EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Job Job { get; set; }
        public Department Department { get; set; }
        public Employee Employee { get; set; }
    }
}