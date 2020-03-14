using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Services
{
    public class StudentService : IStudentService, IDisposable
    {
        private StudentsDbContext context;

        private List<Student> studentsRepository_ = new List<Student>
        {
            new Student {FirstName = "John Snow", Email = "John.Snow@soaf.com"},
            new Student {FirstName = "Tyrion Lannister", Email = "Tyrion.Lannister@soaf.com"},
            new Student {FirstName = "Arya Stark", Email = "Arya.Stark@soaf.com"},
            new Student {FirstName = "Victarion.Greyjoy", Email = "Victarion.Greyjoy@soaf.com"},
        };

        public StudentService()
        {

        }
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>(this.context.Students.Include(s => s.Address));
        }

        public void SaveStudents(IEnumerable<Student> students)
        {
            this.context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                };
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}