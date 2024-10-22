namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Feedback")]
    public partial class Feedback
    {
        [Key]
        public int MaFeedback { get; set; }

        public int MaKhachHang { get; set; }

        public int MaTour { get; set; }

        public string NoiDung { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayPhanHoi { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
