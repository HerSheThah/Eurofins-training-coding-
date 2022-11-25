using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Restaurantmanagementlibrary.Models
{
    public partial class restmanagementDBContext : DbContext
    {
        public restmanagementDBContext()
        {
        }

        public restmanagementDBContext(DbContextOptions<restmanagementDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Dinein> Dineins { get; set; } = null!;
        public virtual DbSet<MenuList> MenuLists { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=restmanagementDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.Catid)
                    .HasName("PK__Category__17B9D93E93E61109");

                entity.ToTable("Category");

                entity.Property(e => e.Catid)
                    .ValueGeneratedNever()
                    .HasColumnName("catid");

                entity.Property(e => e.Catname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("catname");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Custid)
                    .HasName("PK__Customer__973AFEFEA8FDE433");

                entity.ToTable("Customer");

                entity.Property(e => e.Custid)
                    .ValueGeneratedNever()
                    .HasColumnName("custid");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Fname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("fname");

                entity.Property(e => e.Lname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("lname");

                entity.Property(e => e.Phno).HasColumnName("phno");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sex");
            });

            modelBuilder.Entity<Dinein>(entity =>
            {
                entity.HasKey(e => e.Bookingid)
                    .HasName("PK__Dinein__C6D307051EA1BB40");

                entity.ToTable("Dinein");

                entity.Property(e => e.Bookingid)
                    .ValueGeneratedNever()
                    .HasColumnName("bookingid");

                entity.Property(e => e.Bookingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("bookingdate");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Tableno).HasColumnName("tableno");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Dineins)
                    .HasForeignKey(d => d.Custid)
                    .HasConstraintName("FK__Dinein__custid__286302EC");
            });

            modelBuilder.Entity<MenuList>(entity =>
            {
                entity.HasKey(e => e.Menuid)
                    .HasName("PK__MenuList__3B5F7D5CEF98045F");

                entity.ToTable("MenuList");

                entity.Property(e => e.Menuid)
                    .ValueGeneratedNever()
                    .HasColumnName("menuid");

                entity.Property(e => e.Catid).HasColumnName("catid");

                entity.Property(e => e.Menuname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("menuname");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.HasOne(d => d.Cat)
                    .WithMany(p => p.MenuLists)
                    .HasForeignKey(d => d.Catid)
                    .HasConstraintName("FK__MenuList__catid__2B3F6F97");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.Orderid)
                    .ValueGeneratedNever()
                    .HasColumnName("orderid");

                entity.Property(e => e.Custid).HasColumnName("custid");

                entity.Property(e => e.Menuid).HasColumnName("menuid");

                entity.Property(e => e.Orderdate)
                    .HasColumnType("datetime")
                    .HasColumnName("orderdate");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Totalprice).HasColumnName("totalprice");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Custid)
                    .HasConstraintName("FK__Orders__custid__2E1BDC42");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.Menuid)
                    .HasConstraintName("FK__Orders__menuid__2F10007B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
