namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChitietGiohang")]
    public partial class ChitietGiohang
    {
        [Key]
        [Column(Order = 0)]
        public int masp { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string makh { get; set; }

        public int? soluong { get; set; }

        public int? dongia { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Giohang Giohang  { get; set; }

        public virtual Dienthoai Dienthoai { get; set; }
    }
}
