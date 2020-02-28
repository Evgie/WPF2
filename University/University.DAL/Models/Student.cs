using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace University.DAL.Models
{
    public class Student
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }

        public virtual Course Course { get; set; }

        public override string ToString()
        {
            string result;
            if (this.Course is null)
                result = $"Id: {this.Id}\tFirst Name: {this.FirstName}\tLast Name: {this.LastName}";
            else
                result = $"Id: {this.Id}\tFirst Name: {this.FirstName}\tLast Name: {this.LastName}\n\t\tCouseId: {this.Course.CourseId}\tCourse Name: {this.Course.CourseName}";
            return result;
        }
    }
}