using Microsoft.EntityFrameworkCore;
using System;
using ToyStore.DAL.Model;

namespace ToyStore.DAL
{
    public class ToyStoreDbContext : DbContext
    {
        public DbSet<Toy> Toys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Database = ToyStore; Trusted_Connection = True");
        }
    }
}