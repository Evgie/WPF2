using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Models
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieDirection> MovieDirections { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Database=MovieDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //
            //Movie.
            //
            modelBuilder.Entity<Movie>()
                .Property(m => m.MovieTitle)
                .HasMaxLength(50);
            modelBuilder.Entity<Movie>()
                .Property(m => m.MovieLang)
                .HasMaxLength(50);
            modelBuilder.Entity<Movie>()
                .Property(m => m.MovieRelCountry)
                .HasMaxLength(5);

            modelBuilder.Entity<Movie>()
                .HasMany<MovieGenre>(m => m.MovieGenres)
                .WithOne(mg => mg.Movie);
            modelBuilder.Entity<Movie>()
               .HasMany<Rating>(m => m.Ratings)
               .WithOne(r => r.Movie);
            modelBuilder.Entity<Movie>()
               .HasMany<MovieCast>(m => m.MovieCasts)
               .WithOne(mc => mc.Movie);
            modelBuilder.Entity<Movie>()
               .HasMany<MovieDirection>(m => m.MovieDirections)
               .WithOne(md => md.Movie);

            //
            //Genre.
            //
            modelBuilder.Entity<Genre>()
                .Property(g => g.GenreTitle)
                .HasMaxLength(20);
            modelBuilder.Entity<Genre>()
               .HasMany<MovieGenre>(g => g.MovieGenres)
               .WithOne(mG => mG.Genre);

            //
            //Reviewer.
            //
            modelBuilder.Entity<Reviewer>()
               .Property(r => r.ReviewerName)
               .HasMaxLength(30);
            modelBuilder.Entity<Reviewer>()
               .HasMany<Rating>(r => r.Ratings)
               .WithOne(rat => rat.Reviewer);

            //
            //MovieCast.
            //
            modelBuilder.Entity<MovieCast>()
              .Property(mc => mc.Role)
              .HasMaxLength(30);

            //
            //Director.
            //
            modelBuilder.Entity<Director>()
               .Property(d => d.DirectorFName)
               .HasMaxLength(20);
            modelBuilder.Entity<Director>()
               .Property(d => d.DirectorLName)
               .HasMaxLength(20);
            modelBuilder.Entity<Director>()
               .HasMany<MovieDirection>(d => d.MovieDirections)
               .WithOne(md => md.Director);

            //
            //Actor.
            //
            modelBuilder.Entity<Actor>()
               .Property(a => a.ActorFName)
               .HasMaxLength(20);
            modelBuilder.Entity<Actor>()
               .Property(a => a.ActorLName)
               .HasMaxLength(20);
            modelBuilder.Entity<Actor>()
               .Property(a => a.ActorGender)
               .HasMaxLength(1);
            modelBuilder.Entity<Actor>()
               .HasMany<MovieCast>(a => a.MovieCasts)
               .WithOne(mc => mc.Actor);
        }
    }
}
