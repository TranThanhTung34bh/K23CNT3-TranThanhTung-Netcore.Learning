using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TranThanhTung_2310900115.Models;

public partial class TranThanhTung2310900115Context : DbContext
{
    public TranThanhTung2310900115Context()
    {
    }

    public TranThanhTung2310900115Context(DbContextOptions<TranThanhTung2310900115Context> options)
        : base(options)
    {
    }

    public virtual DbSet<TttEmployee> TttEmployees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-5N607HA4\\MAY1;Database=TranThanhTung_2310900115;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TttEmployee>(entity =>
        {
            entity.HasKey(e => e.TttEmpId).HasName("PK__TttEmplo__A4D1E4F1100FFF36");

            entity.ToTable("TttEmployee");

            entity.Property(e => e.TttEmpId).ValueGeneratedNever();
            entity.Property(e => e.TttEmpLevel).HasMaxLength(50);
            entity.Property(e => e.TttEmpName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
