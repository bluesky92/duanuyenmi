using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;

namespace DoAn3.Areas.Admin.Controllers
{
    public class QLNhacungcapController : Controller
    {
        private ModelPhone db = new ModelPhone();
        // GET: Admin/QLNhacungcap
        public ActionResult Index()
        {
            return View();  
        }
        public ActionResult Nhacungcap()
        {
            return View();
        }

        public JsonResult GetNcc()
        {
            ModelPhone ncc = new ModelPhone();

            //// Nếu mà có rất nhiều bản ghi thì nên dùng câu lệnh để lấy các trường trong bản ghi
            ////var emp = ncc.Database.SqlQuery<NhaCungCap>("Select masp,tensp from Nhacungcap").ToList();

            List<NhaCungCap> emplist = ncc.NhaCungCap.ToList();

            // Dòng lệnh gọi hàm lấy số từ trong chuỗi cần lấy
            ////foreach (var a in emplist)
            ////{
            ////    a.diachi = clsTools.ChuanHoa(a.diachi,1);
            ////}
            return Json(emplist, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Insertdata(NhaCungCap addem)
        {
            ModelPhone db = new ModelPhone();
            db.NhaCungCap.Add(addem);
            db.SaveChanges();
            return RedirectToAction("GetNcc");
        }

        public ActionResult Updatedata(NhaCungCap em)
        {
            using (ModelPhone db = new ModelPhone())
            {
                NhaCungCap updatednd = (from c in db.NhaCungCap
                                       where c.mancc == em.mancc
                                       select c).FirstOrDefault();
                updatednd.tenncc = em.tenncc;
                updatednd.sdt = em.sdt;
                updatednd.diachi = em.diachi;
                db.SaveChanges();
            }

            return RedirectToAction("GetNcc");
        }

        public ActionResult Deletedata(string mancc)
        {
            using (ModelPhone db = new ModelPhone())
            {
                NhaCungCap em = (from c in db.NhaCungCap where c.mancc == mancc select c).FirstOrDefault();
                db.NhaCungCap.Remove(em);
                db.SaveChanges();
            }
            return RedirectToAction("GetNcc");
        }
    }
}