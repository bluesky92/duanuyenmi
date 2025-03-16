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
    public class QLDienthoaiController : Controller
    {
        private ModelPhone db = new ModelPhone();

        // GET: Admin/QLDienthoai
        public ActionResult Index()
        {
            var dienthoai = db.Dienthoai.Include(d => d.Danhmucsp);
            return View(dienthoai.ToList());
        }

        // GET: Admin/QLDienthoai/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dienthoai dienthoai = db.Dienthoai.Find(id);
            if (dienthoai == null)
            {
                return HttpNotFound();
            }   
            return View(dienthoai);
        }

        // GET: Admin/QLDienthoai/Create
        public ActionResult Create()
        {
            ViewBag.madm = new SelectList(db.Danhmucsp, "madm", "tendm");
            return View();
        }

        // POST: Admin/QLDienthoai/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "masp,madm,tensp,giasp,soluong,manhinh,chip,ram,rom,Camtrc,Camsau,pin,anh,hedh,thesim,giakm,thenho,cambien,gpu,timebh")] Dienthoai dienthoai)
        {
            if (ModelState.IsValid)
            {
                db.Dienthoai.Add(dienthoai);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.madm = new SelectList(db.Danhmucsp, "madm", "tendm", dienthoai.madm);
            return View(dienthoai);
        }

        // GET: Admin/QLDienthoai/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dienthoai dienthoai = db.Dienthoai.Find(id);
            if (dienthoai == null)
            {
                return HttpNotFound();
            }
            ViewBag.madm = new SelectList(db.Danhmucsp, "madm", "tendm", dienthoai.madm);
            return View(dienthoai);
        }

        // POST: Admin/QLDienthoai/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "masp,madm,tensp,giasp,soluong,manhinh,chip,ram,rom,Camtrc,Camsau,pin,anh,hedh,thesim,giakm,thenho,cambien,gpu,timebh")] Dienthoai dienthoai)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dienthoai).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.madm = new SelectList(db.Danhmucsp, "madm", "tendm", dienthoai.madm);
            return View(dienthoai);
        }

        // GET: Admin/QLDienthoai/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dienthoai dienthoai = db.Dienthoai.Find(id);
            if (dienthoai == null)
            {
                return HttpNotFound();
            }
            return View(dienthoai);
        }

        // POST: Admin/QLDienthoai/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dienthoai dienthoai = db.Dienthoai.Find(id);
            db.Dienthoai.Remove(dienthoai);
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
