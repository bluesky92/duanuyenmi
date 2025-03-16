namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hoadonnhap")]
    public partial class Hoadonnhap
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Hoadonnhap()
        //{
        //    Chitiethdn = new HashSet<Chitiethdn>(); 
        //}

        [Key]
        public int mahdn { get; set; }

        [StringLength(50)]
        public string mancc { get; set; }

        public int masp { get; set; }

        [StringLength(50)]
        public string mand { get; set; }

        public int soluong { get; set; }

        public int gianhap { get; set; }

        //public double Thanhtien { get; set; }

        [StringLength(25)]
        public string NgayNhap { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Chitiethdn> Chitiethdn { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual Ngdung Ngdung { get; set; }

        public virtual Dienthoai Dienthoai { get; set; }
    }
}
