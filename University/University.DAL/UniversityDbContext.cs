using Microsoft.EntityFrameworkCore;
using System;
using University.DAL.Models;

namespace University.DAL
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Database = UniversityDB; Trusted_Connection = True");
        }
    }
}
