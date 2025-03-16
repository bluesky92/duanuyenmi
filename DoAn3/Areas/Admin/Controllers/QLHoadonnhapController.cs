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
    public class QLHoadonnhapController : Controller
    {
        private ModelPhone db = new ModelPhone();

        // GET: Admin/QLHoadonnhap
        public ActionResult Index()
        {
            var hoadon = db.Hoadonnhap.Include(n => n.NhaCungCap);
            //var hoadon = db.Hoadonnhap.Include(h => h.Dienthoai);
            return View(hoadon.ToList());
        }

        // GET: Admin/QLHoadonnhap/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoadonnhap hoadonnhap = db.Hoadonnhap.Find(id);
            if (hoadonnhap == null)
            {
                return HttpNotFound();
            }
            return View(hoadonnhap);
        }

        // GET: Admin/QLHoadonnhap/Create
        public ActionResult Create()
        {
            //ViewBag.mancc = new SelectList(db.NhaCungCap, "mancc", "tenncc");
            ViewBag.masp = new SelectList(db.Dienthoai, "masp", "tensp");
            return View();
        }

        // POST: Admin/QLHoadonnhap/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "mahdn,masp,mancc,mand,soluong,gianhap,NgayNhap")] Hoadonnhap hoadonnhap)
        {
            if (ModelState.IsValid)
            {
                db.Hoadonnhap.Add(hoadonnhap);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.masp = new SelectList(db.Dienthoai, "masp", "tensp", hoadonnhap.masp);
            return View(hoadonnhap);
        }

        // GET: Admin/QLHoadonnhap/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoadonnhap hoadonnhap = db.Hoadonnhap.Find(id);
            if (hoadonnhap == null)
            {
                return HttpNotFound();
            }
            ViewBag.masp = new SelectList(db.Dienthoai, "masp", "tensp", hoadonnhap.masp);
            return View(hoadonnhap);
        }

        // POST: Admin/QLHoadonnhap/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "mahdn,masp,mancc,mand,soluong,gianhap,NgayNhap")] Hoadonnhap hoadonnhap)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoadonnhap).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.masp = new SelectList(db.Dienthoai, "masp", "tensp", hoadonnhap.masp);
            return View(hoadonnhap);
        }

        // GET: Admin/QLHoadonnhap/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hoadonnhap hoadonnhap = db.Hoadonnhap.Find(id);
            if (hoadonnhap == null)
            {
                return HttpNotFound();
            }
            return View(hoadonnhap);
        }

        // POST: Admin/QLHoadonnhap/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hoadonnhap hoadonnhap = db.Hoadonnhap.Find(id);
            db.Hoadonnhap.Remove(hoadonnhap);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
