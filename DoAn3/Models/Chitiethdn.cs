namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitiethdn")]
    public partial class Chitiethdn
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int macthdn { get; set; }

        public int? mahdn { get; set; }

        public int? masp { get; set; }

        public int? soluong { get; set; }

        public int? gianhap { get; set; }

        public virtual Hoadonnhap Hoadonnhap { get; set; }

        public virtual Dienthoai Dienthoai { get; set; }
    }
}
