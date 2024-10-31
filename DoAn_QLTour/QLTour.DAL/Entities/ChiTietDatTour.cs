namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDatTour")]
    public partial class ChiTietDatTour
    {
        [Key]
        public int MaChiTietDatTour { get; set; }

        public int MaKhachHang { get; set; }

        public int MaDatTour { get; set; }

        public int? SoLuongNguoiDat { get; set; }

        public decimal? SoTienCoc { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual DatTour DatTour { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
