namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khachhang")]
    public partial class Khachhang
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Khachhang()
        //{
        //    ChitietGiohang = new HashSet<ChitietGiohang>();
        //    Donhang = new HashSet<Donhang>();
        //}

        [Key]
        [StringLength(20)]
        public string makh { get; set; }

        [StringLength(45)]
        public string tenkh { get; set; }

        [StringLength(11)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ChitietGiohang> ChitietGiohang { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Donhang> Donhang { get; set; }

        //public virtual Giohang Giohang { get; set; }
    }
}
