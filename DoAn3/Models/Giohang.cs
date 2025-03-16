namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Giohang")]
    public partial class Giohang
    {
        //[Key]
        //[StringLength(20)]
        //public string makh { get; set; }

        //public double? tongtien { get; set; }

        public string id { get; set; }
        public string tensp { get; set; }
        public string dongia { get; set; }
        public string giamgia { get; set; }
        public string soluong { get; set; }
        public string thanhtien { get; set; }
        public string anh { get; set; }

        //public virtual Khachhang Khachhang { get; set; }
        //public virtual ICollection<ChitietGiohang> Chitietgiohangs { get; set; }

    }
}
