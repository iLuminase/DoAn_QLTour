namespace QLTour.DAL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DeleteLog")]
    public partial class DeleteLog
    {
        [Key]
        public int LogID { get; set; }

        [StringLength(100)]
        public string TableName { get; set; }

        public int? DeletedRecordID { get; set; }

        public DateTime? DeletedTime { get; set; }

        [StringLength(100)]
        public string DeletedBy { get; set; }
    }
}
