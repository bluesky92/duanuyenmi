using DoAn3.Common;
using DoAn3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                //var result = dao.Login(model.taikhoan, Encryptor.MD5Hash(model.matkhau));
                var result = dao.Login(model.taikhoan, model.matkhau);
                if (result == 1)
                {
                    var user = dao.GetById(model.taikhoan);
                    var userSession = new UserLogin();
                    userSession.UserName = user.taikhoan;
                    userSession.UserID = user.mand;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại.");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đang bị khoá.");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng.");
                }
                else
                {
                    ModelState.AddModelError("", "đăng nhập không đúng.");
                }
            }
            return View(model);
        }
        public ActionResult Forgot()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterModel Model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckUserName(Model.taikhoan))
                {
                    ModelState.AddModelError("", "Tài khoản này đã tồn tại!");
                }
                else
                {
                    var user = new Ngdung();
                    user.tennd = Model.tennd;
                    user.matkhau = Model.matkhau;
                    user.sdt = Model.sdt;
                    user.diachi = Model.diachi;
                    var kq = dao.Insert(user);
                    if (kq !="")
                    {
                        ViewBag.Success = "Chúc mừng. Bạn đã đăng ký thành công !";
                        Model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công!");
                    }
                }
            }
            return View();
        }
    }
}