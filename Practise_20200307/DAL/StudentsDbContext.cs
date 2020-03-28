using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class StudentsDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Database = StudentsDB; Trusted_Connection = True");
        }
    }
}
