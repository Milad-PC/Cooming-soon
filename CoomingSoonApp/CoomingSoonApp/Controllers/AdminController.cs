using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CoomingSoonApp.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private MyContext _db = new MyContext();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.Email = _db.EmailRequests.Count();
            ViewBag.Request = _db.Requests.Count();

            return View();
        }
        public ActionResult Emails()
        {
            return View(_db.EmailRequests.OrderByDescending(o => o.ReqDate));
        }
        public ActionResult Requests()
        {
            return View(_db.Requests.OrderByDescending(o => o.RequestDate));
        }
        [HttpPost]
        public ActionResult DelReq(int id)
        {
            Request src = _db.Requests.Find(id);
            _db.Entry(src).State = System.Data.Entity.EntityState.Deleted;
            _db.SaveChanges();

            return RedirectToAction("Requests");
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login([Bind(Include = "UserName,Password")] Admins src)
        {
            if (_db.Admins.Any(u => u.UserName == src.UserName && u.Password == src.Password))
            {
                FormsAuthentication.SetAuthCookie(src.UserName, true);
                return RedirectToAction("Index");
            }
            ViewBag.Error = "User Not Found";
            return View();
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}