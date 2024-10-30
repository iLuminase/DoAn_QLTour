namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            ChiTietDatTours = new HashSet<ChiTietDatTour>();
            Feedbacks = new HashSet<Feedback>();
        }

        [Key]

        public int MaKhachHang { get; set; }
    public string HoTen { get; set; }
    public string SoDienThoai { get; set; }
    public string Email { get; set; }
    public string DiaChi { get; set; }
    public string CMND { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDatTour> ChiTietDatTours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }

  
    }
}
