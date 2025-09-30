using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ZADANIE5.Models;

public partial class TestContext : DbContext
{

    public TestContext(DbContextOptions<TestContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Klienci> Klienci { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=Test;Username=postgres;Password=Robot128");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Klienci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Klienci_pkey");

            entity.ToTable("Klienci");

            entity.Property(e => e.Id).UseIdentityAlwaysColumn();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .HasColumnName("PESEL");
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
