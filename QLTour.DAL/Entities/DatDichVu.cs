namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatDichVu")]
    public partial class DatDichVu
    {
        [Key]
        public int MaDatDichVu { get; set; }

        public int MaDatTour { get; set; }

        public int MaDichVu { get; set; }

        public int? SoLuong { get; set; }

        public virtual DatTour DatTour { get; set; }

        public virtual DichVu DichVu { get; set; }
    }
}
