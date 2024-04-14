﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Session_8___test.Models
{
    public partial class EmployeeTestContext : DbContext
    {
        public EmployeeTestContext()
        {
        }

        public EmployeeTestContext(DbContextOptions<EmployeeTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Email> Emails { get; set; }
        public virtual DbSet<EmpDepartment> EmpDepartments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MICHAEL;Initial Catalog=EmployeeTest;Integrated Security=True;Encrypt=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Address__Employe__4316F928");

                entity.HasOne(d => d.PostalCodeNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PostalCode)
                    .HasConstraintName("FK__Address__PostalC__4222D4EF");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.PostalCode)
                    .HasName("PK__City__12D1DBD3299359D4");

                entity.ToTable("City");

                entity.Property(e => e.PostalCode).ValueGeneratedNever();

                entity.Property(e => e.City1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("City");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("Department");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Departments)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__Departmen__Compa__47DBAE45");
            });

            modelBuilder.Entity<Email>(entity =>
            {
                entity.ToTable("Email");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.Email1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Email");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Emails)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Email__EmployeeI__3D5E1FD2");
            });

            modelBuilder.Entity<EmpDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmpDepartment");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.HasOne(d => d.Department)
                    .WithMany()
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__EmpDepart__Depar__4AB81AF0");

                entity.HasOne(d => d.Employee)
                    .WithMany()
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__EmpDepart__Emplo__49C3F6B7");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PhoneNumber>(entity =>
            {
                entity.ToTable("PhoneNumber");

                entity.Property(e => e.PhoneNumberId).HasColumnName("PhoneNumberID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.PhoneNumber1).HasColumnName("PhoneNumber");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PhoneNumbers)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__PhoneNumb__Emplo__398D8EEE");
            });

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingGeneratedFunctions(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}