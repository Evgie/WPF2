using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Task2_1.Models
{
    public partial class DoctorWhoContext : DbContext
    {
        public DoctorWhoContext()
        {
        }

        public DoctorWhoContext(DbContextOptions<DoctorWhoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAuthor> TblAuthor { get; set; }
        public virtual DbSet<TblCompanion> TblCompanion { get; set; }
        public virtual DbSet<TblDoctor> TblDoctor { get; set; }
        public virtual DbSet<TblEnemy> TblEnemy { get; set; }
        public virtual DbSet<TblEpisode> TblEpisode { get; set; }
        public virtual DbSet<TblEpisodeCompanion> TblEpisodeCompanion { get; set; }
        public virtual DbSet<TblEpisodeEnemy> TblEpisodeEnemy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Database=DoctorWho;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblAuthor>(entity =>
            {
                entity.HasKey(e => e.AuthorId);

                entity.ToTable("tblAuthor");

                entity.Property(e => e.AuthorName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblCompanion>(entity =>
            {
                entity.HasKey(e => e.CompanionId);

                entity.ToTable("tblCompanion");

                entity.Property(e => e.CompanionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.WhoPlayed).HasMaxLength(50);
            });

            modelBuilder.Entity<TblDoctor>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("tblDoctor");

                entity.Property(e => e.BirthDate).HasColumnType("date");

                entity.Property(e => e.DoctorName).HasMaxLength(50);

                entity.Property(e => e.FirstEpisodeDate).HasColumnType("date");

                entity.Property(e => e.LastEpisodeDate).HasColumnType("date");
            });

            modelBuilder.Entity<TblEnemy>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("tblEnemy");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.EnemyName).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEpisode>(entity =>
            {
                entity.HasKey(e => e.EpisodeId);

                entity.ToTable("tblEpisode");

                entity.Property(e => e.EpisodeDate).HasColumnType("date");

                entity.Property(e => e.EpisodeType).HasMaxLength(50);

                entity.Property(e => e.Notes).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Author)
                    .WithMany(p => p.TblEpisode)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblEpisode_tblAuthor");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TblEpisode)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblEpisode_tblDoctor");
            });

            modelBuilder.Entity<TblEpisodeCompanion>(entity =>
            {
                entity.HasKey(e => e.EpisodeCompanionId);

                entity.ToTable("tblEpisodeCompanion");

                entity.HasOne(d => d.Companion)
                    .WithMany(p => p.TblEpisodeCompanion)
                    .HasForeignKey(d => d.CompanionId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tblEpisodeCompanion_tblCompanion");
            });

            modelBuilder.Entity<TblEpisodeEnemy>(entity =>
            {
                entity.HasKey(e => e.EpisodeEnemyId)
                    .HasName("PK_tbEpisodeEnemy");

                entity.ToTable("tblEpisodeEnemy");

                entity.HasOne(d => d.Enemy)
                    .WithMany(p => p.TblEpisodeEnemy)
                    .HasForeignKey(d => d.EnemyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_tbEpisodeEnemy_tblEnemy");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
