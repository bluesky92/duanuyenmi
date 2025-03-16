using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAn3.Areas.Admin.Models
{
    public class LoginModel1
    {
        [Required(ErrorMessage = "Mời nhập tài khoản")]
        public string taikhoan { set; get; }

        [Required(ErrorMessage = "Mời nhập mật khẩu")]
        public string matkhau { set; get; }

        public bool RememberMe { set; get; }
    }
}