using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAn3.Models
{
    public class RegisterModel
    {
        [Key]
        public string mand { set; get; }

        [Display(Name = "Tài Khoản")]
        [Required(ErrorMessage = "Bạn phải nhập tài khoản!")]
        [StringLength(20)]
        public string taikhoan { set; get; }

        [Display(Name = "Mật khẩu")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Độ dài mật khẩu ít nhất 6 ký tự!")]
        [Required(ErrorMessage = "Bạn phải nhập mật khẩu!")]
        public string matkhau { set; get; }

        [Display(Name = "Xác nhận mật khẩu")]
        [Compare("matkhau", ErrorMessage = "Xác nhận mật khẩu không đúng!")]
        public string Confirmmatkhau { set; get; }

        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Yêu cầu nhập họ tên!")]
        public string tennd { set; get; }

        [Display(Name = "Số Điện Thoại")]
        [StringLength(10, ErrorMessage = "Số điện thoại chỉ có 10 số!")]
        public string sdt { set; get; }

        [Display(Name = "Địa chỉ")]
        public string diachi { set; get; }        
    }
}