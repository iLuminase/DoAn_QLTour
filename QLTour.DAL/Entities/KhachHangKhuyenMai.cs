namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHangKhuyenMai")]
    public partial class KhachHangKhuyenMai
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaKhuyenMai { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaDatTour { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySuDung { get; set; }

        public virtual DatTour DatTour { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
    }
}
