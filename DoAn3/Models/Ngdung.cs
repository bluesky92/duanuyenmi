namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ngdung")]
    public partial class Ngdung
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Ngdung()
        //{
        //    Donhang = new HashSet<Donhang>();
        //    Hoadonnhap = new HashSet<Hoadonnhap>();
        //    TinTuc = new HashSet<TinTuc>();
        //}

        [Key]
        [StringLength(50)]
        public string mand { get; set; }

        [StringLength(25)]
        public string taikhoan { get; set; }

        [StringLength(25)]
        public string matkhau { get; set; }

        [StringLength(45)]
        public string tennd { get; set; }

        [StringLength(10)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Donhang> Donhang { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Hoadonnhap> Hoadonnhap { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<TinTuc> TinTuc { get; set; }
    }
}
