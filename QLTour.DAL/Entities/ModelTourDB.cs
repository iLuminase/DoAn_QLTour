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

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<ChiTietDatTour> ChiTietDatTour { get; set; }
        public virtual DbSet<DatDichVu> DatDichVu { get; set; }
        public virtual DbSet<DatTour> DatTour { get; set; }
        public virtual DbSet<DichVu> DichVu { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<KhachHangKhuyenMai> KhachHangKhuyenMai { get; set; }
        public virtual DbSet<KhuyenMai> KhuyenMai { get; set; }
        public virtual DbSet<NhanVien> NhanVien { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
        public virtual DbSet<ThanhToan> ThanhToan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

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

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.Tour)
                .WithOptional(e => e.NhanVien)
                .HasForeignKey(e => e.HuongDanVienID);

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
