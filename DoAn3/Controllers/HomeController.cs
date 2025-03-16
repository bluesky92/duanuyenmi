using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;


namespace DoAn3.Controllers
{
    public class HomeController : Controller
    {
        ModelPhone db = new ModelPhone();
        public ActionResult Index()
        {
            // Câu truy vấn lấy sản phẩm theo loại
            //var sp = db.Database.SqlQuery<Dienthoai>("Select những trường cần lấy!");
            //foreach (Danhmucsp d in Dienthoai)
            //{
            //    string sql = string.Format("Select * from dienthoai where maloai ='{0}'",d.madm);
            //    var dt = db.Database.SqlQuery<Dienthoai>(sql).ToList() or SingleOrDefault;
            //    d.Dienthoai = dt;
            //}
            var model = db.Danhmucsp.Where(c => c.Dienthoai.Count>4).ToList();
            return View(model);
        }
        public ActionResult Search(){
            var name = Request["term"];

            var data = db.Dienthoai
                .Where(d => d.tensp.Contains(name))
                .Select(d => d.tensp).ToList();
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {        
            return View();
        }
        //[HttpPost]
        //public ActionResult Send(string name,string mobile, string address, string email, string content)
        //{
            //var feedback = new Feedback();
            //feedback.Name = name;
            //feedback.Email = email;
            //feedback.CreateDate = DateTime.Now;
            //feedback.Phone = mobile;
            //feedback.Content = content;
            //feedback.Address = address;
            //var id=new Contact().InsertFeedBack(feedback);
            //if (id > 0)
            //    return Json(new
            //    {
            //        status = true
            //    });
            //else
            //    return Json(new {
            //        status= false
            //    });
        //}

        public ActionResult Category()
        {
            var model = db.Danhmucsp;
            return PartialView("_Category",model);
        }
        /// <summary>
        /// //Lấy về sản phẩm có giá khuyến mại > 20tr; Guid để khi refresh nó ra sp khác
        /// </summary>
        /// <returns></returns>
        public ActionResult SaleOff()
        {
            var model = db.Dienthoai.Where(d=>d.giakm>20000000).OrderBy(d=>Guid.NewGuid()).Take(2);
            return PartialView("_SaleOff", model);
        }

        public ActionResult Special()
        {
            var model = db.Dienthoai.Where(d => d.giasp<19900000).Take(5);
            return PartialView("_BestSeller", model);
        }

    }
}