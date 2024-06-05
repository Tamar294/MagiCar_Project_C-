using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class MagiCarContext : DbContext
{
    public MagiCarContext(DbContextOptions<MagiCarContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarsRental> CarsRentals { get; set; }

    public virtual DbSet<PayDetail> PayDetails { get; set; }

    public virtual DbSet<RentalHistory> RentalHistories { get; set; }

    public virtual DbSet<TypeCar> TypeCars { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Addresse__3214EC07FB08A4AC");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Neighborhood).HasMaxLength(50);
            entity.Property(e => e.Street)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__Cars__68A0342EE9CFC4FA");

            entity.Property(e => e.Company)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ImageAvailable)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ImageNotAvailable)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.ImagePartiallyAvailable)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LockCode).HasColumnName("lockCode");

            entity.HasOne(d => d.AddressCodeNavigation).WithMany(p => p.Cars)
                .HasForeignKey(d => d.AddressCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_TO_Addresses");

            entity.HasOne(d => d.TypeCodeNavigation).WithMany(p => p.Cars)
                .HasForeignKey(d => d.TypeCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cars_TO_TypeCars");
        });

        modelBuilder.Entity<CarsRental>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CarsRent__3214EC07514141B1");

            entity.ToTable("CarsRental");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.CarCodeNavigation).WithMany(p => p.CarsRentals)
                .HasForeignKey(d => d.CarCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarsRental_TO_Cars");

            entity.HasOne(d => d.UserCodeNavigation).WithMany(p => p.CarsRentals)
                .HasForeignKey(d => d.UserCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CarsRental_TO_Users");
        });

        modelBuilder.Entity<PayDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__PayDetai__3214EC07E5C9F4FD");

            entity.Property(e => e.Cvv)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("CVV");
            entity.Property(e => e.Number)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Validity)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<RentalHistory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__RentalHi__3214EC0769CDE12E");

            entity.ToTable("RentalHistory");

            entity.Property(e => e.EndTime).HasColumnType("datetime");
            entity.Property(e => e.StartTime).HasColumnType("datetime");

            entity.HasOne(d => d.CarCodeNavigation).WithMany(p => p.RentalHistories)
                .HasForeignKey(d => d.CarCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentalHistory_TO_Cars");

            entity.HasOne(d => d.UserCodeNavigation).WithMany(p => p.RentalHistories)
                .HasForeignKey(d => d.UserCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_RentalHistory_TO_Users");
        });

        modelBuilder.Entity<TypeCar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TypeCars__3214EC07F5FCC523");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CC4C27033F6B");

            entity.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();

            entity.HasOne(d => d.AddressCodeNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.AddressCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_TO_Addresses");

            entity.HasOne(d => d.PaymentCodeNavigation).WithMany(p => p.Users)
                .HasForeignKey(d => d.PaymentCode)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Users_TO_PayDetails");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
