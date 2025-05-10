using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace RecyclingApp.Models.DataLayer;

public partial class RecycleContext : DbContext
{
    public RecycleContext()
    {
    }

    public RecycleContext(DbContextOptions<RecycleContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bin> Bins { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Material> Materials { get; set; }

    public virtual DbSet<Trailer> Trailers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["RecycleDB"].ConnectionString);

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bin>(entity =>
        {
            entity.Property(e => e.BinId).ValueGeneratedNever();
            entity.Property(e => e.NetWeight).HasComputedColumnSql("([gross_weight]-[tare_weight])", true);

            entity.HasOne(d => d.Material).WithMany(p => p.Bins).HasConstraintName("FK_Bins_Materials");

            entity.HasOne(d => d.Trailer).WithMany(p => p.Bins).HasConstraintName("FK_Bins_Trailers");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.Property(e => e.EmployeeId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Material>(entity =>
        {
            entity.Property(e => e.MaterialId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Trailer>(entity =>
        {
            entity.Property(e => e.TrailerId).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
