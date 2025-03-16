namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiTinTuc")]
    public partial class LoaiTinTuc
    {
        [Key]
        [StringLength(20)]
        public string mltt { get; set; }

        [StringLength(50)]
        public string tenloaitintuc { get; set; }
        public virtual ICollection<TinTuc> TinTucs { get; set; }
    }
}
