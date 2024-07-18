using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1;

public partial class AirportdbContext : DbContext
{
    public AirportdbContext()
    {
    }

    public AirportdbContext(DbContextOptions<AirportdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Garage> Garages { get; set; }

    public virtual DbSet<Plane> Planes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=airportdb;Integrated Security = SSPI;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Garage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Garages__3214EC077D7DF32B");
        });

        modelBuilder.Entity<Plane>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Planes__3214EC0798195540");

            entity.HasOne(d => d.Garage).WithMany(p => p.Planes)
                .HasForeignKey(d => d.GarageId)
                .HasConstraintName("FK_GarageId");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
