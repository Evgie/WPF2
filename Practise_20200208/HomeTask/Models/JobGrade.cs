using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HomeTask.Models
{
    public class JobGrade
    {
        [Key]
        [StringLength(2)]
        public string GradeLevel { get; set; }
        public decimal LowestSal { get; set; }
        public decimal HighestSal { get; set; }
    }
}
