using DiemThiHocSinhGioi.Models.DAO;
using DiemThiHocSinhGioi.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiemThiHocSinhGioi.Controllers
{
    public class HomeController : Controller
    {
        private DiemThi db = new DiemThi();
        public ActionResult Index()
        {
            return View();
        }
        [Route("xemdiem/{sobaodanh}/{matruong}")]
        [HttpGet]
        public ActionResult XemDiem(string sobaodanh, string matruong)
        {
            DiemHsGioi diem = db.DiemHsGiois.Where(s => s.SBD.Trim() == sobaodanh.Trim() && s.MaTruong.Trim() == matruong.Trim()).SingleOrDefault();
            if (diem == null)
            {
                return Json(new ReturnResults(404, "Không tìm thấy số báo danh. Vui lòng thử lại", null), JsonRequestBehavior.AllowGet);
            }
            return Json(new ReturnResults(200, "success", diem), JsonRequestBehavior.AllowGet);
        }
        [Route("dangnhap", Name = "dangnhap")]
        public ActionResult DangNhap()
        {
            return View();
        }
        [Route("requestLogin")]
        [HttpPost]
        public ActionResult RequestLogin(string username, string password)
        {
            string usernameSystem  = System.Configuration.ConfigurationManager.AppSettings["UsernameSystem"];
            string passwordSystem = System.Configuration.ConfigurationManager.AppSettings["PasswordSystem"];
            if (username.Trim() == usernameSystem && password.Trim() == passwordSystem)
            {
                Session.Add("USERSESSION", "Logined");
               
                return Json(new ReturnResults(200, "success", null), JsonRequestBehavior.AllowGet);
            }
            return Json(new ReturnResults(400, "Tên đăng nhập hoặc mật khẩu sai", null), JsonRequestBehavior.AllowGet);
        }
        [Route("logout", Name = "logout")]
        public ActionResult Logout()
        {
            Session.RemoveAll();
            return RedirectToRoute("dangnhap");
        }
    }
}