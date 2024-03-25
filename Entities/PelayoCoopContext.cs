using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mvczeke.Entities;

public partial class PelayoCoopContext : DbContext
{
    public PelayoCoopContext()
    {
    }

    public PelayoCoopContext(DbContextOptions<PelayoCoopContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClientInfo> ClientInfos { get; set; }

    public virtual DbSet<Usertype> Usertypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=PelayoCoop;TrustServerCertificate=true;Trusted_Connection=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ClientInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__clientIn__3213E83FAC0B727D");

            entity.ToTable("clientInfo");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Birthdate).HasColumnType("date");
            entity.Property(e => e.Civilstatus)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NameofFather)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NameofMother)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Occupation)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usertype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__usertype__3213E83F6AA5E79E");

            entity.ToTable("usertype");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
