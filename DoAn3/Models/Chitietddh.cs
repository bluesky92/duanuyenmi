namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chitietddh")]
    public partial class Chitietddh
    {
        [Key]
        public string mactdh { get; set; }

        public string madh { get; set; }

        public int masp { get; set; }

        public int slmua { get; set; }

        public int dongia { get; set; }

        public int thanhtien { get; set; }


        public virtual Donhang Donhang { get; set; }

        public virtual Dienthoai Dienthoai { get; set; }
    }
}
