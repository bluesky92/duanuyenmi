namespace DoAn3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TinTuc")]
    public partial class TinTuc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int matt { get; set; }

        [StringLength(20)]
        public string mltt { get; set; }

        [StringLength(200)]
        public string tieude { get; set; }

        [StringLength(50)]
        public string mand { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ngaydang { get; set; }

        [StringLength(300)]
        public string noidungdemo { get; set; }

        public string noidungchitiet { get; set; }

        [StringLength(60)]
        public string anh { get; set; }

        [StringLength(60)]
        public string anh1 { get; set; }

        [StringLength(60)]
        public string anh2 { get; set; }

        [StringLength(60)]
        public string anh3 { get; set; }

        [StringLength(60)]
        public string anh4 { get; set; }

        public virtual LoaiTinTuc LoaiTinTuc { get; set; }
        public virtual Ngdung Ngdung { get; set; }
    }
}
