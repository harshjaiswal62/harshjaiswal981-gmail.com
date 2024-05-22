using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models;

public partial class MnjwebFormContext : DbContext
{
    public MnjwebFormContext()
    {
    }

    public MnjwebFormContext(DbContextOptions<MnjwebFormContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.City)
                .HasMaxLength(15)
                .IsFixedLength();
            entity.Property(e => e.EmailId)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("EmailID");
            entity.Property(e => e.FatherName)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FirstName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.HouseNo).HasColumnName("HouseNO");
            entity.Property(e => e.InstantMessagingSystemId)
                .HasMaxLength(15)
                .IsFixedLength()
                .HasColumnName("InstantMessagingSystemID");
            entity.Property(e => e.LastName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Nationality)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PanCardNumber)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Sex)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.State)
                .HasMaxLength(15)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
