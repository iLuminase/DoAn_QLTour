namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DichVu")]
    public partial class DichVu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DichVu()
        {
            DatDichVus = new HashSet<DatDichVu>();
        }

        public int DichVuID { get; set; }

        [Required]
        [StringLength(100)]
        public string TenDichVu { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [StringLength(10)]
        public string TinhTrang { get; set; }

        public decimal GiaTien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatDichVu> DatDichVus { get; set; }
    }
}
