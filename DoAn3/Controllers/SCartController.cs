using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn3.Models;

namespace DoAn3.Controllers
{
    public class SCartController : Controller
    {
        // GET: SCart
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult giohang(string id, int soluong)
        {
            ModelPhone db = new ModelPhone();
            List<Models.shopcart> gh = new List<shopcart>();
            string sql = string.Format("select * from Dienthoai where [masp]='{0}'", id);
            var sanphams = db.Database.SqlQuery<Dienthoai>(sql).SingleOrDefault();
            if (Session["giohang"] == null)
            {

                Models.shopcart sp = new shopcart()
                {
                    id = sanphams.masp.ToString(),
                    tensp = sanphams.tensp,
                    dongia = sanphams.giakm.ToString(),
                    soluong = soluong.ToString(),
                    thanhtien = (sanphams.giakm * soluong).ToString(),
                    anh = sanphams.anh.ToString()
                };
                gh.Add(sp);
            }
            else
            {
                gh = (List<Models.shopcart>)Session["giohang"];
                var thuattoan = gh.FirstOrDefault(s => s.id == id);
                if (thuattoan != null)
                {
                    thuattoan.soluong = (int.Parse(thuattoan.soluong) + soluong).ToString();
                    thuattoan.thanhtien = (int.Parse(thuattoan.dongia.Replace(".", "")) * int.Parse(thuattoan.soluong)).ToString();
                }
                else
                {
                    Models.shopcart sp = new shopcart()
                    {
                        id = sanphams.masp.ToString(),
                        tensp = sanphams.tensp,
                        dongia = sanphams.giakm.ToString(),
                        soluong = soluong.ToString(),
                        thanhtien = (sanphams.giakm * soluong).ToString(),
                        anh = sanphams.anh.ToString()
                    };
                    gh.Add(sp);
                }
            }
            Session["giohang"] = gh;
            return RedirectToAction("Thanhtoanshow");
        }
        [HttpGet]
        public ActionResult xoagiohangsp(string id)
        {
            ModelPhone db = new ModelPhone();
            List<Models.shopcart> gh = (List<Models.shopcart>)Session["giohang"];
            var item = gh.FirstOrDefault(s => s.id == id);
            gh.Remove(item);
            Session["giohang"] = gh;
            return RedirectToAction("Thanhtoanshow");
        }
        public ActionResult Thanhtoan()
        {
            var gh = (List<Models.shopcart>)Session["giohang"];
            return Json(gh, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Thanhtoanshow()
        {

            return View();
        }
        public ActionResult xacnhanthanhtoan()
        {

            return View();
        }        
        [HttpPost]
        public ActionResult ghihoadon(string tenkh, string dc1, string dc2, string cmt1, string cmt2, string sdt1, string sdt2)
        {
            Guid getid = Guid.NewGuid();
            string id = getid.ToString();
            List<shopcart> gh = (List<shopcart>)Session["giohang"];
            int tongtien = 0;
            foreach (shopcart a in gh)
            {
                tongtien += int.Parse(a.thanhtien.ToString());
            }
            string makh = Session["name"] == null ? "kh0001" : Session["name"].ToString();
            string sql = string.Format("Insert Into Donhang (madh,makh,tongtien,ngaylap,hovaten,diachikhachhang,diachigiaohang,sodienthoaikhachhang,sdtnguoinhan,socmtndkh,socmtndnguoinhan,taikhoan,tongsotien,tienvat,trangthaidonhang)Values('{0}','{1}','{2}','{3}','{4}',N'{5}',N'{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}')",
                id, makh, tongtien, DateTime.Now.ToString("yyyy-MM-dd"), tenkh, dc1, dc2, sdt1, sdt2, cmt1, cmt2, "Nhanhang", (tongtien + tongtien * 10 / 100), tongtien * 10 / 100, 1);
            ModelPhone db = new ModelPhone();
            var kq = db.Database.ExecuteSqlCommand(sql);
            foreach (shopcart a in gh)
            {
                getid = Guid.NewGuid();
                sql = string.Format("Insert Into Chitietddh(madh,mactdh,masp,dongia,thanhtien) values ('{0}','{1}','{2}','{3}','{4}')", id, getid, a.id, a.dongia, a.thanhtien);
                kq = db.Database.ExecuteSqlCommand(sql);
            }
            return RedirectToAction("Index", "Home");
        }        
    }
}