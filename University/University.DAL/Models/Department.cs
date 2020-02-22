using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.DAL.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        [StringLength(30)]
        public string DepartmentName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
