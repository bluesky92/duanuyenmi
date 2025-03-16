namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Donhang")]
    public partial class Donhang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        ////public Donhang()
        ////{
        ////    Chitietddh = new HashSet<Chitietddh>();
        ////}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [StringLength(100)]
        public string madh { get; set; }

        [StringLength(20)]
        public string makh { get; set; }

        public DateTime ngaylap { get; set; }

        public int tongtien { get; set; }

        [StringLength(50)]
        public string noinhan { get; set; }

        [StringLength(50)]
        public string mand { get; set; }

        [StringLength(50)]
        public string ghichu { get; set; }

        [StringLength(50)]
        public string hovaten { get; set; }

        [StringLength(200)]
        public string diachikhachhang { get; set; }

        [StringLength(200)]
        public string diachigiaohang { get; set; }

        [StringLength(20)]
        public string sodienthoaikhachhang { get; set; }

        [StringLength(20)]
        public string sdtnguoinhan { get; set; }

        [StringLength(20)]
        public string socmtndkh { get; set; }

        [StringLength(20)]
        public string socmtndnguoinhan { get; set; }

        [StringLength(20)]
        public string taikhoan { get; set; }

        public int trangthaidonhang { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        ////public virtual ICollection<Chitietddh> Chitietddh { get; set; }

        //public virtual Chitietddh Chitietddh1 { get; set; }

        public virtual Khachhang Khachhang { get; set; }

        public virtual Ngdung Ngdung { get; set; }
    }
}
