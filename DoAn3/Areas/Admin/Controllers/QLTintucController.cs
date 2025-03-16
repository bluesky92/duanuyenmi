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
    public class QLTintucController : Controller
    {
        private ModelPhone db = new ModelPhone();

        // GET: Admin/QLTintuc
        public ActionResult Index()
        {
            var tinTucs = db.TinTuc.Include(t => t.LoaiTinTuc).Include(t => t.Ngdung);
            return View(tinTucs.ToList());
        }

        // GET: Admin/QLTintuc/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinTuc tinTuc = db.TinTuc.Find(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            ViewBag.mltt = new SelectList(db.LoaiTinTucs, "mltt", "tenloaitintuc", tinTuc.mltt);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", tinTuc.mand);

            return View(tinTuc);
        }

        // GET: Admin/QLTintuc/Create
        public ActionResult Create()
        {
            ViewBag.mltt = new SelectList(db.LoaiTinTucs, "mltt", "tenloaitintuc");
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan");
            return View();
        }

        // POST: Admin/QLTintuc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "matt,mltt,tieude,mand,ngaydang,noidungdemo,noidungchitiet,anh,anh1,anh2,anh3,anh4")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                db.TinTuc.Add(tinTuc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.mltt = new SelectList(db.LoaiTinTucs, "mltt", "tenloaitintuc", tinTuc.mltt);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", tinTuc.mand);
            return View(tinTuc);
        }

        // GET: Admin/QLTintuc/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinTuc tinTuc = db.TinTuc.Find(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            ViewBag.mltt = new SelectList(db.LoaiTinTucs, "mltt", "tenloaitintuc", tinTuc.mltt);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", tinTuc.mand);
            return View(tinTuc);
        }

        // POST: Admin/QLTintuc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "matt,mltt,tieude,mand,ngaydang,noidungdemo,noidungchitiet,anh,anh1,anh2,anh3,anh4")] TinTuc tinTuc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tinTuc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.mltt = new SelectList(db.LoaiTinTucs, "mltt", "tenloaitintuc", tinTuc.mltt);
            ViewBag.mand = new SelectList(db.Ngdung, "mand", "taikhoan", tinTuc.mand);
            return View(tinTuc);
        }

        // GET: Admin/QLTintuc/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TinTuc tinTuc = db.TinTuc.Find(id);
            if (tinTuc == null)
            {
                return HttpNotFound();
            }
            return View(tinTuc);
        }

        // POST: Admin/QLTintuc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TinTuc tinTuc = db.TinTuc.Find(id);
            db.TinTuc.Remove(tinTuc);
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
