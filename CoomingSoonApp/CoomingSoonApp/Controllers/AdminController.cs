using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CoomingSoonApp.Controllers
{
    public class AdminController : Controller
    {
        private MyContext _db = new MyContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Emails()
        {
            return View();
        }
        public ActionResult Requests()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login([Bind(Include = "UserName,Password")]Admins src)
        {
            if(_db.Admins.Any(u=>u.UserName == src.UserName && u.Password == src.Password))
            {
                FormsAuthentication.SetAuthCookie(src.UserName,true);
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