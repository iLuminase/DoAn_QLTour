using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLTour.DAL.Entities
{
    public partial class ModelTourDB : DbContext
    {
        public ModelTourDB()
            : base("name=ModelTourDB")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ChiTietDatTour> ChiTietDatTours { get; set; }
        public virtual DbSet<DatDichVu> DatDichVus { get; set; }
        public virtual DbSet<DatTour> DatTours { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<Feedback> Feedbacks { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<KhachHangKhuyenMai> KhachHangKhuyenMais { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMais { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .HasMany(e => e.KhachHang)
                .WithRequired(e => e.Account)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatTour>()
                .HasMany(e => e.ChiTietDatTour)
                .WithRequired(e => e.DatTour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatTour>()
                .HasMany(e => e.DatDichVu)
                .WithRequired(e => e.DatTour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatTour>()
                .HasMany(e => e.KhachHangKhuyenMai)
                .WithRequired(e => e.DatTour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DatTour>()
                .HasMany(e => e.ThanhToan)
                .WithRequired(e => e.DatTour)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.DatDichVu)
                .WithRequired(e => e.DichVu)
                .HasForeignKey(e => e.MaDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.ChiTietDatTour)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.Feedback)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhuyenMai>()
                .Property(e => e.GiaTriKhuyenMai)
                .HasPrecision(5, 2);

            modelBuilder.Entity<KhuyenMai>()
                .HasMany(e => e.KhachHangKhuyenMai)
                .WithRequired(e => e.KhuyenMai)
                .HasForeignKey(e => e.MaKhuyenMai)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Account)
                .WithRequired(e => e.Role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tour>()
                .HasMany(e => e.Feedback)
                .WithRequired(e => e.Tour)
                .WillCascadeOnDelete(false);
        }
    }
}
