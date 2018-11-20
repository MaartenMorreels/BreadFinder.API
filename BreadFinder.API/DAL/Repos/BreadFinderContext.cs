using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BreadFinder.API.DAL.ENT;

namespace BreadFinder.API.DAL.Repos
{
    public partial class BreadFinderContext : DbContext
    {
        public BreadFinderContext()
        {
        }

        public BreadFinderContext(DbContextOptions<BreadFinderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Automaat> Automaat { get; set; }
        public virtual DbSet<Eigenaar> Eigenaar { get; set; }
        public virtual DbSet<Gebruiker> Gebruiker { get; set; }
        public virtual DbSet<Plaats> Plaats { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BreadFinder;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Automaat>(entity =>
            {
                entity.Property(e => e.HuisNr)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Straat)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Eigenaar)
                    .WithMany(p => p.Automaat)
                    .HasForeignKey(d => d.EigenaarId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Automaten_Eigenaars");

                entity.HasOne(d => d.Plaats)
                    .WithMany(p => p.Automaat)
                    .HasForeignKey(d => d.PlaatsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Automaat_Plaats");
            });

            modelBuilder.Entity<Eigenaar>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.HuisNr).HasMaxLength(5);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Straat).HasMaxLength(50);

                entity.Property(e => e.Telefoon).HasMaxLength(20);

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.HasOne(d => d.Plaats)
                    .WithMany(p => p.Eigenaar)
                    .HasForeignKey(d => d.PlaatsId)
                    .HasConstraintName("FK_Eigenaar_Plaats");
            });

            modelBuilder.Entity<Gebruiker>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FamilieNaam).HasMaxLength(50);

                entity.Property(e => e.HuisNr).HasMaxLength(5);

                entity.Property(e => e.Straat).HasMaxLength(50);

                entity.Property(e => e.VoorNaam).HasMaxLength(50);

                entity.HasOne(d => d.Plaats)
                    .WithMany(p => p.Gebruiker)
                    .HasForeignKey(d => d.PlaatsId)
                    .HasConstraintName("FK_Gebruiker_Plaats");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.Gebruiker)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Gebruikers_Rollen");
            });

            modelBuilder.Entity<Plaats>(entity =>
            {
                entity.Property(e => e.PlaatsNaam)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Provincie).HasMaxLength(50);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.Property(e => e.Rol1)
                    .IsRequired()
                    .HasColumnName("Rol")
                    .HasMaxLength(50);
            });
        }
    }
}
