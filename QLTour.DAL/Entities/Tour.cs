namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tour")]
    public partial class Tour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tour()
        {
            DatTours = new HashSet<DatTour>();
            Feedbacks = new HashSet<Feedback>();
        }

        [Key]
        public int MaTour { get; set; }

        [Required]
        [StringLength(255)]
        public string TenTour { get; set; }

        public string LichTrinh { get; set; }

        public decimal? GiaTien { get; set; }

        public string MoTa { get; set; }

        public int? TinhTrang { get; set; }

        public int? NhanVienID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatTour> DatTours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
