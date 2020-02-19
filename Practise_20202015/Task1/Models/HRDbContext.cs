
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask.Models
{
    public class HRContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobGrade> JobGrades { get; set; }
        public DbSet<JobHistory> JobHistories { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Database=HRDbAPI;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>()
            //    .Property(s => s.EmployeeId)
            //    .IsRequired();
            modelBuilder.Entity<Employee>()
                .HasOne<Job>(emp => emp.Job)
                .WithMany(job => job.Employees);

            modelBuilder.Entity<Job>()
                .HasMany<JobHistory>(job => job.JobHistories)
                .WithOne(jobH => jobH.Job);

            modelBuilder.Entity<Employee>()
                .HasOne<Department>(emp => emp.Department)
                .WithMany(dep => dep.Employees);

            //modelBuilder.Entity<Employee>()
            //    .HasOne<JobHistory>(emp => emp.JobHistory)
            //    .WithMany(jobH => jobH.Employees)
            //    .HasForeignKey(emp => emp.EmployeeId);

            modelBuilder.Entity<JobHistory>()
                .HasKey(jobH => new { jobH.EmployeeId, jobH.StartDate });

            modelBuilder.Entity<JobHistory>()
                .HasOne<Department>(jobH => jobH.Department)
                .WithMany(dep => dep.JobHistories);

            modelBuilder.Entity<JobHistory>()
                .HasOne<Employee>(jobHistory => jobHistory.Employee)
                .WithMany(employee => employee.JobHistories);

            modelBuilder.Entity<Department>()
                .HasOne<Location>(dep => dep.Location)
                .WithMany(loc => loc.Departments);

            modelBuilder.Entity<Location>()
                .HasOne<Country>(loc => loc.Country)
                .WithMany(cnt => cnt.Locations);

            modelBuilder.Entity<Country>()
                .HasOne<Region>(cnt => cnt.Region)
                .WithMany(reg => reg.Countries);

            modelBuilder.Entity<JobGrade>()
                .HasKey(jobG => jobG.GradeLevel);
        }
    }
}