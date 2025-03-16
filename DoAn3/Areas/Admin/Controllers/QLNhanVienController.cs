using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;

namespace DoAn3.Areas.Admin.Controllers
{
    public class QLNhanVienController : Controller
    {
        private ModelPhone db = new ModelPhone();
        // GET: Admin/QLNhanVien
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult getEmployee()
        //{
        //    using (DoAn3.Models.ModelPhone db = new Models.ModelPhone())
        //    {
        //        var ds = db.Ngdung.Select(s => new Nguoidung_test()
        //        {
        //            mand = s.mand,
        //            taikhoan = s.taikhoan,
        //            matkhau = s.matkhau,
        //            tennd = s.tennd,
        //            diachi = s.diachi,
        //            sdt = s.sdt.ToString(),
        //        }).ToList<Nguoidung_test>();

        //        return Json(ds, JsonRequestBehavior.AllowGet);
        //    }
        //}
        public ActionResult Ngdung()
        {
            return View();
        }

        public JsonResult GetNd()
        {
            ModelPhone nd = new ModelPhone();
            List<Ngdung> emplist = nd.Ngdung.ToList();
            return Json(emplist, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Insertdata(Ngdung addem)
        {
            ModelPhone db = new ModelPhone();
            db.Ngdung.Add(addem);
            db.SaveChanges();
            return RedirectToAction("GetNd");
        }

        public ActionResult Updatedata(Ngdung em)
        {
            using (ModelPhone db = new ModelPhone())
            {
                Ngdung updatednd = (from c in db.Ngdung
                                    where c.mand == em.mand
                                    select c).FirstOrDefault();
                updatednd.tennd = em.tennd;
                updatednd.taikhoan = em.taikhoan;
                updatednd.matkhau = em.matkhau;
                updatednd.diachi = em.diachi;
                updatednd.sdt = em.sdt;
                db.SaveChanges();
            }

            return RedirectToAction("GetNd");
        }

        public ActionResult Deletedata(string mand)
        {
            using (ModelPhone db = new ModelPhone())
            {
                Ngdung em = (from c in db.Ngdung where c.mand == mand select c).FirstOrDefault();
                db.Ngdung.Remove(em);
                db.SaveChanges();
            }
            return RedirectToAction("GetNd");
        }
    }
}