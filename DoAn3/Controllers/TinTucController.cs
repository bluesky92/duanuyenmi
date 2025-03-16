using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;

namespace DoAn3.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        ModelPhone db = new ModelPhone();
        public ActionResult Index()
        {
            var model = db.TinTuc.Take(4).ToList();            
            return View(model);
        }
        public ActionResult Chitiettintuc(int? id)
        {
            var model = db.TinTuc.FirstOrDefault(t => t.matt == id);
            return View(model);
        }
        public ActionResult Gioithieu()
        {           
            return View();
        }
    }
}