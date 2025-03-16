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
    public class QLDonhangController : Controller
    {
        private ModelPhone db = new ModelPhone();

        // GET: Admin/QLDonhang
        public ActionResult Index()
        {
            var donhang = db.Donhang.Include(d => d.Khachhang).Include(d => d.Ngdung);
            return View(donhang.ToList());
        }

        // GET: Admin/QLDonhang/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhang.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }

        // GET: Admin/QLDonhang/Create
        public ActionResult Create()
        {
            ViewBag.makh = new SelectList(db.Khachhang, "makh", "tenkh");
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan");
            return View();
        }

        // POST: Admin/QLDonhang/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "makh,ngaylap,tongtien,noinhan,mand,ghichu,hovaten,diachikhachhang,diachigiaohang,sodienthoaikhachhang,sdtnguoinhan,socmtndkh,socmtndnguoinhan,taikhoan,trangthaidonhang")] Donhang donhang)
        {
            if (ModelState.IsValid)
            {
                db.Donhang.Add(donhang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.makh = new SelectList(db.Khachhang, "makh", "tenkh", donhang.makh);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", donhang.mand);
            return View(donhang);
        }

        // GET: Admin/QLDonhang/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhang.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            ViewBag.makh = new SelectList(db.Khachhang, "makh", "tenkh", donhang.makh);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", donhang.mand);
            return View(donhang);
        }

        // POST: Admin/QLDonhang/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "makh,ngaylap,tongtien,noinhan,mand,ghichu,hovaten,diachikhachhang,diachigiaohang,sodienthoaikhachhang,sdtnguoinhan,socmtndkh,socmtndnguoinhan,taikhoan,trangthaidonhang")] Donhang donhang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donhang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.makh = new SelectList(db.Khachhang, "makh", "tenkh", donhang.makh);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", donhang.mand);
            return View(donhang);
        }

        // GET: Admin/QLDonhang/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Donhang donhang = db.Donhang.Find(id);
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(donhang);
        }

        // POST: Admin/QLDonhang/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Donhang donhang = db.Donhang.Find(id);
            db.Donhang.Remove(donhang);
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
