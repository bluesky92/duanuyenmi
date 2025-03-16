namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Giaban")]
    public partial class Giaban
    {
        [Key]
        public int magb { get; set; }

        public int? masp { get; set; }

        [Column("giaban")]
        public int? giaban1 { get; set; }

        [StringLength(20)]
        public string ngaybd { get; set; }

        [StringLength(20)]
        public string ngaykt { get; set; }

        public virtual Dienthoai Dienthoai { get; set; }
    }
}
