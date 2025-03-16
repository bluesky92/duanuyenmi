using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;
using PagedList;

namespace DoAn3.Controllers
{
    public class ProductController : Controller
    {
        ModelPhone db = new ModelPhone();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }   
        public ActionResult Category(int? page, int id)//int 
        {

            if (page == null) page = 1;
            var model = db.Dienthoai.Where(d => d.madm == id).OrderBy(d => d.masp);
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            return View((model.ToPagedList(pageNumber, pageSize)));

            //if (ma != 0)
            //{
            //    var model = db.Dienthoai.Where(d => d.madm == ma);
            //    return View(model);
            //}
            //return View();
        }

        public ActionResult Search(String mancc = "", int madm = 0, String Keywords = "")
        {
            if (mancc != "")
            {
                var model = db.Dienthoai.Where(d => d.mancc == mancc);
                return View(model);
            }
            else if (madm != 0)
            {
                var model = db.Dienthoai.Where(p => p.madm == madm);
                return View(model);
            }
            else if (Keywords != "")
            {
                var model = db.Dienthoai.Where(p => p.tensp.Contains(Keywords));
                return View(model);
            }
            return View(db.Dienthoai);
        }
        //[HttpGet]
        //public ActionResult giohang(int id, int soluong)
        //{
        //    List<Models.shopcart> gh = new List<shopcart>();
        //    var sanphams = db.Dienthoai.FirstOrDefault(d => d.masp == id);
        //    if (Session["giohang"] == null)
        //    {
        //        Models.shopcart sp = new shopcart()
        //        {
        //            id = sanphams.masp.ToString(),
        //            tensp = sanphams.tensp,
        //            dongia = sanphams.giasp.ToString(),
        //            soluong = soluong.ToString(),
        //            thanhtien = (sanphams.giasp * soluong).ToString(),
        //            anh = sanphams.anh
        //        };
        //        gh.Add(sp);
        //    }
        //    else
        //    {
        //        gh = (List<Models.shopcart>)Session["giohang"];
        //        var thuattoan = gh.FirstOrDefault(d => d.id == id.ToString());
        //        if (thuattoan != null)
        //        {
        //            thuattoan.soluong = (int.Parse(thuattoan.soluong) + soluong).ToString();
        //            thuattoan.thanhtien = (int.Parse(thuattoan.dongia) * int.Parse(thuattoan.soluong)).ToString();
        //        }
        //        else
        //        {
        //            Models.shopcart sp = new shopcart()
        //            {
        //                id = sanphams.masp.ToString(),
        //                tensp = sanphams.tensp,
        //                dongia = sanphams.giasp.ToString(),
        //                soluong = soluong.ToString(),
        //                thanhtien = (sanphams.giasp * soluong).ToString(),
        //                anh = sanphams.anh
        //            };
        //            gh.Add(sp);
        //        }
        //    }
        //    Session["giohang"] = gh;
        //    return RedirectToAction("Thanhtoanshow");
        //}
        //[HttpGet]
        //public ActionResult xoagiohangsp(string id)
        //{

        //    List<Models.shopcart> gh = (List<Models.shopcart>)Session["giohang"];
        //    var item = gh.FirstOrDefault(d => d.id == id);
        //    gh.Remove(item);
        //    Session["giohang"] = gh;
        //    return RedirectToAction("Thanhtoanshow");
        //}
        public ActionResult Thanhtoan()
        {
            var gh = (List<Models.shopcart>)Session["giohang"];
            return Json(gh, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Thanhtoanshow()
        {
            return View();
        }
        public ActionResult Detail( int id)
        {
            var model = db.Dienthoai.FirstOrDefault(s => s.masp == id);
            return View(model);
        }
    }
}