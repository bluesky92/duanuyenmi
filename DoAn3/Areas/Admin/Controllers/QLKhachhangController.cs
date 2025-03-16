using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;


namespace DoAn3.Areas.Admin.Controllers
{
    public class QLKhachhangController : Controller
    {
        private ModelPhone db = new ModelPhone();
        // GET: Admin/QLKhachhang
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Khachhang()
        {
            return View();
        }

        public JsonResult GetKh()
        {
            ModelPhone kh = new ModelPhone();
            List<Khachhang> emplist = kh.Khachhang.ToList();
            return Json(emplist, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Insertdata(Khachhang addem)
        {
            ModelPhone db = new ModelPhone();
            db.Khachhang.Add(addem);
            db.SaveChanges();
            return RedirectToAction("GetKh");
        }

        public ActionResult Updatedata(Khachhang em)
        {
            using (ModelPhone db = new ModelPhone())
            {
                Khachhang updatednd = (from c in db.Khachhang
                                    where c.makh == em.makh
                                    select c).FirstOrDefault();
                updatednd.tenkh = em.tenkh;
                updatednd.sdt = em.sdt;
                updatednd.diachi = em.diachi;
                db.SaveChanges();
            }

            return RedirectToAction("GetKh");
        }

        public ActionResult Deletedata(string makh)
        {
            using (ModelPhone db = new ModelPhone())
            {
                Khachhang em = (from c in db.Khachhang where c.makh == makh select c).FirstOrDefault();
                db.Khachhang.Remove(em);
                db.SaveChanges();
            }
            return RedirectToAction("GetKh");
        }
    }
}