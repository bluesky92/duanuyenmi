namespace DoAn3.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Collections.Generic;

    public partial class ModelPhone : DbContext
    {
        public ModelPhone()
            : base("name=ModelPhone1")
        {
        }

        public virtual DbSet<Chitietddh> Chitietddh { get; set; }
        public virtual DbSet<ChitietGiohang> ChitietGiohangs { get; set; }
        public virtual DbSet<Chitiethdn> Chitiethdn { get; set; }
        public virtual DbSet<Danhmucsp> Danhmucsp { get; set; }
        public virtual DbSet<Dienthoai> Dienthoai { get; set; }
        public virtual DbSet<Donhang> Donhang { get; set; }
        public virtual DbSet<Giaban> Giaban { get; set; }
        public virtual DbSet<Giohang> Giohangs { get; set; }
        public virtual DbSet<Hoadonnhap> Hoadonnhap { get; set; }
        public virtual DbSet<Khachhang> Khachhang { get; set; }
        public virtual DbSet<Ngdung> Ngdung { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCap { get; set; }
        public virtual DbSet<TinTuc> TinTuc { get; set; }
        public IEnumerable<object> LoaiTinTuc { get; set; }

        public System.Data.Entity.DbSet<DoAn3.Models.LoaiTinTuc> LoaiTinTucs { get; set; }

        public System.Data.Entity.DbSet<DoAn3.Models.shopcart> shopcarts { get; set; }

        public System.Data.Entity.DbSet<DoAn3.Models.RegisterModel> RegisterModels { get; set; }

        public System.Data.Entity.DbSet<DoAn3.Models.LoginModel> LoginModels { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Dienthoai>()
        //        .Property(e => e.manhinh)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Dienthoai>()
        //        .Property(e => e.Camtrc)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Dienthoai>()
        //        .Property(e => e.Camsau)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Dienthoai>()
        //        .HasMany(e => e.ChitietGiohang)
        //        .WithRequired(e => e.Dienthoai)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Khachhang>()
        //        .Property(e => e.sdt)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<Khachhang>()
        //        .HasMany(e => e.ChitietGiohang)
        //        .WithRequired(e => e.Khachhang)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<Khachhang>()
        //        .HasOptional(e => e.Giohang)
        //        .WithRequired(e => e.Khachhang);
        //}
    }
}
