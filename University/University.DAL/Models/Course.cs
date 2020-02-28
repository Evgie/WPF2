using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.DAL.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [StringLength(30)]
        public string CourseName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            string result = $"CouseId: {this.CourseId}\tCourse Name: {this.CourseName}";
            return result;
        }
    }
}