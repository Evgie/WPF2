using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.DAL.Models;

namespace University.DAL.Tools
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private UniversityDbContext context;

        public StudentRepository(UniversityDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Student> GetStudents()
        {
            return this.context.Students.ToList();
        }

        public Student GetStudentByID(int id)
        {
            return this.context.Students.Find(id);
        }

        public void InsertStudent(Student student)
        {
            context.Students.Add(student);
        }

        public void DeleteStudent(int studentID)
        {
            Student student = this.context.Students.Find(studentID);
            this.context.Students.Remove(student);
        }

        public void UpdateStudent(Student student)
        {
            this.context.Students.Remove(student);
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if(disposing)
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
