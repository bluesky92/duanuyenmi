namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Danhmucsp")]
    public partial class Danhmucsp
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Danhmucsp()
        //{
        //    Dienthoai = new HashSet<Dienthoai>();
        //}

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int madm { get; set; }

        [StringLength(50)]
        public string tendm { get; set; }

        [StringLength(50)]
        public string icon { get; set; }

        [StringLength(50)]
        public string tensection { get; set; }


        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Dienthoai> Dienthoai { get; set; }
    }
}
