namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        public int ThanhToanID { get; set; }

        public int MaDatTour { get; set; }

        public decimal SoTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThanhToan { get; set; }

        [Required]
        [StringLength(50)]
        public string PhuongThucThanhToan { get; set; }

        public virtual DatTour DatTour { get; set; }
    }
}
