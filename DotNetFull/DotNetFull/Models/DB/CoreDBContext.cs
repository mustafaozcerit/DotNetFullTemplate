using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetFull.Models.DB
{
    public partial class CoreDBContext : DbContext
    {
        public CoreDBContext()
        {
        }

        public CoreDBContext(DbContextOptions<CoreDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-F9MI7J0\\SQLEXPRESS;Database=CoreDB;User=sa;Password=Root64;Trusted_Connection=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.İd);

                entity.Property(e => e.Ad).HasMaxLength(50);

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Soyad).HasMaxLength(50);
            });
        }
    }
}
