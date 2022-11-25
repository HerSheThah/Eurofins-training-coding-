using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVC_EFexample.Models
{
    public partial class companyContext : DbContext
    {
        public companyContext()
        {
        }

        public companyContext(DbContextOptions<companyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bonu> Bonus { get; set; } = null!;
        public virtual DbSet<DepartmentTable> DepartmentTables { get; set; } = null!;
        public virtual DbSet<EmployeeTable> EmployeeTables { get; set; } = null!;
        public virtual DbSet<Title> Titles { get; set; } = null!;
        public virtual DbSet<Userlogin> Userlogins { get; set; } = null!;
        public virtual DbSet<Worker> Workers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=company;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bonu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bonus");

                entity.Property(e => e.Bonusamt).HasColumnName("bonusamt");

                entity.Property(e => e.Workid).HasColumnName("workid");
            });

            modelBuilder.Entity<DepartmentTable>(entity =>
            {
                entity.HasKey(e => e.Deptid)
                    .HasName("PK__departme__BE2C1AEEF9D35584");

                entity.ToTable("departmentTable");

                entity.Property(e => e.Deptid)
                    .ValueGeneratedNever()
                    .HasColumnName("deptid");

                entity.Property(e => e.Deptname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("deptname");
            });

            modelBuilder.Entity<EmployeeTable>(entity =>
            {
                entity.HasKey(e => e.Empid)
                    .HasName("PK__Employee__AF4CE8651E9FBE1D");

                entity.ToTable("EmployeeTable");

                entity.Property(e => e.Empid)
                    .ValueGeneratedNever()
                    .HasColumnName("empid");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Empname)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("empname");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.EmployeeTables)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK__EmployeeT__depti__5EBF139D");
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("title");

                entity.Property(e => e.Affectedfrom)
                    .HasColumnType("datetime")
                    .HasColumnName("affectedfrom");

                entity.Property(e => e.Title1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.Workrefid).HasColumnName("workrefid");

                entity.HasOne(d => d.Workref)
                    .WithMany()
                    .HasForeignKey(d => d.Workrefid)
                    .HasConstraintName("FK__title__workrefid__276EDEB3");
            });

            modelBuilder.Entity<Userlogin>(entity =>
            {
                entity.HasKey(e => e.Userid)
                    .HasName("PK__Userlogi__CBA1B257D2BCA7CF");

                entity.ToTable("Userlogin");

                entity.Property(e => e.Userid)
                    .ValueGeneratedNever()
                    .HasColumnName("userid");

                entity.Property(e => e.Password)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.HasKey(e => e.Worderid)
                    .HasName("PK__worker__B1FAAE3E2BDF17C8");

                entity.ToTable("worker");

                entity.Property(e => e.Worderid)
                    .ValueGeneratedNever()
                    .HasColumnName("worderid");

                entity.Property(e => e.Dept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dept");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Joiningdate)
                    .HasColumnType("datetime")
                    .HasColumnName("joiningdate");

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Salary).HasColumnName("salary");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
