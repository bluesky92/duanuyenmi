namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public NhaCungCap()
        //{
        //    Hoadonnhap = new HashSet<Hoadonnhap>();
        //}

        [Key]
        [StringLength(50)]
        public string mancc { get; set; }

        [StringLength(50)]
        public string tenncc { get; set; }

        [StringLength(50)]
        public string sdt { get; set; }

        [StringLength(50)]
        public string diachi { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Hoadonnhap> Hoadonnhap { get; set; }
        //public virtual ICollection<Dienthoai> Dienthoai { get; set; }

    }
}
