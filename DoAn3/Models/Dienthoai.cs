namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dienthoai")]
    public partial class Dienthoai
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Dienthoai()
        //{
        //    Chitietddh = new HashSet<Chitietddh>();
        //    ChitietGiohang = new HashSet<ChitietGiohang>();
        //    Chitiethdn = new HashSet<Chitiethdn>();
        //    Giaban = new HashSet<Giaban>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int masp { get; set; }

        public int madm { get; set; }

        [StringLength(80)]
        [Required(ErrorMessage ="Không được để trống!")]
        public string tensp { get; set; }

        [Required(ErrorMessage = "Không được để trống!")]
        public int giasp { get; set; }

        [Required(ErrorMessage ="Không được để trống!")]
        public int soluong { get; set; }

        [StringLength(50)]
        public string manhinh { get; set; }

        [StringLength(50)]
        public string chip { get; set; }

        [StringLength(20)]
        public string ram { get; set; }

        [StringLength(20)]
        public string rom { get; set; }

        [StringLength(50)]
        public string Camtrc { get; set; }

        [StringLength(50)]
        public string Camsau { get; set; }

        [StringLength(50)]
        public string pin { get; set; }

        [StringLength(70)]
        public string anh { get; set; }

        [StringLength(50)]
        public string hedh { get; set; }

        [StringLength(50)]
        public string thesim { get; set; }

        public int giakm { get; set; }

        [StringLength(35)]
        public string thenho { get; set; }

        [StringLength(80)]
        public string cambien { get; set; }

        [StringLength(50)]
        public string gpu { get; set; }

        [StringLength(20)]
        public string timebh { get; set; }

        [StringLength(50)]
        public string mancc { get; set; }



        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Chitietddh> Chitietddh { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ChitietGiohang> ChitietGiohang { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Chitiethdn> Chitiethdn { get; set; }
        //public virtual Hoadonnhap Hoadonnhap{ get; set; }

        public virtual Danhmucsp Danhmucsp { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        //public virtual Giohang Giohang { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<Giaban> Giaban { get; set; }
    }
}
