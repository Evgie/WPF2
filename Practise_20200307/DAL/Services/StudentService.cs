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

        public StudentService()
        {
            this.context = new StudentsDbContext();
        }
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>(this.context.Students.Include(s => s.Address).Include(s =>s.Books));
        }

        public void SaveStudents(IEnumerable<Student> students)
        {
            this.context.SaveChanges();
        }

        public void RemoveStudent(Student student)
        {
            this.context.Remove(student);
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