namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatTour")]
    public partial class DatTour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatTour()
        {
            DatDichVus = new HashSet<DatDichVu>();
            KhachHangKhuyenMais = new HashSet<KhachHangKhuyenMai>();
            ThanhToans = new HashSet<ThanhToan>();
        }

        [Key]
        public int MaDatTour { get; set; }

        public int MaKhachHang { get; set; }

        public int MaTour { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDat { get; set; }

        public int? SoLuongNguoi { get; set; }

        public decimal? TongTien { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatDichVu> DatDichVus { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Tour Tour { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhachHangKhuyenMai> KhachHangKhuyenMais { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThanhToan> ThanhToans { get; set; }
    }
}